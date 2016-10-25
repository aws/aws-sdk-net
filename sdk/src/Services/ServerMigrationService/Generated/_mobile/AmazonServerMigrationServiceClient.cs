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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ServerMigrationService.Model;
using Amazon.ServerMigrationService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ServerMigrationService
{
    /// <summary>
    /// Implementation for accessing ServerMigrationService
    ///
    /// Amazon Server Migration Service automates the process of migrating servers to EC2.
    /// </summary>
    public partial class AmazonServerMigrationServiceClient : AmazonServiceClient, IAmazonServerMigrationService
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with the credentials loaded from the application's
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
        public AmazonServerMigrationServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServerMigrationServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with the credentials loaded from the application's
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
        public AmazonServerMigrationServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonServerMigrationServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonServerMigrationServiceClient Configuration Object</param>
        public AmazonServerMigrationServiceClient(AmazonServerMigrationServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonServerMigrationServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonServerMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServerMigrationServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonServerMigrationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Credentials and an
        /// AmazonServerMigrationServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonServerMigrationServiceClient Configuration Object</param>
        public AmazonServerMigrationServiceClient(AWSCredentials credentials, AmazonServerMigrationServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServerMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonServerMigrationServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServerMigrationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonServerMigrationServiceClient Configuration Object</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonServerMigrationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServerMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonServerMigrationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonServerMigrationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonServerMigrationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonServerMigrationServiceClient Configuration Object</param>
        public AmazonServerMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonServerMigrationServiceConfig clientConfig)
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

        
        #region  CreateReplicationJob

        internal CreateReplicationJobResponse CreateReplicationJob(CreateReplicationJobRequest request)
        {
            var marshaller = new CreateReplicationJobRequestMarshaller();
            var unmarshaller = CreateReplicationJobResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationJobRequest,CreateReplicationJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateReplicationJobResponse> CreateReplicationJobAsync(CreateReplicationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateReplicationJobRequestMarshaller();
            var unmarshaller = CreateReplicationJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReplicationJobRequest,CreateReplicationJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteReplicationJob

        internal DeleteReplicationJobResponse DeleteReplicationJob(DeleteReplicationJobRequest request)
        {
            var marshaller = new DeleteReplicationJobRequestMarshaller();
            var unmarshaller = DeleteReplicationJobResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationJobRequest,DeleteReplicationJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteReplicationJobResponse> DeleteReplicationJobAsync(DeleteReplicationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteReplicationJobRequestMarshaller();
            var unmarshaller = DeleteReplicationJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReplicationJobRequest,DeleteReplicationJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteServerCatalog

        internal DeleteServerCatalogResponse DeleteServerCatalog(DeleteServerCatalogRequest request)
        {
            var marshaller = new DeleteServerCatalogRequestMarshaller();
            var unmarshaller = DeleteServerCatalogResponseUnmarshaller.Instance;

            return Invoke<DeleteServerCatalogRequest,DeleteServerCatalogResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCatalog operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteServerCatalogResponse> DeleteServerCatalogAsync(DeleteServerCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteServerCatalogRequestMarshaller();
            var unmarshaller = DeleteServerCatalogResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServerCatalogRequest,DeleteServerCatalogResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateConnector

        internal DisassociateConnectorResponse DisassociateConnector(DisassociateConnectorRequest request)
        {
            var marshaller = new DisassociateConnectorRequestMarshaller();
            var unmarshaller = DisassociateConnectorResponseUnmarshaller.Instance;

            return Invoke<DisassociateConnectorRequest,DisassociateConnectorResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnector operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisassociateConnectorResponse> DisassociateConnectorAsync(DisassociateConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateConnectorRequestMarshaller();
            var unmarshaller = DisassociateConnectorResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateConnectorRequest,DisassociateConnectorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConnectors

        internal GetConnectorsResponse GetConnectors(GetConnectorsRequest request)
        {
            var marshaller = new GetConnectorsRequestMarshaller();
            var unmarshaller = GetConnectorsResponseUnmarshaller.Instance;

            return Invoke<GetConnectorsRequest,GetConnectorsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetConnectorsResponse> GetConnectorsAsync(GetConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetConnectorsRequestMarshaller();
            var unmarshaller = GetConnectorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectorsRequest,GetConnectorsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetReplicationJobs

        internal GetReplicationJobsResponse GetReplicationJobs(GetReplicationJobsRequest request)
        {
            var marshaller = new GetReplicationJobsRequestMarshaller();
            var unmarshaller = GetReplicationJobsResponseUnmarshaller.Instance;

            return Invoke<GetReplicationJobsRequest,GetReplicationJobsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetReplicationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetReplicationJobsResponse> GetReplicationJobsAsync(GetReplicationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetReplicationJobsRequestMarshaller();
            var unmarshaller = GetReplicationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<GetReplicationJobsRequest,GetReplicationJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetReplicationRuns

        internal GetReplicationRunsResponse GetReplicationRuns(GetReplicationRunsRequest request)
        {
            var marshaller = new GetReplicationRunsRequestMarshaller();
            var unmarshaller = GetReplicationRunsResponseUnmarshaller.Instance;

            return Invoke<GetReplicationRunsRequest,GetReplicationRunsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetReplicationRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationRuns operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetReplicationRunsResponse> GetReplicationRunsAsync(GetReplicationRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetReplicationRunsRequestMarshaller();
            var unmarshaller = GetReplicationRunsResponseUnmarshaller.Instance;

            return InvokeAsync<GetReplicationRunsRequest,GetReplicationRunsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetServers

        internal GetServersResponse GetServers(GetServersRequest request)
        {
            var marshaller = new GetServersRequestMarshaller();
            var unmarshaller = GetServersResponseUnmarshaller.Instance;

            return Invoke<GetServersRequest,GetServersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetServersResponse> GetServersAsync(GetServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetServersRequestMarshaller();
            var unmarshaller = GetServersResponseUnmarshaller.Instance;

            return InvokeAsync<GetServersRequest,GetServersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportServerCatalog

        internal ImportServerCatalogResponse ImportServerCatalog(ImportServerCatalogRequest request)
        {
            var marshaller = new ImportServerCatalogRequestMarshaller();
            var unmarshaller = ImportServerCatalogResponseUnmarshaller.Instance;

            return Invoke<ImportServerCatalogRequest,ImportServerCatalogResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportServerCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportServerCatalog operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ImportServerCatalogResponse> ImportServerCatalogAsync(ImportServerCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportServerCatalogRequestMarshaller();
            var unmarshaller = ImportServerCatalogResponseUnmarshaller.Instance;

            return InvokeAsync<ImportServerCatalogRequest,ImportServerCatalogResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartOnDemandReplicationRun

        internal StartOnDemandReplicationRunResponse StartOnDemandReplicationRun(StartOnDemandReplicationRunRequest request)
        {
            var marshaller = new StartOnDemandReplicationRunRequestMarshaller();
            var unmarshaller = StartOnDemandReplicationRunResponseUnmarshaller.Instance;

            return Invoke<StartOnDemandReplicationRunRequest,StartOnDemandReplicationRunResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartOnDemandReplicationRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandReplicationRun operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StartOnDemandReplicationRunResponse> StartOnDemandReplicationRunAsync(StartOnDemandReplicationRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartOnDemandReplicationRunRequestMarshaller();
            var unmarshaller = StartOnDemandReplicationRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartOnDemandReplicationRunRequest,StartOnDemandReplicationRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateReplicationJob

        internal UpdateReplicationJobResponse UpdateReplicationJob(UpdateReplicationJobRequest request)
        {
            var marshaller = new UpdateReplicationJobRequestMarshaller();
            var unmarshaller = UpdateReplicationJobResponseUnmarshaller.Instance;

            return Invoke<UpdateReplicationJobRequest,UpdateReplicationJobResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReplicationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateReplicationJobResponse> UpdateReplicationJobAsync(UpdateReplicationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateReplicationJobRequestMarshaller();
            var unmarshaller = UpdateReplicationJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateReplicationJobRequest,UpdateReplicationJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}