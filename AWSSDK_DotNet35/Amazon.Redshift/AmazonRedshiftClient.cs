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


using System;
using System.Threading;

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
    /// Amazon Redshift        <b>Overview</b>        
    /// <para>
    ///             This is an interface reference for Amazon Redshift. It contains documentation
    /// for one of the            programming or command line interfaces you can use to manage
    /// Amazon Redshift clusters. Note            that Amazon Redshift is asynchronous, which
    /// means that some interfaces may require techniques,            such as polling or asynchronous
    /// callback handlers, to determine when a command has been            applied. In this
    /// reference, the parameter descriptions indicate whether a change is            applied
    /// immediately, on the next instance reboot, or during the next maintenance         
    ///   window. For a summary of the Amazon Redshift cluster management interfaces, go to
    /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/using-aws-sdk.html">Using
    /// the Amazon Redshift Management Interfaces            </a>.
    /// </para>
    ///         
    /// <para>
    ///             Amazon Redshift manages all the work of setting up, operating, and scaling
    /// a data warehouse:             provisioning capacity, monitoring and backing up the
    /// cluster, and applying patches and             upgrades to the Amazon Redshift engine.
    /// You can focus on using your data to acquire new             insights for your business
    /// and customers.        
    /// </para>
    ///         
    /// <para>
    /// If you are a first-time user of Amazon Redshift, we recommend that you begin by reading
    /// the            The <a href="http://docs.aws.amazon.com/redshift/latest/gsg/getting-started.html">Amazon
    /// Redshift Getting Started Guide</a>
    /// </para>
    ///         
    /// <para>
    /// If you are a database developer, the <a href="http://docs.aws.amazon.com/redshift/latest/dg/welcome.html">Amazon
    /// Redshift Database Developer Guide</a>            explains how to design, build, query,
    /// and maintain the databases that make up your            data warehouse. 
    /// </para>
    /// </summary>
    public partial class AmazonRedshiftClient : AmazonWebServiceClient, IAmazonRedshift
    {
        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

        
        #region  AuthorizeClusterSecurityGroupIngress


        /// <summary>
        /// Adds an inbound (ingress) rule to an Amazon Redshift security group. 
        ///                       Depending on whether the application accessing your cluster
        /// is running            on the Internet or an EC2 instance, you can            authorize
        /// inbound access to either a Classless Interdomain Routing (CIDR) IP address range 
        ///          or an EC2 security group.               You can add as many as 20 ingress
        /// rules to an Amazon Redshift security group.         
        /// 
        ///         <note>            The EC2 security group must be defined in the AWS region
        /// where the cluster resides.        </note>        
        /// <para>
        /// For an overview of CIDR blocks, see the Wikipedia article on               <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>.        
        /// </para>
        ///         
        /// <para>
        ///             You must also associate the security group with a cluster so that clients
        ///             running on these IP addresses or the EC2 instance are authorized to connect
        /// to the cluster.            For information about managing security groups, go to 
        ///           <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Working
        /// with Security Groups</a> in the             <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for
        /// the specified cluster security group.
        /// </exception>
        /// <exception cref="AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        /// <exception cref="InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        public AuthorizeClusterSecurityGroupIngressResponse AuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request)
        {
            IAsyncResult asyncResult = invokeAuthorizeClusterSecurityGroupIngress(request, null, null, true);
            return EndAuthorizeClusterSecurityGroupIngress(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeClusterSecurityGroupIngress
        ///         operation.</returns>
        public IAsyncResult BeginAuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request, AsyncCallback callback, object state)
        {
            return invokeAuthorizeClusterSecurityGroupIngress(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeClusterSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  AuthorizeClusterSecurityGroupIngressResult from Redshift.</returns>
        public  AuthorizeClusterSecurityGroupIngressResponse EndAuthorizeClusterSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return endOperation< AuthorizeClusterSecurityGroupIngressResponse>(asyncResult);
        }

        IAsyncResult invokeAuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new AuthorizeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  AuthorizeSnapshotAccess


        /// <summary>
        /// Authorizes the specified AWS customer account to restore the specified
        /// snapshot.        
        /// 
        ///         
        /// <para>
        /// For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess service method.</param>
        /// 
        /// <returns>The response from the AuthorizeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for
        /// the specified cluster security group.
        /// </exception>
        /// <exception cref="AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        public AuthorizeSnapshotAccessResponse AuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request)
        {
            IAsyncResult asyncResult = invokeAuthorizeSnapshotAccess(request, null, null, true);
            return EndAuthorizeSnapshotAccess(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeSnapshotAccess
        ///         operation.</returns>
        public IAsyncResult BeginAuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request, AsyncCallback callback, object state)
        {
            return invokeAuthorizeSnapshotAccess(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSnapshotAccess.</param>
        /// 
        /// <returns>Returns a  AuthorizeSnapshotAccessResult from Redshift.</returns>
        public  AuthorizeSnapshotAccessResponse EndAuthorizeSnapshotAccess(IAsyncResult asyncResult)
        {
            return endOperation< AuthorizeSnapshotAccessResponse>(asyncResult);
        }

        IAsyncResult invokeAuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new AuthorizeSnapshotAccessRequestMarshaller();
            var unmarshaller = AuthorizeSnapshotAccessResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CopyClusterSnapshot


        /// <summary>
        /// Copies the specified automated cluster snapshot to a new manual cluster snapshot.
        ///         The source must be an automated snapshot and it must be in the available state.
        ///        
        /// 
        ///         
        /// <para>
        ///             When you delete a cluster, Amazon Redshift deletes any automated snapshots
        ///             of the cluster. Also, when the retention period of the snapshot expires,
        ///            Amazon Redshift automatically deletes it. If you want to keep an      
        ///       automated snapshot for a longer period, you can make a manual            copy
        /// of the snapshot. Manual snapshots are retained until you delete them.         
        /// </para>
        ///         
        /// <para>
        /// For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing
        /// snapshot.
        /// </exception>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster
        /// snapshots.
        /// </exception>
        /// <exception cref="InvalidClusterSnapshotStateException">
        /// The state of the cluster snapshot is not <code>available</code>, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        public CopyClusterSnapshotResponse CopyClusterSnapshot(CopyClusterSnapshotRequest request)
        {
            IAsyncResult asyncResult = invokeCopyClusterSnapshot(request, null, null, true);
            return EndCopyClusterSnapshot(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyClusterSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCopyClusterSnapshot(CopyClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            return invokeCopyClusterSnapshot(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CopyClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  CopyClusterSnapshotResult from Redshift.</returns>
        public  CopyClusterSnapshotResponse EndCopyClusterSnapshot(IAsyncResult asyncResult)
        {
            return endOperation< CopyClusterSnapshotResponse>(asyncResult);
        }

        IAsyncResult invokeCopyClusterSnapshot(CopyClusterSnapshotRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CopyClusterSnapshotRequestMarshaller();
            var unmarshaller = CopyClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateCluster


        /// <summary>
        /// Creates a new cluster. To create the cluster in virtual private cloud
        /// (VPC), you must provide cluster subnet group name. If             you don't provide
        /// a cluster subnet group name or the cluster security group parameter, Amazon Redshift
        ///             creates a non-VPC cluster, it associates the default cluster security
        /// group with the cluster.            For more information about managing clusters, go
        /// to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        /// <exception cref="ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this
        /// account. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        /// <exception cref="ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet
        /// group.
        /// </exception>
        /// <exception cref="HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same
        /// VPC.
        /// </exception>
        /// <exception cref="InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        public CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            IAsyncResult asyncResult = invokeCreateCluster(request, null, null, true);
            return EndCreateCluster(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        public IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateCluster(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from Redshift.</returns>
        public  CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult)
        {
            return endOperation< CreateClusterResponse>(asyncResult);
        }

        IAsyncResult invokeCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateClusterRequestMarshaller();
            var unmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateClusterParameterGroup


        /// <summary>
        /// Creates an Amazon Redshift parameter group. 
        /// 
        ///             
        /// <para>
        /// Creating parameter groups is independent of creating clusters.                   
        /// You can associate a cluster with a parameter group             when you create the
        /// cluster. You can also associate an existing cluster            with a parameter group
        /// after the cluster is created by using <a>ModifyCluster</a>.        
        /// </para>
        ///         
        /// <para>
        ///                      Parameters in the parameter group define specific behavior that
        /// applies to the          databases you create on the cluster.          For more information
        /// about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.    
        ///    
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupAlreadyExistsException">
        /// A cluster parameter group with the same name already exists.
        /// </exception>
        /// <exception cref="ClusterParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed        number of
        /// cluster parameter groups. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        public CreateClusterParameterGroupResponse CreateClusterParameterGroup(CreateClusterParameterGroupRequest request)
        {
            IAsyncResult asyncResult = invokeCreateClusterParameterGroup(request, null, null, true);
            return EndCreateClusterParameterGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterParameterGroup
        ///         operation.</returns>
        public IAsyncResult BeginCreateClusterParameterGroup(CreateClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateClusterParameterGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  CreateClusterParameterGroupResult from Redshift.</returns>
        public  CreateClusterParameterGroupResponse EndCreateClusterParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation< CreateClusterParameterGroupResponse>(asyncResult);
        }

        IAsyncResult invokeCreateClusterParameterGroup(CreateClusterParameterGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateClusterParameterGroupRequestMarshaller();
            var unmarshaller = CreateClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateClusterSecurityGroup


        /// <summary>
        /// Creates a new Amazon Redshift security group. You use security       
        ///      groups to control access to non-VPC clusters.         
        /// 
        ///         
        /// <para>
        ///             For information about managing security groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        ///        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSecurityGroupAlreadyExistsException">
        /// A cluster security group with the same name already exists.
        /// </exception>
        /// <exception cref="ClusterSecurityGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster
        /// security groups. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        public CreateClusterSecurityGroupResponse CreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request)
        {
            IAsyncResult asyncResult = invokeCreateClusterSecurityGroup(request, null, null, true);
            return EndCreateClusterSecurityGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterSecurityGroup
        ///         operation.</returns>
        public IAsyncResult BeginCreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateClusterSecurityGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSecurityGroup.</param>
        /// 
        /// <returns>Returns a  CreateClusterSecurityGroupResult from Redshift.</returns>
        public  CreateClusterSecurityGroupResponse EndCreateClusterSecurityGroup(IAsyncResult asyncResult)
        {
            return endOperation< CreateClusterSecurityGroupResponse>(asyncResult);
        }

        IAsyncResult invokeCreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateClusterSecurityGroupRequestMarshaller();
            var unmarshaller = CreateClusterSecurityGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateClusterSnapshot


        /// <summary>
        /// Creates a manual snapshot of the specified cluster.         The cluster must
        /// be in the <code>available</code> state.        
        /// 
        ///         
        /// <para>
        /// For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing
        /// snapshot.
        /// </exception>
        /// <exception cref="ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster
        /// snapshots.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        public CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest request)
        {
            IAsyncResult asyncResult = invokeCreateClusterSnapshot(request, null, null, true);
            return EndCreateClusterSnapshot(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCreateClusterSnapshot(CreateClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateClusterSnapshot(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateClusterSnapshotResult from Redshift.</returns>
        public  CreateClusterSnapshotResponse EndCreateClusterSnapshot(IAsyncResult asyncResult)
        {
            return endOperation< CreateClusterSnapshotResponse>(asyncResult);
        }

        IAsyncResult invokeCreateClusterSnapshot(CreateClusterSnapshotRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateClusterSnapshotRequestMarshaller();
            var unmarshaller = CreateClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateClusterSubnetGroup


        /// <summary>
        /// Creates a new Amazon Redshift subnet group. You must provide a list of
        /// one or more subnets in             your existing Amazon Virtual Private Cloud (Amazon
        /// VPC) when creating Amazon Redshift subnet group.                   
        /// 
        ///         
        /// <para>
        ///  For information about subnet groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-cluster-subnet-groups.html">Amazon
        /// Redshift Cluster Subnet Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        ///        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSubnetGroupAlreadyExistsException">
        /// A <i>ClusterSubnetGroupName</i> is already used by an existing cluster subnet
        /// group.
        /// </exception>
        /// <exception cref="ClusterSubnetGroupQuotaExceededException">
        /// The request would result in user exceeding the allowed number of cluster
        /// subnet groups. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets
        /// in a cluster subnet groups. For information about increasing your quota, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same
        /// VPC.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        public CreateClusterSubnetGroupResponse CreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request)
        {
            IAsyncResult asyncResult = invokeCreateClusterSubnetGroup(request, null, null, true);
            return EndCreateClusterSubnetGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateClusterSubnetGroup
        ///         operation.</returns>
        public IAsyncResult BeginCreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateClusterSubnetGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateClusterSubnetGroup.</param>
        /// 
        /// <returns>Returns a  CreateClusterSubnetGroupResult from Redshift.</returns>
        public  CreateClusterSubnetGroupResponse EndCreateClusterSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation< CreateClusterSubnetGroupResponse>(asyncResult);
        }

        IAsyncResult invokeCreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateClusterSubnetGroupRequestMarshaller();
            var unmarshaller = CreateClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateEventSubscription


        /// <summary>
        /// Creates an Amazon Redshift event notification subscription. This action
        /// requires an ARN (Amazon Resource Name) of            an Amazon SNS topic created by
        /// either the Amazon Redshift console, the Amazon SNS console, or the             Amazon
        /// SNS API. To obtain an ARN with Amazon SNS, you must create a topic in Amazon SNS and
        /// subscribe to the topic.            The ARN is displayed in the SNS console.      
        ///  
        /// 
        ///         
        /// <para>
        ///             You can specify the source type, and lists of Amazon Redshift source IDs,
        /// event categories, and event severities.            Notifications will be sent for
        /// all events you want that match those criteria. For example, you can specify      
        ///      source type = cluster, source ID = my-cluster-1 and mycluster2, event categories
        /// = Availability, Backup, and            severity = ERROR. The subscription will only
        /// send notifications for those ERROR events in the Availability and            Backup
        /// categories for the specified clusters.        
        /// </para>
        ///         
        /// <para>
        ///             If you specify both the source type and source IDs, such as source type
        /// = cluster and source identifier =             my-cluster-1, notifications will be
        /// sent for all the cluster events for my-cluster-1. If you specify a source type   
        ///         but do not specify a source identifier, you will receive notice of the events
        /// for the objects of that type in your            AWS account. If you do not specify
        /// either the SourceType nor the SourceIdentifier, you will be notified of events   
        ///         generated from all Amazon Redshift sources belonging to your AWS account.
        /// You must specify a source type if you            specify a source ID.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="EventSubscriptionQuotaExceededException">
        /// The request would exceed the allowed number of event subscriptions for
        /// this account. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="SubscriptionAlreadyExistException">
        /// There is already an existing event notification subscription with the specified name.
        /// </exception>
        /// <exception cref="SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or 
        ///           it specified a category that does not apply to the specified source type.
        /// The allowed            values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or 
        ///           it specified a severity that does not apply to the specified source type.
        /// The allowed            values are ERROR and INFO.
        /// </exception>
        public CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            IAsyncResult asyncResult = invokeCreateEventSubscription(request, null, null, true);
            return EndCreateEventSubscription(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventSubscription
        ///         operation.</returns>
        public IAsyncResult BeginCreateEventSubscription(CreateEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateEventSubscription(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventSubscription.</param>
        /// 
        /// <returns>Returns a  CreateEventSubscriptionResult from Redshift.</returns>
        public  CreateEventSubscriptionResponse EndCreateEventSubscription(IAsyncResult asyncResult)
        {
            return endOperation< CreateEventSubscriptionResponse>(asyncResult);
        }

        IAsyncResult invokeCreateEventSubscription(CreateEventSubscriptionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateEventSubscriptionRequestMarshaller();
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateHsmClientCertificate


        /// <summary>
        /// Creates an HSM client certificate that an Amazon Redshift cluster will use to connect
        /// to the client's HSM            in order to store and retrieve the keys used to encrypt
        /// the cluster databases.
        /// 
        ///         
        /// <para>
        /// The command returns a public key, which you must store in the HSM. In addition to
        /// creating the HSM certificate,            you must create an Amazon Redshift HSM configuration
        /// that provides a cluster the information needed to            store and use encryption
        /// keys in the HSM. For more information, go to            <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware
        /// Security Modules</a> in the Amazon Redshift Management Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate service method.</param>
        /// 
        /// <returns>The response from the CreateHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="HsmClientCertificateAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM client certificate with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="HsmClientCertificateQuotaExceededException">
        /// The quota for HSM client certificates has been reached. For information
        /// about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        public CreateHsmClientCertificateResponse CreateHsmClientCertificate(CreateHsmClientCertificateRequest request)
        {
            IAsyncResult asyncResult = invokeCreateHsmClientCertificate(request, null, null, true);
            return EndCreateHsmClientCertificate(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHsmClientCertificate
        ///         operation.</returns>
        public IAsyncResult BeginCreateHsmClientCertificate(CreateHsmClientCertificateRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateHsmClientCertificate(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHsmClientCertificate.</param>
        /// 
        /// <returns>Returns a  CreateHsmClientCertificateResult from Redshift.</returns>
        public  CreateHsmClientCertificateResponse EndCreateHsmClientCertificate(IAsyncResult asyncResult)
        {
            return endOperation< CreateHsmClientCertificateResponse>(asyncResult);
        }

        IAsyncResult invokeCreateHsmClientCertificate(CreateHsmClientCertificateRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateHsmClientCertificateRequestMarshaller();
            var unmarshaller = CreateHsmClientCertificateResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  CreateHsmConfiguration


        /// <summary>
        /// Creates an HSM configuration that contains the information required by an Amazon Redshift
        /// cluster            to store and use database encryption keys in a Hardware Security
        /// Module (HSM). After            creating the HSM configuration, you can specify it
        /// as a parameter when creating a cluster.            The cluster will then store its
        /// encryption keys in the HSM.
        /// 
        ///         
        /// <para>
        /// In addition to creating an HSM configuration, you must also create an HSM client certificate.
        ///            For more information, go to            <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware
        /// Security Modules</a> in the Amazon Redshift Management Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="HsmConfigurationAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM configuration with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="HsmConfigurationQuotaExceededException">
        /// The quota for HSM configurations has been reached. For information about
        /// increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        public CreateHsmConfigurationResponse CreateHsmConfiguration(CreateHsmConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokeCreateHsmConfiguration(request, null, null, true);
            return EndCreateHsmConfiguration(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHsmConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginCreateHsmConfiguration(CreateHsmConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateHsmConfiguration(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHsmConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateHsmConfigurationResult from Redshift.</returns>
        public  CreateHsmConfigurationResponse EndCreateHsmConfiguration(IAsyncResult asyncResult)
        {
            return endOperation< CreateHsmConfigurationResponse>(asyncResult);
        }

        IAsyncResult invokeCreateHsmConfiguration(CreateHsmConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new CreateHsmConfigurationRequestMarshaller();
            var unmarshaller = CreateHsmConfigurationResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes a previously provisioned cluster. A successful response      
        ///      from the web service indicates that the request was received correctly. If a
        /// final cluster snapshot is requested            the status of the cluster will be "final-snapshot"
        /// while the snapshot is being taken, then it's "deleting" once Amazon Redshift begins
        /// deleting the cluster. Use <a>DescribeClusters</a>             to monitor the status
        /// of the deletion. The delete operation cannot be canceled or reverted once submitted.
        ///             For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing
        /// snapshot.
        /// </exception>
        /// <exception cref="ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster
        /// snapshots.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteCluster(request, null, null, true);
            return EndDeleteCluster(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        public IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteCluster(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from Redshift.</returns>
        public  DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult)
        {
            return endOperation< DeleteClusterResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteClusterRequestMarshaller();
            var unmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteClusterParameterGroup


        /// <summary>
        /// Deletes a specified Amazon Redshift parameter group.             <note>You
        /// cannot delete a parameter group if it is associated with a cluster.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        /// <exception cref="InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because         another
        /// task is in progress that involves the parameter group.         Wait a few moments
        /// and try the operation again.
        /// </exception>
        public DeleteClusterParameterGroupResponse DeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteClusterParameterGroup(request, null, null, true);
            return EndDeleteClusterParameterGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterParameterGroup
        ///         operation.</returns>
        public IAsyncResult BeginDeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteClusterParameterGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  DeleteClusterParameterGroupResult from Redshift.</returns>
        public  DeleteClusterParameterGroupResponse EndDeleteClusterParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation< DeleteClusterParameterGroupResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteClusterParameterGroupRequestMarshaller();
            var unmarshaller = DeleteClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteClusterSecurityGroup


        /// <summary>
        /// Deletes an Amazon Redshift security group.         
        /// 
        ///         <note>You cannot delete a security group that is associated with any clusters.
        /// You cannot        delete the default security group.</note>        
        /// <para>
        /// For information about managing security groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        /// <exception cref="InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        public DeleteClusterSecurityGroupResponse DeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteClusterSecurityGroup(request, null, null, true);
            return EndDeleteClusterSecurityGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterSecurityGroup
        ///         operation.</returns>
        public IAsyncResult BeginDeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteClusterSecurityGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterSecurityGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DeleteClusterSecurityGroupResult from Redshift.</returns>
        public  DeleteClusterSecurityGroupResponse EndDeleteClusterSecurityGroup(IAsyncResult asyncResult)
        {
            return endOperation< DeleteClusterSecurityGroupResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteClusterSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSecurityGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteClusterSnapshot


        /// <summary>
        /// Deletes the specified manual snapshot. The snapshot must be in the <code>available</code>
        /// state, with no other users authorized to access the snapshot.         
        /// 
        ///         
        /// <para>
        ///             Unlike automated snapshots, manual snapshots are retained even after you
        ///             delete your cluster.                       Amazon Redshift does not delete
        /// your manual snapshots. You must delete manual snapshot             explicitly to avoid
        /// getting charged.            If other accounts are authorized to access the snapshot,
        /// you must revoke all of the authorizations before you can delete the snapshot.    
        ///    
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="InvalidClusterSnapshotStateException">
        /// The state of the cluster snapshot is not <code>available</code>, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        public DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteClusterSnapshot(request, null, null, true);
            return EndDeleteClusterSnapshot(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginDeleteClusterSnapshot(DeleteClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteClusterSnapshot(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteClusterSnapshotResult from Redshift.</returns>
        public  DeleteClusterSnapshotResponse EndDeleteClusterSnapshot(IAsyncResult asyncResult)
        {
            return endOperation< DeleteClusterSnapshotResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteClusterSnapshot(DeleteClusterSnapshotRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteClusterSnapshotRequestMarshaller();
            var unmarshaller = DeleteClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteClusterSubnetGroup


        /// <summary>
        /// Deletes the specified cluster subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet
        /// group.
        /// </exception>
        /// <exception cref="InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="InvalidClusterSubnetStateException">
        /// The state of the subnet is invalid.
        /// </exception>
        public DeleteClusterSubnetGroupResponse DeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteClusterSubnetGroup(request, null, null, true);
            return EndDeleteClusterSubnetGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClusterSubnetGroup
        ///         operation.</returns>
        public IAsyncResult BeginDeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteClusterSubnetGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClusterSubnetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteClusterSubnetGroupResult from Redshift.</returns>
        public  DeleteClusterSubnetGroupResponse EndDeleteClusterSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation< DeleteClusterSubnetGroupResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteClusterSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteEventSubscription


        /// <summary>
        /// Deletes an Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request.
        /// This subscription request is already in progress.
        /// </exception>
        /// <exception cref="SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        public DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteEventSubscription(request, null, null, true);
            return EndDeleteEventSubscription(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventSubscription
        ///         operation.</returns>
        public IAsyncResult BeginDeleteEventSubscription(DeleteEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteEventSubscription(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteEventSubscriptionResult from Redshift.</returns>
        public  DeleteEventSubscriptionResponse EndDeleteEventSubscription(IAsyncResult asyncResult)
        {
            return endOperation< DeleteEventSubscriptionResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteEventSubscription(DeleteEventSubscriptionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteEventSubscriptionRequestMarshaller();
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteHsmClientCertificate


        /// <summary>
        /// Deletes the specified HSM client certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="InvalidHsmClientCertificateStateException">
        /// The specified HSM client certificate is not in the <code>available</code> state, or
        /// it is still in            use by one or more Amazon Redshift clusters.
        /// </exception>
        public DeleteHsmClientCertificateResponse DeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteHsmClientCertificate(request, null, null, true);
            return EndDeleteHsmClientCertificate(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHsmClientCertificate
        ///         operation.</returns>
        public IAsyncResult BeginDeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteHsmClientCertificate(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHsmClientCertificate operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHsmClientCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteHsmClientCertificateResult from Redshift.</returns>
        public  DeleteHsmClientCertificateResponse EndDeleteHsmClientCertificate(IAsyncResult asyncResult)
        {
            return endOperation< DeleteHsmClientCertificateResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteHsmClientCertificateRequestMarshaller();
            var unmarshaller = DeleteHsmClientCertificateResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DeleteHsmConfiguration


        /// <summary>
        /// Deletes the specified Amazon Redshift HSM configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="InvalidHsmConfigurationStateException">
        /// The specified HSM configuration is not in the <code>available</code> state, or it
        /// is still in            use by one or more Amazon Redshift clusters.
        /// </exception>
        public DeleteHsmConfigurationResponse DeleteHsmConfiguration(DeleteHsmConfigurationRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteHsmConfiguration(request, null, null, true);
            return EndDeleteHsmConfiguration(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHsmConfiguration
        ///         operation.</returns>
        public IAsyncResult BeginDeleteHsmConfiguration(DeleteHsmConfigurationRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteHsmConfiguration(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHsmConfiguration operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHsmConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteHsmConfigurationResult from Redshift.</returns>
        public  DeleteHsmConfigurationResponse EndDeleteHsmConfiguration(IAsyncResult asyncResult)
        {
            return endOperation< DeleteHsmConfigurationResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteHsmConfiguration(DeleteHsmConfigurationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DeleteHsmConfigurationRequestMarshaller();
            var unmarshaller = DeleteHsmConfigurationResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeClusterParameterGroups

        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter
        ///             groups you created and the default parameter             group. For each
        /// parameter group, the response             includes the parameter group name, description,
        /// and parameter group family name.             You can optionally specify a name   
        ///          to retrieve the description of             a specific parameter group.  
        ///                  
        /// 
        ///         
        /// <para>
        /// For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        public DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups()
        {
            return DescribeClusterParameterGroups(new DescribeClusterParameterGroupsRequest());
        }

        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter
        ///             groups you created and the default parameter             group. For each
        /// parameter group, the response             includes the parameter group name, description,
        /// and parameter group family name.             You can optionally specify a name   
        ///          to retrieve the description of             a specific parameter group.  
        ///                  
        /// 
        ///         
        /// <para>
        /// For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        public DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeClusterParameterGroups(request, null, null, true);
            return EndDescribeClusterParameterGroups(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameterGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterParameterGroups
        ///         operation.</returns>
        public IAsyncResult BeginDescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeClusterParameterGroups(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterParameterGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterParameterGroups.</param>
        /// 
        /// <returns>Returns a  DescribeClusterParameterGroupsResult from Redshift.</returns>
        public  DescribeClusterParameterGroupsResponse EndDescribeClusterParameterGroups(IAsyncResult asyncResult)
        {
            return endOperation< DescribeClusterParameterGroupsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeClusterParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterParameterGroupsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeClusterParameters


        /// <summary>
        /// Returns a detailed list of parameters contained within the specified Amazon
        /// Redshift         parameter group. For each parameter the response includes information
        ///         such as parameter name, description,         data type, value, whether the
        /// parameter value is modifiable, and so on.        
        /// 
        ///         
        /// <para>
        /// You can specify <i>source</i> filter to retrieve parameters of only specific type.
        ///            For example, to retrieve parameters that were modified by a user action
        /// such as from             <a>ModifyClusterParameterGroup</a>, you can specify <i>source</i>
        /// equal to <i>user</i>.
        /// </para>
        ///         
        /// <para>
        /// For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameters service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        public DescribeClusterParametersResponse DescribeClusterParameters(DescribeClusterParametersRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeClusterParameters(request, null, null, true);
            return EndDescribeClusterParameters(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterParameters
        ///         operation.</returns>
        public IAsyncResult BeginDescribeClusterParameters(DescribeClusterParametersRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeClusterParameters(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterParameters.</param>
        /// 
        /// <returns>Returns a  DescribeClusterParametersResult from Redshift.</returns>
        public  DescribeClusterParametersResponse EndDescribeClusterParameters(IAsyncResult asyncResult)
        {
            return endOperation< DescribeClusterParametersResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeClusterParameters(DescribeClusterParametersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeClusterParametersRequestMarshaller();
            var unmarshaller = DescribeClusterParametersResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeClusters

        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties,
        /// cluster database properties,            maintenance and backup properties, and security
        /// and access properties. This operation supports pagination.             For more information
        /// about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        public DescribeClustersResponse DescribeClusters()
        {
            return DescribeClusters(new DescribeClustersRequest());
        }

        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties,
        /// cluster database properties,            maintenance and backup properties, and security
        /// and access properties. This operation supports pagination.             For more information
        /// about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        public DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeClusters(request, null, null, true);
            return EndDescribeClusters(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusters
        ///         operation.</returns>
        public IAsyncResult BeginDescribeClusters(DescribeClustersRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeClusters(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusters.</param>
        /// 
        /// <returns>Returns a  DescribeClustersResult from Redshift.</returns>
        public  DescribeClustersResponse EndDescribeClusters(IAsyncResult asyncResult)
        {
            return endOperation< DescribeClustersResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeClusters(DescribeClustersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeClustersRequestMarshaller();
            var unmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeClusterSecurityGroups

        /// <summary>
        /// Returns information about Amazon Redshift security groups.           
        ///  If the name of a security group is specified,             the response will contain
        /// only information about only that security group.         
        /// 
        ///         
        /// <para>
        /// For information about managing security groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        public DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups()
        {
            return DescribeClusterSecurityGroups(new DescribeClusterSecurityGroupsRequest());
        }

        /// <summary>
        /// Returns information about Amazon Redshift security groups.           
        ///  If the name of a security group is specified,             the response will contain
        /// only information about only that security group.         
        /// 
        ///         
        /// <para>
        /// For information about managing security groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        public DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeClusterSecurityGroups(request, null, null, true);
            return EndDescribeClusterSecurityGroups(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSecurityGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterSecurityGroups
        ///         operation.</returns>
        public IAsyncResult BeginDescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeClusterSecurityGroups(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterSecurityGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterSecurityGroups.</param>
        /// 
        /// <returns>Returns a  DescribeClusterSecurityGroupsResult from Redshift.</returns>
        public  DescribeClusterSecurityGroupsResponse EndDescribeClusterSecurityGroups(IAsyncResult asyncResult)
        {
            return endOperation< DescribeClusterSecurityGroupsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeClusterSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeClusterSnapshots

        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster
        /// snapshots.        By default, this operation returns information about all snapshots
        /// of all clusters that are        owned by you AWS customer account. No information
        /// is returned for snapshots owned by inactive AWS customer accounts.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        public DescribeClusterSnapshotsResponse DescribeClusterSnapshots()
        {
            return DescribeClusterSnapshots(new DescribeClusterSnapshotsRequest());
        }

        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster
        /// snapshots.        By default, this operation returns information about all snapshots
        /// of all clusters that are        owned by you AWS customer account. No information
        /// is returned for snapshots owned by inactive AWS customer accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        public DescribeClusterSnapshotsResponse DescribeClusterSnapshots(DescribeClusterSnapshotsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeClusterSnapshots(request, null, null, true);
            return EndDescribeClusterSnapshots(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSnapshots operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterSnapshots
        ///         operation.</returns>
        public IAsyncResult BeginDescribeClusterSnapshots(DescribeClusterSnapshotsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeClusterSnapshots(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterSnapshots operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeClusterSnapshotsResult from Redshift.</returns>
        public  DescribeClusterSnapshotsResponse EndDescribeClusterSnapshots(IAsyncResult asyncResult)
        {
            return endOperation< DescribeClusterSnapshotsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeClusterSnapshots(DescribeClusterSnapshotsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeClusterSnapshotsRequestMarshaller();
            var unmarshaller = DescribeClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeClusterSubnetGroups

        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata
        /// about your            cluster subnet groups.  By default, this operation returns information
        /// about            all cluster subnet groups that are defined in you AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet
        /// group.
        /// </exception>
        public DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups()
        {
            return DescribeClusterSubnetGroups(new DescribeClusterSubnetGroupsRequest());
        }

        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata
        /// about your            cluster subnet groups.  By default, this operation returns information
        /// about            all cluster subnet groups that are defined in you AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet
        /// group.
        /// </exception>
        public DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeClusterSubnetGroups(request, null, null, true);
            return EndDescribeClusterSubnetGroups(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterSubnetGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterSubnetGroups
        ///         operation.</returns>
        public IAsyncResult BeginDescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeClusterSubnetGroups(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterSubnetGroups operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterSubnetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeClusterSubnetGroupsResult from Redshift.</returns>
        public  DescribeClusterSubnetGroupsResponse EndDescribeClusterSubnetGroups(IAsyncResult asyncResult)
        {
            return endOperation< DescribeClusterSubnetGroupsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeClusterSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeClusterSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeClusterVersions

        /// <summary>
        /// Returns  descriptions of the available Amazon Redshift cluster versions. You can
        /// call this     operation even before creating any clusters to learn more about the
        /// Amazon Redshift versions.     For more information about managing clusters, go to
        /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        public DescribeClusterVersionsResponse DescribeClusterVersions()
        {
            return DescribeClusterVersions(new DescribeClusterVersionsRequest());
        }

        /// <summary>
        /// Returns  descriptions of the available Amazon Redshift cluster versions. You can
        /// call this     operation even before creating any clusters to learn more about the
        /// Amazon Redshift versions.     For more information about managing clusters, go to
        /// <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        public DescribeClusterVersionsResponse DescribeClusterVersions(DescribeClusterVersionsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeClusterVersions(request, null, null, true);
            return EndDescribeClusterVersions(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusterVersions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusterVersions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeClusterVersions(DescribeClusterVersionsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeClusterVersions(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusterVersions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusterVersions.</param>
        /// 
        /// <returns>Returns a  DescribeClusterVersionsResult from Redshift.</returns>
        public  DescribeClusterVersionsResponse EndDescribeClusterVersions(IAsyncResult asyncResult)
        {
            return endOperation< DescribeClusterVersionsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeClusterVersions(DescribeClusterVersionsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeClusterVersionsRequestMarshaller();
            var unmarshaller = DescribeClusterVersionsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeDefaultClusterParameters


        /// <summary>
        /// Returns a list of parameter settings for the specified parameter group family.
        ///        
        /// 
        ///         
        /// <para>
        /// For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultClusterParameters service method, as returned by Redshift.</returns>
        public DescribeDefaultClusterParametersResponse DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeDefaultClusterParameters(request, null, null, true);
            return EndDescribeDefaultClusterParameters(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDefaultClusterParameters
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeDefaultClusterParameters(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDefaultClusterParameters operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDefaultClusterParameters.</param>
        /// 
        /// <returns>Returns a  DescribeDefaultClusterParametersResult from Redshift.</returns>
        public  DescribeDefaultClusterParametersResponse EndDescribeDefaultClusterParameters(IAsyncResult asyncResult)
        {
            return endOperation< DescribeDefaultClusterParametersResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeDefaultClusterParametersRequestMarshaller();
            var unmarshaller = DescribeDefaultClusterParametersResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeEventCategories

        /// <summary>
        /// Displays a list of event categories for all event source types, or for a         
        ///  specified source type. For a list of the event categories and source types,     
        ///      go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        public DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }

        /// <summary>
        /// Displays a list of event categories for all event source types, or for a         
        ///  specified source type. For a list of the event categories and source types,     
        ///      go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        public DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeEventCategories(request, null, null, true);
            return EndDescribeEventCategories(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventCategories
        ///         operation.</returns>
        public IAsyncResult BeginDescribeEventCategories(DescribeEventCategoriesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeEventCategories(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventCategories operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventCategories.</param>
        /// 
        /// <returns>Returns a  DescribeEventCategoriesResult from Redshift.</returns>
        public  DescribeEventCategoriesResponse EndDescribeEventCategories(IAsyncResult asyncResult)
        {
            return endOperation< DescribeEventCategoriesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeEventCategories(DescribeEventCategoriesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeEventCategoriesRequestMarshaller();
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeEvents

        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter
        ///        groups for the past 14 days. Events specific to a particular cluster, security
        /// group,        snapshot or parameter group can be obtained by providing the name as
        /// a parameter.        By default, the past hour of events are returned.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        public DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }

        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter
        ///        groups for the past 14 days. Events specific to a particular cluster, security
        /// group,        snapshot or parameter group can be obtained by providing the name as
        /// a parameter.        By default, the past hour of events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeEvents(request, null, null, true);
            return EndDescribeEvents(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        public IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeEvents(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from Redshift.</returns>
        public  DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult)
        {
            return endOperation< DescribeEventsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notifications subscription
        /// for a  customer account.            If you specify a subscription name, lists the
        /// description for that subscription.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        public DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }

        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notifications subscription
        /// for a  customer account.            If you specify a subscription name, lists the
        /// description for that subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        public DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeEventSubscriptions(request, null, null, true);
            return EndDescribeEventSubscriptions(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventSubscriptions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeEventSubscriptions(DescribeEventSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeEventSubscriptions(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventSubscriptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventSubscriptions.</param>
        /// 
        /// <returns>Returns a  DescribeEventSubscriptionsResult from Redshift.</returns>
        public  DescribeEventSubscriptionsResponse EndDescribeEventSubscriptions(IAsyncResult asyncResult)
        {
            return endOperation< DescribeEventSubscriptionsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeEventSubscriptions(DescribeEventSubscriptionsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeEventSubscriptionsRequestMarshaller();
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeHsmClientCertificates

        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified,            returns information about all the HSM certificates owned
        /// by your AWS customer account.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        public DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates()
        {
            return DescribeHsmClientCertificates(new DescribeHsmClientCertificatesRequest());
        }

        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified,            returns information about all the HSM certificates owned
        /// by your AWS customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates service method.</param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        public DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeHsmClientCertificates(request, null, null, true);
            return EndDescribeHsmClientCertificates(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmClientCertificates operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHsmClientCertificates
        ///         operation.</returns>
        public IAsyncResult BeginDescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeHsmClientCertificates(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHsmClientCertificates operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHsmClientCertificates.</param>
        /// 
        /// <returns>Returns a  DescribeHsmClientCertificatesResult from Redshift.</returns>
        public  DescribeHsmClientCertificatesResponse EndDescribeHsmClientCertificates(IAsyncResult asyncResult)
        {
            return endOperation< DescribeHsmClientCertificatesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeHsmClientCertificatesRequestMarshaller();
            var unmarshaller = DescribeHsmClientCertificatesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeHsmConfigurations

        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is            specified, returns information about all the HSM configurations owned
        /// by your AWS customer account.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        public DescribeHsmConfigurationsResponse DescribeHsmConfigurations()
        {
            return DescribeHsmConfigurations(new DescribeHsmConfigurationsRequest());
        }

        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is            specified, returns information about all the HSM configurations owned
        /// by your AWS customer account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        public DescribeHsmConfigurationsResponse DescribeHsmConfigurations(DescribeHsmConfigurationsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeHsmConfigurations(request, null, null, true);
            return EndDescribeHsmConfigurations(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHsmConfigurations operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHsmConfigurations
        ///         operation.</returns>
        public IAsyncResult BeginDescribeHsmConfigurations(DescribeHsmConfigurationsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeHsmConfigurations(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHsmConfigurations operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHsmConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeHsmConfigurationsResult from Redshift.</returns>
        public  DescribeHsmConfigurationsResponse EndDescribeHsmConfigurations(IAsyncResult asyncResult)
        {
            return endOperation< DescribeHsmConfigurationsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeHsmConfigurations(DescribeHsmConfigurationsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeHsmConfigurationsRequestMarshaller();
            var unmarshaller = DescribeHsmConfigurationsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeLoggingStatus


        /// <summary>
        /// Describes whether information, such as queries and connection attempts,          
        ///  is being logged for the specified Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeLoggingStatus service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        public DescribeLoggingStatusResponse DescribeLoggingStatus(DescribeLoggingStatusRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeLoggingStatus(request, null, null, true);
            return EndDescribeLoggingStatus(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingStatus operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoggingStatus
        ///         operation.</returns>
        public IAsyncResult BeginDescribeLoggingStatus(DescribeLoggingStatusRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeLoggingStatus(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoggingStatus operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoggingStatus.</param>
        /// 
        /// <returns>Returns a  DescribeLoggingStatusResult from Redshift.</returns>
        public  DescribeLoggingStatusResponse EndDescribeLoggingStatus(IAsyncResult asyncResult)
        {
            return endOperation< DescribeLoggingStatusResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeLoggingStatus(DescribeLoggingStatusRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeLoggingStatusRequestMarshaller();
            var unmarshaller = DescribeLoggingStatusResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeOrderableClusterOptions

        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a         new cluster
        /// you can use this operation to find what options are         available, such as the
        /// EC2 Availability Zones (AZ) in the specific         AWS region that you can specify,
        ///         and the node types you can request. The node types differ by available   
        ///      storage, memory, CPU and price. With the cost involved you might want to    
        ///     obtain a list of cluster options in the specific region and specify values   
        ///      when creating a cluster.         For more information about managing clusters,
        /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        public DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions()
        {
            return DescribeOrderableClusterOptions(new DescribeOrderableClusterOptionsRequest());
        }

        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a         new cluster
        /// you can use this operation to find what options are         available, such as the
        /// EC2 Availability Zones (AZ) in the specific         AWS region that you can specify,
        ///         and the node types you can request. The node types differ by available   
        ///      storage, memory, CPU and price. With the cost involved you might want to    
        ///     obtain a list of cluster options in the specific region and specify values   
        ///      when creating a cluster.         For more information about managing clusters,
        /// go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        public DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeOrderableClusterOptions(request, null, null, true);
            return EndDescribeOrderableClusterOptions(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableClusterOptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrderableClusterOptions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeOrderableClusterOptions(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrderableClusterOptions operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrderableClusterOptions.</param>
        /// 
        /// <returns>Returns a  DescribeOrderableClusterOptionsResult from Redshift.</returns>
        public  DescribeOrderableClusterOptionsResponse EndDescribeOrderableClusterOptions(IAsyncResult asyncResult)
        {
            return endOperation< DescribeOrderableClusterOptionsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeOrderableClusterOptionsRequestMarshaller();
            var unmarshaller = DescribeOrderableClusterOptionsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeReservedNodeOfferings

        /// <summary>
        /// Returns a list of the            available reserved node offerings by
        /// Amazon Redshift with their descriptions including             the node type, the fixed
        /// and recurring costs of reserving the node and duration the node will             be
        /// reserved for you. These descriptions help you             determine which reserve
        /// node offering you want to purchase. You then use the unique offering ID          
        ///   in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your             Amazon Redshift cluster.        
        /// 
        ///         
        /// <para>
        ///             For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Management Guide</i>.               
        ///      
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        public DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings()
        {
            return DescribeReservedNodeOfferings(new DescribeReservedNodeOfferingsRequest());
        }

        /// <summary>
        /// Returns a list of the            available reserved node offerings by
        /// Amazon Redshift with their descriptions including             the node type, the fixed
        /// and recurring costs of reserving the node and duration the node will             be
        /// reserved for you. These descriptions help you             determine which reserve
        /// node offering you want to purchase. You then use the unique offering ID          
        ///   in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your             Amazon Redshift cluster.        
        /// 
        ///         
        /// <para>
        ///             For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Management Guide</i>.               
        ///      
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        public DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeReservedNodeOfferings(request, null, null, true);
            return EndDescribeReservedNodeOfferings(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodeOfferings operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedNodeOfferings
        ///         operation.</returns>
        public IAsyncResult BeginDescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedNodeOfferings(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedNodeOfferings operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedNodeOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedNodeOfferingsResult from Redshift.</returns>
        public  DescribeReservedNodeOfferingsResponse EndDescribeReservedNodeOfferings(IAsyncResult asyncResult)
        {
            return endOperation< DescribeReservedNodeOfferingsResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeReservedNodeOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedNodeOfferingsResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeReservedNodes

        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="ReservedNodeNotFoundException">
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
        /// <exception cref="ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        public DescribeReservedNodesResponse DescribeReservedNodes(DescribeReservedNodesRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeReservedNodes(request, null, null, true);
            return EndDescribeReservedNodes(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodes operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedNodes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeReservedNodes(DescribeReservedNodesRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedNodes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedNodes operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedNodes.</param>
        /// 
        /// <returns>Returns a  DescribeReservedNodesResult from Redshift.</returns>
        public  DescribeReservedNodesResponse EndDescribeReservedNodes(IAsyncResult asyncResult)
        {
            return endOperation< DescribeReservedNodesResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeReservedNodes(DescribeReservedNodesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeReservedNodesRequestMarshaller();
            var unmarshaller = DescribeReservedNodesResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DescribeResize


        /// <summary>
        /// Returns information about the last resize operation for the specified cluster.
        ///         If no resize operation has ever been initiated for the specified cluster,
        /// a <code>HTTP 404</code> error is returned.            If a resize operation was initiated
        /// and completed, the status of the resize remains as <code>SUCCEEDED</code> until  
        ///          the next resize.        
        /// 
        ///        
        /// <para>
        ///             A resize operation can be requested using         <a>ModifyCluster</a>
        /// and specifying a different number or type of nodes for the cluster.        
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize service method.</param>
        /// 
        /// <returns>The response from the DescribeResize service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="ResizeNotFoundException">
        /// A resize operation for the specified cluster is not found.
        /// </exception>
        public DescribeResizeResponse DescribeResize(DescribeResizeRequest request)
        {
            IAsyncResult asyncResult = invokeDescribeResize(request, null, null, true);
            return EndDescribeResize(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResize operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResize
        ///         operation.</returns>
        public IAsyncResult BeginDescribeResize(DescribeResizeRequest request, AsyncCallback callback, object state)
        {
            return invokeDescribeResize(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResize operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResize.</param>
        /// 
        /// <returns>Returns a  DescribeResizeResult from Redshift.</returns>
        public  DescribeResizeResponse EndDescribeResize(IAsyncResult asyncResult)
        {
            return endOperation< DescribeResizeResponse>(asyncResult);
        }

        IAsyncResult invokeDescribeResize(DescribeResizeRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DescribeResizeRequestMarshaller();
            var unmarshaller = DescribeResizeResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DisableLogging


        /// <summary>
        /// Stops logging information, such as queries and connection attempts,           for
        /// the specified Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging service method.</param>
        /// 
        /// <returns>The response from the DisableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        public DisableLoggingResponse DisableLogging(DisableLoggingRequest request)
        {
            IAsyncResult asyncResult = invokeDisableLogging(request, null, null, true);
            return EndDisableLogging(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableLogging
        ///         operation.</returns>
        public IAsyncResult BeginDisableLogging(DisableLoggingRequest request, AsyncCallback callback, object state)
        {
            return invokeDisableLogging(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableLogging.</param>
        /// 
        /// <returns>Returns a  DisableLoggingResult from Redshift.</returns>
        public  DisableLoggingResponse EndDisableLogging(IAsyncResult asyncResult)
        {
            return endOperation< DisableLoggingResponse>(asyncResult);
        }

        IAsyncResult invokeDisableLogging(DisableLoggingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DisableLoggingRequestMarshaller();
            var unmarshaller = DisableLoggingResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  DisableSnapshotCopy


        /// <summary>
        /// Disables the automatic copying of snapshots from one region to another region for
        /// a specified cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy service method.</param>
        /// 
        /// <returns>The response from the DisableSnapshotCopy service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="SnapshotCopyAlreadyDisabledException">
        /// The cluster already has cross-region snapshot copy disabled.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        public DisableSnapshotCopyResponse DisableSnapshotCopy(DisableSnapshotCopyRequest request)
        {
            IAsyncResult asyncResult = invokeDisableSnapshotCopy(request, null, null, true);
            return EndDisableSnapshotCopy(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableSnapshotCopy
        ///         operation.</returns>
        public IAsyncResult BeginDisableSnapshotCopy(DisableSnapshotCopyRequest request, AsyncCallback callback, object state)
        {
            return invokeDisableSnapshotCopy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableSnapshotCopy.</param>
        /// 
        /// <returns>Returns a  DisableSnapshotCopyResult from Redshift.</returns>
        public  DisableSnapshotCopyResponse EndDisableSnapshotCopy(IAsyncResult asyncResult)
        {
            return endOperation< DisableSnapshotCopyResponse>(asyncResult);
        }

        IAsyncResult invokeDisableSnapshotCopy(DisableSnapshotCopyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new DisableSnapshotCopyRequestMarshaller();
            var unmarshaller = DisableSnapshotCopyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  EnableLogging


        /// <summary>
        /// Starts logging information, such as queries and connection attempts,            for
        /// the specified Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging service method.</param>
        /// 
        /// <returns>The response from the EnableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="BucketNotFoundException">
        /// Could not find the specified S3 bucket.
        /// </exception>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="InsufficientS3BucketPolicyException">
        /// The cluster does not have read bucket or put object permissions      
        ///      on the S3 bucket specified when enabling logging.
        /// </exception>
        /// <exception cref="InvalidS3BucketNameException">
        /// The S3 bucket name is invalid. For more information about naming rules, go to <a href="http://docs.aws.amazon.com/AmazonS3/latest/dev/BucketRestrictions.html">Bucket
        /// Restrictions and Limitations</a> in the Amazon Simple Storage Service (S3) Developer
        /// Guide.
        /// </exception>
        /// <exception cref="InvalidS3KeyPrefixException">
        /// The string specified for the logging S3 key prefix does not comply with
        ///            the documented constraints.
        /// </exception>
        public EnableLoggingResponse EnableLogging(EnableLoggingRequest request)
        {
            IAsyncResult asyncResult = invokeEnableLogging(request, null, null, true);
            return EndEnableLogging(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableLogging
        ///         operation.</returns>
        public IAsyncResult BeginEnableLogging(EnableLoggingRequest request, AsyncCallback callback, object state)
        {
            return invokeEnableLogging(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableLogging operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableLogging.</param>
        /// 
        /// <returns>Returns a  EnableLoggingResult from Redshift.</returns>
        public  EnableLoggingResponse EndEnableLogging(IAsyncResult asyncResult)
        {
            return endOperation< EnableLoggingResponse>(asyncResult);
        }

        IAsyncResult invokeEnableLogging(EnableLoggingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new EnableLoggingRequestMarshaller();
            var unmarshaller = EnableLoggingResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
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
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="CopyToRegionDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request
        /// again.
        /// </exception>
        /// <exception cref="IncompatibleOrderableOptionsException">
        /// The specified options are incompatible.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="SnapshotCopyAlreadyEnabledException">
        /// The cluster already has cross-region snapshot copy enabled.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="UnknownSnapshotCopyRegionException">
        /// The specified region is incorrect or does not exist.
        /// </exception>
        public EnableSnapshotCopyResponse EnableSnapshotCopy(EnableSnapshotCopyRequest request)
        {
            IAsyncResult asyncResult = invokeEnableSnapshotCopy(request, null, null, true);
            return EndEnableSnapshotCopy(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableSnapshotCopy
        ///         operation.</returns>
        public IAsyncResult BeginEnableSnapshotCopy(EnableSnapshotCopyRequest request, AsyncCallback callback, object state)
        {
            return invokeEnableSnapshotCopy(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableSnapshotCopy operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableSnapshotCopy.</param>
        /// 
        /// <returns>Returns a  EnableSnapshotCopyResult from Redshift.</returns>
        public  EnableSnapshotCopyResponse EndEnableSnapshotCopy(IAsyncResult asyncResult)
        {
            return endOperation< EnableSnapshotCopyResponse>(asyncResult);
        }

        IAsyncResult invokeEnableSnapshotCopy(EnableSnapshotCopyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new EnableSnapshotCopyRequestMarshaller();
            var unmarshaller = EnableSnapshotCopyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ModifyCluster


        /// <summary>
        /// Modifies the settings for a cluster.         For example, you can add
        /// another security or parameter group,         update the preferred maintenance window,
        /// or change the master user password.          Resetting a cluster password or modifying
        /// the security groups associated         with a cluster do not need a reboot. However,
        /// modifying a parameter group         requires a reboot for parameters to take effect.
        ///                For more information about managing clusters, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>        
        /// 
        ///         
        /// <para>
        /// You can also change node type and the number of nodes to scale up or down the cluster.
        ///             When resizing a cluster, you must specify            both the number of
        /// nodes and the node type even if one of the parameters does             not change.
        /// If you specify        the same number of nodes and node type that are already configured
        /// for the cluster,         an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        /// <exception cref="HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="UnsupportedOptionException">
        /// A request option was specified that is not supported.
        /// </exception>
        public ModifyClusterResponse ModifyCluster(ModifyClusterRequest request)
        {
            IAsyncResult asyncResult = invokeModifyCluster(request, null, null, true);
            return EndModifyCluster(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyCluster
        ///         operation.</returns>
        public IAsyncResult BeginModifyCluster(ModifyClusterRequest request, AsyncCallback callback, object state)
        {
            return invokeModifyCluster(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyCluster.</param>
        /// 
        /// <returns>Returns a  ModifyClusterResult from Redshift.</returns>
        public  ModifyClusterResponse EndModifyCluster(IAsyncResult asyncResult)
        {
            return endOperation< ModifyClusterResponse>(asyncResult);
        }

        IAsyncResult invokeModifyCluster(ModifyClusterRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ModifyClusterRequestMarshaller();
            var unmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ModifyClusterParameterGroup


        /// <summary>
        /// Modifies the parameters of a parameter group.         
        /// 
        ///         
        /// <para>
        /// For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        /// <exception cref="InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because         another
        /// task is in progress that involves the parameter group.         Wait a few moments
        /// and try the operation again.
        /// </exception>
        public ModifyClusterParameterGroupResponse ModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request)
        {
            IAsyncResult asyncResult = invokeModifyClusterParameterGroup(request, null, null, true);
            return EndModifyClusterParameterGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyClusterParameterGroup
        ///         operation.</returns>
        public IAsyncResult BeginModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeModifyClusterParameterGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  ModifyClusterParameterGroupResult from Redshift.</returns>
        public  ModifyClusterParameterGroupResponse EndModifyClusterParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation< ModifyClusterParameterGroupResponse>(asyncResult);
        }

        IAsyncResult invokeModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ModifyClusterParameterGroupRequestMarshaller();
            var unmarshaller = ModifyClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ModifyClusterSubnetGroup


        /// <summary>
        /// Modifies a cluster subnet group to include the specified list of VPC subnets.
        ///         The operation replaces the existing list of subnets with the new list of subnets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet
        /// group.
        /// </exception>
        /// <exception cref="ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets
        /// in a cluster subnet groups. For information about increasing your quota, go to <a
        /// href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same
        /// VPC.
        /// </exception>
        /// <exception cref="SubnetAlreadyInUseException">
        /// A specified subnet is already in use by another cluster.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        public ModifyClusterSubnetGroupResponse ModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request)
        {
            IAsyncResult asyncResult = invokeModifyClusterSubnetGroup(request, null, null, true);
            return EndModifyClusterSubnetGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyClusterSubnetGroup
        ///         operation.</returns>
        public IAsyncResult BeginModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeModifyClusterSubnetGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyClusterSubnetGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyClusterSubnetGroup.</param>
        /// 
        /// <returns>Returns a  ModifyClusterSubnetGroupResult from Redshift.</returns>
        public  ModifyClusterSubnetGroupResponse EndModifyClusterSubnetGroup(IAsyncResult asyncResult)
        {
            return endOperation< ModifyClusterSubnetGroupResponse>(asyncResult);
        }

        IAsyncResult invokeModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ModifyClusterSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyClusterSubnetGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ModifyEventSubscription


        /// <summary>
        /// Modifies an existing Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request.
        /// This subscription request is already in progress.
        /// </exception>
        /// <exception cref="SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or 
        ///           it specified a category that does not apply to the specified source type.
        /// The allowed            values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <exception cref="SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or 
        ///           it specified a severity that does not apply to the specified source type.
        /// The allowed            values are ERROR and INFO.
        /// </exception>
        public ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            IAsyncResult asyncResult = invokeModifyEventSubscription(request, null, null, true);
            return EndModifyEventSubscription(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyEventSubscription
        ///         operation.</returns>
        public IAsyncResult BeginModifyEventSubscription(ModifyEventSubscriptionRequest request, AsyncCallback callback, object state)
        {
            return invokeModifyEventSubscription(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyEventSubscription operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyEventSubscription.</param>
        /// 
        /// <returns>Returns a  ModifyEventSubscriptionResult from Redshift.</returns>
        public  ModifyEventSubscriptionResponse EndModifyEventSubscription(IAsyncResult asyncResult)
        {
            return endOperation< ModifyEventSubscriptionResponse>(asyncResult);
        }

        IAsyncResult invokeModifyEventSubscription(ModifyEventSubscriptionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ModifyEventSubscriptionRequestMarshaller();
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ModifySnapshotCopyRetentionPeriod


        /// <summary>
        /// Modifies the number of days to retain automated snapshots in the destination
        /// region after they are copied from the source region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod service method.</param>
        /// 
        /// <returns>The response from the ModifySnapshotCopyRetentionPeriod service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="SnapshotCopyDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request
        /// again.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        public ModifySnapshotCopyRetentionPeriodResponse ModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request)
        {
            IAsyncResult asyncResult = invokeModifySnapshotCopyRetentionPeriod(request, null, null, true);
            return EndModifySnapshotCopyRetentionPeriod(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotCopyRetentionPeriod operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifySnapshotCopyRetentionPeriod
        ///         operation.</returns>
        public IAsyncResult BeginModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request, AsyncCallback callback, object state)
        {
            return invokeModifySnapshotCopyRetentionPeriod(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySnapshotCopyRetentionPeriod operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySnapshotCopyRetentionPeriod.</param>
        /// 
        /// <returns>Returns a  ModifySnapshotCopyRetentionPeriodResult from Redshift.</returns>
        public  ModifySnapshotCopyRetentionPeriodResponse EndModifySnapshotCopyRetentionPeriod(IAsyncResult asyncResult)
        {
            return endOperation< ModifySnapshotCopyRetentionPeriodResponse>(asyncResult);
        }

        IAsyncResult invokeModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ModifySnapshotCopyRetentionPeriodRequestMarshaller();
            var unmarshaller = ModifySnapshotCopyRetentionPeriodResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  PurchaseReservedNodeOffering


        /// <summary>
        /// Allows you to purchase reserved nodes. Amazon Redshift offers a predefined
        /// set of reserved node offerings.           You can purchase one of the offerings. You
        /// can call the           <a>DescribeReservedNodeOfferings</a> API to obtain the available
        /// reserved node offerings. You can call this            API by providing a specific
        /// reserved node offering and the number of nodes you want to reserve.       
        /// 
        ///        
        /// <para>
        ///            For more information about managing parameter groups, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Management Guide</i>.               
        ///     
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedNodeOffering service method, as returned by Redshift.</returns>
        /// <exception cref="ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="ReservedNodeQuotaExceededException">
        /// Request would exceed the user's compute node quota. For information about
        /// increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        public PurchaseReservedNodeOfferingResponse PurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request)
        {
            IAsyncResult asyncResult = invokePurchaseReservedNodeOffering(request, null, null, true);
            return EndPurchaseReservedNodeOffering(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedNodeOffering operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseReservedNodeOffering
        ///         operation.</returns>
        public IAsyncResult BeginPurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request, AsyncCallback callback, object state)
        {
            return invokePurchaseReservedNodeOffering(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedNodeOffering operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedNodeOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedNodeOfferingResult from Redshift.</returns>
        public  PurchaseReservedNodeOfferingResponse EndPurchaseReservedNodeOffering(IAsyncResult asyncResult)
        {
            return endOperation< PurchaseReservedNodeOfferingResponse>(asyncResult);
        }

        IAsyncResult invokePurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new PurchaseReservedNodeOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedNodeOfferingResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  RebootCluster


        /// <summary>
        /// Reboots a cluster.         This action is taken as soon as possible. It results
        /// in a momentary outage to the cluster,        during which the cluster status is set
        /// to <code>rebooting</code>. A cluster event is created            when the reboot is
        /// completed.                    Any pending cluster modifications (see <a>ModifyCluster</a>)
        /// are applied at this reboot.        For more information about managing clusters, go
        /// to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Management Guide</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster service method.</param>
        /// 
        /// <returns>The response from the RebootCluster service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        public RebootClusterResponse RebootCluster(RebootClusterRequest request)
        {
            IAsyncResult asyncResult = invokeRebootCluster(request, null, null, true);
            return EndRebootCluster(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootCluster
        ///         operation.</returns>
        public IAsyncResult BeginRebootCluster(RebootClusterRequest request, AsyncCallback callback, object state)
        {
            return invokeRebootCluster(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootCluster operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootCluster.</param>
        /// 
        /// <returns>Returns a  RebootClusterResult from Redshift.</returns>
        public  RebootClusterResponse EndRebootCluster(IAsyncResult asyncResult)
        {
            return endOperation< RebootClusterResponse>(asyncResult);
        }

        IAsyncResult invokeRebootCluster(RebootClusterRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new RebootClusterRequestMarshaller();
            var unmarshaller = RebootClusterResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  ResetClusterParameterGroup


        /// <summary>
        /// Sets one or more parameters of the specified parameter group to their
        /// default values and sets the             source values of the parameters to "engine-default".
        ///             To reset the entire parameter group specify the <i>ResetAllParameters</i>
        /// parameter.             For parameter changes to take effect you must reboot any associated
        /// clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        /// <exception cref="InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because         another
        /// task is in progress that involves the parameter group.         Wait a few moments
        /// and try the operation again.
        /// </exception>
        public ResetClusterParameterGroupResponse ResetClusterParameterGroup(ResetClusterParameterGroupRequest request)
        {
            IAsyncResult asyncResult = invokeResetClusterParameterGroup(request, null, null, true);
            return EndResetClusterParameterGroup(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetClusterParameterGroup
        ///         operation.</returns>
        public IAsyncResult BeginResetClusterParameterGroup(ResetClusterParameterGroupRequest request, AsyncCallback callback, object state)
        {
            return invokeResetClusterParameterGroup(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetClusterParameterGroup operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetClusterParameterGroup.</param>
        /// 
        /// <returns>Returns a  ResetClusterParameterGroupResult from Redshift.</returns>
        public  ResetClusterParameterGroupResponse EndResetClusterParameterGroup(IAsyncResult asyncResult)
        {
            return endOperation< ResetClusterParameterGroupResponse>(asyncResult);
        }

        IAsyncResult invokeResetClusterParameterGroup(ResetClusterParameterGroupRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new ResetClusterParameterGroupRequestMarshaller();
            var unmarshaller = ResetClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  RestoreFromClusterSnapshot


        /// <summary>
        /// Creates a new cluster from a snapshot. Amazon Redshift creates the resulting
        /// cluster         with the same configuration as the original cluster from which the
        /// snapshot was created,         except that the new cluster        is created with the
        /// default cluster security and parameter group.                 After Amazon Redshift
        /// creates the cluster you can use the <a>ModifyCluster</a>             API to associate
        /// a different security group and different parameter group with the            restored
        /// cluster.        
        /// 
        ///         
        /// <para>
        ///  If you restore a cluster into a VPC, you must provide a cluster subnet group where
        /// you want the cluster             restored.        
        /// </para>
        ///         
        /// <para>
        /// For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreFromClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to
        /// access the snapshot.
        /// </exception>
        /// <exception cref="ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an        existing parameter group.
        /// </exception>
        /// <exception cref="ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this
        /// account. For information about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet
        /// group.
        /// </exception>
        /// <exception cref="HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="InvalidClusterSnapshotStateException">
        /// The state of the cluster snapshot is not <code>available</code>, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="InvalidRestoreException">
        /// The restore is invalid.
        /// </exception>
        /// <exception cref="InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same
        /// VPC.
        /// </exception>
        /// <exception cref="InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </exception>
        /// <exception cref="UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        public RestoreFromClusterSnapshotResponse RestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request)
        {
            IAsyncResult asyncResult = invokeRestoreFromClusterSnapshot(request, null, null, true);
            return EndRestoreFromClusterSnapshot(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreFromClusterSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginRestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request, AsyncCallback callback, object state)
        {
            return invokeRestoreFromClusterSnapshot(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreFromClusterSnapshot operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreFromClusterSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreFromClusterSnapshotResult from Redshift.</returns>
        public  RestoreFromClusterSnapshotResponse EndRestoreFromClusterSnapshot(IAsyncResult asyncResult)
        {
            return endOperation< RestoreFromClusterSnapshotResponse>(asyncResult);
        }

        IAsyncResult invokeRestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new RestoreFromClusterSnapshotRequestMarshaller();
            var unmarshaller = RestoreFromClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  RevokeClusterSecurityGroupIngress


        /// <summary>
        /// Revokes an ingress rule in an Amazon Redshift security group for a previously
        /// authorized IP range or         Amazon EC2 security group. To add        an ingress
        /// rule, see <a>AuthorizeClusterSecurityGroupIngress</a>.             For information
        /// about managing security groups, go to<a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the RevokeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized      
        ///  for the specified cluster security group.
        /// </exception>
        /// <exception cref="ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster
        /// security group.
        /// </exception>
        /// <exception cref="InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        public RevokeClusterSecurityGroupIngressResponse RevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request)
        {
            IAsyncResult asyncResult = invokeRevokeClusterSecurityGroupIngress(request, null, null, true);
            return EndRevokeClusterSecurityGroupIngress(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeClusterSecurityGroupIngress
        ///         operation.</returns>
        public IAsyncResult BeginRevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request, AsyncCallback callback, object state)
        {
            return invokeRevokeClusterSecurityGroupIngress(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeClusterSecurityGroupIngress operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeClusterSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  RevokeClusterSecurityGroupIngressResult from Redshift.</returns>
        public  RevokeClusterSecurityGroupIngressResponse EndRevokeClusterSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return endOperation< RevokeClusterSecurityGroupIngressResponse>(asyncResult);
        }

        IAsyncResult invokeRevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new RevokeClusterSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeClusterSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  RevokeSnapshotAccess


        /// <summary>
        /// Removes the ability of the specified AWS customer account to restore the
        /// specified snapshot.            If the account is currently restoring the snapshot,
        /// the restore will run to completion.        
        /// 
        ///         
        /// <para>
        /// For more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess service method.</param>
        /// 
        /// <returns>The response from the RevokeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to
        /// access the snapshot.
        /// </exception>
        /// <exception cref="AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized      
        ///  for the specified cluster security group.
        /// </exception>
        /// <exception cref="ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        public RevokeSnapshotAccessResponse RevokeSnapshotAccess(RevokeSnapshotAccessRequest request)
        {
            IAsyncResult asyncResult = invokeRevokeSnapshotAccess(request, null, null, true);
            return EndRevokeSnapshotAccess(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeSnapshotAccess
        ///         operation.</returns>
        public IAsyncResult BeginRevokeSnapshotAccess(RevokeSnapshotAccessRequest request, AsyncCallback callback, object state)
        {
            return invokeRevokeSnapshotAccess(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeSnapshotAccess operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSnapshotAccess.</param>
        /// 
        /// <returns>Returns a  RevokeSnapshotAccessResult from Redshift.</returns>
        public  RevokeSnapshotAccessResponse EndRevokeSnapshotAccess(IAsyncResult asyncResult)
        {
            return endOperation< RevokeSnapshotAccessResponse>(asyncResult);
        }

        IAsyncResult invokeRevokeSnapshotAccess(RevokeSnapshotAccessRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new RevokeSnapshotAccessRequestMarshaller();
            var unmarshaller = RevokeSnapshotAccessResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
        #region  RotateEncryptionKey


        /// <summary>
        /// Rotates the encryption keys for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the RotateEncryptionKey service method, as returned by Redshift.</returns>
        /// <exception cref="ClusterNotFoundException">
        /// The <i>ClusterIdentifier</i> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        public RotateEncryptionKeyResponse RotateEncryptionKey(RotateEncryptionKeyRequest request)
        {
            IAsyncResult asyncResult = invokeRotateEncryptionKey(request, null, null, true);
            return EndRotateEncryptionKey(asyncResult);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RotateEncryptionKey operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey operation on AmazonRedshiftClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRotateEncryptionKey
        ///         operation.</returns>
        public IAsyncResult BeginRotateEncryptionKey(RotateEncryptionKeyRequest request, AsyncCallback callback, object state)
        {
            return invokeRotateEncryptionKey(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RotateEncryptionKey operation.
        /// <seealso cref="Amazon.Redshift.IAmazonRedshift"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRotateEncryptionKey.</param>
        /// 
        /// <returns>Returns a  RotateEncryptionKeyResult from Redshift.</returns>
        public  RotateEncryptionKeyResponse EndRotateEncryptionKey(IAsyncResult asyncResult)
        {
            return endOperation< RotateEncryptionKeyResponse>(asyncResult);
        }

        IAsyncResult invokeRotateEncryptionKey(RotateEncryptionKeyRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            var marshaller = new RotateEncryptionKeyRequestMarshaller();
            var unmarshaller = RotateEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke(request, callback, state, synchronized, marshaller, unmarshaller, signer);
        }

        #endregion
        
    }
}