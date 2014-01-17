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
    /// RDS automatically backs up your database and maintains the database software that powers your DB instance. Amazon RDS is flexible: you can
    /// scale your database instance's compute resources and storage capacity to meet your application's demand. As with all Amazon Web Services,
    /// there are no up-front investments, and you pay only for the resources you use. </para> <para> This is an interface reference for Amazon RDS.
    /// It contains documentation for a programming or command line interface you can use to manage Amazon RDS. Note that Amazon RDS is
    /// asynchronous, which means that some interfaces may require techniques such as polling or callback functions to determine when a command has
    /// been applied. In this reference, the parameter descriptions indicate whether a command is applied immediately, on the next instance reboot,
    /// or during the maintenance window. For a summary of the Amazon RDS interfaces, go to <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Welcome.html#Welcome.Interfaces">Available RDS Interfaces</a> .
    /// </para>
    /// </summary>
	public partial class AmazonRDSClient : AmazonWebServiceClient, Amazon.RDS.IAmazonRDS
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

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
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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

 
		internal AddSourceIdentifierToSubscriptionResponse AddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AddSourceIdentifierToSubscriptionResponse> AddSourceIdentifierToSubscriptionAsync(AddSourceIdentifierToSubscriptionRequest addSourceIdentifierToSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddSourceIdentifierToSubscriptionRequestMarshaller();
            var unmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AddSourceIdentifierToSubscriptionRequest, AddSourceIdentifierToSubscriptionResponse>(addSourceIdentifierToSubscriptionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
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
        /// <para> Adds metadata tags to an Amazon RDS resource. These tags can also be used with cost allocation reporting to track cost associated
        /// with Amazon RDS resources, or used in Condition statement in IAM policy for Amazon RDS.</para> <para>For an overview on tagging Amazon RDS
        /// resources, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging Amazon RDS Resources</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="addTagsToResourceRequest">Container for the necessary parameters to execute the AddTagsToResource service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest addTagsToResourceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AddTagsToResourceRequest, AddTagsToResourceResponse>(addTagsToResourceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest request)
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
        /// <para> Enables ingress to a DBSecurityGroup using one of two forms of authorization. First, EC2 or VPC security groups can be added to the
        /// DBSecurityGroup if the application using the database is running on EC2 or VPC instances. Second, IP ranges are available if the application
        /// accessing your database is running on the Internet. Required parameters for this API are one of CIDR range, EC2SecurityGroupId for VPC, or
        /// (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId for non-VPC). </para> <para><b>NOTE:</b> You cannot authorize
        /// ingress from an EC2 security group in one Region to an Amazon RDS DB instance in another. You cannot authorize ingress from a VPC security
        /// group in one VPC to an Amazon RDS DB instance in another. </para> <para>For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia Tutorial</a> .
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AuthorizeDBSecurityGroupIngressResponse> AuthorizeDBSecurityGroupIngressAsync(AuthorizeDBSecurityGroupIngressRequest authorizeDBSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeDBSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AuthorizeDBSecurityGroupIngressRequest, AuthorizeDBSecurityGroupIngressResponse>(authorizeDBSecurityGroupIngressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CopyDBSnapshotResponse CopyDBSnapshot(CopyDBSnapshotRequest request)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CopyDBSnapshotResponse> CopyDBSnapshotAsync(CopyDBSnapshotRequest copyDBSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var unmarshaller = CopyDBSnapshotResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CopyDBSnapshotRequest, CopyDBSnapshotResponse>(copyDBSnapshotRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest createDBInstanceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var unmarshaller = CreateDBInstanceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateDBInstanceRequest, CreateDBInstanceResponse>(createDBInstanceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateDBInstanceReadReplicaResponse CreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest request)
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
        /// <para> Creates a DB instance that acts as a read replica of a source DB instance. </para> <para> All read replica DB instances are created
        /// as Single-AZ deployments with backups disabled. All other DB instance attributes (including DB security groups and DB parameter groups) are
        /// inherited from the source DB instance, except as specified below. </para> <para><b>IMPORTANT:</b> The source DB instance must have backup
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
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSubnetGroupException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.RDS.Model.InstanceQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotAllowedException" />
        /// <exception cref="T:Amazon.RDS.Model.StorageQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.InsufficientDBInstanceCapacityException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateDBInstanceReadReplicaResponse> CreateDBInstanceReadReplicaAsync(CreateDBInstanceReadReplicaRequest createDBInstanceReadReplicaRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var unmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateDBInstanceReadReplicaRequest, CreateDBInstanceReadReplicaResponse>(createDBInstanceReadReplicaRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest request)
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
        /// <para> Creates a new DB parameter group. </para> <para> A DB parameter group is initially created with the default parameters for the
        /// database engine used by the DB instance. To provide custom values for any of the parameters, you must modify the group after creating it
        /// using <i>ModifyDBParameterGroup</i> . Once you've created a DB parameter group, you need to associate it with your DB instance using
        /// <i>ModifyDBInstance</i> . When you associate a new DB parameter group with a running DB instance, you need to reboot the DB Instance for the
        /// new DB parameter group and associated settings to take effect. </para>
        /// </summary>
        /// 
        /// <param name="createDBParameterGroupRequest">Container for the necessary parameters to execute the CreateDBParameterGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupAlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateDBParameterGroupResponse> CreateDBParameterGroupAsync(CreateDBParameterGroupRequest createDBParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBParameterGroupRequestMarshaller();
            var unmarshaller = CreateDBParameterGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateDBParameterGroupRequest, CreateDBParameterGroupResponse>(createDBParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest request)
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
        /// <para> Creates a new DB security group. DB security groups control access to a DB instance. </para>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateDBSecurityGroupResponse> CreateDBSecurityGroupAsync(CreateDBSecurityGroupRequest createDBSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBSecurityGroupRequestMarshaller();
            var unmarshaller = CreateDBSecurityGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateDBSecurityGroupRequest, CreateDBSecurityGroupResponse>(createDBSecurityGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest request)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateDBSnapshotResponse> CreateDBSnapshotAsync(CreateDBSnapshotRequest createDBSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBSnapshotRequestMarshaller();
            var unmarshaller = CreateDBSnapshotResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateDBSnapshotRequest, CreateDBSnapshotResponse>(createDBSnapshotRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest request)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateDBSubnetGroupResponse> CreateDBSubnetGroupAsync(CreateDBSubnetGroupRequest createDBSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBSubnetGroupRequestMarshaller();
            var unmarshaller = CreateDBSubnetGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateDBSubnetGroupRequest, CreateDBSubnetGroupResponse>(createDBSubnetGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest createEventSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateEventSubscriptionRequest, CreateEventSubscriptionResponse>(createEventSubscriptionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateOptionGroupResponse CreateOptionGroup(CreateOptionGroupRequest request)
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
        /// <para> Creates a new option group. You can create up to 20 option groups. </para>
        /// </summary>
        /// 
        /// <param name="createOptionGroupRequest">Container for the necessary parameters to execute the CreateOptionGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the CreateOptionGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateOptionGroupResponse> CreateOptionGroupAsync(CreateOptionGroupRequest createOptionGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateOptionGroupRequestMarshaller();
            var unmarshaller = CreateOptionGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateOptionGroupRequest, CreateOptionGroupResponse>(createOptionGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
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
        /// <para> The DeleteDBInstance action deletes a previously provisioned DB instance. A successful response from the web service indicates the
        /// request was received correctly. When you delete a DB instance, all automated backups for that instance are deleted and cannot be recovered.
        /// Manual DB snapshots of the DB instance to be deleted are not deleted. </para> <para> If a final DB snapshot is requested the status of the
        /// RDS instance will be "deleting" until the DB snapshot is created. The API action <c>DescribeDBInstance</c> is used to monitor the status of
        /// this operation. The action cannot be canceled or reverted once submitted. </para>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest deleteDBInstanceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var unmarshaller = DeleteDBInstanceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteDBInstanceRequest, DeleteDBInstanceResponse>(deleteDBInstanceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest request)
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
        /// <para> Deletes a specified DBParameterGroup. The DBParameterGroup cannot be associated with any RDS instances to be deleted. </para>
        /// <para><b>NOTE:</b> The specified DB parameter group cannot be associated with any DB instances. </para>
        /// </summary>
        /// 
        /// <param name="deleteDBParameterGroupRequest">Container for the necessary parameters to execute the DeleteDBParameterGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBParameterGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteDBParameterGroupResponse> DeleteDBParameterGroupAsync(DeleteDBParameterGroupRequest deleteDBParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBParameterGroupRequestMarshaller();
            var unmarshaller = DeleteDBParameterGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteDBParameterGroupRequest, DeleteDBParameterGroupResponse>(deleteDBParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest request)
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
        /// <para> Deletes a DB security group. </para> <para><b>NOTE:</b>The specified DB security group must not be associated with any DB
        /// instances.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSecurityGroupRequest">Container for the necessary parameters to execute the DeleteDBSecurityGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSecurityGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteDBSecurityGroupResponse> DeleteDBSecurityGroupAsync(DeleteDBSecurityGroupRequest deleteDBSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteDBSecurityGroupRequest, DeleteDBSecurityGroupResponse>(deleteDBSecurityGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest request)
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
        /// <para> Deletes a DBSnapshot. If the snapshot is being copied, the copy operation is terminated. </para> <para><b>NOTE:</b>The DBSnapshot
        /// must be in the available state to be deleted.</para>
        /// </summary>
        /// 
        /// <param name="deleteDBSnapshotRequest">Container for the necessary parameters to execute the DeleteDBSnapshot service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DeleteDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSnapshotStateException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteDBSnapshotResponse> DeleteDBSnapshotAsync(DeleteDBSnapshotRequest deleteDBSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBSnapshotRequestMarshaller();
            var unmarshaller = DeleteDBSnapshotResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteDBSnapshotRequest, DeleteDBSnapshotResponse>(deleteDBSnapshotRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteDBSubnetGroupResponse> DeleteDBSubnetGroupAsync(DeleteDBSubnetGroupRequest deleteDBSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteDBSubnetGroupRequest, DeleteDBSubnetGroupResponse>(deleteDBSubnetGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest deleteEventSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteEventSubscriptionRequest, DeleteEventSubscriptionResponse>(deleteEventSubscriptionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteOptionGroupResponse DeleteOptionGroup(DeleteOptionGroupRequest request)
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
        /// <para> Deletes an existing option group. </para>
        /// </summary>
        /// 
        /// <param name="deleteOptionGroupRequest">Container for the necessary parameters to execute the DeleteOptionGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.InvalidOptionGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteOptionGroupResponse> DeleteOptionGroupAsync(DeleteOptionGroupRequest deleteOptionGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteOptionGroupRequestMarshaller();
            var unmarshaller = DeleteOptionGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteOptionGroupRequest, DeleteOptionGroupResponse>(deleteOptionGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request)
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
        /// <para> Returns a list of the available DB engines. </para>
        /// </summary>
        /// 
        /// <param name="describeDBEngineVersionsRequest">Container for the necessary parameters to execute the DescribeDBEngineVersions service method
        /// on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by AmazonRDS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(DescribeDBEngineVersionsRequest describeDBEngineVersionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBEngineVersionsRequestMarshaller();
            var unmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeDBEngineVersionsRequest, DescribeDBEngineVersionsResponse>(describeDBEngineVersionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
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
        /// <para> Returns information about provisioned RDS instances. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <param name="describeDBInstancesRequest">Container for the necessary parameters to execute the DescribeDBInstances service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest describeDBInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBInstancesRequestMarshaller();
            var unmarshaller = DescribeDBInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeDBInstancesRequest, DescribeDBInstancesResponse>(describeDBInstancesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeDBLogFilesResponse DescribeDBLogFiles(DescribeDBLogFilesRequest request)
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
        /// <para> Returns a list of DB log files for the DB instance. </para>
        /// </summary>
        /// 
        /// <param name="describeDBLogFilesRequest">Container for the necessary parameters to execute the DescribeDBLogFiles service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBLogFiles service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeDBLogFilesResponse> DescribeDBLogFilesAsync(DescribeDBLogFilesRequest describeDBLogFilesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBLogFilesRequestMarshaller();
            var unmarshaller = DescribeDBLogFilesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeDBLogFilesRequest, DescribeDBLogFilesResponse>(describeDBLogFilesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request)
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
        /// <para> Returns a list of <c>DBParameterGroup</c> descriptions. If a <c>DBParameterGroupName</c> is specified, the list will contain only the
        /// description of the specified DB parameter group. </para>
        /// </summary>
        /// 
        /// <param name="describeDBParameterGroupsRequest">Container for the necessary parameters to execute the DescribeDBParameterGroups service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(DescribeDBParameterGroupsRequest describeDBParameterGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeDBParameterGroupsRequest, DescribeDBParameterGroupsResponse>(describeDBParameterGroupsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest request)
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
        /// <para> Returns the detailed parameter list for a particular DB parameter group. </para>
        /// </summary>
        /// 
        /// <param name="describeDBParametersRequest">Container for the necessary parameters to execute the DescribeDBParameters service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBParameters service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeDBParametersResponse> DescribeDBParametersAsync(DescribeDBParametersRequest describeDBParametersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBParametersRequestMarshaller();
            var unmarshaller = DescribeDBParametersResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeDBParametersRequest, DescribeDBParametersResponse>(describeDBParametersRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request)
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
        /// <para> Returns a list of <c>DBSecurityGroup</c> descriptions. If a <c>DBSecurityGroupName</c> is specified, the list will contain only the
        /// descriptions of the specified DB security group. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeDBSecurityGroups service method
        /// on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(DescribeDBSecurityGroupsRequest describeDBSecurityGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeDBSecurityGroupsRequest, DescribeDBSecurityGroupsResponse>(describeDBSecurityGroupsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest request)
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
        /// <para> Returns information about DB snapshots. This API supports pagination. </para>
        /// </summary>
        /// 
        /// <param name="describeDBSnapshotsRequest">Container for the necessary parameters to execute the DescribeDBSnapshots service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeDBSnapshotsResponse> DescribeDBSnapshotsAsync(DescribeDBSnapshotsRequest describeDBSnapshotsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBSnapshotsRequestMarshaller();
            var unmarshaller = DescribeDBSnapshotsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeDBSnapshotsRequest, DescribeDBSnapshotsResponse>(describeDBSnapshotsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request)
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
        /// <para> Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified, the list will contain only the descriptions of the
        /// specified DBSubnetGroup. </para> <para>For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia Tutorial</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeDBSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(DescribeDBSubnetGroupsRequest describeDBSubnetGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeDBSubnetGroupsRequest, DescribeDBSubnetGroupsResponse>(describeDBSubnetGroupsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
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
        /// <para> Returns the default engine and system parameter information for the specified database engine. </para>
        /// </summary>
        /// 
        /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        /// service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by AmazonRDS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEngineDefaultParametersRequestMarshaller();
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeEngineDefaultParametersRequest, DescribeEngineDefaultParametersResponse>(describeEngineDefaultParametersRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
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
        /// <para>Displays a list of categories for all event source types, or, if specified, for a specified source type. You can see a list of the
        /// event categories and source types in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html"> Events</a> topic
        /// in the Amazon RDS User Guide.</para>
        /// </summary>
        /// 
        /// <param name="describeEventCategoriesRequest">Container for the necessary parameters to execute the DescribeEventCategories service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by AmazonRDS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest describeEventCategoriesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeEventCategoriesRequest, DescribeEventCategoriesResponse>(describeEventCategoriesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
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
        /// <para> Returns events related to DB instances, DB security groups, DB snapshots, and DB parameter groups for the past 14 days. Events
        /// specific to a particular DB instance, DB security group, database snapshot, or DB parameter group can be obtained by providing the name as a
        /// parameter. By default, the past hour of events are returned. </para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRDS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest describeEventsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeEventsRequest, DescribeEventsResponse>(describeEventsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest describeEventSubscriptionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeEventSubscriptionsRequest, DescribeEventSubscriptionsResponse>(describeEventSubscriptionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeOptionGroupOptionsResponse DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request)
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
        /// <para> Describes all available options. </para>
        /// </summary>
        /// 
        /// <param name="describeOptionGroupOptionsRequest">Container for the necessary parameters to execute the DescribeOptionGroupOptions service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroupOptions service method, as returned by AmazonRDS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeOptionGroupOptionsResponse> DescribeOptionGroupOptionsAsync(DescribeOptionGroupOptionsRequest describeOptionGroupOptionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOptionGroupOptionsRequestMarshaller();
            var unmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeOptionGroupOptionsRequest, DescribeOptionGroupOptionsResponse>(describeOptionGroupOptionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeOptionGroupsResponse DescribeOptionGroups(DescribeOptionGroupsRequest request)
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
        /// <para> Describes the available option groups. </para>
        /// </summary>
        /// 
        /// <param name="describeOptionGroupsRequest">Container for the necessary parameters to execute the DescribeOptionGroups service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeOptionGroupsResponse> DescribeOptionGroupsAsync(DescribeOptionGroupsRequest describeOptionGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOptionGroupsRequestMarshaller();
            var unmarshaller = DescribeOptionGroupsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeOptionGroupsRequest, DescribeOptionGroupsResponse>(describeOptionGroupsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request)
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
        /// <para> Returns a list of orderable DB instance options for the specified engine. </para>
        /// </summary>
        /// 
        /// <param name="describeOrderableDBInstanceOptionsRequest">Container for the necessary parameters to execute the
        /// DescribeOrderableDBInstanceOptions service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by AmazonRDS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeOrderableDBInstanceOptionsResponse> DescribeOrderableDBInstanceOptionsAsync(DescribeOrderableDBInstanceOptionsRequest describeOrderableDBInstanceOptionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOrderableDBInstanceOptionsRequestMarshaller();
            var unmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeOrderableDBInstanceOptionsRequest, DescribeOrderableDBInstanceOptionsResponse>(describeOrderableDBInstanceOptionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeReservedDBInstancesResponse DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request)
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
        /// <para> Returns information about reserved DB instances for this account, or about a specified reserved DB instance. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesRequest">Container for the necessary parameters to execute the DescribeReservedDBInstances service
        /// method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstanceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeReservedDBInstancesResponse> DescribeReservedDBInstancesAsync(DescribeReservedDBInstancesRequest describeReservedDBInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedDBInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeReservedDBInstancesRequest, DescribeReservedDBInstancesResponse>(describeReservedDBInstancesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request)
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
        /// <para> Lists available reserved DB instance offerings. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedDBInstancesOfferingsRequest">Container for the necessary parameters to execute the
        /// DescribeReservedDBInstancesOfferings service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeReservedDBInstancesOfferingsResponse> DescribeReservedDBInstancesOfferingsAsync(DescribeReservedDBInstancesOfferingsRequest describeReservedDBInstancesOfferingsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedDBInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeReservedDBInstancesOfferingsRequest, DescribeReservedDBInstancesOfferingsResponse>(describeReservedDBInstancesOfferingsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DownloadDBLogFilePortionResponse DownloadDBLogFilePortion(DownloadDBLogFilePortionRequest request)
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
        /// <para> Downloads the last line of the specified log file. </para>
        /// </summary>
        /// 
        /// <param name="downloadDBLogFilePortionRequest">Container for the necessary parameters to execute the DownloadDBLogFilePortion service method
        /// on AmazonRDS.</param>
        /// 
        /// <returns>The response from the DownloadDBLogFilePortion service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DownloadDBLogFilePortionResponse> DownloadDBLogFilePortionAsync(DownloadDBLogFilePortionRequest downloadDBLogFilePortionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DownloadDBLogFilePortionRequestMarshaller();
            var unmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DownloadDBLogFilePortionRequest, DownloadDBLogFilePortionResponse>(downloadDBLogFilePortionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
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
        /// <para> Lists all tags on an Amazon RDS resource.</para> <para>For an overview on tagging an Amazon RDS resource, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging Amazon RDS Resources</a> .</para>
        /// </summary>
        /// 
        /// <param name="listTagsForResourceRequest">Container for the necessary parameters to execute the ListTagsForResource service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest listTagsForResourceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListTagsForResourceRequest, ListTagsForResourceResponse>(listTagsForResourceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request)
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
        /// <para> Modify settings for a DB instance. You can change one or more database configuration parameters by specifying these parameters and
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyDBInstanceResponse> ModifyDBInstanceAsync(ModifyDBInstanceRequest modifyDBInstanceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var unmarshaller = ModifyDBInstanceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyDBInstanceRequest, ModifyDBInstanceResponse>(modifyDBInstanceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest request)
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
        /// <para> Modifies the parameters of a DB parameter group. To modify more than one parameter, submit a list of the following:
        /// <c>ParameterName</c> ,
        /// <c>ParameterValue</c> , and <c>ApplyMethod</c> . A maximum of 20 parameters can be modified in a single request. </para>
        /// <para><b>NOTE:</b> The apply-immediate method can be used only for dynamic parameters; the pending-reboot method can be used with MySQL and
        /// Oracle DB instances for either dynamic or static parameters. For Microsoft SQL Server DB instances, the pending-reboot method can be used
        /// only for static parameters. </para>
        /// </summary>
        /// 
        /// <param name="modifyDBParameterGroupRequest">Container for the necessary parameters to execute the ModifyDBParameterGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBParameterGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyDBParameterGroupResponse> ModifyDBParameterGroupAsync(ModifyDBParameterGroupRequest modifyDBParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDBParameterGroupRequestMarshaller();
            var unmarshaller = ModifyDBParameterGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyDBParameterGroupRequest, ModifyDBParameterGroupResponse>(modifyDBParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyDBSubnetGroupResponse> ModifyDBSubnetGroupAsync(ModifyDBSubnetGroupRequest modifyDBSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDBSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyDBSubnetGroupRequest, ModifyDBSubnetGroupResponse>(modifyDBSubnetGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
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
        /// <para>Modifies an existing RDS event notification subscription. Note that you cannot modify the source identifiers using this call; to
        /// change source identifiers for a subscription, use the AddSourceIdentifierToSubscription and RemoveSourceIdentifierFromSubscription
        /// calls.</para> <para>You can see a list of the event categories for a given SourceType in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">Events</a> topic in the Amazon RDS User Guide or by using the
        /// <b>DescribeEventCategories</b> action.</para>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest modifyEventSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyEventSubscriptionRequest, ModifyEventSubscriptionResponse>(modifyEventSubscriptionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyOptionGroupResponse ModifyOptionGroup(ModifyOptionGroupRequest request)
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
        /// <para> Modifies an existing option group. </para>
        /// </summary>
        /// 
        /// <param name="modifyOptionGroupRequest">Container for the necessary parameters to execute the ModifyOptionGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ModifyOptionGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.InvalidOptionGroupStateException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyOptionGroupResponse> ModifyOptionGroupAsync(ModifyOptionGroupRequest modifyOptionGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyOptionGroupRequestMarshaller();
            var unmarshaller = ModifyOptionGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyOptionGroupRequest, ModifyOptionGroupResponse>(modifyOptionGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PromoteReadReplicaResponse PromoteReadReplica(PromoteReadReplicaRequest request)
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
        /// <para> Promotes a read replica DB instance to a standalone DB instance. </para>
        /// </summary>
        /// 
        /// <param name="promoteReadReplicaRequest">Container for the necessary parameters to execute the PromoteReadReplica service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the PromoteReadReplica service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PromoteReadReplicaResponse> PromoteReadReplicaAsync(PromoteReadReplicaRequest promoteReadReplicaRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PromoteReadReplicaRequestMarshaller();
            var unmarshaller = PromoteReadReplicaResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PromoteReadReplicaRequest, PromoteReadReplicaResponse>(promoteReadReplicaRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PurchaseReservedDBInstancesOfferingResponse PurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest request)
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
        /// <para> Purchases a reserved DB instance offering. </para>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PurchaseReservedDBInstancesOfferingResponse> PurchaseReservedDBInstancesOfferingAsync(PurchaseReservedDBInstancesOfferingRequest purchaseReservedDBInstancesOfferingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedDBInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PurchaseReservedDBInstancesOfferingRequest, PurchaseReservedDBInstancesOfferingResponse>(purchaseReservedDBInstancesOfferingRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request)
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
        /// <para> Rebooting a DB instance restarts the database engine service. A reboot also applies to the DB instance any modifications to the
        /// associated DB parameter group that were pending. Rebooting a DB instance results in a momentary outage of the instance, during which the DB
        /// instance status is set to rebooting. If the RDS instance is configured for MultiAZ, it is possible that the reboot will be conducted through
        /// a failover. An Amazon RDS event is created when the reboot is completed. </para> <para> If your DB instance is deployed in multiple
        /// Availability Zones, you can force a failover from one AZ to the other during the reboot. You might force a failover to test the availability
        /// of your DB instance deployment or to restore operations to the original AZ after a failover occurs. </para> <para> The time required to
        /// reboot is a function of the specific database engine's crash recovery process. To improve the reboot time, we recommend that you reduce
        /// database activities as much as possible during the reboot process to reduce rollback activity for in-transit transactions. </para>
        /// </summary>
        /// 
        /// <param name="rebootDBInstanceRequest">Container for the necessary parameters to execute the RebootDBInstance service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RebootDBInstanceResponse> RebootDBInstanceAsync(RebootDBInstanceRequest rebootDBInstanceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootDBInstanceRequestMarshaller();
            var unmarshaller = RebootDBInstanceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RebootDBInstanceRequest, RebootDBInstanceResponse>(rebootDBInstanceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RemoveSourceIdentifierFromSubscriptionResponse RemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RemoveSourceIdentifierFromSubscriptionResponse> RemoveSourceIdentifierFromSubscriptionAsync(RemoveSourceIdentifierFromSubscriptionRequest removeSourceIdentifierFromSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveSourceIdentifierFromSubscriptionRequestMarshaller();
            var unmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RemoveSourceIdentifierFromSubscriptionRequest, RemoveSourceIdentifierFromSubscriptionResponse>(removeSourceIdentifierFromSubscriptionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
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
        /// <para> Removes metadata tags from an Amazon RDS resource.</para> <para>For an overview on tagging an Amazon RDS resource, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging Amazon RDS Resources</a> .</para>
        /// </summary>
        /// 
        /// <param name="removeTagsFromResourceRequest">Container for the necessary parameters to execute the RemoveTagsFromResource service method on
        /// AmazonRDS.</param>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest removeTagsFromResourceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RemoveTagsFromResourceRequest, RemoveTagsFromResourceResponse>(removeTagsFromResourceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest request)
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
        /// <para> Modifies the parameters of a DB parameter group to the engine/system default value. To reset specific parameters submit a list of the
        /// following: <c>ParameterName</c> and <c>ApplyMethod</c> . To reset the entire DB parameter group, specify the <c>DBParameterGroup</c> name
        /// and <c>ResetAllParameters</c> parameters. When resetting the entire group, dynamic parameters are updated immediately and static parameters
        /// are set to <c>pending-reboot</c> to take effect on the next DB instance restart or <c>RebootDBInstance</c> request. </para>
        /// </summary>
        /// 
        /// <param name="resetDBParameterGroupRequest">Container for the necessary parameters to execute the ResetDBParameterGroup service method on
        /// AmazonRDS.</param>
        /// 
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.DBParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBParameterGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ResetDBParameterGroupResponse> ResetDBParameterGroupAsync(ResetDBParameterGroupRequest resetDBParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetDBParameterGroupRequestMarshaller();
            var unmarshaller = ResetDBParameterGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ResetDBParameterGroupRequest, ResetDBParameterGroupResponse>(resetDBParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest request)
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
        /// <para> Creates a new DB instance from a DB snapshot. The target database is created from the source database restore point with the same
        /// configuration as the original source database, except that the new RDS instance is created with the default security group. </para>
        /// </summary>
        /// 
        /// <param name="restoreDBInstanceFromDBSnapshotRequest">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot
        /// service method on AmazonRDS.</param>
        /// 
        /// <returns>The response from the RestoreDBInstanceFromDBSnapshot service method, as returned by AmazonRDS.</returns>
        /// 
        /// <exception cref="T:Amazon.RDS.Model.InvalidRestoreException" />
        /// <exception cref="T:Amazon.RDS.Model.InstanceQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.StorageQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBSnapshotStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InsufficientDBInstanceCapacityException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RestoreDBInstanceFromDBSnapshotResponse> RestoreDBInstanceFromDBSnapshotAsync(RestoreDBInstanceFromDBSnapshotRequest restoreDBInstanceFromDBSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var unmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RestoreDBInstanceFromDBSnapshotRequest, RestoreDBInstanceFromDBSnapshotResponse>(restoreDBInstanceFromDBSnapshotRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest request)
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
        /// <para> Restores a DB instance to an arbitrary point-in-time. Users can restore to any point in time before the latestRestorableTime for up
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
        /// <exception cref="T:Amazon.RDS.Model.InvalidRestoreException" />
        /// <exception cref="T:Amazon.RDS.Model.InstanceQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceAlreadyExistsException" />
        /// <exception cref="T:Amazon.RDS.Model.DBInstanceNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.StorageQuotaExceededException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidDBInstanceStateException" />
        /// <exception cref="T:Amazon.RDS.Model.InsufficientDBInstanceCapacityException" />
        /// <exception cref="T:Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException" />
        /// <exception cref="T:Amazon.RDS.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.RDS.Model.OptionGroupNotFoundException" />
        /// <exception cref="T:Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RestoreDBInstanceToPointInTimeResponse> RestoreDBInstanceToPointInTimeAsync(RestoreDBInstanceToPointInTimeRequest restoreDBInstanceToPointInTimeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var unmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RestoreDBInstanceToPointInTimeRequest, RestoreDBInstanceToPointInTimeResponse>(restoreDBInstanceToPointInTimeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest request)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RevokeDBSecurityGroupIngressResponse> RevokeDBSecurityGroupIngressAsync(RevokeDBSecurityGroupIngressRequest revokeDBSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeDBSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RevokeDBSecurityGroupIngressRequest, RevokeDBSecurityGroupIngressResponse>(revokeDBSecurityGroupIngressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}
