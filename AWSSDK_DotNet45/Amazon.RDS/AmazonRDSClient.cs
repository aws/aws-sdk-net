/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.RDS.Model;
using Amazon.RDS.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS
{
    /// <summary>
    /// Implementation for accessing AmazonRDS.
    /// 
    /// Amazon Relational Database Service <para> Amazon Relational Database Service (Amazon RDS) is a web service that makes it easier to set up,
    /// operate, and scale a relational database in the cloud. It provides cost-efficient, resizable capacity for an industry-standard relational
    /// database and manages common database administration tasks, freeing up developers to focus on what makes their applications and businesses
    /// unique. </para> <para> Amazon RDS gives you access to the capabilities of a familiar MySQL or Oracle database server. This means the code,
    /// applications, and tools you already use today with your existing MySQL or Oracle databases work with Amazon RDS without modification. Amazon
    /// RDS automatically backs up your database and maintains the database software that powers your DB Instance. Amazon RDS is flexible: you can
    /// scale your database instance's compute resources and storage capacity to meet your application's demand. As with all Amazon Web Services,
    /// there are no up-front investments, and you pay only for the resources you use. </para> <para> This is the <i>Amazon RDS API Reference</i> .
    /// It contains a comprehensive description of all Amazon RDS Query APIs and data types. Note that this API is asynchronous and some actions may
    /// require polling to determine when an action has been applied. See the parameter description to determine if a change is applied immediately
    /// or on the next instance reboot or during the maintenance window. For more information on Amazon RDS concepts and usage scenarios, go to the
    /// Amazon RDS User Guide. </para>
    /// </summary>
	public partial class AmazonRDSClient : AmazonWebServiceClient, Amazon.RDS.IAmazonRDS
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRDSClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRDS Configuration Object</param>
        public AmazonRDSClient(AmazonRDSConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRDSClient(AWSCredentials credentials)
            : this(credentials, new AmazonRDSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRDSConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Credentials and an
        /// AmazonRDSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(AWSCredentials credentials, AmazonRDSConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRDSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRDSConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDSClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRDSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRDSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRDSConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDSClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRDSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// <para>Adds a source identifier to an existing RDS event notification subscription.</para>
        /// </summary>
        /// 
        /// <param name="addSourceIdentifierToSubscriptionRequest">Container for the necessary parameters to execute the
        /// AddSourceIdentifierToSubscription service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the AddSourceIdentifierToSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.SourceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionNotFoundException" />
		public AddSourceIdentifierToSubscriptionResponse AddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request)
        {
            var task = AddSourceIdentifierToSubscriptionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the AddSourceIdentifierToSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.AddSourceIdentifierToSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<AddSourceIdentifierToSubscriptionResponse> AddSourceIdentifierToSubscriptionAsync(AddSourceIdentifierToSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddSourceIdentifierToSubscriptionRequestMarshaller();
            var unmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AddSourceIdentifierToSubscriptionRequest, AddSourceIdentifierToSubscriptionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Adds metadata tags to a DB Instance. These tags can also be used with cost allocation reporting to track cost associated with a DB
        /// Instance.</para> <para>For an overview on tagging DB Instances, see DB Instance Tags. </para>
        /// </summary>
        /// 
        /// <param name="addTagsToResourceRequest">Container for the necessary parameters to execute the AddTagsToResource service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
		public AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var task = AddTagsToResourceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.AddTagsToResource"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AddTagsToResourceRequest, AddTagsToResourceResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Enables ingress to a DBSecurityGroup using one of two forms of authorization. First, EC2 or VPC Security Groups can be added to the
        /// DBSecurityGroup if the application using the database is running on EC2 or VPC instances. Second, IP ranges are available if the application
        /// accessing your database is running on the Internet. Required parameters for this API are one of CIDR range, EC2SecurityGroupId for VPC, or
        /// (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId for non-VPC). </para> <para><b>NOTE:</b> You cannot authorize
        /// ingress from an EC2 security group in one Region to an Amazon RDS DB Instance in another. You cannot authorize ingress from a VPC security
        /// group in one VPC to an Amazon RDS DB Instance in another. </para> <para>For an overview of CIDR ranges, go to the Wikipedia Tutorial.
        /// </para>
        /// </summary>
        /// 
        /// <param name="authorizeDBSecurityGroupIngressRequest">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress
        /// service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the AuthorizeDBSecurityGroupIngress service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSecurityGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.AuthorizationAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.AuthorizationQuotaExceededException" />
		public AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest request)
        {
            var task = AuthorizeDBSecurityGroupIngressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.AuthorizeDBSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<AuthorizeDBSecurityGroupIngressResponse> AuthorizeDBSecurityGroupIngressAsync(AuthorizeDBSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeDBSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AuthorizeDBSecurityGroupIngressRequest, AuthorizeDBSecurityGroupIngressResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Copies the specified DBSnapshot. The source DBSnapshot must be in the "available" state. </para>
        /// </summary>
        /// 
        /// <param name="copyDBSnapshotRequest">Container for the necessary parameters to execute the CopyDBSnapshot service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CopyDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSnapshotStateException" />
        /// <exception cref="T:Amazon.RDS.Model.SnapshotQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
		public CopyDBSnapshotResponse CopyDBSnapshot(CopyDBSnapshotRequest request)
        {
            var task = CopyDBSnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CopyDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CopyDBSnapshotResponse> CopyDBSnapshotAsync(CopyDBSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var unmarshaller = CopyDBSnapshotResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CopyDBSnapshotRequest, CopyDBSnapshotResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates a new DB instance. </para>
        /// </summary>
        /// 
        /// <param name="createDBInstanceRequest">Container for the necessary parameters to execute the CreateDBInstance service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InstanceQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.StorageQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InsufficientDBInstanceCapacityException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException" />
		public CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            var task = CreateDBInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBInstance"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var unmarshaller = CreateDBInstanceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateDBInstanceRequest, CreateDBInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates a DB Instance that acts as a Read Replica of a source DB Instance. </para> <para> All Read Replica DB Instances are created
        /// as Single-AZ deployments with backups disabled. All other DB Instance attributes (including DB Security Groups and DB Parameter Groups) are
        /// inherited from the source DB Instance, except as specified below. </para> <para><b>IMPORTANT:</b> The source DB Instance must have backup
        /// retention enabled. </para>
        /// </summary>
        /// 
        /// <param name="createDBInstanceReadReplicaRequest">Container for the necessary parameters to execute the CreateDBInstanceReadReplica service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBInstanceReadReplica service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.RDS.Model.InstanceQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.StorageQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InsufficientDBInstanceCapacityException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException" />
		public CreateDBInstanceReadReplicaResponse CreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest request)
        {
            var task = CreateDBInstanceReadReplicaAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstanceReadReplica operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBInstanceReadReplica"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstanceReadReplica operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateDBInstanceReadReplicaResponse> CreateDBInstanceReadReplicaAsync(CreateDBInstanceReadReplicaRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var unmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateDBInstanceReadReplicaRequest, CreateDBInstanceReadReplicaResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates a new DB Parameter Group. </para> <para> A DB Parameter Group is initially created with the default parameters for the
        /// database engine used by the DB Instance. To provide custom values for any of the parameters, you must modify the group after creating it
        /// using <i>ModifyDBParameterGroup</i> . Once you've created a DB Parameter Group, you need to associate it with your DB Instance using
        /// <i>ModifyDBInstance</i> . When you associate a new DB Parameter Group with a running DB Instance, you need to reboot the DB Instance for the
        /// new DB Parameter Group and associated settings to take effect. </para>
        /// </summary>
        /// 
        /// <param name="createDBParameterGroupRequest">Container for the necessary parameters to execute the CreateDBParameterGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupAlreadyExistsException" />
		public CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest request)
        {
            var task = CreateDBParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateDBParameterGroupResponse> CreateDBParameterGroupAsync(CreateDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBParameterGroupRequestMarshaller();
            var unmarshaller = CreateDBParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateDBParameterGroupRequest, CreateDBParameterGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates a new DB Security Group. DB Security Groups control access to a DB Instance. </para>
        /// </summary>
        /// 
        /// <param name="createDBSecurityGroupRequest">Container for the necessary parameters to execute the CreateDBSecurityGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBSecurityGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotSupportedException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupAlreadyExistsException" />
		public CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest request)
        {
            var task = CreateDBSecurityGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateDBSecurityGroupResponse> CreateDBSecurityGroupAsync(CreateDBSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBSecurityGroupRequestMarshaller();
            var unmarshaller = CreateDBSecurityGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateDBSecurityGroupRequest, CreateDBSecurityGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates a DBSnapshot. The source DBInstance must be in "available" state. </para>
        /// </summary>
        /// 
        /// <param name="createDBSnapshotRequest">Container for the necessary parameters to execute the CreateDBSnapshot service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <exception cref="T:Amazon.RDS.Model.SnapshotQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotAlreadyExistsException" />
		public CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest request)
        {
            var task = CreateDBSnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateDBSnapshotResponse> CreateDBSnapshotAsync(CreateDBSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBSnapshotRequestMarshaller();
            var unmarshaller = CreateDBSnapshotResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateDBSnapshotRequest, CreateDBSnapshotResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates a new DB subnet group. DB subnet groups must contain at least one subnet in at least two AZs in the region. </para>
        /// </summary>
        /// 
        /// <param name="createDBSubnetGroupRequest">Container for the necessary parameters to execute the CreateDBSubnetGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
		public CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest request)
        {
            var task = CreateDBSubnetGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateDBSubnetGroupResponse> CreateDBSubnetGroupAsync(CreateDBSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBSubnetGroupRequestMarshaller();
            var unmarshaller = CreateDBSubnetGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateDBSubnetGroupRequest, CreateDBSubnetGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Creates an RDS event notification subscription. This action requires a topic ARN (Amazon Resource Name) created by either the RDS
        /// console, the SNS console, or the SNS API. To obtain an ARN with SNS, you must create a topic in Amazon SNS and subscribe to the topic. The
        /// ARN is displayed in the SNS console.</para> <para>You can specify the type of source (SourceType) you want to be notified of, provide a list
        /// of RDS sources (SourceIds) that triggers the events, and provide a list of event categories (EventCategories) for events you want to be
        /// notified of. For example, you can specify SourceType = db-instance, SourceIds = mydbinstance1, mydbinstance2 and EventCategories =
        /// Availability, Backup.</para> <para>If you specify both the SourceType and SourceIds, such as SourceType = db-instance and SourceIdentifier =
        /// myDBInstance1, you will be notified of all the db-instance events for the specified source. If you specify a SourceType but do not specify a
        /// SourceIdentifier, you will receive notice of the events for that source type for all your RDS sources. If you do not specify either the
        /// SourceType nor the SourceIdentifier, you will be notified of events generated from all RDS sources belonging to your customer
        /// account.</para>
        /// </summary>
        /// 
        /// <param name="createEventSubscriptionRequest">Container for the necessary parameters to execute the CreateEventSubscription service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.SourceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SNSTopicArnNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SNSInvalidTopicException" />
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionCategoryNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SNSNoAuthorizationException" />
        /// <exception cref="T:Amazon.RDS.Model.EventSubscriptionQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionAlreadyExistException" />
		public CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var task = CreateEventSubscriptionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateEventSubscriptionRequest, CreateEventSubscriptionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates a new Option Group. You can create up to 20 option groups. </para>
        /// </summary>
        /// 
        /// <param name="createOptionGroupRequest">Container for the necessary parameters to execute the CreateOptionGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateOptionGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupQuotaExceededException" />
		public CreateOptionGroupResponse CreateOptionGroup(CreateOptionGroupRequest request)
        {
            var task = CreateOptionGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.CreateOptionGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<CreateOptionGroupResponse> CreateOptionGroupAsync(CreateOptionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateOptionGroupRequestMarshaller();
            var unmarshaller = CreateOptionGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateOptionGroupRequest, CreateOptionGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> The DeleteDBInstance action deletes a previously provisioned DB instance. A successful response from the web service indicates the
        /// request was received correctly. When you delete a DB instance, all automated backups for that instance are deleted and cannot be recovered.
        /// Manual DB Snapshots of the DB instance to be deleted are not deleted. </para> <para> If a final DBSnapshot is requested the status of the
        /// RDS instance will be "deleting" until the DBSnapshot is created. DescribeDBInstance is used to monitor the status of this operation. This
        /// cannot be canceled or reverted once submitted. </para>
        /// </summary>
        /// 
        /// <param name="deleteDBInstanceRequest">Container for the necessary parameters to execute the DeleteDBInstance service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DeleteDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <exception cref="T:Amazon.RDS.Model.SnapshotQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotAlreadyExistsException" />
		public DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            var task = DeleteDBInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBInstance"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var unmarshaller = DeleteDBInstanceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteDBInstanceRequest, DeleteDBInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Deletes a specified DBParameterGroup. The DBParameterGroup cannot be associated with any RDS instances to be deleted. </para>
        /// <para><b>NOTE:</b> The specified DB Parameter Group cannot be associated with any DB Instances. </para>
        /// </summary>
        /// 
        /// <param name="deleteDBParameterGroupRequest">Container for the necessary parameters to execute the DeleteDBParameterGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBParameterGroupStateException" />
		public DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest request)
        {
            var task = DeleteDBParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteDBParameterGroupResponse> DeleteDBParameterGroupAsync(DeleteDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBParameterGroupRequestMarshaller();
            var unmarshaller = DeleteDBParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteDBParameterGroupRequest, DeleteDBParameterGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Deletes a DB Security Group. </para> <para><b>NOTE:</b>The specified DB Security Group must not be associated with any DB
        /// Instances.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSecurityGroupRequest">Container for the necessary parameters to execute the DeleteDBSecurityGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSecurityGroupStateException" />
		public DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest request)
        {
            var task = DeleteDBSecurityGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteDBSecurityGroupResponse> DeleteDBSecurityGroupAsync(DeleteDBSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteDBSecurityGroupRequest, DeleteDBSecurityGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Deletes a DBSnapshot. </para> <para><b>NOTE:</b>The DBSnapshot must be in the available state to be deleted.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSnapshotRequest">Container for the necessary parameters to execute the DeleteDBSnapshot service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DeleteDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSnapshotStateException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
		public DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest request)
        {
            var task = DeleteDBSnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteDBSnapshotResponse> DeleteDBSnapshotAsync(DeleteDBSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBSnapshotRequestMarshaller();
            var unmarshaller = DeleteDBSnapshotResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteDBSnapshotRequest, DeleteDBSnapshotResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Deletes a DB subnet group. </para> <para><b>NOTE:</b>The specified database subnet group must not be associated with any DB
        /// instances.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSubnetGroupRequest">Container for the necessary parameters to execute the DeleteDBSubnetGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSubnetGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSubnetStateException" />
		public DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request)
        {
            var task = DeleteDBSubnetGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteDBSubnetGroupResponse> DeleteDBSubnetGroupAsync(DeleteDBSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteDBSubnetGroupRequest, DeleteDBSubnetGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Deletes an RDS event notification subscription.</para>
        /// </summary>
        /// 
        /// <param name="deleteEventSubscriptionRequest">Container for the necessary parameters to execute the DeleteEventSubscription service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidEventSubscriptionStateException" />
		public DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var task = DeleteEventSubscriptionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteEventSubscriptionRequest, DeleteEventSubscriptionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Deletes an existing Option Group. </para>
        /// </summary>
        /// 
        /// <param name="deleteOptionGroupRequest">Container for the necessary parameters to execute the DeleteOptionGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.InvalidOptionGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
		public DeleteOptionGroupResponse DeleteOptionGroup(DeleteOptionGroupRequest request)
        {
            var task = DeleteOptionGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DeleteOptionGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteOptionGroupResponse> DeleteOptionGroupAsync(DeleteOptionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteOptionGroupRequestMarshaller();
            var unmarshaller = DeleteOptionGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteOptionGroupRequest, DeleteOptionGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a list of the available DB engines. </para>
        /// </summary>
        /// 
        /// <param name="describeDBEngineVersionsRequest">Container for the necessary parameters to execute the DescribeDBEngineVersions service method
        /// on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by AmazonRDS.</returns>
		public DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request)
        {
            var task = DescribeDBEngineVersionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBEngineVersions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBEngineVersions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(DescribeDBEngineVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBEngineVersionsRequestMarshaller();
            var unmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeDBEngineVersionsRequest, DescribeDBEngineVersionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a list of the available DB engines. </para>
        /// </summary>
        /// 
        /// <param name="describeDBEngineVersionsRequest">Container for the necessary parameters to execute the DescribeDBEngineVersions service method
        /// on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by AmazonRDS.</returns>
		public DescribeDBEngineVersionsResponse DescribeDBEngineVersions()
        {
            return this.DescribeDBEngineVersions(new DescribeDBEngineVersionsRequest());
        }
 
        /// <summary>
        /// <para> Returns information about provisioned RDS instances. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <param name="describeDBInstancesRequest">Container for the necessary parameters to execute the DescribeDBInstances service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
		public DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            var task = DescribeDBInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBInstances operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBInstancesRequestMarshaller();
            var unmarshaller = DescribeDBInstancesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeDBInstancesRequest, DescribeDBInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns information about provisioned RDS instances. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <param name="describeDBInstancesRequest">Container for the necessary parameters to execute the DescribeDBInstances service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
		public DescribeDBInstancesResponse DescribeDBInstances()
        {
            return this.DescribeDBInstances(new DescribeDBInstancesRequest());
        }
 
        /// <summary>
        /// <para> Returns a list of DB log files for the DB instance. </para>
        /// </summary>
        /// 
        /// <param name="describeDBLogFilesRequest">Container for the necessary parameters to execute the DescribeDBLogFiles service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBLogFiles service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
		public DescribeDBLogFilesResponse DescribeDBLogFiles(DescribeDBLogFilesRequest request)
        {
            var task = DescribeDBLogFilesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBLogFiles operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBLogFiles"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBLogFiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeDBLogFilesResponse> DescribeDBLogFilesAsync(DescribeDBLogFilesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBLogFilesRequestMarshaller();
            var unmarshaller = DescribeDBLogFilesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeDBLogFilesRequest, DescribeDBLogFilesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a list of DB log files for the DB instance. </para>
        /// </summary>
        /// 
        /// <param name="describeDBLogFilesRequest">Container for the necessary parameters to execute the DescribeDBLogFiles service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBLogFiles service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
		public DescribeDBLogFilesResponse DescribeDBLogFiles()
        {
            return this.DescribeDBLogFiles(new DescribeDBLogFilesRequest());
        }
 
        /// <summary>
        /// <para> Returns a list of DBParameterGroup descriptions. If a DBParameterGroupName is specified, the list will contain only the description
        /// of the specified DBParameterGroup. </para>
        /// </summary>
        /// 
        /// <param name="describeDBParameterGroupsRequest">Container for the necessary parameters to execute the DescribeDBParameterGroups service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
		public DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request)
        {
            var task = DescribeDBParameterGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameterGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBParameterGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(DescribeDBParameterGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeDBParameterGroupsRequest, DescribeDBParameterGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a list of DBParameterGroup descriptions. If a DBParameterGroupName is specified, the list will contain only the description
        /// of the specified DBParameterGroup. </para>
        /// </summary>
        /// 
        /// <param name="describeDBParameterGroupsRequest">Container for the necessary parameters to execute the DescribeDBParameterGroups service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
		public DescribeDBParameterGroupsResponse DescribeDBParameterGroups()
        {
            return this.DescribeDBParameterGroups(new DescribeDBParameterGroupsRequest());
        }
 
        /// <summary>
        /// <para> Returns the detailed parameter list for a particular DBParameterGroup. </para>
        /// </summary>
        /// 
        /// <param name="describeDBParametersRequest">Container for the necessary parameters to execute the DescribeDBParameters service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBParameters service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
		public DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest request)
        {
            var task = DescribeDBParametersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameters operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBParameters"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeDBParametersResponse> DescribeDBParametersAsync(DescribeDBParametersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBParametersRequestMarshaller();
            var unmarshaller = DescribeDBParametersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeDBParametersRequest, DescribeDBParametersResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a list of DBSecurityGroup descriptions. If a DBSecurityGroupName is specified, the list will contain only the descriptions of
        /// the specified DBSecurityGroup. </para> <para>For an overview of CIDR ranges, go to the Wikipedia Tutorial. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeDBSecurityGroups service method
        /// on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
		public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request)
        {
            var task = DescribeDBSecurityGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSecurityGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(DescribeDBSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeDBSecurityGroupsRequest, DescribeDBSecurityGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a list of DBSecurityGroup descriptions. If a DBSecurityGroupName is specified, the list will contain only the descriptions of
        /// the specified DBSecurityGroup. </para> <para>For an overview of CIDR ranges, go to the Wikipedia Tutorial. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeDBSecurityGroups service method
        /// on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
		public DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups()
        {
            return this.DescribeDBSecurityGroups(new DescribeDBSecurityGroupsRequest());
        }
 
        /// <summary>
        /// <para> Returns information about DBSnapshots. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSnapshotsRequest">Container for the necessary parameters to execute the DescribeDBSnapshots service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
		public DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest request)
        {
            var task = DescribeDBSnapshotsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSnapshots operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBSnapshots"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeDBSnapshotsResponse> DescribeDBSnapshotsAsync(DescribeDBSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBSnapshotsRequestMarshaller();
            var unmarshaller = DescribeDBSnapshotsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeDBSnapshotsRequest, DescribeDBSnapshotsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns information about DBSnapshots. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSnapshotsRequest">Container for the necessary parameters to execute the DescribeDBSnapshots service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
		public DescribeDBSnapshotsResponse DescribeDBSnapshots()
        {
            return this.DescribeDBSnapshots(new DescribeDBSnapshotsRequest());
        }
 
        /// <summary>
        /// <para> Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified, the list will contain only the descriptions of the
        /// specified DBSubnetGroup. </para> <para>For an overview of CIDR ranges, go to the Wikipedia Tutorial. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
		public DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups()
        {
            return this.DescribeDBSubnetGroups(new DescribeDBSubnetGroupsRequest());
        }
 
        /// <summary>
        /// <para> Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified, the list will contain only the descriptions of the
        /// specified DBSubnetGroup. </para> <para>For an overview of CIDR ranges, go to the Wikipedia Tutorial. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
		public DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request)
        {
            var task = DescribeDBSubnetGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeDBSubnetGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(DescribeDBSubnetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeDBSubnetGroupsRequest, DescribeDBSubnetGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns the default engine and system parameter information for the specified database engine. </para>
        /// </summary>
        /// 
        /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        /// service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by AmazonRDS.</returns>
		public DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            var task = DescribeEngineDefaultParametersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeEngineDefaultParameters"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEngineDefaultParametersRequestMarshaller();
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeEngineDefaultParametersRequest, DescribeEngineDefaultParametersResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Displays a list of categories for all event source types, or, if specified, for a specified source type. You can see a list of the
        /// event categories and source types in the Events topic in the Amazon RDS User Guide.</para>
        /// </summary>
        /// 
        /// <param name="describeEventCategoriesRequest">Container for the necessary parameters to execute the DescribeEventCategories service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by AmazonRDS.</returns>
		public DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var task = DescribeEventCategoriesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeEventCategories"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeEventCategoriesRequest, DescribeEventCategoriesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Displays a list of categories for all event source types, or, if specified, for a specified source type. You can see a list of the
        /// event categories and source types in the Events topic in the Amazon RDS User Guide.</para>
        /// </summary>
        /// 
        /// <param name="describeEventCategoriesRequest">Container for the necessary parameters to execute the DescribeEventCategories service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by AmazonRDS.</returns>
		public DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return this.DescribeEventCategories(new DescribeEventCategoriesRequest());
        }
 
        /// <summary>
        /// <para> Returns events related to DB Instances, DB Security Groups, DB Snapshots and DB Parameter Groups for the past 14 days. Events
        /// specific to a particular DB Instance, DB Security Group, database snapshot or DB Parameter Group can be obtained by providing the name as a
        /// parameter. By default, the past hour of events are returned. </para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRDS.</returns>
		public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var task = DescribeEventsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeEvents"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeEventsRequest, DescribeEventsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns events related to DB Instances, DB Security Groups, DB Snapshots and DB Parameter Groups for the past 14 days. Events
        /// specific to a particular DB Instance, DB Security Group, database snapshot or DB Parameter Group can be obtained by providing the name as a
        /// parameter. By default, the past hour of events are returned. </para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRDS.</returns>
		public DescribeEventsResponse DescribeEvents()
        {
            return this.DescribeEvents(new DescribeEventsRequest());
        }
 
        /// <summary>
        /// <para>Lists all the subscription descriptions for a customer account. The description for a subscription includes SubscriptionName,
        /// SNSTopicARN, CustomerID, SourceType, SourceID, CreationTime, and Status. </para> <para>If you specify a SubscriptionName, lists the
        /// description for that subscription.</para>
        /// </summary>
        /// 
        /// <param name="describeEventSubscriptionsRequest">Container for the necessary parameters to execute the DescribeEventSubscriptions service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionNotFoundException" />
		public DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var task = DescribeEventSubscriptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeEventSubscriptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeEventSubscriptionsRequest, DescribeEventSubscriptionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Lists all the subscription descriptions for a customer account. The description for a subscription includes SubscriptionName,
        /// SNSTopicARN, CustomerID, SourceType, SourceID, CreationTime, and Status. </para> <para>If you specify a SubscriptionName, lists the
        /// description for that subscription.</para>
        /// </summary>
        /// 
        /// <param name="describeEventSubscriptionsRequest">Container for the necessary parameters to execute the DescribeEventSubscriptions service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionNotFoundException" />
		public DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return this.DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }
 
        /// <summary>
        /// <para> Describes all available options. </para>
        /// </summary>
        /// 
        /// <param name="describeOptionGroupOptionsRequest">Container for the necessary parameters to execute the DescribeOptionGroupOptions service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroupOptions service method, as returned by AmazonRDS.</returns>
		public DescribeOptionGroupOptionsResponse DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request)
        {
            var task = DescribeOptionGroupOptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroupOptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeOptionGroupOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroupOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeOptionGroupOptionsResponse> DescribeOptionGroupOptionsAsync(DescribeOptionGroupOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOptionGroupOptionsRequestMarshaller();
            var unmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeOptionGroupOptionsRequest, DescribeOptionGroupOptionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Describes the available option groups. </para>
        /// </summary>
        /// 
        /// <param name="describeOptionGroupsRequest">Container for the necessary parameters to execute the DescribeOptionGroups service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
		public DescribeOptionGroupsResponse DescribeOptionGroups(DescribeOptionGroupsRequest request)
        {
            var task = DescribeOptionGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeOptionGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeOptionGroupsResponse> DescribeOptionGroupsAsync(DescribeOptionGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOptionGroupsRequestMarshaller();
            var unmarshaller = DescribeOptionGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeOptionGroupsRequest, DescribeOptionGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Describes the available option groups. </para>
        /// </summary>
        /// 
        /// <param name="describeOptionGroupsRequest">Container for the necessary parameters to execute the DescribeOptionGroups service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
		public DescribeOptionGroupsResponse DescribeOptionGroups()
        {
            return this.DescribeOptionGroups(new DescribeOptionGroupsRequest());
        }
 
        /// <summary>
        /// <para> Returns a list of orderable DB Instance options for the specified engine. </para>
        /// </summary>
        /// 
        /// <param name="describeOrderableDBInstanceOptionsRequest">Container for the necessary parameters to execute the
        /// DescribeOrderableDBInstanceOptions service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by AmazonRDS.</returns>
		public DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request)
        {
            var task = DescribeOrderableDBInstanceOptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeOrderableDBInstanceOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeOrderableDBInstanceOptionsResponse> DescribeOrderableDBInstanceOptionsAsync(DescribeOrderableDBInstanceOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOrderableDBInstanceOptionsRequestMarshaller();
            var unmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeOrderableDBInstanceOptionsRequest, DescribeOrderableDBInstanceOptionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns information about reserved DB Instances for this account, or about a specified reserved DB Instance. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesRequest">Container for the necessary parameters to execute the DescribeReservedDBInstances service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstanceNotFoundException" />
		public DescribeReservedDBInstancesResponse DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request)
        {
            var task = DescribeReservedDBInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstances operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeReservedDBInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeReservedDBInstancesResponse> DescribeReservedDBInstancesAsync(DescribeReservedDBInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedDBInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeReservedDBInstancesRequest, DescribeReservedDBInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns information about reserved DB Instances for this account, or about a specified reserved DB Instance. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesRequest">Container for the necessary parameters to execute the DescribeReservedDBInstances service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstanceNotFoundException" />
		public DescribeReservedDBInstancesResponse DescribeReservedDBInstances()
        {
            return this.DescribeReservedDBInstances(new DescribeReservedDBInstancesRequest());
        }
 
        /// <summary>
        /// <para> Lists available reserved DB Instance offerings. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesOfferingsRequest">Container for the necessary parameters to execute the
        /// DescribeReservedDBInstancesOfferings service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException" />
		public DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request)
        {
            var task = DescribeReservedDBInstancesOfferingsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstancesOfferings operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DescribeReservedDBInstancesOfferings"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstancesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeReservedDBInstancesOfferingsResponse> DescribeReservedDBInstancesOfferingsAsync(DescribeReservedDBInstancesOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedDBInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeReservedDBInstancesOfferingsRequest, DescribeReservedDBInstancesOfferingsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Lists available reserved DB Instance offerings. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesOfferingsRequest">Container for the necessary parameters to execute the
        /// DescribeReservedDBInstancesOfferings service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException" />
		public DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings()
        {
            return this.DescribeReservedDBInstancesOfferings(new DescribeReservedDBInstancesOfferingsRequest());
        }
 
        /// <summary>
        /// <para> Downloads the last line of the specified log file. </para>
        /// </summary>
        /// 
        /// <param name="downloadDBLogFilePortionRequest">Container for the necessary parameters to execute the DownloadDBLogFilePortion service method
        /// on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DownloadDBLogFilePortion service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
		public DownloadDBLogFilePortionResponse DownloadDBLogFilePortion(DownloadDBLogFilePortionRequest request)
        {
            var task = DownloadDBLogFilePortionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDBLogFilePortion operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.DownloadDBLogFilePortion"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DownloadDBLogFilePortionResponse> DownloadDBLogFilePortionAsync(DownloadDBLogFilePortionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DownloadDBLogFilePortionRequestMarshaller();
            var unmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DownloadDBLogFilePortionRequest, DownloadDBLogFilePortionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Downloads the last line of the specified log file. </para>
        /// </summary>
        /// 
        /// <param name="downloadDBLogFilePortionRequest">Container for the necessary parameters to execute the DownloadDBLogFilePortion service method
        /// on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DownloadDBLogFilePortion service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
		public DownloadDBLogFilePortionResponse DownloadDBLogFilePortion()
        {
            return this.DownloadDBLogFilePortion(new DownloadDBLogFilePortionRequest());
        }
 
        /// <summary>
        /// <para> Lists all tags on a DB Instance.</para> <para>For an overview on tagging DB Instances, see DB Instance Tags. </para>
        /// </summary>
        /// 
        /// <param name="listTagsForResourceRequest">Container for the necessary parameters to execute the ListTagsForResource service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
		public ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var task = ListTagsForResourceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ListTagsForResource"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListTagsForResourceRequest, ListTagsForResourceResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Modify settings for a DB Instance. You can change one or more database configuration parameters by specifying these parameters and
        /// the new values in the request. </para>
        /// </summary>
        /// 
        /// <param name="modifyDBInstanceRequest">Container for the necessary parameters to execute the ModifyDBInstance service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.StorageQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSecurityGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InsufficientDBInstanceCapacityException" />
        /// <exception cref="T:Amazon.RDS.Model.DBUpgradeDependencyFailureException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException" />
		public ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request)
        {
            var task = ModifyDBInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyDBInstance"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ModifyDBInstanceResponse> ModifyDBInstanceAsync(ModifyDBInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var unmarshaller = ModifyDBInstanceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyDBInstanceRequest, ModifyDBInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Modifies the parameters of a DBParameterGroup. To modify more than one parameter submit a list of the following: ParameterName,
        /// ParameterValue, and ApplyMethod. A maximum of 20 parameters can be modified in a single request. </para> <para><b>NOTE:</b> The
        /// apply-immediate method can be used only for dynamic parameters; the pending-reboot method can be used with MySQL and Oracle DB Instances for
        /// either dynamic or static parameters. For Microsoft SQL Server DB Instances, the pending-reboot method can be used only for static
        /// parameters. </para>
        /// </summary>
        /// 
        /// <param name="modifyDBParameterGroupRequest">Container for the necessary parameters to execute the ModifyDBParameterGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBParameterGroupStateException" />
		public ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest request)
        {
            var task = ModifyDBParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ModifyDBParameterGroupResponse> ModifyDBParameterGroupAsync(ModifyDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDBParameterGroupRequestMarshaller();
            var unmarshaller = ModifyDBParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyDBParameterGroupRequest, ModifyDBParameterGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Modifies an existing DB subnet group. DB subnet groups must contain at least one subnet in at least two AZs in the region. </para>
        /// </summary>
        /// 
        /// <param name="modifyDBSubnetGroupRequest">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.SubnetAlreadyInUseException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
		public ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request)
        {
            var task = ModifyDBSubnetGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyDBSubnetGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ModifyDBSubnetGroupResponse> ModifyDBSubnetGroupAsync(ModifyDBSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDBSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyDBSubnetGroupRequest, ModifyDBSubnetGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Modifies an existing RDS event notification subscription. Note that you cannot modify the source identifiers using this call; to
        /// change source identifiers for a subscription, use the AddSourceIdentifierToSubscription and RemoveSourceIdentifierFromSubscription
        /// calls.</para> <para>You can see a list of the event categories for a given SourceType in the Events topic in the Amazon RDS User Guide or by
        /// using the <b>DescribeEventCategories</b> action.</para>
        /// </summary>
        /// 
        /// <param name="modifyEventSubscriptionRequest">Container for the necessary parameters to execute the ModifyEventSubscription service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.SNSTopicArnNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SNSInvalidTopicException" />
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionCategoryNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SNSNoAuthorizationException" />
        /// <exception cref="T:Amazon.RDS.Model.EventSubscriptionQuotaExceededException" />
		public ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var task = ModifyEventSubscriptionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyEventSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyEventSubscriptionRequest, ModifyEventSubscriptionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Modifies an existing Option Group. </para>
        /// </summary>
        /// 
        /// <param name="modifyOptionGroupRequest">Container for the necessary parameters to execute the ModifyOptionGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyOptionGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.InvalidOptionGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
		public ModifyOptionGroupResponse ModifyOptionGroup(ModifyOptionGroupRequest request)
        {
            var task = ModifyOptionGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ModifyOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ModifyOptionGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ModifyOptionGroupResponse> ModifyOptionGroupAsync(ModifyOptionGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyOptionGroupRequestMarshaller();
            var unmarshaller = ModifyOptionGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyOptionGroupRequest, ModifyOptionGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Promotes a Read Replica DB Instance to a standalone DB Instance. </para>
        /// </summary>
        /// 
        /// <param name="promoteReadReplicaRequest">Container for the necessary parameters to execute the PromoteReadReplica service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the PromoteReadReplica service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
		public PromoteReadReplicaResponse PromoteReadReplica(PromoteReadReplicaRequest request)
        {
            var task = PromoteReadReplicaAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the PromoteReadReplica operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.PromoteReadReplica"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplica operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<PromoteReadReplicaResponse> PromoteReadReplicaAsync(PromoteReadReplicaRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PromoteReadReplicaRequestMarshaller();
            var unmarshaller = PromoteReadReplicaResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, PromoteReadReplicaRequest, PromoteReadReplicaResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Purchases a reserved DB Instance offering. </para>
        /// </summary>
        /// 
        /// <param name="purchaseReservedDBInstancesOfferingRequest">Container for the necessary parameters to execute the
        /// PurchaseReservedDBInstancesOffering service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the PurchaseReservedDBInstancesOffering service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstanceQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstanceAlreadyExistsException" />
		public PurchaseReservedDBInstancesOfferingResponse PurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest request)
        {
            var task = PurchaseReservedDBInstancesOfferingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedDBInstancesOffering operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.PurchaseReservedDBInstancesOffering"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedDBInstancesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<PurchaseReservedDBInstancesOfferingResponse> PurchaseReservedDBInstancesOfferingAsync(PurchaseReservedDBInstancesOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedDBInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, PurchaseReservedDBInstancesOfferingRequest, PurchaseReservedDBInstancesOfferingResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Reboots a previously provisioned RDS instance. This API results in the application of modified DBParameterGroup parameters with
        /// ApplyStatus of pending-reboot to the RDS instance. This action is taken as soon as possible, and results in a momentary outage to the RDS
        /// instance during which the RDS instance status is set to rebooting. If the RDS instance is configured for MultiAZ, it is possible that the
        /// reboot will be conducted through a failover. A DBInstance event is created when the reboot is completed. </para>
        /// </summary>
        /// 
        /// <param name="rebootDBInstanceRequest">Container for the necessary parameters to execute the RebootDBInstance service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
		public RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request)
        {
            var task = RebootDBInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RebootDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RebootDBInstance"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<RebootDBInstanceResponse> RebootDBInstanceAsync(RebootDBInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootDBInstanceRequestMarshaller();
            var unmarshaller = RebootDBInstanceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RebootDBInstanceRequest, RebootDBInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para>Removes a source identifier from an existing RDS event notification subscription.</para>
        /// </summary>
        /// 
        /// <param name="removeSourceIdentifierFromSubscriptionRequest">Container for the necessary parameters to execute the
        /// RemoveSourceIdentifierFromSubscription service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RemoveSourceIdentifierFromSubscription service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.SourceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.SubscriptionNotFoundException" />
		public RemoveSourceIdentifierFromSubscriptionResponse RemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request)
        {
            var task = RemoveSourceIdentifierFromSubscriptionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RemoveSourceIdentifierFromSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RemoveSourceIdentifierFromSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<RemoveSourceIdentifierFromSubscriptionResponse> RemoveSourceIdentifierFromSubscriptionAsync(RemoveSourceIdentifierFromSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveSourceIdentifierFromSubscriptionRequestMarshaller();
            var unmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RemoveSourceIdentifierFromSubscriptionRequest, RemoveSourceIdentifierFromSubscriptionResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Removes metadata tags from a DB Instance.</para> <para>For an overview on tagging DB Instances, see DB Instance Tags. </para>
        /// </summary>
        /// 
        /// <param name="removeTagsFromResourceRequest">Container for the necessary parameters to execute the RemoveTagsFromResource service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
		public RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var task = RemoveTagsFromResourceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RemoveTagsFromResource"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RemoveTagsFromResourceRequest, RemoveTagsFromResourceResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Modifies the parameters of a DBParameterGroup to the engine/system default value. To reset specific parameters submit a list of the
        /// following: ParameterName and ApplyMethod. To reset the entire DBParameterGroup specify the DBParameterGroup name and ResetAllParameters
        /// parameters. When resetting the entire group, dynamic parameters are updated immediately and static parameters are set to pending-reboot to
        /// take effect on the next DB instance restart or RebootDBInstance request. </para>
        /// </summary>
        /// 
        /// <param name="resetDBParameterGroupRequest">Container for the necessary parameters to execute the ResetDBParameterGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBParameterGroupStateException" />
		public ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest request)
        {
            var task = ResetDBParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.ResetDBParameterGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ResetDBParameterGroupResponse> ResetDBParameterGroupAsync(ResetDBParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetDBParameterGroupRequestMarshaller();
            var unmarshaller = ResetDBParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ResetDBParameterGroupRequest, ResetDBParameterGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates a new DB Instance from a DB snapshot. The target database is created from the source database restore point with the same
        /// configuration as the original source database, except that the new RDS instance is created with the default security group. </para>
        /// </summary>
        /// 
        /// <param name="restoreDBInstanceFromDBSnapshotRequest">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot
        /// service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceFromDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSnapshotStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidRestoreException" />
        /// <exception cref="T:Amazon.RDS.Model.InstanceQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.StorageQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.InsufficientDBInstanceCapacityException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException" />
		public RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest request)
        {
            var task = RestoreDBInstanceFromDBSnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceFromDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RestoreDBInstanceFromDBSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<RestoreDBInstanceFromDBSnapshotResponse> RestoreDBInstanceFromDBSnapshotAsync(RestoreDBInstanceFromDBSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var unmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RestoreDBInstanceFromDBSnapshotRequest, RestoreDBInstanceFromDBSnapshotResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Restores a DB Instance to an arbitrary point-in-time. Users can restore to any point in time before the latestRestorableTime for up
        /// to backupRetentionPeriod days. The target database is created from the source database with the same configuration as the original database
        /// except that the DB instance is created with the default DB security group. </para>
        /// </summary>
        /// 
        /// <param name="restoreDBInstanceToPointInTimeRequest">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime
        /// service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceToPointInTime service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.PointInTimeRestoreNotEnabledException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidRestoreException" />
        /// <exception cref="T:Amazon.RDS.Model.InstanceQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.StorageQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InsufficientDBInstanceCapacityException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException" />
		public RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest request)
        {
            var task = RestoreDBInstanceToPointInTimeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceToPointInTime operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RestoreDBInstanceToPointInTime"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<RestoreDBInstanceToPointInTimeResponse> RestoreDBInstanceToPointInTimeAsync(RestoreDBInstanceToPointInTimeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var unmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RestoreDBInstanceToPointInTimeRequest, RestoreDBInstanceToPointInTimeResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Revokes ingress from a DBSecurityGroup for previously authorized IP ranges or EC2 or VPC Security Groups. Required parameters for
        /// this API are one of CIDRIP, EC2SecurityGroupId for VPC, or (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId).
        /// </para>
        /// </summary>
        /// 
        /// <param name="revokeDBSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RevokeDBSecurityGroupIngress service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSecurityGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.AuthorizationNotFoundException" />
		public RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest request)
        {
            var task = RevokeDBSecurityGroupIngressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RevokeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS.RevokeDBSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<RevokeDBSecurityGroupIngressResponse> RevokeDBSecurityGroupIngressAsync(RevokeDBSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeDBSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RevokeDBSecurityGroupIngressRequest, RevokeDBSecurityGroupIngressResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
