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
    /// Amazon Timestream is a fast, scalable, fully managed time series database service
    /// that makes it easy to store and analyze trillions of time series data points per day.
    /// With Timestream, you can easily store and analyze IoT sensor data to derive insights
    /// from your IoT applications. You can analyze industrial telemetry to streamline equipment
    /// management and maintenance. You can also store and analyze log data and metrics to
    /// improve the performance and availability of your applications. Timestream is built
    /// from the ground up to effectively ingest, process, and store time series data. It
    /// organizes data to optimize query processing. It automatically scales based on the
    /// volume of data ingested and on the query volume to ensure you receive optimal performance
    /// while inserting and querying data. As your data grows over time, Timestream’s adaptive
    /// query processing engine spans across storage tiers to provide fast analysis while
    /// reducing costs.
    /// </summary>
    public partial class AmazonTimestreamWriteClient : AmazonServiceClient, IAmazonTimestreamWrite
    {
        private static IServiceMetadata serviceMetadata = new AmazonTimestreamWriteMetadata();
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

        #region  CreateDatabase


        /// <summary>
        /// Creates a new Timestream database. If the KMS key is not specified, the database will
        /// be encrypted with a Timestream managed KMS key located in your account. Refer to <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
        /// managed KMS keys</a> for more info. Service quotas apply. For more information, see
        /// <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatabase service method.</param>
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        public virtual CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request)
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
        /// be encrypted with a Timestream managed KMS key located in your account. Refer to <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
        /// managed KMS keys</a> for more info. Service quotas apply. For more information, see
        /// <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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


        /// <summary>
        /// The CreateTable operation adds a new table to an existing database in your account.
        /// In an AWS account, table names must be at least unique within each Region if they
        /// are in the same database. You may have identical table names in the same Region if
        /// the tables are in seperate databases. While creating the table, you must specify the
        /// table name, database name, and the retention properties. Service quotas apply. For
        /// more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual CreateTableResponse CreateTable(CreateTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<CreateTableResponse>(request, options);
        }


        /// <summary>
        /// The CreateTable operation adds a new table to an existing database in your account.
        /// In an AWS account, table names must be at least unique within each Region if they
        /// are in the same database. You may have identical table names in the same Region if
        /// the tables are in seperate databases. While creating the table, you must specify the
        /// table name, database name, and the retention properties. Service quotas apply. For
        /// more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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


        /// <summary>
        /// Deletes a given Timestream database. <i>This is an irreversible operation. After a
        /// database is deleted, the time series data from its tables cannot be recovered.</i>
        /// 
        /// 
        ///  
        /// <para>
        /// All tables in the database must be deleted first, or a ValidationException error will
        /// be thrown. 
        /// </para>
        ///  
        /// <para>
        /// Due to the nature of distributed retries, the operation can return either success
        /// or a ResourceNotFoundException. Clients should consider them equivalent.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatabase service method.</param>
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        public virtual DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request)
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
        /// database is deleted, the time series data from its tables cannot be recovered.</i>
        /// 
        /// 
        ///  
        /// <para>
        /// All tables in the database must be deleted first, or a ValidationException error will
        /// be thrown. 
        /// </para>
        ///  
        /// <para>
        /// Due to the nature of distributed retries, the operation can return either success
        /// or a ResourceNotFoundException. Clients should consider them equivalent.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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


        /// <summary>
        /// Deletes a given Timestream table. This is an irreversible operation. After a Timestream
        /// database table is deleted, the time series data stored in the table cannot be recovered.
        /// 
        /// 
        ///  
        /// <para>
        /// Due to the nature of distributed retries, the operation can return either success
        /// or a ResourceNotFoundException. Clients should consider them equivalent.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual DeleteTableResponse DeleteTable(DeleteTableRequest request)
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
        /// database table is deleted, the time series data stored in the table cannot be recovered.
        /// 
        /// 
        ///  
        /// <para>
        /// Due to the nature of distributed retries, the operation can return either success
        /// or a ResourceNotFoundException. Clients should consider them equivalent.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        
        #region  DescribeDatabase


        /// <summary>
        /// Returns information about the database, including the database name, time that the
        /// database was created, and the total number of tables found within the database. Service
        /// quotas apply. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatabase service method.</param>
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeDatabase">REST API Reference for DescribeDatabase Operation</seealso>
        public virtual DescribeDatabaseResponse DescribeDatabase(DescribeDatabaseRequest request)
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
        /// database was created, and the total number of tables found within the database. Service
        /// quotas apply. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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


        /// <summary>
        /// DescribeEndpoints returns a list of available endpoints to make Timestream API calls
        /// against. This API is available through both Write and Query.
        /// 
        ///  
        /// <para>
        /// Because Timestream’s SDKs are designed to transparently work with the service’s architecture,
        /// including the management and mapping of the service endpoints, <i>it is not recommended
        /// that you use this API unless</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your application uses a programming language that does not yet have SDK support
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You require better control over the client-side implementation
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For detailed information on how to use DescribeEndpoints, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/Using-API.endpoint-discovery.html">The
        /// Endpoint Discovery Pattern and REST APIs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        public virtual DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointsResponse>(request, options);
        }


        /// <summary>
        /// DescribeEndpoints returns a list of available endpoints to make Timestream API calls
        /// against. This API is available through both Write and Query.
        /// 
        ///  
        /// <para>
        /// Because Timestream’s SDKs are designed to transparently work with the service’s architecture,
        /// including the management and mapping of the service endpoints, <i>it is not recommended
        /// that you use this API unless</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your application uses a programming language that does not yet have SDK support
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You require better control over the client-side implementation
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For detailed information on how to use DescribeEndpoints, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/Using-API.endpoint-discovery.html">The
        /// Endpoint Discovery Pattern and REST APIs</a>.
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
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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


        /// <summary>
        /// Returns information about the table, including the table name, database name, retention
        /// duration of the memory store and the magnetic store. Service quotas apply. For more
        /// information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTable service method.</param>
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        public virtual DescribeTableResponse DescribeTable(DescribeTableRequest request)
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
        /// duration of the memory store and the magnetic store. Service quotas apply. For more
        /// information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        
        #region  ListDatabases


        /// <summary>
        /// Returns a list of your Timestream databases. Service quotas apply. For more information,
        /// see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        public virtual ListDatabasesResponse ListDatabases(ListDatabasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatabasesResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListDatabasesEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ListDatabasesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of your Timestream databases. Service quotas apply. For more information,
        /// see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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


        /// <summary>
        /// A list of tables, along with the name, status and retention properties of each table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual ListTablesResponse ListTables(ListTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListTablesEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ListTablesResponse>(request, options);
        }


        /// <summary>
        /// A list of tables, along with the name, status and retention properties of each table.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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


        /// <summary>
        /// List all tags on a Timestream resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListTagsForResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// List all tags on a Timestream resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        
        #region  TagResource


        /// <summary>
        /// Associate a set of tags with a Timestream resource. You can then activate these user-defined
        /// tags so that they appear on the Billing and Cost Management console for cost allocation
        /// tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = TagResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Associate a set of tags with a Timestream resource. You can then activate these user-defined
        /// tags so that they appear on the Billing and Cost Management console for cost allocation
        /// tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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


        /// <summary>
        /// Removes the association of tags from a Timestream resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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


        /// <summary>
        /// Modifies the KMS key for an existing database. While updating the database, you must
        /// specify the database name and the identifier of the new KMS key to be used (<code>KmsKeyId</code>).
        /// If there are any concurrent <code>UpdateDatabase</code> requests, first writer wins.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatabase service method.</param>
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        public virtual UpdateDatabaseResponse UpdateDatabase(UpdateDatabaseRequest request)
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        /// Service quotas apply. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable service method.</param>
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual UpdateTableResponse UpdateTable(UpdateTableRequest request)
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
        /// Service quotas apply. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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


        /// <summary>
        /// The WriteRecords operation enables you to write your time series data into Timestream.
        /// You can specify a single data point or a batch of data points to be inserted into
        /// the system. Timestream offers you with a flexible schema that auto detects the column
        /// names and data types for your Timestream tables based on the dimension names and data
        /// types of the data points you specify when invoking writes into the database. Timestream
        /// support eventual consistency read semantics. This means that when you query data immediately
        /// after writing a batch of data into Timestream, the query results might not reflect
        /// the results of a recently completed write operation. The results may also include
        /// some stale data. If you repeat the query request after a short time, the results should
        /// return the latest data. Service quotas apply. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the WriteRecords service method.</param>
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.RejectedRecordsException">
        /// WriteRecords would throw this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  Records with duplicate data where there are multiple records with the same dimensions,
        /// timestamps, and measure names but different measure values. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Records with timestamps that lie outside the retention duration of the memory store
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Records with dimensions or measures that exceed the Timestream defined limits. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/WriteRecords">REST API Reference for WriteRecords Operation</seealso>
        public virtual WriteRecordsResponse WriteRecords(WriteRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = WriteRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = WriteRecordsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = WriteRecordsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<WriteRecordsResponse>(request, options);
        }


        /// <summary>
        /// The WriteRecords operation enables you to write your time series data into Timestream.
        /// You can specify a single data point or a batch of data points to be inserted into
        /// the system. Timestream offers you with a flexible schema that auto detects the column
        /// names and data types for your Timestream tables based on the dimension names and data
        /// types of the data points you specify when invoking writes into the database. Timestream
        /// support eventual consistency read semantics. This means that when you query data immediately
        /// after writing a batch of data into Timestream, the query results might not reflect
        /// the results of a recently completed write operation. The results may also include
        /// some stale data. If you repeat the query request after a short time, the results should
        /// return the latest data. Service quotas apply. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.RejectedRecordsException">
        /// WriteRecords would throw this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  Records with duplicate data where there are multiple records with the same dimensions,
        /// timestamps, and measure names but different measure values. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Records with timestamps that lie outside the retention duration of the memory store
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Records with dimensions or measures that exceed the Timestream defined limits. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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