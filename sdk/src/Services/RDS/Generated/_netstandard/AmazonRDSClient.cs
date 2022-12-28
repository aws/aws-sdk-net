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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RDS.Model;
using Amazon.RDS.Model.Internal.MarshallTransformations;
using Amazon.RDS.Internal;
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
    /// Amazon Relational Database Service (Amazon RDS) is a web service that makes it easier
    /// to set up, operate, and scale a relational database in the cloud. It provides cost-efficient,
    /// resizeable capacity for an industry-standard relational database and manages common
    /// database administration tasks, freeing up developers to focus on what makes their
    /// applications and businesses unique.
    /// </para>
    ///  
    /// <para>
    /// Amazon RDS gives you access to the capabilities of a MySQL, MariaDB, PostgreSQL, Microsoft
    /// SQL Server, Oracle, or Amazon Aurora database server. These capabilities mean that
    /// the code, applications, and tools you already use today with your existing databases
    /// work with Amazon RDS without modification. Amazon RDS automatically backs up your
    /// database and maintains the database software that powers your DB instance. Amazon
    /// RDS is flexible: you can scale your DB instance's compute resources and storage capacity
    /// to meet your application's demand. As with all Amazon Web Services, there are no up-front
    /// investments, and you pay only for the resources you use.
    /// </para>
    ///  
    /// <para>
    /// This interface reference for Amazon RDS contains documentation for a programming or
    /// command line interface you can use to manage Amazon RDS. Amazon RDS is asynchronous,
    /// which means that some interfaces might require techniques such as polling or callback
    /// functions to determine when a command has been applied. In this reference, the parameter
    /// descriptions indicate whether a command is applied immediately, on the next instance
    /// reboot, or during the maintenance window. The reference structure is as follows, and
    /// we list following some related topics from the user guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>Amazon RDS API Reference</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For the alphabetical list of API actions, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Operations.html">API
    /// Actions</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For the alphabetical list of data types, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Types.html">Data
    /// Types</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a list of common query parameters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/CommonParameters.html">Common
    /// Parameters</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For descriptions of the error codes, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/CommonErrors.html">Common
    /// Errors</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Amazon RDS User Guide</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For a summary of the Amazon RDS interfaces, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Welcome.html#Welcome.Interfaces">Available
    /// RDS Interfaces</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For more information about how to use the Query API, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Using_the_Query_API.html">Using
    /// the Query API</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonRDSClient : AmazonServiceClient, IAmazonRDS
    {
        private static IServiceMetadata serviceMetadata = new AmazonRDSMetadata();
        
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
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRDSClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSConfig()) { }

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
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
        public AmazonRDSClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRDSConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRDSClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRDSClient Configuration Object</param>
        public AmazonRDSClient(AmazonRDSConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
        private IRDSPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRDSPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new RDSPaginatorFactory(this);
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
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.RDS.Internal.PreSignedUrlRequestHandler(this.Credentials));
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRDSEndpointResolver());
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


        #region  AddRoleToDBCluster

        internal virtual AddRoleToDBClusterResponse AddRoleToDBCluster(AddRoleToDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddRoleToDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToDBClusterResponseUnmarshaller.Instance;

            return Invoke<AddRoleToDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Associates an Identity and Access Management (IAM) role with a DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddRoleToDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterRoleAlreadyExistsException">
        /// The specified IAM role Amazon Resource Name (ARN) is already associated with the specified
        /// DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterRoleQuotaExceededException">
        /// You have exceeded the maximum number of IAM roles that can be associated with the
        /// specified DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddRoleToDBCluster">REST API Reference for AddRoleToDBCluster Operation</seealso>
        public virtual Task<AddRoleToDBClusterResponse> AddRoleToDBClusterAsync(AddRoleToDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddRoleToDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<AddRoleToDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddRoleToDBInstance

        internal virtual AddRoleToDBInstanceResponse AddRoleToDBInstance(AddRoleToDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddRoleToDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToDBInstanceResponseUnmarshaller.Instance;

            return Invoke<AddRoleToDBInstanceResponse>(request, options);
        }



        /// <summary>
        /// Associates an Amazon Web Services Identity and Access Management (IAM) role with a
        /// DB instance.
        /// 
        ///  <note> 
        /// <para>
        /// To add a role to a DB instance, the status of the DB instance must be <code>available</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddRoleToDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceRoleAlreadyExistsException">
        /// The specified <code>RoleArn</code> or <code>FeatureName</code> value is already associated
        /// with the DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceRoleQuotaExceededException">
        /// You can't associate any more Amazon Web Services Identity and Access Management (IAM)
        /// roles with the DB instance because the quota has been reached.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddRoleToDBInstance">REST API Reference for AddRoleToDBInstance Operation</seealso>
        public virtual Task<AddRoleToDBInstanceResponse> AddRoleToDBInstanceAsync(AddRoleToDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddRoleToDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<AddRoleToDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddSourceIdentifierToSubscription

        internal virtual AddSourceIdentifierToSubscriptionResponse AddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddSourceIdentifierToSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return Invoke<AddSourceIdentifierToSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Adds a source identifier to an existing RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddSourceIdentifierToSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        public virtual Task<AddSourceIdentifierToSubscriptionResponse> AddSourceIdentifierToSubscriptionAsync(AddSourceIdentifierToSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddSourceIdentifierToSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<AddSourceIdentifierToSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddTagsToResource

        internal virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds metadata tags to an Amazon RDS resource. These tags can also be used with cost
        /// allocation reporting to track cost associated with Amazon RDS resources, or used in
        /// a Condition statement in an IAM policy for Amazon RDS.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging Amazon RDS resources, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon RDS Resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <code>BlueGreenDeploymentIdentifier</code> doesn't refer to an existing blue/green
        /// deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ApplyPendingMaintenanceAction

        internal virtual ApplyPendingMaintenanceActionResponse ApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return Invoke<ApplyPendingMaintenanceActionResponse>(request, options);
        }



        /// <summary>
        /// Applies a pending maintenance action to a resource (for example, to a DB instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApplyPendingMaintenanceAction service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual Task<ApplyPendingMaintenanceActionResponse> ApplyPendingMaintenanceActionAsync(ApplyPendingMaintenanceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return InvokeAsync<ApplyPendingMaintenanceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeDBSecurityGroupIngress

        internal virtual AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeDBSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeDBSecurityGroupIngressResponse>(request, options);
        }



        /// <summary>
        /// Enables ingress to a DBSecurityGroup using one of two forms of authorization. First,
        /// EC2 or VPC security groups can be added to the DBSecurityGroup if the application
        /// using the database is running on EC2 or VPC instances. Second, IP ranges are available
        /// if the application accessing your database is running on the internet. Required parameters
        /// for this API are one of CIDR range, EC2SecurityGroupId for VPC, or (EC2SecurityGroupOwnerId
        /// and either EC2SecurityGroupName or EC2SecurityGroupId for non-VPC).
        /// 
        ///  
        /// <para>
        /// You can't authorize ingress from an EC2 security group in one Amazon Web Services
        /// Region to an Amazon RDS DB instance in another. You can't authorize ingress from a
        /// VPC security group in one VPC to an Amazon RDS DB instance in another.
        /// </para>
        ///  
        /// <para>
        /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
        /// Tutorial</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// EC2-Classic was retired on August 15, 2022. If you haven't migrated from EC2-Classic
        /// to a VPC, we recommend that you migrate as soon as possible. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-migrate.html">Migrate
        /// from EC2-Classic to a VPC</a> in the <i>Amazon EC2 User Guide</i>, the blog <a href="http://aws.amazon.com/blogs/aws/ec2-classic-is-retiring-heres-how-to-prepare/">EC2-Classic
        /// Networking is Retiring – Here’s How to Prepare</a>, and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.Non-VPC2VPC.html">Moving
        /// a DB instance not in a VPC into a VPC</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeDBSecurityGroupIngress service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationAlreadyExistsException">
        /// The specified CIDR IP range or Amazon EC2 security group is already authorized for
        /// the specified DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.AuthorizationQuotaExceededException">
        /// The DB security group authorization quota has been reached.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AuthorizeDBSecurityGroupIngress">REST API Reference for AuthorizeDBSecurityGroupIngress Operation</seealso>
        public virtual Task<AuthorizeDBSecurityGroupIngressResponse> AuthorizeDBSecurityGroupIngressAsync(AuthorizeDBSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeDBSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeDBSecurityGroupIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BacktrackDBCluster

        internal virtual BacktrackDBClusterResponse BacktrackDBCluster(BacktrackDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BacktrackDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BacktrackDBClusterResponseUnmarshaller.Instance;

            return Invoke<BacktrackDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Backtracks a DB cluster to a specific time, without creating a new DB cluster.
        /// 
        ///  
        /// <para>
        /// For more information on backtracking, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/AuroraMySQL.Managing.Backtrack.html">
        /// Backtracking an Aurora DB Cluster</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action applies only to Aurora MySQL DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BacktrackDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BacktrackDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/BacktrackDBCluster">REST API Reference for BacktrackDBCluster Operation</seealso>
        public virtual Task<BacktrackDBClusterResponse> BacktrackDBClusterAsync(BacktrackDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BacktrackDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BacktrackDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<BacktrackDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelExportTask

        internal virtual CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelExportTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancels an export task in progress that is exporting a snapshot to Amazon S3. Any
        /// data that has already been written to the S3 bucket isn't removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelExportTask service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ExportTaskNotFoundException">
        /// The export task doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidExportTaskStateException">
        /// You can't cancel an export task that has completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelExportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyDBClusterParameterGroup

        internal virtual CopyDBClusterParameterGroupResponse CopyDBClusterParameterGroup(CopyDBClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Copies the specified DB cluster parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB parameter
        /// groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        public virtual Task<CopyDBClusterParameterGroupResponse> CopyDBClusterParameterGroupAsync(CopyDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyDBClusterSnapshot

        internal virtual CopyDBClusterSnapshotResponse CopyDBClusterSnapshot(CopyDBClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Copies a snapshot of a DB cluster.
        /// 
        ///  
        /// <para>
        /// To copy a DB cluster snapshot from a shared manual DB cluster snapshot, <code>SourceDBClusterSnapshotIdentifier</code>
        /// must be the Amazon Resource Name (ARN) of the shared DB cluster snapshot.
        /// </para>
        ///  
        /// <para>
        /// You can copy an encrypted DB cluster snapshot from another Amazon Web Services Region.
        /// In that case, the Amazon Web Services Region where you call the <code>CopyDBClusterSnapshot</code>
        /// operation is the destination Amazon Web Services Region for the encrypted DB cluster
        /// snapshot to be copied to. To copy an encrypted DB cluster snapshot from another Amazon
        /// Web Services Region, you must provide the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>KmsKeyId</code> - The Amazon Web Services Key Management System (Amazon Web
        /// Services KMS) key identifier for the key to use to encrypt the copy of the DB cluster
        /// snapshot in the destination Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TargetDBClusterSnapshotIdentifier</code> - The identifier for the new copy
        /// of the DB cluster snapshot in the destination Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SourceDBClusterSnapshotIdentifier</code> - The DB cluster snapshot identifier
        /// for the encrypted DB cluster snapshot to be copied. This identifier must be in the
        /// ARN format for the source Amazon Web Services Region and is the same value as the
        /// <code>SourceDBClusterSnapshotIdentifier</code> in the presigned URL.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To cancel the copy operation once it is in progress, delete the target DB cluster
        /// snapshot identified by <code>TargetDBClusterSnapshotIdentifier</code> while that DB
        /// cluster snapshot is in "copying" status.
        /// </para>
        ///  
        /// <para>
        /// For more information on copying encrypted Amazon Aurora DB cluster snapshots from
        /// one Amazon Web Services Region to another, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_CopySnapshot.html">
        /// Copying a Snapshot</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotAlreadyExistsException">
        /// The user already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
        public virtual Task<CopyDBClusterSnapshotResponse> CopyDBClusterSnapshotAsync(CopyDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyDBParameterGroup

        internal virtual CopyDBParameterGroupResponse CopyDBParameterGroup(CopyDBParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Copies the specified DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB parameter
        /// groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBParameterGroup">REST API Reference for CopyDBParameterGroup Operation</seealso>
        public virtual Task<CopyDBParameterGroupResponse> CopyDBParameterGroupAsync(CopyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyDBSnapshot

        internal virtual CopyDBSnapshotResponse CopyDBSnapshot(CopyDBSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyDBSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Copies the specified DB snapshot. The source DB snapshot must be in the <code>available</code>
        /// state.
        /// 
        ///  
        /// <para>
        /// You can copy a snapshot from one Amazon Web Services Region to another. In that case,
        /// the Amazon Web Services Region where you call the <code>CopyDBSnapshot</code> operation
        /// is the destination Amazon Web Services Region for the DB snapshot copy.
        /// </para>
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        /// For more information about copying snapshots, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_CopySnapshot.html#USER_CopyDBSnapshot">Copying
        /// a DB Snapshot</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CustomAvailabilityZoneNotFoundException">
        /// <code>CustomAvailabilityZoneId</code> doesn't refer to an existing custom Availability
        /// Zone identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <code>DBSnapshotIdentifier</code> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBSnapshot">REST API Reference for CopyDBSnapshot Operation</seealso>
        public virtual Task<CopyDBSnapshotResponse> CopyDBSnapshotAsync(CopyDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyOptionGroup

        internal virtual CopyOptionGroupResponse CopyOptionGroup(CopyOptionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyOptionGroupResponseUnmarshaller.Instance;

            return Invoke<CopyOptionGroupResponse>(request, options);
        }



        /// <summary>
        /// Copies the specified option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyOptionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupAlreadyExistsException">
        /// The option group you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupQuotaExceededException">
        /// The quota of 20 option groups was exceeded for this Amazon Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyOptionGroup">REST API Reference for CopyOptionGroup Operation</seealso>
        public virtual Task<CopyOptionGroupResponse> CopyOptionGroupAsync(CopyOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CopyOptionGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBlueGreenDeployment

        internal virtual CreateBlueGreenDeploymentResponse CreateBlueGreenDeployment(CreateBlueGreenDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBlueGreenDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueGreenDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateBlueGreenDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Creates a blue/green deployment.
        /// 
        ///  
        /// <para>
        /// A blue/green deployment creates a staging environment that copies the production environment.
        /// In a blue/green deployment, the blue environment is the current production environment.
        /// The green environment is the staging environment. The staging environment stays in
        /// sync with the current production environment using logical replication.
        /// </para>
        ///  
        /// <para>
        /// You can make changes to the databases in the green environment without affecting production
        /// workloads. For example, you can upgrade the major or minor DB engine version, change
        /// database parameters, or make schema changes in the staging environment. You can thoroughly
        /// test changes in the green environment. When ready, you can switch over the environments
        /// to promote the green environment to be the new production environment. The switchover
        /// typically takes under a minute.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/blue-green-deployments.html">Using
        /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon RDS User
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">
        /// Using Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon
        /// Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBlueGreenDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBlueGreenDeployment service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentAlreadyExistsException">
        /// A blue/green deployment with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <code>DBClusterParameterGroupName</code> doesn't refer to an existing DB cluster
        /// parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SourceClusterNotSupportedException">
        /// The source DB cluster isn't supported for a blue/green deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SourceDatabaseNotSupportedException">
        /// The source DB instance isn't supported for a blue/green deployment.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateBlueGreenDeployment">REST API Reference for CreateBlueGreenDeployment Operation</seealso>
        public virtual Task<CreateBlueGreenDeploymentResponse> CreateBlueGreenDeploymentAsync(CreateBlueGreenDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBlueGreenDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueGreenDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBlueGreenDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomDBEngineVersion

        internal virtual CreateCustomDBEngineVersionResponse CreateCustomDBEngineVersion(CreateCustomDBEngineVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomDBEngineVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomDBEngineVersionResponseUnmarshaller.Instance;

            return Invoke<CreateCustomDBEngineVersionResponse>(request, options);
        }



        /// <summary>
        /// Creates a custom DB engine version (CEV).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomDBEngineVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomDBEngineVersion service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CustomDBEngineVersionAlreadyExistsException">
        /// A CEV with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.CustomDBEngineVersionQuotaExceededException">
        /// You have exceeded your CEV quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.Ec2ImagePropertiesNotSupportedException">
        /// The AMI configuration prerequisite has not been met.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateCustomDBEngineVersion">REST API Reference for CreateCustomDBEngineVersion Operation</seealso>
        public virtual Task<CreateCustomDBEngineVersionResponse> CreateCustomDBEngineVersionAsync(CreateCustomDBEngineVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomDBEngineVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomDBEngineVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomDBEngineVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBCluster

        internal virtual CreateDBClusterResponse CreateDBCluster(CreateDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon Aurora DB cluster or Multi-AZ DB cluster.
        /// 
        ///  
        /// <para>
        /// You can use the <code>ReplicationSourceIdentifier</code> parameter to create an Amazon
        /// Aurora DB cluster as a read replica of another DB cluster or Amazon RDS MySQL or PostgreSQL
        /// DB instance.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <code>DBClusterParameterGroupName</code> doesn't refer to an existing DB cluster
        /// parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <code>GlobalClusterIdentifier</code> doesn't refer to an existing global database
        /// cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You might be able
        /// to resolve this error by updating your subnet group to use different Availability
        /// Zones that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual Task<CreateDBClusterResponse> CreateDBClusterAsync(CreateDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBClusterEndpoint

        internal virtual CreateDBClusterEndpointResponse CreateDBClusterEndpoint(CreateDBClusterEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterEndpointResponse>(request, options);
        }



        /// <summary>
        /// Creates a new custom endpoint and associates it with an Amazon Aurora DB cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This action applies only to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBClusterEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterEndpointAlreadyExistsException">
        /// The specified custom endpoint can't be created because it already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterEndpointQuotaExceededException">
        /// The cluster already has the maximum number of custom endpoints.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterEndpoint">REST API Reference for CreateDBClusterEndpoint Operation</seealso>
        public virtual Task<CreateDBClusterEndpointResponse> CreateDBClusterEndpointAsync(CreateDBClusterEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBClusterEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBClusterParameterGroup

        internal virtual CreateDBClusterParameterGroupResponse CreateDBClusterParameterGroup(CreateDBClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB cluster parameter group.
        /// 
        ///  
        /// <para>
        /// Parameters in a DB cluster parameter group apply to all of the instances in a DB cluster.
        /// </para>
        ///  
        /// <para>
        /// A DB cluster parameter group is initially created with the default parameters for
        /// the database engine used by instances in the DB cluster. To provide custom values
        /// for any of the parameters, you must modify the group after creating it using <code>ModifyDBClusterParameterGroup</code>.
        /// Once you've created a DB cluster parameter group, you need to associate it with your
        /// DB cluster using <code>ModifyDBCluster</code>.
        /// </para>
        ///  
        /// <para>
        /// When you associate a new DB cluster parameter group with a running Aurora DB cluster,
        /// reboot the DB instances in the DB cluster without failover for the new DB cluster
        /// parameter group and associated settings to take effect.
        /// </para>
        ///  
        /// <para>
        /// When you associate a new DB cluster parameter group with a running Multi-AZ DB cluster,
        /// reboot the DB cluster without failover for the new DB cluster parameter group and
        /// associated settings to take effect.
        /// </para>
        ///  <important> 
        /// <para>
        /// After you create a DB cluster parameter group, you should wait at least 5 minutes
        /// before creating your first DB cluster that uses that DB cluster parameter group as
        /// the default parameter group. This allows Amazon RDS to fully complete the create action
        /// before the DB cluster parameter group is used as the default for a new DB cluster.
        /// This is especially important for parameters that are critical when creating the default
        /// database for a DB cluster, such as the character set for the default database defined
        /// by the <code>character_set_database</code> parameter. You can use the <i>Parameter
        /// Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon RDS
        /// console</a> or the <code>DescribeDBClusterParameters</code> operation to verify that
        /// your DB cluster parameter group has been created or modified.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB parameter
        /// groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        public virtual Task<CreateDBClusterParameterGroupResponse> CreateDBClusterParameterGroupAsync(CreateDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBClusterSnapshot

        internal virtual CreateDBClusterSnapshotResponse CreateDBClusterSnapshot(CreateDBClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of a DB cluster.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotAlreadyExistsException">
        /// The user already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
        public virtual Task<CreateDBClusterSnapshotResponse> CreateDBClusterSnapshotAsync(CreateDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBInstance

        internal virtual CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB instance.
        /// 
        ///  
        /// <para>
        /// The new DB instance can be an RDS DB instance, or it can be a DB instance in an Aurora
        /// DB cluster. For an Aurora DB cluster, you can call this operation multiple times to
        /// add more than one DB instance to the cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating an RDS DB instance, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_CreateDBInstance.html">
        /// Creating an Amazon RDS DB instance</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating a DB instance in an Aurora DB cluster, see <a
        /// href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/Aurora.CreateInstance.html">
        /// Creating an Amazon Aurora DB cluster</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.BackupPolicyNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <code>IPV4</code>
        /// and <code>DUAL</code>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBInstanceReadReplica

        internal virtual CreateDBInstanceReadReplicaResponse CreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceReadReplicaResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB instance that acts as a read replica for an existing source DB instance.
        /// You can create a read replica for a DB instance running MySQL, MariaDB, Oracle, PostgreSQL,
        /// or SQL Server. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReadRepl.html">Working
        /// with Read Replicas</a> in the <i>Amazon RDS User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Amazon Aurora doesn't support this operation. Call the <code>CreateDBInstance</code>
        /// operation to create a DB instance for an Aurora DB cluster.
        /// </para>
        ///  
        /// <para>
        /// All read replica DB instances are created with backups disabled. All other DB instance
        /// attributes (including DB security groups and DB parameter groups) are inherited from
        /// the source DB instance, except as specified.
        /// </para>
        ///  <important> 
        /// <para>
        /// Your source DB instance must have backup retention enabled.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstanceReadReplica service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBInstanceReadReplica service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotAllowedException">
        /// The DBSubnetGroup shouldn't be specified while creating read replicas that lie in
        /// the same region as the source instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupException">
        /// The DBSubnetGroup doesn't belong to the same VPC as that of an existing cross-region
        /// read replica of the same source instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <code>IPV4</code>
        /// and <code>DUAL</code>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstanceReadReplica">REST API Reference for CreateDBInstanceReadReplica Operation</seealso>
        public virtual Task<CreateDBInstanceReadReplicaResponse> CreateDBInstanceReadReplicaAsync(CreateDBInstanceReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBInstanceReadReplicaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBParameterGroup

        internal virtual CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB parameter group.
        /// 
        ///  
        /// <para>
        /// A DB parameter group is initially created with the default parameters for the database
        /// engine used by the DB instance. To provide custom values for any of the parameters,
        /// you must modify the group after creating it using <code>ModifyDBParameterGroup</code>.
        /// Once you've created a DB parameter group, you need to associate it with your DB instance
        /// using <code>ModifyDBInstance</code>. When you associate a new DB parameter group with
        /// a running DB instance, you need to reboot the DB instance without failover for the
        /// new DB parameter group and associated settings to take effect.
        /// </para>
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        ///  <important> 
        /// <para>
        /// After you create a DB parameter group, you should wait at least 5 minutes before creating
        /// your first DB instance that uses that DB parameter group as the default parameter
        /// group. This allows Amazon RDS to fully complete the create action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <i>DescribeDBParameters</i> command to verify that your DB
        /// parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB parameter
        /// groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBParameterGroup">REST API Reference for CreateDBParameterGroup Operation</seealso>
        public virtual Task<CreateDBParameterGroupResponse> CreateDBParameterGroupAsync(CreateDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBProxy

        internal virtual CreateDBProxyResponse CreateDBProxy(CreateDBProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBProxyResponseUnmarshaller.Instance;

            return Invoke<CreateDBProxyResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBProxy service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyAlreadyExistsException">
        /// The specified proxy name must be unique for all proxies owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyQuotaExceededException">
        /// Your Amazon Web Services account already has the maximum number of proxies in the
        /// specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBProxy">REST API Reference for CreateDBProxy Operation</seealso>
        public virtual Task<CreateDBProxyResponse> CreateDBProxyAsync(CreateDBProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBProxyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBProxyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBProxyEndpoint

        internal virtual CreateDBProxyEndpointResponse CreateDBProxyEndpoint(CreateDBProxyEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBProxyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBProxyEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateDBProxyEndpointResponse>(request, options);
        }



        /// <summary>
        /// Creates a <code>DBProxyEndpoint</code>. Only applies to proxies that are associated
        /// with Aurora DB clusters. You can use DB proxy endpoints to specify read/write or read-only
        /// access to the DB cluster. You can also use DB proxy endpoints to access a DB proxy
        /// through a different VPC than the proxy's default VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBProxyEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBProxyEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyEndpointAlreadyExistsException">
        /// The specified DB proxy endpoint name must be unique for all DB proxy endpoints owned
        /// by your Amazon Web Services account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyEndpointQuotaExceededException">
        /// The DB proxy already has the maximum number of endpoints.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBProxyEndpoint">REST API Reference for CreateDBProxyEndpoint Operation</seealso>
        public virtual Task<CreateDBProxyEndpointResponse> CreateDBProxyEndpointAsync(CreateDBProxyEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBProxyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBProxyEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBProxyEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSecurityGroup

        internal virtual CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBSecurityGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB security group. DB security groups control access to a DB instance.
        /// 
        ///  
        /// <para>
        /// A DB security group controls access to EC2-Classic DB instances that are not in a
        /// VPC.
        /// </para>
        ///  <note> 
        /// <para>
        /// EC2-Classic was retired on August 15, 2022. If you haven't migrated from EC2-Classic
        /// to a VPC, we recommend that you migrate as soon as possible. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-migrate.html">Migrate
        /// from EC2-Classic to a VPC</a> in the <i>Amazon EC2 User Guide</i>, the blog <a href="http://aws.amazon.com/blogs/aws/ec2-classic-is-retiring-heres-how-to-prepare/">EC2-Classic
        /// Networking is Retiring – Here’s How to Prepare</a>, and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.Non-VPC2VPC.html">Moving
        /// a DB instance not in a VPC into a VPC</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBSecurityGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupAlreadyExistsException">
        /// A DB security group with the name specified in <code>DBSecurityGroupName</code> already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotSupportedException">
        /// A DB security group isn't allowed for this action.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB security groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSecurityGroup">REST API Reference for CreateDBSecurityGroup Operation</seealso>
        public virtual Task<CreateDBSecurityGroupResponse> CreateDBSecurityGroupAsync(CreateDBSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSnapshot

        internal virtual CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDBSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of a DB instance. The source DB instance must be in the <code>available</code>
        /// or <code>storage-optimization</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <code>DBSnapshotIdentifier</code> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSnapshot">REST API Reference for CreateDBSnapshot Operation</seealso>
        public virtual Task<CreateDBSnapshotResponse> CreateDBSnapshotAsync(CreateDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSubnetGroup

        internal virtual CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB subnet group. DB subnet groups must contain at least one subnet in
        /// at least two AZs in the Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupAlreadyExistsException">
        /// <code>DBSubnetGroupName</code> is already used by an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB subnet groups.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of subnets in a
        /// DB subnet groups.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
        public virtual Task<CreateDBSubnetGroupResponse> CreateDBSubnetGroupAsync(CreateDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEventSubscription

        internal virtual CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Creates an RDS event notification subscription. This operation requires a topic Amazon
        /// Resource Name (ARN) created by either the RDS console, the SNS console, or the SNS
        /// API. To obtain an ARN with SNS, you must create a topic in Amazon SNS and subscribe
        /// to the topic. The ARN is displayed in the SNS console.
        /// 
        ///  
        /// <para>
        /// You can specify the type of source (<code>SourceType</code>) that you want to be notified
        /// of and provide a list of RDS sources (<code>SourceIds</code>) that triggers the events.
        /// You can also provide a list of event categories (<code>EventCategories</code>) for
        /// events that you want to be notified of. For example, you can specify <code>SourceType</code>
        /// = <code>db-instance</code>, <code>SourceIds</code> = <code>mydbinstance1</code>, <code>mydbinstance2</code>
        /// and <code>EventCategories</code> = <code>Availability</code>, <code>Backup</code>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the <code>SourceType</code> and <code>SourceIds</code>, such as
        /// <code>SourceType</code> = <code>db-instance</code> and <code>SourceIds</code> = <code>myDBInstance1</code>,
        /// you are notified of all the <code>db-instance</code> events for the specified source.
        /// If you specify a <code>SourceType</code> but do not specify <code>SourceIds</code>,
        /// you receive notice of the events for that source type for all your RDS sources. If
        /// you don't specify either the SourceType or the <code>SourceIds</code>, you are notified
        /// of events generated from all RDS sources belonging to your customer account.
        /// </para>
        ///  
        /// <para>
        /// For more information about subscribing to an event for RDS DB engines, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.Subscribing.html">
        /// Subscribing to Amazon RDS event notification</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about subscribing to an event for Aurora DB engines, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Events.Subscribing.html">
        /// Subscribing to Amazon RDS event notification</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.EventSubscriptionQuotaExceededException">
        /// You have reached the maximum number of event subscriptions.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSInvalidTopicException">
        /// SNS has responded that there is a problem with the SNS topic specified.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the SNS topic ARN.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSTopicArnNotFoundException">
        /// The SNS topic ARN does not exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionAlreadyExistException">
        /// The supplied subscription name already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionCategoryNotFoundException">
        /// The supplied category does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGlobalCluster

        internal virtual CreateGlobalClusterResponse CreateGlobalCluster(CreateGlobalClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<CreateGlobalClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates an Aurora global database spread across multiple Amazon Web Services Regions.
        /// The global database contains a single primary cluster with read-write capability,
        /// and a read-only secondary cluster that receives data from the primary cluster through
        /// high-speed replication performed by the Aurora storage subsystem.
        /// 
        ///  
        /// <para>
        /// You can create a global database that is initially empty, and then add a primary cluster
        /// and a secondary cluster to it. Or you can specify an existing Aurora cluster during
        /// the create operation, and this cluster becomes the primary cluster of the global database.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action applies only to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterAlreadyExistsException">
        /// The <code>GlobalClusterIdentifier</code> already exists. Choose a new global database
        /// identifier (unique name) to create a new global database cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterQuotaExceededException">
        /// The number of global database clusters for this account is already at the maximum
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateGlobalCluster">REST API Reference for CreateGlobalCluster Operation</seealso>
        public virtual Task<CreateGlobalClusterResponse> CreateGlobalClusterAsync(CreateGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGlobalClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOptionGroup

        internal virtual CreateOptionGroupResponse CreateOptionGroup(CreateOptionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOptionGroupResponseUnmarshaller.Instance;

            return Invoke<CreateOptionGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new option group. You can create up to 20 option groups.
        /// 
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOptionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupAlreadyExistsException">
        /// The option group you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupQuotaExceededException">
        /// The quota of 20 option groups was exceeded for this Amazon Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateOptionGroup">REST API Reference for CreateOptionGroup Operation</seealso>
        public virtual Task<CreateOptionGroupResponse> CreateOptionGroupAsync(CreateOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOptionGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBlueGreenDeployment

        internal virtual DeleteBlueGreenDeploymentResponse DeleteBlueGreenDeployment(DeleteBlueGreenDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBlueGreenDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBlueGreenDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteBlueGreenDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Deletes a blue/green deployment.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/blue-green-deployments.html">Using
        /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon RDS User
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">
        /// Using Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon
        /// Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBlueGreenDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBlueGreenDeployment service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <code>BlueGreenDeploymentIdentifier</code> doesn't refer to an existing blue/green
        /// deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidBlueGreenDeploymentStateException">
        /// The blue/green deployment can't be switched over or deleted because there is an invalid
        /// configuration in the green environment.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteBlueGreenDeployment">REST API Reference for DeleteBlueGreenDeployment Operation</seealso>
        public virtual Task<DeleteBlueGreenDeploymentResponse> DeleteBlueGreenDeploymentAsync(DeleteBlueGreenDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBlueGreenDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBlueGreenDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBlueGreenDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomDBEngineVersion

        internal virtual DeleteCustomDBEngineVersionResponse DeleteCustomDBEngineVersion(DeleteCustomDBEngineVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomDBEngineVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomDBEngineVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomDBEngineVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom engine version. To run this command, make sure you meet the following
        /// prerequisites:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The CEV must not be the default for RDS Custom. If it is, change the default before
        /// running this command.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The CEV must not be associated with an RDS Custom DB instance, RDS Custom instance
        /// snapshot, or automated backup of your RDS Custom instance.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Typically, deletion takes a few minutes.
        /// </para>
        ///  <note> 
        /// <para>
        /// The MediaImport service that imports files from Amazon S3 to create CEVs isn't integrated
        /// with Amazon Web Services CloudTrail. If you turn on data logging for Amazon RDS in
        /// CloudTrail, calls to the <code>DeleteCustomDbEngineVersion</code> event aren't logged.
        /// However, you might see calls from the API gateway that accesses your Amazon S3 bucket.
        /// These calls originate from the MediaImport service for the <code>DeleteCustomDbEngineVersion</code>
        /// event.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-cev.html#custom-cev.delete">
        /// Deleting a CEV</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomDBEngineVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomDBEngineVersion service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CustomDBEngineVersionNotFoundException">
        /// The specified CEV was not found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidCustomDBEngineVersionStateException">
        /// You can't delete the CEV.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteCustomDBEngineVersion">REST API Reference for DeleteCustomDBEngineVersion Operation</seealso>
        public virtual Task<DeleteCustomDBEngineVersionResponse> DeleteCustomDBEngineVersionAsync(DeleteCustomDBEngineVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomDBEngineVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomDBEngineVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomDBEngineVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBCluster

        internal virtual DeleteDBClusterResponse DeleteDBCluster(DeleteDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterResponse>(request, options);
        }



        /// <summary>
        /// The DeleteDBCluster action deletes a previously provisioned DB cluster. When you delete
        /// a DB cluster, all automated backups for that DB cluster are deleted and can't be recovered.
        /// Manual DB cluster snapshots of the specified DB cluster are not deleted.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotAlreadyExistsException">
        /// The user already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual Task<DeleteDBClusterResponse> DeleteDBClusterAsync(DeleteDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBClusterEndpoint

        internal virtual DeleteDBClusterEndpointResponse DeleteDBClusterEndpoint(DeleteDBClusterEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterEndpointResponse>(request, options);
        }



        /// <summary>
        /// Deletes a custom endpoint and removes it from an Amazon Aurora DB cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBClusterEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterEndpointNotFoundException">
        /// The specified custom endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterEndpointStateException">
        /// The requested operation can't be performed on the endpoint while the endpoint is in
        /// this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterEndpoint">REST API Reference for DeleteDBClusterEndpoint Operation</seealso>
        public virtual Task<DeleteDBClusterEndpointResponse> DeleteDBClusterEndpointAsync(DeleteDBClusterEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBClusterEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBClusterParameterGroup

        internal virtual DeleteDBClusterParameterGroupResponse DeleteDBClusterParameterGroup(DeleteDBClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specified DB cluster parameter group. The DB cluster parameter group to
        /// be deleted can't be associated with any DB clusters.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        public virtual Task<DeleteDBClusterParameterGroupResponse> DeleteDBClusterParameterGroupAsync(DeleteDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBClusterSnapshot

        internal virtual DeleteDBClusterSnapshotResponse DeleteDBClusterSnapshot(DeleteDBClusterSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes a DB cluster snapshot. If the snapshot is being copied, the copy operation
        /// is terminated.
        /// 
        ///  <note> 
        /// <para>
        /// The DB cluster snapshot must be in the <code>available</code> state to be deleted.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        public virtual Task<DeleteDBClusterSnapshotResponse> DeleteDBClusterSnapshotAsync(DeleteDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBInstance

        internal virtual DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteDBInstanceResponse>(request, options);
        }



        /// <summary>
        /// The DeleteDBInstance action deletes a previously provisioned DB instance. When you
        /// delete a DB instance, all automated backups for that instance are deleted and can't
        /// be recovered. Manual DB snapshots of the DB instance to be deleted by <code>DeleteDBInstance</code>
        /// are not deleted.
        /// 
        ///  
        /// <para>
        /// If you request a final DB snapshot the status of the Amazon RDS DB instance is <code>deleting</code>
        /// until the DB snapshot is created. The API action <code>DescribeDBInstance</code> is
        /// used to monitor the status of this operation. The action can't be canceled or reverted
        /// once submitted.
        /// </para>
        ///  
        /// <para>
        /// When a DB instance is in a failure state and has a status of <code>failed</code>,
        /// <code>incompatible-restore</code>, or <code>incompatible-network</code>, you can only
        /// delete it when you skip creation of the final snapshot with the <code>SkipFinalSnapshot</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// If the specified DB instance is part of an Amazon Aurora DB cluster, you can't delete
        /// the DB instance if both of the following conditions are true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The DB cluster is a read replica of another Amazon Aurora DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The DB instance is the only instance in the DB cluster.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To delete a DB instance in this case, first call the <code>PromoteReadReplicaDBCluster</code>
        /// API action to promote the DB cluster so it's no longer a read replica. After the promotion
        /// completes, then call the <code>DeleteDBInstance</code> API action to delete the final
        /// instance in the DB cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupQuotaExceededException">
        /// The quota for retained automated backups was exceeded. This prevents you from retaining
        /// any additional automated backups. The retained automated backups quota is the same
        /// as your DB Instance quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <code>DBSnapshotIdentifier</code> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBInstanceAutomatedBackup

        internal virtual DeleteDBInstanceAutomatedBackupResponse DeleteDBInstanceAutomatedBackup(DeleteDBInstanceAutomatedBackupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceAutomatedBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceAutomatedBackupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBInstanceAutomatedBackupResponse>(request, options);
        }



        /// <summary>
        /// Deletes automated backups using the <code>DbiResourceId</code> value of the source
        /// DB instance or the Amazon Resource Name (ARN) of the automated backups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstanceAutomatedBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBInstanceAutomatedBackup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupNotFoundException">
        /// No automated backup for this DB instance was found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceAutomatedBackupStateException">
        /// The automated backup is in an invalid state. For example, this automated backup is
        /// associated with an active instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBInstanceAutomatedBackup">REST API Reference for DeleteDBInstanceAutomatedBackup Operation</seealso>
        public virtual Task<DeleteDBInstanceAutomatedBackupResponse> DeleteDBInstanceAutomatedBackupAsync(DeleteDBInstanceAutomatedBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceAutomatedBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceAutomatedBackupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBInstanceAutomatedBackupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBParameterGroup

        internal virtual DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specified DB parameter group. The DB parameter group to be deleted can't
        /// be associated with any DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBParameterGroup">REST API Reference for DeleteDBParameterGroup Operation</seealso>
        public virtual Task<DeleteDBParameterGroupResponse> DeleteDBParameterGroupAsync(DeleteDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBProxy

        internal virtual DeleteDBProxyResponse DeleteDBProxy(DeleteDBProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBProxyResponseUnmarshaller.Instance;

            return Invoke<DeleteDBProxyResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing DB proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBProxy service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBProxy">REST API Reference for DeleteDBProxy Operation</seealso>
        public virtual Task<DeleteDBProxyResponse> DeleteDBProxyAsync(DeleteDBProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBProxyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBProxyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBProxyEndpoint

        internal virtual DeleteDBProxyEndpointResponse DeleteDBProxyEndpoint(DeleteDBProxyEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBProxyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBProxyEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteDBProxyEndpointResponse>(request, options);
        }



        /// <summary>
        /// Deletes a <code>DBProxyEndpoint</code>. Doing so removes the ability to access the
        /// DB proxy using the endpoint that you defined. The endpoint that you delete might have
        /// provided capabilities such as read/write or read-only operations, or using a different
        /// VPC than the DB proxy's default VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBProxyEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBProxyEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyEndpointNotFoundException">
        /// The DB proxy endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyEndpointStateException">
        /// You can't perform this operation while the DB proxy endpoint is in a particular state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBProxyEndpoint">REST API Reference for DeleteDBProxyEndpoint Operation</seealso>
        public virtual Task<DeleteDBProxyEndpointResponse> DeleteDBProxyEndpointAsync(DeleteDBProxyEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBProxyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBProxyEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBProxyEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSecurityGroup

        internal virtual DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSecurityGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a DB security group.
        /// 
        ///  
        /// <para>
        /// The specified DB security group must not be associated with any DB instances.
        /// </para>
        ///  <note> 
        /// <para>
        /// EC2-Classic was retired on August 15, 2022. If you haven't migrated from EC2-Classic
        /// to a VPC, we recommend that you migrate as soon as possible. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-migrate.html">Migrate
        /// from EC2-Classic to a VPC</a> in the <i>Amazon EC2 User Guide</i>, the blog <a href="http://aws.amazon.com/blogs/aws/ec2-classic-is-retiring-heres-how-to-prepare/">EC2-Classic
        /// Networking is Retiring – Here’s How to Prepare</a>, and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.Non-VPC2VPC.html">Moving
        /// a DB instance not in a VPC into a VPC</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBSecurityGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSecurityGroup">REST API Reference for DeleteDBSecurityGroup Operation</seealso>
        public virtual Task<DeleteDBSecurityGroupResponse> DeleteDBSecurityGroupAsync(DeleteDBSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSnapshot

        internal virtual DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes a DB snapshot. If the snapshot is being copied, the copy operation is terminated.
        /// 
        ///  <note> 
        /// <para>
        /// The DB snapshot must be in the <code>available</code> state to be deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSnapshot">REST API Reference for DeleteDBSnapshot Operation</seealso>
        public virtual Task<DeleteDBSnapshotResponse> DeleteDBSnapshotAsync(DeleteDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSubnetGroup

        internal virtual DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a DB subnet group.
        /// 
        ///  <note> 
        /// <para>
        /// The specified database subnet group must not be associated with any DB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetStateException">
        /// The DB subnet isn't in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        public virtual Task<DeleteDBSubnetGroupResponse> DeleteDBSubnetGroupAsync(DeleteDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventSubscription

        internal virtual DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidEventSubscriptionStateException">
        /// This error can occur if someone else is modifying a subscription. You should retry
        /// the action.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGlobalCluster

        internal virtual DeleteGlobalClusterResponse DeleteGlobalCluster(DeleteGlobalClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteGlobalClusterResponse>(request, options);
        }



        /// <summary>
        /// Deletes a global database cluster. The primary and secondary clusters must already
        /// be detached or destroyed first.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <code>GlobalClusterIdentifier</code> doesn't refer to an existing global database
        /// cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteGlobalCluster">REST API Reference for DeleteGlobalCluster Operation</seealso>
        public virtual Task<DeleteGlobalClusterResponse> DeleteGlobalClusterAsync(DeleteGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGlobalClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOptionGroup

        internal virtual DeleteOptionGroupResponse DeleteOptionGroup(DeleteOptionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOptionGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteOptionGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidOptionGroupStateException">
        /// The option group isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteOptionGroup">REST API Reference for DeleteOptionGroup Operation</seealso>
        public virtual Task<DeleteOptionGroupResponse> DeleteOptionGroupAsync(DeleteOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOptionGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterDBProxyTargets

        internal virtual DeregisterDBProxyTargetsResponse DeregisterDBProxyTargets(DeregisterDBProxyTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterDBProxyTargetsResponseUnmarshaller.Instance;

            return Invoke<DeregisterDBProxyTargetsResponse>(request, options);
        }



        /// <summary>
        /// Remove the association between one or more <code>DBProxyTarget</code> data structures
        /// and a <code>DBProxyTargetGroup</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterDBProxyTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterDBProxyTargets service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetNotFoundException">
        /// The specified RDS DB instance or Aurora DB cluster isn't available for a proxy owned
        /// by your Amazon Web Services account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeregisterDBProxyTargets">REST API Reference for DeregisterDBProxyTargets Operation</seealso>
        public virtual Task<DeregisterDBProxyTargetsResponse> DeregisterDBProxyTargetsAsync(DeregisterDBProxyTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterDBProxyTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterDBProxyTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes()
        {
            return DescribeAccountAttributes(new DescribeAccountAttributesRequest());
        }
        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesResponse>(request, options);
        }


        /// <summary>
        /// Lists all of the attributes for a customer account. The attributes include Amazon
        /// RDS quotas for the account, such as the number of DB instances allowed. The description
        /// for a quota includes the quota name, current usage toward that quota, and the quota's
        /// maximum value.
        /// 
        ///  
        /// <para>
        /// This command doesn't take any parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAccountAttributesAsync(new DescribeAccountAttributesRequest(), cancellationToken);
        }



        /// <summary>
        /// Lists all of the attributes for a customer account. The attributes include Amazon
        /// RDS quotas for the account, such as the number of DB instances allowed. The description
        /// for a quota includes the quota name, current usage toward that quota, and the quota's
        /// maximum value.
        /// 
        ///  
        /// <para>
        /// This command doesn't take any parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBlueGreenDeployments

        internal virtual DescribeBlueGreenDeploymentsResponse DescribeBlueGreenDeployments(DescribeBlueGreenDeploymentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBlueGreenDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBlueGreenDeploymentsResponseUnmarshaller.Instance;

            return Invoke<DescribeBlueGreenDeploymentsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about blue/green deployments.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/blue-green-deployments.html">Using
        /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon RDS User
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">
        /// Using Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon
        /// Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBlueGreenDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBlueGreenDeployments service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <code>BlueGreenDeploymentIdentifier</code> doesn't refer to an existing blue/green
        /// deployment.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeBlueGreenDeployments">REST API Reference for DescribeBlueGreenDeployments Operation</seealso>
        public virtual Task<DescribeBlueGreenDeploymentsResponse> DescribeBlueGreenDeploymentsAsync(DescribeBlueGreenDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBlueGreenDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBlueGreenDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBlueGreenDeploymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCertificates

        internal virtual DescribeCertificatesResponse DescribeCertificates(DescribeCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificatesResponse>(request, options);
        }



        /// <summary>
        /// Lists the set of CA certificates provided by Amazon RDS for this Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificates service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <code>CertificateIdentifier</code> doesn't refer to an existing certificate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual Task<DescribeCertificatesResponse> DescribeCertificatesAsync(DescribeCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterBacktracks

        internal virtual DescribeDBClusterBacktracksResponse DescribeDBClusterBacktracks(DescribeDBClusterBacktracksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterBacktracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterBacktracksResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterBacktracksResponse>(request, options);
        }



        /// <summary>
        /// Returns information about backtracks for a DB cluster.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora MySQL DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterBacktracks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterBacktracks service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterBacktrackNotFoundException">
        /// <code>BacktrackIdentifier</code> doesn't refer to an existing backtrack.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterBacktracks">REST API Reference for DescribeDBClusterBacktracks Operation</seealso>
        public virtual Task<DescribeDBClusterBacktracksResponse> DescribeDBClusterBacktracksAsync(DescribeDBClusterBacktracksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterBacktracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterBacktracksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterBacktracksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterEndpoints

        internal virtual DescribeDBClusterEndpointsResponse DescribeDBClusterEndpoints(DescribeDBClusterEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about endpoints for an Amazon Aurora DB cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterEndpoints service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterEndpoints">REST API Reference for DescribeDBClusterEndpoints Operation</seealso>
        public virtual Task<DescribeDBClusterEndpointsResponse> DescribeDBClusterEndpointsAsync(DescribeDBClusterEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterParameterGroups

        internal virtual DescribeDBClusterParameterGroupsResponse DescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterParameterGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of <code>DBClusterParameterGroup</code> descriptions. If a <code>DBClusterParameterGroupName</code>
        /// parameter is specified, the list will contain only the description of the specified
        /// DB cluster parameter group.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual Task<DescribeDBClusterParameterGroupsResponse> DescribeDBClusterParameterGroupsAsync(DescribeDBClusterParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterParameterGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterParameters

        internal virtual DescribeDBClusterParametersResponse DescribeDBClusterParameters(DescribeDBClusterParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns the detailed parameter list for a particular DB cluster parameter group.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual Task<DescribeDBClusterParametersResponse> DescribeDBClusterParametersAsync(DescribeDBClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusters

        internal virtual DescribeDBClustersResponse DescribeDBClusters(DescribeDBClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClustersResponse>(request, options);
        }



        /// <summary>
        /// Returns information about Amazon Aurora DB clusters and Multi-AZ DB clusters. This
        /// API supports pagination.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation can also return information for Amazon Neptune DB instances and Amazon
        /// DocumentDB instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        public virtual Task<DescribeDBClustersResponse> DescribeDBClustersAsync(DescribeDBClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterSnapshotAttributes

        internal virtual DescribeDBClusterSnapshotAttributesResponse DescribeDBClusterSnapshotAttributes(DescribeDBClusterSnapshotAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterSnapshotAttributesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of DB cluster snapshot attribute names and values for a manual DB cluster
        /// snapshot.
        /// 
        ///  
        /// <para>
        /// When sharing snapshots with other Amazon Web Services accounts, <code>DescribeDBClusterSnapshotAttributes</code>
        /// returns the <code>restore</code> attribute and a list of IDs for the Amazon Web Services
        /// accounts that are authorized to copy or restore the manual DB cluster snapshot. If
        /// <code>all</code> is included in the list of values for the <code>restore</code> attribute,
        /// then the manual DB cluster snapshot is public and can be copied or restored by all
        /// Amazon Web Services accounts.
        /// </para>
        ///  
        /// <para>
        /// To add or remove access for an Amazon Web Services account to copy or restore a manual
        /// DB cluster snapshot, or to make the manual DB cluster snapshot public or private,
        /// use the <code>ModifyDBClusterSnapshotAttribute</code> API action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshotAttributes service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual Task<DescribeDBClusterSnapshotAttributesResponse> DescribeDBClusterSnapshotAttributesAsync(DescribeDBClusterSnapshotAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterSnapshotAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterSnapshots

        internal virtual DescribeDBClusterSnapshotsResponse DescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about DB cluster snapshots. This API action supports pagination.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual Task<DescribeDBClusterSnapshotsResponse> DescribeDBClusterSnapshotsAsync(DescribeDBClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBEngineVersions

        internal virtual DescribeDBEngineVersionsResponse DescribeDBEngineVersions()
        {
            return DescribeDBEngineVersions(new DescribeDBEngineVersionsRequest());
        }
        internal virtual DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBEngineVersionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the available DB engines.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBEngineVersionsAsync(new DescribeDBEngineVersionsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns a list of the available DB engines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(DescribeDBEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBEngineVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBInstanceAutomatedBackups

        internal virtual DescribeDBInstanceAutomatedBackupsResponse DescribeDBInstanceAutomatedBackups(DescribeDBInstanceAutomatedBackupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBInstanceAutomatedBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstanceAutomatedBackupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBInstanceAutomatedBackupsResponse>(request, options);
        }



        /// <summary>
        /// Displays backups for both current and deleted instances. For example, use this operation
        /// to find details about automated backups for previously deleted instances. Current
        /// instances with retention periods greater than zero (0) are returned for both the <code>DescribeDBInstanceAutomatedBackups</code>
        /// and <code>DescribeDBInstances</code> operations.
        /// 
        ///  
        /// <para>
        /// All parameters are optional.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstanceAutomatedBackups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBInstanceAutomatedBackups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupNotFoundException">
        /// No automated backup for this DB instance was found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstanceAutomatedBackups">REST API Reference for DescribeDBInstanceAutomatedBackups Operation</seealso>
        public virtual Task<DescribeDBInstanceAutomatedBackupsResponse> DescribeDBInstanceAutomatedBackupsAsync(DescribeDBInstanceAutomatedBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBInstanceAutomatedBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstanceAutomatedBackupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBInstanceAutomatedBackupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBInstances

        internal virtual DescribeDBInstancesResponse DescribeDBInstances()
        {
            return DescribeDBInstances(new DescribeDBInstancesRequest());
        }
        internal virtual DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBInstancesResponse>(request, options);
        }


        /// <summary>
        /// Returns information about provisioned RDS instances. This API supports pagination.
        /// 
        ///  <note> 
        /// <para>
        /// This operation can also return information for Amazon Neptune DB instances and Amazon
        /// DocumentDB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBInstancesAsync(new DescribeDBInstancesRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns information about provisioned RDS instances. This API supports pagination.
        /// 
        ///  <note> 
        /// <para>
        /// This operation can also return information for Amazon Neptune DB instances and Amazon
        /// DocumentDB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBLogFiles

        internal virtual DescribeDBLogFilesResponse DescribeDBLogFiles(DescribeDBLogFilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBLogFilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBLogFilesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBLogFilesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of DB log files for the DB instance.
        /// 
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBLogFiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBLogFiles service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBLogFiles">REST API Reference for DescribeDBLogFiles Operation</seealso>
        public virtual Task<DescribeDBLogFilesResponse> DescribeDBLogFilesAsync(DescribeDBLogFilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBLogFilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBLogFilesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBLogFilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBParameterGroups

        internal virtual DescribeDBParameterGroupsResponse DescribeDBParameterGroups()
        {
            return DescribeDBParameterGroups(new DescribeDBParameterGroupsRequest());
        }
        internal virtual DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParameterGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of <code>DBParameterGroup</code> descriptions. If a <code>DBParameterGroupName</code>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBParameterGroupsAsync(new DescribeDBParameterGroupsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns a list of <code>DBParameterGroup</code> descriptions. If a <code>DBParameterGroupName</code>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(DescribeDBParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBParameterGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBParameters

        internal virtual DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns the detailed parameter list for a particular DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBParameters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameters">REST API Reference for DescribeDBParameters Operation</seealso>
        public virtual Task<DescribeDBParametersResponse> DescribeDBParametersAsync(DescribeDBParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBProxies

        internal virtual DescribeDBProxiesResponse DescribeDBProxies(DescribeDBProxiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxiesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBProxiesResponse>(request, options);
        }



        /// <summary>
        /// Returns information about DB proxies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBProxies service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxies">REST API Reference for DescribeDBProxies Operation</seealso>
        public virtual Task<DescribeDBProxiesResponse> DescribeDBProxiesAsync(DescribeDBProxiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxiesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBProxiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBProxyEndpoints

        internal virtual DescribeDBProxyEndpointsResponse DescribeDBProxyEndpoints(DescribeDBProxyEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBProxyEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about DB proxy endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxyEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBProxyEndpoints service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyEndpointNotFoundException">
        /// The DB proxy endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxyEndpoints">REST API Reference for DescribeDBProxyEndpoints Operation</seealso>
        public virtual Task<DescribeDBProxyEndpointsResponse> DescribeDBProxyEndpointsAsync(DescribeDBProxyEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBProxyEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBProxyTargetGroups

        internal virtual DescribeDBProxyTargetGroupsResponse DescribeDBProxyTargetGroups(DescribeDBProxyTargetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBProxyTargetGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about DB proxy target groups, represented by <code>DBProxyTargetGroup</code>
        /// data structures.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxyTargetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBProxyTargetGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxyTargetGroups">REST API Reference for DescribeDBProxyTargetGroups Operation</seealso>
        public virtual Task<DescribeDBProxyTargetGroupsResponse> DescribeDBProxyTargetGroupsAsync(DescribeDBProxyTargetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyTargetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBProxyTargetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBProxyTargets

        internal virtual DescribeDBProxyTargetsResponse DescribeDBProxyTargets(DescribeDBProxyTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBProxyTargetsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about <code>DBProxyTarget</code> objects. This API supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxyTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBProxyTargets service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetNotFoundException">
        /// The specified RDS DB instance or Aurora DB cluster isn't available for a proxy owned
        /// by your Amazon Web Services account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxyTargets">REST API Reference for DescribeDBProxyTargets Operation</seealso>
        public virtual Task<DescribeDBProxyTargetsResponse> DescribeDBProxyTargetsAsync(DescribeDBProxyTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBProxyTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSecurityGroups

        internal virtual DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups()
        {
            return DescribeDBSecurityGroups(new DescribeDBSecurityGroupsRequest());
        }
        internal virtual DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSecurityGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of <code>DBSecurityGroup</code> descriptions. If a <code>DBSecurityGroupName</code>
        /// is specified, the list will contain only the descriptions of the specified DB security
        /// group.
        /// 
        ///  <note> 
        /// <para>
        /// EC2-Classic was retired on August 15, 2022. If you haven't migrated from EC2-Classic
        /// to a VPC, we recommend that you migrate as soon as possible. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-migrate.html">Migrate
        /// from EC2-Classic to a VPC</a> in the <i>Amazon EC2 User Guide</i>, the blog <a href="http://aws.amazon.com/blogs/aws/ec2-classic-is-retiring-heres-how-to-prepare/">EC2-Classic
        /// Networking is Retiring – Here’s How to Prepare</a>, and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.Non-VPC2VPC.html">Moving
        /// a DB instance not in a VPC into a VPC</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSecurityGroups">REST API Reference for DescribeDBSecurityGroups Operation</seealso>
        public virtual Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBSecurityGroupsAsync(new DescribeDBSecurityGroupsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns a list of <code>DBSecurityGroup</code> descriptions. If a <code>DBSecurityGroupName</code>
        /// is specified, the list will contain only the descriptions of the specified DB security
        /// group.
        /// 
        ///  <note> 
        /// <para>
        /// EC2-Classic was retired on August 15, 2022. If you haven't migrated from EC2-Classic
        /// to a VPC, we recommend that you migrate as soon as possible. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-migrate.html">Migrate
        /// from EC2-Classic to a VPC</a> in the <i>Amazon EC2 User Guide</i>, the blog <a href="http://aws.amazon.com/blogs/aws/ec2-classic-is-retiring-heres-how-to-prepare/">EC2-Classic
        /// Networking is Retiring – Here’s How to Prepare</a>, and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.Non-VPC2VPC.html">Moving
        /// a DB instance not in a VPC into a VPC</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSecurityGroups">REST API Reference for DescribeDBSecurityGroups Operation</seealso>
        public virtual Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(DescribeDBSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSecurityGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSnapshotAttributes

        internal virtual DescribeDBSnapshotAttributesResponse DescribeDBSnapshotAttributes(DescribeDBSnapshotAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSnapshotAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSnapshotAttributesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of DB snapshot attribute names and values for a manual DB snapshot.
        /// 
        ///  
        /// <para>
        /// When sharing snapshots with other Amazon Web Services accounts, <code>DescribeDBSnapshotAttributes</code>
        /// returns the <code>restore</code> attribute and a list of IDs for the Amazon Web Services
        /// accounts that are authorized to copy or restore the manual DB snapshot. If <code>all</code>
        /// is included in the list of values for the <code>restore</code> attribute, then the
        /// manual DB snapshot is public and can be copied or restored by all Amazon Web Services
        /// accounts.
        /// </para>
        ///  
        /// <para>
        /// To add or remove access for an Amazon Web Services account to copy or restore a manual
        /// DB snapshot, or to make the manual DB snapshot public or private, use the <code>ModifyDBSnapshotAttribute</code>
        /// API action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshotAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSnapshotAttributes service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshotAttributes">REST API Reference for DescribeDBSnapshotAttributes Operation</seealso>
        public virtual Task<DescribeDBSnapshotAttributesResponse> DescribeDBSnapshotAttributesAsync(DescribeDBSnapshotAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSnapshotAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSnapshotAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSnapshots

        internal virtual DescribeDBSnapshotsResponse DescribeDBSnapshots()
        {
            return DescribeDBSnapshots(new DescribeDBSnapshotsRequest());
        }
        internal virtual DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSnapshotsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about DB snapshots. This API action supports pagination.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshots">REST API Reference for DescribeDBSnapshots Operation</seealso>
        public virtual Task<DescribeDBSnapshotsResponse> DescribeDBSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBSnapshotsAsync(new DescribeDBSnapshotsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns information about DB snapshots. This API action supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshots">REST API Reference for DescribeDBSnapshots Operation</seealso>
        public virtual Task<DescribeDBSnapshotsResponse> DescribeDBSnapshotsAsync(DescribeDBSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSubnetGroups

        internal virtual DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups()
        {
            return DescribeDBSubnetGroups(new DescribeDBSubnetGroupsRequest());
        }
        internal virtual DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSubnetGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified,
        /// the list will contain only the descriptions of the specified DBSubnetGroup.
        /// 
        ///  
        /// <para>
        /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
        /// Tutorial</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBSubnetGroupsAsync(new DescribeDBSubnetGroupsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns a list of DBSubnetGroup descriptions. If a DBSubnetGroupName is specified,
        /// the list will contain only the descriptions of the specified DBSubnetGroup.
        /// 
        ///  
        /// <para>
        /// For an overview of CIDR ranges, go to the <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Wikipedia
        /// Tutorial</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(DescribeDBSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDBSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSubnetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEngineDefaultClusterParameters

        internal virtual DescribeEngineDefaultClusterParametersResponse DescribeEngineDefaultClusterParameters(DescribeEngineDefaultClusterParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultClusterParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns the default engine and system parameter information for the cluster database
        /// engine.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultClusterParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultClusterParameters service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        public virtual Task<DescribeEngineDefaultClusterParametersResponse> DescribeEngineDefaultClusterParametersAsync(DescribeEngineDefaultClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEngineDefaultClusterParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEngineDefaultParameters

        internal virtual DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns the default engine and system parameter information for the specified database
        /// engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        public virtual Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEngineDefaultParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventCategories

        internal virtual DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }
        internal virtual DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesResponse>(request, options);
        }


        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type. You can also see this list in the "Amazon RDS event categories
        /// and event messages" section of the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.Messages.html">
        /// <i>Amazon RDS User Guide</i> </a> or the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Events.Messages.html">
        /// <i>Amazon Aurora User Guide</i> </a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventCategoriesAsync(new DescribeEventCategoriesRequest(), cancellationToken);
        }



        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type. You can also see this list in the "Amazon RDS event categories
        /// and event messages" section of the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.Messages.html">
        /// <i>Amazon RDS User Guide</i> </a> or the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Events.Messages.html">
        /// <i>Amazon Aurora User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventCategoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents

        internal virtual DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }
        internal virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }


        /// <summary>
        /// Returns events related to DB instances, DB clusters, DB parameter groups, DB security
        /// groups, DB snapshots, DB cluster snapshots, and RDS Proxies for the past 14 days.
        /// Events specific to a particular DB instance, DB cluster, DB parameter group, DB security
        /// group, DB snapshot, DB cluster snapshot group, or RDS Proxy can be obtained by providing
        /// the name as a parameter.
        /// 
        ///  
        /// <para>
        /// For more information on working with events, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/working-with-events.html">Monitoring
        /// Amazon RDS events</a> in the <i>Amazon RDS User Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/working-with-events.html">Monitoring
        /// Amazon Aurora events</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, RDS returns events that were generated in the past hour.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventsAsync(new DescribeEventsRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns events related to DB instances, DB clusters, DB parameter groups, DB security
        /// groups, DB snapshots, DB cluster snapshots, and RDS Proxies for the past 14 days.
        /// Events specific to a particular DB instance, DB cluster, DB parameter group, DB security
        /// group, DB snapshot, DB cluster snapshot group, or RDS Proxy can be obtained by providing
        /// the name as a parameter.
        /// 
        ///  
        /// <para>
        /// For more information on working with events, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/working-with-events.html">Monitoring
        /// Amazon RDS events</a> in the <i>Amazon RDS User Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/working-with-events.html">Monitoring
        /// Amazon Aurora events</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, RDS returns events that were generated in the past hour.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        internal virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }
        internal virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsResponse>(request, options);
        }


        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes <code>SubscriptionName</code>, <code>SNSTopicARN</code>, <code>CustomerID</code>,
        /// <code>SourceType</code>, <code>SourceID</code>, <code>CreationTime</code>, and <code>Status</code>.
        /// 
        ///  
        /// <para>
        /// If you specify a <code>SubscriptionName</code>, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventSubscriptionsAsync(new DescribeEventSubscriptionsRequest(), cancellationToken);
        }



        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes <code>SubscriptionName</code>, <code>SNSTopicARN</code>, <code>CustomerID</code>,
        /// <code>SourceType</code>, <code>SourceID</code>, <code>CreationTime</code>, and <code>Status</code>.
        /// 
        ///  
        /// <para>
        /// If you specify a <code>SubscriptionName</code>, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventSubscriptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeExportTasks

        internal virtual DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeExportTasksResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a snapshot export to Amazon S3. This API operation supports
        /// pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ExportTaskNotFoundException">
        /// The export task doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExportTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGlobalClusters

        internal virtual DescribeGlobalClustersResponse DescribeGlobalClusters(DescribeGlobalClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGlobalClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeGlobalClustersResponse>(request, options);
        }



        /// <summary>
        /// Returns information about Aurora global database clusters. This API supports pagination.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGlobalClusters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <code>GlobalClusterIdentifier</code> doesn't refer to an existing global database
        /// cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeGlobalClusters">REST API Reference for DescribeGlobalClusters Operation</seealso>
        public virtual Task<DescribeGlobalClustersResponse> DescribeGlobalClustersAsync(DescribeGlobalClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGlobalClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGlobalClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOptionGroupOptions

        internal virtual DescribeOptionGroupOptionsResponse DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOptionGroupOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOptionGroupOptionsResponse>(request, options);
        }



        /// <summary>
        /// Describes all available options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroupOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOptionGroupOptions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroupOptions">REST API Reference for DescribeOptionGroupOptions Operation</seealso>
        public virtual Task<DescribeOptionGroupOptionsResponse> DescribeOptionGroupOptionsAsync(DescribeOptionGroupOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOptionGroupOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOptionGroupOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOptionGroups

        internal virtual DescribeOptionGroupsResponse DescribeOptionGroups()
        {
            return DescribeOptionGroups(new DescribeOptionGroupsRequest());
        }
        internal virtual DescribeOptionGroupsResponse DescribeOptionGroups(DescribeOptionGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOptionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptionGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeOptionGroupsResponse>(request, options);
        }


        /// <summary>
        /// Describes the available option groups.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroups">REST API Reference for DescribeOptionGroups Operation</seealso>
        public virtual Task<DescribeOptionGroupsResponse> DescribeOptionGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeOptionGroupsAsync(new DescribeOptionGroupsRequest(), cancellationToken);
        }



        /// <summary>
        /// Describes the available option groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroups">REST API Reference for DescribeOptionGroups Operation</seealso>
        public virtual Task<DescribeOptionGroupsResponse> DescribeOptionGroupsAsync(DescribeOptionGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOptionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptionGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOptionGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrderableDBInstanceOptions

        internal virtual DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrderableDBInstanceOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableDBInstanceOptionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of orderable DB instance options for the specified DB engine, DB engine
        /// version, and DB instance class.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        public virtual Task<DescribeOrderableDBInstanceOptionsResponse> DescribeOrderableDBInstanceOptionsAsync(DescribeOrderableDBInstanceOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrderableDBInstanceOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrderableDBInstanceOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePendingMaintenanceActions

        internal virtual DescribePendingMaintenanceActionsResponse DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return Invoke<DescribePendingMaintenanceActionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of resources (for example, DB instances) that have at least one pending
        /// maintenance action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePendingMaintenanceActions service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual Task<DescribePendingMaintenanceActionsResponse> DescribePendingMaintenanceActionsAsync(DescribePendingMaintenanceActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePendingMaintenanceActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedDBInstances

        internal virtual DescribeReservedDBInstancesResponse DescribeReservedDBInstances()
        {
            return DescribeReservedDBInstances(new DescribeReservedDBInstancesRequest());
        }
        internal virtual DescribeReservedDBInstancesResponse DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedDBInstancesResponse>(request, options);
        }


        /// <summary>
        /// Returns information about reserved DB instances for this account, or about a specified
        /// reserved DB instance.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceNotFoundException">
        /// The specified reserved DB Instance not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstances">REST API Reference for DescribeReservedDBInstances Operation</seealso>
        public virtual Task<DescribeReservedDBInstancesResponse> DescribeReservedDBInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedDBInstancesAsync(new DescribeReservedDBInstancesRequest(), cancellationToken);
        }



        /// <summary>
        /// Returns information about reserved DB instances for this account, or about a specified
        /// reserved DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceNotFoundException">
        /// The specified reserved DB Instance not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstances">REST API Reference for DescribeReservedDBInstances Operation</seealso>
        public virtual Task<DescribeReservedDBInstancesResponse> DescribeReservedDBInstancesAsync(DescribeReservedDBInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedDBInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedDBInstancesOfferings

        internal virtual DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings()
        {
            return DescribeReservedDBInstancesOfferings(new DescribeReservedDBInstancesOfferingsRequest());
        }
        internal virtual DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedDBInstancesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedDBInstancesOfferingsResponse>(request, options);
        }


        /// <summary>
        /// Lists available reserved DB instance offerings.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstancesOfferings">REST API Reference for DescribeReservedDBInstancesOfferings Operation</seealso>
        public virtual Task<DescribeReservedDBInstancesOfferingsResponse> DescribeReservedDBInstancesOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedDBInstancesOfferingsAsync(new DescribeReservedDBInstancesOfferingsRequest(), cancellationToken);
        }



        /// <summary>
        /// Lists available reserved DB instance offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstancesOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstancesOfferings">REST API Reference for DescribeReservedDBInstancesOfferings Operation</seealso>
        public virtual Task<DescribeReservedDBInstancesOfferingsResponse> DescribeReservedDBInstancesOfferingsAsync(DescribeReservedDBInstancesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedDBInstancesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedDBInstancesOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSourceRegions

        internal virtual DescribeSourceRegionsResponse DescribeSourceRegions(DescribeSourceRegionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceRegionsResponseUnmarshaller.Instance;

            return Invoke<DescribeSourceRegionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the source Amazon Web Services Regions where the current Amazon
        /// Web Services Region can create a read replica, copy a DB snapshot from, or replicate
        /// automated backups from.
        /// 
        ///  
        /// <para>
        /// Use this operation to determine whether cross-Region features are supported between
        /// other Regions and your current Region. This operation supports pagination.
        /// </para>
        ///  
        /// <para>
        /// To return information about the Regions that are enabled for your account, or all
        /// Regions, use the EC2 operation <code>DescribeRegions</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeRegions.html">
        /// DescribeRegions</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSourceRegions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeSourceRegions">REST API Reference for DescribeSourceRegions Operation</seealso>
        public virtual Task<DescribeSourceRegionsResponse> DescribeSourceRegionsAsync(DescribeSourceRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSourceRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceRegionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSourceRegionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeValidDBInstanceModifications

        internal virtual DescribeValidDBInstanceModificationsResponse DescribeValidDBInstanceModifications(DescribeValidDBInstanceModificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeValidDBInstanceModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeValidDBInstanceModificationsResponse>(request, options);
        }



        /// <summary>
        /// You can call <code>DescribeValidDBInstanceModifications</code> to learn what modifications
        /// you can make to your DB instance. You can use this information when you call <code>ModifyDBInstance</code>.
        /// 
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeValidDBInstanceModifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeValidDBInstanceModifications service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeValidDBInstanceModifications">REST API Reference for DescribeValidDBInstanceModifications Operation</seealso>
        public virtual Task<DescribeValidDBInstanceModificationsResponse> DescribeValidDBInstanceModificationsAsync(DescribeValidDBInstanceModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeValidDBInstanceModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeValidDBInstanceModificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DownloadDBLogFilePortion

        internal virtual DownloadDBLogFilePortionResponse DownloadDBLogFilePortion(DownloadDBLogFilePortionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DownloadDBLogFilePortionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.Instance;

            return Invoke<DownloadDBLogFilePortionResponse>(request, options);
        }



        /// <summary>
        /// Downloads all or a portion of the specified log file, up to 1 MB in size.
        /// 
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DownloadDBLogFilePortion service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBLogFileNotFoundException">
        /// <code>LogFileName</code> doesn't refer to an existing DB log file.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DownloadDBLogFilePortion">REST API Reference for DownloadDBLogFilePortion Operation</seealso>
        public virtual Task<DownloadDBLogFilePortionResponse> DownloadDBLogFilePortionAsync(DownloadDBLogFilePortionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DownloadDBLogFilePortionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.Instance;

            return InvokeAsync<DownloadDBLogFilePortionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  FailoverDBCluster

        internal virtual FailoverDBClusterResponse FailoverDBCluster(FailoverDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FailoverDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverDBClusterResponseUnmarshaller.Instance;

            return Invoke<FailoverDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Forces a failover for a DB cluster.
        /// 
        ///  
        /// <para>
        /// For an Aurora DB cluster, failover for a DB cluster promotes one of the Aurora Replicas
        /// (read-only instances) in the DB cluster to be the primary DB instance (the cluster
        /// writer).
        /// </para>
        ///  
        /// <para>
        /// For a Multi-AZ DB cluster, failover for a DB cluster promotes one of the readable
        /// standby DB instances (read-only instances) in the DB cluster to be the primary DB
        /// instance (the cluster writer).
        /// </para>
        ///  
        /// <para>
        /// An Amazon Aurora DB cluster automatically fails over to an Aurora Replica, if one
        /// exists, when the primary DB instance fails. A Multi-AZ DB cluster automatically fails
        /// over to a readable standby DB instance when the primary DB instance fails.
        /// </para>
        ///  
        /// <para>
        /// To simulate a failure of a primary instance for testing, you can force a failover.
        /// Because each instance in a DB cluster has its own endpoint address, make sure to clean
        /// up and re-establish any existing connections that use those endpoint addresses when
        /// the failover is complete.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FailoverDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        public virtual Task<FailoverDBClusterResponse> FailoverDBClusterAsync(FailoverDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FailoverDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<FailoverDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  FailoverGlobalCluster

        internal virtual FailoverGlobalClusterResponse FailoverGlobalCluster(FailoverGlobalClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FailoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<FailoverGlobalClusterResponse>(request, options);
        }



        /// <summary>
        /// Initiates the failover process for an Aurora global database (<a>GlobalCluster</a>).
        /// 
        ///  
        /// <para>
        /// A failover for an Aurora global database promotes one of secondary read-only DB clusters
        /// to be the primary DB cluster and demotes the primary DB cluster to being a secondary
        /// (read-only) DB cluster. In other words, the role of the current primary DB cluster
        /// and the selected (target) DB cluster are switched. The selected secondary DB cluster
        /// assumes full read/write capabilities for the Aurora global database.
        /// </para>
        ///  
        /// <para>
        /// For more information about failing over an Amazon Aurora global database, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-global-database-disaster-recovery.html#aurora-global-database-disaster-recovery.managed-failover">Managed
        /// planned failover for Amazon Aurora global databases</a> in the <i>Amazon Aurora User
        /// Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action applies to <a>GlobalCluster</a> (Aurora global databases) only. Use this
        /// action only on healthy Aurora global databases with running Aurora DB clusters and
        /// no Region-wide outages, to test disaster recovery scenarios or to reconfigure your
        /// Aurora global database topology.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FailoverGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <code>GlobalClusterIdentifier</code> doesn't refer to an existing global database
        /// cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/FailoverGlobalCluster">REST API Reference for FailoverGlobalCluster Operation</seealso>
        public virtual Task<FailoverGlobalClusterResponse> FailoverGlobalClusterAsync(FailoverGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FailoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverGlobalClusterResponseUnmarshaller.Instance;

            return InvokeAsync<FailoverGlobalClusterResponse>(request, options, cancellationToken);
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
        /// Lists all tags on an Amazon RDS resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon RDS resource, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon RDS Resources</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <code>BlueGreenDeploymentIdentifier</code> doesn't refer to an existing blue/green
        /// deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyActivityStream

        internal virtual ModifyActivityStreamResponse ModifyActivityStream(ModifyActivityStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyActivityStreamResponseUnmarshaller.Instance;

            return Invoke<ModifyActivityStreamResponse>(request, options);
        }



        /// <summary>
        /// Changes the audit policy state of a database activity stream to either locked (default)
        /// or unlocked. A locked policy is read-only, whereas an unlocked policy is read/write.
        /// If your activity stream is started and locked, you can unlock it, customize your audit
        /// policy, and then lock your activity stream. Restarting the activity stream isn't required.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/DBActivityStreams.Modifying.html">
        /// Modifying a database activity stream</a> in the <i>Amazon RDS User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// This operation is supported for RDS for Oracle only.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyActivityStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyActivityStream service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyActivityStream">REST API Reference for ModifyActivityStream Operation</seealso>
        public virtual Task<ModifyActivityStreamResponse> ModifyActivityStreamAsync(ModifyActivityStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyActivityStreamResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyActivityStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyCertificates

        internal virtual ModifyCertificatesResponse ModifyCertificates(ModifyCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCertificatesResponseUnmarshaller.Instance;

            return Invoke<ModifyCertificatesResponse>(request, options);
        }



        /// <summary>
        /// Override the system-default Secure Sockets Layer/Transport Layer Security (SSL/TLS)
        /// certificate for Amazon RDS for new DB instances, or remove the override.
        /// 
        ///  
        /// <para>
        /// By using this operation, you can specify an RDS-approved SSL/TLS certificate for new
        /// DB instances that is different from the default certificate provided by RDS. You can
        /// also use this operation to remove the override, so that new DB instances use the default
        /// certificate provided by RDS.
        /// </para>
        ///  
        /// <para>
        /// You might need to override the default certificate in the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You already migrated your applications to support the latest certificate authority
        /// (CA) certificate, but the new CA certificate is not yet the RDS default CA certificate
        /// for the specified Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDS has already moved to a new default CA certificate for the specified Amazon Web
        /// Services Region, but you are still in the process of supporting the new CA certificate.
        /// In this case, you temporarily need additional time to finish your application changes.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about rotating your SSL/TLS certificate for RDS DB engines, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL-certificate-rotation.html">
        /// Rotating Your SSL/TLS Certificate</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about rotating your SSL/TLS certificate for Aurora DB engines,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.SSL-certificate-rotation.html">
        /// Rotating Your SSL/TLS Certificate</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCertificates service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <code>CertificateIdentifier</code> doesn't refer to an existing certificate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCertificates">REST API Reference for ModifyCertificates Operation</seealso>
        public virtual Task<ModifyCertificatesResponse> ModifyCertificatesAsync(ModifyCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyCurrentDBClusterCapacity

        internal virtual ModifyCurrentDBClusterCapacityResponse ModifyCurrentDBClusterCapacity(ModifyCurrentDBClusterCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCurrentDBClusterCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCurrentDBClusterCapacityResponseUnmarshaller.Instance;

            return Invoke<ModifyCurrentDBClusterCapacityResponse>(request, options);
        }



        /// <summary>
        /// Set the capacity of an Aurora Serverless v1 DB cluster to a specific value.
        /// 
        ///  
        /// <para>
        /// Aurora Serverless v1 scales seamlessly based on the workload on the DB cluster. In
        /// some cases, the capacity might not scale fast enough to meet a sudden change in workload,
        /// such as a large number of new transactions. Call <code>ModifyCurrentDBClusterCapacity</code>
        /// to set the capacity explicitly.
        /// </para>
        ///  
        /// <para>
        /// After this call sets the DB cluster capacity, Aurora Serverless v1 can automatically
        /// scale the DB cluster based on the cooldown period for scaling up and the cooldown
        /// period for scaling down.
        /// </para>
        ///  
        /// <para>
        /// For more information about Aurora Serverless v1, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.html">Using
        /// Amazon Aurora Serverless v1</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you call <code>ModifyCurrentDBClusterCapacity</code> with the default <code>TimeoutAction</code>,
        /// connections that prevent Aurora Serverless v1 from finding a scaling point might be
        /// dropped. For more information about scaling points, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.how-it-works.html#aurora-serverless.how-it-works.auto-scaling">
        /// Autoscaling for Aurora Serverless v1</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// This action only applies to Aurora Serverless v1 DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCurrentDBClusterCapacity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCurrentDBClusterCapacity service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterCapacityException">
        /// <code>Capacity</code> isn't a valid Aurora Serverless DB cluster capacity. Valid
        /// capacity values are <code>2</code>, <code>4</code>, <code>8</code>, <code>16</code>,
        /// <code>32</code>, <code>64</code>, <code>128</code>, and <code>256</code>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCurrentDBClusterCapacity">REST API Reference for ModifyCurrentDBClusterCapacity Operation</seealso>
        public virtual Task<ModifyCurrentDBClusterCapacityResponse> ModifyCurrentDBClusterCapacityAsync(ModifyCurrentDBClusterCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCurrentDBClusterCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCurrentDBClusterCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyCurrentDBClusterCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyCustomDBEngineVersion

        internal virtual ModifyCustomDBEngineVersionResponse ModifyCustomDBEngineVersion(ModifyCustomDBEngineVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCustomDBEngineVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCustomDBEngineVersionResponseUnmarshaller.Instance;

            return Invoke<ModifyCustomDBEngineVersionResponse>(request, options);
        }



        /// <summary>
        /// Modifies the status of a custom engine version (CEV). You can find CEVs to modify
        /// by calling <code>DescribeDBEngineVersions</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The MediaImport service that imports files from Amazon S3 to create CEVs isn't integrated
        /// with Amazon Web Services CloudTrail. If you turn on data logging for Amazon RDS in
        /// CloudTrail, calls to the <code>ModifyCustomDbEngineVersion</code> event aren't logged.
        /// However, you might see calls from the API gateway that accesses your Amazon S3 bucket.
        /// These calls originate from the MediaImport service for the <code>ModifyCustomDbEngineVersion</code>
        /// event.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-cev.html#custom-cev.modify">Modifying
        /// CEV status</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCustomDBEngineVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCustomDBEngineVersion service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CustomDBEngineVersionNotFoundException">
        /// The specified CEV was not found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidCustomDBEngineVersionStateException">
        /// You can't delete the CEV.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCustomDBEngineVersion">REST API Reference for ModifyCustomDBEngineVersion Operation</seealso>
        public virtual Task<ModifyCustomDBEngineVersionResponse> ModifyCustomDBEngineVersionAsync(ModifyCustomDBEngineVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCustomDBEngineVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCustomDBEngineVersionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyCustomDBEngineVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBCluster

        internal virtual ModifyDBClusterResponse ModifyDBCluster(ModifyDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Modify the settings for an Amazon Aurora DB cluster or a Multi-AZ DB cluster. You
        /// can change one or more settings by specifying these parameters and the new values
        /// in the request.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <code>DBClusterParameterGroupName</code> doesn't refer to an existing DB cluster
        /// parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual Task<ModifyDBClusterResponse> ModifyDBClusterAsync(ModifyDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBClusterEndpoint

        internal virtual ModifyDBClusterEndpointResponse ModifyDBClusterEndpoint(ModifyDBClusterEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterEndpointResponse>(request, options);
        }



        /// <summary>
        /// Modifies the properties of an endpoint in an Amazon Aurora DB cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBClusterEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterEndpointNotFoundException">
        /// The specified custom endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterEndpointStateException">
        /// The requested operation can't be performed on the endpoint while the endpoint is in
        /// this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterEndpoint">REST API Reference for ModifyDBClusterEndpoint Operation</seealso>
        public virtual Task<ModifyDBClusterEndpointResponse> ModifyDBClusterEndpointAsync(ModifyDBClusterEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBClusterEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBClusterParameterGroup

        internal virtual ModifyDBClusterParameterGroupResponse ModifyDBClusterParameterGroup(ModifyDBClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the parameters of a DB cluster parameter group. To modify more than one parameter,
        /// submit a list of the following: <code>ParameterName</code>, <code>ParameterValue</code>,
        /// and <code>ApplyMethod</code>. A maximum of 20 parameters can be modified in a single
        /// request.
        /// 
        ///  <important> 
        /// <para>
        /// After you create a DB cluster parameter group, you should wait at least 5 minutes
        /// before creating your first DB cluster that uses that DB cluster parameter group as
        /// the default parameter group. This allows Amazon RDS to fully complete the create action
        /// before the parameter group is used as the default for a new DB cluster. This is especially
        /// important for parameters that are critical when creating the default database for
        /// a DB cluster, such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <code>DescribeDBClusterParameters</code> operation to verify
        /// that your DB cluster parameter group has been created or modified.
        /// </para>
        ///  
        /// <para>
        /// If the modified DB cluster parameter group is used by an Aurora Serverless v1 cluster,
        /// Aurora applies the update immediately. The cluster restart might interrupt your workload.
        /// In that case, your application must reopen any connections and retry any transactions
        /// that were active when the parameter changes took effect.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        public virtual Task<ModifyDBClusterParameterGroupResponse> ModifyDBClusterParameterGroupAsync(ModifyDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBClusterSnapshotAttribute

        internal virtual ModifyDBClusterSnapshotAttributeResponse ModifyDBClusterSnapshotAttribute(ModifyDBClusterSnapshotAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterSnapshotAttributeResponse>(request, options);
        }



        /// <summary>
        /// Adds an attribute and values to, or removes an attribute and values from, a manual
        /// DB cluster snapshot.
        /// 
        ///  
        /// <para>
        /// To share a manual DB cluster snapshot with other Amazon Web Services accounts, specify
        /// <code>restore</code> as the <code>AttributeName</code> and use the <code>ValuesToAdd</code>
        /// parameter to add a list of IDs of the Amazon Web Services accounts that are authorized
        /// to restore the manual DB cluster snapshot. Use the value <code>all</code> to make
        /// the manual DB cluster snapshot public, which means that it can be copied or restored
        /// by all Amazon Web Services accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't add the <code>all</code> value for any manual DB cluster snapshots that contain
        /// private information that you don't want available to all Amazon Web Services accounts.
        /// </para>
        ///  </note> 
        /// <para>
        /// If a manual DB cluster snapshot is encrypted, it can be shared, but only by specifying
        /// a list of authorized Amazon Web Services account IDs for the <code>ValuesToAdd</code>
        /// parameter. You can't use <code>all</code> as a value for that parameter in this case.
        /// </para>
        ///  
        /// <para>
        /// To view which Amazon Web Services accounts have access to copy or restore a manual
        /// DB cluster snapshot, or whether a manual DB cluster snapshot is public or private,
        /// use the <a>DescribeDBClusterSnapshotAttributes</a> API operation. The accounts are
        /// returned as values for the <code>restore</code> attribute.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBClusterSnapshotAttribute service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SharedSnapshotQuotaExceededException">
        /// You have exceeded the maximum number of accounts that you can share a manual DB snapshot
        /// with.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        public virtual Task<ModifyDBClusterSnapshotAttributeResponse> ModifyDBClusterSnapshotAttributeAsync(ModifyDBClusterSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBClusterSnapshotAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBInstance

        internal virtual ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return Invoke<ModifyDBInstanceResponse>(request, options);
        }



        /// <summary>
        /// Modifies settings for a DB instance. You can change one or more database configuration
        /// parameters by specifying these parameters and the new values in the request. To learn
        /// what modifications you can make to your DB instance, call <code>DescribeValidDBInstanceModifications</code>
        /// before you call <code>ModifyDBInstance</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.BackupPolicyNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <code>CertificateIdentifier</code> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBUpgradeDependencyFailureException">
        /// The DB upgrade failed because a resource the DB depends on can't be modified.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <code>IPV4</code>
        /// and <code>DUAL</code>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        public virtual Task<ModifyDBInstanceResponse> ModifyDBInstanceAsync(ModifyDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBParameterGroup

        internal virtual ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the parameters of a DB parameter group. To modify more than one parameter,
        /// submit a list of the following: <code>ParameterName</code>, <code>ParameterValue</code>,
        /// and <code>ApplyMethod</code>. A maximum of 20 parameters can be modified in a single
        /// request.
        /// 
        ///  <important> 
        /// <para>
        /// After you modify a DB parameter group, you should wait at least 5 minutes before creating
        /// your first DB instance that uses that DB parameter group as the default parameter
        /// group. This allows Amazon RDS to fully complete the modify action before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <code>character_set_database</code>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <i>DescribeDBParameters</i> command to verify that your DB
        /// parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBParameterGroup">REST API Reference for ModifyDBParameterGroup Operation</seealso>
        public virtual Task<ModifyDBParameterGroupResponse> ModifyDBParameterGroupAsync(ModifyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBProxy

        internal virtual ModifyDBProxyResponse ModifyDBProxy(ModifyDBProxyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyResponseUnmarshaller.Instance;

            return Invoke<ModifyDBProxyResponse>(request, options);
        }



        /// <summary>
        /// Changes the settings for an existing DB proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBProxy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBProxy service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyAlreadyExistsException">
        /// The specified proxy name must be unique for all proxies owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBProxy">REST API Reference for ModifyDBProxy Operation</seealso>
        public virtual Task<ModifyDBProxyResponse> ModifyDBProxyAsync(ModifyDBProxyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBProxyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBProxyEndpoint

        internal virtual ModifyDBProxyEndpointResponse ModifyDBProxyEndpoint(ModifyDBProxyEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyDBProxyEndpointResponse>(request, options);
        }



        /// <summary>
        /// Changes the settings for an existing DB proxy endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBProxyEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBProxyEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyEndpointAlreadyExistsException">
        /// The specified DB proxy endpoint name must be unique for all DB proxy endpoints owned
        /// by your Amazon Web Services account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyEndpointNotFoundException">
        /// The DB proxy endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyEndpointStateException">
        /// You can't perform this operation while the DB proxy endpoint is in a particular state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBProxyEndpoint">REST API Reference for ModifyDBProxyEndpoint Operation</seealso>
        public virtual Task<ModifyDBProxyEndpointResponse> ModifyDBProxyEndpointAsync(ModifyDBProxyEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBProxyEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBProxyTargetGroup

        internal virtual ModifyDBProxyTargetGroupResponse ModifyDBProxyTargetGroup(ModifyDBProxyTargetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyTargetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBProxyTargetGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the properties of a <code>DBProxyTargetGroup</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBProxyTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBProxyTargetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBProxyTargetGroup">REST API Reference for ModifyDBProxyTargetGroup Operation</seealso>
        public virtual Task<ModifyDBProxyTargetGroupResponse> ModifyDBProxyTargetGroupAsync(ModifyDBProxyTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyTargetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBProxyTargetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBSnapshot

        internal virtual ModifyDBSnapshotResponse ModifyDBSnapshot(ModifyDBSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Updates a manual DB snapshot with a new engine version. The snapshot can be encrypted
        /// or unencrypted, but not shared or public. 
        /// 
        ///  
        /// <para>
        /// Amazon RDS supports upgrading DB snapshots for MySQL, PostgreSQL, and Oracle. This
        /// command doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSnapshot">REST API Reference for ModifyDBSnapshot Operation</seealso>
        public virtual Task<ModifyDBSnapshotResponse> ModifyDBSnapshotAsync(ModifyDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBSnapshotAttribute

        internal virtual ModifyDBSnapshotAttributeResponse ModifyDBSnapshotAttribute(ModifyDBSnapshotAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSnapshotAttributeResponse>(request, options);
        }



        /// <summary>
        /// Adds an attribute and values to, or removes an attribute and values from, a manual
        /// DB snapshot.
        /// 
        ///  
        /// <para>
        /// To share a manual DB snapshot with other Amazon Web Services accounts, specify <code>restore</code>
        /// as the <code>AttributeName</code> and use the <code>ValuesToAdd</code> parameter to
        /// add a list of IDs of the Amazon Web Services accounts that are authorized to restore
        /// the manual DB snapshot. Uses the value <code>all</code> to make the manual DB snapshot
        /// public, which means it can be copied or restored by all Amazon Web Services accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't add the <code>all</code> value for any manual DB snapshots that contain private
        /// information that you don't want available to all Amazon Web Services accounts.
        /// </para>
        ///  </note> 
        /// <para>
        /// If the manual DB snapshot is encrypted, it can be shared, but only by specifying a
        /// list of authorized Amazon Web Services account IDs for the <code>ValuesToAdd</code>
        /// parameter. You can't use <code>all</code> as a value for that parameter in this case.
        /// </para>
        ///  
        /// <para>
        /// To view which Amazon Web Services accounts have access to copy or restore a manual
        /// DB snapshot, or whether a manual DB snapshot public or private, use the <a>DescribeDBSnapshotAttributes</a>
        /// API operation. The accounts are returned as values for the <code>restore</code> attribute.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshotAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBSnapshotAttribute service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SharedSnapshotQuotaExceededException">
        /// You have exceeded the maximum number of accounts that you can share a manual DB snapshot
        /// with.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSnapshotAttribute">REST API Reference for ModifyDBSnapshotAttribute Operation</seealso>
        public virtual Task<ModifyDBSnapshotAttributeResponse> ModifyDBSnapshotAttributeAsync(ModifyDBSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBSnapshotAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBSubnetGroup

        internal virtual ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies an existing DB subnet group. DB subnet groups must contain at least one subnet
        /// in at least two AZs in the Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of subnets in a
        /// DB subnet groups.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubnetAlreadyInUseException">
        /// The DB subnet is already in use in the Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        public virtual Task<ModifyDBSubnetGroupResponse> ModifyDBSubnetGroupAsync(ModifyDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyEventSubscription

        internal virtual ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Modifies an existing RDS event notification subscription. You can't modify the source
        /// identifiers using this call. To change source identifiers for a subscription, use
        /// the <code>AddSourceIdentifierToSubscription</code> and <code>RemoveSourceIdentifierFromSubscription</code>
        /// calls.
        /// 
        ///  
        /// <para>
        /// You can see a list of the event categories for a given source type (<code>SourceType</code>)
        /// in <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">Events</a>
        /// in the <i>Amazon RDS User Guide</i> or by using the <code>DescribeEventCategories</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.EventSubscriptionQuotaExceededException">
        /// You have reached the maximum number of event subscriptions.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSInvalidTopicException">
        /// SNS has responded that there is a problem with the SNS topic specified.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the SNS topic ARN.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SNSTopicArnNotFoundException">
        /// The SNS topic ARN does not exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionCategoryNotFoundException">
        /// The supplied category does not exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyEventSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyGlobalCluster

        internal virtual ModifyGlobalClusterResponse ModifyGlobalCluster(ModifyGlobalClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyGlobalClusterResponse>(request, options);
        }



        /// <summary>
        /// Modify a setting for an Amazon Aurora global cluster. You can change one or more database
        /// configuration parameters by specifying these parameters and the new values in the
        /// request. For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <code>GlobalClusterIdentifier</code> doesn't refer to an existing global database
        /// cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyGlobalCluster">REST API Reference for ModifyGlobalCluster Operation</seealso>
        public virtual Task<ModifyGlobalClusterResponse> ModifyGlobalClusterAsync(ModifyGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyGlobalClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyGlobalClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyOptionGroup

        internal virtual ModifyOptionGroupResponse ModifyOptionGroup(ModifyOptionGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyOptionGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyOptionGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies an existing option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyOptionGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidOptionGroupStateException">
        /// The option group isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyOptionGroup">REST API Reference for ModifyOptionGroup Operation</seealso>
        public virtual Task<ModifyOptionGroupResponse> ModifyOptionGroupAsync(ModifyOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyOptionGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PromoteReadReplica

        internal virtual PromoteReadReplicaResponse PromoteReadReplica(PromoteReadReplicaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromoteReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteReadReplicaResponseUnmarshaller.Instance;

            return Invoke<PromoteReadReplicaResponse>(request, options);
        }



        /// <summary>
        /// Promotes a read replica DB instance to a standalone DB instance.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// Backup duration is a function of the amount of changes to the database since the previous
        /// backup. If you plan to promote a read replica to a standalone instance, we recommend
        /// that you enable backups and complete at least one backup prior to promotion. In addition,
        /// a read replica cannot be promoted to a standalone instance when it is in the <code>backing-up</code>
        /// status. If you have enabled backups on your read replica, configure the automated
        /// backup window so that daily backups do not interfere with read replica promotion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This command doesn't apply to Aurora MySQL, Aurora PostgreSQL, or RDS Custom.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplica service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PromoteReadReplica service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplica">REST API Reference for PromoteReadReplica Operation</seealso>
        public virtual Task<PromoteReadReplicaResponse> PromoteReadReplicaAsync(PromoteReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromoteReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteReadReplicaResponseUnmarshaller.Instance;

            return InvokeAsync<PromoteReadReplicaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PromoteReadReplicaDBCluster

        internal virtual PromoteReadReplicaDBClusterResponse PromoteReadReplicaDBCluster(PromoteReadReplicaDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromoteReadReplicaDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance;

            return Invoke<PromoteReadReplicaDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Promotes a read replica DB cluster to a standalone DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplicaDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PromoteReadReplicaDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplicaDBCluster">REST API Reference for PromoteReadReplicaDBCluster Operation</seealso>
        public virtual Task<PromoteReadReplicaDBClusterResponse> PromoteReadReplicaDBClusterAsync(PromoteReadReplicaDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PromoteReadReplicaDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<PromoteReadReplicaDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedDBInstancesOffering

        internal virtual PurchaseReservedDBInstancesOfferingResponse PurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedDBInstancesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedDBInstancesOfferingResponse>(request, options);
        }



        /// <summary>
        /// Purchases a reserved DB instance offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedDBInstancesOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseReservedDBInstancesOffering service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceQuotaExceededException">
        /// Request would exceed the user's DB Instance quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PurchaseReservedDBInstancesOffering">REST API Reference for PurchaseReservedDBInstancesOffering Operation</seealso>
        public virtual Task<PurchaseReservedDBInstancesOfferingResponse> PurchaseReservedDBInstancesOfferingAsync(PurchaseReservedDBInstancesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedDBInstancesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedDBInstancesOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootDBCluster

        internal virtual RebootDBClusterResponse RebootDBCluster(RebootDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDBClusterResponseUnmarshaller.Instance;

            return Invoke<RebootDBClusterResponse>(request, options);
        }



        /// <summary>
        /// You might need to reboot your DB cluster, usually for maintenance reasons. For example,
        /// if you make certain modifications, or if you change the DB cluster parameter group
        /// associated with the DB cluster, reboot the DB cluster for the changes to take effect.
        /// 
        ///  
        /// <para>
        /// Rebooting a DB cluster restarts the database engine service. Rebooting a DB cluster
        /// results in a momentary outage, during which the DB cluster status is set to rebooting.
        /// </para>
        ///  
        /// <para>
        /// Use this operation only for a non-Aurora Multi-AZ DB cluster.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RebootDBCluster">REST API Reference for RebootDBCluster Operation</seealso>
        public virtual Task<RebootDBClusterResponse> RebootDBClusterAsync(RebootDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RebootDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootDBInstance

        internal virtual RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootDBInstanceResponse>(request, options);
        }



        /// <summary>
        /// You might need to reboot your DB instance, usually for maintenance reasons. For example,
        /// if you make certain modifications, or if you change the DB parameter group associated
        /// with the DB instance, you must reboot the instance for the changes to take effect.
        /// 
        ///  
        /// <para>
        /// Rebooting a DB instance restarts the database engine service. Rebooting a DB instance
        /// results in a momentary outage, during which the DB instance status is set to rebooting.
        /// </para>
        ///  
        /// <para>
        /// For more information about rebooting, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_RebootInstance.html">Rebooting
        /// a DB Instance</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        /// If your DB instance is part of a Multi-AZ DB cluster, you can reboot the DB cluster
        /// with the <code>RebootDBCluster</code> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual Task<RebootDBInstanceResponse> RebootDBInstanceAsync(RebootDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RebootDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterDBProxyTargets

        internal virtual RegisterDBProxyTargetsResponse RegisterDBProxyTargets(RegisterDBProxyTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDBProxyTargetsResponseUnmarshaller.Instance;

            return Invoke<RegisterDBProxyTargetsResponse>(request, options);
        }



        /// <summary>
        /// Associate one or more <code>DBProxyTarget</code> data structures with a <code>DBProxyTargetGroup</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDBProxyTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterDBProxyTargets service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetAlreadyRegisteredException">
        /// The proxy is already associated with the specified RDS DB instance or Aurora DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientAvailableIPsInSubnetException">
        /// The requested operation can't be performed because there aren't enough available IP
        /// addresses in the proxy's subnets. Add more CIDR blocks to the VPC or remove IP address
        /// that aren't required from the subnets.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyStateException">
        /// The requested operation can't be performed while the proxy is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RegisterDBProxyTargets">REST API Reference for RegisterDBProxyTargets Operation</seealso>
        public virtual Task<RegisterDBProxyTargetsResponse> RegisterDBProxyTargetsAsync(RegisterDBProxyTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDBProxyTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterDBProxyTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveFromGlobalCluster

        internal virtual RemoveFromGlobalClusterResponse RemoveFromGlobalCluster(RemoveFromGlobalClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveFromGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFromGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<RemoveFromGlobalClusterResponse>(request, options);
        }



        /// <summary>
        /// Detaches an Aurora secondary cluster from an Aurora global database cluster. The cluster
        /// becomes a standalone cluster with read-write capability instead of being read-only
        /// and receiving data from a primary cluster in a different Region.
        /// 
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFromGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveFromGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <code>GlobalClusterIdentifier</code> doesn't refer to an existing global database
        /// cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveFromGlobalCluster">REST API Reference for RemoveFromGlobalCluster Operation</seealso>
        public virtual Task<RemoveFromGlobalClusterResponse> RemoveFromGlobalClusterAsync(RemoveFromGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveFromGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFromGlobalClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveFromGlobalClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveRoleFromDBCluster

        internal virtual RemoveRoleFromDBClusterResponse RemoveRoleFromDBCluster(RemoveRoleFromDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromDBClusterResponseUnmarshaller.Instance;

            return Invoke<RemoveRoleFromDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Removes the asssociation of an Amazon Web Services Identity and Access Management
        /// (IAM) role from a DB cluster.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveRoleFromDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterRoleNotFoundException">
        /// The specified IAM role Amazon Resource Name (ARN) isn't associated with the specified
        /// DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveRoleFromDBCluster">REST API Reference for RemoveRoleFromDBCluster Operation</seealso>
        public virtual Task<RemoveRoleFromDBClusterResponse> RemoveRoleFromDBClusterAsync(RemoveRoleFromDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveRoleFromDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveRoleFromDBInstance

        internal virtual RemoveRoleFromDBInstanceResponse RemoveRoleFromDBInstance(RemoveRoleFromDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromDBInstanceResponseUnmarshaller.Instance;

            return Invoke<RemoveRoleFromDBInstanceResponse>(request, options);
        }



        /// <summary>
        /// Disassociates an Amazon Web Services Identity and Access Management (IAM) role from
        /// a DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveRoleFromDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceRoleNotFoundException">
        /// The specified <code>RoleArn</code> value doesn't match the specified feature for the
        /// DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveRoleFromDBInstance">REST API Reference for RemoveRoleFromDBInstance Operation</seealso>
        public virtual Task<RemoveRoleFromDBInstanceResponse> RemoveRoleFromDBInstanceAsync(RemoveRoleFromDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveRoleFromDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveSourceIdentifierFromSubscription

        internal virtual RemoveSourceIdentifierFromSubscriptionResponse RemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveSourceIdentifierFromSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return Invoke<RemoveSourceIdentifierFromSubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Removes a source identifier from an existing RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveSourceIdentifierFromSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        public virtual Task<RemoveSourceIdentifierFromSubscriptionResponse> RemoveSourceIdentifierFromSubscriptionAsync(RemoveSourceIdentifierFromSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveSourceIdentifierFromSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveSourceIdentifierFromSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        internal virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes metadata tags from an Amazon RDS resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon RDS resource, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Overview.Tagging.html">Tagging
        /// Amazon RDS Resources</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <code>BlueGreenDeploymentIdentifier</code> doesn't refer to an existing blue/green
        /// deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetDBClusterParameterGroup

        internal virtual ResetDBClusterParameterGroupResponse ResetDBClusterParameterGroup(ResetDBClusterParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBClusterParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the parameters of a DB cluster parameter group to the default value. To reset
        /// specific parameters submit a list of the following: <code>ParameterName</code> and
        /// <code>ApplyMethod</code>. To reset the entire DB cluster parameter group, specify
        /// the <code>DBClusterParameterGroupName</code> and <code>ResetAllParameters</code> parameters.
        /// 
        ///  
        /// <para>
        /// When resetting the entire group, dynamic parameters are updated immediately and static
        /// parameters are set to <code>pending-reboot</code> to take effect on the next DB instance
        /// restart or <code>RebootDBInstance</code> request. You must call <code>RebootDBInstance</code>
        /// for every DB instance in your DB cluster that you want the updated static parameter
        /// to apply to.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        public virtual Task<ResetDBClusterParameterGroupResponse> ResetDBClusterParameterGroupAsync(ResetDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetDBParameterGroup

        internal virtual ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the parameters of a DB parameter group to the engine/system default value.
        /// To reset specific parameters, provide a list of the following: <code>ParameterName</code>
        /// and <code>ApplyMethod</code>. To reset the entire DB parameter group, specify the
        /// <code>DBParameterGroup</code> name and <code>ResetAllParameters</code> parameters.
        /// When resetting the entire group, dynamic parameters are updated immediately and static
        /// parameters are set to <code>pending-reboot</code> to take effect on the next DB instance
        /// restart or <code>RebootDBInstance</code> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBParameterGroup">REST API Reference for ResetDBParameterGroup Operation</seealso>
        public virtual Task<ResetDBParameterGroupResponse> ResetDBParameterGroupAsync(ResetDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetDBParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBClusterFromS3

        internal virtual RestoreDBClusterFromS3Response RestoreDBClusterFromS3(RestoreDBClusterFromS3Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterFromS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterFromS3ResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterFromS3Response>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Aurora DB cluster from MySQL data stored in an Amazon S3 bucket.
        /// Amazon RDS must be authorized to access the Amazon S3 bucket and the data must be
        /// created using the Percona XtraBackup utility as described in <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/AuroraMySQL.Migrating.ExtMySQL.html#AuroraMySQL.Migrating.ExtMySQL.S3">
        /// Migrating Data from MySQL by Using an Amazon S3 Bucket</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// This action only restores the DB cluster, not the DB instances for that DB cluster.
        /// You must invoke the <code>CreateDBInstance</code> action to create DB instances for
        /// the restored DB cluster, specifying the identifier of the restored DB cluster in <code>DBClusterIdentifier</code>.
        /// You can create DB instances only after the <code>RestoreDBClusterFromS3</code> action
        /// has completed and the DB cluster is available.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters. The source DB engine must be MySQL.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromS3 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreDBClusterFromS3 service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <code>DBClusterParameterGroupName</code> doesn't refer to an existing DB cluster
        /// parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You might be able
        /// to resolve this error by updating your subnet group to use different Availability
        /// Zones that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidS3BucketException">
        /// The specified Amazon S3 bucket name can't be found or Amazon RDS isn't authorized
        /// to access the specified Amazon S3 bucket. Verify the <b>SourceS3BucketName</b> and
        /// <b>S3IngestionRoleArn</b> values and try again.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromS3">REST API Reference for RestoreDBClusterFromS3 Operation</seealso>
        public virtual Task<RestoreDBClusterFromS3Response> RestoreDBClusterFromS3Async(RestoreDBClusterFromS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterFromS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterFromS3ResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBClusterFromS3Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBClusterFromSnapshot

        internal virtual RestoreDBClusterFromSnapshotResponse RestoreDBClusterFromSnapshot(RestoreDBClusterFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterFromSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB cluster from a DB snapshot or DB cluster snapshot.
        /// 
        ///  
        /// <para>
        /// The target DB cluster is created from the source snapshot with a default configuration.
        /// If you don't specify a security group, the new DB cluster is associated with the default
        /// security group.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only restores the DB cluster, not the DB instances for that DB cluster.
        /// You must invoke the <code>CreateDBInstance</code> action to create DB instances for
        /// the restored DB cluster, specifying the identifier of the restored DB cluster in <code>DBClusterIdentifier</code>.
        /// You can create DB instances only after the <code>RestoreDBClusterFromSnapshot</code>
        /// action has completed and the DB cluster is available.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreDBClusterFromSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <code>DBClusterParameterGroupName</code> doesn't refer to an existing DB cluster
        /// parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster doesn't have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You might be able
        /// to resolve this error by updating your subnet group to use different Availability
        /// Zones that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidRestoreException">
        /// Cannot restore from VPC backup to non-VPC DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        public virtual Task<RestoreDBClusterFromSnapshotResponse> RestoreDBClusterFromSnapshotAsync(RestoreDBClusterFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBClusterFromSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBClusterToPointInTime

        internal virtual RestoreDBClusterToPointInTimeResponse RestoreDBClusterToPointInTime(RestoreDBClusterToPointInTimeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterToPointInTimeResponse>(request, options);
        }



        /// <summary>
        /// Restores a DB cluster to an arbitrary point in time. Users can restore to any point
        /// in time before <code>LatestRestorableTime</code> for up to <code>BackupRetentionPeriod</code>
        /// days. The target DB cluster is created from the source DB cluster with the same configuration
        /// as the original DB cluster, except that the new DB cluster is created with the default
        /// DB security group.
        /// 
        ///  <note> 
        /// <para>
        /// For Aurora, this action only restores the DB cluster, not the DB instances for that
        /// DB cluster. You must invoke the <code>CreateDBInstance</code> action to create DB
        /// instances for the restored DB cluster, specifying the identifier of the restored DB
        /// cluster in <code>DBClusterIdentifier</code>. You can create DB instances only after
        /// the <code>RestoreDBClusterToPointInTime</code> action has completed and the DB cluster
        /// is available.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ deployments with two readable standby DB instances</a> in the <i>Amazon RDS
        /// User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreDBClusterToPointInTime service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <code>DBClusterParameterGroupName</code> doesn't refer to an existing DB cluster
        /// parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster doesn't have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientStorageClusterCapacityException">
        /// There is insufficient storage available for the current action. You might be able
        /// to resolve this error by updating your subnet group to use different Availability
        /// Zones that have more storage available.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidRestoreException">
        /// Cannot restore from VPC backup to non-VPC DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual Task<RestoreDBClusterToPointInTimeResponse> RestoreDBClusterToPointInTimeAsync(RestoreDBClusterToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBClusterToPointInTimeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBInstanceFromDBSnapshot

        internal virtual RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceFromDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceFromDBSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a new DB instance from a DB snapshot. The target database is created from
        /// the source database restore point with most of the source's original configuration,
        /// including the default security group and DB parameter group. By default, the new DB
        /// instance is created as a Single-AZ deployment, except when the instance is a SQL Server
        /// instance that has an option group associated with mirroring. In this case, the instance
        /// becomes a Multi-AZ deployment, not a Single-AZ deployment.
        /// 
        ///  
        /// <para>
        /// If you want to replace your original DB instance with the new, restored DB instance,
        /// then rename your original DB instance before you call the RestoreDBInstanceFromDBSnapshot
        /// action. RDS doesn't allow two DB instances with the same name. After you have renamed
        /// your original DB instance with a different identifier, then you can pass the original
        /// name of the DB instance as the DBInstanceIdentifier in the call to the RestoreDBInstanceFromDBSnapshot
        /// action. The result is that you replace the original DB instance with the DB instance
        /// created from the snapshot.
        /// </para>
        ///  
        /// <para>
        /// If you are restoring from a shared manual DB snapshot, the <code>DBSnapshotIdentifier</code>
        /// must be the ARN of the shared DB snapshot.
        /// </para>
        ///  <note> 
        /// <para>
        /// This command doesn't apply to Aurora MySQL and Aurora PostgreSQL. For Aurora, use
        /// <code>RestoreDBClusterFromSnapshot</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreDBInstanceFromDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.BackupPolicyNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidRestoreException">
        /// Cannot restore from VPC backup to non-VPC DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <code>IPV4</code>
        /// and <code>DUAL</code>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromDBSnapshot">REST API Reference for RestoreDBInstanceFromDBSnapshot Operation</seealso>
        public virtual Task<RestoreDBInstanceFromDBSnapshotResponse> RestoreDBInstanceFromDBSnapshotAsync(RestoreDBInstanceFromDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceFromDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBInstanceFromDBSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBInstanceFromS3

        internal virtual RestoreDBInstanceFromS3Response RestoreDBInstanceFromS3(RestoreDBInstanceFromS3Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceFromS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceFromS3Response>(request, options);
        }



        /// <summary>
        /// Amazon Relational Database Service (Amazon RDS) supports importing MySQL databases
        /// by using backup files. You can create a backup of your on-premises database, store
        /// it on Amazon Simple Storage Service (Amazon S3), and then restore the backup file
        /// onto a new Amazon RDS DB instance running MySQL. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/MySQL.Procedural.Importing.html">Importing
        /// Data into an Amazon RDS MySQL DB Instance</a> in the <i>Amazon RDS User Guide.</i>
        /// 
        /// 
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromS3 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreDBInstanceFromS3 service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.BackupPolicyNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidS3BucketException">
        /// The specified Amazon S3 bucket name can't be found or Amazon RDS isn't authorized
        /// to access the specified Amazon S3 bucket. Verify the <b>SourceS3BucketName</b> and
        /// <b>S3IngestionRoleArn</b> values and try again.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <code>IPV4</code>
        /// and <code>DUAL</code>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromS3">REST API Reference for RestoreDBInstanceFromS3 Operation</seealso>
        public virtual Task<RestoreDBInstanceFromS3Response> RestoreDBInstanceFromS3Async(RestoreDBInstanceFromS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceFromS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBInstanceFromS3Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBInstanceToPointInTime

        internal virtual RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceToPointInTimeResponse>(request, options);
        }



        /// <summary>
        /// Restores a DB instance to an arbitrary point in time. You can restore to any point
        /// in time before the time identified by the LatestRestorableTime property. You can restore
        /// to a point up to the number of days specified by the BackupRetentionPeriod property.
        /// 
        ///  
        /// <para>
        /// The target database is created with most of the original configuration, but in a system-selected
        /// Availability Zone, with the default security group, the default subnet group, and
        /// the default DB parameter group. By default, the new DB instance is created as a single-AZ
        /// deployment except when the instance is a SQL Server instance that has an option group
        /// that is associated with mirroring; in this case, the instance becomes a mirrored deployment
        /// and not a single-AZ deployment.
        /// </para>
        ///  <note> 
        /// <para>
        /// This command doesn't apply to Aurora MySQL and Aurora PostgreSQL. For Aurora, use
        /// <code>RestoreDBClusterToPointInTime</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreDBInstanceToPointInTime service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.BackupPolicyNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupNotFoundException">
        /// No automated backup for this DB instance was found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <code>DBParameterGroupName</code> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <code>Domain</code> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InstanceQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidRestoreException">
        /// Cannot restore from VPC backup to non-VPC DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <code>IPV4</code>
        /// and <code>DUAL</code>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.PointInTimeRestoreNotEnabledException">
        /// <code>SourceDBInstanceIdentifier</code> refers to a DB instance with <code>BackupRetentionPeriod</code>
        /// equal to 0.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ProvisionedIopsNotAvailableInAZException">
        /// Provisioned IOPS not available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceToPointInTime">REST API Reference for RestoreDBInstanceToPointInTime Operation</seealso>
        public virtual Task<RestoreDBInstanceToPointInTimeResponse> RestoreDBInstanceToPointInTimeAsync(RestoreDBInstanceToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBInstanceToPointInTimeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeDBSecurityGroupIngress

        internal virtual RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeDBSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeDBSecurityGroupIngressResponse>(request, options);
        }



        /// <summary>
        /// Revokes ingress from a DBSecurityGroup for previously authorized IP ranges or EC2
        /// or VPC security groups. Required parameters for this API are one of CIDRIP, EC2SecurityGroupId
        /// for VPC, or (EC2SecurityGroupOwnerId and either EC2SecurityGroupName or EC2SecurityGroupId).
        /// 
        ///  <note> 
        /// <para>
        /// EC2-Classic was retired on August 15, 2022. If you haven't migrated from EC2-Classic
        /// to a VPC, we recommend that you migrate as soon as possible. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-migrate.html">Migrate
        /// from EC2-Classic to a VPC</a> in the <i>Amazon EC2 User Guide</i>, the blog <a href="http://aws.amazon.com/blogs/aws/ec2-classic-is-retiring-heres-how-to-prepare/">EC2-Classic
        /// Networking is Retiring – Here’s How to Prepare</a>, and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.Non-VPC2VPC.html">Moving
        /// a DB instance not in a VPC into a VPC</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeDBSecurityGroupIngress service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <code>DBSecurityGroupName</code> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RevokeDBSecurityGroupIngress">REST API Reference for RevokeDBSecurityGroupIngress Operation</seealso>
        public virtual Task<RevokeDBSecurityGroupIngressResponse> RevokeDBSecurityGroupIngressAsync(RevokeDBSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeDBSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeDBSecurityGroupIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartActivityStream

        internal virtual StartActivityStreamResponse StartActivityStream(StartActivityStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartActivityStreamResponseUnmarshaller.Instance;

            return Invoke<StartActivityStreamResponse>(request, options);
        }



        /// <summary>
        /// Starts a database activity stream to monitor activity on the database. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/DBActivityStreams.html">Database
        /// Activity Streams</a> in the <i>Amazon Aurora User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartActivityStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartActivityStream service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartActivityStream">REST API Reference for StartActivityStream Operation</seealso>
        public virtual Task<StartActivityStreamResponse> StartActivityStreamAsync(StartActivityStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartActivityStreamResponseUnmarshaller.Instance;

            return InvokeAsync<StartActivityStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDBCluster

        internal virtual StartDBClusterResponse StartDBCluster(StartDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBClusterResponseUnmarshaller.Instance;

            return Invoke<StartDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Starts an Amazon Aurora DB cluster that was stopped using the Amazon Web Services
        /// console, the stop-db-cluster CLI command, or the StopDBCluster action.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-cluster-stop-start.html">
        /// Stopping and Starting an Aurora Cluster</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBCluster">REST API Reference for StartDBCluster Operation</seealso>
        public virtual Task<StartDBClusterResponse> StartDBClusterAsync(StartDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<StartDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDBInstance

        internal virtual StartDBInstanceResponse StartDBInstance(StartDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBInstanceResponseUnmarshaller.Instance;

            return Invoke<StartDBInstanceResponse>(request, options);
        }



        /// <summary>
        /// Starts an Amazon RDS DB instance that was stopped using the Amazon Web Services console,
        /// the stop-db-instance CLI command, or the StopDBInstance action.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_StartInstance.html">
        /// Starting an Amazon RDS DB instance That Was Previously Stopped</a> in the <i>Amazon
        /// RDS User Guide.</i> 
        /// </para>
        ///  <note> 
        /// <para>
        /// This command doesn't apply to RDS Custom, Aurora MySQL, and Aurora PostgreSQL. For
        /// Aurora DB clusters, use <code>StartDBCluster</code> instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or Amazon EC2 security group might not be authorized for
        /// the specified DB security group.
        /// 
        ///  
        /// <para>
        /// Or, RDS might not be authorized to perform necessary actions using IAM on your behalf.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <code>DBSubnetGroupName</code> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBInstance">REST API Reference for StartDBInstance Operation</seealso>
        public virtual Task<StartDBInstanceResponse> StartDBInstanceAsync(StartDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StartDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDBInstanceAutomatedBackupsReplication

        internal virtual StartDBInstanceAutomatedBackupsReplicationResponse StartDBInstanceAutomatedBackupsReplication(StartDBInstanceAutomatedBackupsReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDBInstanceAutomatedBackupsReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance;

            return Invoke<StartDBInstanceAutomatedBackupsReplicationResponse>(request, options);
        }



        /// <summary>
        /// Enables replication of automated backups to a different Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReplicateBackups.html">
        /// Replicating Automated Backups to Another Amazon Web Services Region</a> in the <i>Amazon
        /// RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDBInstanceAutomatedBackupsReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDBInstanceAutomatedBackupsReplication service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupQuotaExceededException">
        /// The quota for retained automated backups was exceeded. This prevents you from retaining
        /// any additional automated backups. The retained automated backups quota is the same
        /// as your DB Instance quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// Storage of the <code>StorageType</code> specified can't be associated with the DB
        /// instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBInstanceAutomatedBackupsReplication">REST API Reference for StartDBInstanceAutomatedBackupsReplication Operation</seealso>
        public virtual Task<StartDBInstanceAutomatedBackupsReplicationResponse> StartDBInstanceAutomatedBackupsReplicationAsync(StartDBInstanceAutomatedBackupsReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDBInstanceAutomatedBackupsReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StartDBInstanceAutomatedBackupsReplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartExportTask

        internal virtual StartExportTaskResponse StartExportTask(StartExportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportTaskResponseUnmarshaller.Instance;

            return Invoke<StartExportTaskResponse>(request, options);
        }



        /// <summary>
        /// Starts an export of a snapshot to Amazon S3. The provided IAM role must have access
        /// to the S3 bucket.
        /// 
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartExportTask service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <code>DBClusterSnapshotIdentifier</code> doesn't refer to an existing DB cluster
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <code>DBSnapshotIdentifier</code> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ExportTaskAlreadyExistsException">
        /// You can't start an export task that's already running.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IamRoleMissingPermissionsException">
        /// The IAM role requires additional permissions to export to an Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IamRoleNotFoundException">
        /// The IAM role is missing for exporting to an Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidExportOnlyException">
        /// The export is invalid for exporting to an Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidExportSourceStateException">
        /// The state of the export snapshot is invalid for exporting to an Amazon S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidS3BucketException">
        /// The specified Amazon S3 bucket name can't be found or Amazon RDS isn't authorized
        /// to access the specified Amazon S3 bucket. Verify the <b>SourceS3BucketName</b> and
        /// <b>S3IngestionRoleArn</b> values and try again.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartExportTask">REST API Reference for StartExportTask Operation</seealso>
        public virtual Task<StartExportTaskResponse> StartExportTaskAsync(StartExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartExportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopActivityStream

        internal virtual StopActivityStreamResponse StopActivityStream(StopActivityStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopActivityStreamResponseUnmarshaller.Instance;

            return Invoke<StopActivityStreamResponse>(request, options);
        }



        /// <summary>
        /// Stops a database activity stream that was started using the Amazon Web Services console,
        /// the <code>start-activity-stream</code> CLI command, or the <code>StartActivityStream</code>
        /// action.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/DBActivityStreams.html">Database
        /// Activity Streams</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopActivityStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopActivityStream service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopActivityStream">REST API Reference for StopActivityStream Operation</seealso>
        public virtual Task<StopActivityStreamResponse> StopActivityStreamAsync(StopActivityStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopActivityStreamResponseUnmarshaller.Instance;

            return InvokeAsync<StopActivityStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopDBCluster

        internal virtual StopDBClusterResponse StopDBCluster(StopDBClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBClusterResponseUnmarshaller.Instance;

            return Invoke<StopDBClusterResponse>(request, options);
        }



        /// <summary>
        /// Stops an Amazon Aurora DB cluster. When you stop a DB cluster, Aurora retains the
        /// DB cluster's metadata, including its endpoints and DB parameter groups. Aurora also
        /// retains the transaction logs so you can do a point-in-time restore if necessary.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-cluster-stop-start.html">
        /// Stopping and Starting an Aurora Cluster</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <code>DBClusterIdentifier</code> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBCluster">REST API Reference for StopDBCluster Operation</seealso>
        public virtual Task<StopDBClusterResponse> StopDBClusterAsync(StopDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<StopDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopDBInstance

        internal virtual StopDBInstanceResponse StopDBInstance(StopDBInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBInstanceResponseUnmarshaller.Instance;

            return Invoke<StopDBInstanceResponse>(request, options);
        }



        /// <summary>
        /// Stops an Amazon RDS DB instance. When you stop a DB instance, Amazon RDS retains the
        /// DB instance's metadata, including its endpoint, DB parameter group, and option group
        /// membership. Amazon RDS also retains the transaction logs so you can do a point-in-time
        /// restore if necessary.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_StopInstance.html">
        /// Stopping an Amazon RDS DB Instance Temporarily</a> in the <i>Amazon RDS User Guide.</i>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// This command doesn't apply to RDS Custom, Aurora MySQL, and Aurora PostgreSQL. For
        /// Aurora clusters, use <code>StopDBCluster</code> instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <code>DBSnapshotIdentifier</code> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBInstance">REST API Reference for StopDBInstance Operation</seealso>
        public virtual Task<StopDBInstanceResponse> StopDBInstanceAsync(StopDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StopDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopDBInstanceAutomatedBackupsReplication

        internal virtual StopDBInstanceAutomatedBackupsReplicationResponse StopDBInstanceAutomatedBackupsReplication(StopDBInstanceAutomatedBackupsReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDBInstanceAutomatedBackupsReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance;

            return Invoke<StopDBInstanceAutomatedBackupsReplicationResponse>(request, options);
        }



        /// <summary>
        /// Stops automated backup replication for a DB instance.
        /// 
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom, Aurora MySQL, and Aurora PostgreSQL.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReplicateBackups.html">
        /// Replicating Automated Backups to Another Amazon Web Services Region</a> in the <i>Amazon
        /// RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDBInstanceAutomatedBackupsReplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDBInstanceAutomatedBackupsReplication service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBInstanceAutomatedBackupsReplication">REST API Reference for StopDBInstanceAutomatedBackupsReplication Operation</seealso>
        public virtual Task<StopDBInstanceAutomatedBackupsReplicationResponse> StopDBInstanceAutomatedBackupsReplicationAsync(StopDBInstanceAutomatedBackupsReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDBInstanceAutomatedBackupsReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StopDBInstanceAutomatedBackupsReplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SwitchoverBlueGreenDeployment

        internal virtual SwitchoverBlueGreenDeploymentResponse SwitchoverBlueGreenDeployment(SwitchoverBlueGreenDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SwitchoverBlueGreenDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverBlueGreenDeploymentResponseUnmarshaller.Instance;

            return Invoke<SwitchoverBlueGreenDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Switches over a blue/green deployment.
        /// 
        ///  
        /// <para>
        /// Before you switch over, production traffic is routed to the databases in the blue
        /// environment. After you switch over, production traffic is routed to the databases
        /// in the green environment.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/blue-green-deployments.html">Using
        /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon RDS User
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">
        /// Using Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon
        /// Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwitchoverBlueGreenDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SwitchoverBlueGreenDeployment service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <code>BlueGreenDeploymentIdentifier</code> doesn't refer to an existing blue/green
        /// deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidBlueGreenDeploymentStateException">
        /// The blue/green deployment can't be switched over or deleted because there is an invalid
        /// configuration in the green environment.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/SwitchoverBlueGreenDeployment">REST API Reference for SwitchoverBlueGreenDeployment Operation</seealso>
        public virtual Task<SwitchoverBlueGreenDeploymentResponse> SwitchoverBlueGreenDeploymentAsync(SwitchoverBlueGreenDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SwitchoverBlueGreenDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverBlueGreenDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<SwitchoverBlueGreenDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SwitchoverReadReplica

        internal virtual SwitchoverReadReplicaResponse SwitchoverReadReplica(SwitchoverReadReplicaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SwitchoverReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverReadReplicaResponseUnmarshaller.Instance;

            return Invoke<SwitchoverReadReplicaResponse>(request, options);
        }



        /// <summary>
        /// Switches over an Oracle standby database in an Oracle Data Guard environment, making
        /// it the new primary database. Issue this command in the Region that hosts the current
        /// standby database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwitchoverReadReplica service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SwitchoverReadReplica service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <code>DBInstanceIdentifier</code> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/SwitchoverReadReplica">REST API Reference for SwitchoverReadReplica Operation</seealso>
        public virtual Task<SwitchoverReadReplicaResponse> SwitchoverReadReplicaAsync(SwitchoverReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SwitchoverReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverReadReplicaResponseUnmarshaller.Instance;

            return InvokeAsync<SwitchoverReadReplicaResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}