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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
    ///  
    /// </para>
    ///  
    /// <para>
    /// Amazon Relational Database Service (Amazon RDS) is a web service that makes it easier
    /// to set up, operate, and scale a relational database in the cloud. It provides cost-efficient,
    /// resizable capacity for an industry-standard relational database and manages common
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
    /// command line interface you can use to manage Amazon RDS. Note that Amazon RDS is asynchronous,
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
    /// For the alphabetical list of API actions, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Operations.html">API
    /// Actions</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For the alphabetical list of data types, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/APIReference/API_Types.html">Data
    /// Types</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a list of common query parameters, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/APIReference/CommonParameters.html">Common
    /// Parameters</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For descriptions of the error codes, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/APIReference/CommonErrors.html">Common
    /// Errors</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Amazon RDS User Guide</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For a summary of the Amazon RDS interfaces, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Welcome.html#Welcome.Interfaces">Available
    /// RDS Interfaces</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For more information about how to use the Query API, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/Using_the_Query_API.html">Using
    /// the Query API</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonRDSClient : AmazonServiceClient, IAmazonRDS
    {
        
        #region Constructors

#if CORECLR
    
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

#endif

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
            var marshaller = AddRoleToDBClusterRequestMarshaller.Instance;
            var unmarshaller = AddRoleToDBClusterResponseUnmarshaller.Instance;

            return Invoke<AddRoleToDBClusterRequest,AddRoleToDBClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddRoleToDBCluster">REST API Reference for AddRoleToDBCluster Operation</seealso>
        public virtual Task<AddRoleToDBClusterResponse> AddRoleToDBClusterAsync(AddRoleToDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddRoleToDBClusterRequestMarshaller.Instance;
            var unmarshaller = AddRoleToDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<AddRoleToDBClusterRequest,AddRoleToDBClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddSourceIdentifierToSubscription

        internal virtual AddSourceIdentifierToSubscriptionResponse AddSourceIdentifierToSubscription(AddSourceIdentifierToSubscriptionRequest request)
        {
            var marshaller = AddSourceIdentifierToSubscriptionRequestMarshaller.Instance;
            var unmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return Invoke<AddSourceIdentifierToSubscriptionRequest,AddSourceIdentifierToSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddSourceIdentifierToSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddSourceIdentifierToSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddSourceIdentifierToSubscription">REST API Reference for AddSourceIdentifierToSubscription Operation</seealso>
        public virtual Task<AddSourceIdentifierToSubscriptionResponse> AddSourceIdentifierToSubscriptionAsync(AddSourceIdentifierToSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddSourceIdentifierToSubscriptionRequestMarshaller.Instance;
            var unmarshaller = AddSourceIdentifierToSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<AddSourceIdentifierToSubscriptionRequest,AddSourceIdentifierToSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddTagsToResource

        internal virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ApplyPendingMaintenanceAction

        internal virtual ApplyPendingMaintenanceActionResponse ApplyPendingMaintenanceAction(ApplyPendingMaintenanceActionRequest request)
        {
            var marshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            var unmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return Invoke<ApplyPendingMaintenanceActionRequest,ApplyPendingMaintenanceActionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ApplyPendingMaintenanceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplyPendingMaintenanceAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ApplyPendingMaintenanceAction">REST API Reference for ApplyPendingMaintenanceAction Operation</seealso>
        public virtual Task<ApplyPendingMaintenanceActionResponse> ApplyPendingMaintenanceActionAsync(ApplyPendingMaintenanceActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ApplyPendingMaintenanceActionRequestMarshaller.Instance;
            var unmarshaller = ApplyPendingMaintenanceActionResponseUnmarshaller.Instance;

            return InvokeAsync<ApplyPendingMaintenanceActionRequest,ApplyPendingMaintenanceActionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeDBSecurityGroupIngress

        internal virtual AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest request)
        {
            var marshaller = AuthorizeDBSecurityGroupIngressRequestMarshaller.Instance;
            var unmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeDBSecurityGroupIngressRequest,AuthorizeDBSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeDBSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeDBSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/AuthorizeDBSecurityGroupIngress">REST API Reference for AuthorizeDBSecurityGroupIngress Operation</seealso>
        public virtual Task<AuthorizeDBSecurityGroupIngressResponse> AuthorizeDBSecurityGroupIngressAsync(AuthorizeDBSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AuthorizeDBSecurityGroupIngressRequestMarshaller.Instance;
            var unmarshaller = AuthorizeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeDBSecurityGroupIngressRequest,AuthorizeDBSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BacktrackDBCluster

        internal virtual BacktrackDBClusterResponse BacktrackDBCluster(BacktrackDBClusterRequest request)
        {
            var marshaller = BacktrackDBClusterRequestMarshaller.Instance;
            var unmarshaller = BacktrackDBClusterResponseUnmarshaller.Instance;

            return Invoke<BacktrackDBClusterRequest,BacktrackDBClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BacktrackDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BacktrackDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/BacktrackDBCluster">REST API Reference for BacktrackDBCluster Operation</seealso>
        public virtual Task<BacktrackDBClusterResponse> BacktrackDBClusterAsync(BacktrackDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BacktrackDBClusterRequestMarshaller.Instance;
            var unmarshaller = BacktrackDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<BacktrackDBClusterRequest,BacktrackDBClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyDBClusterParameterGroup

        internal virtual CopyDBClusterParameterGroupResponse CopyDBClusterParameterGroup(CopyDBClusterParameterGroupRequest request)
        {
            var marshaller = CopyDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CopyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterParameterGroupRequest,CopyDBClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBClusterParameterGroup">REST API Reference for CopyDBClusterParameterGroup Operation</seealso>
        public virtual Task<CopyDBClusterParameterGroupResponse> CopyDBClusterParameterGroupAsync(CopyDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CopyDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CopyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBClusterParameterGroupRequest,CopyDBClusterParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyDBClusterSnapshot

        internal virtual CopyDBClusterSnapshotResponse CopyDBClusterSnapshot(CopyDBClusterSnapshotRequest request)
        {
            var marshaller = CopyDBClusterSnapshotRequestMarshaller.Instance;
            var unmarshaller = CopyDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyDBClusterSnapshotRequest,CopyDBClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBClusterSnapshot">REST API Reference for CopyDBClusterSnapshot Operation</seealso>
        public virtual Task<CopyDBClusterSnapshotResponse> CopyDBClusterSnapshotAsync(CopyDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CopyDBClusterSnapshotRequestMarshaller.Instance;
            var unmarshaller = CopyDBClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBClusterSnapshotRequest,CopyDBClusterSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyDBParameterGroup

        internal virtual CopyDBParameterGroupResponse CopyDBParameterGroup(CopyDBParameterGroupRequest request)
        {
            var marshaller = CopyDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CopyDBParameterGroupRequest,CopyDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBParameterGroup">REST API Reference for CopyDBParameterGroup Operation</seealso>
        public virtual Task<CopyDBParameterGroupResponse> CopyDBParameterGroupAsync(CopyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CopyDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CopyDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBParameterGroupRequest,CopyDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyDBSnapshot

        internal virtual CopyDBSnapshotResponse CopyDBSnapshot(CopyDBSnapshotRequest request)
        {
            var marshaller = CopyDBSnapshotRequestMarshaller.Instance;
            var unmarshaller = CopyDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<CopyDBSnapshotRequest,CopyDBSnapshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyDBSnapshot">REST API Reference for CopyDBSnapshot Operation</seealso>
        public virtual Task<CopyDBSnapshotResponse> CopyDBSnapshotAsync(CopyDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CopyDBSnapshotRequestMarshaller.Instance;
            var unmarshaller = CopyDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopyDBSnapshotRequest,CopyDBSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyOptionGroup

        internal virtual CopyOptionGroupResponse CopyOptionGroup(CopyOptionGroupRequest request)
        {
            var marshaller = CopyOptionGroupRequestMarshaller.Instance;
            var unmarshaller = CopyOptionGroupResponseUnmarshaller.Instance;

            return Invoke<CopyOptionGroupRequest,CopyOptionGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CopyOptionGroup">REST API Reference for CopyOptionGroup Operation</seealso>
        public virtual Task<CopyOptionGroupResponse> CopyOptionGroupAsync(CopyOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CopyOptionGroupRequestMarshaller.Instance;
            var unmarshaller = CopyOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CopyOptionGroupRequest,CopyOptionGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBCluster

        internal virtual CreateDBClusterResponse CreateDBCluster(CreateDBClusterRequest request)
        {
            var marshaller = CreateDBClusterRequestMarshaller.Instance;
            var unmarshaller = CreateDBClusterResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterRequest,CreateDBClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBCluster">REST API Reference for CreateDBCluster Operation</seealso>
        public virtual Task<CreateDBClusterResponse> CreateDBClusterAsync(CreateDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDBClusterRequestMarshaller.Instance;
            var unmarshaller = CreateDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBClusterRequest,CreateDBClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBClusterParameterGroup

        internal virtual CreateDBClusterParameterGroupResponse CreateDBClusterParameterGroup(CreateDBClusterParameterGroupRequest request)
        {
            var marshaller = CreateDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterParameterGroupRequest,CreateDBClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterParameterGroup">REST API Reference for CreateDBClusterParameterGroup Operation</seealso>
        public virtual Task<CreateDBClusterParameterGroupResponse> CreateDBClusterParameterGroupAsync(CreateDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBClusterParameterGroupRequest,CreateDBClusterParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBClusterSnapshot

        internal virtual CreateDBClusterSnapshotResponse CreateDBClusterSnapshot(CreateDBClusterSnapshotRequest request)
        {
            var marshaller = CreateDBClusterSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDBClusterSnapshotRequest,CreateDBClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBClusterSnapshot">REST API Reference for CreateDBClusterSnapshot Operation</seealso>
        public virtual Task<CreateDBClusterSnapshotResponse> CreateDBClusterSnapshotAsync(CreateDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDBClusterSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateDBClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBClusterSnapshotRequest,CreateDBClusterSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBInstance

        internal virtual CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request)
        {
            var marshaller = CreateDBInstanceRequestMarshaller.Instance;
            var unmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceRequest,CreateDBInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstance">REST API Reference for CreateDBInstance Operation</seealso>
        public virtual Task<CreateDBInstanceResponse> CreateDBInstanceAsync(CreateDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDBInstanceRequestMarshaller.Instance;
            var unmarshaller = CreateDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBInstanceRequest,CreateDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBInstanceReadReplica

        internal virtual CreateDBInstanceReadReplicaResponse CreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest request)
        {
            var marshaller = CreateDBInstanceReadReplicaRequestMarshaller.Instance;
            var unmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance;

            return Invoke<CreateDBInstanceReadReplicaRequest,CreateDBInstanceReadReplicaResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBInstanceReadReplica operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBInstanceReadReplica operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBInstanceReadReplica">REST API Reference for CreateDBInstanceReadReplica Operation</seealso>
        public virtual Task<CreateDBInstanceReadReplicaResponse> CreateDBInstanceReadReplicaAsync(CreateDBInstanceReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDBInstanceReadReplicaRequestMarshaller.Instance;
            var unmarshaller = CreateDBInstanceReadReplicaResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBInstanceReadReplicaRequest,CreateDBInstanceReadReplicaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBParameterGroup

        internal virtual CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest request)
        {
            var marshaller = CreateDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBParameterGroupRequest,CreateDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBParameterGroup">REST API Reference for CreateDBParameterGroup Operation</seealso>
        public virtual Task<CreateDBParameterGroupResponse> CreateDBParameterGroupAsync(CreateDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBParameterGroupRequest,CreateDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSecurityGroup

        internal virtual CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest request)
        {
            var marshaller = CreateDBSecurityGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBSecurityGroupRequest,CreateDBSecurityGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSecurityGroup">REST API Reference for CreateDBSecurityGroup Operation</seealso>
        public virtual Task<CreateDBSecurityGroupResponse> CreateDBSecurityGroupAsync(CreateDBSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDBSecurityGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBSecurityGroupRequest,CreateDBSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSnapshot

        internal virtual CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest request)
        {
            var marshaller = CreateDBSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateDBSnapshotRequest,CreateDBSnapshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSnapshot">REST API Reference for CreateDBSnapshot Operation</seealso>
        public virtual Task<CreateDBSnapshotResponse> CreateDBSnapshotAsync(CreateDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDBSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBSnapshotRequest,CreateDBSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDBSubnetGroup

        internal virtual CreateDBSubnetGroupResponse CreateDBSubnetGroup(CreateDBSubnetGroupRequest request)
        {
            var marshaller = CreateDBSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDBSubnetGroupRequest,CreateDBSubnetGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateDBSubnetGroup">REST API Reference for CreateDBSubnetGroup Operation</seealso>
        public virtual Task<CreateDBSubnetGroupResponse> CreateDBSubnetGroupAsync(CreateDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDBSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = CreateDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDBSubnetGroupRequest,CreateDBSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateEventSubscription

        internal virtual CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var marshaller = CreateEventSubscriptionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventSubscriptionRequest,CreateEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateOptionGroup

        internal virtual CreateOptionGroupResponse CreateOptionGroup(CreateOptionGroupRequest request)
        {
            var marshaller = CreateOptionGroupRequestMarshaller.Instance;
            var unmarshaller = CreateOptionGroupResponseUnmarshaller.Instance;

            return Invoke<CreateOptionGroupRequest,CreateOptionGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/CreateOptionGroup">REST API Reference for CreateOptionGroup Operation</seealso>
        public virtual Task<CreateOptionGroupResponse> CreateOptionGroupAsync(CreateOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateOptionGroupRequestMarshaller.Instance;
            var unmarshaller = CreateOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOptionGroupRequest,CreateOptionGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBCluster

        internal virtual DeleteDBClusterResponse DeleteDBCluster(DeleteDBClusterRequest request)
        {
            var marshaller = DeleteDBClusterRequestMarshaller.Instance;
            var unmarshaller = DeleteDBClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterRequest,DeleteDBClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBCluster">REST API Reference for DeleteDBCluster Operation</seealso>
        public virtual Task<DeleteDBClusterResponse> DeleteDBClusterAsync(DeleteDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDBClusterRequestMarshaller.Instance;
            var unmarshaller = DeleteDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBClusterRequest,DeleteDBClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBClusterParameterGroup

        internal virtual DeleteDBClusterParameterGroupResponse DeleteDBClusterParameterGroup(DeleteDBClusterParameterGroupRequest request)
        {
            var marshaller = DeleteDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterParameterGroupRequest,DeleteDBClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterParameterGroup">REST API Reference for DeleteDBClusterParameterGroup Operation</seealso>
        public virtual Task<DeleteDBClusterParameterGroupResponse> DeleteDBClusterParameterGroupAsync(DeleteDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBClusterParameterGroupRequest,DeleteDBClusterParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBClusterSnapshot

        internal virtual DeleteDBClusterSnapshotResponse DeleteDBClusterSnapshot(DeleteDBClusterSnapshotRequest request)
        {
            var marshaller = DeleteDBClusterSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteDBClusterSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDBClusterSnapshotRequest,DeleteDBClusterSnapshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBClusterSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBClusterSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBClusterSnapshot">REST API Reference for DeleteDBClusterSnapshot Operation</seealso>
        public virtual Task<DeleteDBClusterSnapshotResponse> DeleteDBClusterSnapshotAsync(DeleteDBClusterSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDBClusterSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteDBClusterSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBClusterSnapshotRequest,DeleteDBClusterSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBInstance

        internal virtual DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request)
        {
            var marshaller = DeleteDBInstanceRequestMarshaller.Instance;
            var unmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteDBInstanceRequest,DeleteDBInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBInstance">REST API Reference for DeleteDBInstance Operation</seealso>
        public virtual Task<DeleteDBInstanceResponse> DeleteDBInstanceAsync(DeleteDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDBInstanceRequestMarshaller.Instance;
            var unmarshaller = DeleteDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBInstanceRequest,DeleteDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBParameterGroup

        internal virtual DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest request)
        {
            var marshaller = DeleteDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBParameterGroupRequest,DeleteDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBParameterGroup">REST API Reference for DeleteDBParameterGroup Operation</seealso>
        public virtual Task<DeleteDBParameterGroupResponse> DeleteDBParameterGroupAsync(DeleteDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBParameterGroupRequest,DeleteDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSecurityGroup

        internal virtual DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest request)
        {
            var marshaller = DeleteDBSecurityGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSecurityGroupRequest,DeleteDBSecurityGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSecurityGroup">REST API Reference for DeleteDBSecurityGroup Operation</seealso>
        public virtual Task<DeleteDBSecurityGroupResponse> DeleteDBSecurityGroupAsync(DeleteDBSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDBSecurityGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBSecurityGroupRequest,DeleteDBSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSnapshot

        internal virtual DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest request)
        {
            var marshaller = DeleteDBSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSnapshotRequest,DeleteDBSnapshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSnapshot">REST API Reference for DeleteDBSnapshot Operation</seealso>
        public virtual Task<DeleteDBSnapshotResponse> DeleteDBSnapshotAsync(DeleteDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDBSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBSnapshotRequest,DeleteDBSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDBSubnetGroup

        internal virtual DeleteDBSubnetGroupResponse DeleteDBSubnetGroup(DeleteDBSubnetGroupRequest request)
        {
            var marshaller = DeleteDBSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDBSubnetGroupRequest,DeleteDBSubnetGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteDBSubnetGroup">REST API Reference for DeleteDBSubnetGroup Operation</seealso>
        public virtual Task<DeleteDBSubnetGroupResponse> DeleteDBSubnetGroupAsync(DeleteDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDBSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDBSubnetGroupRequest,DeleteDBSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventSubscription

        internal virtual DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var marshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventSubscriptionRequest,DeleteEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteOptionGroup

        internal virtual DeleteOptionGroupResponse DeleteOptionGroup(DeleteOptionGroupRequest request)
        {
            var marshaller = DeleteOptionGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteOptionGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteOptionGroupRequest,DeleteOptionGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DeleteOptionGroup">REST API Reference for DeleteOptionGroup Operation</seealso>
        public virtual Task<DeleteOptionGroupResponse> DeleteOptionGroupAsync(DeleteOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteOptionGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOptionGroupRequest,DeleteOptionGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes()
        {
            return DescribeAccountAttributes(new DescribeAccountAttributesRequest());
        }
        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var marshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, unmarshaller);
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
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCertificates

        internal virtual DescribeCertificatesResponse DescribeCertificates(DescribeCertificatesRequest request)
        {
            var marshaller = DescribeCertificatesRequestMarshaller.Instance;
            var unmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificatesRequest,DescribeCertificatesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual Task<DescribeCertificatesResponse> DescribeCertificatesAsync(DescribeCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeCertificatesRequestMarshaller.Instance;
            var unmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCertificatesRequest,DescribeCertificatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterBacktracks

        internal virtual DescribeDBClusterBacktracksResponse DescribeDBClusterBacktracks(DescribeDBClusterBacktracksRequest request)
        {
            var marshaller = DescribeDBClusterBacktracksRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterBacktracksResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterBacktracksRequest,DescribeDBClusterBacktracksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterBacktracks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterBacktracks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterBacktracks">REST API Reference for DescribeDBClusterBacktracks Operation</seealso>
        public virtual Task<DescribeDBClusterBacktracksResponse> DescribeDBClusterBacktracksAsync(DescribeDBClusterBacktracksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBClusterBacktracksRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterBacktracksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterBacktracksRequest,DescribeDBClusterBacktracksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterParameterGroups

        internal virtual DescribeDBClusterParameterGroupsResponse DescribeDBClusterParameterGroups(DescribeDBClusterParameterGroupsRequest request)
        {
            var marshaller = DescribeDBClusterParameterGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterParameterGroupsRequest,DescribeDBClusterParameterGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameterGroups">REST API Reference for DescribeDBClusterParameterGroups Operation</seealso>
        public virtual Task<DescribeDBClusterParameterGroupsResponse> DescribeDBClusterParameterGroupsAsync(DescribeDBClusterParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBClusterParameterGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterParameterGroupsRequest,DescribeDBClusterParameterGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterParameters

        internal virtual DescribeDBClusterParametersResponse DescribeDBClusterParameters(DescribeDBClusterParametersRequest request)
        {
            var marshaller = DescribeDBClusterParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterParametersRequest,DescribeDBClusterParametersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterParameters">REST API Reference for DescribeDBClusterParameters Operation</seealso>
        public virtual Task<DescribeDBClusterParametersResponse> DescribeDBClusterParametersAsync(DescribeDBClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBClusterParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterParametersRequest,DescribeDBClusterParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusters

        internal virtual DescribeDBClustersResponse DescribeDBClusters(DescribeDBClustersRequest request)
        {
            var marshaller = DescribeDBClustersRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClustersRequest,DescribeDBClustersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusters">REST API Reference for DescribeDBClusters Operation</seealso>
        public virtual Task<DescribeDBClustersResponse> DescribeDBClustersAsync(DescribeDBClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBClustersRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClustersRequest,DescribeDBClustersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterSnapshotAttributes

        internal virtual DescribeDBClusterSnapshotAttributesResponse DescribeDBClusterSnapshotAttributes(DescribeDBClusterSnapshotAttributesRequest request)
        {
            var marshaller = DescribeDBClusterSnapshotAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterSnapshotAttributesRequest,DescribeDBClusterSnapshotAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterSnapshotAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshotAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshotAttributes">REST API Reference for DescribeDBClusterSnapshotAttributes Operation</seealso>
        public virtual Task<DescribeDBClusterSnapshotAttributesResponse> DescribeDBClusterSnapshotAttributesAsync(DescribeDBClusterSnapshotAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBClusterSnapshotAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterSnapshotAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterSnapshotAttributesRequest,DescribeDBClusterSnapshotAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBClusterSnapshots

        internal virtual DescribeDBClusterSnapshotsResponse DescribeDBClusterSnapshots(DescribeDBClusterSnapshotsRequest request)
        {
            var marshaller = DescribeDBClusterSnapshotsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBClusterSnapshotsRequest,DescribeDBClusterSnapshotsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBClusterSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBClusterSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBClusterSnapshots">REST API Reference for DescribeDBClusterSnapshots Operation</seealso>
        public virtual Task<DescribeDBClusterSnapshotsResponse> DescribeDBClusterSnapshotsAsync(DescribeDBClusterSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBClusterSnapshotsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBClusterSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBClusterSnapshotsRequest,DescribeDBClusterSnapshotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBEngineVersions

        internal virtual DescribeDBEngineVersionsResponse DescribeDBEngineVersions()
        {
            return DescribeDBEngineVersions(new DescribeDBEngineVersionsRequest());
        }
        internal virtual DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest request)
        {
            var marshaller = DescribeDBEngineVersionsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBEngineVersionsRequest,DescribeDBEngineVersionsResponse>(request, marshaller, unmarshaller);
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
        /// Initiates the asynchronous execution of the DescribeDBEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBEngineVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBEngineVersions">REST API Reference for DescribeDBEngineVersions Operation</seealso>
        public virtual Task<DescribeDBEngineVersionsResponse> DescribeDBEngineVersionsAsync(DescribeDBEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBEngineVersionsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBEngineVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBEngineVersionsRequest,DescribeDBEngineVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBInstances

        internal virtual DescribeDBInstancesResponse DescribeDBInstances()
        {
            return DescribeDBInstances(new DescribeDBInstancesRequest());
        }
        internal virtual DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request)
        {
            var marshaller = DescribeDBInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBInstancesRequest,DescribeDBInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns information about provisioned RDS instances. This API supports pagination.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBInstances service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBInstanceNotFoundException">
        /// <i>DBInstanceIdentifier</i> doesn't refer to an existing DB instance.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBInstancesAsync(new DescribeDBInstancesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBInstances">REST API Reference for DescribeDBInstances Operation</seealso>
        public virtual Task<DescribeDBInstancesResponse> DescribeDBInstancesAsync(DescribeDBInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeDBInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBInstancesRequest,DescribeDBInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBLogFiles

        internal virtual DescribeDBLogFilesResponse DescribeDBLogFiles(DescribeDBLogFilesRequest request)
        {
            var marshaller = DescribeDBLogFilesRequestMarshaller.Instance;
            var unmarshaller = DescribeDBLogFilesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBLogFilesRequest,DescribeDBLogFilesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBLogFiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBLogFiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBLogFiles">REST API Reference for DescribeDBLogFiles Operation</seealso>
        public virtual Task<DescribeDBLogFilesResponse> DescribeDBLogFilesAsync(DescribeDBLogFilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBLogFilesRequestMarshaller.Instance;
            var unmarshaller = DescribeDBLogFilesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBLogFilesRequest,DescribeDBLogFilesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBParameterGroups

        internal virtual DescribeDBParameterGroupsResponse DescribeDBParameterGroups()
        {
            return DescribeDBParameterGroups(new DescribeDBParameterGroupsRequest());
        }
        internal virtual DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request)
        {
            var marshaller = DescribeDBParameterGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParameterGroupsRequest,DescribeDBParameterGroupsResponse>(request, marshaller, unmarshaller);
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
        /// <i>DBParameterGroupName</i> doesn't refer to an existing DB parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBParameterGroupsAsync(new DescribeDBParameterGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameterGroups">REST API Reference for DescribeDBParameterGroups Operation</seealso>
        public virtual Task<DescribeDBParameterGroupsResponse> DescribeDBParameterGroupsAsync(DescribeDBParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBParameterGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBParameterGroupsRequest,DescribeDBParameterGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBParameters

        internal virtual DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest request)
        {
            var marshaller = DescribeDBParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDBParametersRequest,DescribeDBParametersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBParameters">REST API Reference for DescribeDBParameters Operation</seealso>
        public virtual Task<DescribeDBParametersResponse> DescribeDBParametersAsync(DescribeDBParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeDBParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBParametersRequest,DescribeDBParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSecurityGroups

        internal virtual DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups()
        {
            return DescribeDBSecurityGroups(new DescribeDBSecurityGroupsRequest());
        }
        internal virtual DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request)
        {
            var marshaller = DescribeDBSecurityGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSecurityGroupsRequest,DescribeDBSecurityGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a list of <code>DBSecurityGroup</code> descriptions. If a <code>DBSecurityGroupName</code>
        /// is specified, the list will contain only the descriptions of the specified DB security
        /// group.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDBSecurityGroups service method, as returned by RDS.</returns>
        /// <exception cref="Amazon.RDS.Model.DBSecurityGroupNotFoundException">
        /// <i>DBSecurityGroupName</i> doesn't refer to an existing DB security group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSecurityGroups">REST API Reference for DescribeDBSecurityGroups Operation</seealso>
        public virtual Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBSecurityGroupsAsync(new DescribeDBSecurityGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSecurityGroups">REST API Reference for DescribeDBSecurityGroups Operation</seealso>
        public virtual Task<DescribeDBSecurityGroupsResponse> DescribeDBSecurityGroupsAsync(DescribeDBSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBSecurityGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSecurityGroupsRequest,DescribeDBSecurityGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSnapshotAttributes

        internal virtual DescribeDBSnapshotAttributesResponse DescribeDBSnapshotAttributes(DescribeDBSnapshotAttributesRequest request)
        {
            var marshaller = DescribeDBSnapshotAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeDBSnapshotAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSnapshotAttributesRequest,DescribeDBSnapshotAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSnapshotAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshotAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshotAttributes">REST API Reference for DescribeDBSnapshotAttributes Operation</seealso>
        public virtual Task<DescribeDBSnapshotAttributesResponse> DescribeDBSnapshotAttributesAsync(DescribeDBSnapshotAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBSnapshotAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeDBSnapshotAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSnapshotAttributesRequest,DescribeDBSnapshotAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSnapshots

        internal virtual DescribeDBSnapshotsResponse DescribeDBSnapshots()
        {
            return DescribeDBSnapshots(new DescribeDBSnapshotsRequest());
        }
        internal virtual DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest request)
        {
            var marshaller = DescribeDBSnapshotsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSnapshotsRequest,DescribeDBSnapshotsResponse>(request, marshaller, unmarshaller);
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
        /// <i>DBSnapshotIdentifier</i> doesn't refer to an existing DB snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshots">REST API Reference for DescribeDBSnapshots Operation</seealso>
        public virtual Task<DescribeDBSnapshotsResponse> DescribeDBSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBSnapshotsAsync(new DescribeDBSnapshotsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSnapshots">REST API Reference for DescribeDBSnapshots Operation</seealso>
        public virtual Task<DescribeDBSnapshotsResponse> DescribeDBSnapshotsAsync(DescribeDBSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBSnapshotsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSnapshotsRequest,DescribeDBSnapshotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDBSubnetGroups

        internal virtual DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups()
        {
            return DescribeDBSubnetGroups(new DescribeDBSubnetGroupsRequest());
        }
        internal virtual DescribeDBSubnetGroupsResponse DescribeDBSubnetGroups(DescribeDBSubnetGroupsRequest request)
        {
            var marshaller = DescribeDBSubnetGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeDBSubnetGroupsRequest,DescribeDBSubnetGroupsResponse>(request, marshaller, unmarshaller);
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
        /// <i>DBSubnetGroupName</i> doesn't refer to an existing DB subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDBSubnetGroupsAsync(new DescribeDBSubnetGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDBSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDBSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeDBSubnetGroups">REST API Reference for DescribeDBSubnetGroups Operation</seealso>
        public virtual Task<DescribeDBSubnetGroupsResponse> DescribeDBSubnetGroupsAsync(DescribeDBSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDBSubnetGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeDBSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDBSubnetGroupsRequest,DescribeDBSubnetGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEngineDefaultClusterParameters

        internal virtual DescribeEngineDefaultClusterParametersResponse DescribeEngineDefaultClusterParameters(DescribeEngineDefaultClusterParametersRequest request)
        {
            var marshaller = DescribeEngineDefaultClusterParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultClusterParametersRequest,DescribeEngineDefaultClusterParametersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultClusterParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultClusterParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEngineDefaultClusterParameters">REST API Reference for DescribeEngineDefaultClusterParameters Operation</seealso>
        public virtual Task<DescribeEngineDefaultClusterParametersResponse> DescribeEngineDefaultClusterParametersAsync(DescribeEngineDefaultClusterParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEngineDefaultClusterParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeEngineDefaultClusterParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEngineDefaultClusterParametersRequest,DescribeEngineDefaultClusterParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEngineDefaultParameters

        internal virtual DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            var marshaller = DescribeEngineDefaultParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeEngineDefaultParametersRequest,DescribeEngineDefaultParametersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineDefaultParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineDefaultParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEngineDefaultParameters">REST API Reference for DescribeEngineDefaultParameters Operation</seealso>
        public virtual Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEngineDefaultParametersRequestMarshaller.Instance;
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEngineDefaultParametersRequest,DescribeEngineDefaultParametersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventCategories

        internal virtual DescribeEventCategoriesResponse DescribeEventCategories()
        {
            return DescribeEventCategories(new DescribeEventCategoriesRequest());
        }
        internal virtual DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var marshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesRequest,DescribeEventCategoriesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Displays a list of categories for all event source types, or, if specified, for a
        /// specified source type. You can see a list of the event categories and source types
        /// in the <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Events.html">
        /// Events</a> topic in the <i>Amazon RDS User Guide.</i>
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
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventCategoriesRequest,DescribeEventCategoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents

        internal virtual DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }
        internal virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var marshaller = DescribeEventsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns events related to DB instances, DB security groups, DB snapshots, and DB parameter
        /// groups for the past 14 days. Events specific to a particular DB instance, DB security
        /// group, database snapshot, or DB parameter group can be obtained by providing the name
        /// as a parameter. By default, the past hour of events are returned.
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
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEventsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        internal virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions()
        {
            return DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest());
        }
        internal virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var marshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsRequest,DescribeEventSubscriptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Lists all the subscription descriptions for a customer account. The description for
        /// a subscription includes SubscriptionName, SNSTopicARN, CustomerID, SourceType, SourceID,
        /// CreationTime, and Status.
        /// 
        ///  
        /// <para>
        /// If you specify a SubscriptionName, lists the description for that subscription.
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
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventSubscriptionsRequest,DescribeEventSubscriptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOptionGroupOptions

        internal virtual DescribeOptionGroupOptionsResponse DescribeOptionGroupOptions(DescribeOptionGroupOptionsRequest request)
        {
            var marshaller = DescribeOptionGroupOptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOptionGroupOptionsRequest,DescribeOptionGroupOptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOptionGroupOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroupOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroupOptions">REST API Reference for DescribeOptionGroupOptions Operation</seealso>
        public virtual Task<DescribeOptionGroupOptionsResponse> DescribeOptionGroupOptionsAsync(DescribeOptionGroupOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeOptionGroupOptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeOptionGroupOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOptionGroupOptionsRequest,DescribeOptionGroupOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOptionGroups

        internal virtual DescribeOptionGroupsResponse DescribeOptionGroups()
        {
            return DescribeOptionGroups(new DescribeOptionGroupsRequest());
        }
        internal virtual DescribeOptionGroupsResponse DescribeOptionGroups(DescribeOptionGroupsRequest request)
        {
            var marshaller = DescribeOptionGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeOptionGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeOptionGroupsRequest,DescribeOptionGroupsResponse>(request, marshaller, unmarshaller);
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
        /// Initiates the asynchronous execution of the DescribeOptionGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptionGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOptionGroups">REST API Reference for DescribeOptionGroups Operation</seealso>
        public virtual Task<DescribeOptionGroupsResponse> DescribeOptionGroupsAsync(DescribeOptionGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeOptionGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeOptionGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOptionGroupsRequest,DescribeOptionGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrderableDBInstanceOptions

        internal virtual DescribeOrderableDBInstanceOptionsResponse DescribeOrderableDBInstanceOptions(DescribeOrderableDBInstanceOptionsRequest request)
        {
            var marshaller = DescribeOrderableDBInstanceOptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableDBInstanceOptionsRequest,DescribeOrderableDBInstanceOptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableDBInstanceOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableDBInstanceOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeOrderableDBInstanceOptions">REST API Reference for DescribeOrderableDBInstanceOptions Operation</seealso>
        public virtual Task<DescribeOrderableDBInstanceOptionsResponse> DescribeOrderableDBInstanceOptionsAsync(DescribeOrderableDBInstanceOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeOrderableDBInstanceOptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeOrderableDBInstanceOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrderableDBInstanceOptionsRequest,DescribeOrderableDBInstanceOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePendingMaintenanceActions

        internal virtual DescribePendingMaintenanceActionsResponse DescribePendingMaintenanceActions(DescribePendingMaintenanceActionsRequest request)
        {
            var marshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            var unmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return Invoke<DescribePendingMaintenanceActionsRequest,DescribePendingMaintenanceActionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePendingMaintenanceActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingMaintenanceActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribePendingMaintenanceActions">REST API Reference for DescribePendingMaintenanceActions Operation</seealso>
        public virtual Task<DescribePendingMaintenanceActionsResponse> DescribePendingMaintenanceActionsAsync(DescribePendingMaintenanceActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribePendingMaintenanceActionsRequestMarshaller.Instance;
            var unmarshaller = DescribePendingMaintenanceActionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePendingMaintenanceActionsRequest,DescribePendingMaintenanceActionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedDBInstances

        internal virtual DescribeReservedDBInstancesResponse DescribeReservedDBInstances()
        {
            return DescribeReservedDBInstances(new DescribeReservedDBInstancesRequest());
        }
        internal virtual DescribeReservedDBInstancesResponse DescribeReservedDBInstances(DescribeReservedDBInstancesRequest request)
        {
            var marshaller = DescribeReservedDBInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedDBInstancesRequest,DescribeReservedDBInstancesResponse>(request, marshaller, unmarshaller);
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
        /// Initiates the asynchronous execution of the DescribeReservedDBInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstances">REST API Reference for DescribeReservedDBInstances Operation</seealso>
        public virtual Task<DescribeReservedDBInstancesResponse> DescribeReservedDBInstancesAsync(DescribeReservedDBInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReservedDBInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedDBInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedDBInstancesRequest,DescribeReservedDBInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedDBInstancesOfferings

        internal virtual DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings()
        {
            return DescribeReservedDBInstancesOfferings(new DescribeReservedDBInstancesOfferingsRequest());
        }
        internal virtual DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest request)
        {
            var marshaller = DescribeReservedDBInstancesOfferingsRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedDBInstancesOfferingsRequest,DescribeReservedDBInstancesOfferingsResponse>(request, marshaller, unmarshaller);
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
        /// Initiates the asynchronous execution of the DescribeReservedDBInstancesOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedDBInstancesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeReservedDBInstancesOfferings">REST API Reference for DescribeReservedDBInstancesOfferings Operation</seealso>
        public virtual Task<DescribeReservedDBInstancesOfferingsResponse> DescribeReservedDBInstancesOfferingsAsync(DescribeReservedDBInstancesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReservedDBInstancesOfferingsRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedDBInstancesOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedDBInstancesOfferingsRequest,DescribeReservedDBInstancesOfferingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSourceRegions

        internal virtual DescribeSourceRegionsResponse DescribeSourceRegions(DescribeSourceRegionsRequest request)
        {
            var marshaller = DescribeSourceRegionsRequestMarshaller.Instance;
            var unmarshaller = DescribeSourceRegionsResponseUnmarshaller.Instance;

            return Invoke<DescribeSourceRegionsRequest,DescribeSourceRegionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSourceRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceRegions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeSourceRegions">REST API Reference for DescribeSourceRegions Operation</seealso>
        public virtual Task<DescribeSourceRegionsResponse> DescribeSourceRegionsAsync(DescribeSourceRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSourceRegionsRequestMarshaller.Instance;
            var unmarshaller = DescribeSourceRegionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSourceRegionsRequest,DescribeSourceRegionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeValidDBInstanceModifications

        internal virtual DescribeValidDBInstanceModificationsResponse DescribeValidDBInstanceModifications(DescribeValidDBInstanceModificationsRequest request)
        {
            var marshaller = DescribeValidDBInstanceModificationsRequestMarshaller.Instance;
            var unmarshaller = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeValidDBInstanceModificationsRequest,DescribeValidDBInstanceModificationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeValidDBInstanceModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeValidDBInstanceModifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DescribeValidDBInstanceModifications">REST API Reference for DescribeValidDBInstanceModifications Operation</seealso>
        public virtual Task<DescribeValidDBInstanceModificationsResponse> DescribeValidDBInstanceModificationsAsync(DescribeValidDBInstanceModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeValidDBInstanceModificationsRequestMarshaller.Instance;
            var unmarshaller = DescribeValidDBInstanceModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeValidDBInstanceModificationsRequest,DescribeValidDBInstanceModificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DownloadDBLogFilePortion

        internal virtual DownloadDBLogFilePortionResponse DownloadDBLogFilePortion(DownloadDBLogFilePortionRequest request)
        {
            var marshaller = DownloadDBLogFilePortionRequestMarshaller.Instance;
            var unmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.Instance;

            return Invoke<DownloadDBLogFilePortionRequest,DownloadDBLogFilePortionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDBLogFilePortion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DownloadDBLogFilePortion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/DownloadDBLogFilePortion">REST API Reference for DownloadDBLogFilePortion Operation</seealso>
        public virtual Task<DownloadDBLogFilePortionResponse> DownloadDBLogFilePortionAsync(DownloadDBLogFilePortionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DownloadDBLogFilePortionRequestMarshaller.Instance;
            var unmarshaller = DownloadDBLogFilePortionResponseUnmarshaller.Instance;

            return InvokeAsync<DownloadDBLogFilePortionRequest,DownloadDBLogFilePortionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  FailoverDBCluster

        internal virtual FailoverDBClusterResponse FailoverDBCluster(FailoverDBClusterRequest request)
        {
            var marshaller = FailoverDBClusterRequestMarshaller.Instance;
            var unmarshaller = FailoverDBClusterResponseUnmarshaller.Instance;

            return Invoke<FailoverDBClusterRequest,FailoverDBClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the FailoverDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FailoverDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/FailoverDBCluster">REST API Reference for FailoverDBCluster Operation</seealso>
        public virtual Task<FailoverDBClusterResponse> FailoverDBClusterAsync(FailoverDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = FailoverDBClusterRequestMarshaller.Instance;
            var unmarshaller = FailoverDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<FailoverDBClusterRequest,FailoverDBClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBCluster

        internal virtual ModifyDBClusterResponse ModifyDBCluster(ModifyDBClusterRequest request)
        {
            var marshaller = ModifyDBClusterRequestMarshaller.Instance;
            var unmarshaller = ModifyDBClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterRequest,ModifyDBClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBCluster">REST API Reference for ModifyDBCluster Operation</seealso>
        public virtual Task<ModifyDBClusterResponse> ModifyDBClusterAsync(ModifyDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyDBClusterRequestMarshaller.Instance;
            var unmarshaller = ModifyDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBClusterRequest,ModifyDBClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBClusterParameterGroup

        internal virtual ModifyDBClusterParameterGroupResponse ModifyDBClusterParameterGroup(ModifyDBClusterParameterGroupRequest request)
        {
            var marshaller = ModifyDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterParameterGroupRequest,ModifyDBClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterParameterGroup">REST API Reference for ModifyDBClusterParameterGroup Operation</seealso>
        public virtual Task<ModifyDBClusterParameterGroupResponse> ModifyDBClusterParameterGroupAsync(ModifyDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBClusterParameterGroupRequest,ModifyDBClusterParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBClusterSnapshotAttribute

        internal virtual ModifyDBClusterSnapshotAttributeResponse ModifyDBClusterSnapshotAttribute(ModifyDBClusterSnapshotAttributeRequest request)
        {
            var marshaller = ModifyDBClusterSnapshotAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyDBClusterSnapshotAttributeRequest,ModifyDBClusterSnapshotAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBClusterSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBClusterSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBClusterSnapshotAttribute">REST API Reference for ModifyDBClusterSnapshotAttribute Operation</seealso>
        public virtual Task<ModifyDBClusterSnapshotAttributeResponse> ModifyDBClusterSnapshotAttributeAsync(ModifyDBClusterSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyDBClusterSnapshotAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyDBClusterSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBClusterSnapshotAttributeRequest,ModifyDBClusterSnapshotAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBInstance

        internal virtual ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request)
        {
            var marshaller = ModifyDBInstanceRequestMarshaller.Instance;
            var unmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return Invoke<ModifyDBInstanceRequest,ModifyDBInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBInstance">REST API Reference for ModifyDBInstance Operation</seealso>
        public virtual Task<ModifyDBInstanceResponse> ModifyDBInstanceAsync(ModifyDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyDBInstanceRequestMarshaller.Instance;
            var unmarshaller = ModifyDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBInstanceRequest,ModifyDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBParameterGroup

        internal virtual ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest request)
        {
            var marshaller = ModifyDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBParameterGroupRequest,ModifyDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBParameterGroup">REST API Reference for ModifyDBParameterGroup Operation</seealso>
        public virtual Task<ModifyDBParameterGroupResponse> ModifyDBParameterGroupAsync(ModifyDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBParameterGroupRequest,ModifyDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBSnapshot

        internal virtual ModifyDBSnapshotResponse ModifyDBSnapshot(ModifyDBSnapshotRequest request)
        {
            var marshaller = ModifyDBSnapshotRequestMarshaller.Instance;
            var unmarshaller = ModifyDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSnapshotRequest,ModifyDBSnapshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSnapshot">REST API Reference for ModifyDBSnapshot Operation</seealso>
        public virtual Task<ModifyDBSnapshotResponse> ModifyDBSnapshotAsync(ModifyDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyDBSnapshotRequestMarshaller.Instance;
            var unmarshaller = ModifyDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBSnapshotRequest,ModifyDBSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBSnapshotAttribute

        internal virtual ModifyDBSnapshotAttributeResponse ModifyDBSnapshotAttribute(ModifyDBSnapshotAttributeRequest request)
        {
            var marshaller = ModifyDBSnapshotAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyDBSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSnapshotAttributeRequest,ModifyDBSnapshotAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSnapshotAttribute">REST API Reference for ModifyDBSnapshotAttribute Operation</seealso>
        public virtual Task<ModifyDBSnapshotAttributeResponse> ModifyDBSnapshotAttributeAsync(ModifyDBSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyDBSnapshotAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyDBSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBSnapshotAttributeRequest,ModifyDBSnapshotAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyDBSubnetGroup

        internal virtual ModifyDBSubnetGroupResponse ModifyDBSubnetGroup(ModifyDBSubnetGroupRequest request)
        {
            var marshaller = ModifyDBSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyDBSubnetGroupRequest,ModifyDBSubnetGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyDBSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyDBSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyDBSubnetGroup">REST API Reference for ModifyDBSubnetGroup Operation</seealso>
        public virtual Task<ModifyDBSubnetGroupResponse> ModifyDBSubnetGroupAsync(ModifyDBSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyDBSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyDBSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyDBSubnetGroupRequest,ModifyDBSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyEventSubscription

        internal virtual ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var marshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyEventSubscriptionRequest,ModifyEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyOptionGroup

        internal virtual ModifyOptionGroupResponse ModifyOptionGroup(ModifyOptionGroupRequest request)
        {
            var marshaller = ModifyOptionGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyOptionGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyOptionGroupRequest,ModifyOptionGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyOptionGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyOptionGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ModifyOptionGroup">REST API Reference for ModifyOptionGroup Operation</seealso>
        public virtual Task<ModifyOptionGroupResponse> ModifyOptionGroupAsync(ModifyOptionGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyOptionGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyOptionGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyOptionGroupRequest,ModifyOptionGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PromoteReadReplica

        internal virtual PromoteReadReplicaResponse PromoteReadReplica(PromoteReadReplicaRequest request)
        {
            var marshaller = PromoteReadReplicaRequestMarshaller.Instance;
            var unmarshaller = PromoteReadReplicaResponseUnmarshaller.Instance;

            return Invoke<PromoteReadReplicaRequest,PromoteReadReplicaResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PromoteReadReplica operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplica operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplica">REST API Reference for PromoteReadReplica Operation</seealso>
        public virtual Task<PromoteReadReplicaResponse> PromoteReadReplicaAsync(PromoteReadReplicaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PromoteReadReplicaRequestMarshaller.Instance;
            var unmarshaller = PromoteReadReplicaResponseUnmarshaller.Instance;

            return InvokeAsync<PromoteReadReplicaRequest,PromoteReadReplicaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PromoteReadReplicaDBCluster

        internal virtual PromoteReadReplicaDBClusterResponse PromoteReadReplicaDBCluster(PromoteReadReplicaDBClusterRequest request)
        {
            var marshaller = PromoteReadReplicaDBClusterRequestMarshaller.Instance;
            var unmarshaller = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance;

            return Invoke<PromoteReadReplicaDBClusterRequest,PromoteReadReplicaDBClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PromoteReadReplicaDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteReadReplicaDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PromoteReadReplicaDBCluster">REST API Reference for PromoteReadReplicaDBCluster Operation</seealso>
        public virtual Task<PromoteReadReplicaDBClusterResponse> PromoteReadReplicaDBClusterAsync(PromoteReadReplicaDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PromoteReadReplicaDBClusterRequestMarshaller.Instance;
            var unmarshaller = PromoteReadReplicaDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<PromoteReadReplicaDBClusterRequest,PromoteReadReplicaDBClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedDBInstancesOffering

        internal virtual PurchaseReservedDBInstancesOfferingResponse PurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest request)
        {
            var marshaller = PurchaseReservedDBInstancesOfferingRequestMarshaller.Instance;
            var unmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedDBInstancesOfferingRequest,PurchaseReservedDBInstancesOfferingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedDBInstancesOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedDBInstancesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/PurchaseReservedDBInstancesOffering">REST API Reference for PurchaseReservedDBInstancesOffering Operation</seealso>
        public virtual Task<PurchaseReservedDBInstancesOfferingResponse> PurchaseReservedDBInstancesOfferingAsync(PurchaseReservedDBInstancesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PurchaseReservedDBInstancesOfferingRequestMarshaller.Instance;
            var unmarshaller = PurchaseReservedDBInstancesOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedDBInstancesOfferingRequest,PurchaseReservedDBInstancesOfferingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebootDBInstance

        internal virtual RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request)
        {
            var marshaller = RebootDBInstanceRequestMarshaller.Instance;
            var unmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootDBInstanceRequest,RebootDBInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RebootDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RebootDBInstance">REST API Reference for RebootDBInstance Operation</seealso>
        public virtual Task<RebootDBInstanceResponse> RebootDBInstanceAsync(RebootDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RebootDBInstanceRequestMarshaller.Instance;
            var unmarshaller = RebootDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RebootDBInstanceRequest,RebootDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveRoleFromDBCluster

        internal virtual RemoveRoleFromDBClusterResponse RemoveRoleFromDBCluster(RemoveRoleFromDBClusterRequest request)
        {
            var marshaller = RemoveRoleFromDBClusterRequestMarshaller.Instance;
            var unmarshaller = RemoveRoleFromDBClusterResponseUnmarshaller.Instance;

            return Invoke<RemoveRoleFromDBClusterRequest,RemoveRoleFromDBClusterResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromDBCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromDBCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveRoleFromDBCluster">REST API Reference for RemoveRoleFromDBCluster Operation</seealso>
        public virtual Task<RemoveRoleFromDBClusterResponse> RemoveRoleFromDBClusterAsync(RemoveRoleFromDBClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveRoleFromDBClusterRequestMarshaller.Instance;
            var unmarshaller = RemoveRoleFromDBClusterResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveRoleFromDBClusterRequest,RemoveRoleFromDBClusterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveSourceIdentifierFromSubscription

        internal virtual RemoveSourceIdentifierFromSubscriptionResponse RemoveSourceIdentifierFromSubscription(RemoveSourceIdentifierFromSubscriptionRequest request)
        {
            var marshaller = RemoveSourceIdentifierFromSubscriptionRequestMarshaller.Instance;
            var unmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return Invoke<RemoveSourceIdentifierFromSubscriptionRequest,RemoveSourceIdentifierFromSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveSourceIdentifierFromSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceIdentifierFromSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveSourceIdentifierFromSubscription">REST API Reference for RemoveSourceIdentifierFromSubscription Operation</seealso>
        public virtual Task<RemoveSourceIdentifierFromSubscriptionResponse> RemoveSourceIdentifierFromSubscriptionAsync(RemoveSourceIdentifierFromSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveSourceIdentifierFromSubscriptionRequestMarshaller.Instance;
            var unmarshaller = RemoveSourceIdentifierFromSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveSourceIdentifierFromSubscriptionRequest,RemoveSourceIdentifierFromSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        internal virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetDBClusterParameterGroup

        internal virtual ResetDBClusterParameterGroupResponse ResetDBClusterParameterGroup(ResetDBClusterParameterGroupRequest request)
        {
            var marshaller = ResetDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ResetDBClusterParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBClusterParameterGroupRequest,ResetDBClusterParameterGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBClusterParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBClusterParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBClusterParameterGroup">REST API Reference for ResetDBClusterParameterGroup Operation</seealso>
        public virtual Task<ResetDBClusterParameterGroupResponse> ResetDBClusterParameterGroupAsync(ResetDBClusterParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResetDBClusterParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ResetDBClusterParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetDBClusterParameterGroupRequest,ResetDBClusterParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetDBParameterGroup

        internal virtual ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest request)
        {
            var marshaller = ResetDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return Invoke<ResetDBParameterGroupRequest,ResetDBParameterGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetDBParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetDBParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/ResetDBParameterGroup">REST API Reference for ResetDBParameterGroup Operation</seealso>
        public virtual Task<ResetDBParameterGroupResponse> ResetDBParameterGroupAsync(ResetDBParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResetDBParameterGroupRequestMarshaller.Instance;
            var unmarshaller = ResetDBParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ResetDBParameterGroupRequest,ResetDBParameterGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBClusterFromS3

        internal virtual RestoreDBClusterFromS3Response RestoreDBClusterFromS3(RestoreDBClusterFromS3Request request)
        {
            var marshaller = RestoreDBClusterFromS3RequestMarshaller.Instance;
            var unmarshaller = RestoreDBClusterFromS3ResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterFromS3Request,RestoreDBClusterFromS3Response>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterFromS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromS3 operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromS3">REST API Reference for RestoreDBClusterFromS3 Operation</seealso>
        public virtual Task<RestoreDBClusterFromS3Response> RestoreDBClusterFromS3Async(RestoreDBClusterFromS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RestoreDBClusterFromS3RequestMarshaller.Instance;
            var unmarshaller = RestoreDBClusterFromS3ResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBClusterFromS3Request,RestoreDBClusterFromS3Response>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBClusterFromSnapshot

        internal virtual RestoreDBClusterFromSnapshotResponse RestoreDBClusterFromSnapshot(RestoreDBClusterFromSnapshotRequest request)
        {
            var marshaller = RestoreDBClusterFromSnapshotRequestMarshaller.Instance;
            var unmarshaller = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterFromSnapshotRequest,RestoreDBClusterFromSnapshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterFromSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterFromSnapshot">REST API Reference for RestoreDBClusterFromSnapshot Operation</seealso>
        public virtual Task<RestoreDBClusterFromSnapshotResponse> RestoreDBClusterFromSnapshotAsync(RestoreDBClusterFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RestoreDBClusterFromSnapshotRequestMarshaller.Instance;
            var unmarshaller = RestoreDBClusterFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBClusterFromSnapshotRequest,RestoreDBClusterFromSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBClusterToPointInTime

        internal virtual RestoreDBClusterToPointInTimeResponse RestoreDBClusterToPointInTime(RestoreDBClusterToPointInTimeRequest request)
        {
            var marshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
            var unmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<RestoreDBClusterToPointInTimeRequest,RestoreDBClusterToPointInTimeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBClusterToPointInTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBClusterToPointInTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBClusterToPointInTime">REST API Reference for RestoreDBClusterToPointInTime Operation</seealso>
        public virtual Task<RestoreDBClusterToPointInTimeResponse> RestoreDBClusterToPointInTimeAsync(RestoreDBClusterToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RestoreDBClusterToPointInTimeRequestMarshaller.Instance;
            var unmarshaller = RestoreDBClusterToPointInTimeResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBClusterToPointInTimeRequest,RestoreDBClusterToPointInTimeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBInstanceFromDBSnapshot

        internal virtual RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest request)
        {
            var marshaller = RestoreDBInstanceFromDBSnapshotRequestMarshaller.Instance;
            var unmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceFromDBSnapshotRequest,RestoreDBInstanceFromDBSnapshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceFromDBSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromDBSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromDBSnapshot">REST API Reference for RestoreDBInstanceFromDBSnapshot Operation</seealso>
        public virtual Task<RestoreDBInstanceFromDBSnapshotResponse> RestoreDBInstanceFromDBSnapshotAsync(RestoreDBInstanceFromDBSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RestoreDBInstanceFromDBSnapshotRequestMarshaller.Instance;
            var unmarshaller = RestoreDBInstanceFromDBSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBInstanceFromDBSnapshotRequest,RestoreDBInstanceFromDBSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBInstanceFromS3

        internal virtual RestoreDBInstanceFromS3Response RestoreDBInstanceFromS3(RestoreDBInstanceFromS3Request request)
        {
            var marshaller = RestoreDBInstanceFromS3RequestMarshaller.Instance;
            var unmarshaller = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceFromS3Request,RestoreDBInstanceFromS3Response>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceFromS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceFromS3 operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceFromS3">REST API Reference for RestoreDBInstanceFromS3 Operation</seealso>
        public virtual Task<RestoreDBInstanceFromS3Response> RestoreDBInstanceFromS3Async(RestoreDBInstanceFromS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RestoreDBInstanceFromS3RequestMarshaller.Instance;
            var unmarshaller = RestoreDBInstanceFromS3ResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBInstanceFromS3Request,RestoreDBInstanceFromS3Response>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreDBInstanceToPointInTime

        internal virtual RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest request)
        {
            var marshaller = RestoreDBInstanceToPointInTimeRequestMarshaller.Instance;
            var unmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<RestoreDBInstanceToPointInTimeRequest,RestoreDBInstanceToPointInTimeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreDBInstanceToPointInTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreDBInstanceToPointInTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RestoreDBInstanceToPointInTime">REST API Reference for RestoreDBInstanceToPointInTime Operation</seealso>
        public virtual Task<RestoreDBInstanceToPointInTimeResponse> RestoreDBInstanceToPointInTimeAsync(RestoreDBInstanceToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RestoreDBInstanceToPointInTimeRequestMarshaller.Instance;
            var unmarshaller = RestoreDBInstanceToPointInTimeResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreDBInstanceToPointInTimeRequest,RestoreDBInstanceToPointInTimeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeDBSecurityGroupIngress

        internal virtual RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest request)
        {
            var marshaller = RevokeDBSecurityGroupIngressRequestMarshaller.Instance;
            var unmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeDBSecurityGroupIngressRequest,RevokeDBSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeDBSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeDBSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/RevokeDBSecurityGroupIngress">REST API Reference for RevokeDBSecurityGroupIngress Operation</seealso>
        public virtual Task<RevokeDBSecurityGroupIngressResponse> RevokeDBSecurityGroupIngressAsync(RevokeDBSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RevokeDBSecurityGroupIngressRequestMarshaller.Instance;
            var unmarshaller = RevokeDBSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeDBSecurityGroupIngressRequest,RevokeDBSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartDBInstance

        internal virtual StartDBInstanceResponse StartDBInstance(StartDBInstanceRequest request)
        {
            var marshaller = StartDBInstanceRequestMarshaller.Instance;
            var unmarshaller = StartDBInstanceResponseUnmarshaller.Instance;

            return Invoke<StartDBInstanceRequest,StartDBInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StartDBInstance">REST API Reference for StartDBInstance Operation</seealso>
        public virtual Task<StartDBInstanceResponse> StartDBInstanceAsync(StartDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartDBInstanceRequestMarshaller.Instance;
            var unmarshaller = StartDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StartDBInstanceRequest,StartDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopDBInstance

        internal virtual StopDBInstanceResponse StopDBInstance(StopDBInstanceRequest request)
        {
            var marshaller = StopDBInstanceRequestMarshaller.Instance;
            var unmarshaller = StopDBInstanceResponseUnmarshaller.Instance;

            return Invoke<StopDBInstanceRequest,StopDBInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopDBInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDBInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-2014-10-31/StopDBInstance">REST API Reference for StopDBInstance Operation</seealso>
        public virtual Task<StopDBInstanceResponse> StopDBInstanceAsync(StopDBInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopDBInstanceRequestMarshaller.Instance;
            var unmarshaller = StopDBInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<StopDBInstanceRequest,StopDBInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}