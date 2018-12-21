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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DatabaseMigrationService.Model;
using Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations;
using Amazon.DatabaseMigrationService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DatabaseMigrationService
{
    /// <summary>
    /// Implementation for accessing DatabaseMigrationService
    ///
    /// AWS Database Migration Service 
    /// <para>
    /// AWS Database Migration Service (AWS DMS) can migrate your data to and from the most
    /// widely used commercial and open-source databases such as Oracle, PostgreSQL, Microsoft
    /// SQL Server, Amazon Redshift, MariaDB, Amazon Aurora, MySQL, and SAP Adaptive Server
    /// Enterprise (ASE). The service supports homogeneous migrations such as Oracle to Oracle,
    /// as well as heterogeneous migrations between different database platforms, such as
    /// Oracle to MySQL or SQL Server to PostgreSQL.
    /// </para>
    ///  
    /// <para>
    /// For more information about AWS DMS, see <a href="http://docs.aws.amazon.com/dms/latest/userguide/Welcome.html">What
    /// Is AWS Database Migration Service?</a> in the <i>AWS Database Migration User Guide.</i>
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonDatabaseMigrationServiceClient : AmazonServiceClient, IAmazonDatabaseMigrationService
    {
        private static IServiceMetadata serviceMetadata = new AmazonDatabaseMigrationServiceMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with the credentials loaded from the application's
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
        public AmazonDatabaseMigrationServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDatabaseMigrationServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with the credentials loaded from the application's
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
        public AmazonDatabaseMigrationServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDatabaseMigrationServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDatabaseMigrationServiceClient Configuration Object</param>
        public AmazonDatabaseMigrationServiceClient(AmazonDatabaseMigrationServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDatabaseMigrationServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonDatabaseMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDatabaseMigrationServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDatabaseMigrationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Credentials and an
        /// AmazonDatabaseMigrationServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDatabaseMigrationServiceClient Configuration Object</param>
        public AmazonDatabaseMigrationServiceClient(AWSCredentials credentials, AmazonDatabaseMigrationServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDatabaseMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDatabaseMigrationServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDatabaseMigrationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDatabaseMigrationServiceClient Configuration Object</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDatabaseMigrationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDatabaseMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDatabaseMigrationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDatabaseMigrationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDatabaseMigrationServiceClient Configuration Object</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDatabaseMigrationServiceConfig clientConfig)
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


        #region  AddTagsToResource


        /// <summary>
        /// Adds metadata tags to an AWS DMS resource, including replication instance, endpoint,
        /// security group, and migration task. These tags can also be used with cost allocation
        /// reporting to track cost associated with DMS resources, or used in a Condition statement
        /// in an IAM policy for DMS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddTagsToResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEndpoint


        /// <summary>
        /// Creates an endpoint using the provided settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// AWS DMS was denied access to the endpoint.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// AWS DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEventSubscription


        /// <summary>
        /// Creates an AWS DMS event notification subscription. 
        /// 
        ///  
        /// <para>
        /// You can specify the type of source (<code>SourceType</code>) you want to be notified
        /// of, provide a list of AWS DMS source IDs (<code>SourceIds</code>) that triggers the
        /// events, and provide a list of event categories (<code>EventCategories</code>) for
        /// events you want to be notified of. If you specify both the <code>SourceType</code>
        /// and <code>SourceIds</code>, such as <code>SourceType = replication-instance</code>
        /// and <code>SourceIdentifier = my-replinstance</code>, you will be notified of all the
        /// replication instance events for the specified source. If you specify a <code>SourceType</code>
        /// but don't specify a <code>SourceIdentifier</code>, you receive notice of the events
        /// for that source type for all your AWS DMS sources. If you don't specify either <code>SourceType</code>
        /// nor <code>SourceIdentifier</code>, you will be notified of events generated from all
        /// AWS DMS sources belonging to your customer account.
        /// </para>
        ///  
        /// <para>
        /// For more information about AWS DMS events, see <a href="http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html">Working
        /// with Events and Notifications</a> in the <i>AWS Database Migration Service User Guide.</i>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.SNSInvalidTopicException">
        /// The SNS topic is invalid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.SNSNoAuthorizationException">
        /// You are not authorized for the SNS subscription.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEventSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReplicationInstance


        /// <summary>
        /// Creates the replication instance using the specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// AWS DMS was denied access to the endpoint.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InsufficientResourceCapacityException">
        /// There are not enough resources allocated to the database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// The subnet provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// AWS DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ReplicationSubnetGroupDoesNotCoverEnoughAZsException">
        /// The replication subnet group does not cover enough Availability Zones (AZs). Edit
        /// the replication subnet group and add more AZs.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.StorageQuotaExceededException">
        /// The storage quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationInstance">REST API Reference for CreateReplicationInstance Operation</seealso>
        public virtual CreateReplicationInstanceResponse CreateReplicationInstance(CreateReplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationInstance">REST API Reference for CreateReplicationInstance Operation</seealso>
        public virtual Task<CreateReplicationInstanceResponse> CreateReplicationInstanceAsync(CreateReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateReplicationInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReplicationSubnetGroup


        /// <summary>
        /// Creates a replication subnet group given a list of the subnet IDs in a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationSubnetGroup service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// AWS DMS was denied access to the endpoint.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// The subnet provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ReplicationSubnetGroupDoesNotCoverEnoughAZsException">
        /// The replication subnet group does not cover enough Availability Zones (AZs). Edit
        /// the replication subnet group and add more AZs.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationSubnetGroup">REST API Reference for CreateReplicationSubnetGroup Operation</seealso>
        public virtual CreateReplicationSubnetGroupResponse CreateReplicationSubnetGroup(CreateReplicationSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationSubnetGroup">REST API Reference for CreateReplicationSubnetGroup Operation</seealso>
        public virtual Task<CreateReplicationSubnetGroupResponse> CreateReplicationSubnetGroupAsync(CreateReplicationSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationSubnetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateReplicationSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReplicationTask


        /// <summary>
        /// Creates a replication task using the specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationTask service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// AWS DMS was denied access to the endpoint.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// AWS DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationTask">REST API Reference for CreateReplicationTask Operation</seealso>
        public virtual CreateReplicationTaskResponse CreateReplicationTask(CreateReplicationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationTask">REST API Reference for CreateReplicationTask Operation</seealso>
        public virtual Task<CreateReplicationTaskResponse> CreateReplicationTaskAsync(CreateReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReplicationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateReplicationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCertificate


        /// <summary>
        /// Deletes the specified certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpoint


        /// <summary>
        /// Deletes the specified endpoint.
        /// 
        ///  <note> 
        /// <para>
        /// All tasks associated with the endpoint must be deleted before you can delete the endpoint.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventSubscription


        /// <summary>
        /// Deletes an AWS DMS event subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEventSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteReplicationInstance


        /// <summary>
        /// Deletes the specified replication instance.
        /// 
        ///  <note> 
        /// <para>
        /// You must delete any migration tasks that are associated with the replication instance
        /// before you can delete it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationInstance">REST API Reference for DeleteReplicationInstance Operation</seealso>
        public virtual DeleteReplicationInstanceResponse DeleteReplicationInstance(DeleteReplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationInstance">REST API Reference for DeleteReplicationInstance Operation</seealso>
        public virtual Task<DeleteReplicationInstanceResponse> DeleteReplicationInstanceAsync(DeleteReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteReplicationInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteReplicationSubnetGroup


        /// <summary>
        /// Deletes a subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationSubnetGroup service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationSubnetGroup">REST API Reference for DeleteReplicationSubnetGroup Operation</seealso>
        public virtual DeleteReplicationSubnetGroupResponse DeleteReplicationSubnetGroup(DeleteReplicationSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationSubnetGroup">REST API Reference for DeleteReplicationSubnetGroup Operation</seealso>
        public virtual Task<DeleteReplicationSubnetGroupResponse> DeleteReplicationSubnetGroupAsync(DeleteReplicationSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationSubnetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteReplicationSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteReplicationTask


        /// <summary>
        /// Deletes the specified replication task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationTask service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationTask">REST API Reference for DeleteReplicationTask Operation</seealso>
        public virtual DeleteReplicationTaskResponse DeleteReplicationTask(DeleteReplicationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationTask">REST API Reference for DeleteReplicationTask Operation</seealso>
        public virtual Task<DeleteReplicationTaskResponse> DeleteReplicationTaskAsync(DeleteReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReplicationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteReplicationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes


        /// <summary>
        /// Lists all of the AWS DMS attributes for a customer account. The attributes include
        /// AWS DMS quotas for the account, such as the number of replication instances allowed.
        /// The description for a quota includes the quota name, current usage toward that quota,
        /// and the quota's maximum value.
        /// 
        ///  
        /// <para>
        /// This command does not take any parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccountAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCertificates


        /// <summary>
        /// Provides a description of the certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificates service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual DescribeCertificatesResponse DescribeCertificates(DescribeCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual Task<DescribeCertificatesResponse> DescribeCertificatesAsync(DescribeCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnections


        /// <summary>
        /// Describes the status of the connections that have been made between the replication
        /// instance and an endpoint. Connections are created when you test an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual Task<DescribeConnectionsResponse> DescribeConnectionsAsync(DescribeConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpoints


        /// <summary>
        /// Returns information about the endpoints for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        public virtual DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        public virtual Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpointTypes


        /// <summary>
        /// Returns information about the type of endpoints available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpointTypes service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpointTypes">REST API Reference for DescribeEndpointTypes Operation</seealso>
        public virtual DescribeEndpointTypesResponse DescribeEndpointTypes(DescribeEndpointTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpointTypes">REST API Reference for DescribeEndpointTypes Operation</seealso>
        public virtual Task<DescribeEndpointTypesResponse> DescribeEndpointTypesAsync(DescribeEndpointTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEndpointTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventCategories


        /// <summary>
        /// Lists categories for all event source types, or, if specified, for a specified source
        /// type. You can see a list of the event categories and source types in <a href="http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html">Working
        /// with Events and Notifications</a> in the <i>AWS Database Migration Service User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventCategoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Lists events for a given source identifier and source type. You can also specify
        /// a start and end time. For more information on AWS DMS events, see <a href="http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Events.html">Working
        /// with Events and Notifications</a> in the <i>AWS Database Migration User Guide.</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventSubscriptions


        /// <summary>
        /// Lists all the event subscriptions for a customer account. The description of a subscription
        /// includes <code>SubscriptionName</code>, <code>SNSTopicARN</code>, <code>CustomerID</code>,
        /// <code>SourceType</code>, <code>SourceID</code>, <code>CreationTime</code>, and <code>Status</code>.
        /// 
        /// 
        ///  
        /// <para>
        /// If you specify <code>SubscriptionName</code>, this action lists the description for
        /// that subscription.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventSubscriptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrderableReplicationInstances


        /// <summary>
        /// Returns information about the replication instance types that can be created in the
        /// specified region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableReplicationInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableReplicationInstances service method, as returned by DatabaseMigrationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeOrderableReplicationInstances">REST API Reference for DescribeOrderableReplicationInstances Operation</seealso>
        public virtual DescribeOrderableReplicationInstancesResponse DescribeOrderableReplicationInstances(DescribeOrderableReplicationInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrderableReplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableReplicationInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableReplicationInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableReplicationInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeOrderableReplicationInstances">REST API Reference for DescribeOrderableReplicationInstances Operation</seealso>
        public virtual Task<DescribeOrderableReplicationInstancesResponse> DescribeOrderableReplicationInstancesAsync(DescribeOrderableReplicationInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrderableReplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableReplicationInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOrderableReplicationInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRefreshSchemasStatus


        /// <summary>
        /// Returns the status of the RefreshSchemas operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchemasStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeRefreshSchemasStatus service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRefreshSchemasStatus">REST API Reference for DescribeRefreshSchemasStatus Operation</seealso>
        public virtual DescribeRefreshSchemasStatusResponse DescribeRefreshSchemasStatus(DescribeRefreshSchemasStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRefreshSchemasStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRefreshSchemasStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeRefreshSchemasStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRefreshSchemasStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchemasStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRefreshSchemasStatus">REST API Reference for DescribeRefreshSchemasStatus Operation</seealso>
        public virtual Task<DescribeRefreshSchemasStatusResponse> DescribeRefreshSchemasStatusAsync(DescribeRefreshSchemasStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRefreshSchemasStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRefreshSchemasStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRefreshSchemasStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReplicationInstances


        /// <summary>
        /// Returns information about replication instances for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationInstances service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstances">REST API Reference for DescribeReplicationInstances Operation</seealso>
        public virtual DescribeReplicationInstancesResponse DescribeReplicationInstances(DescribeReplicationInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstances">REST API Reference for DescribeReplicationInstances Operation</seealso>
        public virtual Task<DescribeReplicationInstancesResponse> DescribeReplicationInstancesAsync(DescribeReplicationInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReplicationInstanceTaskLogs


        /// <summary>
        /// Returns information about the task logs for the specified task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstanceTaskLogs service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationInstanceTaskLogs service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstanceTaskLogs">REST API Reference for DescribeReplicationInstanceTaskLogs Operation</seealso>
        public virtual DescribeReplicationInstanceTaskLogsResponse DescribeReplicationInstanceTaskLogs(DescribeReplicationInstanceTaskLogsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationInstanceTaskLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationInstanceTaskLogsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationInstanceTaskLogsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationInstanceTaskLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstanceTaskLogs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstanceTaskLogs">REST API Reference for DescribeReplicationInstanceTaskLogs Operation</seealso>
        public virtual Task<DescribeReplicationInstanceTaskLogsResponse> DescribeReplicationInstanceTaskLogsAsync(DescribeReplicationInstanceTaskLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationInstanceTaskLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationInstanceTaskLogsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationInstanceTaskLogsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReplicationSubnetGroups


        /// <summary>
        /// Returns information about the replication subnet groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationSubnetGroups service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationSubnetGroups">REST API Reference for DescribeReplicationSubnetGroups Operation</seealso>
        public virtual DescribeReplicationSubnetGroupsResponse DescribeReplicationSubnetGroups(DescribeReplicationSubnetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationSubnetGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationSubnetGroups">REST API Reference for DescribeReplicationSubnetGroups Operation</seealso>
        public virtual Task<DescribeReplicationSubnetGroupsResponse> DescribeReplicationSubnetGroupsAsync(DescribeReplicationSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationSubnetGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationSubnetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReplicationTaskAssessmentResults


        /// <summary>
        /// Returns the task assessment results from Amazon S3. This action always returns the
        /// latest results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTaskAssessmentResults service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationTaskAssessmentResults service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskAssessmentResults">REST API Reference for DescribeReplicationTaskAssessmentResults Operation</seealso>
        public virtual DescribeReplicationTaskAssessmentResultsResponse DescribeReplicationTaskAssessmentResults(DescribeReplicationTaskAssessmentResultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskAssessmentResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskAssessmentResultsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTaskAssessmentResultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationTaskAssessmentResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTaskAssessmentResults operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskAssessmentResults">REST API Reference for DescribeReplicationTaskAssessmentResults Operation</seealso>
        public virtual Task<DescribeReplicationTaskAssessmentResultsResponse> DescribeReplicationTaskAssessmentResultsAsync(DescribeReplicationTaskAssessmentResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTaskAssessmentResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTaskAssessmentResultsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationTaskAssessmentResultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReplicationTasks


        /// <summary>
        /// Returns information about replication tasks for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationTasks service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTasks">REST API Reference for DescribeReplicationTasks Operation</seealso>
        public virtual DescribeReplicationTasksResponse DescribeReplicationTasks(DescribeReplicationTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTasks">REST API Reference for DescribeReplicationTasks Operation</seealso>
        public virtual Task<DescribeReplicationTasksResponse> DescribeReplicationTasksAsync(DescribeReplicationTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReplicationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReplicationTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReplicationTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSchemas


        /// <summary>
        /// Returns information about the schema for the specified endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchemas service method.</param>
        /// 
        /// <returns>The response from the DescribeSchemas service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeSchemas">REST API Reference for DescribeSchemas Operation</seealso>
        public virtual DescribeSchemasResponse DescribeSchemas(DescribeSchemasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemasResponseUnmarshaller.Instance;

            return Invoke<DescribeSchemasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchemas operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeSchemas">REST API Reference for DescribeSchemas Operation</seealso>
        public virtual Task<DescribeSchemasResponse> DescribeSchemasAsync(DescribeSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchemasResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSchemasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTableStatistics


        /// <summary>
        /// Returns table statistics on the database migration task, including table name, rows
        /// inserted, rows updated, and rows deleted.
        /// 
        ///  
        /// <para>
        /// Note that the "last updated" column the DMS console only indicates the time that AWS
        /// DMS last updated the table statistics record for a table. It does not indicate the
        /// time of the last update to the table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableStatistics service method.</param>
        /// 
        /// <returns>The response from the DescribeTableStatistics service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeTableStatistics">REST API Reference for DescribeTableStatistics Operation</seealso>
        public virtual DescribeTableStatisticsResponse DescribeTableStatistics(DescribeTableStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableStatisticsResponseUnmarshaller.Instance;

            return Invoke<DescribeTableStatisticsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTableStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableStatistics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeTableStatistics">REST API Reference for DescribeTableStatistics Operation</seealso>
        public virtual Task<DescribeTableStatisticsResponse> DescribeTableStatisticsAsync(DescribeTableStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTableStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTableStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportCertificate


        /// <summary>
        /// Uploads the specified certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidCertificateException">
        /// The certificate was not valid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        public virtual ImportCertificateResponse ImportCertificate(ImportCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return Invoke<ImportCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        public virtual Task<ImportCertificateResponse> ImportCertificateAsync(ImportCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags for an AWS DMS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyEndpoint


        /// <summary>
        /// Modifies the specified endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpoint service method.</param>
        /// 
        /// <returns>The response from the ModifyEndpoint service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// AWS DMS was denied access to the endpoint.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// AWS DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEndpoint">REST API Reference for ModifyEndpoint Operation</seealso>
        public virtual ModifyEndpointResponse ModifyEndpoint(ModifyEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEndpoint">REST API Reference for ModifyEndpoint Operation</seealso>
        public virtual Task<ModifyEndpointResponse> ModifyEndpointAsync(ModifyEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyEventSubscription


        /// <summary>
        /// Modifies an existing AWS DMS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.SNSInvalidTopicException">
        /// The SNS topic is invalid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.SNSNoAuthorizationException">
        /// You are not authorized for the SNS subscription.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyEventSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyReplicationInstance


        /// <summary>
        /// Modifies the replication instance to apply new settings. You can change one or more
        /// parameters by specifying these parameters and the new values in the request.
        /// 
        ///  
        /// <para>
        /// Some settings are applied during the maintenance window.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InsufficientResourceCapacityException">
        /// There are not enough resources allocated to the database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.StorageQuotaExceededException">
        /// The storage quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.UpgradeDependencyFailureException">
        /// An upgrade dependency is preventing the database migration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationInstance">REST API Reference for ModifyReplicationInstance Operation</seealso>
        public virtual ModifyReplicationInstanceResponse ModifyReplicationInstance(ModifyReplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationInstance">REST API Reference for ModifyReplicationInstance Operation</seealso>
        public virtual Task<ModifyReplicationInstanceResponse> ModifyReplicationInstanceAsync(ModifyReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyReplicationInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyReplicationSubnetGroup


        /// <summary>
        /// Modifies the settings for the specified replication subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationSubnetGroup service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// AWS DMS was denied access to the endpoint.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// The subnet provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ReplicationSubnetGroupDoesNotCoverEnoughAZsException">
        /// The replication subnet group does not cover enough Availability Zones (AZs). Edit
        /// the replication subnet group and add more AZs.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.SubnetAlreadyInUseException">
        /// The specified subnet is already in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationSubnetGroup">REST API Reference for ModifyReplicationSubnetGroup Operation</seealso>
        public virtual ModifyReplicationSubnetGroupResponse ModifyReplicationSubnetGroup(ModifyReplicationSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationSubnetGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationSubnetGroup">REST API Reference for ModifyReplicationSubnetGroup Operation</seealso>
        public virtual Task<ModifyReplicationSubnetGroupResponse> ModifyReplicationSubnetGroupAsync(ModifyReplicationSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationSubnetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyReplicationSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyReplicationTask


        /// <summary>
        /// Modifies the specified replication task.
        /// 
        ///  
        /// <para>
        /// You can't modify the task endpoints. The task must be stopped before you can modify
        /// it. 
        /// </para>
        ///  
        /// <para>
        /// For more information about AWS DMS tasks, see <a href="http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.html">Working
        /// with Migration Tasks</a> in the <i>AWS Database Migration Service User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationTask service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// AWS DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationTask">REST API Reference for ModifyReplicationTask Operation</seealso>
        public virtual ModifyReplicationTaskResponse ModifyReplicationTask(ModifyReplicationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationTask">REST API Reference for ModifyReplicationTask Operation</seealso>
        public virtual Task<ModifyReplicationTaskResponse> ModifyReplicationTaskAsync(ModifyReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReplicationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyReplicationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootReplicationInstance


        /// <summary>
        /// Reboots a replication instance. Rebooting results in a momentary outage, until the
        /// replication instance becomes available again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the RebootReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RebootReplicationInstance">REST API Reference for RebootReplicationInstance Operation</seealso>
        public virtual RebootReplicationInstanceResponse RebootReplicationInstance(RebootReplicationInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootReplicationInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RebootReplicationInstance">REST API Reference for RebootReplicationInstance Operation</seealso>
        public virtual Task<RebootReplicationInstanceResponse> RebootReplicationInstanceAsync(RebootReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootReplicationInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootReplicationInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<RebootReplicationInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RefreshSchemas


        /// <summary>
        /// Populates the schema for the specified endpoint. This is an asynchronous operation
        /// and can take several minutes. You can check the status of this operation by calling
        /// the DescribeRefreshSchemasStatus operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshSchemas service method.</param>
        /// 
        /// <returns>The response from the RefreshSchemas service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// AWS DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RefreshSchemas">REST API Reference for RefreshSchemas Operation</seealso>
        public virtual RefreshSchemasResponse RefreshSchemas(RefreshSchemasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RefreshSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshSchemasResponseUnmarshaller.Instance;

            return Invoke<RefreshSchemasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RefreshSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshSchemas operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RefreshSchemas">REST API Reference for RefreshSchemas Operation</seealso>
        public virtual Task<RefreshSchemasResponse> RefreshSchemasAsync(RefreshSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RefreshSchemasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RefreshSchemasResponseUnmarshaller.Instance;
            
            return InvokeAsync<RefreshSchemasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReloadTables


        /// <summary>
        /// Reloads the target database table with the source data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReloadTables service method.</param>
        /// 
        /// <returns>The response from the ReloadTables service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ReloadTables">REST API Reference for ReloadTables Operation</seealso>
        public virtual ReloadTablesResponse ReloadTables(ReloadTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReloadTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReloadTablesResponseUnmarshaller.Instance;

            return Invoke<ReloadTablesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReloadTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReloadTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ReloadTables">REST API Reference for ReloadTables Operation</seealso>
        public virtual Task<ReloadTablesResponse> ReloadTablesAsync(ReloadTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReloadTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReloadTablesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReloadTablesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource


        /// <summary>
        /// Removes metadata tags from a DMS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartReplicationTask


        /// <summary>
        /// Starts the replication task.
        /// 
        ///  
        /// <para>
        /// For more information about AWS DMS tasks, see <a href="http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.html">Working
        /// with Migration Tasks </a> in the <i>AWS Database Migration Service User Guide.</i>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTask service method.</param>
        /// 
        /// <returns>The response from the StartReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// AWS DMS was denied access to the endpoint.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTask">REST API Reference for StartReplicationTask Operation</seealso>
        public virtual StartReplicationTaskResponse StartReplicationTask(StartReplicationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<StartReplicationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTask">REST API Reference for StartReplicationTask Operation</seealso>
        public virtual Task<StartReplicationTaskResponse> StartReplicationTaskAsync(StartReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartReplicationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartReplicationTaskAssessment


        /// <summary>
        /// Starts the replication task assessment for unsupported data types in the source database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTaskAssessment service method.</param>
        /// 
        /// <returns>The response from the StartReplicationTaskAssessment service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTaskAssessment">REST API Reference for StartReplicationTaskAssessment Operation</seealso>
        public virtual StartReplicationTaskAssessmentResponse StartReplicationTaskAssessment(StartReplicationTaskAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskAssessmentResponseUnmarshaller.Instance;

            return Invoke<StartReplicationTaskAssessmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartReplicationTaskAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTaskAssessment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTaskAssessment">REST API Reference for StartReplicationTaskAssessment Operation</seealso>
        public virtual Task<StartReplicationTaskAssessmentResponse> StartReplicationTaskAssessmentAsync(StartReplicationTaskAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartReplicationTaskAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartReplicationTaskAssessmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartReplicationTaskAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopReplicationTask


        /// <summary>
        /// Stops the replication task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationTask service method.</param>
        /// 
        /// <returns>The response from the StopReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopReplicationTask">REST API Reference for StopReplicationTask Operation</seealso>
        public virtual StopReplicationTaskResponse StopReplicationTask(StopReplicationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<StopReplicationTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopReplicationTask">REST API Reference for StopReplicationTask Operation</seealso>
        public virtual Task<StopReplicationTaskResponse> StopReplicationTaskAsync(StopReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopReplicationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopReplicationTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopReplicationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestConnection


        /// <summary>
        /// Tests the connection between the replication instance and the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestConnection service method.</param>
        /// 
        /// <returns>The response from the TestConnection service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// AWS DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/TestConnection">REST API Reference for TestConnection Operation</seealso>
        public virtual TestConnectionResponse TestConnection(TestConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestConnectionResponseUnmarshaller.Instance;

            return Invoke<TestConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/TestConnection">REST API Reference for TestConnection Operation</seealso>
        public virtual Task<TestConnectionResponse> TestConnectionAsync(TestConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<TestConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}