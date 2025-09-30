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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.RDS
{
    /// <summary>
    /// <para>Implementation for accessing RDS</para>
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
    /// SQL Server, Oracle, Db2, or Amazon Aurora database server. These capabilities mean
    /// that the code, applications, and tools you already use today with your existing databases
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
            : base(new AmazonRDSConfig()) { }

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
            : base(new AmazonRDSConfig{RegionEndpoint = region}) { }

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
            : base(config) { }

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

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.RDS.Internal.PreSignedUrlRequestHandler(this.ExplicitAWSCredentials ?? this.Config.DefaultAWSCredentials));
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRDSEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRDSAuthSchemeHandler());
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


        /// <summary>
        /// Associates an Identity and Access Management (IAM) role with a DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBCluster service method.</param>
        /// 
        /// <returns>The response from the AddRoleToDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
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
        public virtual AddRoleToDBClusterResponse AddRoleToDBCluster(AddRoleToDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddRoleToDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToDBClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddRoleToDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddRoleToDBInstance


        /// <summary>
        /// Associates an Amazon Web Services Identity and Access Management (IAM) role with a
        /// DB instance.
        /// 
        ///  <note> 
        /// <para>
        /// To add a role to a DB instance, the status of the DB instance must be <c>available</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBInstance service method.</param>
        /// 
        /// <returns>The response from the AddRoleToDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceRoleAlreadyExistsException">
        /// The specified <c>RoleArn</c> or <c>FeatureName</c> value is already associated with
        /// the DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceRoleQuotaExceededException">
        /// You can't associate any more Amazon Web Services Identity and Access Management (IAM)
        /// roles with the DB instance because the quota has been reached.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddRoleToDBInstance">REST API Reference for AddRoleToDBInstance Operation</seealso>
        public virtual AddRoleToDBInstanceResponse AddRoleToDBInstance(AddRoleToDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// To add a role to a DB instance, the status of the DB instance must be <c>available</c>.
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
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceRoleAlreadyExistsException">
        /// The specified <c>RoleArn</c> or <c>FeatureName</c> value is already associated with
        /// the DB instance.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddRoleToDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddRoleToDBInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddRoleToDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddSourceIdentifierToSubscription


        /// <summary>
        /// Adds a source identifier to an existing RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription service method.</param>
        /// 
        /// <returns>The response from the AddSourceIdentifierToSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        public virtual AddSourceIdentifierToSubscriptionResponse AddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddSourceIdentifierToSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddSourceIdentifierToSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddTagsToResource


        /// <summary>
        /// Adds metadata tags to an Amazon RDS resource. These tags can also be used with cost
        /// allocation reporting to track cost associated with Amazon RDS resources, or used in
        /// a Condition statement in an IAM policy for Amazon RDS.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging your relational database resources, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html">Tagging
        /// Amazon RDS Resources</a> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Tagging.html">Tagging
        /// Amazon Aurora and Amazon RDS Resources</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <c>BlueGreenDeploymentIdentifier</c> doesn't refer to an existing blue/green deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyEndpointNotFoundException">
        /// The DB proxy endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotTenantDatabaseNotFoundException">
        /// The specified snapshot tenant database wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationNotFoundException">
        /// The specified integration could not be found.
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
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseNotFoundException">
        /// The specified tenant database wasn't found in the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// For an overview on tagging your relational database resources, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html">Tagging
        /// Amazon RDS Resources</a> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Tagging.html">Tagging
        /// Amazon Aurora and Amazon RDS Resources</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <c>BlueGreenDeploymentIdentifier</c> doesn't refer to an existing blue/green deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyEndpointNotFoundException">
        /// The DB proxy endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotTenantDatabaseNotFoundException">
        /// The specified snapshot tenant database wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationNotFoundException">
        /// The specified integration could not be found.
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
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseNotFoundException">
        /// The specified tenant database wasn't found in the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<AddTagsToResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ApplyPendingMaintenanceAction


        /// <summary>
        /// Applies a pending maintenance action to a resource (for example, to a DB instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction service method.</param>
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
        public virtual ApplyPendingMaintenanceActionResponse ApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ApplyPendingMaintenanceActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeDBSecurityGroupIngress


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
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AuthorizeDBSecurityGroupIngress">REST API Reference for AuthorizeDBSecurityGroupIngress Operation</seealso>
        public virtual AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AuthorizeDBSecurityGroupIngress">REST API Reference for AuthorizeDBSecurityGroupIngress Operation</seealso>
        public virtual Task<AuthorizeDBSecurityGroupIngressResponse> AuthorizeDBSecurityGroupIngressAsync(AuthorizeDBSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AuthorizeDBSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance;
            
            return InvokeAsync<AuthorizeDBSecurityGroupIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BacktrackDBCluster


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
        /// 
        /// <returns>The response from the BacktrackDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/BacktrackDBCluster">REST API Reference for BacktrackDBCluster Operation</seealso>
        public virtual BacktrackDBClusterResponse BacktrackDBCluster(BacktrackDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/BacktrackDBCluster">REST API Reference for BacktrackDBCluster Operation</seealso>
        public virtual Task<BacktrackDBClusterResponse> BacktrackDBClusterAsync(BacktrackDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BacktrackDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BacktrackDBClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<BacktrackDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelExportTask


        /// <summary>
        /// Cancels an export task in progress that is exporting a snapshot or cluster to Amazon
        /// S3. Any data that has already been written to the S3 bucket isn't removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method.</param>
        /// 
        /// <returns>The response from the CancelExportTask service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ExportTaskNotFoundException">
        /// The export task doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidExportTaskStateException">
        /// You can't cancel an export task that has completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelExportTaskResponse>(request, options);
        }


        /// <summary>
        /// Cancels an export task in progress that is exporting a snapshot or cluster to Amazon
        /// S3. Any data that has already been written to the S3 bucket isn't removed.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelExportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyDBClusterParameterGroup


        /// <summary>
        /// Copies the specified DB cluster parameter group.
        /// 
        ///  <note> 
        /// <para>
        /// You can't copy a default DB cluster parameter group. Instead, create a new custom
        /// DB cluster parameter group, which copies the default parameters and values for the
        /// specified DB cluster parameter group family.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CopyDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB parameter
        /// groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        public virtual CopyDBClusterParameterGroupResponse CopyDBClusterParameterGroup(CopyDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Copies the specified DB cluster parameter group.
        /// 
        ///  <note> 
        /// <para>
        /// You can't copy a default DB cluster parameter group. Instead, create a new custom
        /// DB cluster parameter group, which copies the default parameters and values for the
        /// specified DB cluster parameter group family.
        /// </para>
        ///  </note>
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
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB parameter
        /// groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        public virtual Task<CopyDBClusterParameterGroupResponse> CopyDBClusterParameterGroupAsync(CopyDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterParameterGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CopyDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyDBClusterSnapshot


        /// <summary>
        /// Copies a snapshot of a DB cluster.
        /// 
        ///  
        /// <para>
        /// To copy a DB cluster snapshot from a shared manual DB cluster snapshot, <c>SourceDBClusterSnapshotIdentifier</c>
        /// must be the Amazon Resource Name (ARN) of the shared DB cluster snapshot.
        /// </para>
        ///  
        /// <para>
        /// You can copy an encrypted DB cluster snapshot from another Amazon Web Services Region.
        /// In that case, the Amazon Web Services Region where you call the <c>CopyDBClusterSnapshot</c>
        /// operation is the destination Amazon Web Services Region for the encrypted DB cluster
        /// snapshot to be copied to. To copy an encrypted DB cluster snapshot from another Amazon
        /// Web Services Region, you must provide the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KmsKeyId</c> - The Amazon Web Services Key Management System (Amazon Web Services
        /// KMS) key identifier for the key to use to encrypt the copy of the DB cluster snapshot
        /// in the destination Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TargetDBClusterSnapshotIdentifier</c> - The identifier for the new copy of the
        /// DB cluster snapshot in the destination Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SourceDBClusterSnapshotIdentifier</c> - The DB cluster snapshot identifier for
        /// the encrypted DB cluster snapshot to be copied. This identifier must be in the ARN
        /// format for the source Amazon Web Services Region and is the same value as the <c>SourceDBClusterSnapshotIdentifier</c>
        /// in the presigned URL.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To cancel the copy operation once it is in progress, delete the target DB cluster
        /// snapshot identified by <c>TargetDBClusterSnapshotIdentifier</c> while that DB cluster
        /// snapshot is in "copying" status.
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotAlreadyExistsException">
        /// The user already has a DB cluster snapshot with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
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
        public virtual CopyDBClusterSnapshotResponse CopyDBClusterSnapshot(CopyDBClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Copies a snapshot of a DB cluster.
        /// 
        ///  
        /// <para>
        /// To copy a DB cluster snapshot from a shared manual DB cluster snapshot, <c>SourceDBClusterSnapshotIdentifier</c>
        /// must be the Amazon Resource Name (ARN) of the shared DB cluster snapshot.
        /// </para>
        ///  
        /// <para>
        /// You can copy an encrypted DB cluster snapshot from another Amazon Web Services Region.
        /// In that case, the Amazon Web Services Region where you call the <c>CopyDBClusterSnapshot</c>
        /// operation is the destination Amazon Web Services Region for the encrypted DB cluster
        /// snapshot to be copied to. To copy an encrypted DB cluster snapshot from another Amazon
        /// Web Services Region, you must provide the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KmsKeyId</c> - The Amazon Web Services Key Management System (Amazon Web Services
        /// KMS) key identifier for the key to use to encrypt the copy of the DB cluster snapshot
        /// in the destination Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TargetDBClusterSnapshotIdentifier</c> - The identifier for the new copy of the
        /// DB cluster snapshot in the destination Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SourceDBClusterSnapshotIdentifier</c> - The DB cluster snapshot identifier for
        /// the encrypted DB cluster snapshot to be copied. This identifier must be in the ARN
        /// format for the source Amazon Web Services Region and is the same value as the <c>SourceDBClusterSnapshotIdentifier</c>
        /// in the presigned URL.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To cancel the copy operation once it is in progress, delete the target DB cluster
        /// snapshot identified by <c>TargetDBClusterSnapshotIdentifier</c> while that DB cluster
        /// snapshot is in "copying" status.
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
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
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBClusterSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CopyDBClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyDBParameterGroup


        /// <summary>
        /// Copies the specified DB parameter group.
        /// 
        ///  <note> 
        /// <para>
        /// You can't copy a default DB parameter group. Instead, create a new custom DB parameter
        /// group, which copies the default parameters and values for the specified DB parameter
        /// group family.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CopyDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupAlreadyExistsException">
        /// A DB parameter group with the same name exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB parameter
        /// groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBParameterGroup">REST API Reference for CopyDBParameterGroup Operation</seealso>
        public virtual CopyDBParameterGroupResponse CopyDBParameterGroup(CopyDBParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Copies the specified DB parameter group.
        /// 
        ///  <note> 
        /// <para>
        /// You can't copy a default DB parameter group. Instead, create a new custom DB parameter
        /// group, which copies the default parameters and values for the specified DB parameter
        /// group family.
        /// </para>
        ///  </note>
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
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB parameter
        /// groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBParameterGroup">REST API Reference for CopyDBParameterGroup Operation</seealso>
        public virtual Task<CopyDBParameterGroupResponse> CopyDBParameterGroupAsync(CopyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CopyDBParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyDBSnapshot


        /// <summary>
        /// Copies the specified DB snapshot. The source DB snapshot must be in the <c>available</c>
        /// state.
        /// 
        ///  
        /// <para>
        /// You can copy a snapshot from one Amazon Web Services Region to another. In that case,
        /// the Amazon Web Services Region where you call the <c>CopyDBSnapshot</c> operation
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
        /// 
        /// <returns>The response from the CopyDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CustomAvailabilityZoneNotFoundException">
        /// <c>CustomAvailabilityZoneId</c> doesn't refer to an existing custom Availability
        /// Zone identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <c>DBSnapshotIdentifier</c> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
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
        public virtual CopyDBSnapshotResponse CopyDBSnapshot(CopyDBSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyDBSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Copies the specified DB snapshot. The source DB snapshot must be in the <c>available</c>
        /// state.
        /// 
        ///  
        /// <para>
        /// You can copy a snapshot from one Amazon Web Services Region to another. In that case,
        /// the Amazon Web Services Region where you call the <c>CopyDBSnapshot</c> operation
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
        /// <c>CustomAvailabilityZoneId</c> doesn't refer to an existing custom Availability
        /// Zone identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <c>DBSnapshotIdentifier</c> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyDBSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CopyDBSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyOptionGroup


        /// <summary>
        /// Copies the specified option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyOptionGroup service method.</param>
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
        public virtual CopyOptionGroupResponse CopyOptionGroup(CopyOptionGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CopyOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyOptionGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CopyOptionGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBlueGreenDeployment


        /// <summary>
        /// Creates a blue/green deployment.
        /// 
        ///  
        /// <para>
        /// A blue/green deployment creates a staging environment that copies the production environment.
        /// In a blue/green deployment, the blue environment is the current production environment.
        /// The green environment is the staging environment, and it stays in sync with the current
        /// production environment.
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
        /// 
        /// <returns>The response from the CreateBlueGreenDeployment service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentAlreadyExistsException">
        /// A blue/green deployment with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing DB cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
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
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateBlueGreenDeployment">REST API Reference for CreateBlueGreenDeployment Operation</seealso>
        public virtual CreateBlueGreenDeploymentResponse CreateBlueGreenDeployment(CreateBlueGreenDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The green environment is the staging environment, and it stays in sync with the current
        /// production environment.
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing DB cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
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
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateBlueGreenDeployment">REST API Reference for CreateBlueGreenDeployment Operation</seealso>
        public virtual Task<CreateBlueGreenDeploymentResponse> CreateBlueGreenDeploymentAsync(CreateBlueGreenDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBlueGreenDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBlueGreenDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBlueGreenDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomDBEngineVersion


        /// <summary>
        /// Creates a custom DB engine version (CEV).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomDBEngineVersion service method.</param>
        /// 
        /// <returns>The response from the CreateCustomDBEngineVersion service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CreateCustomDBEngineVersionException">
        /// An error occurred while trying to create the CEV.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.CustomDBEngineVersionAlreadyExistsException">
        /// A CEV with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.CustomDBEngineVersionNotFoundException">
        /// The specified CEV was not found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.CustomDBEngineVersionQuotaExceededException">
        /// You have exceeded your CEV quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.Ec2ImagePropertiesNotSupportedException">
        /// The AMI configuration prerequisite has not been met.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidCustomDBEngineVersionStateException">
        /// You can't delete the CEV.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateCustomDBEngineVersion">REST API Reference for CreateCustomDBEngineVersion Operation</seealso>
        public virtual CreateCustomDBEngineVersionResponse CreateCustomDBEngineVersion(CreateCustomDBEngineVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <exception cref="Amazon.RDS.Model.CreateCustomDBEngineVersionException">
        /// An error occurred while trying to create the CEV.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.CustomDBEngineVersionAlreadyExistsException">
        /// A CEV with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.CustomDBEngineVersionNotFoundException">
        /// The specified CEV was not found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.CustomDBEngineVersionQuotaExceededException">
        /// You have exceeded your CEV quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.Ec2ImagePropertiesNotSupportedException">
        /// The AMI configuration prerequisite has not been met.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidCustomDBEngineVersionStateException">
        /// You can't delete the CEV.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateCustomDBEngineVersion">REST API Reference for CreateCustomDBEngineVersion Operation</seealso>
        public virtual Task<CreateCustomDBEngineVersionResponse> CreateCustomDBEngineVersionAsync(CreateCustomDBEngineVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomDBEngineVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomDBEngineVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCustomDBEngineVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBCluster


        /// <summary>
        /// Creates a new Amazon Aurora DB cluster or Multi-AZ DB cluster.
        /// 
        ///  
        /// <para>
        /// If you create an Aurora DB cluster, the request creates an empty cluster. You must
        /// explicitly create the writer instance for your DB cluster using the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_CreateDBInstance.html">CreateDBInstance</a>
        /// operation. If you create a Multi-AZ DB cluster, the request creates a writer and two
        /// reader DB instances for you, each in a different Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>ReplicationSourceIdentifier</c> parameter to create an Amazon Aurora
        /// DB cluster as a read replica of another DB cluster or Amazon RDS for MySQL or PostgreSQL
        /// DB instance. For more information about Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">What
        /// is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can also use the <c>ReplicationSourceIdentifier</c> parameter to create a Multi-AZ
        /// DB cluster read replica with an RDS for MySQL or PostgreSQL DB instance as the source.
        /// For more information about Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">Multi-AZ
        /// DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster service method.</param>
        /// 
        /// <returns>The response from the CreateDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing DB cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
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
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupException">
        /// The DBSubnetGroup doesn't belong to the same VPC as that of an existing cross-region
        /// read replica of the same source instance.
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
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual CreateDBClusterResponse CreateDBCluster(CreateDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Amazon Aurora DB cluster or Multi-AZ DB cluster.
        /// 
        ///  
        /// <para>
        /// If you create an Aurora DB cluster, the request creates an empty cluster. You must
        /// explicitly create the writer instance for your DB cluster using the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_CreateDBInstance.html">CreateDBInstance</a>
        /// operation. If you create a Multi-AZ DB cluster, the request creates a writer and two
        /// reader DB instances for you, each in a different Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>ReplicationSourceIdentifier</c> parameter to create an Amazon Aurora
        /// DB cluster as a read replica of another DB cluster or Amazon RDS for MySQL or PostgreSQL
        /// DB instance. For more information about Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">What
        /// is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can also use the <c>ReplicationSourceIdentifier</c> parameter to create a Multi-AZ
        /// DB cluster read replica with an RDS for MySQL or PostgreSQL DB instance as the source.
        /// For more information about Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">Multi-AZ
        /// DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing DB cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
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
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupException">
        /// The DBSubnetGroup doesn't belong to the same VPC as that of an existing cross-region
        /// read replica of the same source instance.
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
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual Task<CreateDBClusterResponse> CreateDBClusterAsync(CreateDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBClusterEndpoint


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
        /// 
        /// <returns>The response from the CreateDBClusterEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterEndpointAlreadyExistsException">
        /// The specified custom endpoint can't be created because it already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterEndpointQuotaExceededException">
        /// The cluster already has the maximum number of custom endpoints.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterEndpoint">REST API Reference for CreateDBClusterEndpoint Operation</seealso>
        public virtual CreateDBClusterEndpointResponse CreateDBClusterEndpoint(CreateDBClusterEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDBClusterEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBClusterParameterGroup


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
        /// for any of the parameters, you must modify the group after creating it using <c>ModifyDBClusterParameterGroup</c>.
        /// Once you've created a DB cluster parameter group, you need to associate it with your
        /// DB cluster using <c>ModifyDBCluster</c>.
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
        /// by the <c>character_set_database</c> parameter. You can use the <i>Parameter Groups</i>
        /// option of the <a href="https://console.aws.amazon.com/rds/">Amazon RDS console</a>
        /// or the <c>DescribeDBClusterParameters</c> operation to verify that your DB cluster
        /// parameter group has been created or modified.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup service method.</param>
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
        public virtual CreateDBClusterParameterGroupResponse CreateDBClusterParameterGroup(CreateDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// for any of the parameters, you must modify the group after creating it using <c>ModifyDBClusterParameterGroup</c>.
        /// Once you've created a DB cluster parameter group, you need to associate it with your
        /// DB cluster using <c>ModifyDBCluster</c>.
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
        /// by the <c>character_set_database</c> parameter. You can use the <i>Parameter Groups</i>
        /// option of the <a href="https://console.aws.amazon.com/rds/">Amazon RDS console</a>
        /// or the <c>DescribeDBClusterParameters</c> operation to verify that your DB cluster
        /// parameter group has been created or modified.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterParameterGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBClusterSnapshot


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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
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
        public virtual CreateDBClusterSnapshotResponse CreateDBClusterSnapshot(CreateDBClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBClusterSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDBClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBInstance


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
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
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
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseQuotaExceededException">
        /// You attempted to create more tenant databases than are permitted in your Amazon Web
        /// Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
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
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseQuotaExceededException">
        /// You attempted to create more tenant databases than are permitted in your Amazon Web
        /// Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBInstanceReadReplica


        /// <summary>
        /// Creates a new DB instance that acts as a read replica for an existing source DB instance
        /// or Multi-AZ DB cluster. You can create a read replica for a DB instance running Db2,
        /// MariaDB, MySQL, Oracle, PostgreSQL, or SQL Server. You can create a read replica for
        /// a Multi-AZ DB cluster running MySQL or PostgreSQL. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReadRepl.html">Working
        /// with read replicas</a> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html#multi-az-db-clusters-migrating-to-instance-with-read-replica">Migrating
        /// from a Multi-AZ DB cluster to a DB instance using a read replica</a> in the <i>Amazon
        /// RDS User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Amazon Aurora doesn't support this operation. To create a DB instance for an Aurora
        /// DB cluster, use the <c>CreateDBInstance</c> operation.
        /// </para>
        ///  
        /// <para>
        /// RDS creates read replicas with backups disabled. All other attributes (including DB
        /// security groups and DB parameter groups) are inherited from the source DB instance
        /// or cluster, except as specified.
        /// </para>
        ///  <important> 
        /// <para>
        /// Your source DB instance or cluster must have backup retention enabled.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstanceReadReplica service method.</param>
        /// 
        /// <returns>The response from the CreateDBInstanceReadReplica service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
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
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
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
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseQuotaExceededException">
        /// You attempted to create more tenant databases than are permitted in your Amazon Web
        /// Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstanceReadReplica">REST API Reference for CreateDBInstanceReadReplica Operation</seealso>
        public virtual CreateDBInstanceReadReplicaResponse CreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceReadReplicaResponse>(request, options);
        }


        /// <summary>
        /// Creates a new DB instance that acts as a read replica for an existing source DB instance
        /// or Multi-AZ DB cluster. You can create a read replica for a DB instance running Db2,
        /// MariaDB, MySQL, Oracle, PostgreSQL, or SQL Server. You can create a read replica for
        /// a Multi-AZ DB cluster running MySQL or PostgreSQL. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ReadRepl.html">Working
        /// with read replicas</a> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html#multi-az-db-clusters-migrating-to-instance-with-read-replica">Migrating
        /// from a Multi-AZ DB cluster to a DB instance using a read replica</a> in the <i>Amazon
        /// RDS User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Amazon Aurora doesn't support this operation. To create a DB instance for an Aurora
        /// DB cluster, use the <c>CreateDBInstance</c> operation.
        /// </para>
        ///  
        /// <para>
        /// RDS creates read replicas with backups disabled. All other attributes (including DB
        /// security groups and DB parameter groups) are inherited from the source DB instance
        /// or cluster, except as specified.
        /// </para>
        ///  <important> 
        /// <para>
        /// Your source DB instance or cluster must have backup retention enabled.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstanceReadReplica service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBInstanceReadReplica service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
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
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
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
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseQuotaExceededException">
        /// You attempted to create more tenant databases than are permitted in your Amazon Web
        /// Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstanceReadReplica">REST API Reference for CreateDBInstanceReadReplica Operation</seealso>
        public virtual Task<CreateDBInstanceReadReplicaResponse> CreateDBInstanceReadReplicaAsync(CreateDBInstanceReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBInstanceReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDBInstanceReadReplicaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBParameterGroup


        /// <summary>
        /// Creates a new DB parameter group.
        /// 
        ///  
        /// <para>
        /// A DB parameter group is initially created with the default parameters for the database
        /// engine used by the DB instance. To provide custom values for any of the parameters,
        /// you must modify the group after creating it using <c>ModifyDBParameterGroup</c>. Once
        /// you've created a DB parameter group, you need to associate it with your DB instance
        /// using <c>ModifyDBInstance</c>. When you associate a new DB parameter group with a
        /// running DB instance, you need to reboot the DB instance without failover for the new
        /// DB parameter group and associated settings to take effect.
        /// </para>
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup service method.</param>
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
        public virtual CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// you must modify the group after creating it using <c>ModifyDBParameterGroup</c>. Once
        /// you've created a DB parameter group, you need to associate it with your DB instance
        /// using <c>ModifyDBInstance</c>. When you associate a new DB parameter group with a
        /// running DB instance, you need to reboot the DB instance without failover for the new
        /// DB parameter group and associated settings to take effect.
        /// </para>
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDBParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBProxy


        /// <summary>
        /// Creates a new DB proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBProxy service method.</param>
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
        public virtual CreateDBProxyResponse CreateDBProxy(CreateDBProxyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBProxyResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDBProxyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBProxyEndpoint


        /// <summary>
        /// Creates a <c>DBProxyEndpoint</c>. Only applies to proxies that are associated with
        /// Aurora DB clusters. You can use DB proxy endpoints to specify read/write or read-only
        /// access to the DB cluster. You can also use DB proxy endpoints to access a DB proxy
        /// through a different VPC than the proxy's default VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBProxyEndpoint service method.</param>
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
        public virtual CreateDBProxyEndpointResponse CreateDBProxyEndpoint(CreateDBProxyEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBProxyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBProxyEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateDBProxyEndpointResponse>(request, options);
        }


        /// <summary>
        /// Creates a <c>DBProxyEndpoint</c>. Only applies to proxies that are associated with
        /// Aurora DB clusters. You can use DB proxy endpoints to specify read/write or read-only
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBProxyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBProxyEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDBProxyEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSecurityGroup


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
        /// 
        /// <returns>The response from the CreateDBSecurityGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupAlreadyExistsException">
        /// A DB security group with the name specified in <c>DBSecurityGroupName</c> already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotSupportedException">
        /// A DB security group isn't allowed for this action.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB security groups.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSecurityGroup">REST API Reference for CreateDBSecurityGroup Operation</seealso>
        public virtual CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// A DB security group with the name specified in <c>DBSecurityGroupName</c> already
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSecurityGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDBSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBShardGroup


        /// <summary>
        /// Creates a new DB shard group for Aurora Limitless Database. You must enable Aurora
        /// Limitless Database to create a DB shard group.
        /// 
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBShardGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBShardGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupAlreadyExistsException">
        /// The specified DB shard group name must be unique in your Amazon Web Services account
        /// in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.MaxDBShardGroupLimitReachedException">
        /// The maximum number of DB shard groups for your Amazon Web Services account in the
        /// specified Amazon Web Services Region has been reached.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.UnsupportedDBEngineVersionException">
        /// The specified DB engine version isn't supported for Aurora Limitless Database.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBShardGroup">REST API Reference for CreateDBShardGroup Operation</seealso>
        public virtual CreateDBShardGroupResponse CreateDBShardGroup(CreateDBShardGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBShardGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBShardGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBShardGroupResponse>(request, options);
        }


        /// <summary>
        /// Creates a new DB shard group for Aurora Limitless Database. You must enable Aurora
        /// Limitless Database to create a DB shard group.
        /// 
        ///  
        /// <para>
        /// Valid for: Aurora DB clusters only
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBShardGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBShardGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupAlreadyExistsException">
        /// The specified DB shard group name must be unique in your Amazon Web Services account
        /// in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidVPCNetworkStateException">
        /// The DB subnet group doesn't cover all Availability Zones after it's created because
        /// of users' change.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.MaxDBShardGroupLimitReachedException">
        /// The maximum number of DB shard groups for your Amazon Web Services account in the
        /// specified Amazon Web Services Region has been reached.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.UnsupportedDBEngineVersionException">
        /// The specified DB engine version isn't supported for Aurora Limitless Database.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBShardGroup">REST API Reference for CreateDBShardGroup Operation</seealso>
        public virtual Task<CreateDBShardGroupResponse> CreateDBShardGroupAsync(CreateDBShardGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBShardGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBShardGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDBShardGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSnapshot


        /// <summary>
        /// Creates a snapshot of a DB instance. The source DB instance must be in the <c>available</c>
        /// or <c>storage-optimization</c> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <c>DBSnapshotIdentifier</c> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSnapshot">REST API Reference for CreateDBSnapshot Operation</seealso>
        public virtual CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDBSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Creates a snapshot of a DB instance. The source DB instance must be in the <c>available</c>
        /// or <c>storage-optimization</c> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <c>DBSnapshotIdentifier</c> is already used by an existing snapshot.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDBSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSubnetGroup


        /// <summary>
        /// Creates a new DB subnet group. DB subnet groups must contain at least one subnet in
        /// at least two AZs in the Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupAlreadyExistsException">
        /// <c>DBSubnetGroupName</c> is already used by an existing DB subnet group.
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
        public virtual CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBSubnetGroupName</c> is already used by an existing DB subnet group.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDBSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEventSubscription


        /// <summary>
        /// Creates an RDS event notification subscription. This operation requires a topic Amazon
        /// Resource Name (ARN) created by either the RDS console, the SNS console, or the SNS
        /// API. To obtain an ARN with SNS, you must create a topic in Amazon SNS and subscribe
        /// to the topic. The ARN is displayed in the SNS console.
        /// 
        ///  
        /// <para>
        /// You can specify the type of source (<c>SourceType</c>) that you want to be notified
        /// of and provide a list of RDS sources (<c>SourceIds</c>) that triggers the events.
        /// You can also provide a list of event categories (<c>EventCategories</c>) for events
        /// that you want to be notified of. For example, you can specify <c>SourceType</c> =
        /// <c>db-instance</c>, <c>SourceIds</c> = <c>mydbinstance1</c>, <c>mydbinstance2</c>
        /// and <c>EventCategories</c> = <c>Availability</c>, <c>Backup</c>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the <c>SourceType</c> and <c>SourceIds</c>, such as <c>SourceType</c>
        /// = <c>db-instance</c> and <c>SourceIds</c> = <c>myDBInstance1</c>, you are notified
        /// of all the <c>db-instance</c> events for the specified source. If you specify a <c>SourceType</c>
        /// but do not specify <c>SourceIds</c>, you receive notice of the events for that source
        /// type for all your RDS sources. If you don't specify either the SourceType or the <c>SourceIds</c>,
        /// you are notified of events generated from all RDS sources belonging to your customer
        /// account.
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
        public virtual CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// You can specify the type of source (<c>SourceType</c>) that you want to be notified
        /// of and provide a list of RDS sources (<c>SourceIds</c>) that triggers the events.
        /// You can also provide a list of event categories (<c>EventCategories</c>) for events
        /// that you want to be notified of. For example, you can specify <c>SourceType</c> =
        /// <c>db-instance</c>, <c>SourceIds</c> = <c>mydbinstance1</c>, <c>mydbinstance2</c>
        /// and <c>EventCategories</c> = <c>Availability</c>, <c>Backup</c>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the <c>SourceType</c> and <c>SourceIds</c>, such as <c>SourceType</c>
        /// = <c>db-instance</c> and <c>SourceIds</c> = <c>myDBInstance1</c>, you are notified
        /// of all the <c>db-instance</c> events for the specified source. If you specify a <c>SourceType</c>
        /// but do not specify <c>SourceIds</c>, you receive notice of the events for that source
        /// type for all your RDS sources. If you don't specify either the SourceType or the <c>SourceIds</c>,
        /// you are notified of events generated from all RDS sources belonging to your customer
        /// account.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEventSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGlobalCluster


        /// <summary>
        /// Creates an Aurora global database spread across multiple Amazon Web Services Regions.
        /// The global database contains a single primary cluster with read-write capability,
        /// and a read-only secondary cluster that receives data from the primary cluster through
        /// high-speed replication performed by the Aurora storage subsystem.
        /// 
        ///  
        /// <para>
        /// You can create a global database that is initially empty, and then create the primary
        /// and secondary DB clusters in the global database. Or you can specify an existing Aurora
        /// cluster during the create operation, and this cluster becomes the primary cluster
        /// of the global database.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation applies only to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the CreateGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterAlreadyExistsException">
        /// The <c>GlobalClusterIdentifier</c> already exists. Specify a new global database identifier
        /// (unique name) to create a new global database cluster or to rename an existing one.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterQuotaExceededException">
        /// The number of global database clusters for this account is already at the maximum
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBShardGroupStateException">
        /// The DB shard group must be in the available state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateGlobalCluster">REST API Reference for CreateGlobalCluster Operation</seealso>
        public virtual CreateGlobalClusterResponse CreateGlobalCluster(CreateGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// You can create a global database that is initially empty, and then create the primary
        /// and secondary DB clusters in the global database. Or you can specify an existing Aurora
        /// cluster during the create operation, and this cluster becomes the primary cluster
        /// of the global database.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation applies only to Aurora DB clusters.
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterAlreadyExistsException">
        /// The <c>GlobalClusterIdentifier</c> already exists. Specify a new global database identifier
        /// (unique name) to create a new global database cluster or to rename an existing one.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterQuotaExceededException">
        /// The number of global database clusters for this account is already at the maximum
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBShardGroupStateException">
        /// The DB shard group must be in the available state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateGlobalCluster">REST API Reference for CreateGlobalCluster Operation</seealso>
        public virtual Task<CreateGlobalClusterResponse> CreateGlobalClusterAsync(CreateGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateGlobalClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIntegration


        /// <summary>
        /// Creates a zero-ETL integration with Amazon Redshift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateIntegration service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationAlreadyExistsException">
        /// The integration you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationConflictOperationException">
        /// A conflicting conditional operation is currently in progress against this resource.
        /// Typically occurs when there are multiple requests being made to the same resource
        /// at the same time, and these requests conflict with each other.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationQuotaExceededException">
        /// You can't crate any more zero-ETL integrations because the quota has been reached.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        public virtual CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Creates a zero-ETL integration with Amazon Redshift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIntegration service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationAlreadyExistsException">
        /// The integration you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationConflictOperationException">
        /// A conflicting conditional operation is currently in progress against this resource.
        /// Typically occurs when there are multiple requests being made to the same resource
        /// at the same time, and these requests conflict with each other.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationQuotaExceededException">
        /// You can't crate any more zero-ETL integrations because the quota has been reached.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        public virtual Task<CreateIntegrationResponse> CreateIntegrationAsync(CreateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOptionGroup


        /// <summary>
        /// Creates a new option group. You can create up to 20 option groups.
        /// 
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOptionGroup service method.</param>
        /// 
        /// <returns>The response from the CreateOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupAlreadyExistsException">
        /// The option group you are trying to create already exists.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupQuotaExceededException">
        /// The quota of 20 option groups was exceeded for this Amazon Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateOptionGroup">REST API Reference for CreateOptionGroup Operation</seealso>
        public virtual CreateOptionGroupResponse CreateOptionGroup(CreateOptionGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOptionGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOptionGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTenantDatabase


        /// <summary>
        /// Creates a tenant database in a DB instance that uses the multi-tenant configuration.
        /// Only RDS for Oracle container database (CDB) instances are supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTenantDatabase service method.</param>
        /// 
        /// <returns>The response from the CreateTenantDatabase service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseAlreadyExistsException">
        /// You attempted to either create a tenant database that already exists or modify a tenant
        /// database to use the name of an existing tenant database.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseQuotaExceededException">
        /// You attempted to create more tenant databases than are permitted in your Amazon Web
        /// Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateTenantDatabase">REST API Reference for CreateTenantDatabase Operation</seealso>
        public virtual CreateTenantDatabaseResponse CreateTenantDatabase(CreateTenantDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTenantDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTenantDatabaseResponseUnmarshaller.Instance;

            return Invoke<CreateTenantDatabaseResponse>(request, options);
        }


        /// <summary>
        /// Creates a tenant database in a DB instance that uses the multi-tenant configuration.
        /// Only RDS for Oracle container database (CDB) instances are supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTenantDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTenantDatabase service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseAlreadyExistsException">
        /// You attempted to either create a tenant database that already exists or modify a tenant
        /// database to use the name of an existing tenant database.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseQuotaExceededException">
        /// You attempted to create more tenant databases than are permitted in your Amazon Web
        /// Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateTenantDatabase">REST API Reference for CreateTenantDatabase Operation</seealso>
        public virtual Task<CreateTenantDatabaseResponse> CreateTenantDatabaseAsync(CreateTenantDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTenantDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTenantDatabaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTenantDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBlueGreenDeployment


        /// <summary>
        /// Deletes a blue/green deployment.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/blue-green-deployments.html">Using
        /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon RDS User
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">Using
        /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBlueGreenDeployment service method.</param>
        /// 
        /// <returns>The response from the DeleteBlueGreenDeployment service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <c>BlueGreenDeploymentIdentifier</c> doesn't refer to an existing blue/green deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidBlueGreenDeploymentStateException">
        /// The blue/green deployment can't be switched over or deleted because there is an invalid
        /// configuration in the green environment.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteBlueGreenDeployment">REST API Reference for DeleteBlueGreenDeployment Operation</seealso>
        public virtual DeleteBlueGreenDeploymentResponse DeleteBlueGreenDeployment(DeleteBlueGreenDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">Using
        /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBlueGreenDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBlueGreenDeployment service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <c>BlueGreenDeploymentIdentifier</c> doesn't refer to an existing blue/green deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidBlueGreenDeploymentStateException">
        /// The blue/green deployment can't be switched over or deleted because there is an invalid
        /// configuration in the green environment.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteBlueGreenDeployment">REST API Reference for DeleteBlueGreenDeployment Operation</seealso>
        public virtual Task<DeleteBlueGreenDeploymentResponse> DeleteBlueGreenDeploymentAsync(DeleteBlueGreenDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBlueGreenDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBlueGreenDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBlueGreenDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomDBEngineVersion


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
        /// CloudTrail, calls to the <c>DeleteCustomDbEngineVersion</c> event aren't logged. However,
        /// you might see calls from the API gateway that accesses your Amazon S3 bucket. These
        /// calls originate from the MediaImport service for the <c>DeleteCustomDbEngineVersion</c>
        /// event.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-cev.html#custom-cev.delete">Deleting
        /// a CEV</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomDBEngineVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomDBEngineVersion service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CustomDBEngineVersionNotFoundException">
        /// The specified CEV was not found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidCustomDBEngineVersionStateException">
        /// You can't delete the CEV.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteCustomDBEngineVersion">REST API Reference for DeleteCustomDBEngineVersion Operation</seealso>
        public virtual DeleteCustomDBEngineVersionResponse DeleteCustomDBEngineVersion(DeleteCustomDBEngineVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// CloudTrail, calls to the <c>DeleteCustomDbEngineVersion</c> event aren't logged. However,
        /// you might see calls from the API gateway that accesses your Amazon S3 bucket. These
        /// calls originate from the MediaImport service for the <c>DeleteCustomDbEngineVersion</c>
        /// event.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-cev.html#custom-cev.delete">Deleting
        /// a CEV</a> in the <i>Amazon RDS User Guide</i>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomDBEngineVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomDBEngineVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCustomDBEngineVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBCluster


        /// <summary>
        /// The DeleteDBCluster action deletes a previously provisioned DB cluster. When you delete
        /// a DB cluster, all automated backups for that DB cluster are deleted and can't be recovered.
        /// Manual DB cluster snapshots of the specified DB cluster are not deleted.
        /// 
        ///  
        /// <para>
        /// If you're deleting a Multi-AZ DB cluster with read replicas, all cluster members are
        /// terminated and read replicas are promoted to standalone instances.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAutomatedBackupQuotaExceededException">
        /// The quota for retained automated backups was exceeded. This prevents you from retaining
        /// any additional automated backups. The retained automated backups quota is the same
        /// as your DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
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
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual DeleteDBClusterResponse DeleteDBCluster(DeleteDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// If you're deleting a Multi-AZ DB cluster with read replicas, all cluster members are
        /// terminated and read replicas are promoted to standalone instances.
        /// </para>
        ///  
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAutomatedBackupQuotaExceededException">
        /// The quota for retained automated backups was exceeded. This prevents you from retaining
        /// any additional automated backups. The retained automated backups quota is the same
        /// as your DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
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
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual Task<DeleteDBClusterResponse> DeleteDBClusterAsync(DeleteDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBClusterAutomatedBackup


        /// <summary>
        /// Deletes automated backups using the <c>DbClusterResourceId</c> value of the source
        /// DB cluster or the Amazon Resource Name (ARN) of the automated backups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterAutomatedBackup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterAutomatedBackup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAutomatedBackupNotFoundException">
        /// No automated backup for this DB cluster was found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterAutomatedBackupStateException">
        /// The automated backup is in an invalid state. For example, this automated backup is
        /// associated with an active cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterAutomatedBackup">REST API Reference for DeleteDBClusterAutomatedBackup Operation</seealso>
        public virtual DeleteDBClusterAutomatedBackupResponse DeleteDBClusterAutomatedBackup(DeleteDBClusterAutomatedBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterAutomatedBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterAutomatedBackupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterAutomatedBackupResponse>(request, options);
        }


        /// <summary>
        /// Deletes automated backups using the <c>DbClusterResourceId</c> value of the source
        /// DB cluster or the Amazon Resource Name (ARN) of the automated backups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterAutomatedBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBClusterAutomatedBackup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAutomatedBackupNotFoundException">
        /// No automated backup for this DB cluster was found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterAutomatedBackupStateException">
        /// The automated backup is in an invalid state. For example, this automated backup is
        /// associated with an active cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterAutomatedBackup">REST API Reference for DeleteDBClusterAutomatedBackup Operation</seealso>
        public virtual Task<DeleteDBClusterAutomatedBackupResponse> DeleteDBClusterAutomatedBackupAsync(DeleteDBClusterAutomatedBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterAutomatedBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterAutomatedBackupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBClusterAutomatedBackupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBClusterEndpoint


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
        public virtual DeleteDBClusterEndpointResponse DeleteDBClusterEndpoint(DeleteDBClusterEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBClusterEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBClusterParameterGroup


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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        public virtual DeleteDBClusterParameterGroupResponse DeleteDBClusterParameterGroup(DeleteDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        public virtual Task<DeleteDBClusterParameterGroupResponse> DeleteDBClusterParameterGroupAsync(DeleteDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBClusterSnapshot


        /// <summary>
        /// Deletes a DB cluster snapshot. If the snapshot is being copied, the copy operation
        /// is terminated.
        /// 
        ///  <note> 
        /// <para>
        /// The DB cluster snapshot must be in the <c>available</c> state to be deleted.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        public virtual DeleteDBClusterSnapshotResponse DeleteDBClusterSnapshot(DeleteDBClusterSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The DB cluster snapshot must be in the <c>available</c> state to be deleted.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBClusterSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        public virtual Task<DeleteDBClusterSnapshotResponse> DeleteDBClusterSnapshotAsync(DeleteDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBClusterSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBClusterSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBClusterSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBInstance


        /// <summary>
        /// Deletes a previously provisioned DB instance. When you delete a DB instance, all automated
        /// backups for that instance are deleted and can't be recovered. However, manual DB snapshots
        /// of the DB instance aren't deleted.
        /// 
        ///  
        /// <para>
        /// If you request a final DB snapshot, the status of the Amazon RDS DB instance is <c>deleting</c>
        /// until the DB snapshot is created. This operation can't be canceled or reverted after
        /// it begins. To monitor the status of this operation, use <c>DescribeDBInstance</c>.
        /// </para>
        ///  
        /// <para>
        /// When a DB instance is in a failure state and has a status of <c>failed</c>, <c>incompatible-restore</c>,
        /// or <c>incompatible-network</c>, you can only delete it when you skip creation of the
        /// final snapshot with the <c>SkipFinalSnapshot</c> parameter.
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
        /// To delete a DB instance in this case, first use the <c>PromoteReadReplicaDBCluster</c>
        /// operation to promote the DB cluster so that it's no longer a read replica. After the
        /// promotion completes, use the <c>DeleteDBInstance</c> operation to delete the final
        /// instance in the DB cluster.
        /// </para>
        ///  <important> 
        /// <para>
        /// For RDS Custom DB instances, deleting the DB instance permanently deletes the EC2
        /// instance and the associated EBS volumes. Make sure that you don't terminate or delete
        /// these resources before you delete the DB instance. Otherwise, deleting the DB instance
        /// and creation of the final snapshot might fail.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupQuotaExceededException">
        /// The quota for retained automated backups was exceeded. This prevents you from retaining
        /// any additional automated backups. The retained automated backups quota is the same
        /// as your DB instance quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <c>DBSnapshotIdentifier</c> is already used by an existing snapshot.
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
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteDBInstanceResponse>(request, options);
        }


        /// <summary>
        /// Deletes a previously provisioned DB instance. When you delete a DB instance, all automated
        /// backups for that instance are deleted and can't be recovered. However, manual DB snapshots
        /// of the DB instance aren't deleted.
        /// 
        ///  
        /// <para>
        /// If you request a final DB snapshot, the status of the Amazon RDS DB instance is <c>deleting</c>
        /// until the DB snapshot is created. This operation can't be canceled or reverted after
        /// it begins. To monitor the status of this operation, use <c>DescribeDBInstance</c>.
        /// </para>
        ///  
        /// <para>
        /// When a DB instance is in a failure state and has a status of <c>failed</c>, <c>incompatible-restore</c>,
        /// or <c>incompatible-network</c>, you can only delete it when you skip creation of the
        /// final snapshot with the <c>SkipFinalSnapshot</c> parameter.
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
        /// To delete a DB instance in this case, first use the <c>PromoteReadReplicaDBCluster</c>
        /// operation to promote the DB cluster so that it's no longer a read replica. After the
        /// promotion completes, use the <c>DeleteDBInstance</c> operation to delete the final
        /// instance in the DB cluster.
        /// </para>
        ///  <important> 
        /// <para>
        /// For RDS Custom DB instances, deleting the DB instance permanently deletes the EC2
        /// instance and the associated EBS volumes. Make sure that you don't terminate or delete
        /// these resources before you delete the DB instance. Otherwise, deleting the DB instance
        /// and creation of the final snapshot might fail.
        /// </para>
        ///  </important>
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
        /// as your DB instance quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <c>DBSnapshotIdentifier</c> is already used by an existing snapshot.
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
        /// <exception cref="Amazon.RDS.Model.SnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of DB snapshots.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBInstanceAutomatedBackup


        /// <summary>
        /// Deletes automated backups using the <c>DbiResourceId</c> value of the source DB instance
        /// or the Amazon Resource Name (ARN) of the automated backups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstanceAutomatedBackup service method.</param>
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
        public virtual DeleteDBInstanceAutomatedBackupResponse DeleteDBInstanceAutomatedBackup(DeleteDBInstanceAutomatedBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceAutomatedBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceAutomatedBackupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBInstanceAutomatedBackupResponse>(request, options);
        }


        /// <summary>
        /// Deletes automated backups using the <c>DbiResourceId</c> value of the source DB instance
        /// or the Amazon Resource Name (ARN) of the automated backups.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBInstanceAutomatedBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBInstanceAutomatedBackupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBInstanceAutomatedBackupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBParameterGroup


        /// <summary>
        /// Deletes a specified DB parameter group. The DB parameter group to be deleted can't
        /// be associated with any DB instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBParameterGroup">REST API Reference for DeleteDBParameterGroup Operation</seealso>
        public virtual DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBParameterGroup">REST API Reference for DeleteDBParameterGroup Operation</seealso>
        public virtual Task<DeleteDBParameterGroupResponse> DeleteDBParameterGroupAsync(DeleteDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBProxy


        /// <summary>
        /// Deletes an existing DB proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBProxy service method.</param>
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
        public virtual DeleteDBProxyResponse DeleteDBProxy(DeleteDBProxyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBProxyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBProxyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBProxyEndpoint


        /// <summary>
        /// Deletes a <c>DBProxyEndpoint</c>. Doing so removes the ability to access the DB proxy
        /// using the endpoint that you defined. The endpoint that you delete might have provided
        /// capabilities such as read/write or read-only operations, or using a different VPC
        /// than the DB proxy's default VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBProxyEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteDBProxyEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyEndpointNotFoundException">
        /// The DB proxy endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBProxyEndpointStateException">
        /// You can't perform this operation while the DB proxy endpoint is in a particular state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBProxyEndpoint">REST API Reference for DeleteDBProxyEndpoint Operation</seealso>
        public virtual DeleteDBProxyEndpointResponse DeleteDBProxyEndpoint(DeleteDBProxyEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBProxyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBProxyEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteDBProxyEndpointResponse>(request, options);
        }


        /// <summary>
        /// Deletes a <c>DBProxyEndpoint</c>. Doing so removes the ability to access the DB proxy
        /// using the endpoint that you defined. The endpoint that you delete might have provided
        /// capabilities such as read/write or read-only operations, or using a different VPC
        /// than the DB proxy's default VPC.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBProxyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBProxyEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBProxyEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSecurityGroup


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
        /// 
        /// <returns>The response from the DeleteDBSecurityGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSecurityGroup">REST API Reference for DeleteDBSecurityGroup Operation</seealso>
        public virtual DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSecurityGroup">REST API Reference for DeleteDBSecurityGroup Operation</seealso>
        public virtual Task<DeleteDBSecurityGroupResponse> DeleteDBSecurityGroupAsync(DeleteDBSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBShardGroup


        /// <summary>
        /// Deletes an Aurora Limitless Database DB shard group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBShardGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDBShardGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBShardGroupStateException">
        /// The DB shard group must be in the available state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBShardGroup">REST API Reference for DeleteDBShardGroup Operation</seealso>
        public virtual DeleteDBShardGroupResponse DeleteDBShardGroup(DeleteDBShardGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBShardGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBShardGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBShardGroupResponse>(request, options);
        }


        /// <summary>
        /// Deletes an Aurora Limitless Database DB shard group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBShardGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDBShardGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBShardGroupStateException">
        /// The DB shard group must be in the available state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBShardGroup">REST API Reference for DeleteDBShardGroup Operation</seealso>
        public virtual Task<DeleteDBShardGroupResponse> DeleteDBShardGroupAsync(DeleteDBShardGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBShardGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBShardGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBShardGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSnapshot


        /// <summary>
        /// Deletes a DB snapshot. If the snapshot is being copied, the copy operation is terminated.
        /// 
        ///  <note> 
        /// <para>
        /// The DB snapshot must be in the <c>available</c> state to be deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSnapshot">REST API Reference for DeleteDBSnapshot Operation</seealso>
        public virtual DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Deletes a DB snapshot. If the snapshot is being copied, the copy operation is terminated.
        /// 
        ///  <note> 
        /// <para>
        /// The DB snapshot must be in the <c>available</c> state to be deleted.
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
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSnapshot">REST API Reference for DeleteDBSnapshot Operation</seealso>
        public virtual Task<DeleteDBSnapshotResponse> DeleteDBSnapshotAsync(DeleteDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSubnetGroup


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
        /// 
        /// <returns>The response from the DeleteDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetStateException">
        /// The DB subnet isn't in the <i>available</i> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        public virtual DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDBSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventSubscription


        /// <summary>
        /// Deletes an RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
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
        public virtual DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEventSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGlobalCluster


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
        /// 
        /// <returns>The response from the DeleteGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteGlobalCluster">REST API Reference for DeleteGlobalCluster Operation</seealso>
        public virtual DeleteGlobalClusterResponse DeleteGlobalCluster(DeleteGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteGlobalCluster">REST API Reference for DeleteGlobalCluster Operation</seealso>
        public virtual Task<DeleteGlobalClusterResponse> DeleteGlobalClusterAsync(DeleteGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteGlobalClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntegration


        /// <summary>
        /// Deletes a zero-ETL integration with Amazon Redshift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.IntegrationConflictOperationException">
        /// A conflicting conditional operation is currently in progress against this resource.
        /// Typically occurs when there are multiple requests being made to the same resource
        /// at the same time, and these requests conflict with each other.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationNotFoundException">
        /// The specified integration could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidIntegrationStateException">
        /// The integration is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a zero-ETL integration with Amazon Redshift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.IntegrationConflictOperationException">
        /// A conflicting conditional operation is currently in progress against this resource.
        /// Typically occurs when there are multiple requests being made to the same resource
        /// at the same time, and these requests conflict with each other.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationNotFoundException">
        /// The specified integration could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidIntegrationStateException">
        /// The integration is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteOptionGroup


        /// <summary>
        /// Deletes an existing option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptionGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidOptionGroupStateException">
        /// The option group isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteOptionGroup">REST API Reference for DeleteOptionGroup Operation</seealso>
        public virtual DeleteOptionGroupResponse DeleteOptionGroup(DeleteOptionGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOptionGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteOptionGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTenantDatabase


        /// <summary>
        /// Deletes a tenant database from your DB instance. This command only applies to RDS
        /// for Oracle container database (CDB) instances.
        /// 
        ///  
        /// <para>
        /// You can't delete a tenant database when it is the only tenant in the DB instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTenantDatabase service method.</param>
        /// 
        /// <returns>The response from the DeleteTenantDatabase service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <c>DBSnapshotIdentifier</c> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseNotFoundException">
        /// The specified tenant database wasn't found in the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteTenantDatabase">REST API Reference for DeleteTenantDatabase Operation</seealso>
        public virtual DeleteTenantDatabaseResponse DeleteTenantDatabase(DeleteTenantDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTenantDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTenantDatabaseResponseUnmarshaller.Instance;

            return Invoke<DeleteTenantDatabaseResponse>(request, options);
        }


        /// <summary>
        /// Deletes a tenant database from your DB instance. This command only applies to RDS
        /// for Oracle container database (CDB) instances.
        /// 
        ///  
        /// <para>
        /// You can't delete a tenant database when it is the only tenant in the DB instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTenantDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTenantDatabase service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <c>DBSnapshotIdentifier</c> is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseNotFoundException">
        /// The specified tenant database wasn't found in the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteTenantDatabase">REST API Reference for DeleteTenantDatabase Operation</seealso>
        public virtual Task<DeleteTenantDatabaseResponse> DeleteTenantDatabaseAsync(DeleteTenantDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTenantDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTenantDatabaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTenantDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterDBProxyTargets


        /// <summary>
        /// Remove the association between one or more <c>DBProxyTarget</c> data structures and
        /// a <c>DBProxyTargetGroup</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterDBProxyTargets service method.</param>
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
        public virtual DeregisterDBProxyTargetsResponse DeregisterDBProxyTargets(DeregisterDBProxyTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterDBProxyTargetsResponseUnmarshaller.Instance;

            return Invoke<DeregisterDBProxyTargetsResponse>(request, options);
        }


        /// <summary>
        /// Remove the association between one or more <c>DBProxyTarget</c> data structures and
        /// a <c>DBProxyTargetGroup</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterDBProxyTargetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeregisterDBProxyTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes


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
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse DescribeAccountAttributes()
        {
            return DescribeAccountAttributes(new DescribeAccountAttributesRequest());
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
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccountAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBlueGreenDeployments


        /// <summary>
        /// Describes one or more blue/green deployments.
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
        /// 
        /// <returns>The response from the DescribeBlueGreenDeployments service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <c>BlueGreenDeploymentIdentifier</c> doesn't refer to an existing blue/green deployment.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeBlueGreenDeployments">REST API Reference for DescribeBlueGreenDeployments Operation</seealso>
        public virtual DescribeBlueGreenDeploymentsResponse DescribeBlueGreenDeployments(DescribeBlueGreenDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBlueGreenDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBlueGreenDeploymentsResponseUnmarshaller.Instance;

            return Invoke<DescribeBlueGreenDeploymentsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more blue/green deployments.
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
        /// <c>BlueGreenDeploymentIdentifier</c> doesn't refer to an existing blue/green deployment.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeBlueGreenDeployments">REST API Reference for DescribeBlueGreenDeployments Operation</seealso>
        public virtual Task<DescribeBlueGreenDeploymentsResponse> DescribeBlueGreenDeploymentsAsync(DescribeBlueGreenDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBlueGreenDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBlueGreenDeploymentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeBlueGreenDeploymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCertificates


        /// <summary>
        /// Lists the set of certificate authority (CA) certificates provided by Amazon RDS for
        /// this Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL.html">Using
        /// SSL/TLS to encrypt a connection to a DB instance</a> in the <i>Amazon RDS User Guide</i>
        /// and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.SSL.html">
        /// Using SSL/TLS to encrypt a connection to a DB cluster</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificates service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual DescribeCertificatesResponse DescribeCertificates(DescribeCertificatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificatesResponse>(request, options);
        }


        /// <summary>
        /// Lists the set of certificate authority (CA) certificates provided by Amazon RDS for
        /// this Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/UsingWithRDS.SSL.html">Using
        /// SSL/TLS to encrypt a connection to a DB instance</a> in the <i>Amazon RDS User Guide</i>
        /// and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/UsingWithRDS.SSL.html">
        /// Using SSL/TLS to encrypt a connection to a DB cluster</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificates service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual Task<DescribeCertificatesResponse> DescribeCertificatesAsync(DescribeCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterAutomatedBackups


        /// <summary>
        /// Displays backups for both current and deleted DB clusters. For example, use this operation
        /// to find details about automated backups for previously deleted clusters. Current clusters
        /// are returned for both the <c>DescribeDBClusterAutomatedBackups</c> and <c>DescribeDBClusters</c>
        /// operations.
        /// 
        ///  
        /// <para>
        /// All parameters are optional.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterAutomatedBackups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterAutomatedBackups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAutomatedBackupNotFoundException">
        /// No automated backup for this DB cluster was found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterAutomatedBackups">REST API Reference for DescribeDBClusterAutomatedBackups Operation</seealso>
        public virtual DescribeDBClusterAutomatedBackupsResponse DescribeDBClusterAutomatedBackups(DescribeDBClusterAutomatedBackupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterAutomatedBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterAutomatedBackupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterAutomatedBackupsResponse>(request, options);
        }


        /// <summary>
        /// Displays backups for both current and deleted DB clusters. For example, use this operation
        /// to find details about automated backups for previously deleted clusters. Current clusters
        /// are returned for both the <c>DescribeDBClusterAutomatedBackups</c> and <c>DescribeDBClusters</c>
        /// operations.
        /// 
        ///  
        /// <para>
        /// All parameters are optional.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterAutomatedBackups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterAutomatedBackups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAutomatedBackupNotFoundException">
        /// No automated backup for this DB cluster was found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterAutomatedBackups">REST API Reference for DescribeDBClusterAutomatedBackups Operation</seealso>
        public virtual Task<DescribeDBClusterAutomatedBackupsResponse> DescribeDBClusterAutomatedBackupsAsync(DescribeDBClusterAutomatedBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterAutomatedBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterAutomatedBackupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBClusterAutomatedBackupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterBacktracks


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
        /// 
        /// <returns>The response from the DescribeDBClusterBacktracks service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterBacktrackNotFoundException">
        /// <c>BacktrackIdentifier</c> doesn't refer to an existing backtrack.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterBacktracks">REST API Reference for DescribeDBClusterBacktracks Operation</seealso>
        public virtual DescribeDBClusterBacktracksResponse DescribeDBClusterBacktracks(DescribeDBClusterBacktracksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>BacktrackIdentifier</c> doesn't refer to an existing backtrack.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterBacktracks">REST API Reference for DescribeDBClusterBacktracks Operation</seealso>
        public virtual Task<DescribeDBClusterBacktracksResponse> DescribeDBClusterBacktracksAsync(DescribeDBClusterBacktracksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterBacktracksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterBacktracksResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBClusterBacktracksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterEndpoints


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
        /// 
        /// <returns>The response from the DescribeDBClusterEndpoints service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterEndpoints">REST API Reference for DescribeDBClusterEndpoints Operation</seealso>
        public virtual DescribeDBClusterEndpointsResponse DescribeDBClusterEndpoints(DescribeDBClusterEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterEndpoints">REST API Reference for DescribeDBClusterEndpoints Operation</seealso>
        public virtual Task<DescribeDBClusterEndpointsResponse> DescribeDBClusterEndpointsAsync(DescribeDBClusterEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBClusterEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterParameterGroups


        /// <summary>
        /// Returns a list of <c>DBClusterParameterGroup</c> descriptions. If a <c>DBClusterParameterGroupName</c>
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual DescribeDBClusterParameterGroupsResponse DescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterParameterGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of <c>DBClusterParameterGroup</c> descriptions. If a <c>DBClusterParameterGroupName</c>
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual Task<DescribeDBClusterParameterGroupsResponse> DescribeDBClusterParameterGroupsAsync(DescribeDBClusterParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBClusterParameterGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterParameters


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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual DescribeDBClusterParametersResponse DescribeDBClusterParameters(DescribeDBClusterParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterParameters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual Task<DescribeDBClusterParametersResponse> DescribeDBClusterParametersAsync(DescribeDBClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterParametersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBClusterParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusters


        /// <summary>
        /// Describes existing Amazon Aurora DB clusters and Multi-AZ DB clusters. This API supports
        /// pagination.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation can also return information for Amazon Neptune DB instances and Amazon
        /// DocumentDB instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        public virtual DescribeDBClustersResponse DescribeDBClusters(DescribeDBClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClustersResponse>(request, options);
        }


        /// <summary>
        /// Describes existing Amazon Aurora DB clusters and Multi-AZ DB clusters. This API supports
        /// pagination.
        /// 
        ///  
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        public virtual Task<DescribeDBClustersResponse> DescribeDBClustersAsync(DescribeDBClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClustersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterSnapshotAttributes


        /// <summary>
        /// Returns a list of DB cluster snapshot attribute names and values for a manual DB cluster
        /// snapshot.
        /// 
        ///  
        /// <para>
        /// When sharing snapshots with other Amazon Web Services accounts, <c>DescribeDBClusterSnapshotAttributes</c>
        /// returns the <c>restore</c> attribute and a list of IDs for the Amazon Web Services
        /// accounts that are authorized to copy or restore the manual DB cluster snapshot. If
        /// <c>all</c> is included in the list of values for the <c>restore</c> attribute, then
        /// the manual DB cluster snapshot is public and can be copied or restored by all Amazon
        /// Web Services accounts.
        /// </para>
        ///  
        /// <para>
        /// To add or remove access for an Amazon Web Services account to copy or restore a manual
        /// DB cluster snapshot, or to make the manual DB cluster snapshot public or private,
        /// use the <c>ModifyDBClusterSnapshotAttribute</c> API action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshotAttributes service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual DescribeDBClusterSnapshotAttributesResponse DescribeDBClusterSnapshotAttributes(DescribeDBClusterSnapshotAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// When sharing snapshots with other Amazon Web Services accounts, <c>DescribeDBClusterSnapshotAttributes</c>
        /// returns the <c>restore</c> attribute and a list of IDs for the Amazon Web Services
        /// accounts that are authorized to copy or restore the manual DB cluster snapshot. If
        /// <c>all</c> is included in the list of values for the <c>restore</c> attribute, then
        /// the manual DB cluster snapshot is public and can be copied or restored by all Amazon
        /// Web Services accounts.
        /// </para>
        ///  
        /// <para>
        /// To add or remove access for an Amazon Web Services account to copy or restore a manual
        /// DB cluster snapshot, or to make the manual DB cluster snapshot public or private,
        /// use the <c>ModifyDBClusterSnapshotAttribute</c> API action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshotAttributes service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual Task<DescribeDBClusterSnapshotAttributesResponse> DescribeDBClusterSnapshotAttributesAsync(DescribeDBClusterSnapshotAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBClusterSnapshotAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterSnapshots


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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual DescribeDBClusterSnapshotsResponse DescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBClusterSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual Task<DescribeDBClusterSnapshotsResponse> DescribeDBClusterSnapshotsAsync(DescribeDBClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBClusterSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBClusterSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBEngineVersions


        /// <summary>
        /// Describes the properties of specific versions of DB engines.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual DescribeDBEngineVersionsResponse DescribeDBEngineVersions()
        {
            return DescribeDBEngineVersions(new DescribeDBEngineVersionsRequest());
        }


        /// <summary>
        /// Describes the properties of specific versions of DB engines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeDBEngineVersions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBEngineVersionsResponse>(request, options);
        }


        /// <summary>
        /// Describes the properties of specific versions of DB engines.
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
        /// Describes the properties of specific versions of DB engines.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBEngineVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBInstanceAutomatedBackups


        /// <summary>
        /// Displays backups for both current and deleted instances. For example, use this operation
        /// to find details about automated backups for previously deleted instances. Current
        /// instances with retention periods greater than zero (0) are returned for both the <c>DescribeDBInstanceAutomatedBackups</c>
        /// and <c>DescribeDBInstances</c> operations.
        /// 
        ///  
        /// <para>
        /// All parameters are optional.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstanceAutomatedBackups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBInstanceAutomatedBackups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupNotFoundException">
        /// No automated backup for this DB instance was found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstanceAutomatedBackups">REST API Reference for DescribeDBInstanceAutomatedBackups Operation</seealso>
        public virtual DescribeDBInstanceAutomatedBackupsResponse DescribeDBInstanceAutomatedBackups(DescribeDBInstanceAutomatedBackupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBInstanceAutomatedBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstanceAutomatedBackupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBInstanceAutomatedBackupsResponse>(request, options);
        }


        /// <summary>
        /// Displays backups for both current and deleted instances. For example, use this operation
        /// to find details about automated backups for previously deleted instances. Current
        /// instances with retention periods greater than zero (0) are returned for both the <c>DescribeDBInstanceAutomatedBackups</c>
        /// and <c>DescribeDBInstances</c> operations.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBInstanceAutomatedBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstanceAutomatedBackupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBInstanceAutomatedBackupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBInstances


        /// <summary>
        /// Describes provisioned RDS instances. This API supports pagination.
        /// 
        ///  <note> 
        /// <para>
        /// This operation can also return information for Amazon Neptune DB instances and Amazon
        /// DocumentDB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual DescribeDBInstancesResponse DescribeDBInstances()
        {
            return DescribeDBInstances(new DescribeDBInstancesRequest());
        }


        /// <summary>
        /// Describes provisioned RDS instances. This API supports pagination.
        /// 
        ///  <note> 
        /// <para>
        /// This operation can also return information for Amazon Neptune DB instances and Amazon
        /// DocumentDB instances.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBInstancesResponse>(request, options);
        }


        /// <summary>
        /// Describes provisioned RDS instances. This API supports pagination.
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
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBInstancesAsync(new DescribeDBInstancesRequest(), cancellationToken);
        }

        /// <summary>
        /// Describes provisioned RDS instances. This API supports pagination.
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
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBLogFiles


        /// <summary>
        /// Returns a list of DB log files for the DB instance.
        /// 
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBLogFiles service method.</param>
        /// 
        /// <returns>The response from the DescribeDBLogFiles service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotReadyException">
        /// An attempt to download or examine log files didn't succeed because an Aurora Serverless
        /// v2 instance was paused.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBLogFiles">REST API Reference for DescribeDBLogFiles Operation</seealso>
        public virtual DescribeDBLogFilesResponse DescribeDBLogFiles(DescribeDBLogFilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotReadyException">
        /// An attempt to download or examine log files didn't succeed because an Aurora Serverless
        /// v2 instance was paused.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBLogFiles">REST API Reference for DescribeDBLogFiles Operation</seealso>
        public virtual Task<DescribeDBLogFilesResponse> DescribeDBLogFilesAsync(DescribeDBLogFilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBLogFilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBLogFilesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBLogFilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBMajorEngineVersions


        /// <summary>
        /// Describes the properties of specific major versions of DB engines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBMajorEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeDBMajorEngineVersions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBMajorEngineVersions">REST API Reference for DescribeDBMajorEngineVersions Operation</seealso>
        public virtual DescribeDBMajorEngineVersionsResponse DescribeDBMajorEngineVersions(DescribeDBMajorEngineVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBMajorEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBMajorEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBMajorEngineVersionsResponse>(request, options);
        }


        /// <summary>
        /// Describes the properties of specific major versions of DB engines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBMajorEngineVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBMajorEngineVersions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBMajorEngineVersions">REST API Reference for DescribeDBMajorEngineVersions Operation</seealso>
        public virtual Task<DescribeDBMajorEngineVersionsResponse> DescribeDBMajorEngineVersionsAsync(DescribeDBMajorEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBMajorEngineVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBMajorEngineVersionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBMajorEngineVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBParameterGroups


        /// <summary>
        /// Returns a list of <c>DBParameterGroup</c> descriptions. If a <c>DBParameterGroupName</c>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual DescribeDBParameterGroupsResponse DescribeDBParameterGroups()
        {
            return DescribeDBParameterGroups(new DescribeDBParameterGroupsRequest());
        }


        /// <summary>
        /// Returns a list of <c>DBParameterGroup</c> descriptions. If a <c>DBParameterGroupName</c>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParameterGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of <c>DBParameterGroup</c> descriptions. If a <c>DBParameterGroupName</c>
        /// is specified, the list will contain only the description of the specified DB parameter
        /// group.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBParameterGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBParameterGroupsAsync(new DescribeDBParameterGroupsRequest(), cancellationToken);
        }

        /// <summary>
        /// Returns a list of <c>DBParameterGroup</c> descriptions. If a <c>DBParameterGroupName</c>
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
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(DescribeDBParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBParameterGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBParameters


        /// <summary>
        /// Returns the detailed parameter list for a particular DB parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDBParameters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameters">REST API Reference for DescribeDBParameters Operation</seealso>
        public virtual DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameters">REST API Reference for DescribeDBParameters Operation</seealso>
        public virtual Task<DescribeDBParametersResponse> DescribeDBParametersAsync(DescribeDBParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBProxies


        /// <summary>
        /// Returns information about DB proxies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxies service method.</param>
        /// 
        /// <returns>The response from the DescribeDBProxies service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBProxies">REST API Reference for DescribeDBProxies Operation</seealso>
        public virtual DescribeDBProxiesResponse DescribeDBProxies(DescribeDBProxiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBProxiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBProxiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBProxyEndpoints


        /// <summary>
        /// Returns information about DB proxy endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxyEndpoints service method.</param>
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
        public virtual DescribeDBProxyEndpointsResponse DescribeDBProxyEndpoints(DescribeDBProxyEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBProxyEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBProxyTargetGroups


        /// <summary>
        /// Returns information about DB proxy target groups, represented by <c>DBProxyTargetGroup</c>
        /// data structures.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxyTargetGroups service method.</param>
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
        public virtual DescribeDBProxyTargetGroupsResponse DescribeDBProxyTargetGroups(DescribeDBProxyTargetGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBProxyTargetGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about DB proxy target groups, represented by <c>DBProxyTargetGroup</c>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyTargetGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBProxyTargetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBProxyTargets


        /// <summary>
        /// Returns information about <c>DBProxyTarget</c> objects. This API supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBProxyTargets service method.</param>
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
        public virtual DescribeDBProxyTargetsResponse DescribeDBProxyTargets(DescribeDBProxyTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBProxyTargetsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about <c>DBProxyTarget</c> objects. This API supports pagination.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBProxyTargetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBProxyTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBRecommendations


        /// <summary>
        /// Describes the recommendations to resolve the issues for your DB instances, DB clusters,
        /// and DB parameter groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBRecommendations service method.</param>
        /// 
        /// <returns>The response from the DescribeDBRecommendations service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBRecommendations">REST API Reference for DescribeDBRecommendations Operation</seealso>
        public virtual DescribeDBRecommendationsResponse DescribeDBRecommendations(DescribeDBRecommendationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBRecommendationsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBRecommendationsResponse>(request, options);
        }


        /// <summary>
        /// Describes the recommendations to resolve the issues for your DB instances, DB clusters,
        /// and DB parameter groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBRecommendations service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBRecommendations">REST API Reference for DescribeDBRecommendations Operation</seealso>
        public virtual Task<DescribeDBRecommendationsResponse> DescribeDBRecommendationsAsync(DescribeDBRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBRecommendationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSecurityGroups


        /// <summary>
        /// Returns a list of <c>DBSecurityGroup</c> descriptions. If a <c>DBSecurityGroupName</c>
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
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSecurityGroups">REST API Reference for DescribeDBSecurityGroups Operation</seealso>
        public virtual DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups()
        {
            return DescribeDBSecurityGroups(new DescribeDBSecurityGroupsRequest());
        }


        /// <summary>
        /// Returns a list of <c>DBSecurityGroup</c> descriptions. If a <c>DBSecurityGroupName</c>
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
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSecurityGroups">REST API Reference for DescribeDBSecurityGroups Operation</seealso>
        public virtual DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSecurityGroupsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of <c>DBSecurityGroup</c> descriptions. If a <c>DBSecurityGroupName</c>
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
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSecurityGroups">REST API Reference for DescribeDBSecurityGroups Operation</seealso>
        public virtual Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBSecurityGroupsAsync(new DescribeDBSecurityGroupsRequest(), cancellationToken);
        }

        /// <summary>
        /// Returns a list of <c>DBSecurityGroup</c> descriptions. If a <c>DBSecurityGroupName</c>
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
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSecurityGroups">REST API Reference for DescribeDBSecurityGroups Operation</seealso>
        public virtual Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(DescribeDBSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBSecurityGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBShardGroups


        /// <summary>
        /// Describes existing Aurora Limitless Database DB shard groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBShardGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeDBShardGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBShardGroups">REST API Reference for DescribeDBShardGroups Operation</seealso>
        public virtual DescribeDBShardGroupsResponse DescribeDBShardGroups(DescribeDBShardGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBShardGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBShardGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBShardGroupsResponse>(request, options);
        }


        /// <summary>
        /// Describes existing Aurora Limitless Database DB shard groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBShardGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBShardGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBShardGroups">REST API Reference for DescribeDBShardGroups Operation</seealso>
        public virtual Task<DescribeDBShardGroupsResponse> DescribeDBShardGroupsAsync(DescribeDBShardGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBShardGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBShardGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBShardGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSnapshotAttributes


        /// <summary>
        /// Returns a list of DB snapshot attribute names and values for a manual DB snapshot.
        /// 
        ///  
        /// <para>
        /// When sharing snapshots with other Amazon Web Services accounts, <c>DescribeDBSnapshotAttributes</c>
        /// returns the <c>restore</c> attribute and a list of IDs for the Amazon Web Services
        /// accounts that are authorized to copy or restore the manual DB snapshot. If <c>all</c>
        /// is included in the list of values for the <c>restore</c> attribute, then the manual
        /// DB snapshot is public and can be copied or restored by all Amazon Web Services accounts.
        /// </para>
        ///  
        /// <para>
        /// To add or remove access for an Amazon Web Services account to copy or restore a manual
        /// DB snapshot, or to make the manual DB snapshot public or private, use the <c>ModifyDBSnapshotAttribute</c>
        /// API action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshotAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshotAttributes service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshotAttributes">REST API Reference for DescribeDBSnapshotAttributes Operation</seealso>
        public virtual DescribeDBSnapshotAttributesResponse DescribeDBSnapshotAttributes(DescribeDBSnapshotAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSnapshotAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSnapshotAttributesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of DB snapshot attribute names and values for a manual DB snapshot.
        /// 
        ///  
        /// <para>
        /// When sharing snapshots with other Amazon Web Services accounts, <c>DescribeDBSnapshotAttributes</c>
        /// returns the <c>restore</c> attribute and a list of IDs for the Amazon Web Services
        /// accounts that are authorized to copy or restore the manual DB snapshot. If <c>all</c>
        /// is included in the list of values for the <c>restore</c> attribute, then the manual
        /// DB snapshot is public and can be copied or restored by all Amazon Web Services accounts.
        /// </para>
        ///  
        /// <para>
        /// To add or remove access for an Amazon Web Services account to copy or restore a manual
        /// DB snapshot, or to make the manual DB snapshot public or private, use the <c>ModifyDBSnapshotAttribute</c>
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
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshotAttributes">REST API Reference for DescribeDBSnapshotAttributes Operation</seealso>
        public virtual Task<DescribeDBSnapshotAttributesResponse> DescribeDBSnapshotAttributesAsync(DescribeDBSnapshotAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBSnapshotAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSnapshotAttributesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBSnapshotAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSnapshots


        /// <summary>
        /// Returns information about DB snapshots. This API action supports pagination.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshots">REST API Reference for DescribeDBSnapshots Operation</seealso>
        public virtual DescribeDBSnapshotsResponse DescribeDBSnapshots()
        {
            return DescribeDBSnapshots(new DescribeDBSnapshotsRequest());
        }


        /// <summary>
        /// Returns information about DB snapshots. This API action supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshots service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshots">REST API Reference for DescribeDBSnapshots Operation</seealso>
        public virtual DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
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
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshots">REST API Reference for DescribeDBSnapshots Operation</seealso>
        public virtual Task<DescribeDBSnapshotsResponse> DescribeDBSnapshotsAsync(DescribeDBSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSnapshotsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSnapshotTenantDatabases


        /// <summary>
        /// Describes the tenant databases that exist in a DB snapshot. This command only applies
        /// to RDS for Oracle DB instances in the multi-tenant configuration.
        /// 
        ///  
        /// <para>
        /// You can use this command to inspect the tenant databases within a snapshot before
        /// restoring it. You can't directly interact with the tenant databases in a DB snapshot.
        /// If you restore a snapshot that was taken from DB instance using the multi-tenant configuration,
        /// you restore all its tenant databases.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshotTenantDatabases service method.</param>
        /// 
        /// <returns>The response from the DescribeDBSnapshotTenantDatabases service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshotTenantDatabases">REST API Reference for DescribeDBSnapshotTenantDatabases Operation</seealso>
        public virtual DescribeDBSnapshotTenantDatabasesResponse DescribeDBSnapshotTenantDatabases(DescribeDBSnapshotTenantDatabasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBSnapshotTenantDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSnapshotTenantDatabasesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSnapshotTenantDatabasesResponse>(request, options);
        }


        /// <summary>
        /// Describes the tenant databases that exist in a DB snapshot. This command only applies
        /// to RDS for Oracle DB instances in the multi-tenant configuration.
        /// 
        ///  
        /// <para>
        /// You can use this command to inspect the tenant databases within a snapshot before
        /// restoring it. You can't directly interact with the tenant databases in a DB snapshot.
        /// If you restore a snapshot that was taken from DB instance using the multi-tenant configuration,
        /// you restore all its tenant databases.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshotTenantDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSnapshotTenantDatabases service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshotTenantDatabases">REST API Reference for DescribeDBSnapshotTenantDatabases Operation</seealso>
        public virtual Task<DescribeDBSnapshotTenantDatabasesResponse> DescribeDBSnapshotTenantDatabasesAsync(DescribeDBSnapshotTenantDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBSnapshotTenantDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSnapshotTenantDatabasesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBSnapshotTenantDatabasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSubnetGroups


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
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups()
        {
            return DescribeDBSubnetGroups(new DescribeDBSubnetGroupsRequest());
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
        /// 
        /// <returns>The response from the DescribeDBSubnetGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
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
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(DescribeDBSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDBSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDBSubnetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEngineDefaultClusterParameters


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
        /// 
        /// <returns>The response from the DescribeEngineDefaultClusterParameters service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        public virtual DescribeEngineDefaultClusterParametersResponse DescribeEngineDefaultClusterParameters(DescribeEngineDefaultClusterParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultClusterParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEngineDefaultClusterParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEngineDefaultParameters


        /// <summary>
        /// Returns the default engine and system parameter information for the specified database
        /// engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        public virtual DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEngineDefaultParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEngineDefaultParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventCategories


        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type. You can also see this list in the "Amazon RDS event categories
        /// and event messages" section of the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.Messages.html">
        /// <i>Amazon RDS User Guide</i> </a> or the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Events.Messages.html">
        /// <i>Amazon Aurora User Guide</i> </a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }


        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type. You can also see this list in the "Amazon RDS event categories
        /// and event messages" section of the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.Messages.html">
        /// <i>Amazon RDS User Guide</i> </a> or the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Events.Messages.html">
        /// <i>Amazon Aurora User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventCategoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents


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
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
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
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventSubscriptions


        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes <c>SubscriptionName</c>, <c>SNSTopicARN</c>, <c>CustomerID</c>,
        /// <c>SourceType</c>, <c>SourceID</c>, <c>CreationTime</c>, and <c>Status</c>.
        /// 
        ///  
        /// <para>
        /// If you specify a <c>SubscriptionName</c>, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }


        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes <c>SubscriptionName</c>, <c>SNSTopicARN</c>, <c>CustomerID</c>,
        /// <c>SourceType</c>, <c>SourceID</c>, <c>CreationTime</c>, and <c>Status</c>.
        /// 
        ///  
        /// <para>
        /// If you specify a <c>SubscriptionName</c>, lists the description for that subscription.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsResponse>(request, options);
        }


        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes <c>SubscriptionName</c>, <c>SNSTopicARN</c>, <c>CustomerID</c>,
        /// <c>SourceType</c>, <c>SourceID</c>, <c>CreationTime</c>, and <c>Status</c>.
        /// 
        ///  
        /// <para>
        /// If you specify a <c>SubscriptionName</c>, lists the description for that subscription.
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
        /// a subscription includes <c>SubscriptionName</c>, <c>SNSTopicARN</c>, <c>CustomerID</c>,
        /// <c>SourceType</c>, <c>SourceID</c>, <c>CreationTime</c>, and <c>Status</c>.
        /// 
        ///  
        /// <para>
        /// If you specify a <c>SubscriptionName</c>, lists the description for that subscription.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventSubscriptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeExportTasks


        /// <summary>
        /// Returns information about a snapshot or cluster export to Amazon S3. This API operation
        /// supports pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ExportTaskNotFoundException">
        /// The export task doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeExportTasksResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a snapshot or cluster export to Amazon S3. This API operation
        /// supports pagination.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeExportTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGlobalClusters


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
        /// 
        /// <returns>The response from the DescribeGlobalClusters service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeGlobalClusters">REST API Reference for DescribeGlobalClusters Operation</seealso>
        public virtual DescribeGlobalClustersResponse DescribeGlobalClusters(DescribeGlobalClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeGlobalClusters">REST API Reference for DescribeGlobalClusters Operation</seealso>
        public virtual Task<DescribeGlobalClustersResponse> DescribeGlobalClustersAsync(DescribeGlobalClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGlobalClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalClustersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeGlobalClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIntegrations


        /// <summary>
        /// Describe one or more zero-ETL integrations with Amazon Redshift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIntegrations service method.</param>
        /// 
        /// <returns>The response from the DescribeIntegrations service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.IntegrationNotFoundException">
        /// The specified integration could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeIntegrations">REST API Reference for DescribeIntegrations Operation</seealso>
        public virtual DescribeIntegrationsResponse DescribeIntegrations(DescribeIntegrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIntegrationsResponseUnmarshaller.Instance;

            return Invoke<DescribeIntegrationsResponse>(request, options);
        }


        /// <summary>
        /// Describe one or more zero-ETL integrations with Amazon Redshift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIntegrations service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.IntegrationNotFoundException">
        /// The specified integration could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeIntegrations">REST API Reference for DescribeIntegrations Operation</seealso>
        public virtual Task<DescribeIntegrationsResponse> DescribeIntegrationsAsync(DescribeIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIntegrationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeIntegrationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOptionGroupOptions


        /// <summary>
        /// Describes all available options for the specified engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroupOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroupOptions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroupOptions">REST API Reference for DescribeOptionGroupOptions Operation</seealso>
        public virtual DescribeOptionGroupOptionsResponse DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOptionGroupOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOptionGroupOptionsResponse>(request, options);
        }


        /// <summary>
        /// Describes all available options for the specified engine.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOptionGroupOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOptionGroupOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOptionGroups


        /// <summary>
        /// Describes the available option groups.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroups">REST API Reference for DescribeOptionGroups Operation</seealso>
        public virtual DescribeOptionGroupsResponse DescribeOptionGroups()
        {
            return DescribeOptionGroups(new DescribeOptionGroupsRequest());
        }


        /// <summary>
        /// Describes the available option groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeOptionGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroups">REST API Reference for DescribeOptionGroups Operation</seealso>
        public virtual DescribeOptionGroupsResponse DescribeOptionGroups(DescribeOptionGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOptionGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptionGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOptionGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrderableDBInstanceOptions


        /// <summary>
        /// Describes the orderable DB instance options for a specified DB engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableDBInstanceOptions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        public virtual DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrderableDBInstanceOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableDBInstanceOptionsResponse>(request, options);
        }


        /// <summary>
        /// Describes the orderable DB instance options for a specified DB engine.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOrderableDBInstanceOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeOrderableDBInstanceOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePendingMaintenanceActions


        /// <summary>
        /// Returns a list of resources (for example, DB instances) that have at least one pending
        /// maintenance action.
        /// 
        ///  
        /// <para>
        /// This API follows an eventual consistency model. This means that the result of the
        /// <c>DescribePendingMaintenanceActions</c> command might not be immediately visible
        /// to all subsequent RDS commands. Keep this in mind when you use <c>DescribePendingMaintenanceActions</c>
        /// immediately after using a previous API command such as <c>ApplyPendingMaintenanceActions</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions service method.</param>
        /// 
        /// <returns>The response from the DescribePendingMaintenanceActions service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual DescribePendingMaintenanceActionsResponse DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return Invoke<DescribePendingMaintenanceActionsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of resources (for example, DB instances) that have at least one pending
        /// maintenance action.
        /// 
        ///  
        /// <para>
        /// This API follows an eventual consistency model. This means that the result of the
        /// <c>DescribePendingMaintenanceActions</c> command might not be immediately visible
        /// to all subsequent RDS commands. Keep this in mind when you use <c>DescribePendingMaintenanceActions</c>
        /// immediately after using a previous API command such as <c>ApplyPendingMaintenanceActions</c>.
        /// </para>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePendingMaintenanceActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedDBInstances


        /// <summary>
        /// Returns information about reserved DB instances for this account, or about a specified
        /// reserved DB instance.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceNotFoundException">
        /// The specified reserved DB Instance not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstances">REST API Reference for DescribeReservedDBInstances Operation</seealso>
        public virtual DescribeReservedDBInstancesResponse DescribeReservedDBInstances()
        {
            return DescribeReservedDBInstances(new DescribeReservedDBInstancesRequest());
        }


        /// <summary>
        /// Returns information about reserved DB instances for this account, or about a specified
        /// reserved DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstanceNotFoundException">
        /// The specified reserved DB Instance not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstances">REST API Reference for DescribeReservedDBInstances Operation</seealso>
        public virtual DescribeReservedDBInstancesResponse DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReservedDBInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReservedDBInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedDBInstancesOfferings


        /// <summary>
        /// Lists available reserved DB instance offerings.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstancesOfferings">REST API Reference for DescribeReservedDBInstancesOfferings Operation</seealso>
        public virtual DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings()
        {
            return DescribeReservedDBInstancesOfferings(new DescribeReservedDBInstancesOfferingsRequest());
        }


        /// <summary>
        /// Lists available reserved DB instance offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstancesOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedDBInstancesOfferings service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.ReservedDBInstancesOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstancesOfferings">REST API Reference for DescribeReservedDBInstancesOfferings Operation</seealso>
        public virtual DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeReservedDBInstancesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeReservedDBInstancesOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSourceRegions


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
        /// Regions, use the EC2 operation <c>DescribeRegions</c>. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeRegions.html">
        /// DescribeRegions</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceRegions service method.</param>
        /// 
        /// <returns>The response from the DescribeSourceRegions service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeSourceRegions">REST API Reference for DescribeSourceRegions Operation</seealso>
        public virtual DescribeSourceRegionsResponse DescribeSourceRegions(DescribeSourceRegionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Regions, use the EC2 operation <c>DescribeRegions</c>. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeRegions.html">
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSourceRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSourceRegionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSourceRegionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTenantDatabases


        /// <summary>
        /// Describes the tenant databases in a DB instance that uses the multi-tenant configuration.
        /// Only RDS for Oracle CDB instances are supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTenantDatabases service method.</param>
        /// 
        /// <returns>The response from the DescribeTenantDatabases service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeTenantDatabases">REST API Reference for DescribeTenantDatabases Operation</seealso>
        public virtual DescribeTenantDatabasesResponse DescribeTenantDatabases(DescribeTenantDatabasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTenantDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTenantDatabasesResponseUnmarshaller.Instance;

            return Invoke<DescribeTenantDatabasesResponse>(request, options);
        }


        /// <summary>
        /// Describes the tenant databases in a DB instance that uses the multi-tenant configuration.
        /// Only RDS for Oracle CDB instances are supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTenantDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTenantDatabases service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeTenantDatabases">REST API Reference for DescribeTenantDatabases Operation</seealso>
        public virtual Task<DescribeTenantDatabasesResponse> DescribeTenantDatabasesAsync(DescribeTenantDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTenantDatabasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTenantDatabasesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTenantDatabasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeValidDBInstanceModifications


        /// <summary>
        /// You can call <c>DescribeValidDBInstanceModifications</c> to learn what modifications
        /// you can make to your DB instance. You can use this information when you call <c>ModifyDBInstance</c>.
        /// 
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeValidDBInstanceModifications service method.</param>
        /// 
        /// <returns>The response from the DescribeValidDBInstanceModifications service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeValidDBInstanceModifications">REST API Reference for DescribeValidDBInstanceModifications Operation</seealso>
        public virtual DescribeValidDBInstanceModificationsResponse DescribeValidDBInstanceModifications(DescribeValidDBInstanceModificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeValidDBInstanceModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeValidDBInstanceModificationsResponse>(request, options);
        }


        /// <summary>
        /// You can call <c>DescribeValidDBInstanceModifications</c> to learn what modifications
        /// you can make to your DB instance. You can use this information when you call <c>ModifyDBInstance</c>.
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
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeValidDBInstanceModifications">REST API Reference for DescribeValidDBInstanceModifications Operation</seealso>
        public virtual Task<DescribeValidDBInstanceModificationsResponse> DescribeValidDBInstanceModificationsAsync(DescribeValidDBInstanceModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeValidDBInstanceModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeValidDBInstanceModificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableHttpEndpoint


        /// <summary>
        /// Disables the HTTP endpoint for the specified DB cluster. Disabling this endpoint disables
        /// RDS Data API.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
        /// RDS Data API</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation applies only to Aurora Serverless v2 and provisioned DB clusters. To
        /// disable the HTTP endpoint for Aurora Serverless v1 DB clusters, use the <c>EnableHttpEndpoint</c>
        /// parameter of the <c>ModifyDBCluster</c> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableHttpEndpoint service method.</param>
        /// 
        /// <returns>The response from the DisableHttpEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidResourceStateException">
        /// The operation can't be performed because another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DisableHttpEndpoint">REST API Reference for DisableHttpEndpoint Operation</seealso>
        public virtual DisableHttpEndpointResponse DisableHttpEndpoint(DisableHttpEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableHttpEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableHttpEndpointResponseUnmarshaller.Instance;

            return Invoke<DisableHttpEndpointResponse>(request, options);
        }


        /// <summary>
        /// Disables the HTTP endpoint for the specified DB cluster. Disabling this endpoint disables
        /// RDS Data API.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
        /// RDS Data API</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation applies only to Aurora Serverless v2 and provisioned DB clusters. To
        /// disable the HTTP endpoint for Aurora Serverless v1 DB clusters, use the <c>EnableHttpEndpoint</c>
        /// parameter of the <c>ModifyDBCluster</c> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableHttpEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableHttpEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidResourceStateException">
        /// The operation can't be performed because another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DisableHttpEndpoint">REST API Reference for DisableHttpEndpoint Operation</seealso>
        public virtual Task<DisableHttpEndpointResponse> DisableHttpEndpointAsync(DisableHttpEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableHttpEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableHttpEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableHttpEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DownloadDBLogFilePortion


        /// <summary>
        /// Downloads all or a portion of the specified log file, up to 1 MB in size.
        /// 
        ///  
        /// <para>
        /// This command doesn't apply to RDS Custom.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation uses resources on database instances. Because of this, we recommend
        /// publishing database logs to CloudWatch and then using the GetLogEvents operation.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogEvents.html">GetLogEvents</a>
        /// in the <i>Amazon CloudWatch Logs API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion service method.</param>
        /// 
        /// <returns>The response from the DownloadDBLogFilePortion service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotReadyException">
        /// An attempt to download or examine log files didn't succeed because an Aurora Serverless
        /// v2 instance was paused.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBLogFileNotFoundException">
        /// <c>LogFileName</c> doesn't refer to an existing DB log file.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DownloadDBLogFilePortion">REST API Reference for DownloadDBLogFilePortion Operation</seealso>
        public virtual DownloadDBLogFilePortionResponse DownloadDBLogFilePortion(DownloadDBLogFilePortionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        ///  <note> 
        /// <para>
        /// This operation uses resources on database instances. Because of this, we recommend
        /// publishing database logs to CloudWatch and then using the GetLogEvents operation.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogEvents.html">GetLogEvents</a>
        /// in the <i>Amazon CloudWatch Logs API Reference</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DownloadDBLogFilePortion service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotReadyException">
        /// An attempt to download or examine log files didn't succeed because an Aurora Serverless
        /// v2 instance was paused.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBLogFileNotFoundException">
        /// <c>LogFileName</c> doesn't refer to an existing DB log file.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DownloadDBLogFilePortion">REST API Reference for DownloadDBLogFilePortion Operation</seealso>
        public virtual Task<DownloadDBLogFilePortionResponse> DownloadDBLogFilePortionAsync(DownloadDBLogFilePortionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DownloadDBLogFilePortionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DownloadDBLogFilePortionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableHttpEndpoint


        /// <summary>
        /// Enables the HTTP endpoint for the DB cluster. By default, the HTTP endpoint isn't
        /// enabled.
        /// 
        ///  
        /// <para>
        /// When enabled, this endpoint provides a connectionless web service API (RDS Data API)
        /// for running SQL queries on the Aurora DB cluster. You can also query your database
        /// from inside the RDS console with the RDS query editor.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
        /// RDS Data API</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation applies only to Aurora Serverless v2 and provisioned DB clusters. To
        /// enable the HTTP endpoint for Aurora Serverless v1 DB clusters, use the <c>EnableHttpEndpoint</c>
        /// parameter of the <c>ModifyDBCluster</c> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableHttpEndpoint service method.</param>
        /// 
        /// <returns>The response from the EnableHttpEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidResourceStateException">
        /// The operation can't be performed because another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/EnableHttpEndpoint">REST API Reference for EnableHttpEndpoint Operation</seealso>
        public virtual EnableHttpEndpointResponse EnableHttpEndpoint(EnableHttpEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableHttpEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableHttpEndpointResponseUnmarshaller.Instance;

            return Invoke<EnableHttpEndpointResponse>(request, options);
        }


        /// <summary>
        /// Enables the HTTP endpoint for the DB cluster. By default, the HTTP endpoint isn't
        /// enabled.
        /// 
        ///  
        /// <para>
        /// When enabled, this endpoint provides a connectionless web service API (RDS Data API)
        /// for running SQL queries on the Aurora DB cluster. You can also query your database
        /// from inside the RDS console with the RDS query editor.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
        /// RDS Data API</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation applies only to Aurora Serverless v2 and provisioned DB clusters. To
        /// enable the HTTP endpoint for Aurora Serverless v1 DB clusters, use the <c>EnableHttpEndpoint</c>
        /// parameter of the <c>ModifyDBCluster</c> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableHttpEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableHttpEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidResourceStateException">
        /// The operation can't be performed because another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/EnableHttpEndpoint">REST API Reference for EnableHttpEndpoint Operation</seealso>
        public virtual Task<EnableHttpEndpointResponse> EnableHttpEndpointAsync(EnableHttpEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableHttpEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableHttpEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableHttpEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  FailoverDBCluster


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
        /// For a Multi-AZ DB cluster, after RDS terminates the primary DB instance, the internal
        /// monitoring system detects that the primary DB instance is unhealthy and promotes a
        /// readable standby (read-only instances) in the DB cluster to be the primary DB instance
        /// (the cluster writer). Failover times are typically less than 35 seconds.
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster service method.</param>
        /// 
        /// <returns>The response from the FailoverDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        public virtual FailoverDBClusterResponse FailoverDBCluster(FailoverDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// For a Multi-AZ DB cluster, after RDS terminates the primary DB instance, the internal
        /// monitoring system detects that the primary DB instance is unhealthy and promotes a
        /// readable standby (read-only instances) in the DB cluster to be the primary DB instance
        /// (the cluster writer). Failover times are typically less than 35 seconds.
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FailoverDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverDBClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<FailoverDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  FailoverGlobalCluster


        /// <summary>
        /// Promotes the specified secondary DB cluster to be the primary DB cluster in the global
        /// database cluster to fail over or switch over a global database. Switchover operations
        /// were previously called "managed planned failovers."
        /// 
        ///  <note> 
        /// <para>
        /// Although this operation can be used either to fail over or to switch over a global
        /// database cluster, its intended use is for global database failover. To switch over
        /// a global database cluster, we recommend that you use the <a>SwitchoverGlobalCluster</a>
        /// operation instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// How you use this operation depends on whether you are failing over or switching over
        /// your global database cluster:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Failing over - Specify the <c>AllowDataLoss</c> parameter and don't specify the <c>Switchover</c>
        /// parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Switching over - Specify the <c>Switchover</c> parameter or omit it, but don't specify
        /// the <c>AllowDataLoss</c> parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>About failing over and switching over</b> 
        /// </para>
        ///  
        /// <para>
        /// While failing over and switching over a global database cluster both change the primary
        /// DB cluster, you use these operations for different reasons:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Failing over</i> - Use this operation to respond to an unplanned event, such as
        /// a Regional disaster in the primary Region. Failing over can result in a loss of write
        /// transaction data that wasn't replicated to the chosen secondary before the failover
        /// event occurred. However, the recovery process that promotes a DB instance on the chosen
        /// seconday DB cluster to be the primary writer DB instance guarantees that the data
        /// is in a transactionally consistent state.
        /// </para>
        ///  
        /// <para>
        /// For more information about failing over an Amazon Aurora global database, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-global-database-disaster-recovery.html#aurora-global-database-failover.managed-unplanned">Performing
        /// managed failovers for Aurora global databases</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Switching over</i> - Use this operation on a healthy global database cluster for
        /// planned events, such as Regional rotation or to fail back to the original primary
        /// DB cluster after a failover operation. With this operation, there is no data loss.
        /// </para>
        ///  
        /// <para>
        /// For more information about switching over an Amazon Aurora global database, see <a
        /// href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-global-database-disaster-recovery.html#aurora-global-database-disaster-recovery.managed-failover">Performing
        /// switchovers for Aurora global databases</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the FailoverGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/FailoverGlobalCluster">REST API Reference for FailoverGlobalCluster Operation</seealso>
        public virtual FailoverGlobalClusterResponse FailoverGlobalCluster(FailoverGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<FailoverGlobalClusterResponse>(request, options);
        }


        /// <summary>
        /// Promotes the specified secondary DB cluster to be the primary DB cluster in the global
        /// database cluster to fail over or switch over a global database. Switchover operations
        /// were previously called "managed planned failovers."
        /// 
        ///  <note> 
        /// <para>
        /// Although this operation can be used either to fail over or to switch over a global
        /// database cluster, its intended use is for global database failover. To switch over
        /// a global database cluster, we recommend that you use the <a>SwitchoverGlobalCluster</a>
        /// operation instead.
        /// </para>
        ///  </note> 
        /// <para>
        /// How you use this operation depends on whether you are failing over or switching over
        /// your global database cluster:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Failing over - Specify the <c>AllowDataLoss</c> parameter and don't specify the <c>Switchover</c>
        /// parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Switching over - Specify the <c>Switchover</c> parameter or omit it, but don't specify
        /// the <c>AllowDataLoss</c> parameter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>About failing over and switching over</b> 
        /// </para>
        ///  
        /// <para>
        /// While failing over and switching over a global database cluster both change the primary
        /// DB cluster, you use these operations for different reasons:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Failing over</i> - Use this operation to respond to an unplanned event, such as
        /// a Regional disaster in the primary Region. Failing over can result in a loss of write
        /// transaction data that wasn't replicated to the chosen secondary before the failover
        /// event occurred. However, the recovery process that promotes a DB instance on the chosen
        /// seconday DB cluster to be the primary writer DB instance guarantees that the data
        /// is in a transactionally consistent state.
        /// </para>
        ///  
        /// <para>
        /// For more information about failing over an Amazon Aurora global database, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-global-database-disaster-recovery.html#aurora-global-database-failover.managed-unplanned">Performing
        /// managed failovers for Aurora global databases</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Switching over</i> - Use this operation on a healthy global database cluster for
        /// planned events, such as Regional rotation or to fail back to the original primary
        /// DB cluster after a failover operation. With this operation, there is no data loss.
        /// </para>
        ///  
        /// <para>
        /// For more information about switching over an Amazon Aurora global database, see <a
        /// href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-global-database-disaster-recovery.html#aurora-global-database-disaster-recovery.managed-failover">Performing
        /// switchovers for Aurora global databases</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FailoverGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FailoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FailoverGlobalClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<FailoverGlobalClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags on an Amazon RDS resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon RDS resource, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html">Tagging
        /// Amazon RDS Resources</a> in the <i>Amazon RDS User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Tagging.html">Tagging
        /// Amazon Aurora and Amazon RDS Resources</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <c>BlueGreenDeploymentIdentifier</c> doesn't refer to an existing blue/green deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyEndpointNotFoundException">
        /// The DB proxy endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotTenantDatabaseNotFoundException">
        /// The specified snapshot tenant database wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationNotFoundException">
        /// The specified integration could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseNotFoundException">
        /// The specified tenant database wasn't found in the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists all tags on an Amazon RDS resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon RDS resource, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html">Tagging
        /// Amazon RDS Resources</a> in the <i>Amazon RDS User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Tagging.html">Tagging
        /// Amazon Aurora and Amazon RDS Resources</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <c>BlueGreenDeploymentIdentifier</c> doesn't refer to an existing blue/green deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyEndpointNotFoundException">
        /// The DB proxy endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotTenantDatabaseNotFoundException">
        /// The specified snapshot tenant database wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationNotFoundException">
        /// The specified integration could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseNotFoundException">
        /// The specified tenant database wasn't found in the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyActivityStream


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
        /// This operation is supported for RDS for Oracle and Microsoft SQL Server.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyActivityStream service method.</param>
        /// 
        /// <returns>The response from the ModifyActivityStream service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.ResourceNotFoundException">
        /// The specified resource ID was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyActivityStream">REST API Reference for ModifyActivityStream Operation</seealso>
        public virtual ModifyActivityStreamResponse ModifyActivityStream(ModifyActivityStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// This operation is supported for RDS for Oracle and Microsoft SQL Server.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyActivityStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyActivityStream service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyActivityStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyActivityStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyCertificates


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
        /// 
        /// <returns>The response from the ModifyCertificates service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCertificates">REST API Reference for ModifyCertificates Operation</seealso>
        public virtual ModifyCertificatesResponse ModifyCertificates(ModifyCertificatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCertificates">REST API Reference for ModifyCertificates Operation</seealso>
        public virtual Task<ModifyCertificatesResponse> ModifyCertificatesAsync(ModifyCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCertificatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyCurrentDBClusterCapacity


        /// <summary>
        /// Set the capacity of an Aurora Serverless v1 DB cluster to a specific value.
        /// 
        ///  
        /// <para>
        /// Aurora Serverless v1 scales seamlessly based on the workload on the DB cluster. In
        /// some cases, the capacity might not scale fast enough to meet a sudden change in workload,
        /// such as a large number of new transactions. Call <c>ModifyCurrentDBClusterCapacity</c>
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
        /// If you call <c>ModifyCurrentDBClusterCapacity</c> with the default <c>TimeoutAction</c>,
        /// connections that prevent Aurora Serverless v1 from finding a scaling point might be
        /// dropped. For more information about scaling points, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.how-it-works.html#aurora-serverless.how-it-works.auto-scaling">
        /// Autoscaling for Aurora Serverless v1</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// This operation only applies to Aurora Serverless v1 DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCurrentDBClusterCapacity service method.</param>
        /// 
        /// <returns>The response from the ModifyCurrentDBClusterCapacity service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterCapacityException">
        /// <c>Capacity</c> isn't a valid Aurora Serverless DB cluster capacity. Valid capacity
        /// values are <c>2</c>, <c>4</c>, <c>8</c>, <c>16</c>, <c>32</c>, <c>64</c>, <c>128</c>,
        /// and <c>256</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCurrentDBClusterCapacity">REST API Reference for ModifyCurrentDBClusterCapacity Operation</seealso>
        public virtual ModifyCurrentDBClusterCapacityResponse ModifyCurrentDBClusterCapacity(ModifyCurrentDBClusterCapacityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// such as a large number of new transactions. Call <c>ModifyCurrentDBClusterCapacity</c>
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
        /// If you call <c>ModifyCurrentDBClusterCapacity</c> with the default <c>TimeoutAction</c>,
        /// connections that prevent Aurora Serverless v1 from finding a scaling point might be
        /// dropped. For more information about scaling points, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.how-it-works.html#aurora-serverless.how-it-works.auto-scaling">
        /// Autoscaling for Aurora Serverless v1</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// This operation only applies to Aurora Serverless v1 DB clusters.
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterCapacityException">
        /// <c>Capacity</c> isn't a valid Aurora Serverless DB cluster capacity. Valid capacity
        /// values are <c>2</c>, <c>4</c>, <c>8</c>, <c>16</c>, <c>32</c>, <c>64</c>, <c>128</c>,
        /// and <c>256</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCurrentDBClusterCapacity">REST API Reference for ModifyCurrentDBClusterCapacity Operation</seealso>
        public virtual Task<ModifyCurrentDBClusterCapacityResponse> ModifyCurrentDBClusterCapacityAsync(ModifyCurrentDBClusterCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyCurrentDBClusterCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCurrentDBClusterCapacityResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyCurrentDBClusterCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyCustomDBEngineVersion


        /// <summary>
        /// Modifies the status of a custom engine version (CEV). You can find CEVs to modify
        /// by calling <c>DescribeDBEngineVersions</c>.
        /// 
        ///  <note> 
        /// <para>
        /// The MediaImport service that imports files from Amazon S3 to create CEVs isn't integrated
        /// with Amazon Web Services CloudTrail. If you turn on data logging for Amazon RDS in
        /// CloudTrail, calls to the <c>ModifyCustomDbEngineVersion</c> event aren't logged. However,
        /// you might see calls from the API gateway that accesses your Amazon S3 bucket. These
        /// calls originate from the MediaImport service for the <c>ModifyCustomDbEngineVersion</c>
        /// event.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/custom-cev.html#custom-cev.modify">Modifying
        /// CEV status</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCustomDBEngineVersion service method.</param>
        /// 
        /// <returns>The response from the ModifyCustomDBEngineVersion service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.CustomDBEngineVersionNotFoundException">
        /// The specified CEV was not found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidCustomDBEngineVersionStateException">
        /// You can't delete the CEV.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyCustomDBEngineVersion">REST API Reference for ModifyCustomDBEngineVersion Operation</seealso>
        public virtual ModifyCustomDBEngineVersionResponse ModifyCustomDBEngineVersion(ModifyCustomDBEngineVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyCustomDBEngineVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCustomDBEngineVersionResponseUnmarshaller.Instance;

            return Invoke<ModifyCustomDBEngineVersionResponse>(request, options);
        }


        /// <summary>
        /// Modifies the status of a custom engine version (CEV). You can find CEVs to modify
        /// by calling <c>DescribeDBEngineVersions</c>.
        /// 
        ///  <note> 
        /// <para>
        /// The MediaImport service that imports files from Amazon S3 to create CEVs isn't integrated
        /// with Amazon Web Services CloudTrail. If you turn on data logging for Amazon RDS in
        /// CloudTrail, calls to the <c>ModifyCustomDbEngineVersion</c> event aren't logged. However,
        /// you might see calls from the API gateway that accesses your Amazon S3 bucket. These
        /// calls originate from the MediaImport service for the <c>ModifyCustomDbEngineVersion</c>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyCustomDBEngineVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCustomDBEngineVersionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyCustomDBEngineVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBCluster


        /// <summary>
        /// Modifies the settings of an Amazon Aurora DB cluster or a Multi-AZ DB cluster. You
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing DB cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotAvailableException">
        /// The <c>aurora-iopt1</c> storage type isn't available, because you modified the DB
        /// cluster to use this storage type less than one month ago.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual ModifyDBClusterResponse ModifyDBCluster(ModifyDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterResponse>(request, options);
        }


        /// <summary>
        /// Modifies the settings of an Amazon Aurora DB cluster or a Multi-AZ DB cluster. You
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide</i>.
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing DB cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotAvailableException">
        /// The <c>aurora-iopt1</c> storage type isn't available, because you modified the DB
        /// cluster to use this storage type less than one month ago.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual Task<ModifyDBClusterResponse> ModifyDBClusterAsync(ModifyDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBClusterEndpoint


        /// <summary>
        /// Modifies the properties of an endpoint in an Amazon Aurora DB cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This operation only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterEndpoint service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterEndpoint service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterEndpointNotFoundException">
        /// The specified custom endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
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
        public virtual ModifyDBClusterEndpointResponse ModifyDBClusterEndpoint(ModifyDBClusterEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterEndpointResponse>(request, options);
        }


        /// <summary>
        /// Modifies the properties of an endpoint in an Amazon Aurora DB cluster.
        /// 
        ///  <note> 
        /// <para>
        /// This operation only applies to Aurora DB clusters.
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
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBClusterEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBClusterParameterGroup


        /// <summary>
        /// Modifies the parameters of a DB cluster parameter group. To modify more than one parameter,
        /// submit a list of the following: <c>ParameterName</c>, <c>ParameterValue</c>, and <c>ApplyMethod</c>.
        /// A maximum of 20 parameters can be modified in a single request.
        /// 
        ///  <important> 
        /// <para>
        /// After you create a DB cluster parameter group, you should wait at least 5 minutes
        /// before creating your first DB cluster that uses that DB cluster parameter group as
        /// the default parameter group. This allows Amazon RDS to fully complete the create operation
        /// before the parameter group is used as the default for a new DB cluster. This is especially
        /// important for parameters that are critical when creating the default database for
        /// a DB cluster, such as the character set for the default database defined by the <c>character_set_database</c>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <c>DescribeDBClusterParameters</c> operation to verify that
        /// your DB cluster parameter group has been created or modified.
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        public virtual ModifyDBClusterParameterGroupResponse ModifyDBClusterParameterGroup(ModifyDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Modifies the parameters of a DB cluster parameter group. To modify more than one parameter,
        /// submit a list of the following: <c>ParameterName</c>, <c>ParameterValue</c>, and <c>ApplyMethod</c>.
        /// A maximum of 20 parameters can be modified in a single request.
        /// 
        ///  <important> 
        /// <para>
        /// After you create a DB cluster parameter group, you should wait at least 5 minutes
        /// before creating your first DB cluster that uses that DB cluster parameter group as
        /// the default parameter group. This allows Amazon RDS to fully complete the create operation
        /// before the parameter group is used as the default for a new DB cluster. This is especially
        /// important for parameters that are critical when creating the default database for
        /// a DB cluster, such as the character set for the default database defined by the <c>character_set_database</c>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <c>DescribeDBClusterParameters</c> operation to verify that
        /// your DB cluster parameter group has been created or modified.
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        public virtual Task<ModifyDBClusterParameterGroupResponse> ModifyDBClusterParameterGroupAsync(ModifyDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBClusterSnapshotAttribute


        /// <summary>
        /// Adds an attribute and values to, or removes an attribute and values from, a manual
        /// DB cluster snapshot.
        /// 
        ///  
        /// <para>
        /// To share a manual DB cluster snapshot with other Amazon Web Services accounts, specify
        /// <c>restore</c> as the <c>AttributeName</c> and use the <c>ValuesToAdd</c> parameter
        /// to add a list of IDs of the Amazon Web Services accounts that are authorized to restore
        /// the manual DB cluster snapshot. Use the value <c>all</c> to make the manual DB cluster
        /// snapshot public, which means that it can be copied or restored by all Amazon Web Services
        /// accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't add the <c>all</c> value for any manual DB cluster snapshots that contain private
        /// information that you don't want available to all Amazon Web Services accounts.
        /// </para>
        ///  </note> 
        /// <para>
        /// If a manual DB cluster snapshot is encrypted, it can be shared, but only by specifying
        /// a list of authorized Amazon Web Services account IDs for the <c>ValuesToAdd</c> parameter.
        /// You can't use <c>all</c> as a value for that parameter in this case.
        /// </para>
        ///  
        /// <para>
        /// To view which Amazon Web Services accounts have access to copy or restore a manual
        /// DB cluster snapshot, or whether a manual DB cluster snapshot is public or private,
        /// use the <a>DescribeDBClusterSnapshotAttributes</a> API operation. The accounts are
        /// returned as values for the <c>restore</c> attribute.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyDBClusterSnapshotAttribute service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterSnapshotStateException">
        /// The supplied value isn't a valid DB cluster snapshot state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SharedSnapshotQuotaExceededException">
        /// You have exceeded the maximum number of accounts that you can share a manual DB snapshot
        /// with.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        public virtual ModifyDBClusterSnapshotAttributeResponse ModifyDBClusterSnapshotAttribute(ModifyDBClusterSnapshotAttributeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>restore</c> as the <c>AttributeName</c> and use the <c>ValuesToAdd</c> parameter
        /// to add a list of IDs of the Amazon Web Services accounts that are authorized to restore
        /// the manual DB cluster snapshot. Use the value <c>all</c> to make the manual DB cluster
        /// snapshot public, which means that it can be copied or restored by all Amazon Web Services
        /// accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't add the <c>all</c> value for any manual DB cluster snapshots that contain private
        /// information that you don't want available to all Amazon Web Services accounts.
        /// </para>
        ///  </note> 
        /// <para>
        /// If a manual DB cluster snapshot is encrypted, it can be shared, but only by specifying
        /// a list of authorized Amazon Web Services account IDs for the <c>ValuesToAdd</c> parameter.
        /// You can't use <c>all</c> as a value for that parameter in this case.
        /// </para>
        ///  
        /// <para>
        /// To view which Amazon Web Services accounts have access to copy or restore a manual
        /// DB cluster snapshot, or whether a manual DB cluster snapshot is public or private,
        /// use the <a>DescribeDBClusterSnapshotAttributes</a> API operation. The accounts are
        /// returned as values for the <c>restore</c> attribute.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBClusterSnapshotAttribute service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBClusterSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBClusterSnapshotAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBInstance


        /// <summary>
        /// Modifies settings for a DB instance. You can change one or more database configuration
        /// parameters by specifying these parameters and the new values in the request. To learn
        /// what modifications you can make to your DB instance, call <c>DescribeValidDBInstanceModifications</c>
        /// before you call <c>ModifyDBInstance</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance service method.</param>
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
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBUpgradeDependencyFailureException">
        /// The DB upgrade failed because a resource the DB depends on can't be modified.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
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
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseQuotaExceededException">
        /// You attempted to create more tenant databases than are permitted in your Amazon Web
        /// Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        public virtual ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return Invoke<ModifyDBInstanceResponse>(request, options);
        }


        /// <summary>
        /// Modifies settings for a DB instance. You can change one or more database configuration
        /// parameters by specifying these parameters and the new values in the request. To learn
        /// what modifications you can make to your DB instance, call <c>DescribeValidDBInstanceModifications</c>
        /// before you call <c>ModifyDBInstance</c>.
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
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBUpgradeDependencyFailureException">
        /// The DB upgrade failed because a resource the DB depends on can't be modified.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
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
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseQuotaExceededException">
        /// You attempted to create more tenant databases than are permitted in your Amazon Web
        /// Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        public virtual Task<ModifyDBInstanceResponse> ModifyDBInstanceAsync(ModifyDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBParameterGroup


        /// <summary>
        /// Modifies the parameters of a DB parameter group. To modify more than one parameter,
        /// submit a list of the following: <c>ParameterName</c>, <c>ParameterValue</c>, and <c>ApplyMethod</c>.
        /// A maximum of 20 parameters can be modified in a single request.
        /// 
        ///  <important> 
        /// <para>
        /// After you modify a DB parameter group, you should wait at least 5 minutes before creating
        /// your first DB instance that uses that DB parameter group as the default parameter
        /// group. This allows Amazon RDS to fully complete the modify operation before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <c>character_set_database</c>
        /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
        /// RDS console</a> or the <i>DescribeDBParameters</i> command to verify that your DB
        /// parameter group has been created or modified.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBParameterGroup">REST API Reference for ModifyDBParameterGroup Operation</seealso>
        public virtual ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Modifies the parameters of a DB parameter group. To modify more than one parameter,
        /// submit a list of the following: <c>ParameterName</c>, <c>ParameterValue</c>, and <c>ApplyMethod</c>.
        /// A maximum of 20 parameters can be modified in a single request.
        /// 
        ///  <important> 
        /// <para>
        /// After you modify a DB parameter group, you should wait at least 5 minutes before creating
        /// your first DB instance that uses that DB parameter group as the default parameter
        /// group. This allows Amazon RDS to fully complete the modify operation before the parameter
        /// group is used as the default for a new DB instance. This is especially important for
        /// parameters that are critical when creating the default database for a DB instance,
        /// such as the character set for the default database defined by the <c>character_set_database</c>
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
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBParameterGroup">REST API Reference for ModifyDBParameterGroup Operation</seealso>
        public virtual Task<ModifyDBParameterGroupResponse> ModifyDBParameterGroupAsync(ModifyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBProxy


        /// <summary>
        /// Changes the settings for an existing DB proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBProxy service method.</param>
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
        public virtual ModifyDBProxyResponse ModifyDBProxy(ModifyDBProxyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBProxyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBProxyEndpoint


        /// <summary>
        /// Changes the settings for an existing DB proxy endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBProxyEndpoint service method.</param>
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
        public virtual ModifyDBProxyEndpointResponse ModifyDBProxyEndpoint(ModifyDBProxyEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBProxyEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBProxyTargetGroup


        /// <summary>
        /// Modifies the properties of a <c>DBProxyTargetGroup</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBProxyTargetGroup service method.</param>
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
        public virtual ModifyDBProxyTargetGroupResponse ModifyDBProxyTargetGroup(ModifyDBProxyTargetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyTargetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBProxyTargetGroupResponse>(request, options);
        }


        /// <summary>
        /// Modifies the properties of a <c>DBProxyTargetGroup</c>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBProxyTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBProxyTargetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBProxyTargetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBRecommendation


        /// <summary>
        /// Updates the recommendation status and recommended action status for the specified
        /// recommendation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBRecommendation service method.</param>
        /// 
        /// <returns>The response from the ModifyDBRecommendation service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBRecommendation">REST API Reference for ModifyDBRecommendation Operation</seealso>
        public virtual ModifyDBRecommendationResponse ModifyDBRecommendation(ModifyDBRecommendationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBRecommendationResponseUnmarshaller.Instance;

            return Invoke<ModifyDBRecommendationResponse>(request, options);
        }


        /// <summary>
        /// Updates the recommendation status and recommended action status for the specified
        /// recommendation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBRecommendation service method, as returned by RDS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBRecommendation">REST API Reference for ModifyDBRecommendation Operation</seealso>
        public virtual Task<ModifyDBRecommendationResponse> ModifyDBRecommendationAsync(ModifyDBRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBRecommendationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBRecommendationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBShardGroup


        /// <summary>
        /// Modifies the settings of an Aurora Limitless Database DB shard group. You can change
        /// one or more settings by specifying these parameters and the new values in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBShardGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBShardGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupAlreadyExistsException">
        /// The specified DB shard group name must be unique in your Amazon Web Services account
        /// in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBShardGroup">REST API Reference for ModifyDBShardGroup Operation</seealso>
        public virtual ModifyDBShardGroupResponse ModifyDBShardGroup(ModifyDBShardGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBShardGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBShardGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBShardGroupResponse>(request, options);
        }


        /// <summary>
        /// Modifies the settings of an Aurora Limitless Database DB shard group. You can change
        /// one or more settings by specifying these parameters and the new values in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBShardGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBShardGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupAlreadyExistsException">
        /// The specified DB shard group name must be unique in your Amazon Web Services account
        /// in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBShardGroup">REST API Reference for ModifyDBShardGroup Operation</seealso>
        public virtual Task<ModifyDBShardGroupResponse> ModifyDBShardGroupAsync(ModifyDBShardGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBShardGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBShardGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBShardGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBSnapshot


        /// <summary>
        /// Updates a manual DB snapshot with a new engine version. The snapshot can be encrypted
        /// or unencrypted, but not shared or public. 
        /// 
        ///  
        /// <para>
        /// Amazon RDS supports upgrading DB snapshots for MariaDB, MySQL, PostgreSQL, and Oracle.
        /// This operation doesn't apply to RDS Custom or RDS for Db2.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshot service method.</param>
        /// 
        /// <returns>The response from the ModifyDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSnapshot">REST API Reference for ModifyDBSnapshot Operation</seealso>
        public virtual ModifyDBSnapshotResponse ModifyDBSnapshot(ModifyDBSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Amazon RDS supports upgrading DB snapshots for MariaDB, MySQL, PostgreSQL, and Oracle.
        /// This operation doesn't apply to RDS Custom or RDS for Db2.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSnapshot">REST API Reference for ModifyDBSnapshot Operation</seealso>
        public virtual Task<ModifyDBSnapshotResponse> ModifyDBSnapshotAsync(ModifyDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBSnapshotAttribute


        /// <summary>
        /// Adds an attribute and values to, or removes an attribute and values from, a manual
        /// DB snapshot.
        /// 
        ///  
        /// <para>
        /// To share a manual DB snapshot with other Amazon Web Services accounts, specify <c>restore</c>
        /// as the <c>AttributeName</c> and use the <c>ValuesToAdd</c> parameter to add a list
        /// of IDs of the Amazon Web Services accounts that are authorized to restore the manual
        /// DB snapshot. Uses the value <c>all</c> to make the manual DB snapshot public, which
        /// means it can be copied or restored by all Amazon Web Services accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't add the <c>all</c> value for any manual DB snapshots that contain private information
        /// that you don't want available to all Amazon Web Services accounts.
        /// </para>
        ///  </note> 
        /// <para>
        /// If the manual DB snapshot is encrypted, it can be shared, but only by specifying a
        /// list of authorized Amazon Web Services account IDs for the <c>ValuesToAdd</c> parameter.
        /// You can't use <c>all</c> as a value for that parameter in this case.
        /// </para>
        ///  
        /// <para>
        /// To view which Amazon Web Services accounts have access to copy or restore a manual
        /// DB snapshot, or whether a manual DB snapshot public or private, use the <a>DescribeDBSnapshotAttributes</a>
        /// API operation. The accounts are returned as values for the <c>restore</c> attribute.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyDBSnapshotAttribute service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSnapshotStateException">
        /// The state of the DB snapshot doesn't allow deletion.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SharedSnapshotQuotaExceededException">
        /// You have exceeded the maximum number of accounts that you can share a manual DB snapshot
        /// with.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSnapshotAttribute">REST API Reference for ModifyDBSnapshotAttribute Operation</seealso>
        public virtual ModifyDBSnapshotAttributeResponse ModifyDBSnapshotAttribute(ModifyDBSnapshotAttributeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// To share a manual DB snapshot with other Amazon Web Services accounts, specify <c>restore</c>
        /// as the <c>AttributeName</c> and use the <c>ValuesToAdd</c> parameter to add a list
        /// of IDs of the Amazon Web Services accounts that are authorized to restore the manual
        /// DB snapshot. Uses the value <c>all</c> to make the manual DB snapshot public, which
        /// means it can be copied or restored by all Amazon Web Services accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't add the <c>all</c> value for any manual DB snapshots that contain private information
        /// that you don't want available to all Amazon Web Services accounts.
        /// </para>
        ///  </note> 
        /// <para>
        /// If the manual DB snapshot is encrypted, it can be shared, but only by specifying a
        /// list of authorized Amazon Web Services account IDs for the <c>ValuesToAdd</c> parameter.
        /// You can't use <c>all</c> as a value for that parameter in this case.
        /// </para>
        ///  
        /// <para>
        /// To view which Amazon Web Services accounts have access to copy or restore a manual
        /// DB snapshot, or whether a manual DB snapshot public or private, use the <a>DescribeDBSnapshotAttributes</a>
        /// API operation. The accounts are returned as values for the <c>restore</c> attribute.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshotAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyDBSnapshotAttribute service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSnapshotAttributeResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBSnapshotAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBSubnetGroup


        /// <summary>
        /// Modifies an existing DB subnet group. DB subnet groups must contain at least one subnet
        /// in at least two AZs in the Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyDBSubnetGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of subnets in a
        /// DB subnet groups.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it's in use.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidSubnetException">
        /// The requested subnet is invalid, or multiple subnets were requested that are not all
        /// in a common VPC.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubnetAlreadyInUseException">
        /// The DB subnet is already in use in the Availability Zone.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        public virtual ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of subnets in a
        /// DB subnet groups.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSubnetGroupStateException">
        /// The DB subnet group cannot be deleted because it's in use.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyDBSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyDBSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyEventSubscription


        /// <summary>
        /// Modifies an existing RDS event notification subscription. You can't modify the source
        /// identifiers using this call. To change source identifiers for a subscription, use
        /// the <c>AddSourceIdentifierToSubscription</c> and <c>RemoveSourceIdentifierFromSubscription</c>
        /// calls.
        /// 
        ///  
        /// <para>
        /// You can see a list of the event categories for a given source type (<c>SourceType</c>)
        /// in <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">Events</a>
        /// in the <i>Amazon RDS User Guide</i> or by using the <c>DescribeEventCategories</c>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
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
        public virtual ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Modifies an existing RDS event notification subscription. You can't modify the source
        /// identifiers using this call. To change source identifiers for a subscription, use
        /// the <c>AddSourceIdentifierToSubscription</c> and <c>RemoveSourceIdentifierFromSubscription</c>
        /// calls.
        /// 
        ///  
        /// <para>
        /// You can see a list of the event categories for a given source type (<c>SourceType</c>)
        /// in <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">Events</a>
        /// in the <i>Amazon RDS User Guide</i> or by using the <c>DescribeEventCategories</c>
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyEventSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyGlobalCluster


        /// <summary>
        /// Modifies a setting for an Amazon Aurora global database cluster. You can change one
        /// or more database configuration parameters by specifying these parameters and the new
        /// values in the request. For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// This operation only applies to Aurora global database clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterAlreadyExistsException">
        /// The <c>GlobalClusterIdentifier</c> already exists. Specify a new global database identifier
        /// (unique name) to create a new global database cluster or to rename an existing one.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
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
        public virtual ModifyGlobalClusterResponse ModifyGlobalCluster(ModifyGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyGlobalClusterResponse>(request, options);
        }


        /// <summary>
        /// Modifies a setting for an Amazon Aurora global database cluster. You can change one
        /// or more database configuration parameters by specifying these parameters and the new
        /// values in the request. For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// This operation only applies to Aurora global database clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterAlreadyExistsException">
        /// The <c>GlobalClusterIdentifier</c> already exists. Specify a new global database identifier
        /// (unique name) to create a new global database cluster or to rename an existing one.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyGlobalClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyGlobalClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyIntegration


        /// <summary>
        /// Modifies a zero-ETL integration with Amazon Redshift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIntegration service method.</param>
        /// 
        /// <returns>The response from the ModifyIntegration service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.IntegrationConflictOperationException">
        /// A conflicting conditional operation is currently in progress against this resource.
        /// Typically occurs when there are multiple requests being made to the same resource
        /// at the same time, and these requests conflict with each other.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationNotFoundException">
        /// The specified integration could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidIntegrationStateException">
        /// The integration is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyIntegration">REST API Reference for ModifyIntegration Operation</seealso>
        public virtual ModifyIntegrationResponse ModifyIntegration(ModifyIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyIntegrationResponseUnmarshaller.Instance;

            return Invoke<ModifyIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Modifies a zero-ETL integration with Amazon Redshift.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyIntegration service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.IntegrationConflictOperationException">
        /// A conflicting conditional operation is currently in progress against this resource.
        /// Typically occurs when there are multiple requests being made to the same resource
        /// at the same time, and these requests conflict with each other.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationNotFoundException">
        /// The specified integration could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidIntegrationStateException">
        /// The integration is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyIntegration">REST API Reference for ModifyIntegration Operation</seealso>
        public virtual Task<ModifyIntegrationResponse> ModifyIntegrationAsync(ModifyIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyOptionGroup


        /// <summary>
        /// Modifies an existing option group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyOptionGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyOptionGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.InvalidOptionGroupStateException">
        /// The option group isn't in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyOptionGroup">REST API Reference for ModifyOptionGroup Operation</seealso>
        public virtual ModifyOptionGroupResponse ModifyOptionGroup(ModifyOptionGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyOptionGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyOptionGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyOptionGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyTenantDatabase


        /// <summary>
        /// Modifies an existing tenant database in a DB instance. You can change the tenant database
        /// name or the master user password. This operation is supported only for RDS for Oracle
        /// CDB instances using the multi-tenant configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTenantDatabase service method.</param>
        /// 
        /// <returns>The response from the ModifyTenantDatabase service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseAlreadyExistsException">
        /// You attempted to either create a tenant database that already exists or modify a tenant
        /// database to use the name of an existing tenant database.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseNotFoundException">
        /// The specified tenant database wasn't found in the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyTenantDatabase">REST API Reference for ModifyTenantDatabase Operation</seealso>
        public virtual ModifyTenantDatabaseResponse ModifyTenantDatabase(ModifyTenantDatabaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyTenantDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyTenantDatabaseResponseUnmarshaller.Instance;

            return Invoke<ModifyTenantDatabaseResponse>(request, options);
        }


        /// <summary>
        /// Modifies an existing tenant database in a DB instance. You can change the tenant database
        /// name or the master user password. This operation is supported only for RDS for Oracle
        /// CDB instances using the multi-tenant configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTenantDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyTenantDatabase service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseAlreadyExistsException">
        /// You attempted to either create a tenant database that already exists or modify a tenant
        /// database to use the name of an existing tenant database.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseNotFoundException">
        /// The specified tenant database wasn't found in the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyTenantDatabase">REST API Reference for ModifyTenantDatabase Operation</seealso>
        public virtual Task<ModifyTenantDatabaseResponse> ModifyTenantDatabaseAsync(ModifyTenantDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ModifyTenantDatabaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyTenantDatabaseResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyTenantDatabaseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PromoteReadReplica


        /// <summary>
        /// Promotes a read replica DB instance to a standalone DB instance.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// Backup duration is a function of the amount of changes to the database since the previous
        /// backup. If you plan to promote a read replica to a standalone instance, we recommend
        /// that you enable backups and complete at least one backup prior to promotion. In addition,
        /// a read replica cannot be promoted to a standalone instance when it is in the <c>backing-up</c>
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
        /// 
        /// <returns>The response from the PromoteReadReplica service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplica">REST API Reference for PromoteReadReplica Operation</seealso>
        public virtual PromoteReadReplicaResponse PromoteReadReplica(PromoteReadReplicaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// a read replica cannot be promoted to a standalone instance when it is in the <c>backing-up</c>
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
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplica">REST API Reference for PromoteReadReplica Operation</seealso>
        public virtual Task<PromoteReadReplicaResponse> PromoteReadReplicaAsync(PromoteReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PromoteReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteReadReplicaResponseUnmarshaller.Instance;
            
            return InvokeAsync<PromoteReadReplicaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PromoteReadReplicaDBCluster


        /// <summary>
        /// Promotes a read replica DB cluster to a standalone DB cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplicaDBCluster service method.</param>
        /// 
        /// <returns>The response from the PromoteReadReplicaDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplicaDBCluster">REST API Reference for PromoteReadReplicaDBCluster Operation</seealso>
        public virtual PromoteReadReplicaDBClusterResponse PromoteReadReplicaDBCluster(PromoteReadReplicaDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplicaDBCluster">REST API Reference for PromoteReadReplicaDBCluster Operation</seealso>
        public virtual Task<PromoteReadReplicaDBClusterResponse> PromoteReadReplicaDBClusterAsync(PromoteReadReplicaDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PromoteReadReplicaDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<PromoteReadReplicaDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedDBInstancesOffering


        /// <summary>
        /// Purchases a reserved DB instance offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedDBInstancesOffering service method.</param>
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
        public virtual PurchaseReservedDBInstancesOfferingResponse PurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PurchaseReservedDBInstancesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance;
            
            return InvokeAsync<PurchaseReservedDBInstancesOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootDBCluster


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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBCluster service method.</param>
        /// 
        /// <returns>The response from the RebootDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RebootDBCluster">REST API Reference for RebootDBCluster Operation</seealso>
        public virtual RebootDBClusterResponse RebootDBCluster(RebootDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDBClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<RebootDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootDBInstance


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
        /// with the <c>RebootDBCluster</c> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance service method.</param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// with the <c>RebootDBCluster</c> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual Task<RebootDBInstanceResponse> RebootDBInstanceAsync(RebootDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<RebootDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootDBShardGroup


        /// <summary>
        /// You might need to reboot your DB shard group, usually for maintenance reasons. For
        /// example, if you make certain modifications, reboot the DB shard group for the changes
        /// to take effect.
        /// 
        ///  
        /// <para>
        /// This operation applies only to Aurora Limitless Database DBb shard groups.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBShardGroup service method.</param>
        /// 
        /// <returns>The response from the RebootDBShardGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBShardGroupStateException">
        /// The DB shard group must be in the available state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RebootDBShardGroup">REST API Reference for RebootDBShardGroup Operation</seealso>
        public virtual RebootDBShardGroupResponse RebootDBShardGroup(RebootDBShardGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDBShardGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDBShardGroupResponseUnmarshaller.Instance;

            return Invoke<RebootDBShardGroupResponse>(request, options);
        }


        /// <summary>
        /// You might need to reboot your DB shard group, usually for maintenance reasons. For
        /// example, if you make certain modifications, reboot the DB shard group for the changes
        /// to take effect.
        /// 
        ///  
        /// <para>
        /// This operation applies only to Aurora Limitless Database DBb shard groups.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDBShardGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootDBShardGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBShardGroupStateException">
        /// The DB shard group must be in the available state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RebootDBShardGroup">REST API Reference for RebootDBShardGroup Operation</seealso>
        public virtual Task<RebootDBShardGroupResponse> RebootDBShardGroupAsync(RebootDBShardGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDBShardGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDBShardGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<RebootDBShardGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterDBProxyTargets


        /// <summary>
        /// Associate one or more <c>DBProxyTarget</c> data structures with a <c>DBProxyTargetGroup</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDBProxyTargets service method.</param>
        /// 
        /// <returns>The response from the RegisterDBProxyTargets service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
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
        public virtual RegisterDBProxyTargetsResponse RegisterDBProxyTargets(RegisterDBProxyTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDBProxyTargetsResponseUnmarshaller.Instance;

            return Invoke<RegisterDBProxyTargetsResponse>(request, options);
        }


        /// <summary>
        /// Associate one or more <c>DBProxyTarget</c> data structures with a <c>DBProxyTargetGroup</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDBProxyTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterDBProxyTargets service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterDBProxyTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDBProxyTargetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<RegisterDBProxyTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveFromGlobalCluster


        /// <summary>
        /// Detaches an Aurora secondary cluster from an Aurora global database cluster. The cluster
        /// becomes a standalone cluster with read-write capability instead of being read-only
        /// and receiving data from a primary cluster in a different Region.
        /// 
        ///  <note> 
        /// <para>
        /// This operation only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFromGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the RemoveFromGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveFromGlobalCluster">REST API Reference for RemoveFromGlobalCluster Operation</seealso>
        public virtual RemoveFromGlobalClusterResponse RemoveFromGlobalCluster(RemoveFromGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// This operation only applies to Aurora DB clusters.
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveFromGlobalCluster">REST API Reference for RemoveFromGlobalCluster Operation</seealso>
        public virtual Task<RemoveFromGlobalClusterResponse> RemoveFromGlobalClusterAsync(RemoveFromGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveFromGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveFromGlobalClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveFromGlobalClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveRoleFromDBCluster


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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBCluster service method.</param>
        /// 
        /// <returns>The response from the RemoveRoleFromDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterRoleNotFoundException">
        /// The specified IAM role Amazon Resource Name (ARN) isn't associated with the specified
        /// DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveRoleFromDBCluster">REST API Reference for RemoveRoleFromDBCluster Operation</seealso>
        public virtual RemoveRoleFromDBClusterResponse RemoveRoleFromDBCluster(RemoveRoleFromDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveRoleFromDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromDBClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveRoleFromDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveRoleFromDBInstance


        /// <summary>
        /// Disassociates an Amazon Web Services Identity and Access Management (IAM) role from
        /// a DB instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBInstance service method.</param>
        /// 
        /// <returns>The response from the RemoveRoleFromDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceRoleNotFoundException">
        /// The specified <c>RoleArn</c> value doesn't match the specified feature for the DB
        /// instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveRoleFromDBInstance">REST API Reference for RemoveRoleFromDBInstance Operation</seealso>
        public virtual RemoveRoleFromDBInstanceResponse RemoveRoleFromDBInstance(RemoveRoleFromDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceRoleNotFoundException">
        /// The specified <c>RoleArn</c> value doesn't match the specified feature for the DB
        /// instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveRoleFromDBInstance">REST API Reference for RemoveRoleFromDBInstance Operation</seealso>
        public virtual Task<RemoveRoleFromDBInstanceResponse> RemoveRoleFromDBInstanceAsync(RemoveRoleFromDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveRoleFromDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveRoleFromDBInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveRoleFromDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveSourceIdentifierFromSubscription


        /// <summary>
        /// Removes a source identifier from an existing RDS event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription service method.</param>
        /// 
        /// <returns>The response from the RemoveSourceIdentifierFromSubscription service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.SourceNotFoundException">
        /// The requested source could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.SubscriptionNotFoundException">
        /// The subscription name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        public virtual RemoveSourceIdentifierFromSubscriptionResponse RemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveSourceIdentifierFromSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveSourceIdentifierFromSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource


        /// <summary>
        /// Removes metadata tags from an Amazon RDS resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon RDS resource, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html">Tagging
        /// Amazon RDS Resources</a> in the <i>Amazon RDS User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Tagging.html">Tagging
        /// Amazon Aurora and Amazon RDS Resources</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <c>BlueGreenDeploymentIdentifier</c> doesn't refer to an existing blue/green deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyEndpointNotFoundException">
        /// The DB proxy endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotTenantDatabaseNotFoundException">
        /// The specified snapshot tenant database wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationNotFoundException">
        /// The specified integration could not be found.
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
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseNotFoundException">
        /// The specified tenant database wasn't found in the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes metadata tags from an Amazon RDS resource.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging an Amazon RDS resource, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.html">Tagging
        /// Amazon RDS Resources</a> in the <i>Amazon RDS User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_Tagging.html">Tagging
        /// Amazon Aurora and Amazon RDS Resources</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <c>BlueGreenDeploymentIdentifier</c> doesn't refer to an existing blue/green deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyEndpointNotFoundException">
        /// The DB proxy endpoint doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyNotFoundException">
        /// The specified proxy name doesn't correspond to a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBProxyTargetGroupNotFoundException">
        /// The specified target group isn't available for a proxy owned by your Amazon Web Services
        /// account in the specified Amazon Web Services Region.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBShardGroupNotFoundException">
        /// The specified DB shard group name wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotTenantDatabaseNotFoundException">
        /// The specified snapshot tenant database wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.IntegrationNotFoundException">
        /// The specified integration could not be found.
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
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseNotFoundException">
        /// The specified tenant database wasn't found in the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetDBClusterParameterGroup


        /// <summary>
        /// Modifies the parameters of a DB cluster parameter group to the default value. To reset
        /// specific parameters submit a list of the following: <c>ParameterName</c> and <c>ApplyMethod</c>.
        /// To reset the entire DB cluster parameter group, specify the <c>DBClusterParameterGroupName</c>
        /// and <c>ResetAllParameters</c> parameters.
        /// 
        ///  
        /// <para>
        /// When resetting the entire group, dynamic parameters are updated immediately and static
        /// parameters are set to <c>pending-reboot</c> to take effect on the next DB instance
        /// restart or <c>RebootDBInstance</c> request. You must call <c>RebootDBInstance</c>
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        public virtual ResetDBClusterParameterGroupResponse ResetDBClusterParameterGroup(ResetDBClusterParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBClusterParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Modifies the parameters of a DB cluster parameter group to the default value. To reset
        /// specific parameters submit a list of the following: <c>ParameterName</c> and <c>ApplyMethod</c>.
        /// To reset the entire DB cluster parameter group, specify the <c>DBClusterParameterGroupName</c>
        /// and <c>ResetAllParameters</c> parameters.
        /// 
        ///  
        /// <para>
        /// When resetting the entire group, dynamic parameters are updated immediately and static
        /// parameters are set to <c>pending-reboot</c> to take effect on the next DB instance
        /// restart or <c>RebootDBInstance</c> request. You must call <c>RebootDBInstance</c>
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
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetDBClusterParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        public virtual Task<ResetDBClusterParameterGroupResponse> ResetDBClusterParameterGroupAsync(ResetDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetDBClusterParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBClusterParameterGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResetDBClusterParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetDBParameterGroup


        /// <summary>
        /// Modifies the parameters of a DB parameter group to the engine/system default value.
        /// To reset specific parameters, provide a list of the following: <c>ParameterName</c>
        /// and <c>ApplyMethod</c>. To reset the entire DB parameter group, specify the <c>DBParameterGroup</c>
        /// name and <c>ResetAllParameters</c> parameters. When resetting the entire group, dynamic
        /// parameters are updated immediately and static parameters are set to <c>pending-reboot</c>
        /// to take effect on the next DB instance restart or <c>RebootDBInstance</c> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBParameterGroup">REST API Reference for ResetDBParameterGroup Operation</seealso>
        public virtual ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Modifies the parameters of a DB parameter group to the engine/system default value.
        /// To reset specific parameters, provide a list of the following: <c>ParameterName</c>
        /// and <c>ApplyMethod</c>. To reset the entire DB parameter group, specify the <c>DBParameterGroup</c>
        /// name and <c>ResetAllParameters</c> parameters. When resetting the entire group, dynamic
        /// parameters are updated immediately and static parameters are set to <c>pending-reboot</c>
        /// to take effect on the next DB instance restart or <c>RebootDBInstance</c> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetDBParameterGroup service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBParameterGroupStateException">
        /// The DB parameter group is in use or is in an invalid state. If you are attempting
        /// to delete the parameter group, you can't delete it when the parameter group is in
        /// this state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBParameterGroup">REST API Reference for ResetDBParameterGroup Operation</seealso>
        public virtual Task<ResetDBParameterGroupResponse> ResetDBParameterGroupAsync(ResetDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetDBParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResetDBParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBClusterFromS3


        /// <summary>
        /// Creates an Amazon Aurora DB cluster from MySQL data stored in an Amazon S3 bucket.
        /// Amazon RDS must be authorized to access the Amazon S3 bucket and the data must be
        /// created using the Percona XtraBackup utility as described in <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/AuroraMySQL.Migrating.ExtMySQL.html#AuroraMySQL.Migrating.ExtMySQL.S3">
        /// Migrating Data from MySQL by Using an Amazon S3 Bucket</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// This operation only restores the DB cluster, not the DB instances for that DB cluster.
        /// You must invoke the <c>CreateDBInstance</c> operation to create DB instances for the
        /// restored DB cluster, specifying the identifier of the restored DB cluster in <c>DBClusterIdentifier</c>.
        /// You can create DB instances only after the <c>RestoreDBClusterFromS3</c> operation
        /// has completed and the DB cluster is available.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation only applies to Aurora DB clusters. The source DB engine must be MySQL.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromS3 service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterFromS3 service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing DB cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromS3">REST API Reference for RestoreDBClusterFromS3 Operation</seealso>
        public virtual RestoreDBClusterFromS3Response RestoreDBClusterFromS3(RestoreDBClusterFromS3Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// This operation only restores the DB cluster, not the DB instances for that DB cluster.
        /// You must invoke the <c>CreateDBInstance</c> operation to create DB instances for the
        /// restored DB cluster, specifying the identifier of the restored DB cluster in <c>DBClusterIdentifier</c>.
        /// You can create DB instances only after the <c>RestoreDBClusterFromS3</c> operation
        /// has completed and the DB cluster is available.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation only applies to Aurora DB clusters. The source DB engine must be MySQL.
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing DB cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromS3">REST API Reference for RestoreDBClusterFromS3 Operation</seealso>
        public virtual Task<RestoreDBClusterFromS3Response> RestoreDBClusterFromS3Async(RestoreDBClusterFromS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterFromS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterFromS3ResponseUnmarshaller.Instance;
            
            return InvokeAsync<RestoreDBClusterFromS3Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBClusterFromSnapshot


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
        /// This operation only restores the DB cluster, not the DB instances for that DB cluster.
        /// You must invoke the <c>CreateDBInstance</c> operation to create DB instances for the
        /// restored DB cluster, specifying the identifier of the restored DB cluster in <c>DBClusterIdentifier</c>.
        /// You can create DB instances only after the <c>RestoreDBClusterFromSnapshot</c> operation
        /// has completed and the DB cluster is available.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterFromSnapshot service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing DB cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster doesn't have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
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
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        public virtual RestoreDBClusterFromSnapshotResponse RestoreDBClusterFromSnapshot(RestoreDBClusterFromSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// This operation only restores the DB cluster, not the DB instances for that DB cluster.
        /// You must invoke the <c>CreateDBInstance</c> operation to create DB instances for the
        /// restored DB cluster, specifying the identifier of the restored DB cluster in <c>DBClusterIdentifier</c>.
        /// You can create DB instances only after the <c>RestoreDBClusterFromSnapshot</c> operation
        /// has completed and the DB cluster is available.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
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
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing DB cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster doesn't have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
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
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        public virtual Task<RestoreDBClusterFromSnapshotResponse> RestoreDBClusterFromSnapshotAsync(RestoreDBClusterFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<RestoreDBClusterFromSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBClusterToPointInTime


        /// <summary>
        /// Restores a DB cluster to an arbitrary point in time. Users can restore to any point
        /// in time before <c>LatestRestorableTime</c> for up to <c>BackupRetentionPeriod</c>
        /// days. The target DB cluster is created from the source DB cluster with the same configuration
        /// as the original DB cluster, except that the new DB cluster is created with the default
        /// DB security group. Unless the <c>RestoreType</c> is set to <c>copy-on-write</c>, the
        /// restore may occur in a different Availability Zone (AZ) from the original DB cluster.
        /// The AZ where RDS restores the DB cluster depends on the AZs in the specified subnet
        /// group.
        /// 
        ///  <note> 
        /// <para>
        /// For Aurora, this operation only restores the DB cluster, not the DB instances for
        /// that DB cluster. You must invoke the <c>CreateDBInstance</c> operation to create DB
        /// instances for the restored DB cluster, specifying the identifier of the restored DB
        /// cluster in <c>DBClusterIdentifier</c>. You can create DB instances only after the
        /// <c>RestoreDBClusterToPointInTime</c> operation has completed and the DB cluster is
        /// available.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime service method.</param>
        /// 
        /// <returns>The response from the RestoreDBClusterToPointInTime service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterAlreadyExistsException">
        /// The user already has a DB cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterAutomatedBackupNotFoundException">
        /// No automated backup for this DB cluster was found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing DB cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster doesn't have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
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
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual RestoreDBClusterToPointInTimeResponse RestoreDBClusterToPointInTime(RestoreDBClusterToPointInTimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterToPointInTimeResponse>(request, options);
        }


        /// <summary>
        /// Restores a DB cluster to an arbitrary point in time. Users can restore to any point
        /// in time before <c>LatestRestorableTime</c> for up to <c>BackupRetentionPeriod</c>
        /// days. The target DB cluster is created from the source DB cluster with the same configuration
        /// as the original DB cluster, except that the new DB cluster is created with the default
        /// DB security group. Unless the <c>RestoreType</c> is set to <c>copy-on-write</c>, the
        /// restore may occur in a different Availability Zone (AZ) from the original DB cluster.
        /// The AZ where RDS restores the DB cluster depends on the AZs in the specified subnet
        /// group.
        /// 
        ///  <note> 
        /// <para>
        /// For Aurora, this operation only restores the DB cluster, not the DB instances for
        /// that DB cluster. You must invoke the <c>CreateDBInstance</c> operation to create DB
        /// instances for the restored DB cluster, specifying the identifier of the restored DB
        /// cluster in <c>DBClusterIdentifier</c>. You can create DB instances only after the
        /// <c>RestoreDBClusterToPointInTime</c> operation has completed and the DB cluster is
        /// available.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
        /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
        /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
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
        /// <exception cref="Amazon.RDS.Model.DBClusterAutomatedBackupNotFoundException">
        /// No automated backup for this DB cluster was found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterParameterGroupNotFoundException">
        /// <c>DBClusterParameterGroupName</c> doesn't refer to an existing DB cluster parameter
        /// group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterQuotaExceededException">
        /// The user attempted to create a new DB cluster and the user has already reached the
        /// maximum allowed DB cluster quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBClusterCapacityException">
        /// The DB cluster doesn't have enough capacity for the current operation.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InsufficientDBInstanceCapacityException">
        /// The specified DB instance class isn't available in the specified Availability Zone.
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
        /// <exception cref="Amazon.RDS.Model.NetworkTypeNotSupportedException">
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageQuotaExceededException">
        /// The request would result in the user exceeding the allowed amount of storage available
        /// across all DB instances.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual Task<RestoreDBClusterToPointInTimeResponse> RestoreDBClusterToPointInTimeAsync(RestoreDBClusterToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;
            
            return InvokeAsync<RestoreDBClusterToPointInTimeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBInstanceFromDBSnapshot


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
        /// then rename your original DB instance before you call the <c>RestoreDBInstanceFromDBSnapshot</c>
        /// operation. RDS doesn't allow two DB instances with the same name. After you have renamed
        /// your original DB instance with a different identifier, then you can pass the original
        /// name of the DB instance as the <c>DBInstanceIdentifier</c> in the call to the <c>RestoreDBInstanceFromDBSnapshot</c>
        /// operation. The result is that you replace the original DB instance with the DB instance
        /// created from the snapshot.
        /// </para>
        ///  
        /// <para>
        /// If you are restoring from a shared manual DB snapshot, the <c>DBSnapshotIdentifier</c>
        /// must be the ARN of the shared DB snapshot.
        /// </para>
        ///  
        /// <para>
        /// To restore from a DB snapshot with an unsupported engine version, you must first upgrade
        /// the engine version of the snapshot. For more information about upgrading a RDS for
        /// MySQL DB snapshot engine version, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/mysql-upgrade-snapshot.html">Upgrading
        /// a MySQL DB snapshot engine version</a>. For more information about upgrading a RDS
        /// for PostgreSQL DB snapshot engine version, <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBSnapshot.PostgreSQL.html">Upgrading
        /// a PostgreSQL DB snapshot engine version</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This command doesn't apply to Aurora MySQL and Aurora PostgreSQL. For Aurora, use
        /// <c>RestoreDBClusterFromSnapshot</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot service method.</param>
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
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
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
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseQuotaExceededException">
        /// You attempted to create more tenant databases than are permitted in your Amazon Web
        /// Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromDBSnapshot">REST API Reference for RestoreDBInstanceFromDBSnapshot Operation</seealso>
        public virtual RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// then rename your original DB instance before you call the <c>RestoreDBInstanceFromDBSnapshot</c>
        /// operation. RDS doesn't allow two DB instances with the same name. After you have renamed
        /// your original DB instance with a different identifier, then you can pass the original
        /// name of the DB instance as the <c>DBInstanceIdentifier</c> in the call to the <c>RestoreDBInstanceFromDBSnapshot</c>
        /// operation. The result is that you replace the original DB instance with the DB instance
        /// created from the snapshot.
        /// </para>
        ///  
        /// <para>
        /// If you are restoring from a shared manual DB snapshot, the <c>DBSnapshotIdentifier</c>
        /// must be the ARN of the shared DB snapshot.
        /// </para>
        ///  
        /// <para>
        /// To restore from a DB snapshot with an unsupported engine version, you must first upgrade
        /// the engine version of the snapshot. For more information about upgrading a RDS for
        /// MySQL DB snapshot engine version, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/mysql-upgrade-snapshot.html">Upgrading
        /// a MySQL DB snapshot engine version</a>. For more information about upgrading a RDS
        /// for PostgreSQL DB snapshot engine version, <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBSnapshot.PostgreSQL.html">Upgrading
        /// a PostgreSQL DB snapshot engine version</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This command doesn't apply to Aurora MySQL and Aurora PostgreSQL. For Aurora, use
        /// <c>RestoreDBClusterFromSnapshot</c>.
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
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
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
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseQuotaExceededException">
        /// You attempted to create more tenant databases than are permitted in your Amazon Web
        /// Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromDBSnapshot">REST API Reference for RestoreDBInstanceFromDBSnapshot Operation</seealso>
        public virtual Task<RestoreDBInstanceFromDBSnapshotResponse> RestoreDBInstanceFromDBSnapshotAsync(RestoreDBInstanceFromDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceFromDBSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<RestoreDBInstanceFromDBSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBInstanceFromS3


        /// <summary>
        /// Amazon Relational Database Service (Amazon RDS) supports importing MySQL databases
        /// by using backup files. You can create a backup of your on-premises database, store
        /// it on Amazon Simple Storage Service (Amazon S3), and then restore the backup file
        /// onto a new Amazon RDS DB instance running MySQL. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/MySQL.Procedural.Importing.html">Restoring
        /// a backup into an Amazon RDS for MySQL DB instance</a> in the <i>Amazon RDS User Guide.</i>
        /// 
        /// 
        ///  
        /// <para>
        /// This operation doesn't apply to RDS Custom.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromS3 service method.</param>
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
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
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
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
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
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromS3">REST API Reference for RestoreDBInstanceFromS3 Operation</seealso>
        public virtual RestoreDBInstanceFromS3Response RestoreDBInstanceFromS3(RestoreDBInstanceFromS3Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceFromS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceFromS3Response>(request, options);
        }


        /// <summary>
        /// Amazon Relational Database Service (Amazon RDS) supports importing MySQL databases
        /// by using backup files. You can create a backup of your on-premises database, store
        /// it on Amazon Simple Storage Service (Amazon S3), and then restore the backup file
        /// onto a new Amazon RDS DB instance running MySQL. For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/MySQL.Procedural.Importing.html">Restoring
        /// a backup into an Amazon RDS for MySQL DB instance</a> in the <i>Amazon RDS User Guide.</i>
        /// 
        /// 
        ///  
        /// <para>
        /// This operation doesn't apply to RDS Custom.
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
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
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
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
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
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromS3">REST API Reference for RestoreDBInstanceFromS3 Operation</seealso>
        public virtual Task<RestoreDBInstanceFromS3Response> RestoreDBInstanceFromS3Async(RestoreDBInstanceFromS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceFromS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance;
            
            return InvokeAsync<RestoreDBInstanceFromS3Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBInstanceToPointInTime


        /// <summary>
        /// Restores a DB instance to an arbitrary point in time. You can restore to any point
        /// in time before the time identified by the <c>LatestRestorableTime</c> property. You
        /// can restore to a point up to the number of days specified by the <c>BackupRetentionPeriod</c>
        /// property.
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
        /// This operation doesn't apply to Aurora MySQL and Aurora PostgreSQL. For Aurora, use
        /// <c>RestoreDBClusterToPointInTime</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime service method.</param>
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
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupNotFoundException">
        /// No automated backup for this DB instance was found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.PointInTimeRestoreNotEnabledException">
        /// <c>SourceDBInstanceIdentifier</c> refers to a DB instance with <c>BackupRetentionPeriod</c>
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
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseQuotaExceededException">
        /// You attempted to create more tenant databases than are permitted in your Amazon Web
        /// Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceToPointInTime">REST API Reference for RestoreDBInstanceToPointInTime Operation</seealso>
        public virtual RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceToPointInTimeResponse>(request, options);
        }


        /// <summary>
        /// Restores a DB instance to an arbitrary point in time. You can restore to any point
        /// in time before the time identified by the <c>LatestRestorableTime</c> property. You
        /// can restore to a point up to the number of days specified by the <c>BackupRetentionPeriod</c>
        /// property.
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
        /// This operation doesn't apply to Aurora MySQL and Aurora PostgreSQL. For Aurora, use
        /// <c>RestoreDBClusterToPointInTime</c>.
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
        /// <exception cref="Amazon.RDS.Model.CertificateNotFoundException">
        /// <c>CertificateIdentifier</c> doesn't refer to an existing certificate.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAlreadyExistsException">
        /// The user already has a DB instance with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupNotFoundException">
        /// No automated backup for this DB instance was found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBParameterGroupNotFoundException">
        /// <c>DBParameterGroupName</c> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DomainNotFoundException">
        /// <c>Domain</c> doesn't refer to an existing Active Directory domain.
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
        /// The network type is invalid for the DB instance. Valid nework type values are <c>IPV4</c>
        /// and <c>DUAL</c>.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.OptionGroupNotFoundException">
        /// The specified option group could not be found.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.PointInTimeRestoreNotEnabledException">
        /// <c>SourceDBInstanceIdentifier</c> refers to a DB instance with <c>BackupRetentionPeriod</c>
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
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.TenantDatabaseQuotaExceededException">
        /// You attempted to create more tenant databases than are permitted in your Amazon Web
        /// Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceToPointInTime">REST API Reference for RestoreDBInstanceToPointInTime Operation</seealso>
        public virtual Task<RestoreDBInstanceToPointInTimeResponse> RestoreDBInstanceToPointInTimeAsync(RestoreDBInstanceToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreDBInstanceToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance;
            
            return InvokeAsync<RestoreDBInstanceToPointInTimeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeDBSecurityGroupIngress


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
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RevokeDBSecurityGroupIngress">REST API Reference for RevokeDBSecurityGroupIngress Operation</seealso>
        public virtual RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBSecurityGroupName</c> doesn't refer to an existing DB security group.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBSecurityGroupStateException">
        /// The state of the DB security group doesn't allow deletion.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RevokeDBSecurityGroupIngress">REST API Reference for RevokeDBSecurityGroupIngress Operation</seealso>
        public virtual Task<RevokeDBSecurityGroupIngressResponse> RevokeDBSecurityGroupIngressAsync(RevokeDBSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeDBSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance;
            
            return InvokeAsync<RevokeDBSecurityGroupIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartActivityStream


        /// <summary>
        /// Starts a database activity stream to monitor activity on the database. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/DBActivityStreams.html">
        /// Monitoring Amazon Aurora with Database Activity Streams</a> in the <i>Amazon Aurora
        /// User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/DBActivityStreams.html">
        /// Monitoring Amazon RDS with Database Activity Streams</a> in the <i>Amazon RDS User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartActivityStream service method.</param>
        /// 
        /// <returns>The response from the StartActivityStream service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
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
        public virtual StartActivityStreamResponse StartActivityStream(StartActivityStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartActivityStreamResponseUnmarshaller.Instance;

            return Invoke<StartActivityStreamResponse>(request, options);
        }


        /// <summary>
        /// Starts a database activity stream to monitor activity on the database. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/DBActivityStreams.html">
        /// Monitoring Amazon Aurora with Database Activity Streams</a> in the <i>Amazon Aurora
        /// User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/DBActivityStreams.html">
        /// Monitoring Amazon RDS with Database Activity Streams</a> in the <i>Amazon RDS User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartActivityStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartActivityStream service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartActivityStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartActivityStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDBCluster


        /// <summary>
        /// Starts an Amazon Aurora DB cluster that was stopped using the Amazon Web Services
        /// console, the stop-db-cluster CLI command, or the <c>StopDBCluster</c> operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-cluster-stop-start.html">
        /// Stopping and Starting an Aurora Cluster</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDBCluster service method.</param>
        /// 
        /// <returns>The response from the StartDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBShardGroupStateException">
        /// The DB shard group must be in the available state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBCluster">REST API Reference for StartDBCluster Operation</seealso>
        public virtual StartDBClusterResponse StartDBCluster(StartDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBClusterResponseUnmarshaller.Instance;

            return Invoke<StartDBClusterResponse>(request, options);
        }


        /// <summary>
        /// Starts an Amazon Aurora DB cluster that was stopped using the Amazon Web Services
        /// console, the stop-db-cluster CLI command, or the <c>StopDBCluster</c> operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-cluster-stop-start.html">
        /// Stopping and Starting an Aurora Cluster</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation only applies to Aurora DB clusters.
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBShardGroupStateException">
        /// The DB shard group must be in the available state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBCluster">REST API Reference for StartDBCluster Operation</seealso>
        public virtual Task<StartDBClusterResponse> StartDBClusterAsync(StartDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDBInstance


        /// <summary>
        /// Starts an Amazon RDS DB instance that was stopped using the Amazon Web Services console,
        /// the stop-db-instance CLI command, or the <c>StopDBInstance</c> operation.
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
        /// Aurora DB clusters, use <c>StartDBCluster</c> instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDBInstance service method.</param>
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
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
        public virtual StartDBInstanceResponse StartDBInstance(StartDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBInstanceResponseUnmarshaller.Instance;

            return Invoke<StartDBInstanceResponse>(request, options);
        }


        /// <summary>
        /// Starts an Amazon RDS DB instance that was stopped using the Amazon Web Services console,
        /// the stop-db-instance CLI command, or the <c>StopDBInstance</c> operation.
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
        /// Aurora DB clusters, use <c>StartDBCluster</c> instead.
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupDoesNotCoverEnoughAZsException">
        /// Subnets in the DB subnet group should cover at least two Availability Zones unless
        /// there is only one Availability Zone.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSubnetGroupNotFoundException">
        /// <c>DBSubnetGroupName</c> doesn't refer to an existing DB subnet group.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDBInstanceAutomatedBackupsReplication


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
        /// 
        /// <returns>The response from the StartDBInstanceAutomatedBackupsReplication service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceAutomatedBackupQuotaExceededException">
        /// The quota for retained automated backups was exceeded. This prevents you from retaining
        /// any additional automated backups. The retained automated backups quota is the same
        /// as your DB instance quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceAutomatedBackupStateException">
        /// The automated backup is in an invalid state. For example, this automated backup is
        /// associated with an active instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBInstanceAutomatedBackupsReplication">REST API Reference for StartDBInstanceAutomatedBackupsReplication Operation</seealso>
        public virtual StartDBInstanceAutomatedBackupsReplicationResponse StartDBInstanceAutomatedBackupsReplication(StartDBInstanceAutomatedBackupsReplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// as your DB instance quota.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceAutomatedBackupStateException">
        /// The automated backup is in an invalid state. For example, this automated backup is
        /// associated with an active instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.KMSKeyNotAccessibleException">
        /// An error occurred accessing an Amazon Web Services KMS key.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.StorageTypeNotSupportedException">
        /// The specified <c>StorageType</c> can't be associated with the DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBInstanceAutomatedBackupsReplication">REST API Reference for StartDBInstanceAutomatedBackupsReplication Operation</seealso>
        public virtual Task<StartDBInstanceAutomatedBackupsReplicationResponse> StartDBInstanceAutomatedBackupsReplicationAsync(StartDBInstanceAutomatedBackupsReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDBInstanceAutomatedBackupsReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartDBInstanceAutomatedBackupsReplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartExportTask


        /// <summary>
        /// Starts an export of DB snapshot or DB cluster data to Amazon S3. The provided IAM
        /// role must have access to the S3 bucket.
        /// 
        ///  
        /// <para>
        /// You can't export snapshot data from RDS Custom DB instances. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.RDS_Fea_Regions_DB-eng.Feature.ExportSnapshotToS3.html">
        /// Supported Regions and DB engines for exporting snapshots to S3 in Amazon RDS</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information on exporting DB snapshot data, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ExportSnapshot.html">Exporting
        /// DB snapshot data to Amazon S3</a> in the <i>Amazon RDS User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-export-snapshot.html">Exporting
        /// DB cluster snapshot data to Amazon S3</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on exporting DB cluster data, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/export-cluster-data.html">Exporting
        /// DB cluster data to Amazon S3</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask service method.</param>
        /// 
        /// <returns>The response from the StartExportTask service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
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
        public virtual StartExportTaskResponse StartExportTask(StartExportTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportTaskResponseUnmarshaller.Instance;

            return Invoke<StartExportTaskResponse>(request, options);
        }


        /// <summary>
        /// Starts an export of DB snapshot or DB cluster data to Amazon S3. The provided IAM
        /// role must have access to the S3 bucket.
        /// 
        ///  
        /// <para>
        /// You can't export snapshot data from RDS Custom DB instances. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Concepts.RDS_Fea_Regions_DB-eng.Feature.ExportSnapshotToS3.html">
        /// Supported Regions and DB engines for exporting snapshots to S3 in Amazon RDS</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information on exporting DB snapshot data, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_ExportSnapshot.html">Exporting
        /// DB snapshot data to Amazon S3</a> in the <i>Amazon RDS User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-export-snapshot.html">Exporting
        /// DB cluster snapshot data to Amazon S3</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on exporting DB cluster data, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/export-cluster-data.html">Exporting
        /// DB cluster data to Amazon S3</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartExportTask service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBClusterSnapshotNotFoundException">
        /// <c>DBClusterSnapshotIdentifier</c> doesn't refer to an existing DB cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotNotFoundException">
        /// <c>DBSnapshotIdentifier</c> doesn't refer to an existing DB snapshot.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartExportTaskResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartExportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopActivityStream


        /// <summary>
        /// Stops a database activity stream that was started using the Amazon Web Services console,
        /// the <c>start-activity-stream</c> CLI command, or the <c>StartActivityStream</c> operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/DBActivityStreams.html">
        /// Monitoring Amazon Aurora with Database Activity Streams</a> in the <i>Amazon Aurora
        /// User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/DBActivityStreams.html">
        /// Monitoring Amazon RDS with Database Activity Streams</a> in the <i>Amazon RDS User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopActivityStream service method.</param>
        /// 
        /// <returns>The response from the StopActivityStream service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
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
        public virtual StopActivityStreamResponse StopActivityStream(StopActivityStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopActivityStreamResponseUnmarshaller.Instance;

            return Invoke<StopActivityStreamResponse>(request, options);
        }


        /// <summary>
        /// Stops a database activity stream that was started using the Amazon Web Services console,
        /// the <c>start-activity-stream</c> CLI command, or the <c>StartActivityStream</c> operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/DBActivityStreams.html">
        /// Monitoring Amazon Aurora with Database Activity Streams</a> in the <i>Amazon Aurora
        /// User Guide</i> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/DBActivityStreams.html">
        /// Monitoring Amazon RDS with Database Activity Streams</a> in the <i>Amazon RDS User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopActivityStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopActivityStream service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopActivityStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopActivityStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopActivityStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopDBCluster


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
        /// This operation only applies to Aurora DB clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDBCluster service method.</param>
        /// 
        /// <returns>The response from the StopDBCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBShardGroupStateException">
        /// The DB shard group must be in the available state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBCluster">REST API Reference for StopDBCluster Operation</seealso>
        public virtual StopDBClusterResponse StopDBCluster(StopDBClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// This operation only applies to Aurora DB clusters.
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
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBShardGroupStateException">
        /// The DB shard group must be in the available state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBCluster">REST API Reference for StopDBCluster Operation</seealso>
        public virtual Task<StopDBClusterResponse> StopDBClusterAsync(StopDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDBClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopDBClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopDBInstance


        /// <summary>
        /// Stops an Amazon RDS DB instance temporarily. When you stop a DB instance, Amazon RDS
        /// retains the DB instance's metadata, including its endpoint, DB parameter group, and
        /// option group membership. Amazon RDS also retains the transaction logs so you can do
        /// a point-in-time restore if necessary. The instance restarts automatically after 7
        /// days.
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
        /// Aurora clusters, use <c>StopDBCluster</c> instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDBInstance service method.</param>
        /// 
        /// <returns>The response from the StopDBInstance service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <c>DBSnapshotIdentifier</c> is already used by an existing snapshot.
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
        public virtual StopDBInstanceResponse StopDBInstance(StopDBInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBInstanceResponseUnmarshaller.Instance;

            return Invoke<StopDBInstanceResponse>(request, options);
        }


        /// <summary>
        /// Stops an Amazon RDS DB instance temporarily. When you stop a DB instance, Amazon RDS
        /// retains the DB instance's metadata, including its endpoint, DB parameter group, and
        /// option group membership. Amazon RDS also retains the transaction logs so you can do
        /// a point-in-time restore if necessary. The instance restarts automatically after 7
        /// days.
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
        /// Aurora clusters, use <c>StopDBCluster</c> instead.
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
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.DBSnapshotAlreadyExistsException">
        /// <c>DBSnapshotIdentifier</c> is already used by an existing snapshot.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDBInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopDBInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopDBInstanceAutomatedBackupsReplication


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
        /// 
        /// <returns>The response from the StopDBInstanceAutomatedBackupsReplication service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBInstanceAutomatedBackupsReplication">REST API Reference for StopDBInstanceAutomatedBackupsReplication Operation</seealso>
        public virtual StopDBInstanceAutomatedBackupsReplicationResponse StopDBInstanceAutomatedBackupsReplication(StopDBInstanceAutomatedBackupsReplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBInstanceAutomatedBackupsReplication">REST API Reference for StopDBInstanceAutomatedBackupsReplication Operation</seealso>
        public virtual Task<StopDBInstanceAutomatedBackupsReplicationResponse> StopDBInstanceAutomatedBackupsReplicationAsync(StopDBInstanceAutomatedBackupsReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDBInstanceAutomatedBackupsReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDBInstanceAutomatedBackupsReplicationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopDBInstanceAutomatedBackupsReplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SwitchoverBlueGreenDeployment


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
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">Using
        /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwitchoverBlueGreenDeployment service method.</param>
        /// 
        /// <returns>The response from the SwitchoverBlueGreenDeployment service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <c>BlueGreenDeploymentIdentifier</c> doesn't refer to an existing blue/green deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidBlueGreenDeploymentStateException">
        /// The blue/green deployment can't be switched over or deleted because there is an invalid
        /// configuration in the green environment.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/SwitchoverBlueGreenDeployment">REST API Reference for SwitchoverBlueGreenDeployment Operation</seealso>
        public virtual SwitchoverBlueGreenDeploymentResponse SwitchoverBlueGreenDeployment(SwitchoverBlueGreenDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">Using
        /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon Aurora
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwitchoverBlueGreenDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SwitchoverBlueGreenDeployment service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.BlueGreenDeploymentNotFoundException">
        /// <c>BlueGreenDeploymentIdentifier</c> doesn't refer to an existing blue/green deployment.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidBlueGreenDeploymentStateException">
        /// The blue/green deployment can't be switched over or deleted because there is an invalid
        /// configuration in the green environment.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/SwitchoverBlueGreenDeployment">REST API Reference for SwitchoverBlueGreenDeployment Operation</seealso>
        public virtual Task<SwitchoverBlueGreenDeploymentResponse> SwitchoverBlueGreenDeploymentAsync(SwitchoverBlueGreenDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SwitchoverBlueGreenDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverBlueGreenDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<SwitchoverBlueGreenDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SwitchoverGlobalCluster


        /// <summary>
        /// Switches over the specified secondary DB cluster to be the new primary DB cluster
        /// in the global database cluster. Switchover operations were previously called "managed
        /// planned failovers."
        /// 
        ///  
        /// <para>
        /// Aurora promotes the specified secondary cluster to assume full read/write capabilities
        /// and demotes the current primary cluster to a secondary (read-only) cluster, maintaining
        /// the orginal replication topology. All secondary clusters are synchronized with the
        /// primary at the beginning of the process so the new primary continues operations for
        /// the Aurora global database without losing any data. Your database is unavailable for
        /// a short time while the primary and selected secondary clusters are assuming their
        /// new roles. For more information about switching over an Aurora global database, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-global-database-disaster-recovery.html#aurora-global-database-disaster-recovery.managed-failover">Performing
        /// switchovers for Amazon Aurora global databases</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is intended for controlled environments, for operations such as "regional
        /// rotation" or to fall back to the original primary after a global database failover.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwitchoverGlobalCluster service method.</param>
        /// 
        /// <returns>The response from the SwitchoverGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/SwitchoverGlobalCluster">REST API Reference for SwitchoverGlobalCluster Operation</seealso>
        public virtual SwitchoverGlobalClusterResponse SwitchoverGlobalCluster(SwitchoverGlobalClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SwitchoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverGlobalClusterResponseUnmarshaller.Instance;

            return Invoke<SwitchoverGlobalClusterResponse>(request, options);
        }


        /// <summary>
        /// Switches over the specified secondary DB cluster to be the new primary DB cluster
        /// in the global database cluster. Switchover operations were previously called "managed
        /// planned failovers."
        /// 
        ///  
        /// <para>
        /// Aurora promotes the specified secondary cluster to assume full read/write capabilities
        /// and demotes the current primary cluster to a secondary (read-only) cluster, maintaining
        /// the orginal replication topology. All secondary clusters are synchronized with the
        /// primary at the beginning of the process so the new primary continues operations for
        /// the Aurora global database without losing any data. Your database is unavailable for
        /// a short time while the primary and selected secondary clusters are assuming their
        /// new roles. For more information about switching over an Aurora global database, see
        /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-global-database-disaster-recovery.html#aurora-global-database-disaster-recovery.managed-failover">Performing
        /// switchovers for Amazon Aurora global databases</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is intended for controlled environments, for operations such as "regional
        /// rotation" or to fall back to the original primary after a global database failover.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwitchoverGlobalCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SwitchoverGlobalCluster service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBClusterNotFoundException">
        /// <c>DBClusterIdentifier</c> doesn't refer to an existing DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.GlobalClusterNotFoundException">
        /// The <c>GlobalClusterIdentifier</c> doesn't refer to an existing global database cluster.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBClusterStateException">
        /// The requested operation can't be performed while the cluster is in this state.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidGlobalClusterStateException">
        /// The global cluster is in an invalid state and can't perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/SwitchoverGlobalCluster">REST API Reference for SwitchoverGlobalCluster Operation</seealso>
        public virtual Task<SwitchoverGlobalClusterResponse> SwitchoverGlobalClusterAsync(SwitchoverGlobalClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SwitchoverGlobalClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverGlobalClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<SwitchoverGlobalClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SwitchoverReadReplica


        /// <summary>
        /// Switches over an Oracle standby database in an Oracle Data Guard environment, making
        /// it the new primary database. Issue this command in the Region that hosts the current
        /// standby database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SwitchoverReadReplica service method.</param>
        /// 
        /// <returns>The response from the SwitchoverReadReplica service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/SwitchoverReadReplica">REST API Reference for SwitchoverReadReplica Operation</seealso>
        public virtual SwitchoverReadReplicaResponse SwitchoverReadReplica(SwitchoverReadReplicaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <c>DBInstanceIdentifier</c> doesn't refer to an existing DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDS.Model.InvalidDBInstanceStateException">
        /// The DB instance isn't in a valid state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/SwitchoverReadReplica">REST API Reference for SwitchoverReadReplica Operation</seealso>
        public virtual Task<SwitchoverReadReplicaResponse> SwitchoverReadReplicaAsync(SwitchoverReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SwitchoverReadReplicaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwitchoverReadReplicaResponseUnmarshaller.Instance;
            
            return InvokeAsync<SwitchoverReadReplicaResponse>(request, options, cancellationToken);
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