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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Redshift.Model;
using Amazon.Redshift.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift
{
    /// <summary>
    /// Implementation for accessing Redshift
    ///
    /// Amazon Redshift <b>Overview</b> 
    /// <para>
    ///  This is an interface reference for Amazon Redshift. It contains documentation for
    /// one of the programming or command line interfaces you can use to manage Amazon Redshift
    /// clusters. Note that Amazon Redshift is asynchronous, which means that some interfaces
    /// may require techniques, such as polling or asynchronous callback handlers, to determine
    /// when a command has been applied. In this reference, the parameter descriptions indicate
    /// whether a change is applied immediately, on the next instance reboot, or during the
    /// next maintenance window. For a summary of the Amazon Redshift cluster management interfaces,
    /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/using-aws-sdk.html">Using
    /// the Amazon Redshift Management Interfaces </a>.
    /// </para>
    ///  
    /// <para>
    ///  Amazon Redshift manages all the work of setting up, operating, and scaling a data
    /// warehouse: provisioning capacity, monitoring and backing up the cluster, and applying
    /// patches and upgrades to the Amazon Redshift engine. You can focus on using your data
    /// to acquire new insights for your business and customers. 
    /// </para>
    ///  
    /// <para>
    /// If you are a first-time user of Amazon Redshift, we recommend that you begin by reading
    /// the The <a href="http://docs.aws.amazon.com/redshift/latest/gsg/getting-started.html">Amazon
    /// Redshift Getting Started Guide</a>
    /// </para>
    ///  
    /// <para>
    /// If you are a database developer, the <a href="http://docs.aws.amazon.com/redshift/latest/dg/welcome.html">Amazon
    /// Redshift Database Developer Guide</a> explains how to design, build, query, and maintain
    /// the databases that make up your data warehouse. 
    /// </para>
    /// </summary>
    public partial class AmazonRedshiftClient : AmazonServiceClient, IAmazonRedshift
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonRedshiftClient with the credentials loaded from the application's
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
        public AmazonRedshiftClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftConfig()) { }

        /// <summary>
        /// Constructs AmazonRedshiftClient with the credentials loaded from the application's
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
        public AmazonRedshiftClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRedshiftClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(AmazonRedshiftConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            : this(credentials, new AmazonRedshiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Credentials and an
        /// AmazonRedshiftClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(AWSCredentials credentials, AmazonRedshiftConfig clientConfig)
            : base(credentials, clientConfig)
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
        /// AmazonRedshiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRedshiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRedshiftClient Configuration Object</param>
        public AmazonRedshiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRedshiftConfig clientConfig)
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

        
        #region  AuthorizeClusterSecurityGroupIngress


        /// <summary>
        /// Adds an inbound (ingress) rule to an Amazon Redshift security group. Depending on
        /// whether the application accessing your cluster is running on the Internet or an Amazon
        /// EC2 instance, you can authorize inbound access to either a Classless Interdomain Routing
        /// (CIDR)/Internet Protocol (IP) range or to an Amazon EC2 security group. You can add
        /// as many as 20 ingress rules to an Amazon Redshift security group. 
        /// 
        ///  
        /// <para>
        /// If you authorize access to an Amazon EC2 security group, specify <i>EC2SecurityGroupName</i>
        /// and <i>EC2SecurityGroupOwnerId</i>. The Amazon EC2 security group and Amazon Redshift
        /// cluster must be in the same AWS region. 
        /// </para>
        ///  
        /// <para>
        ///  If you authorize access to a CIDR/IP address range, specify <i>CIDRIP</i>. For an
        /// overview of CIDR blocks, see the Wikipedia article on <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>. 
        /// </para>
        ///  
        /// <para>
        ///  You must also associate the security group with a cluster so that clients running
        /// on these IP addresses or the EC2 instance are authorized to connect to the cluster.
        /// For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Working
        /// with Security Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        public AuthorizeClusterSecurityGroupIngressResponse AuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request)
        {
            var marshaller = new AuthorizeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeClusterSecurityGroupIngressRequest,AuthorizeClusterSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeClusterSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AuthorizeClusterSecurityGroupIngressResponse> AuthorizeClusterSecurityGroupIngressAsync(AuthorizeClusterSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeClusterSecurityGroupIngressRequest,AuthorizeClusterSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeSnapshotAccess


        /// <summary>
        /// Authorizes the specified AWS customer account to restore the specified snapshot.
        /// 
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess service method.</param>
        /// 
        /// <returns>The response from the AuthorizeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        public AuthorizeSnapshotAccessResponse AuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request)
        {
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var unmarshaller = AuthorizeSnapshotAccessResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSnapshotAccessRequest,AuthorizeSnapshotAccessResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSnapshotAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AuthorizeSnapshotAccessResponse> AuthorizeSnapshotAccessAsync(AuthorizeSnapshotAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var unmarshaller = AuthorizeSnapshotAccessResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSnapshotAccessRequest,AuthorizeSnapshotAccessResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyClusterSnapshot


        /// <summary>
        /// Copies the specified automated cluster snapshot to a new manual cluster snapshot.
        /// The source must be an automated snapshot and it must be in the available state. 
        /// 
        ///  
        /// <para>
        ///  When you delete a cluster, Amazon Redshift deletes any automated snapshots of the
        /// cluster. Also, when the retention period of the snapshot expires, Amazon Redshift
        /// automatically deletes it. If you want to keep an automated snapshot for a longer period,
        /// you can make a manual copy of the snapshot. Manual snapshots are retained until you
        /// delete them. 
        /// </para>
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        public CopyClusterSnapshotResponse CopyClusterSnapshot(CopyClusterSnapshotRequest request)
        {
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var unmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyClusterSnapshotRequest,CopyClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CopyClusterSnapshotResponse> CopyClusterSnapshotAsync(CopyClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var unmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopyClusterSnapshotRequest,CopyClusterSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCluster


        /// <summary>
        /// Creates a new cluster. To create the cluster in virtual private cloud (VPC), you
        /// must provide cluster subnet group name. If you don't provide a cluster subnet group
        /// name or the cluster security group parameter, Amazon Redshift creates a non-VPC cluster,
        /// it associates the default cluster security group with the cluster. For more information
        /// about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i> .
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this account.
        /// For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// The request exceeds the limit of 10 tags for the resource.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        public CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var marshaller = new CreateClusterRequestMarshaller();
            var unmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterRequest,CreateClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterRequestMarshaller();
            var unmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterRequest,CreateClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateClusterParameterGroup


        /// <summary>
        /// Creates an Amazon Redshift parameter group. 
        /// 
        ///  
        /// <para>
        /// Creating parameter groups is independent of creating clusters. You can associate a
        /// cluster with a parameter group when you create the cluster. You can also associate
        /// an existing cluster with a parameter group after the cluster is created by using <a>ModifyCluster</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Parameters in the parameter group define specific behavior that applies to the databases
        /// you create on the cluster. For more information about parameters and parameter groups,
        /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupAlreadyExistsException">
        /// A cluster parameter group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster parameter
        /// groups. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// The request exceeds the limit of 10 tags for the resource.
        /// </exception>
        public CreateClusterParameterGroupResponse CreateClusterParameterGroup(CreateClusterParameterGroupRequest request)
        {
            var marshaller = new CreateClusterParameterGroupRequestMarshaller();
            var unmarshaller = CreateClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterParameterGroupRequest,CreateClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterParameterGroupResponse> CreateClusterParameterGroupAsync(CreateClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterParameterGroupRequestMarshaller();
            var unmarshaller = CreateClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterParameterGroupRequest,CreateClusterParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateClusterSecurityGroup


        /// <summary>
        /// Creates a new Amazon Redshift security group. You use security groups to control
        /// access to non-VPC clusters. 
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupAlreadyExistsException">
        /// A cluster security group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster security
        /// groups. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// The request exceeds the limit of 10 tags for the resource.
        /// </exception>
        public CreateClusterSecurityGroupResponse CreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request)
        {
            var marshaller = new CreateClusterSecurityGroupRequestMarshaller();
            var unmarshaller = CreateClusterSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSecurityGroupRequest,CreateClusterSecurityGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterSecurityGroupResponse> CreateClusterSecurityGroupAsync(CreateClusterSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterSecurityGroupRequestMarshaller();
            var unmarshaller = CreateClusterSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterSecurityGroupRequest,CreateClusterSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateClusterSnapshot


        /// <summary>
        /// Creates a manual snapshot of the specified cluster. The cluster must be in the <code>available</code>
        /// state. 
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// The request exceeds the limit of 10 tags for the resource.
        /// </exception>
        public CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest request)
        {
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var unmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSnapshotRequest,CreateClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterSnapshotResponse> CreateClusterSnapshotAsync(CreateClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var unmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterSnapshotRequest,CreateClusterSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateClusterSubnetGroup


        /// <summary>
        /// Creates a new Amazon Redshift subnet group. You must provide a list of one or more
        /// subnets in your existing Amazon Virtual Private Cloud (Amazon VPC) when creating Amazon
        /// Redshift subnet group. 
        /// 
        ///  
        /// <para>
        ///  For information about subnet groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-cluster-subnet-groups.html">Amazon
        /// Redshift Cluster Subnet Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupAlreadyExistsException">
        /// A <i>ClusterSubnetGroupName</i> is already used by an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupQuotaExceededException">
        /// The request would result in user exceeding the allowed number of cluster subnet groups.
        /// For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets in a cluster
        /// subnet groups. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// The request exceeds the limit of 10 tags for the resource.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        public CreateClusterSubnetGroupResponse CreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request)
        {
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var unmarshaller = CreateClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateClusterSubnetGroupRequest,CreateClusterSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateClusterSubnetGroupResponse> CreateClusterSubnetGroupAsync(CreateClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var unmarshaller = CreateClusterSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterSubnetGroupRequest,CreateClusterSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateEventSubscription


        /// <summary>
        /// Creates an Amazon Redshift event notification subscription. This action requires
        /// an ARN (Amazon Resource Name) of an Amazon SNS topic created by either the Amazon
        /// Redshift console, the Amazon SNS console, or the Amazon SNS API. To obtain an ARN
        /// with Amazon SNS, you must create a topic in Amazon SNS and subscribe to the topic.
        /// The ARN is displayed in the SNS console. 
        /// 
        ///  
        /// <para>
        ///  You can specify the source type, and lists of Amazon Redshift source IDs, event categories,
        /// and event severities. Notifications will be sent for all events you want that match
        /// those criteria. For example, you can specify source type = cluster, source ID = my-cluster-1
        /// and mycluster2, event categories = Availability, Backup, and severity = ERROR. The
        /// subscription will only send notifications for those ERROR events in the Availability
        /// and Backup categories for the specified clusters. 
        /// </para>
        ///  
        /// <para>
        ///  If you specify both the source type and source IDs, such as source type = cluster
        /// and source identifier = my-cluster-1, notifications will be sent for all the cluster
        /// events for my-cluster-1. If you specify a source type but do not specify a source
        /// identifier, you will receive notice of the events for the objects of that type in
        /// your AWS account. If you do not specify either the SourceType nor the SourceIdentifier,
        /// you will be notified of events generated from all Amazon Redshift sources belonging
        /// to your AWS account. You must specify a source type if you specify a source ID. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.EventSubscriptionQuotaExceededException">
        /// The request would exceed the allowed number of event subscriptions for this account.
        /// For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionAlreadyExistException">
        /// There is already an existing event notification subscription with the specified name.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or it
        /// specified a category that does not apply to the specified source type. The allowed
        /// values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or it
        /// specified a severity that does not apply to the specified source type. The allowed
        /// values are ERROR and INFO.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// The request exceeds the limit of 10 tags for the resource.
        /// </exception>
        public CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionRequest,CreateEventSubscriptionResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventSubscriptionRequest,CreateEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHsmClientCertificate


        /// <summary>
        /// Creates an HSM client certificate that an Amazon Redshift cluster will use to connect
        /// to the client's HSM in order to store and retrieve the keys used to encrypt the cluster
        /// databases.
        /// 
        ///  
        /// <para>
        /// The command returns a public key, which you must store in the HSM. In addition to
        /// creating the HSM certificate, you must create an Amazon Redshift HSM configuration
        /// that provides a cluster the information needed to store and use encryption keys in
        /// the HSM. For more information, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware
        /// Security Modules</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate service method.</param>
        /// 
        /// <returns>The response from the CreateHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM client certificate with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateQuotaExceededException">
        /// The quota for HSM client certificates has been reached. For information about increasing
        /// your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// The request exceeds the limit of 10 tags for the resource.
        /// </exception>
        public CreateHsmClientCertificateResponse CreateHsmClientCertificate(CreateHsmClientCertificateRequest request)
        {
            var marshaller = new CreateHsmClientCertificateRequestMarshaller();
            var unmarshaller = CreateHsmClientCertificateResponseUnmarshaller.Instance;

            return Invoke<CreateHsmClientCertificateRequest,CreateHsmClientCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateHsmClientCertificateResponse> CreateHsmClientCertificateAsync(CreateHsmClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHsmClientCertificateRequestMarshaller();
            var unmarshaller = CreateHsmClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHsmClientCertificateRequest,CreateHsmClientCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateHsmConfiguration


        /// <summary>
        /// Creates an HSM configuration that contains the information required by an Amazon Redshift
        /// cluster to store and use database encryption keys in a Hardware Security Module (HSM).
        /// After creating the HSM configuration, you can specify it as a parameter when creating
        /// a cluster. The cluster will then store its encryption keys in the HSM.
        /// 
        ///  
        /// <para>
        /// In addition to creating an HSM configuration, you must also create an HSM client certificate.
        /// For more information, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware
        /// Security Modules</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM configuration with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationQuotaExceededException">
        /// The quota for HSM configurations has been reached. For information about increasing
        /// your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// The request exceeds the limit of 10 tags for the resource.
        /// </exception>
        public CreateHsmConfigurationResponse CreateHsmConfiguration(CreateHsmConfigurationRequest request)
        {
            var marshaller = new CreateHsmConfigurationRequestMarshaller();
            var unmarshaller = CreateHsmConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateHsmConfigurationRequest,CreateHsmConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateHsmConfigurationResponse> CreateHsmConfigurationAsync(CreateHsmConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateHsmConfigurationRequestMarshaller();
            var unmarshaller = CreateHsmConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateHsmConfigurationRequest,CreateHsmConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshotCopyGrant


        /// <summary>
        /// Creates a snapshot copy grant that permits Amazon Redshift to use a customer master
        /// key (CMK) from AWS Key Management Service (AWS KMS) to encrypt copied snapshots in
        /// a destination region.
        /// 
        ///  
        /// <para>
        ///  For more information about managing snapshot copy grants, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-db-encryption.html">Amazon
        /// Redshift Database Encryption</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotCopyGrant service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshotCopyGrant service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantAlreadyExistsException">
        /// The snapshot copy grant can't be created because a grant with the same name already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantQuotaExceededException">
        /// The AWS account has exceeded the maximum number of snapshot copy grants in this region.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// The request exceeds the limit of 10 tags for the resource.
        /// </exception>
        public CreateSnapshotCopyGrantResponse CreateSnapshotCopyGrant(CreateSnapshotCopyGrantRequest request)
        {
            var marshaller = new CreateSnapshotCopyGrantRequestMarshaller();
            var unmarshaller = CreateSnapshotCopyGrantResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotCopyGrantRequest,CreateSnapshotCopyGrantResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshotCopyGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotCopyGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateSnapshotCopyGrantResponse> CreateSnapshotCopyGrantAsync(CreateSnapshotCopyGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSnapshotCopyGrantRequestMarshaller();
            var unmarshaller = CreateSnapshotCopyGrantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotCopyGrantRequest,CreateSnapshotCopyGrantResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTags


        /// <summary>
        /// Adds one or more tags to a specified resource. 
        /// 
        ///  
        /// <para>
        ///  A resource can have up to 10 tags. If you try to create more than 10 tags for a resource,
        /// you will receive an error and the attempt will fail. 
        /// </para>
        ///  
        /// <para>
        ///  If you specify a key that already exists for the resource, the value for that key
        /// will be updated with the new value. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// The request exceeds the limit of 10 tags for the resource.
        /// </exception>
        public CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsRequest,CreateTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsRequest,CreateTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes a previously provisioned cluster. A successful response from the web service
        /// indicates that the request was received correctly. Use <a>DescribeClusters</a> to
        /// monitor the status of the deletion. The delete operation cannot be canceled or reverted
        /// once submitted. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i> . 
        /// 
        ///  
        /// <para>
        ///  If you want to shut down the cluster and retain it for future use, set <i>SkipFinalClusterSnapshot</i>
        /// to <code>false</code> and specify a name for <i>FinalClusterSnapshotIdentifier</i>.
        /// You can later restore this snapshot to resume using the cluster. If a final cluster
        /// snapshot is requested, the status of the cluster will be "final-snapshot" while the
        /// snapshot is being taken, then it's "deleting" once Amazon Redshift begins deleting
        /// the cluster. 
        /// </para>
        ///  
        /// <para>
        ///  For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i> . 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var marshaller = new DeleteClusterRequestMarshaller();
            var unmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterRequest,DeleteClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterRequestMarshaller();
            var unmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterRequest,DeleteClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteClusterParameterGroup


        /// <summary>
        /// Deletes a specified Amazon Redshift parameter group. <note>You cannot delete a parameter
        /// group if it is associated with a cluster.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        public DeleteClusterParameterGroupResponse DeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request)
        {
            var marshaller = new DeleteClusterParameterGroupRequestMarshaller();
            var unmarshaller = DeleteClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterParameterGroupRequest,DeleteClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterParameterGroupResponse> DeleteClusterParameterGroupAsync(DeleteClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterParameterGroupRequestMarshaller();
            var unmarshaller = DeleteClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterParameterGroupRequest,DeleteClusterParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteClusterSecurityGroup


        /// <summary>
        /// Deletes an Amazon Redshift security group. 
        /// 
        ///  <note>You cannot delete a security group that is associated with any clusters. You
        /// cannot delete the default security group.</note> 
        /// <para>
        ///  For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        public DeleteClusterSecurityGroupResponse DeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request)
        {
            var marshaller = new DeleteClusterSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSecurityGroupRequest,DeleteClusterSecurityGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterSecurityGroupResponse> DeleteClusterSecurityGroupAsync(DeleteClusterSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterSecurityGroupRequest,DeleteClusterSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteClusterSnapshot


        /// <summary>
        /// Deletes the specified manual snapshot. The snapshot must be in the <code>available</code>
        /// state, with no other users authorized to access the snapshot. 
        /// 
        ///  
        /// <para>
        ///  Unlike automated snapshots, manual snapshots are retained even after you delete your
        /// cluster. Amazon Redshift does not delete your manual snapshots. You must delete manual
        /// snapshot explicitly to avoid getting charged. If other accounts are authorized to
        /// access the snapshot, you must revoke all of the authorizations before you can delete
        /// the snapshot. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        public DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest request)
        {
            var marshaller = new DeleteClusterSnapshotRequestMarshaller();
            var unmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSnapshotRequest,DeleteClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterSnapshotResponse> DeleteClusterSnapshotAsync(DeleteClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterSnapshotRequestMarshaller();
            var unmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterSnapshotRequest,DeleteClusterSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteClusterSubnetGroup


        /// <summary>
        /// Deletes the specified cluster subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetStateException">
        /// The state of the subnet is invalid.
        /// </exception>
        public DeleteClusterSubnetGroupResponse DeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request)
        {
            var marshaller = new DeleteClusterSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterSubnetGroupRequest,DeleteClusterSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClusterSubnetGroupResponse> DeleteClusterSubnetGroupAsync(DeleteClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClusterSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterSubnetGroupRequest,DeleteClusterSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventSubscription


        /// <summary>
        /// Deletes an Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request. This subscription
        /// request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        public DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionRequest,DeleteEventSubscriptionResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventSubscriptionRequest,DeleteEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteHsmClientCertificate


        /// <summary>
        /// Deletes the specified HSM client certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidHsmClientCertificateStateException">
        /// The specified HSM client certificate is not in the <code>available</code> state, or
        /// it is still in use by one or more Amazon Redshift clusters.
        /// </exception>
        public DeleteHsmClientCertificateResponse DeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request)
        {
            var marshaller = new DeleteHsmClientCertificateRequestMarshaller();
            var unmarshaller = DeleteHsmClientCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmClientCertificateRequest,DeleteHsmClientCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteHsmClientCertificateResponse> DeleteHsmClientCertificateAsync(DeleteHsmClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHsmClientCertificateRequestMarshaller();
            var unmarshaller = DeleteHsmClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHsmClientCertificateRequest,DeleteHsmClientCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteHsmConfiguration


        /// <summary>
        /// Deletes the specified Amazon Redshift HSM configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidHsmConfigurationStateException">
        /// The specified HSM configuration is not in the <code>available</code> state, or it
        /// is still in use by one or more Amazon Redshift clusters.
        /// </exception>
        public DeleteHsmConfigurationResponse DeleteHsmConfiguration(DeleteHsmConfigurationRequest request)
        {
            var marshaller = new DeleteHsmConfigurationRequestMarshaller();
            var unmarshaller = DeleteHsmConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteHsmConfigurationRequest,DeleteHsmConfigurationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteHsmConfigurationResponse> DeleteHsmConfigurationAsync(DeleteHsmConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteHsmConfigurationRequestMarshaller();
            var unmarshaller = DeleteHsmConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHsmConfigurationRequest,DeleteHsmConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshotCopyGrant


        /// <summary>
        /// Deletes the specified snapshot copy grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotCopyGrant service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshotCopyGrant service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSnapshotCopyGrantStateException">
        /// The snapshot copy grant can't be deleted because it is used by one or more clusters.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        public DeleteSnapshotCopyGrantResponse DeleteSnapshotCopyGrant(DeleteSnapshotCopyGrantRequest request)
        {
            var marshaller = new DeleteSnapshotCopyGrantRequestMarshaller();
            var unmarshaller = DeleteSnapshotCopyGrantResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotCopyGrantRequest,DeleteSnapshotCopyGrantResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshotCopyGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotCopyGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteSnapshotCopyGrantResponse> DeleteSnapshotCopyGrantAsync(DeleteSnapshotCopyGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSnapshotCopyGrantRequestMarshaller();
            var unmarshaller = DeleteSnapshotCopyGrantResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotCopyGrantRequest,DeleteSnapshotCopyGrantResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Deletes a tag or tags from a resource. You must provide the ARN of the resource from
        /// which you want to delete the tag or tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        public DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterParameterGroups


        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
        /// created and the default parameter group. For each parameter group, the response includes
        /// the parameter group name, description, and parameter group family name. You can optionally
        /// specify a name to retrieve the description of a specific parameter group. 
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all parameter groups that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all parameter groups
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, parameter groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups()
        {
            return DescribeClusterParameterGroups(new DescribeClusterParameterGroupsRequest());
        }


        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
        /// created and the default parameter group. For each parameter group, the response includes
        /// the parameter group name, description, and parameter group family name. You can optionally
        /// specify a name to retrieve the description of a specific parameter group. 
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all parameter groups that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all parameter groups
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, parameter groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request)
        {
            var marshaller = new DescribeClusterParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterParameterGroupsRequest,DescribeClusterParameterGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
        /// created and the default parameter group. For each parameter group, the response includes
        /// the parameter group name, description, and parameter group family name. You can optionally
        /// specify a name to retrieve the description of a specific parameter group. 
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all parameter groups that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all parameter groups
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, parameter groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterParameterGroupsAsync(new DescribeClusterParameterGroupsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(DescribeClusterParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterParameterGroupsRequest,DescribeClusterParameterGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterParameters


        /// <summary>
        /// Returns a detailed list of parameters contained within the specified Amazon Redshift
        /// parameter group. For each parameter the response includes information such as parameter
        /// name, description, data type, value, whether the parameter value is modifiable, and
        /// so on. 
        /// 
        ///  
        /// <para>
        /// You can specify <i>source</i> filter to retrieve parameters of only specific type.
        /// For example, to retrieve parameters that were modified by a user action such as from
        /// <a>ModifyClusterParameterGroup</a>, you can specify <i>source</i> equal to <i>user</i>.
        /// </para>
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        public DescribeClusterParametersResponse DescribeClusterParameters(DescribeClusterParametersRequest request)
        {
            var marshaller = new DescribeClusterParametersRequestMarshaller();
            var unmarshaller = DescribeClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterParametersRequest,DescribeClusterParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterParametersResponse> DescribeClusterParametersAsync(DescribeClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterParametersRequestMarshaller();
            var unmarshaller = DescribeClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterParametersRequest,DescribeClusterParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusters


        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties,
        /// cluster database properties, maintenance and backup properties, and security and access
        /// properties. This operation supports pagination. For more information about managing
        /// clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i> . 
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all clusters that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all clusters that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, clusters are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeClustersResponse DescribeClusters()
        {
            return DescribeClusters(new DescribeClustersRequest());
        }


        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties,
        /// cluster database properties, maintenance and backup properties, and security and access
        /// properties. This operation supports pagination. For more information about managing
        /// clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i> . 
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all clusters that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all clusters that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, clusters are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var marshaller = new DescribeClustersRequestMarshaller();
            var unmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeClustersRequest,DescribeClustersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties,
        /// cluster database properties, maintenance and backup properties, and security and access
        /// properties. This operation supports pagination. For more information about managing
        /// clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i> . 
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all clusters that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all clusters that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, clusters are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public Task<DescribeClustersResponse> DescribeClustersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClustersAsync(new DescribeClustersRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClustersRequestMarshaller();
            var unmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClustersRequest,DescribeClustersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterSecurityGroups


        /// <summary>
        /// Returns information about Amazon Redshift security groups. If the name of a security
        /// group is specified, the response will contain only information about only that security
        /// group. 
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all security groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all security groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, security groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups()
        {
            return DescribeClusterSecurityGroups(new DescribeClusterSecurityGroupsRequest());
        }


        /// <summary>
        /// Returns information about Amazon Redshift security groups. If the name of a security
        /// group is specified, the response will contain only information about only that security
        /// group. 
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all security groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all security groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, security groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request)
        {
            var marshaller = new DescribeClusterSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSecurityGroupsRequest,DescribeClusterSecurityGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns information about Amazon Redshift security groups. If the name of a security
        /// group is specified, the response will contain only information about only that security
        /// group. 
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all security groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all security groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, security groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterSecurityGroupsAsync(new DescribeClusterSecurityGroupsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(DescribeClusterSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterSecurityGroupsRequest,DescribeClusterSecurityGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterSnapshots


        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
        /// By default, this operation returns information about all snapshots of all clusters
        /// that are owned by you AWS customer account. No information is returned for snapshots
        /// owned by inactive AWS customer accounts. 
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all snapshots that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all snapshots that have any combination of those
        /// values are returned. Only snapshots that you own are returned in the response; shared
        /// snapshots are not returned with the tag key and tag value request parameters.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, snapshots are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeClusterSnapshotsResponse DescribeClusterSnapshots()
        {
            return DescribeClusterSnapshots(new DescribeClusterSnapshotsRequest());
        }


        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
        /// By default, this operation returns information about all snapshots of all clusters
        /// that are owned by you AWS customer account. No information is returned for snapshots
        /// owned by inactive AWS customer accounts. 
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all snapshots that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all snapshots that have any combination of those
        /// values are returned. Only snapshots that you own are returned in the response; shared
        /// snapshots are not returned with the tag key and tag value request parameters.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, snapshots are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeClusterSnapshotsResponse DescribeClusterSnapshots(DescribeClusterSnapshotsRequest request)
        {
            var marshaller = new DescribeClusterSnapshotsRequestMarshaller();
            var unmarshaller = DescribeClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSnapshotsRequest,DescribeClusterSnapshotsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
        /// By default, this operation returns information about all snapshots of all clusters
        /// that are owned by you AWS customer account. No information is returned for snapshots
        /// owned by inactive AWS customer accounts. 
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all snapshots that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all snapshots that have any combination of those
        /// values are returned. Only snapshots that you own are returned in the response; shared
        /// snapshots are not returned with the tag key and tag value request parameters.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, snapshots are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterSnapshotsAsync(new DescribeClusterSnapshotsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(DescribeClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterSnapshotsRequestMarshaller();
            var unmarshaller = DescribeClusterSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterSnapshotsRequest,DescribeClusterSnapshotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterSubnetGroups


        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata about your
        /// cluster subnet groups. By default, this operation returns information about all cluster
        /// subnet groups that are defined in you AWS account. 
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all subnet groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all subnet groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subnet groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups()
        {
            return DescribeClusterSubnetGroups(new DescribeClusterSubnetGroupsRequest());
        }


        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata about your
        /// cluster subnet groups. By default, this operation returns information about all cluster
        /// subnet groups that are defined in you AWS account. 
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all subnet groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all subnet groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subnet groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request)
        {
            var marshaller = new DescribeClusterSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterSubnetGroupsRequest,DescribeClusterSubnetGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata about your
        /// cluster subnet groups. By default, this operation returns information about all cluster
        /// subnet groups that are defined in you AWS account. 
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all subnet groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all subnet groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subnet groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterSubnetGroupsAsync(new DescribeClusterSubnetGroupsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(DescribeClusterSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterSubnetGroupsRequest,DescribeClusterSubnetGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusterVersions


        /// <summary>
        /// Returns descriptions of the available Amazon Redshift cluster versions. You can call
        /// this operation even before creating any clusters to learn more about the Amazon Redshift
        /// versions. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        public DescribeClusterVersionsResponse DescribeClusterVersions()
        {
            return DescribeClusterVersions(new DescribeClusterVersionsRequest());
        }


        /// <summary>
        /// Returns descriptions of the available Amazon Redshift cluster versions. You can call
        /// this operation even before creating any clusters to learn more about the Amazon Redshift
        /// versions. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        public DescribeClusterVersionsResponse DescribeClusterVersions(DescribeClusterVersionsRequest request)
        {
            var marshaller = new DescribeClusterVersionsRequestMarshaller();
            var unmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterVersionsRequest,DescribeClusterVersionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns descriptions of the available Amazon Redshift cluster versions. You can call
        /// this operation even before creating any clusters to learn more about the Amazon Redshift
        /// versions. For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        public Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterVersionsAsync(new DescribeClusterVersionsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(DescribeClusterVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClusterVersionsRequestMarshaller();
            var unmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterVersionsRequest,DescribeClusterVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDefaultClusterParameters


        /// <summary>
        /// Returns a list of parameter settings for the specified parameter group family. 
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultClusterParameters service method, as returned by Redshift.</returns>
        public DescribeDefaultClusterParametersResponse DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request)
        {
            var marshaller = new DescribeDefaultClusterParametersRequestMarshaller();
            var unmarshaller = DescribeDefaultClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDefaultClusterParametersRequest,DescribeDefaultClusterParametersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDefaultClusterParametersResponse> DescribeDefaultClusterParametersAsync(DescribeDefaultClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDefaultClusterParametersRequestMarshaller();
            var unmarshaller = DescribeDefaultClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDefaultClusterParametersRequest,DescribeDefaultClusterParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventCategories


        /// <summary>
        /// Displays a list of event categories for all event source types, or for a specified
        /// source type. For a list of the event categories and source types, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        public DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }


        /// <summary>
        /// Displays a list of event categories for all event source types, or for a specified
        /// source type. For a list of the event categories and source types, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        public DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesRequest,DescribeEventCategoriesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Displays a list of event categories for all event source types, or for a specified
        /// source type. For a list of the event categories and source types, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        public Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventCategoriesAsync(new DescribeEventCategoriesRequest(), cancellationToken);
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
        public Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventCategoriesRequest,DescribeEventCategoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter groups
        /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
        /// or parameter group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        public DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }


        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter groups
        /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
        /// or parameter group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter groups
        /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
        /// or parameter group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        public Task<DescribeEventsResponse> DescribeEventsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventsAsync(new DescribeEventsRequest(), cancellationToken);
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
        public Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventSubscriptions


        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notifications subscription for
        /// a customer account. If you specify a subscription name, lists the description for
        /// that subscription.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        public DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }


        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notifications subscription for
        /// a customer account. If you specify a subscription name, lists the description for
        /// that subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        public DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsRequest,DescribeEventSubscriptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notifications subscription for
        /// a customer account. If you specify a subscription name, lists the description for
        /// that subscription.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        public Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventSubscriptionsAsync(new DescribeEventSubscriptionsRequest(), cancellationToken);
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
        public Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventSubscriptionsRequest,DescribeEventSubscriptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeHsmClientCertificates


        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified, returns information about all the HSM certificates owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM client certificates that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM client certificates
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM client certificates
        /// are returned regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates()
        {
            return DescribeHsmClientCertificates(new DescribeHsmClientCertificatesRequest());
        }


        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified, returns information about all the HSM certificates owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM client certificates that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM client certificates
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM client certificates
        /// are returned regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates service method.</param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request)
        {
            var marshaller = new DescribeHsmClientCertificatesRequestMarshaller();
            var unmarshaller = DescribeHsmClientCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmClientCertificatesRequest,DescribeHsmClientCertificatesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified, returns information about all the HSM certificates owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM client certificates that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM client certificates
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM client certificates
        /// are returned regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeHsmClientCertificatesAsync(new DescribeHsmClientCertificatesRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(DescribeHsmClientCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeHsmClientCertificatesRequestMarshaller();
            var unmarshaller = DescribeHsmClientCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHsmClientCertificatesRequest,DescribeHsmClientCertificatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeHsmConfigurations


        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is specified, returns information about all the HSM configurations owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM connections that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM connections that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM connections are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeHsmConfigurationsResponse DescribeHsmConfigurations()
        {
            return DescribeHsmConfigurations(new DescribeHsmConfigurationsRequest());
        }


        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is specified, returns information about all the HSM configurations owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM connections that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM connections that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM connections are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public DescribeHsmConfigurationsResponse DescribeHsmConfigurations(DescribeHsmConfigurationsRequest request)
        {
            var marshaller = new DescribeHsmConfigurationsRequestMarshaller();
            var unmarshaller = DescribeHsmConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeHsmConfigurationsRequest,DescribeHsmConfigurationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is specified, returns information about all the HSM configurations owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM connections that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM connections that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM connections are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        public Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeHsmConfigurationsAsync(new DescribeHsmConfigurationsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(DescribeHsmConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeHsmConfigurationsRequestMarshaller();
            var unmarshaller = DescribeHsmConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHsmConfigurationsRequest,DescribeHsmConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoggingStatus


        /// <summary>
        /// Describes whether information, such as queries and connection attempts, is being logged
        /// for the specified Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeLoggingStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        public DescribeLoggingStatusResponse DescribeLoggingStatus(DescribeLoggingStatusRequest request)
        {
            var marshaller = new DescribeLoggingStatusRequestMarshaller();
            var unmarshaller = DescribeLoggingStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingStatusRequest,DescribeLoggingStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLoggingStatusResponse> DescribeLoggingStatusAsync(DescribeLoggingStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoggingStatusRequestMarshaller();
            var unmarshaller = DescribeLoggingStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoggingStatusRequest,DescribeLoggingStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrderableClusterOptions


        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a new cluster you
        /// can use this operation to find what options are available, such as the EC2 Availability
        /// Zones (AZ) in the specific AWS region that you can specify, and the node types you
        /// can request. The node types differ by available storage, memory, CPU and price. With
        /// the cost involved you might want to obtain a list of cluster options in the specific
        /// region and specify values when creating a cluster. For more information about managing
        /// clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        public DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions()
        {
            return DescribeOrderableClusterOptions(new DescribeOrderableClusterOptionsRequest());
        }


        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a new cluster you
        /// can use this operation to find what options are available, such as the EC2 Availability
        /// Zones (AZ) in the specific AWS region that you can specify, and the node types you
        /// can request. The node types differ by available storage, memory, CPU and price. With
        /// the cost involved you might want to obtain a list of cluster options in the specific
        /// region and specify values when creating a cluster. For more information about managing
        /// clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        public DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request)
        {
            var marshaller = new DescribeOrderableClusterOptionsRequestMarshaller();
            var unmarshaller = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableClusterOptionsRequest,DescribeOrderableClusterOptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a new cluster you
        /// can use this operation to find what options are available, such as the EC2 Availability
        /// Zones (AZ) in the specific AWS region that you can specify, and the node types you
        /// can request. The node types differ by available storage, memory, CPU and price. With
        /// the cost involved you might want to obtain a list of cluster options in the specific
        /// region and specify values when creating a cluster. For more information about managing
        /// clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        public Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeOrderableClusterOptionsAsync(new DescribeOrderableClusterOptionsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableClusterOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(DescribeOrderableClusterOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeOrderableClusterOptionsRequestMarshaller();
            var unmarshaller = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrderableClusterOptionsRequest,DescribeOrderableClusterOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedNodeOfferings


        /// <summary>
        /// Returns a list of the available reserved node offerings by Amazon Redshift with their
        /// descriptions including the node type, the fixed and recurring costs of reserving the
        /// node and duration the node will be reserved for you. These descriptions help you determine
        /// which reserve node offering you want to purchase. You then use the unique offering
        /// ID in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your Amazon Redshift cluster. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        public DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings()
        {
            return DescribeReservedNodeOfferings(new DescribeReservedNodeOfferingsRequest());
        }


        /// <summary>
        /// Returns a list of the available reserved node offerings by Amazon Redshift with their
        /// descriptions including the node type, the fixed and recurring costs of reserving the
        /// node and duration the node will be reserved for you. These descriptions help you determine
        /// which reserve node offering you want to purchase. You then use the unique offering
        /// ID in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your Amazon Redshift cluster. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        public DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request)
        {
            var marshaller = new DescribeReservedNodeOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodeOfferingsRequest,DescribeReservedNodeOfferingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a list of the available reserved node offerings by Amazon Redshift with their
        /// descriptions including the node type, the fixed and recurring costs of reserving the
        /// node and duration the node will be reserved for you. These descriptions help you determine
        /// which reserve node offering you want to purchase. You then use the unique offering
        /// ID in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your Amazon Redshift cluster. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        public Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedNodeOfferingsAsync(new DescribeReservedNodeOfferingsRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodeOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(DescribeReservedNodeOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedNodeOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedNodeOfferingsRequest,DescribeReservedNodeOfferingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedNodes


        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        public DescribeReservedNodesResponse DescribeReservedNodes()
        {
            return DescribeReservedNodes(new DescribeReservedNodesRequest());
        }


        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        public DescribeReservedNodesResponse DescribeReservedNodes(DescribeReservedNodesRequest request)
        {
            var marshaller = new DescribeReservedNodesRequestMarshaller();
            var unmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedNodesRequest,DescribeReservedNodesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        public Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedNodesAsync(new DescribeReservedNodesRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(DescribeReservedNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedNodesRequestMarshaller();
            var unmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedNodesRequest,DescribeReservedNodesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeResize


        /// <summary>
        /// Returns information about the last resize operation for the specified cluster. If
        /// no resize operation has ever been initiated for the specified cluster, a <code>HTTP
        /// 404</code> error is returned. If a resize operation was initiated and completed, the
        /// status of the resize remains as <code>SUCCEEDED</code> until the next resize. 
        /// 
        ///  
        /// <para>
        ///  A resize operation can be requested using <a>ModifyCluster</a> and specifying a different
        /// number or type of nodes for the cluster. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize service method.</param>
        /// 
        /// <returns>The response from the DescribeResize service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResizeNotFoundException">
        /// A resize operation for the specified cluster is not found.
        /// </exception>
        public DescribeResizeResponse DescribeResize(DescribeResizeRequest request)
        {
            var marshaller = new DescribeResizeRequestMarshaller();
            var unmarshaller = DescribeResizeResponseUnmarshaller.Instance;

            return Invoke<DescribeResizeRequest,DescribeResizeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResize operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeResizeResponse> DescribeResizeAsync(DescribeResizeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeResizeRequestMarshaller();
            var unmarshaller = DescribeResizeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResizeRequest,DescribeResizeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshotCopyGrants


        /// <summary>
        /// Returns a list of snapshot copy grants owned by the AWS account in the destination
        /// region.
        /// 
        ///  
        /// <para>
        ///  For more information about managing snapshot copy grants, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-db-encryption.html">Amazon
        /// Redshift Database Encryption</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotCopyGrants service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotCopyGrants service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        public DescribeSnapshotCopyGrantsResponse DescribeSnapshotCopyGrants(DescribeSnapshotCopyGrantsRequest request)
        {
            var marshaller = new DescribeSnapshotCopyGrantsRequestMarshaller();
            var unmarshaller = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotCopyGrantsRequest,DescribeSnapshotCopyGrantsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotCopyGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotCopyGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeSnapshotCopyGrantsResponse> DescribeSnapshotCopyGrantsAsync(DescribeSnapshotCopyGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotCopyGrantsRequestMarshaller();
            var unmarshaller = DescribeSnapshotCopyGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotCopyGrantsRequest,DescribeSnapshotCopyGrantsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTableRestoreStatus


        /// <summary>
        /// Lists the status of one or more table restore requests made using the <a>RestoreTableFromClusterSnapshot</a>
        /// API action. If you don't specify a value for the <code>TableRestoreRequestId</code>
        /// parameter, then <code>DescribeTableRestoreStatus</code> returns the status of all
        /// in-progress table restore requests. Otherwise <code>DescribeTableRestoreStatus</code>
        /// returns the status of the table specified by <code>TableRestoreRequestId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableRestoreStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeTableRestoreStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TableRestoreNotFoundException">
        /// The specified <code>TableRestoreRequestId</code> value was not found.
        /// </exception>
        public DescribeTableRestoreStatusResponse DescribeTableRestoreStatus(DescribeTableRestoreStatusRequest request)
        {
            var marshaller = new DescribeTableRestoreStatusRequestMarshaller();
            var unmarshaller = DescribeTableRestoreStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeTableRestoreStatusRequest,DescribeTableRestoreStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTableRestoreStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableRestoreStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTableRestoreStatusResponse> DescribeTableRestoreStatusAsync(DescribeTableRestoreStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTableRestoreStatusRequestMarshaller();
            var unmarshaller = DescribeTableRestoreStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTableRestoreStatusRequest,DescribeTableRestoreStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Returns a list of tags. You can return tags from a specific resource by specifying
        /// an ARN, or you can return all tags for a given type of resource, such as clusters,
        /// snapshots, and so on.
        /// 
        ///  
        /// <para>
        ///  The following are limitations for <code>DescribeTags</code>: <ul> <li>You cannot
        /// specify an ARN and a resource-type value together in the same request.</li> <li>You
        /// cannot use the <code>MaxRecords</code> and <code>Marker</code> parameters together
        /// with the ARN parameter.</li> <li>The <code>MaxRecords</code> parameter can be a range
        /// from 10 to 50 results to return in a request.</li> </ul> 
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all resources that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all resources that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, resources are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableLogging


        /// <summary>
        /// Stops logging information, such as queries and connection attempts, for the specified
        /// Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging service method.</param>
        /// 
        /// <returns>The response from the DisableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        public DisableLoggingResponse DisableLogging(DisableLoggingRequest request)
        {
            var marshaller = new DisableLoggingRequestMarshaller();
            var unmarshaller = DisableLoggingResponseUnmarshaller.Instance;

            return Invoke<DisableLoggingRequest,DisableLoggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableLoggingResponse> DisableLoggingAsync(DisableLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableLoggingRequestMarshaller();
            var unmarshaller = DisableLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<DisableLoggingRequest,DisableLoggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableSnapshotCopy


        /// <summary>
        /// Disables the automatic copying of snapshots from one region to another region for
        /// a specified cluster.
        /// 
        ///  
        /// <para>
        /// If your cluster and its snapshots are encrypted using a customer master key (CMK)
        /// from AWS KMS, use <a>DeleteSnapshotCopyGrant</a> to delete the grant that grants Amazon
        /// Redshift permission to the CMK in the destination region. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy service method.</param>
        /// 
        /// <returns>The response from the DisableSnapshotCopy service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyAlreadyDisabledException">
        /// The cluster already has cross-region snapshot copy disabled.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        public DisableSnapshotCopyResponse DisableSnapshotCopy(DisableSnapshotCopyRequest request)
        {
            var marshaller = new DisableSnapshotCopyRequestMarshaller();
            var unmarshaller = DisableSnapshotCopyResponseUnmarshaller.Instance;

            return Invoke<DisableSnapshotCopyRequest,DisableSnapshotCopyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSnapshotCopy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableSnapshotCopyResponse> DisableSnapshotCopyAsync(DisableSnapshotCopyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableSnapshotCopyRequestMarshaller();
            var unmarshaller = DisableSnapshotCopyResponseUnmarshaller.Instance;

            return InvokeAsync<DisableSnapshotCopyRequest,DisableSnapshotCopyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableLogging


        /// <summary>
        /// Starts logging information, such as queries and connection attempts, for the specified
        /// Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging service method.</param>
        /// 
        /// <returns>The response from the EnableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.BucketNotFoundException">
        /// Could not find the specified S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientS3BucketPolicyException">
        /// The cluster does not have read bucket or put object permissions on the S3 bucket
        /// specified when enabling logging.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidS3BucketNameException">
        /// The S3 bucket name is invalid. For more information about naming rules, go to <a href="http://docs.aws.amazon.com/AmazonS3/latest/dev/BucketRestrictions.html">Bucket
        /// Restrictions and Limitations</a> in the Amazon Simple Storage Service (S3) Developer
        /// Guide.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidS3KeyPrefixException">
        /// The string specified for the logging S3 key prefix does not comply with the documented
        /// constraints.
        /// </exception>
        public EnableLoggingResponse EnableLogging(EnableLoggingRequest request)
        {
            var marshaller = new EnableLoggingRequestMarshaller();
            var unmarshaller = EnableLoggingResponseUnmarshaller.Instance;

            return Invoke<EnableLoggingRequest,EnableLoggingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableLoggingResponse> EnableLoggingAsync(EnableLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableLoggingRequestMarshaller();
            var unmarshaller = EnableLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<EnableLoggingRequest,EnableLoggingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableSnapshotCopy


        /// <summary>
        /// Enables the automatic copy of snapshots from one region to another region for a specified
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy service method.</param>
        /// 
        /// <returns>The response from the EnableSnapshotCopy service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.CopyToRegionDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IncompatibleOrderableOptionsException">
        /// The specified options are incompatible.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyAlreadyEnabledException">
        /// The cluster already has cross-region snapshot copy enabled.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnknownSnapshotCopyRegionException">
        /// The specified region is incorrect or does not exist.
        /// </exception>
        public EnableSnapshotCopyResponse EnableSnapshotCopy(EnableSnapshotCopyRequest request)
        {
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var unmarshaller = EnableSnapshotCopyResponseUnmarshaller.Instance;

            return Invoke<EnableSnapshotCopyRequest,EnableSnapshotCopyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSnapshotCopy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableSnapshotCopyResponse> EnableSnapshotCopyAsync(EnableSnapshotCopyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var unmarshaller = EnableSnapshotCopyResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSnapshotCopyRequest,EnableSnapshotCopyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyCluster


        /// <summary>
        /// Modifies the settings for a cluster. For example, you can add another security or
        /// parameter group, update the preferred maintenance window, or change the master user
        /// password. Resetting a cluster password or modifying the security groups associated
        /// with a cluster do not need a reboot. However, modifying a parameter group requires
        /// a reboot for parameters to take effect. For more information about managing clusters,
        /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i> . 
        /// 
        ///  
        /// <para>
        /// You can also change node type and the number of nodes to scale up or down the cluster.
        /// When resizing a cluster, you must specify both the number of nodes and the node type
        /// even if one of the parameters does not change.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOptionException">
        /// A request option was specified that is not supported.
        /// </exception>
        public ModifyClusterResponse ModifyCluster(ModifyClusterRequest request)
        {
            var marshaller = new ModifyClusterRequestMarshaller();
            var unmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterRequest,ModifyClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyClusterResponse> ModifyClusterAsync(ModifyClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyClusterRequestMarshaller();
            var unmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterRequest,ModifyClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyClusterParameterGroup


        /// <summary>
        /// Modifies the parameters of a parameter group. 
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        public ModifyClusterParameterGroupResponse ModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request)
        {
            var marshaller = new ModifyClusterParameterGroupRequestMarshaller();
            var unmarshaller = ModifyClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterParameterGroupRequest,ModifyClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyClusterParameterGroupResponse> ModifyClusterParameterGroupAsync(ModifyClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyClusterParameterGroupRequestMarshaller();
            var unmarshaller = ModifyClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterParameterGroupRequest,ModifyClusterParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyClusterSubnetGroup


        /// <summary>
        /// Modifies a cluster subnet group to include the specified list of VPC subnets. The
        /// operation replaces the existing list of subnets with the new list of subnets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets in a cluster
        /// subnet groups. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubnetAlreadyInUseException">
        /// A specified subnet is already in use by another cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        public ModifyClusterSubnetGroupResponse ModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request)
        {
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterSubnetGroupRequest,ModifyClusterSubnetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyClusterSubnetGroupResponse> ModifyClusterSubnetGroupAsync(ModifyClusterSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyClusterSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterSubnetGroupRequest,ModifyClusterSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyEventSubscription


        /// <summary>
        /// Modifies an existing Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request. This subscription
        /// request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or it
        /// specified a category that does not apply to the specified source type. The allowed
        /// values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or it
        /// specified a severity that does not apply to the specified source type. The allowed
        /// values are ERROR and INFO.
        /// </exception>
        public ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionRequest,ModifyEventSubscriptionResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyEventSubscriptionRequest,ModifyEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifySnapshotCopyRetentionPeriod


        /// <summary>
        /// Modifies the number of days to retain automated snapshots in the destination region
        /// after they are copied from the source region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod service method.</param>
        /// 
        /// <returns>The response from the ModifySnapshotCopyRetentionPeriod service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        public ModifySnapshotCopyRetentionPeriodResponse ModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request)
        {
            var marshaller = new ModifySnapshotCopyRetentionPeriodRequestMarshaller();
            var unmarshaller = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotCopyRetentionPeriodRequest,ModifySnapshotCopyRetentionPeriodResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotCopyRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifySnapshotCopyRetentionPeriodResponse> ModifySnapshotCopyRetentionPeriodAsync(ModifySnapshotCopyRetentionPeriodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifySnapshotCopyRetentionPeriodRequestMarshaller();
            var unmarshaller = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySnapshotCopyRetentionPeriodRequest,ModifySnapshotCopyRetentionPeriodResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedNodeOffering


        /// <summary>
        /// Allows you to purchase reserved nodes. Amazon Redshift offers a predefined set of
        /// reserved node offerings. You can purchase one or more of the offerings. You can call
        /// the <a>DescribeReservedNodeOfferings</a> API to obtain the available reserved node
        /// offerings. You can call this API by providing a specific reserved node offering and
        /// the number of nodes you want to reserve. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedNodeOffering service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeQuotaExceededException">
        /// Request would exceed the user's compute node quota. For information about increasing
        /// your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        public PurchaseReservedNodeOfferingResponse PurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request)
        {
            var marshaller = new PurchaseReservedNodeOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedNodeOfferingRequest,PurchaseReservedNodeOfferingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedNodeOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PurchaseReservedNodeOfferingResponse> PurchaseReservedNodeOfferingAsync(PurchaseReservedNodeOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedNodeOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedNodeOfferingRequest,PurchaseReservedNodeOfferingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebootCluster


        /// <summary>
        /// Reboots a cluster. This action is taken as soon as possible. It results in a momentary
        /// outage to the cluster, during which the cluster status is set to <code>rebooting</code>.
        /// A cluster event is created when the reboot is completed. Any pending cluster modifications
        /// (see <a>ModifyCluster</a>) are applied at this reboot. For more information about
        /// managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster service method.</param>
        /// 
        /// <returns>The response from the RebootCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        public RebootClusterResponse RebootCluster(RebootClusterRequest request)
        {
            var marshaller = new RebootClusterRequestMarshaller();
            var unmarshaller = RebootClusterResponseUnmarshaller.Instance;

            return Invoke<RebootClusterRequest,RebootClusterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RebootClusterResponse> RebootClusterAsync(RebootClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootClusterRequestMarshaller();
            var unmarshaller = RebootClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RebootClusterRequest,RebootClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetClusterParameterGroup


        /// <summary>
        /// Sets one or more parameters of the specified parameter group to their default values
        /// and sets the source values of the parameters to "engine-default". To reset the entire
        /// parameter group specify the <i>ResetAllParameters</i> parameter. For parameter changes
        /// to take effect you must reboot any associated clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        public ResetClusterParameterGroupResponse ResetClusterParameterGroup(ResetClusterParameterGroupRequest request)
        {
            var marshaller = new ResetClusterParameterGroupRequestMarshaller();
            var unmarshaller = ResetClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetClusterParameterGroupRequest,ResetClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ResetClusterParameterGroupResponse> ResetClusterParameterGroupAsync(ResetClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetClusterParameterGroupRequestMarshaller();
            var unmarshaller = ResetClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetClusterParameterGroupRequest,ResetClusterParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreFromClusterSnapshot


        /// <summary>
        /// Creates a new cluster from a snapshot. By default, Amazon Redshift creates the resulting
        /// cluster with the same configuration as the original cluster from which the snapshot
        /// was created, except that the new cluster is created with the default cluster security
        /// and parameter groups. After Amazon Redshift creates the cluster, you can use the <a>ModifyCluster</a>
        /// API to associate a different security group and different parameter group with the
        /// restored cluster. If you are using a DS node type, you can also choose to change to
        /// another DS node type of the same size during restore.
        /// 
        ///  
        /// <para>
        ///  If you restore a cluster into a VPC, you must provide a cluster subnet group where
        /// you want the cluster restored. 
        /// </para>
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreFromClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this account.
        /// For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRestoreException">
        /// The restore is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        public RestoreFromClusterSnapshotResponse RestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request)
        {
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var unmarshaller = RestoreFromClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreFromClusterSnapshotRequest,RestoreFromClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RestoreFromClusterSnapshotResponse> RestoreFromClusterSnapshotAsync(RestoreFromClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var unmarshaller = RestoreFromClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreFromClusterSnapshotRequest,RestoreFromClusterSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreTableFromClusterSnapshot


        /// <summary>
        /// Creates a new table from a table in an Amazon Redshift cluster snapshot. You must
        /// create the new table within the Amazon Redshift cluster that the snapshot was taken
        /// from.
        /// 
        ///  
        /// <para>
        /// You cannot use <code>RestoreTableFromClusterSnapshot</code> to restore a table with
        /// the same name as an existing table in an Amazon Redshift cluster. That is, you cannot
        /// overwrite an existing table in a cluster with a restored table. If you want to replace
        /// your original table with a new, restored table, then rename or drop your original
        /// table before you call <code>RestoreTableFromClusterSnapshot</code>. When you have
        /// renamed your original table, then you can pass the original name of the table as the
        /// <code>NewTableName</code> parameter value in the call to <code>RestoreTableFromClusterSnapshot</code>.
        /// This way, you can replace the original table with the table created from the snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreTableFromClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InProgressTableRestoreQuotaExceededException">
        /// You have exceeded the allowed number of table restore requests. Wait for your current
        /// table restore requests to complete before making a new request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTableRestoreArgumentException">
        /// The value specified for the <code>sourceDatabaseName</code>, <code>sourceSchemaName</code>,
        /// or <code>sourceTableName</code> parameter, or a combination of these, doesn't exist
        /// in the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        public RestoreTableFromClusterSnapshotResponse RestoreTableFromClusterSnapshot(RestoreTableFromClusterSnapshotRequest request)
        {
            var marshaller = new RestoreTableFromClusterSnapshotRequestMarshaller();
            var unmarshaller = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreTableFromClusterSnapshotRequest,RestoreTableFromClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreTableFromClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RestoreTableFromClusterSnapshotResponse> RestoreTableFromClusterSnapshotAsync(RestoreTableFromClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreTableFromClusterSnapshotRequestMarshaller();
            var unmarshaller = RestoreTableFromClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreTableFromClusterSnapshotRequest,RestoreTableFromClusterSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeClusterSecurityGroupIngress


        /// <summary>
        /// Revokes an ingress rule in an Amazon Redshift security group for a previously authorized
        /// IP range or Amazon EC2 security group. To add an ingress rule, see <a>AuthorizeClusterSecurityGroupIngress</a>.
        /// For information about managing security groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the RevokeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        public RevokeClusterSecurityGroupIngressResponse RevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request)
        {
            var marshaller = new RevokeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeClusterSecurityGroupIngressRequest,RevokeClusterSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeClusterSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RevokeClusterSecurityGroupIngressResponse> RevokeClusterSecurityGroupIngressAsync(RevokeClusterSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeClusterSecurityGroupIngressRequest,RevokeClusterSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeSnapshotAccess


        /// <summary>
        /// Removes the ability of the specified AWS customer account to restore the specified
        /// snapshot. If the account is currently restoring the snapshot, the restore will run
        /// to completion. 
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess service method.</param>
        /// 
        /// <returns>The response from the RevokeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        public RevokeSnapshotAccessResponse RevokeSnapshotAccess(RevokeSnapshotAccessRequest request)
        {
            var marshaller = new RevokeSnapshotAccessRequestMarshaller();
            var unmarshaller = RevokeSnapshotAccessResponseUnmarshaller.Instance;

            return Invoke<RevokeSnapshotAccessRequest,RevokeSnapshotAccessResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSnapshotAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RevokeSnapshotAccessResponse> RevokeSnapshotAccessAsync(RevokeSnapshotAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeSnapshotAccessRequestMarshaller();
            var unmarshaller = RevokeSnapshotAccessResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSnapshotAccessRequest,RevokeSnapshotAccessResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RotateEncryptionKey


        /// <summary>
        /// Rotates the encryption keys for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the RotateEncryptionKey service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        public RotateEncryptionKeyResponse RotateEncryptionKey(RotateEncryptionKeyRequest request)
        {
            var marshaller = new RotateEncryptionKeyRequestMarshaller();
            var unmarshaller = RotateEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke<RotateEncryptionKeyRequest,RotateEncryptionKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RotateEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RotateEncryptionKeyResponse> RotateEncryptionKeyAsync(RotateEncryptionKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RotateEncryptionKeyRequestMarshaller();
            var unmarshaller = RotateEncryptionKeyResponseUnmarshaller.Instance;

            return InvokeAsync<RotateEncryptionKeyRequest,RotateEncryptionKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}