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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.OpsWorksCM.Model;
using Amazon.OpsWorksCM.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.OpsWorksCM
{
    /// <summary>
    /// Implementation for accessing OpsWorksCM
    ///
    /// AWS OpsWorks for Chef Automate 
    /// <para>
    ///  A service that runs and manages configuration management servers. 
    /// </para>
    ///  
    /// <para>
    /// Glossary of terms
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Server</b>: A server is a configuration management server, and can be highly-available.
    /// The configuration manager runs on your instances by using various AWS services, such
    /// as Amazon Elastic Compute Cloud (EC2), and potentially Amazon Relational Database
    /// Service (RDS). A server is a generic abstraction over the configuration manager that
    /// you want to use, much like Amazon RDS. In AWS OpsWorks for Chef Automate, you do not
    /// start or stop servers. After you create servers, they continue to run until they are
    /// deleted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Engine</b>: The specific configuration manager that you want to use (such as <code>Chef</code>)
    /// is the engine.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Backup</b>: This is an application-level backup of the data that the configuration
    /// manager stores. A backup creates a .tar.gz file that is stored in an Amazon Simple
    /// Storage Service (S3) bucket in your account. AWS OpsWorks for Chef Automate creates
    /// the S3 bucket when you launch the first instance. A backup maintains a snapshot of
    /// all of a server's important attributes at the time of the backup.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Events</b>: Events are always related to a server. Events are written during server
    /// creation, when health checks run, when backups are created, etc. When you delete a
    /// server, the server's events are also deleted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AccountAttributes</b>: Every account has attributes that are assigned in the AWS
    /// OpsWorks for Chef Automate database. These attributes store information about configuration
    /// limits (servers, backups, etc.) and your customer account. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Throttling limits
    /// </para>
    ///  
    /// <para>
    /// All API operations allow for 5 requests per second with a burst of 10 requests per
    /// second.
    /// </para>
    /// </summary>
    public partial class AmazonOpsWorksCMClient : AmazonServiceClient, IAmazonOpsWorksCM
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with the credentials loaded from the application's
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
        public AmazonOpsWorksCMClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpsWorksCMConfig()) { }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with the credentials loaded from the application's
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
        public AmazonOpsWorksCMClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonOpsWorksCMConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOpsWorksCMClient Configuration Object</param>
        public AmazonOpsWorksCMClient(AmazonOpsWorksCMConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOpsWorksCMClient(AWSCredentials credentials)
            : this(credentials, new AmazonOpsWorksCMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpsWorksCMClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOpsWorksCMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Credentials and an
        /// AmazonOpsWorksCMClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOpsWorksCMClient Configuration Object</param>
        public AmazonOpsWorksCMClient(AWSCredentials credentials, AmazonOpsWorksCMConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOpsWorksCMClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOpsWorksCMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpsWorksCMClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOpsWorksCMConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOpsWorksCMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOpsWorksCMClient Configuration Object</param>
        public AmazonOpsWorksCMClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOpsWorksCMConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOpsWorksCMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOpsWorksCMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOpsWorksCMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOpsWorksCMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOpsWorksCMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOpsWorksCMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOpsWorksCMClient Configuration Object</param>
        public AmazonOpsWorksCMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOpsWorksCMConfig clientConfig)
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

        
        #region  AssociateNode

        internal AssociateNodeResponse AssociateNode(AssociateNodeRequest request)
        {
            var marshaller = new AssociateNodeRequestMarshaller();
            var unmarshaller = AssociateNodeResponseUnmarshaller.Instance;

            return Invoke<AssociateNodeRequest,AssociateNodeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssociateNodeResponse> AssociateNodeAsync(AssociateNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateNodeRequestMarshaller();
            var unmarshaller = AssociateNodeResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateNodeRequest,AssociateNodeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateBackup

        internal CreateBackupResponse CreateBackup(CreateBackupRequest request)
        {
            var marshaller = new CreateBackupRequestMarshaller();
            var unmarshaller = CreateBackupResponseUnmarshaller.Instance;

            return Invoke<CreateBackupRequest,CreateBackupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateBackupResponse> CreateBackupAsync(CreateBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateBackupRequestMarshaller();
            var unmarshaller = CreateBackupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBackupRequest,CreateBackupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateServer

        internal CreateServerResponse CreateServer(CreateServerRequest request)
        {
            var marshaller = new CreateServerRequestMarshaller();
            var unmarshaller = CreateServerResponseUnmarshaller.Instance;

            return Invoke<CreateServerRequest,CreateServerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateServerResponse> CreateServerAsync(CreateServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateServerRequestMarshaller();
            var unmarshaller = CreateServerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateServerRequest,CreateServerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackup

        internal DeleteBackupResponse DeleteBackup(DeleteBackupRequest request)
        {
            var marshaller = new DeleteBackupRequestMarshaller();
            var unmarshaller = DeleteBackupResponseUnmarshaller.Instance;

            return Invoke<DeleteBackupRequest,DeleteBackupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBackupRequestMarshaller();
            var unmarshaller = DeleteBackupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBackupRequest,DeleteBackupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteServer

        internal DeleteServerResponse DeleteServer(DeleteServerRequest request)
        {
            var marshaller = new DeleteServerRequestMarshaller();
            var unmarshaller = DeleteServerResponseUnmarshaller.Instance;

            return Invoke<DeleteServerRequest,DeleteServerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteServerResponse> DeleteServerAsync(DeleteServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteServerRequestMarshaller();
            var unmarshaller = DeleteServerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServerRequest,DeleteServerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        internal DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeBackups

        internal DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request)
        {
            var marshaller = new DescribeBackupsRequestMarshaller();
            var unmarshaller = DescribeBackupsResponseUnmarshaller.Instance;

            return Invoke<DescribeBackupsRequest,DescribeBackupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBackups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeBackupsResponse> DescribeBackupsAsync(DescribeBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeBackupsRequestMarshaller();
            var unmarshaller = DescribeBackupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBackupsRequest,DescribeBackupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents

        internal DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, unmarshaller);
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
        
        #region  DescribeNodeAssociationStatus

        internal DescribeNodeAssociationStatusResponse DescribeNodeAssociationStatus(DescribeNodeAssociationStatusRequest request)
        {
            var marshaller = new DescribeNodeAssociationStatusRequestMarshaller();
            var unmarshaller = DescribeNodeAssociationStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeNodeAssociationStatusRequest,DescribeNodeAssociationStatusResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNodeAssociationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeAssociationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeNodeAssociationStatusResponse> DescribeNodeAssociationStatusAsync(DescribeNodeAssociationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNodeAssociationStatusRequestMarshaller();
            var unmarshaller = DescribeNodeAssociationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNodeAssociationStatusRequest,DescribeNodeAssociationStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeServers

        internal DescribeServersResponse DescribeServers(DescribeServersRequest request)
        {
            var marshaller = new DescribeServersRequestMarshaller();
            var unmarshaller = DescribeServersResponseUnmarshaller.Instance;

            return Invoke<DescribeServersRequest,DescribeServersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeServersResponse> DescribeServersAsync(DescribeServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeServersRequestMarshaller();
            var unmarshaller = DescribeServersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeServersRequest,DescribeServersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateNode

        internal DisassociateNodeResponse DisassociateNode(DisassociateNodeRequest request)
        {
            var marshaller = new DisassociateNodeRequestMarshaller();
            var unmarshaller = DisassociateNodeResponseUnmarshaller.Instance;

            return Invoke<DisassociateNodeRequest,DisassociateNodeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisassociateNodeResponse> DisassociateNodeAsync(DisassociateNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateNodeRequestMarshaller();
            var unmarshaller = DisassociateNodeResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateNodeRequest,DisassociateNodeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreServer

        internal RestoreServerResponse RestoreServer(RestoreServerRequest request)
        {
            var marshaller = new RestoreServerRequestMarshaller();
            var unmarshaller = RestoreServerResponseUnmarshaller.Instance;

            return Invoke<RestoreServerRequest,RestoreServerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RestoreServerResponse> RestoreServerAsync(RestoreServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreServerRequestMarshaller();
            var unmarshaller = RestoreServerResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreServerRequest,RestoreServerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartMaintenance

        internal StartMaintenanceResponse StartMaintenance(StartMaintenanceRequest request)
        {
            var marshaller = new StartMaintenanceRequestMarshaller();
            var unmarshaller = StartMaintenanceResponseUnmarshaller.Instance;

            return Invoke<StartMaintenanceRequest,StartMaintenanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartMaintenance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMaintenance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StartMaintenanceResponse> StartMaintenanceAsync(StartMaintenanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartMaintenanceRequestMarshaller();
            var unmarshaller = StartMaintenanceResponseUnmarshaller.Instance;

            return InvokeAsync<StartMaintenanceRequest,StartMaintenanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateServer

        internal UpdateServerResponse UpdateServer(UpdateServerRequest request)
        {
            var marshaller = new UpdateServerRequestMarshaller();
            var unmarshaller = UpdateServerResponseUnmarshaller.Instance;

            return Invoke<UpdateServerRequest,UpdateServerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateServerResponse> UpdateServerAsync(UpdateServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateServerRequestMarshaller();
            var unmarshaller = UpdateServerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServerRequest,UpdateServerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateServerEngineAttributes

        internal UpdateServerEngineAttributesResponse UpdateServerEngineAttributes(UpdateServerEngineAttributesRequest request)
        {
            var marshaller = new UpdateServerEngineAttributesRequestMarshaller();
            var unmarshaller = UpdateServerEngineAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateServerEngineAttributesRequest,UpdateServerEngineAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerEngineAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerEngineAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateServerEngineAttributesResponse> UpdateServerEngineAttributesAsync(UpdateServerEngineAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateServerEngineAttributesRequestMarshaller();
            var unmarshaller = UpdateServerEngineAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServerEngineAttributesRequest,UpdateServerEngineAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}