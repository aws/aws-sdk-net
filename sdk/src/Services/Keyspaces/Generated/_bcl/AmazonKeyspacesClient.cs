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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Keyspaces
{
    /// <summary>
    /// <para>Implementation for accessing Keyspaces</para>
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
            : base(new AmazonKeyspacesConfig()) { }

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
            : base(new AmazonKeyspacesConfig{RegionEndpoint = region}) { }

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
            : base(config) { }

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

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKeyspacesEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKeyspacesAuthSchemeHandler());
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


        /// <summary>
        /// The <c>CreateKeyspace</c> operation adds a new keyspace to your account. In an Amazon
        /// Web Services account, keyspace names must be unique within each Region.
        /// 
        ///  
        /// <para>
        ///  <c>CreateKeyspace</c> is an asynchronous operation. You can monitor the creation
        /// status of the new keyspace by using the <c>GetKeyspace</c> operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/getting-started.keyspaces.html">Create
        /// a keyspace</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyspace service method.</param>
        /// 
        /// <returns>The response from the CreateKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
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
        public virtual CreateKeyspaceResponse CreateKeyspace(CreateKeyspaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyspaceResponseUnmarshaller.Instance;

            return Invoke<CreateKeyspaceResponse>(request, options);
        }


        /// <summary>
        /// The <c>CreateKeyspace</c> operation adds a new keyspace to your account. In an Amazon
        /// Web Services account, keyspace names must be unique within each Region.
        /// 
        ///  
        /// <para>
        ///  <c>CreateKeyspace</c> is an asynchronous operation. You can monitor the creation
        /// status of the new keyspace by using the <c>GetKeyspace</c> operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/getting-started.keyspaces.html">Create
        /// a keyspace</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyspaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateKeyspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTable


        /// <summary>
        /// The <c>CreateTable</c> operation adds a new table to the specified keyspace. Within
        /// a keyspace, table names must be unique.
        /// 
        ///  
        /// <para>
        ///  <c>CreateTable</c> is an asynchronous operation. When the request is received, the
        /// status of the table is set to <c>CREATING</c>. You can monitor the creation status
        /// of the new table by using the <c>GetTable</c> operation, which returns the current
        /// <c>status</c> of the table. You can start using a table when the status is <c>ACTIVE</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/getting-started.tables.html">Create
        /// a table</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
        public virtual CreateTableResponse CreateTable(CreateTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;

            return Invoke<CreateTableResponse>(request, options);
        }


        /// <summary>
        /// The <c>CreateTable</c> operation adds a new table to the specified keyspace. Within
        /// a keyspace, table names must be unique.
        /// 
        ///  
        /// <para>
        ///  <c>CreateTable</c> is an asynchronous operation. When the request is received, the
        /// status of the table is set to <c>CREATING</c>. You can monitor the creation status
        /// of the new table by using the <c>GetTable</c> operation, which returns the current
        /// <c>status</c> of the table. You can start using a table when the status is <c>ACTIVE</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/getting-started.tables.html">Create
        /// a table</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateType


        /// <summary>
        /// The <c>CreateType</c> operation creates a new user-defined type in the specified
        /// keyspace. 
        /// 
        ///  
        /// <para>
        /// To configure the required permissions, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/configure-udt-permissions.html#udt-permissions-create">Permissions
        /// to create a UDT</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/udts.html">User-defined
        /// types (UDTs)</a> in the <i>Amazon Keyspaces Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateType service method.</param>
        /// 
        /// <returns>The response from the CreateType service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/CreateType">REST API Reference for CreateType Operation</seealso>
        public virtual CreateTypeResponse CreateType(CreateTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypeResponseUnmarshaller.Instance;

            return Invoke<CreateTypeResponse>(request, options);
        }


        /// <summary>
        /// The <c>CreateType</c> operation creates a new user-defined type in the specified
        /// keyspace. 
        /// 
        ///  
        /// <para>
        /// To configure the required permissions, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/configure-udt-permissions.html#udt-permissions-create">Permissions
        /// to create a UDT</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/udts.html">User-defined
        /// types (UDTs)</a> in the <i>Amazon Keyspaces Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateType service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/CreateType">REST API Reference for CreateType Operation</seealso>
        public virtual Task<CreateTypeResponse> CreateTypeAsync(CreateTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteKeyspace


        /// <summary>
        /// The <c>DeleteKeyspace</c> operation deletes a keyspace and all of its tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyspace service method.</param>
        /// 
        /// <returns>The response from the DeleteKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
        public virtual DeleteKeyspaceResponse DeleteKeyspace(DeleteKeyspaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyspaceResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyspaceResponse>(request, options);
        }


        /// <summary>
        /// The <c>DeleteKeyspace</c> operation deletes a keyspace and all of its tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyspaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteKeyspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTable


        /// <summary>
        /// The <c>DeleteTable</c> operation deletes a table and all of its data. After a <c>DeleteTable</c>
        /// request is received, the specified table is in the <c>DELETING</c> state until Amazon
        /// Keyspaces completes the deletion. If the table is in the <c>ACTIVE</c> state, you
        /// can delete it. If a table is either in the <c>CREATING</c> or <c>UPDATING</c> states,
        /// then Amazon Keyspaces returns a <c>ResourceInUseException</c>. If the specified table
        /// does not exist, Amazon Keyspaces returns a <c>ResourceNotFoundException</c>. If the
        /// table is already in the <c>DELETING</c> state, no error is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
        public virtual DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteTableResponse>(request, options);
        }


        /// <summary>
        /// The <c>DeleteTable</c> operation deletes a table and all of its data. After a <c>DeleteTable</c>
        /// request is received, the specified table is in the <c>DELETING</c> state until Amazon
        /// Keyspaces completes the deletion. If the table is in the <c>ACTIVE</c> state, you
        /// can delete it. If a table is either in the <c>CREATING</c> or <c>UPDATING</c> states,
        /// then Amazon Keyspaces returns a <c>ResourceInUseException</c>. If the specified table
        /// does not exist, Amazon Keyspaces returns a <c>ResourceNotFoundException</c>. If the
        /// table is already in the <c>DELETING</c> state, no error is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteType


        /// <summary>
        /// The <c>DeleteType</c> operation deletes a user-defined type (UDT). You can only delete
        /// a type that is not used in a table or another UDT. 
        /// 
        ///  
        /// <para>
        /// To configure the required permissions, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/configure-udt-permissions.html#udt-permissions-drop">Permissions
        /// to delete a UDT</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteType service method.</param>
        /// 
        /// <returns>The response from the DeleteType service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/DeleteType">REST API Reference for DeleteType Operation</seealso>
        public virtual DeleteTypeResponse DeleteType(DeleteTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteTypeResponse>(request, options);
        }


        /// <summary>
        /// The <c>DeleteType</c> operation deletes a user-defined type (UDT). You can only delete
        /// a type that is not used in a table or another UDT. 
        /// 
        ///  
        /// <para>
        /// To configure the required permissions, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/configure-udt-permissions.html#udt-permissions-drop">Permissions
        /// to delete a UDT</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteType service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/DeleteType">REST API Reference for DeleteType Operation</seealso>
        public virtual Task<DeleteTypeResponse> DeleteTypeAsync(DeleteTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetKeyspace


        /// <summary>
        /// Returns the name of the specified keyspace, the Amazon Resource Name (ARN), the replication
        /// strategy, the Amazon Web Services Regions of a multi-Region keyspace, and the status
        /// of newly added Regions after an <c>UpdateKeyspace</c> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyspace service method.</param>
        /// 
        /// <returns>The response from the GetKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
        public virtual GetKeyspaceResponse GetKeyspace(GetKeyspaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyspaceResponseUnmarshaller.Instance;

            return Invoke<GetKeyspaceResponse>(request, options);
        }


        /// <summary>
        /// Returns the name of the specified keyspace, the Amazon Resource Name (ARN), the replication
        /// strategy, the Amazon Web Services Regions of a multi-Region keyspace, and the status
        /// of newly added Regions after an <c>UpdateKeyspace</c> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyspaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetKeyspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTable


        /// <summary>
        /// Returns information about the table, including the table's name and current status,
        /// the keyspace name, configuration settings, and metadata.
        /// 
        ///  
        /// <para>
        /// To read table metadata using <c>GetTable</c>, the IAM principal needs <c>Select</c>
        /// action permissions for the table and the system keyspace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTable service method.</param>
        /// 
        /// <returns>The response from the GetTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
        public virtual GetTableResponse GetTable(GetTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// To read table metadata using <c>GetTable</c>, the IAM principal needs <c>Select</c>
        /// action permissions for the table and the system keyspace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTableAutoScalingSettings


        /// <summary>
        /// Returns auto scaling related settings of the specified table in JSON format. If the
        /// table is a multi-Region table, the Amazon Web Services Region specific auto scaling
        /// settings of the table are included.
        /// 
        ///  
        /// <para>
        /// Amazon Keyspaces auto scaling helps you provision throughput capacity for variable
        /// workloads efficiently by increasing and decreasing your table's read and write capacity
        /// automatically in response to application traffic. For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/autoscaling.html">Managing
        /// throughput capacity automatically with Amazon Keyspaces auto scaling</a> in the <i>Amazon
        /// Keyspaces Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <c>GetTableAutoScalingSettings</c> can't be used as an action in an IAM policy.
        /// </para>
        ///  </important> 
        /// <para>
        /// To define permissions for <c>GetTableAutoScalingSettings</c>, you must allow the following
        /// two actions in the IAM policy statement's <c>Action</c> element:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>application-autoscaling:DescribeScalableTargets</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application-autoscaling:DescribeScalingPolicies</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableAutoScalingSettings service method.</param>
        /// 
        /// <returns>The response from the GetTableAutoScalingSettings service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetTableAutoScalingSettings">REST API Reference for GetTableAutoScalingSettings Operation</seealso>
        public virtual GetTableAutoScalingSettingsResponse GetTableAutoScalingSettings(GetTableAutoScalingSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableAutoScalingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableAutoScalingSettingsResponseUnmarshaller.Instance;

            return Invoke<GetTableAutoScalingSettingsResponse>(request, options);
        }


        /// <summary>
        /// Returns auto scaling related settings of the specified table in JSON format. If the
        /// table is a multi-Region table, the Amazon Web Services Region specific auto scaling
        /// settings of the table are included.
        /// 
        ///  
        /// <para>
        /// Amazon Keyspaces auto scaling helps you provision throughput capacity for variable
        /// workloads efficiently by increasing and decreasing your table's read and write capacity
        /// automatically in response to application traffic. For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/autoscaling.html">Managing
        /// throughput capacity automatically with Amazon Keyspaces auto scaling</a> in the <i>Amazon
        /// Keyspaces Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <c>GetTableAutoScalingSettings</c> can't be used as an action in an IAM policy.
        /// </para>
        ///  </important> 
        /// <para>
        /// To define permissions for <c>GetTableAutoScalingSettings</c>, you must allow the following
        /// two actions in the IAM policy statement's <c>Action</c> element:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>application-autoscaling:DescribeScalableTargets</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application-autoscaling:DescribeScalingPolicies</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableAutoScalingSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableAutoScalingSettings service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetTableAutoScalingSettings">REST API Reference for GetTableAutoScalingSettings Operation</seealso>
        public virtual Task<GetTableAutoScalingSettingsResponse> GetTableAutoScalingSettingsAsync(GetTableAutoScalingSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTableAutoScalingSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTableAutoScalingSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTableAutoScalingSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetType


        /// <summary>
        /// The <c>GetType</c> operation returns information about the type, for example the
        /// field definitions, the timestamp when the type was last modified, the level of nesting,
        /// the status, and details about if the type is used in other types and tables. 
        /// 
        ///  
        /// <para>
        /// To read keyspace metadata using <c>GetType</c>, the IAM principal needs <c>Select</c>
        /// action permissions for the system keyspace. To configure the required permissions,
        /// see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/configure-udt-permissions.html#udt-permissions-view">Permissions
        /// to view a UDT</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetType service method.</param>
        /// 
        /// <returns>The response from the GetType service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetType">REST API Reference for GetType Operation</seealso>
        public virtual GetTypeResponse GetType(GetTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypeResponseUnmarshaller.Instance;

            return Invoke<GetTypeResponse>(request, options);
        }


        /// <summary>
        /// The <c>GetType</c> operation returns information about the type, for example the
        /// field definitions, the timestamp when the type was last modified, the level of nesting,
        /// the status, and details about if the type is used in other types and tables. 
        /// 
        ///  
        /// <para>
        /// To read keyspace metadata using <c>GetType</c>, the IAM principal needs <c>Select</c>
        /// action permissions for the system keyspace. To configure the required permissions,
        /// see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/configure-udt-permissions.html#udt-permissions-view">Permissions
        /// to view a UDT</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetType service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/GetType">REST API Reference for GetType Operation</seealso>
        public virtual Task<GetTypeResponse> GetTypeAsync(GetTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListKeyspaces


        /// <summary>
        /// The <c>ListKeyspaces</c> operation returns a list of keyspaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyspaces service method.</param>
        /// 
        /// <returns>The response from the ListKeyspaces service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
        public virtual ListKeyspacesResponse ListKeyspaces(ListKeyspacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKeyspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyspacesResponseUnmarshaller.Instance;

            return Invoke<ListKeyspacesResponse>(request, options);
        }


        /// <summary>
        /// The <c>ListKeyspaces</c> operation returns a list of keyspaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeyspaces service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListKeyspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyspacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListKeyspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTables


        /// <summary>
        /// The <c>ListTables</c> operation returns a list of tables for a specified keyspace.
        /// 
        ///  
        /// <para>
        /// To read keyspace metadata using <c>ListTables</c>, the IAM principal needs <c>Select</c>
        /// action permissions for the system keyspace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
        public virtual ListTablesResponse ListTables(ListTablesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;

            return Invoke<ListTablesResponse>(request, options);
        }


        /// <summary>
        /// The <c>ListTables</c> operation returns a list of tables for a specified keyspace.
        /// 
        ///  
        /// <para>
        /// To read keyspace metadata using <c>ListTables</c>, the IAM principal needs <c>Select</c>
        /// action permissions for the system keyspace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTablesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of all tags associated with the specified Amazon Keyspaces resource.
        /// 
        ///  
        /// <para>
        /// To read keyspace metadata using <c>ListTagsForResource</c>, the IAM principal needs
        /// <c>Select</c> action permissions for the specified resource and the system keyspace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all tags associated with the specified Amazon Keyspaces resource.
        /// 
        ///  
        /// <para>
        /// To read keyspace metadata using <c>ListTagsForResource</c>, the IAM principal needs
        /// <c>Select</c> action permissions for the specified resource and the system keyspace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTypes


        /// <summary>
        /// The <c>ListTypes</c> operation returns a list of types for a specified keyspace.
        /// 
        /// 
        ///  
        /// <para>
        /// To read keyspace metadata using <c>ListTypes</c>, the IAM principal needs <c>Select</c>
        /// action permissions for the system keyspace. To configure the required permissions,
        /// see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/configure-udt-permissions.html#udt-permissions-view">Permissions
        /// to view a UDT</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypes service method.</param>
        /// 
        /// <returns>The response from the ListTypes service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListTypes">REST API Reference for ListTypes Operation</seealso>
        public virtual ListTypesResponse ListTypes(ListTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesResponseUnmarshaller.Instance;

            return Invoke<ListTypesResponse>(request, options);
        }


        /// <summary>
        /// The <c>ListTypes</c> operation returns a list of types for a specified keyspace.
        /// 
        /// 
        ///  
        /// <para>
        /// To read keyspace metadata using <c>ListTypes</c>, the IAM principal needs <c>Select</c>
        /// action permissions for the system keyspace. To configure the required permissions,
        /// see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/configure-udt-permissions.html#udt-permissions-view">Permissions
        /// to view a UDT</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTypes service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/ListTypes">REST API Reference for ListTypes Operation</seealso>
        public virtual Task<ListTypesResponse> ListTypesAsync(ListTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreTable


        /// <summary>
        /// Restores the table to the specified point in time within the <c>earliest_restorable_timestamp</c>
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
        /// table's schema and data to the state based on the selected timestamp <c>(day:hour:minute:second)</c>
        /// to a new table. The Time to Live (TTL) settings are also restored to the state based
        /// on the selected timestamp.
        /// </para>
        ///  
        /// <para>
        /// In addition to the table's schema, data, and TTL settings, <c>RestoreTable</c> restores
        /// the capacity mode, auto scaling settings, encryption settings, and point-in-time recovery
        /// settings from the source table. Unlike the table's schema data and TTL settings, which
        /// are restored based on the selected timestamp, these settings are always restored based
        /// on the table's settings as of the current time or when the table was deleted.
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
        /// Provisioned throughput capacity units
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Auto scaling settings
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
        /// Identity and Access Management (IAM) policies
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon CloudWatch metrics and alarms
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTable service method.</param>
        /// 
        /// <returns>The response from the RestoreTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
        public virtual RestoreTableResponse RestoreTable(RestoreTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableResponseUnmarshaller.Instance;

            return Invoke<RestoreTableResponse>(request, options);
        }


        /// <summary>
        /// Restores the table to the specified point in time within the <c>earliest_restorable_timestamp</c>
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
        /// table's schema and data to the state based on the selected timestamp <c>(day:hour:minute:second)</c>
        /// to a new table. The Time to Live (TTL) settings are also restored to the state based
        /// on the selected timestamp.
        /// </para>
        ///  
        /// <para>
        /// In addition to the table's schema, data, and TTL settings, <c>RestoreTable</c> restores
        /// the capacity mode, auto scaling settings, encryption settings, and point-in-time recovery
        /// settings from the source table. Unlike the table's schema data and TTL settings, which
        /// are restored based on the selected timestamp, these settings are always restored based
        /// on the table's settings as of the current time or when the table was deleted.
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
        /// Provisioned throughput capacity units
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Auto scaling settings
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
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableResponseUnmarshaller.Instance;
            
            return InvokeAsync<RestoreTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


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
        /// based on tags, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/security_iam_id-based-policy-examples.html#security_iam_id-based-policy-examples-tags">Amazon
        /// Keyspaces resource access based on tags</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// based on tags, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/security_iam_id-based-policy-examples.html#security_iam_id-based-policy-examples-tags">Amazon
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
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the association of tags from a Amazon Keyspaces resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateKeyspace


        /// <summary>
        /// Adds a new Amazon Web Services Region to the keyspace. You can add a new Region to
        /// a keyspace that is either a single or a multi-Region keyspace. Amazon Keyspaces is
        /// going to replicate all tables in the keyspace to the new Region. To successfully replicate
        /// all tables to the new Region, they must use client-side timestamps for conflict resolution.
        /// To enable client-side timestamps, specify <c>clientSideTimestamps.status = enabled</c>
        /// when invoking the API. For more information about client-side timestamps, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/client-side-timestamps.html">Client-side
        /// timestamps in Amazon Keyspaces</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// To add a Region to a keyspace using the <c>UpdateKeyspace</c> API, the IAM principal
        /// needs permissions for the following IAM actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>cassandra:Alter</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:AlterMultiRegionResource</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:Create</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:CreateMultiRegionResource</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:Select</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:SelectMultiRegionResource</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:Modify</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:ModifyMultiRegionResource</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the keyspace contains a table that is configured in provisioned mode with auto
        /// scaling enabled, the following additional IAM actions need to be allowed.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>application-autoscaling:RegisterScalableTarget</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application-autoscaling:DeregisterScalableTarget</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application-autoscaling:DescribeScalableTargets</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application-autoscaling:PutScalingPolicy</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application-autoscaling:DescribeScalingPolicies</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use the <c>UpdateKeyspace</c> API, the IAM principal also needs permissions to
        /// create a service-linked role with the following elements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>iam:CreateServiceLinkedRole</c> - The <b>action</b> the principal can perform.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:iam::*:role/aws-service-role/replication.cassandra.amazonaws.com/AWSServiceRoleForKeyspacesReplication</c>
        /// - The <b>resource</b> that the action can be performed on. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>iam:AWSServiceName: replication.cassandra.amazonaws.com</c> - The only Amazon
        /// Web Services service that this role can be attached to is Amazon Keyspaces.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/howitworks_replication_permissions_addReplica.html">Configure
        /// the IAM permissions required to add an Amazon Web Services Region to a keyspace</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyspace service method.</param>
        /// 
        /// <returns>The response from the UpdateKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/UpdateKeyspace">REST API Reference for UpdateKeyspace Operation</seealso>
        public virtual UpdateKeyspaceResponse UpdateKeyspace(UpdateKeyspaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyspaceResponseUnmarshaller.Instance;

            return Invoke<UpdateKeyspaceResponse>(request, options);
        }


        /// <summary>
        /// Adds a new Amazon Web Services Region to the keyspace. You can add a new Region to
        /// a keyspace that is either a single or a multi-Region keyspace. Amazon Keyspaces is
        /// going to replicate all tables in the keyspace to the new Region. To successfully replicate
        /// all tables to the new Region, they must use client-side timestamps for conflict resolution.
        /// To enable client-side timestamps, specify <c>clientSideTimestamps.status = enabled</c>
        /// when invoking the API. For more information about client-side timestamps, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/client-side-timestamps.html">Client-side
        /// timestamps in Amazon Keyspaces</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// To add a Region to a keyspace using the <c>UpdateKeyspace</c> API, the IAM principal
        /// needs permissions for the following IAM actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>cassandra:Alter</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:AlterMultiRegionResource</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:Create</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:CreateMultiRegionResource</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:Select</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:SelectMultiRegionResource</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:Modify</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cassandra:ModifyMultiRegionResource</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the keyspace contains a table that is configured in provisioned mode with auto
        /// scaling enabled, the following additional IAM actions need to be allowed.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>application-autoscaling:RegisterScalableTarget</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application-autoscaling:DeregisterScalableTarget</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application-autoscaling:DescribeScalableTargets</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application-autoscaling:PutScalingPolicy</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application-autoscaling:DescribeScalingPolicies</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use the <c>UpdateKeyspace</c> API, the IAM principal also needs permissions to
        /// create a service-linked role with the following elements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>iam:CreateServiceLinkedRole</c> - The <b>action</b> the principal can perform.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arn:aws:iam::*:role/aws-service-role/replication.cassandra.amazonaws.com/AWSServiceRoleForKeyspacesReplication</c>
        /// - The <b>resource</b> that the action can be performed on. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>iam:AWSServiceName: replication.cassandra.amazonaws.com</c> - The only Amazon
        /// Web Services service that this role can be attached to is Amazon Keyspaces.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/howitworks_replication_permissions_addReplica.html">Configure
        /// the IAM permissions required to add an Amazon Web Services Region to a keyspace</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyspace service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ServiceQuotaExceededException">
        /// The operation exceeded the service quota for this resource. For more information on
        /// service quotas, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/quotas.html">Quotas</a>
        /// in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ValidationException">
        /// The operation failed due to an invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspaces-2022-02-10/UpdateKeyspace">REST API Reference for UpdateKeyspace Operation</seealso>
        public virtual Task<UpdateKeyspaceResponse> UpdateKeyspaceAsync(UpdateKeyspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKeyspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyspaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateKeyspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTable


        /// <summary>
        /// Adds new columns to the table or updates one of the table's settings, for example
        /// capacity mode, auto scaling, encryption, point-in-time recovery, or ttl settings.
        /// Note that you can only update one specific table setting per update operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable service method.</param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
        public virtual UpdateTableResponse UpdateTable(UpdateTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableResponseUnmarshaller.Instance;

            return Invoke<UpdateTableResponse>(request, options);
        }


        /// <summary>
        /// Adds new columns to the table or updates one of the table's settings, for example
        /// capacity mode, auto scaling, encryption, point-in-time recovery, or ttl settings.
        /// Note that you can only update one specific table setting per update operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by Keyspaces.</returns>
        /// <exception cref="Amazon.Keyspaces.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ConflictException">
        /// Amazon Keyspaces couldn't complete the requested action. This error may occur if you
        /// try to perform an action and the same or a different action is already in progress,
        /// or if you try to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.InternalServerException">
        /// Amazon Keyspaces was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.Keyspaces.Model.ResourceNotFoundException">
        /// The operation tried to access a keyspace, table, or type that doesn't exist. The resource
        /// might not be specified correctly, or its status might not be <c>ACTIVE</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTableResponse>(request, options, cancellationToken);
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