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
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.RDS.Model;
using Amazon.RDS.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS
{
    /// <summary>
    /// Implementation for accessing RDS
    ///
    /// Amazon Relational Database Service 
    /// <para>
    ///  Amazon Relational Database Service (Amazon RDS) is a web service that makes it easier
    /// to set up, operate, and scale a relational database in the cloud. It provides cost-efficient,
    /// resizable capacity for an industry-standard relational database and manages common
    /// database administration tasks, freeing up developers to focus on what makes their
    /// applications and businesses unique. 
    /// </para>
    ///  
    /// <para>
    ///  Amazon RDS gives you access to the capabilities of a MySQL, PostgreSQL, Microsoft
    /// SQL Server, or Oracle database server. This means the code, applications, and tools
    /// you already use today with your existing databases work with Amazon RDS without modification.
    /// Amazon RDS automatically backs up your database and maintains the database software
    /// that powers your DB instance. Amazon RDS is flexible: you can scale your database
    /// instance's compute resources and storage capacity to meet your application's demand.
    /// As with all Amazon Web Services, there are no up-front investments, and you pay only
    /// for the resources you use. 
    /// </para>
    ///  
    /// <para>
    ///  This is an interface reference for Amazon RDS. It contains documentation for a programming
    /// or command line interface you can use to manage Amazon RDS. Note that Amazon RDS is
    /// asynchronous, which means that some interfaces may require techniques such as polling
    /// or callback functions to determine when a command has been applied. In this reference,
    /// the parameter descriptions indicate whether a command is applied immediately, on the
    /// next instance reboot, or during the maintenance window. For a summary of the Amazon
    /// RDS interfaces, go to <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Welcome.html#Welcome.Interfaces">Available
    /// RDS Interfaces</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonRDSClient : AmazonServiceClient, IAmazonRDS
    {
        
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
            : this(credentials, new AmazonRDSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Credentials and an
        /// AmazonRDSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(AWSCredentials credentials, AmazonRDSConfig clientConfig)
            : base(credentials, clientConfig)
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
        /// AmazonRDSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRDSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRDSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRDSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRDSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRDSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AddSourceIdentifierToSubscription

        internal AddSourceIdentifierToSubscriptionResponse AddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request)
        {
            var marshaller = new AddSourceIdentifierToSubscriptionRequestMarshaller();
            var unmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return Invoke<AddSourceIdentifierToSubscriptionRequest,AddSourceIdentifierToSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddSourceIdentifierToSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddSourceIdentifierToSubscriptionResponse> AddSourceIdentifierToSubscriptionAsync(AddSourceIdentifierToSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddSourceIdentifierToSubscriptionRequestMarshaller();
            var unmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<AddSourceIdentifierToSubscriptionRequest,AddSourceIdentifierToSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddTagsToResource

        internal AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsToResourceRequestMarshaller();
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeDBSecurityGroupIngress

        internal AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest request)
        {
            var marshaller = new AuthorizeDBSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeDBSecurityGroupIngressRequest,AuthorizeDBSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AuthorizeDBSecurityGroupIngressResponse> AuthorizeDBSecurityGroupIngressAsync(AuthorizeDBSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeDBSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeDBSecurityGroupIngressRequest,AuthorizeDBSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyDBParameterGroup

        internal CopyDBParameterGroupResponse CopyDBParameterGroup(CopyDBParameterGroupRequest request)
        {
            var marshaller = new CopyDBParameterGroupRequestMarshaller();
            var unmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBParameterGroupRequest,CopyDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CopyDBParameterGroupResponse> CopyDBParameterGroupAsync(CopyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyDBParameterGroupRequestMarshaller();
            var unmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBParameterGroupRequest,CopyDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyDBSnapshot

        internal CopyDBSnapshotResponse CopyDBSnapshot(CopyDBSnapshotRequest request)
        {
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var unmarshaller = CopyDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyDBSnapshotRequest,CopyDBSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CopyDBSnapshotResponse> CopyDBSnapshotAsync(CopyDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyDBSnapshotRequestMarshaller();
            var unmarshaller = CopyDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBSnapshotRequest,CopyDBSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyOptionGroup

        internal CopyOptionGroupResponse CopyOptionGroup(CopyOptionGroupRequest request)
        {
            var marshaller = new CopyOptionGroupRequestMarshaller();
            var unmarshaller = CopyOptionGroupResponseUnmarshaller.Instance;

            return Invoke<CopyOptionGroupRequest,CopyOptionGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CopyOptionGroupResponse> CopyOptionGroupAsync(CopyOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyOptionGroupRequestMarshaller();
            var unmarshaller = CopyOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CopyOptionGroupRequest,CopyOptionGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBInstance

        internal CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var unmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceRequest,CreateDBInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBInstanceRequestMarshaller();
            var unmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBInstanceRequest,CreateDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBInstanceReadReplica

        internal CreateDBInstanceReadReplicaResponse CreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest request)
        {
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var unmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceReadReplicaRequest,CreateDBInstanceReadReplicaResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstanceReadReplica operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstanceReadReplica operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDBInstanceReadReplicaResponse> CreateDBInstanceReadReplicaAsync(CreateDBInstanceReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBInstanceReadReplicaRequestMarshaller();
            var unmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBInstanceReadReplicaRequest,CreateDBInstanceReadReplicaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBParameterGroup

        internal CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest request)
        {
            var marshaller = new CreateDBParameterGroupRequestMarshaller();
            var unmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBParameterGroupRequest,CreateDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDBParameterGroupResponse> CreateDBParameterGroupAsync(CreateDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBParameterGroupRequestMarshaller();
            var unmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBParameterGroupRequest,CreateDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSecurityGroup

        internal CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest request)
        {
            var marshaller = new CreateDBSecurityGroupRequestMarshaller();
            var unmarshaller = CreateDBSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBSecurityGroupRequest,CreateDBSecurityGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDBSecurityGroupResponse> CreateDBSecurityGroupAsync(CreateDBSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBSecurityGroupRequestMarshaller();
            var unmarshaller = CreateDBSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBSecurityGroupRequest,CreateDBSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSnapshot

        internal CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest request)
        {
            var marshaller = new CreateDBSnapshotRequestMarshaller();
            var unmarshaller = CreateDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDBSnapshotRequest,CreateDBSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDBSnapshotResponse> CreateDBSnapshotAsync(CreateDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBSnapshotRequestMarshaller();
            var unmarshaller = CreateDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBSnapshotRequest,CreateDBSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSubnetGroup

        internal CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest request)
        {
            var marshaller = new CreateDBSubnetGroupRequestMarshaller();
            var unmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBSubnetGroupRequest,CreateDBSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDBSubnetGroupResponse> CreateDBSubnetGroupAsync(CreateDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDBSubnetGroupRequestMarshaller();
            var unmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBSubnetGroupRequest,CreateDBSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateEventSubscription

        internal CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionRequest,CreateEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventSubscriptionRequest,CreateEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateOptionGroup

        internal CreateOptionGroupResponse CreateOptionGroup(CreateOptionGroupRequest request)
        {
            var marshaller = new CreateOptionGroupRequestMarshaller();
            var unmarshaller = CreateOptionGroupResponseUnmarshaller.Instance;

            return Invoke<CreateOptionGroupRequest,CreateOptionGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateOptionGroupResponse> CreateOptionGroupAsync(CreateOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateOptionGroupRequestMarshaller();
            var unmarshaller = CreateOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOptionGroupRequest,CreateOptionGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBInstance

        internal DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var unmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteDBInstanceRequest,DeleteDBInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBInstanceRequestMarshaller();
            var unmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBInstanceRequest,DeleteDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBParameterGroup

        internal DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest request)
        {
            var marshaller = new DeleteDBParameterGroupRequestMarshaller();
            var unmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBParameterGroupRequest,DeleteDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDBParameterGroupResponse> DeleteDBParameterGroupAsync(DeleteDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBParameterGroupRequestMarshaller();
            var unmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBParameterGroupRequest,DeleteDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSecurityGroup

        internal DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest request)
        {
            var marshaller = new DeleteDBSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSecurityGroupRequest,DeleteDBSecurityGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSecurityGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDBSecurityGroupResponse> DeleteDBSecurityGroupAsync(DeleteDBSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBSecurityGroupRequest,DeleteDBSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSnapshot

        internal DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest request)
        {
            var marshaller = new DeleteDBSnapshotRequestMarshaller();
            var unmarshaller = DeleteDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSnapshotRequest,DeleteDBSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDBSnapshotResponse> DeleteDBSnapshotAsync(DeleteDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBSnapshotRequestMarshaller();
            var unmarshaller = DeleteDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBSnapshotRequest,DeleteDBSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSubnetGroup

        internal DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request)
        {
            var marshaller = new DeleteDBSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSubnetGroupRequest,DeleteDBSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDBSubnetGroupResponse> DeleteDBSubnetGroupAsync(DeleteDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDBSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBSubnetGroupRequest,DeleteDBSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventSubscription

        internal DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionRequest,DeleteEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventSubscriptionRequest,DeleteEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteOptionGroup

        internal DeleteOptionGroupResponse DeleteOptionGroup(DeleteOptionGroupRequest request)
        {
            var marshaller = new DeleteOptionGroupRequestMarshaller();
            var unmarshaller = DeleteOptionGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteOptionGroupRequest,DeleteOptionGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteOptionGroupResponse> DeleteOptionGroupAsync(DeleteOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteOptionGroupRequestMarshaller();
            var unmarshaller = DeleteOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOptionGroupRequest,DeleteOptionGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBEngineVersions

        internal DescribeDBEngineVersionsResponse DescribeDBEngineVersions()
        {
            return DescribeDBEngineVersions(new DescribeDBEngineVersionsRequest());
        }
        internal DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request)
        {
            var marshaller = new DescribeDBEngineVersionsRequestMarshaller();
            var unmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBEngineVersionsRequest,DescribeDBEngineVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBEngineVersions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(DescribeDBEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBEngineVersionsRequestMarshaller();
            var unmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBEngineVersionsRequest,DescribeDBEngineVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBInstances

        internal DescribeDBInstancesResponse DescribeDBInstances()
        {
            return DescribeDBInstances(new DescribeDBInstancesRequest());
        }
        internal DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            var marshaller = new DescribeDBInstancesRequestMarshaller();
            var unmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBInstancesRequest,DescribeDBInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBInstances operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBInstancesRequestMarshaller();
            var unmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBInstancesRequest,DescribeDBInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBLogFiles

        internal DescribeDBLogFilesResponse DescribeDBLogFiles(DescribeDBLogFilesRequest request)
        {
            var marshaller = new DescribeDBLogFilesRequestMarshaller();
            var unmarshaller = DescribeDBLogFilesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBLogFilesRequest,DescribeDBLogFilesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBLogFiles operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBLogFiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBLogFilesResponse> DescribeDBLogFilesAsync(DescribeDBLogFilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBLogFilesRequestMarshaller();
            var unmarshaller = DescribeDBLogFilesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBLogFilesRequest,DescribeDBLogFilesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBParameterGroups

        internal DescribeDBParameterGroupsResponse DescribeDBParameterGroups()
        {
            return DescribeDBParameterGroups(new DescribeDBParameterGroupsRequest());
        }
        internal DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request)
        {
            var marshaller = new DescribeDBParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParameterGroupsRequest,DescribeDBParameterGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameterGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(DescribeDBParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBParameterGroupsRequest,DescribeDBParameterGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBParameters

        internal DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest request)
        {
            var marshaller = new DescribeDBParametersRequestMarshaller();
            var unmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParametersRequest,DescribeDBParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameters operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBParametersResponse> DescribeDBParametersAsync(DescribeDBParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBParametersRequestMarshaller();
            var unmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBParametersRequest,DescribeDBParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSecurityGroups

        internal DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups()
        {
            return DescribeDBSecurityGroups(new DescribeDBSecurityGroupsRequest());
        }
        internal DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request)
        {
            var marshaller = new DescribeDBSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSecurityGroupsRequest,DescribeDBSecurityGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSecurityGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(DescribeDBSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSecurityGroupsRequest,DescribeDBSecurityGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSnapshots

        internal DescribeDBSnapshotsResponse DescribeDBSnapshots()
        {
            return DescribeDBSnapshots(new DescribeDBSnapshotsRequest());
        }
        internal DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest request)
        {
            var marshaller = new DescribeDBSnapshotsRequestMarshaller();
            var unmarshaller = DescribeDBSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSnapshotsRequest,DescribeDBSnapshotsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSnapshots operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBSnapshotsResponse> DescribeDBSnapshotsAsync(DescribeDBSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBSnapshotsRequestMarshaller();
            var unmarshaller = DescribeDBSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSnapshotsRequest,DescribeDBSnapshotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSubnetGroups

        internal DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups()
        {
            return DescribeDBSubnetGroups(new DescribeDBSubnetGroupsRequest());
        }
        internal DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request)
        {
            var marshaller = new DescribeDBSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSubnetGroupsRequest,DescribeDBSubnetGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(DescribeDBSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDBSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSubnetGroupsRequest,DescribeDBSubnetGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEngineDefaultParameters

        internal DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            var marshaller = new DescribeEngineDefaultParametersRequestMarshaller();
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultParametersRequest,DescribeEngineDefaultParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEngineDefaultParametersRequestMarshaller();
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEngineDefaultParametersRequest,DescribeEngineDefaultParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventCategories

        internal DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }
        internal DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesRequest,DescribeEventCategoriesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventCategoriesRequest,DescribeEventCategoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents

        internal DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }
        internal DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        internal DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }
        internal DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsRequest,DescribeEventSubscriptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventSubscriptionsRequest,DescribeEventSubscriptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOptionGroupOptions

        internal DescribeOptionGroupOptionsResponse DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request)
        {
            var marshaller = new DescribeOptionGroupOptionsRequestMarshaller();
            var unmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOptionGroupOptionsRequest,DescribeOptionGroupOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroupOptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroupOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeOptionGroupOptionsResponse> DescribeOptionGroupOptionsAsync(DescribeOptionGroupOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOptionGroupOptionsRequestMarshaller();
            var unmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOptionGroupOptionsRequest,DescribeOptionGroupOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOptionGroups

        internal DescribeOptionGroupsResponse DescribeOptionGroups()
        {
            return DescribeOptionGroups(new DescribeOptionGroupsRequest());
        }
        internal DescribeOptionGroupsResponse DescribeOptionGroups(DescribeOptionGroupsRequest request)
        {
            var marshaller = new DescribeOptionGroupsRequestMarshaller();
            var unmarshaller = DescribeOptionGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeOptionGroupsRequest,DescribeOptionGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroups operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeOptionGroupsResponse> DescribeOptionGroupsAsync(DescribeOptionGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOptionGroupsRequestMarshaller();
            var unmarshaller = DescribeOptionGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOptionGroupsRequest,DescribeOptionGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrderableDBInstanceOptions

        internal DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request)
        {
            var marshaller = new DescribeOrderableDBInstanceOptionsRequestMarshaller();
            var unmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableDBInstanceOptionsRequest,DescribeOrderableDBInstanceOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeOrderableDBInstanceOptionsResponse> DescribeOrderableDBInstanceOptionsAsync(DescribeOrderableDBInstanceOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOrderableDBInstanceOptionsRequestMarshaller();
            var unmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrderableDBInstanceOptionsRequest,DescribeOrderableDBInstanceOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedDBInstances

        internal DescribeReservedDBInstancesResponse DescribeReservedDBInstances()
        {
            return DescribeReservedDBInstances(new DescribeReservedDBInstancesRequest());
        }
        internal DescribeReservedDBInstancesResponse DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request)
        {
            var marshaller = new DescribeReservedDBInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedDBInstancesRequest,DescribeReservedDBInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstances operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedDBInstancesResponse> DescribeReservedDBInstancesAsync(DescribeReservedDBInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedDBInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedDBInstancesRequest,DescribeReservedDBInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedDBInstancesOfferings

        internal DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings()
        {
            return DescribeReservedDBInstancesOfferings(new DescribeReservedDBInstancesOfferingsRequest());
        }
        internal DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request)
        {
            var marshaller = new DescribeReservedDBInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedDBInstancesOfferingsRequest,DescribeReservedDBInstancesOfferingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedDBInstancesOfferings operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstancesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedDBInstancesOfferingsResponse> DescribeReservedDBInstancesOfferingsAsync(DescribeReservedDBInstancesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedDBInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedDBInstancesOfferingsRequest,DescribeReservedDBInstancesOfferingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DownloadDBLogFilePortion

        internal DownloadDBLogFilePortionResponse DownloadDBLogFilePortion(DownloadDBLogFilePortionRequest request)
        {
            var marshaller = new DownloadDBLogFilePortionRequestMarshaller();
            var unmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.Instance;

            return Invoke<DownloadDBLogFilePortionRequest,DownloadDBLogFilePortionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDBLogFilePortion operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DownloadDBLogFilePortionResponse> DownloadDBLogFilePortionAsync(DownloadDBLogFilePortionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DownloadDBLogFilePortionRequestMarshaller();
            var unmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.Instance;

            return InvokeAsync<DownloadDBLogFilePortionRequest,DownloadDBLogFilePortionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTagsForResourceRequestMarshaller();
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBInstance

        internal ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request)
        {
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var unmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return Invoke<ModifyDBInstanceRequest,ModifyDBInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyDBInstanceResponse> ModifyDBInstanceAsync(ModifyDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDBInstanceRequestMarshaller();
            var unmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBInstanceRequest,ModifyDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBParameterGroup

        internal ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest request)
        {
            var marshaller = new ModifyDBParameterGroupRequestMarshaller();
            var unmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBParameterGroupRequest,ModifyDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyDBParameterGroupResponse> ModifyDBParameterGroupAsync(ModifyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDBParameterGroupRequestMarshaller();
            var unmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBParameterGroupRequest,ModifyDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBSubnetGroup

        internal ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request)
        {
            var marshaller = new ModifyDBSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSubnetGroupRequest,ModifyDBSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyDBSubnetGroupResponse> ModifyDBSubnetGroupAsync(ModifyDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyDBSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBSubnetGroupRequest,ModifyDBSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyEventSubscription

        internal ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionRequest,ModifyEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyEventSubscriptionRequest,ModifyEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyOptionGroup

        internal ModifyOptionGroupResponse ModifyOptionGroup(ModifyOptionGroupRequest request)
        {
            var marshaller = new ModifyOptionGroupRequestMarshaller();
            var unmarshaller = ModifyOptionGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyOptionGroupRequest,ModifyOptionGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyOptionGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyOptionGroupResponse> ModifyOptionGroupAsync(ModifyOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyOptionGroupRequestMarshaller();
            var unmarshaller = ModifyOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyOptionGroupRequest,ModifyOptionGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PromoteReadReplica

        internal PromoteReadReplicaResponse PromoteReadReplica(PromoteReadReplicaRequest request)
        {
            var marshaller = new PromoteReadReplicaRequestMarshaller();
            var unmarshaller = PromoteReadReplicaResponseUnmarshaller.Instance;

            return Invoke<PromoteReadReplicaRequest,PromoteReadReplicaResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PromoteReadReplica operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplica operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PromoteReadReplicaResponse> PromoteReadReplicaAsync(PromoteReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PromoteReadReplicaRequestMarshaller();
            var unmarshaller = PromoteReadReplicaResponseUnmarshaller.Instance;

            return InvokeAsync<PromoteReadReplicaRequest,PromoteReadReplicaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedDBInstancesOffering

        internal PurchaseReservedDBInstancesOfferingResponse PurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest request)
        {
            var marshaller = new PurchaseReservedDBInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedDBInstancesOfferingRequest,PurchaseReservedDBInstancesOfferingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedDBInstancesOffering operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedDBInstancesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PurchaseReservedDBInstancesOfferingResponse> PurchaseReservedDBInstancesOfferingAsync(PurchaseReservedDBInstancesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedDBInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedDBInstancesOfferingRequest,PurchaseReservedDBInstancesOfferingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebootDBInstance

        internal RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request)
        {
            var marshaller = new RebootDBInstanceRequestMarshaller();
            var unmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootDBInstanceRequest,RebootDBInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootDBInstance operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RebootDBInstanceResponse> RebootDBInstanceAsync(RebootDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootDBInstanceRequestMarshaller();
            var unmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RebootDBInstanceRequest,RebootDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveSourceIdentifierFromSubscription

        internal RemoveSourceIdentifierFromSubscriptionResponse RemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request)
        {
            var marshaller = new RemoveSourceIdentifierFromSubscriptionRequestMarshaller();
            var unmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return Invoke<RemoveSourceIdentifierFromSubscriptionRequest,RemoveSourceIdentifierFromSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveSourceIdentifierFromSubscription operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemoveSourceIdentifierFromSubscriptionResponse> RemoveSourceIdentifierFromSubscriptionAsync(RemoveSourceIdentifierFromSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveSourceIdentifierFromSubscriptionRequestMarshaller();
            var unmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveSourceIdentifierFromSubscriptionRequest,RemoveSourceIdentifierFromSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        internal RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsFromResourceRequestMarshaller();
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetDBParameterGroup

        internal ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest request)
        {
            var marshaller = new ResetDBParameterGroupRequestMarshaller();
            var unmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBParameterGroupRequest,ResetDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBParameterGroup operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ResetDBParameterGroupResponse> ResetDBParameterGroupAsync(ResetDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetDBParameterGroupRequestMarshaller();
            var unmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetDBParameterGroupRequest,ResetDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBInstanceFromDBSnapshot

        internal RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest request)
        {
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var unmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceFromDBSnapshotRequest,RestoreDBInstanceFromDBSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceFromDBSnapshot operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RestoreDBInstanceFromDBSnapshotResponse> RestoreDBInstanceFromDBSnapshotAsync(RestoreDBInstanceFromDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();
            var unmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBInstanceFromDBSnapshotRequest,RestoreDBInstanceFromDBSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBInstanceToPointInTime

        internal RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest request)
        {
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var unmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceToPointInTimeRequest,RestoreDBInstanceToPointInTimeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceToPointInTime operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RestoreDBInstanceToPointInTimeResponse> RestoreDBInstanceToPointInTimeAsync(RestoreDBInstanceToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreDBInstanceToPointInTimeRequestMarshaller();
            var unmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBInstanceToPointInTimeRequest,RestoreDBInstanceToPointInTimeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeDBSecurityGroupIngress

        internal RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest request)
        {
            var marshaller = new RevokeDBSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeDBSecurityGroupIngressRequest,RevokeDBSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeDBSecurityGroupIngress operation.
        /// <seealso cref="Amazon.RDS.IAmazonRDS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RevokeDBSecurityGroupIngressResponse> RevokeDBSecurityGroupIngressAsync(RevokeDBSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeDBSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeDBSecurityGroupIngressRequest,RevokeDBSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}