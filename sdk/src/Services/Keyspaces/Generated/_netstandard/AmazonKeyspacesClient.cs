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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Keyspaces.Model;
using Amazon.Keyspaces.Model.Internal.MarshallTransformations;
using Amazon.Keyspaces.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Keyspaces
{
    /// <summary>
    /// Implementation for accessing Keyspaces
    ///
    /// Amazon Keyspaces (for Apache Cassandra) is a scalable, highly available, and managed
    /// Apache Cassandra-compatible database service. Amazon Keyspaces makes it easy to migrate,
    /// run, and scale Cassandra workloads in the Amazon Web Services Cloud. With just a few
    /// clicks on the Amazon Web Services Management Console or a few lines of code, you can
    /// create keyspaces and tables in Amazon Keyspaces, without deploying any infrastructure
    /// or installing software. 
    /// 
    ///  
    /// <para>
    /// In addition to supporting Cassandra Query Language (CQL) requests via open-source
    /// Cassandra drivers, Amazon Keyspaces supports data definition language (DDL) operations
    /// to manage keyspaces and tables using the Amazon Web Services SDK and CLI, as well
    /// as infrastructure as code (IaC) services and tools such as CloudFormation and Terraform.
    /// This API reference describes the supported DDL operations in detail.
    /// </para>
    ///  
    /// <para>
    /// For the list of all supported CQL APIs, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/cassandra-apis.html">Supported
    /// Cassandra APIs, operations, and data types in Amazon Keyspaces</a> in the <i>Amazon
    /// Keyspaces Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To learn how Amazon Keyspaces API actions are recorded with CloudTrail, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/logging-using-cloudtrail.html#service-name-info-in-cloudtrail">Amazon
    /// Keyspaces information in CloudTrail</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about Amazon Web Services APIs, for example how to implement
    /// retry logic or how to sign Amazon Web Services API requests, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-apis.html">Amazon
    /// Web Services APIs</a> in the <i>General Reference</i>.
    /// </para>
    /// </summary>
    public partial class AmazonKeyspacesClient : AmazonServiceClient, IAmazonKeyspaces
    {
        private static IServiceMetadata serviceMetadata = new AmazonKeyspacesMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonKeyspacesClient with the credentials loaded from the application's
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
        public AmazonKeyspacesClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyspacesConfig()) { }

        /// <summary>
        /// Constructs AmazonKeyspacesClient with the credentials loaded from the application's
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
        public AmazonKeyspacesClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyspacesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKeyspacesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKeyspacesClient Configuration Object</param>
        public AmazonKeyspacesClient(AmazonKeyspacesConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonKeyspacesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKeyspacesClient(AWSCredentials credentials)
            : this(credentials, new AmazonKeyspacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyspacesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKeyspacesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesClient with AWS Credentials and an
        /// AmazonKeyspacesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKeyspacesClient Configuration Object</param>
        public AmazonKeyspacesClient(AWSCredentials credentials, AmazonKeyspacesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKeyspacesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyspacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyspacesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyspacesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyspacesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKeyspacesClient Configuration Object</param>
        public AmazonKeyspacesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKeyspacesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKeyspacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyspacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyspacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyspacesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyspacesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKeyspacesClient Configuration Object</param>
        public AmazonKeyspacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKeyspacesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IKeyspacesPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IKeyspacesPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new KeyspacesPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKeyspacesEndpointResolver());
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


        #region  CreateKeyspace

        internal virtual CreateKeyspaceResponse CreateKeyspace(CreateKeyspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyspaceResponseUnmarshaller.Instance;

            return Invoke<CreateKeyspaceResponse>(request, options);
        }



        /// <summary>
        /// The <code>CreateKeyspace</code> operation adds a new keyspace to your account. In
        /// an Amazon Web Services account, keyspace names must be unique within each Region.
        /// 
        ///  
        /// <para>
        ///  <code>CreateKeyspace</code> is an asynchronous operation. You can monitor the creation
        /// status of the new keyspace by using the <code>GetKeyspace</code> operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/working-with-keyspaces.html#keyspaces-create">Creating
        /// keyspaces</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces could not complete the requested action. This error may occur if
        /// you try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/CreateKeyspace">REST API Reference for CreateKeyspace Operation</seealso>
        public virtual Task<CreateKeyspaceResponse> CreateKeyspaceAsync(CreateKeyspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyspaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyspaceResponse>(request, options, cancellationToken);
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
        /// The <code>CreateTable</code> operation adds a new table to the specified keyspace.
        /// Within a keyspace, table names must be unique.
        /// 
        ///  
        /// <para>
        ///  <code>CreateTable</code> is an asynchronous operation. When the request is received,
        /// the status of the table is set to <code>CREATING</code>. You can monitor the creation
        /// status of the new table by using the <code>GetTable</code> operation, which returns
        /// the current <code>status</code> of the table. You can start using a table when the
        /// status is <code>ACTIVE</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/working-with-tables.html#tables-create">Creating
        /// tables</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces could not complete the requested action. This error may occur if
        /// you try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace or table that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <code>ACTIVE</code>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteKeyspace

        internal virtual DeleteKeyspaceResponse DeleteKeyspace(DeleteKeyspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyspaceResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyspaceResponse>(request, options);
        }



        /// <summary>
        /// The <code>DeleteKeyspace</code> operation deletes a keyspace and all of its tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces could not complete the requested action. This error may occur if
        /// you try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace or table that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <code>ACTIVE</code>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/DeleteKeyspace">REST API Reference for DeleteKeyspace Operation</seealso>
        public virtual Task<DeleteKeyspaceResponse> DeleteKeyspaceAsync(DeleteKeyspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyspaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKeyspaceResponse>(request, options, cancellationToken);
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
        /// The <code>DeleteTable</code> operation deletes a table and all of its data. After
        /// a <code>DeleteTable</code> request is received, the specified table is in the <code>DELETING</code>
        /// state until Amazon Keyspaces completes the deletion. If the table is in the <code>ACTIVE</code>
        /// state, you can delete it. If a table is either in the <code>CREATING</code> or <code>UPDATING</code>
        /// states, then Amazon Keyspaces returns a <code>ResourceInUseException</code>. If the
        /// specified table does not exist, Amazon Keyspaces returns a <code>ResourceNotFoundException</code>.
        /// If the table is already in the <code>DELETING</code> state, no error is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces could not complete the requested action. This error may occur if
        /// you try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace or table that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <code>ACTIVE</code>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetKeyspace

        internal virtual GetKeyspaceResponse GetKeyspace(GetKeyspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyspaceResponseUnmarshaller.Instance;

            return Invoke<GetKeyspaceResponse>(request, options);
        }



        /// <summary>
        /// Returns the name and the Amazon Resource Name (ARN) of the specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace or table that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <code>ACTIVE</code>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetKeyspace">REST API Reference for GetKeyspace Operation</seealso>
        public virtual Task<GetKeyspaceResponse> GetKeyspaceAsync(GetKeyspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyspaceResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyspaceResponse>(request, options, cancellationToken);
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
        /// Returns information about the table, including the table's name and current status,
        /// the keyspace name, configuration settings, and metadata.
        /// 
        ///  
        /// <para>
        /// To read table metadata using <code>GetTable</code>, <code>Select</code> action permissions
        /// for the table and system tables are required to complete the operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace or table that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <code>ACTIVE</code>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetTable">REST API Reference for GetTable Operation</seealso>
        public virtual Task<GetTableResponse> GetTableAsync(GetTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableResponseUnmarshaller.Instance;

            return InvokeAsync<GetTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListKeyspaces

        internal virtual ListKeyspacesResponse ListKeyspaces(ListKeyspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyspacesResponseUnmarshaller.Instance;

            return Invoke<ListKeyspacesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of keyspaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeyspaces service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace or table that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <code>ACTIVE</code>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListKeyspaces">REST API Reference for ListKeyspaces Operation</seealso>
        public virtual Task<ListKeyspacesResponse> ListKeyspacesAsync(ListKeyspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyspacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeyspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTables

        internal virtual ListTablesResponse ListTables(ListTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;

            return Invoke<ListTablesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of tables for a specified keyspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace or table that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <code>ACTIVE</code>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual Task<ListTablesResponse> ListTablesAsync(ListTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTablesResponse>(request, options, cancellationToken);
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
        /// Returns a list of all tags associated with the specified Amazon Keyspaces resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace or table that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <code>ACTIVE</code>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreTable

        internal virtual RestoreTableResponse RestoreTable(RestoreTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableResponseUnmarshaller.Instance;

            return Invoke<RestoreTableResponse>(request, options);
        }



        /// <summary>
        /// Restores the specified table to the specified point in time within the <code>earliest_restorable_timestamp</code>
        /// and the current time. For more information about restore points, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/PointInTimeRecovery_HowItWorks.html#howitworks_backup_window">
        /// Time window for PITR continuous backups</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// Any number of users can execute up to 4 concurrent restores (any type of restore)
        /// in a given account.
        /// </para>
        ///  
        /// <para>
        /// When you restore using point in time recovery, Amazon Keyspaces restores your source
        /// table's schema and data to the state based on the selected timestamp <code>(day:hour:minute:second)</code>
        /// to a new table. The Time to Live (TTL) settings are also restored to the state based
        /// on the selected timestamp.
        /// </para>
        ///  
        /// <para>
        /// In addition to the table's schema, data, and TTL settings, <code>RestoreTable</code>
        /// restores the capacity mode, encryption, and point-in-time recovery settings from the
        /// source table. Unlike the table's schema data and TTL settings, which are restored
        /// based on the selected timestamp, these settings are always restored based on the table's
        /// settings as of the current time or when the table was deleted.
        /// </para>
        ///  
        /// <para>
        /// You can also overwrite these settings during restore:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Read/write capacity mode
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned throughput capacity settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Point-in-time (PITR) settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/PointInTimeRecovery_HowItWorks.html#howitworks_backup_settings">PITR
        /// restore settings</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Note that the following settings are not restored, and you must configure them manually
        /// for the new table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Automatic scaling policies (for tables that use provisioned capacity mode)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Identity and Access Management (IAM) policies
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon CloudWatch metrics and alarms
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces could not complete the requested action. This error may occur if
        /// you try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace or table that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <code>ACTIVE</code>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/RestoreTable">REST API Reference for RestoreTable Operation</seealso>
        public virtual Task<RestoreTableResponse> RestoreTableAsync(RestoreTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreTableResponse>(request, options, cancellationToken);
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
        /// Associates a set of tags with a Amazon Keyspaces resource. You can then activate these
        /// user-defined tags so that they appear on the Cost Management Console for cost allocation
        /// tracking. For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/tagging-keyspaces.html">Adding
        /// tags and labels to Amazon Keyspaces resources</a> in the <i>Amazon Keyspaces Developer
        /// Guide</i>.
        /// 
        ///  
        /// <para>
        /// For IAM policy examples that show how to control access to Amazon Keyspaces resources
        /// based on tags, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/security_iam_id-based-policy-examples-tags">Amazon
        /// Keyspaces resource access based on tags</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace or table that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <code>ACTIVE</code>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes the association of tags from a Amazon Keyspaces resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces could not complete the requested action. This error may occur if
        /// you try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace or table that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <code>ACTIVE</code>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
        /// Adds new columns to the table or updates one of the table's settings, for example
        /// capacity mode, encryption, point-in-time recovery, or ttl settings. Note that you
        /// can only update one specific table setting per update operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces could not complete the requested action. This error may occur if
        /// you try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace or table that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <code>ACTIVE</code>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}