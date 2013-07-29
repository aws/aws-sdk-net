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

using Amazon.Redshift.Model;
using Amazon.Redshift.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift
{
    /// <summary>
    /// Implementation for accessing AmazonRedshift.
    /// 
    /// Amazon Redshift <b>Overview</b> <para> This is the Amazon Redshift API Reference. This guide provides descriptions and samples of the Amazon
    /// Redshift API. </para> <para> Amazon Redshift manages all the work of setting up, operating, and scaling a data warehouse: provisioning
    /// capacity, monitoring and backing up the cluster, and applying patches and upgrades to the Amazon Redshift engine. You can focus on using
    /// your data to acquire new insights for your business and customers. </para> <b>Are You a First-Time Amazon Redshift User?</b> <para>If you
    /// are a first-time user of Amazon Redshift, we recommend that you begin by reading the following sections:</para> <para>
    /// <ul>
    /// <li> <para> <i>Service Highlights and Pricing</i> - The product detail page provides the Amazon Redshift value proposition, service
    /// highlights and pricing. </para> </li>
    /// <li> <para> <i>Getting Started</i> - The Getting Started Guide includes an example that walks you through the process of creating a
    /// cluster, creating database tables, uploading data, and testing queries. </para> </li>
    /// 
    /// </ul>
    /// </para> <para>After you complete the Getting Started Guide, we recommend that you explore one of the following guides:</para>
    /// <ul>
    /// <li> <para> <i>Cluster Management</i> - If you are responsible for managing Amazon Redshift clusters, the Cluster Management Guide shows
    /// you how to create and manage Amazon Redshift clusters.</para> <para> If you are an application developer, you can use the Amazon Redshift
    /// Query API to manage clusters programmatically. Additionally, the AWS SDK libraries that wrap the underlying Amazon Redshift API simplify
    /// your programming tasks. If you prefer a more interactive way of managing clusters, you can use the Amazon Redshift console and the AWS
    /// command line interface (AWS CLI). For information about the API and CLI, go to the following manuals : </para>
    /// <ul>
    /// <li> <para>API Reference ( <i>this document</i> ) </para> </li>
    /// <li> <para> CLI Reference </para> </li>
    /// 
    /// </ul>
    /// </li>
    /// <li> <para> <i>Amazon Redshift Database Database Developer</i> - If you are a database developer, the Amazon Redshift Database Developer
    /// Guide explains how to design, build, query, and maintain the databases that make up your data warehouse. </para> </li>
    /// 
    /// </ul>
    /// <para>For a list of supported AWS regions where you can provision a cluster, go to the Regions and Endpoints section in the <i>Amazon Web
    /// Services Glossary</i> . </para>
    /// </summary>
	public partial class AmazonRedshiftClient : AmazonWebServiceClient, Amazon.Redshift.IAmazonRedshift
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRedshiftClient(AWSCredentials credentials)
            : this(credentials, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRedshiftConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials and an
        /// AmazonRedshiftClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(AWSCredentials credentials, AmazonRedshiftConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRedshiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRedshiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// <para> Adds an inbound (ingress) rule to an Amazon Redshift security group. Depending on whether the application accessing your cluster is
        /// running on the Internet or an EC2 instance, you can authorize inbound access to either a Classless Interdomain Routing (CIDR) IP address
        /// range or an EC2 security group. You can add as many as 20 ingress rules to an Amazon Redshift security group. </para> <para><b>NOTE:</b> The
        /// EC2 security group must be defined in the AWS region where the cluster resides. </para> <para>For an overview of CIDR blocks, see the
        /// Wikipedia article on Classless Inter-Domain Routing. </para> <para> You must also associate the security group with a cluster so that
        /// clients running on these IP addresses or the EC2 instance are authorized to connect to the cluster. For information about managing security
        /// groups, go to Working with Security Groups in the <i>Amazon Redshift Management Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="authorizeClusterSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        /// AuthorizeClusterSecurityGroupIngress service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the AuthorizeClusterSecurityGroupIngress service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<AuthorizeClusterSecurityGroupIngressResponse> AuthorizeClusterSecurityGroupIngressAsync(AuthorizeClusterSecurityGroupIngressRequest authorizeClusterSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AuthorizeClusterSecurityGroupIngressRequest, AuthorizeClusterSecurityGroupIngressResponse>(authorizeClusterSecurityGroupIngressRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Copies the specified automated cluster snapshot to a new manual cluster snapshot. The source must be an automated snapshot and it
        /// must be in the available state. </para> <para> When you delete a cluster, Amazon Redshift deletes any automated snapshots of the cluster.
        /// Also, when the retention period of the snapshot expires, Amazon Redshift automatically deletes it. If you want to keep an automated snapshot
        /// for a longer period, you can make a manual copy of the snapshot. Manual snapshots are retained until you delete them. </para> <para> For
        /// more information about working with snapshots, go to Amazon Redshift Snapshots in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="copyClusterSnapshotRequest">Container for the necessary parameters to execute the CopyClusterSnapshot service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSnapshotStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CopyClusterSnapshotResponse> CopyClusterSnapshotAsync(CopyClusterSnapshotRequest copyClusterSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var unmarshaller = CopyClusterSnapshotResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CopyClusterSnapshotRequest, CopyClusterSnapshotResponse>(copyClusterSnapshotRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates a new cluster. To create the cluster in virtual private cloud (VPC), you must provide cluster subnet group name. If you don't
        /// provide a cluster subnet group name or the cluster security group parameter, Amazon Redshift creates a non-VPC cluster, it associates the
        /// default cluster security group with the cluster. For more information about managing clusters, go to Amazon Redshift Clusters in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterRequest">Container for the necessary parameters to execute the CreateCluster service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InsufficientClusterCapacityException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest createClusterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterRequestMarshaller();
            var unmarshaller = CreateClusterResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateClusterRequest, CreateClusterResponse>(createClusterRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates an Amazon Redshift parameter group. </para> <para>Creating parameter groups is independent of creating clusters. You can
        /// associate a cluster with a parameter group when you create the cluster. You can also associate an existing cluster with a parameter group
        /// after the cluster is created by using ModifyCluster. </para> <para> Parameters in the parameter group define specific behavior that applies
        /// to the databases you create on the cluster. For more information about managing parameter groups, go to Amazon Redshift Parameter Groups in
        /// the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterParameterGroupRequest">Container for the necessary parameters to execute the CreateClusterParameterGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterParameterGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupAlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateClusterParameterGroupResponse> CreateClusterParameterGroupAsync(CreateClusterParameterGroupRequest createClusterParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterParameterGroupRequestMarshaller();
            var unmarshaller = CreateClusterParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateClusterParameterGroupRequest, CreateClusterParameterGroupResponse>(createClusterParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates a new Amazon Redshift security group. You use security groups to control access to non-VPC clusters. </para> <para> For
        /// information about managing security groups, go to Amazon Redshift Cluster Security Groups in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterSecurityGroupRequest">Container for the necessary parameters to execute the CreateClusterSecurityGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterSecurityGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupAlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateClusterSecurityGroupResponse> CreateClusterSecurityGroupAsync(CreateClusterSecurityGroupRequest createClusterSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterSecurityGroupRequestMarshaller();
            var unmarshaller = CreateClusterSecurityGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateClusterSecurityGroupRequest, CreateClusterSecurityGroupResponse>(createClusterSecurityGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates a manual snapshot of the specified cluster. The cluster must be in the "available" state. </para> <para> For more information
        /// about working with snapshots, go to Amazon Redshift Snapshots in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterSnapshotRequest">Container for the necessary parameters to execute the CreateClusterSnapshot service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateClusterSnapshotResponse> CreateClusterSnapshotAsync(CreateClusterSnapshotRequest createClusterSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var unmarshaller = CreateClusterSnapshotResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateClusterSnapshotRequest, CreateClusterSnapshotResponse>(createClusterSnapshotRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates a new Amazon Redshift subnet group. You must provide a list of one or more subnets in your existing Amazon Virtual Private
        /// Cloud (Amazon VPC) when creating Amazon Redshift subnet group. </para> <para> For information about subnet groups, go to Amazon Redshift
        /// Cluster Subnet Groups in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createClusterSubnetGroupRequest">Container for the necessary parameters to execute the CreateClusterSubnetGroup service method
        /// on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the CreateClusterSubnetGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateClusterSubnetGroupResponse> CreateClusterSubnetGroupAsync(CreateClusterSubnetGroupRequest createClusterSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var unmarshaller = CreateClusterSubnetGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateClusterSubnetGroupRequest, CreateClusterSubnetGroupResponse>(createClusterSubnetGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Deletes a previously provisioned cluster. A successful response from the web service indicates that the request was received
        /// correctly. If a final cluster snapshot is requested the status of the cluster will be "final-snapshot" while the snapshot is being taken,
        /// then it's "deleting" once Amazon Redshift begins deleting the cluster. Use DescribeClusters to monitor the status of the deletion. The
        /// delete operation cannot be canceled or reverted once submitted. For more information about managing clusters, go to Amazon Redshift Clusters
        /// in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterRequest">Container for the necessary parameters to execute the DeleteCluster service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest deleteClusterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterRequestMarshaller();
            var unmarshaller = DeleteClusterResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteClusterRequest, DeleteClusterResponse>(deleteClusterRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Deletes a specified Amazon Redshift parameter group. <para><b>NOTE:</b>You cannot delete a parameter group if it is associated with a
        /// cluster.</para> </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterParameterGroupRequest">Container for the necessary parameters to execute the DeleteClusterParameterGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterParameterGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteClusterParameterGroupResponse> DeleteClusterParameterGroupAsync(DeleteClusterParameterGroupRequest deleteClusterParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterParameterGroupRequestMarshaller();
            var unmarshaller = DeleteClusterParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteClusterParameterGroupRequest, DeleteClusterParameterGroupResponse>(deleteClusterParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Deletes an Amazon Redshift security group. </para> <para><b>NOTE:</b>You cannot delete a security group that is associated with any
        /// clusters. You cannot delete the default security group.</para> <para> For information about managing security groups, go to Amazon Redshift
        /// Cluster Security Groups in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterSecurityGroupRequest">Container for the necessary parameters to execute the DeleteClusterSecurityGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteClusterSecurityGroupResponse> DeleteClusterSecurityGroupAsync(DeleteClusterSecurityGroupRequest deleteClusterSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSecurityGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteClusterSecurityGroupRequest, DeleteClusterSecurityGroupResponse>(deleteClusterSecurityGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Deletes the specified manual snapshot. The snapshot must be in the "available" state. </para> <para> Unlike automated snapshots,
        /// manual snapshots are retained even after you delete your cluster. Amazon Redshift does not delete your manual snapshots. You must delete
        /// manual snapshot explicitly to avoid getting charged. </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterSnapshotRequest">Container for the necessary parameters to execute the DeleteClusterSnapshot service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSnapshotStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteClusterSnapshotResponse> DeleteClusterSnapshotAsync(DeleteClusterSnapshotRequest deleteClusterSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterSnapshotRequestMarshaller();
            var unmarshaller = DeleteClusterSnapshotResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteClusterSnapshotRequest, DeleteClusterSnapshotResponse>(deleteClusterSnapshotRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Deletes the specified cluster subnet group. </para>
        /// </summary>
        /// 
        /// <param name="deleteClusterSubnetGroupRequest">Container for the necessary parameters to execute the DeleteClusterSubnetGroup service method
        /// on AmazonRedshift.</param>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSubnetStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteClusterSubnetGroupResponse> DeleteClusterSubnetGroupAsync(DeleteClusterSubnetGroupRequest deleteClusterSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSubnetGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteClusterSubnetGroupRequest, DeleteClusterSubnetGroupResponse>(deleteClusterSubnetGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a list of Amazon Redshift parameter groups, including parameter groups you created and the default parameter group. For each
        /// parameter group, the response includes the parameter group name, description, and parameter group family name. You can optionally specify a
        /// name to retrieve the description of a specific parameter group. </para> <para> For more information about managing parameter groups, go to
        /// Amazon Redshift Parameter Groups in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeClusterParameterGroupsRequest">Container for the necessary parameters to execute the DescribeClusterParameterGroups
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(DescribeClusterParameterGroupsRequest describeClusterParameterGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterParameterGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeClusterParameterGroupsRequest, DescribeClusterParameterGroupsResponse>(describeClusterParameterGroupsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a detailed list of parameters contained within the specified Amazon Redshift parameter group. For each parameter the response
        /// includes information such as parameter name, description, data type, value, whether the parameter value is modifiable, and so on. </para>
        /// <para>You can specify <i>source</i> filter to retrieve parameters of only specific type. For example, to retrieve parameters that were
        /// modified by a user action such as from ModifyClusterParameterGroup, you can specify <i>source</i> equal to <i>user</i> .</para> <para> For
        /// more information about managing parameter groups, go to Amazon Redshift Parameter Groups in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeClusterParametersRequest">Container for the necessary parameters to execute the DescribeClusterParameters service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameters service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeClusterParametersResponse> DescribeClusterParametersAsync(DescribeClusterParametersRequest describeClusterParametersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterParametersRequestMarshaller();
            var unmarshaller = DescribeClusterParametersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeClusterParametersRequest, DescribeClusterParametersResponse>(describeClusterParametersRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns properties of provisioned clusters including general cluster properties, cluster database properties, maintenance and backup
        /// properties, and security and access properties. This operation supports pagination. For more information about managing clusters, go to
        /// Amazon Redshift Clusters in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeClustersRequest">Container for the necessary parameters to execute the DescribeClusters service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest describeClustersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClustersRequestMarshaller();
            var unmarshaller = DescribeClustersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeClustersRequest, DescribeClustersResponse>(describeClustersRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns information about Amazon Redshift security groups. If the name of a security group is specified, the response will contain
        /// only information about only that security group. </para> <para> For information about managing security groups, go to Amazon Redshift
        /// Cluster Security Groups in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeClusterSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeClusterSecurityGroups
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(DescribeClusterSecurityGroupsRequest describeClusterSecurityGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSecurityGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeClusterSecurityGroupsRequest, DescribeClusterSecurityGroupsResponse>(describeClusterSecurityGroupsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns one or more snapshot objects, which contain metadata about your cluster snapshots. By default, this operation returns
        /// information about all snapshots of all clusters that are owned by the AWS account. </para>
        /// </summary>
        /// 
        /// <param name="describeClusterSnapshotsRequest">Container for the necessary parameters to execute the DescribeClusterSnapshots service method
        /// on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(DescribeClusterSnapshotsRequest describeClusterSnapshotsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterSnapshotsRequestMarshaller();
            var unmarshaller = DescribeClusterSnapshotsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeClusterSnapshotsRequest, DescribeClusterSnapshotsResponse>(describeClusterSnapshotsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns one or more cluster subnet group objects, which contain metadata about your cluster subnet groups. By default, this
        /// operation returns information about all cluster subnet groups that are defined in you AWS account. </para>
        /// </summary>
        /// 
        /// <param name="describeClusterSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeClusterSubnetGroups service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(DescribeClusterSubnetGroupsRequest describeClusterSubnetGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSubnetGroupsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeClusterSubnetGroupsRequest, DescribeClusterSubnetGroupsResponse>(describeClusterSubnetGroupsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns descriptions of the available Amazon Redshift cluster versions. You can call this operation even before creating any
        /// clusters to learn more about the Amazon Redshift versions. For more information about managing clusters, go to Amazon Redshift Clusters in
        /// the <i>Amazon Redshift Management Guide</i> </para>
        /// </summary>
        /// 
        /// <param name="describeClusterVersionsRequest">Container for the necessary parameters to execute the DescribeClusterVersions service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by AmazonRedshift.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(DescribeClusterVersionsRequest describeClusterVersionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterVersionsRequestMarshaller();
            var unmarshaller = DescribeClusterVersionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeClusterVersionsRequest, DescribeClusterVersionsResponse>(describeClusterVersionsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a list of parameter settings for the specified parameter group family. </para> <para> For more information about managing
        /// parameter groups, go to Amazon Redshift Parameter Groups in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeDefaultClusterParametersRequest">Container for the necessary parameters to execute the DescribeDefaultClusterParameters
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeDefaultClusterParameters service method, as returned by AmazonRedshift.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeDefaultClusterParametersResponse> DescribeDefaultClusterParametersAsync(DescribeDefaultClusterParametersRequest describeDefaultClusterParametersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDefaultClusterParametersRequestMarshaller();
            var unmarshaller = DescribeDefaultClusterParametersResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeDefaultClusterParametersRequest, DescribeDefaultClusterParametersResponse>(describeDefaultClusterParametersRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns events related to clusters, security groups, snapshots, and parameter groups for the past 14 days. Events specific to a
        /// particular cluster, security group, snapshot or parameter group can be obtained by providing the name as a parameter. By default, the past
        /// hour of events are returned. </para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonRedshift.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest describeEventsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeEventsRequest, DescribeEventsResponse>(describeEventsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a list of orderable cluster options. Before you create a new cluster you can use this operation to find what options are
        /// available, such as the EC2 Availability Zones (AZ) in the specific AWS region that you can specify, and the node types you can request. The
        /// node types differ by available storage, memory, CPU and price. With the cost involved you might want to obtain a list of cluster options in
        /// the specific region and specify values when creating a cluster. For more information about managing clusters, go to Amazon Redshift Clusters
        /// in the <i>Amazon Redshift Management Guide</i> </para>
        /// </summary>
        /// 
        /// <param name="describeOrderableClusterOptionsRequest">Container for the necessary parameters to execute the DescribeOrderableClusterOptions
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by AmazonRedshift.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(DescribeOrderableClusterOptionsRequest describeOrderableClusterOptionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOrderableClusterOptionsRequestMarshaller();
            var unmarshaller = DescribeOrderableClusterOptionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeOrderableClusterOptionsRequest, DescribeOrderableClusterOptionsResponse>(describeOrderableClusterOptionsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a list of the available reserved node offerings by Amazon Redshift with their descriptions including the node type, the fixed
        /// and recurring costs of reserving the node and duration the node will be reserved for you. These descriptions help you determine which
        /// reserve node offering you want to purchase. You then use the unique offering ID in you call to PurchaseReservedNodeOffering to reserve one
        /// or more nodes for your Amazon Redshift cluster. </para> <para> For more information about managing parameter groups, go to Purchasing
        /// Reserved Nodes in the <i>Amazon Redshift Management Guide</i> .
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeReservedNodeOfferingsRequest">Container for the necessary parameters to execute the DescribeReservedNodeOfferings
        /// service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(DescribeReservedNodeOfferingsRequest describeReservedNodeOfferingsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedNodeOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedNodeOfferingsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeReservedNodeOfferingsRequest, DescribeReservedNodeOfferingsResponse>(describeReservedNodeOfferingsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns the descriptions of the reserved nodes. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedNodesRequest">Container for the necessary parameters to execute the DescribeReservedNodes service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(DescribeReservedNodesRequest describeReservedNodesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedNodesRequestMarshaller();
            var unmarshaller = DescribeReservedNodesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeReservedNodesRequest, DescribeReservedNodesResponse>(describeReservedNodesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns information about the last resize operation for the specified cluster. If no resize operation has ever been initiated for the
        /// specified cluster, a <c>HTTP 404</c> error is returned. If a resize operation was initiated and completed, the status of the resize remains
        /// as <c>SUCCEEDED</c> until the next resize. </para> <para> A resize operation can be requested using ModifyCluster and specifying a different
        /// number or type of nodes for the cluster. </para>
        /// </summary>
        /// 
        /// <param name="describeResizeRequest">Container for the necessary parameters to execute the DescribeResize service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the DescribeResize service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ResizeNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeResizeResponse> DescribeResizeAsync(DescribeResizeRequest describeResizeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeResizeRequestMarshaller();
            var unmarshaller = DescribeResizeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeResizeRequest, DescribeResizeResponse>(describeResizeRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Modifies the settings for a cluster. For example, you can add another security or parameter group, update the preferred maintenance
        /// window, or change the master user password. Resetting a cluster password or modifying the security groups associated with a cluster do not
        /// need a reboot. However, modifying parameter group requires a reboot for parameters to take effect. For more information about managing
        /// clusters, go to Amazon Redshift Clusters in the <i>Amazon Redshift Management Guide</i> </para> <para>You can also change node type and the
        /// number of nodes to scale up or down the cluster. When resizing a cluster, you must specify both the number of nodes and the node type even
        /// if one of the parameters does not change. If you specify the same number of nodes and node type that are already configured for the cluster,
        /// an error is returned.</para>
        /// </summary>
        /// 
        /// <param name="modifyClusterRequest">Container for the necessary parameters to execute the ModifyCluster service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.InsufficientClusterCapacityException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.UnsupportedOptionException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ModifyClusterResponse> ModifyClusterAsync(ModifyClusterRequest modifyClusterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyClusterRequestMarshaller();
            var unmarshaller = ModifyClusterResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyClusterRequest, ModifyClusterResponse>(modifyClusterRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Modifies the parameters of a parameter group. </para> <para> For more information about managing parameter groups, go to Amazon
        /// Redshift Parameter Groups in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="modifyClusterParameterGroupRequest">Container for the necessary parameters to execute the ModifyClusterParameterGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyClusterParameterGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterParameterGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ModifyClusterParameterGroupResponse> ModifyClusterParameterGroupAsync(ModifyClusterParameterGroupRequest modifyClusterParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyClusterParameterGroupRequestMarshaller();
            var unmarshaller = ModifyClusterParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyClusterParameterGroupRequest, ModifyClusterParameterGroupResponse>(modifyClusterParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Modifies a cluster subnet group to include the specified list of VPC subnets. The operation replaces the existing list of subnets
        /// with the new list of subnets. </para>
        /// </summary>
        /// 
        /// <param name="modifyClusterSubnetGroupRequest">Container for the necessary parameters to execute the ModifyClusterSubnetGroup service method
        /// on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ModifyClusterSubnetGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.SubnetAlreadyInUseException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ModifyClusterSubnetGroupResponse> ModifyClusterSubnetGroupAsync(ModifyClusterSubnetGroupRequest modifyClusterSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyClusterSubnetGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ModifyClusterSubnetGroupRequest, ModifyClusterSubnetGroupResponse>(modifyClusterSubnetGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Allows you to purchase reserved nodes. Amazon Redshift offers a predefined set of reserved node offerings. You can purchase one of
        /// the offerings. You can call the DescribeReservedNodeOfferings API to obtain the available reserved node offerings. You can call this API by
        /// providing a specific reserved node offering and the number of nodes you want to reserve. </para> <para> For more information about managing
        /// parameter groups, go to Purchasing Reserved Nodes in the <i>Amazon Redshift Management Guide</i> .
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <param name="purchaseReservedNodeOfferingRequest">Container for the necessary parameters to execute the PurchaseReservedNodeOffering service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the PurchaseReservedNodeOffering service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ReservedNodeQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<PurchaseReservedNodeOfferingResponse> PurchaseReservedNodeOfferingAsync(PurchaseReservedNodeOfferingRequest purchaseReservedNodeOfferingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedNodeOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedNodeOfferingResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, PurchaseReservedNodeOfferingRequest, PurchaseReservedNodeOfferingResponse>(purchaseReservedNodeOfferingRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Reboots a cluster. This action is taken as soon as possible. It results in a momentary outage to the cluster, during which the
        /// cluster status is set to <c>rebooting</c> . A cluster event is created when the reboot is completed. Any pending cluster modifications (see
        /// ModifyCluster) are applied at this reboot. For more information about managing clusters, go to Amazon Redshift Clusters in the <i>Amazon
        /// Redshift Management Guide</i> </para>
        /// </summary>
        /// 
        /// <param name="rebootClusterRequest">Container for the necessary parameters to execute the RebootCluster service method on
        /// AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RebootCluster service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<RebootClusterResponse> RebootClusterAsync(RebootClusterRequest rebootClusterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootClusterRequestMarshaller();
            var unmarshaller = RebootClusterResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RebootClusterRequest, RebootClusterResponse>(rebootClusterRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Sets one or more parameters of the specified parameter group to their default values and sets the source values of the parameters to
        /// "engine-default". To reset the entire parameter group specify the <i>ResetAllParameters</i> parameter. For parameter changes to take effect
        /// you must reboot any associated clusters. </para>
        /// </summary>
        /// 
        /// <param name="resetClusterParameterGroupRequest">Container for the necessary parameters to execute the ResetClusterParameterGroup service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the ResetClusterParameterGroup service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterParameterGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ResetClusterParameterGroupResponse> ResetClusterParameterGroupAsync(ResetClusterParameterGroupRequest resetClusterParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetClusterParameterGroupRequestMarshaller();
            var unmarshaller = ResetClusterParameterGroupResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ResetClusterParameterGroupRequest, ResetClusterParameterGroupResponse>(resetClusterParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Creates a new cluster from a snapshot. Amazon Redshift creates the resulting cluster with the same configuration as the original
        /// cluster from which the snapshot was created, except that the new cluster is created with the default cluster security and parameter group.
        /// After Amazon Redshift creates the cluster you can use the ModifyCluster API to associate a different security group and different parameter
        /// group with the restored cluster. </para> <para> If a snapshot is taken of a cluster in VPC, you can restore it only in VPC. In this case,
        /// you must provide a cluster subnet group where you want the cluster restored. If snapshot is taken of a cluster outside VPC, then you can
        /// restore it only outside VPC.</para> <para> For more information about working with snapshots, go to Amazon Redshift Snapshots in the
        /// <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="restoreFromClusterSnapshotRequest">Container for the necessary parameters to execute the RestoreFromClusterSnapshot service
        /// method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RestoreFromClusterSnapshot service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidRestoreException" />
        /// <exception cref="T:Amazon.Redshift.Model.InsufficientClusterCapacityException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSnapshotNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterAlreadyExistsException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterQuotaExceededException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSnapshotStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<RestoreFromClusterSnapshotResponse> RestoreFromClusterSnapshotAsync(RestoreFromClusterSnapshotRequest restoreFromClusterSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var unmarshaller = RestoreFromClusterSnapshotResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RestoreFromClusterSnapshotRequest, RestoreFromClusterSnapshotResponse>(restoreFromClusterSnapshotRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Revokes an ingress rule in an Amazon Redshift security group for a previously authorized IP range or Amazon EC2 security group. To
        /// add an ingress rule, see AuthorizeClusterSecurityGroupIngress. For information about managing security groups, go to Amazon Redshift Cluster
        /// Security Groups in the <i>Amazon Redshift Management Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="revokeClusterSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        /// RevokeClusterSecurityGroupIngress service method on AmazonRedshift.</param>
        /// 
        /// <returns>The response from the RevokeClusterSecurityGroupIngress service method, as returned by AmazonRedshift.</returns>
        /// 
        /// <exception cref="T:Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException" />
        /// <exception cref="T:Amazon.Redshift.Model.AuthorizationNotFoundException" />
        /// <exception cref="T:Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<RevokeClusterSecurityGroupIngressResponse> RevokeClusterSecurityGroupIngressAsync(RevokeClusterSecurityGroupIngressRequest revokeClusterSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeClusterSecurityGroupIngressResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RevokeClusterSecurityGroupIngressRequest, RevokeClusterSecurityGroupIngressResponse>(revokeClusterSecurityGroupIngressRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
