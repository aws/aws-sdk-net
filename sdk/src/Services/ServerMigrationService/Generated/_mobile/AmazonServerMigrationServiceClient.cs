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
using Amazon.ServerMigrationService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ServerMigrationService
{
    /// <summary>
    /// Implementation for accessing ServerMigrationService
    ///
    /// AAWS Sever Migration Service 
    /// <para>
    /// This is the <i>AWS Sever Migration Service API Reference</i>. It provides descriptions,
    /// syntax, and usage examples for each of the actions and data types for the AWS Sever
    /// Migration Service (AWS SMS). The topic for each action shows the Query API request
    /// parameters and the XML response. You can also view the XML request elements in the
    /// WSDL.
    /// </para>
    ///  
    /// <para>
    /// Alternatively, you can use one of the AWS SDKs to access an API that's tailored to
    /// the programming language or platform that you're using. For more information, see
    /// <a href="http://aws.amazon.com/tools/#SDKs">AWS SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// To learn more about the Server Migration Service, see the following resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://aws.amazon.com/server-migration-service/">AWS Sever Migration Service
    /// product page</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/server-migration-service/latest/userguide/server-migration.html">AWS
    /// Sever Migration Service User Guide</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonServerMigrationServiceClient : AmazonServiceClient, IAmazonServerMigrationService
    {
        private static IServiceMetadata serviceMetadata = new AmazonServerMigrationServiceMetadata();
        
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

        
        #region  CreateApp

        internal virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var marshaller = CreateAppRequestMarshaller.Instance;
            var unmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppRequest,CreateAppResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateAppRequestMarshaller.Instance;
            var unmarshaller = CreateAppResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppRequest,CreateAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateReplicationJob

        internal virtual CreateReplicationJobResponse CreateReplicationJob(CreateReplicationJobRequest request)
        {
            var marshaller = CreateReplicationJobRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/CreateReplicationJob">REST API Reference for CreateReplicationJob Operation</seealso>
        public virtual Task<CreateReplicationJobResponse> CreateReplicationJobAsync(CreateReplicationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateReplicationJobRequestMarshaller.Instance;
            var unmarshaller = CreateReplicationJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReplicationJobRequest,CreateReplicationJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApp

        internal virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var marshaller = DeleteAppRequestMarshaller.Instance;
            var unmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppRequest,DeleteAppResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAppRequestMarshaller.Instance;
            var unmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppRequest,DeleteAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAppLaunchConfiguration

        internal virtual DeleteAppLaunchConfigurationResponse DeleteAppLaunchConfiguration(DeleteAppLaunchConfigurationRequest request)
        {
            var marshaller = DeleteAppLaunchConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeleteAppLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteAppLaunchConfigurationRequest,DeleteAppLaunchConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppLaunchConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppLaunchConfiguration">REST API Reference for DeleteAppLaunchConfiguration Operation</seealso>
        public virtual Task<DeleteAppLaunchConfigurationResponse> DeleteAppLaunchConfigurationAsync(DeleteAppLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAppLaunchConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeleteAppLaunchConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppLaunchConfigurationRequest,DeleteAppLaunchConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAppReplicationConfiguration

        internal virtual DeleteAppReplicationConfigurationResponse DeleteAppReplicationConfiguration(DeleteAppReplicationConfigurationRequest request)
        {
            var marshaller = DeleteAppReplicationConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeleteAppReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteAppReplicationConfigurationRequest,DeleteAppReplicationConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppReplicationConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteAppReplicationConfiguration">REST API Reference for DeleteAppReplicationConfiguration Operation</seealso>
        public virtual Task<DeleteAppReplicationConfigurationResponse> DeleteAppReplicationConfigurationAsync(DeleteAppReplicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAppReplicationConfigurationRequestMarshaller.Instance;
            var unmarshaller = DeleteAppReplicationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppReplicationConfigurationRequest,DeleteAppReplicationConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteReplicationJob

        internal virtual DeleteReplicationJobResponse DeleteReplicationJob(DeleteReplicationJobRequest request)
        {
            var marshaller = DeleteReplicationJobRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteReplicationJob">REST API Reference for DeleteReplicationJob Operation</seealso>
        public virtual Task<DeleteReplicationJobResponse> DeleteReplicationJobAsync(DeleteReplicationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteReplicationJobRequestMarshaller.Instance;
            var unmarshaller = DeleteReplicationJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReplicationJobRequest,DeleteReplicationJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteServerCatalog

        internal virtual DeleteServerCatalogResponse DeleteServerCatalog(DeleteServerCatalogRequest request)
        {
            var marshaller = DeleteServerCatalogRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DeleteServerCatalog">REST API Reference for DeleteServerCatalog Operation</seealso>
        public virtual Task<DeleteServerCatalogResponse> DeleteServerCatalogAsync(DeleteServerCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteServerCatalogRequestMarshaller.Instance;
            var unmarshaller = DeleteServerCatalogResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServerCatalogRequest,DeleteServerCatalogResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateConnector

        internal virtual DisassociateConnectorResponse DisassociateConnector(DisassociateConnectorRequest request)
        {
            var marshaller = DisassociateConnectorRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/DisassociateConnector">REST API Reference for DisassociateConnector Operation</seealso>
        public virtual Task<DisassociateConnectorResponse> DisassociateConnectorAsync(DisassociateConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateConnectorRequestMarshaller.Instance;
            var unmarshaller = DisassociateConnectorResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateConnectorRequest,DisassociateConnectorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateChangeSet

        internal virtual GenerateChangeSetResponse GenerateChangeSet(GenerateChangeSetRequest request)
        {
            var marshaller = GenerateChangeSetRequestMarshaller.Instance;
            var unmarshaller = GenerateChangeSetResponseUnmarshaller.Instance;

            return Invoke<GenerateChangeSetRequest,GenerateChangeSetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateChangeSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GenerateChangeSet">REST API Reference for GenerateChangeSet Operation</seealso>
        public virtual Task<GenerateChangeSetResponse> GenerateChangeSetAsync(GenerateChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GenerateChangeSetRequestMarshaller.Instance;
            var unmarshaller = GenerateChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateChangeSetRequest,GenerateChangeSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateTemplate

        internal virtual GenerateTemplateResponse GenerateTemplate(GenerateTemplateRequest request)
        {
            var marshaller = GenerateTemplateRequestMarshaller.Instance;
            var unmarshaller = GenerateTemplateResponseUnmarshaller.Instance;

            return Invoke<GenerateTemplateRequest,GenerateTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GenerateTemplate">REST API Reference for GenerateTemplate Operation</seealso>
        public virtual Task<GenerateTemplateResponse> GenerateTemplateAsync(GenerateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GenerateTemplateRequestMarshaller.Instance;
            var unmarshaller = GenerateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateTemplateRequest,GenerateTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApp

        internal virtual GetAppResponse GetApp(GetAppRequest request)
        {
            var marshaller = GetAppRequestMarshaller.Instance;
            var unmarshaller = GetAppResponseUnmarshaller.Instance;

            return Invoke<GetAppRequest,GetAppResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetApp">REST API Reference for GetApp Operation</seealso>
        public virtual Task<GetAppResponse> GetAppAsync(GetAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAppRequestMarshaller.Instance;
            var unmarshaller = GetAppResponseUnmarshaller.Instance;

            return InvokeAsync<GetAppRequest,GetAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAppLaunchConfiguration

        internal virtual GetAppLaunchConfigurationResponse GetAppLaunchConfiguration(GetAppLaunchConfigurationRequest request)
        {
            var marshaller = GetAppLaunchConfigurationRequestMarshaller.Instance;
            var unmarshaller = GetAppLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetAppLaunchConfigurationRequest,GetAppLaunchConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAppLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppLaunchConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppLaunchConfiguration">REST API Reference for GetAppLaunchConfiguration Operation</seealso>
        public virtual Task<GetAppLaunchConfigurationResponse> GetAppLaunchConfigurationAsync(GetAppLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAppLaunchConfigurationRequestMarshaller.Instance;
            var unmarshaller = GetAppLaunchConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetAppLaunchConfigurationRequest,GetAppLaunchConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAppReplicationConfiguration

        internal virtual GetAppReplicationConfigurationResponse GetAppReplicationConfiguration(GetAppReplicationConfigurationRequest request)
        {
            var marshaller = GetAppReplicationConfigurationRequestMarshaller.Instance;
            var unmarshaller = GetAppReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetAppReplicationConfigurationRequest,GetAppReplicationConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAppReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAppReplicationConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetAppReplicationConfiguration">REST API Reference for GetAppReplicationConfiguration Operation</seealso>
        public virtual Task<GetAppReplicationConfigurationResponse> GetAppReplicationConfigurationAsync(GetAppReplicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAppReplicationConfigurationRequestMarshaller.Instance;
            var unmarshaller = GetAppReplicationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetAppReplicationConfigurationRequest,GetAppReplicationConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConnectors

        internal virtual GetConnectorsResponse GetConnectors(GetConnectorsRequest request)
        {
            var marshaller = GetConnectorsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetConnectors">REST API Reference for GetConnectors Operation</seealso>
        public virtual Task<GetConnectorsResponse> GetConnectorsAsync(GetConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetConnectorsRequestMarshaller.Instance;
            var unmarshaller = GetConnectorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectorsRequest,GetConnectorsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetReplicationJobs

        internal virtual GetReplicationJobsResponse GetReplicationJobs(GetReplicationJobsRequest request)
        {
            var marshaller = GetReplicationJobsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationJobs">REST API Reference for GetReplicationJobs Operation</seealso>
        public virtual Task<GetReplicationJobsResponse> GetReplicationJobsAsync(GetReplicationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetReplicationJobsRequestMarshaller.Instance;
            var unmarshaller = GetReplicationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<GetReplicationJobsRequest,GetReplicationJobsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetReplicationRuns

        internal virtual GetReplicationRunsResponse GetReplicationRuns(GetReplicationRunsRequest request)
        {
            var marshaller = GetReplicationRunsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetReplicationRuns">REST API Reference for GetReplicationRuns Operation</seealso>
        public virtual Task<GetReplicationRunsResponse> GetReplicationRunsAsync(GetReplicationRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetReplicationRunsRequestMarshaller.Instance;
            var unmarshaller = GetReplicationRunsResponseUnmarshaller.Instance;

            return InvokeAsync<GetReplicationRunsRequest,GetReplicationRunsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetServers

        internal virtual GetServersResponse GetServers(GetServersRequest request)
        {
            var marshaller = GetServersRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/GetServers">REST API Reference for GetServers Operation</seealso>
        public virtual Task<GetServersResponse> GetServersAsync(GetServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetServersRequestMarshaller.Instance;
            var unmarshaller = GetServersResponseUnmarshaller.Instance;

            return InvokeAsync<GetServersRequest,GetServersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportServerCatalog

        internal virtual ImportServerCatalogResponse ImportServerCatalog(ImportServerCatalogRequest request)
        {
            var marshaller = ImportServerCatalogRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ImportServerCatalog">REST API Reference for ImportServerCatalog Operation</seealso>
        public virtual Task<ImportServerCatalogResponse> ImportServerCatalogAsync(ImportServerCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportServerCatalogRequestMarshaller.Instance;
            var unmarshaller = ImportServerCatalogResponseUnmarshaller.Instance;

            return InvokeAsync<ImportServerCatalogRequest,ImportServerCatalogResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  LaunchApp

        internal virtual LaunchAppResponse LaunchApp(LaunchAppRequest request)
        {
            var marshaller = LaunchAppRequestMarshaller.Instance;
            var unmarshaller = LaunchAppResponseUnmarshaller.Instance;

            return Invoke<LaunchAppRequest,LaunchAppResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the LaunchApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LaunchApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/LaunchApp">REST API Reference for LaunchApp Operation</seealso>
        public virtual Task<LaunchAppResponse> LaunchAppAsync(LaunchAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = LaunchAppRequestMarshaller.Instance;
            var unmarshaller = LaunchAppResponseUnmarshaller.Instance;

            return InvokeAsync<LaunchAppRequest,LaunchAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListApps

        internal virtual ListAppsResponse ListApps(ListAppsRequest request)
        {
            var marshaller = ListAppsRequestMarshaller.Instance;
            var unmarshaller = ListAppsResponseUnmarshaller.Instance;

            return Invoke<ListAppsRequest,ListAppsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApps operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListAppsRequestMarshaller.Instance;
            var unmarshaller = ListAppsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppsRequest,ListAppsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutAppLaunchConfiguration

        internal virtual PutAppLaunchConfigurationResponse PutAppLaunchConfiguration(PutAppLaunchConfigurationRequest request)
        {
            var marshaller = PutAppLaunchConfigurationRequestMarshaller.Instance;
            var unmarshaller = PutAppLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutAppLaunchConfigurationRequest,PutAppLaunchConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutAppLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAppLaunchConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppLaunchConfiguration">REST API Reference for PutAppLaunchConfiguration Operation</seealso>
        public virtual Task<PutAppLaunchConfigurationResponse> PutAppLaunchConfigurationAsync(PutAppLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutAppLaunchConfigurationRequestMarshaller.Instance;
            var unmarshaller = PutAppLaunchConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutAppLaunchConfigurationRequest,PutAppLaunchConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutAppReplicationConfiguration

        internal virtual PutAppReplicationConfigurationResponse PutAppReplicationConfiguration(PutAppReplicationConfigurationRequest request)
        {
            var marshaller = PutAppReplicationConfigurationRequestMarshaller.Instance;
            var unmarshaller = PutAppReplicationConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutAppReplicationConfigurationRequest,PutAppReplicationConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutAppReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAppReplicationConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/PutAppReplicationConfiguration">REST API Reference for PutAppReplicationConfiguration Operation</seealso>
        public virtual Task<PutAppReplicationConfigurationResponse> PutAppReplicationConfigurationAsync(PutAppReplicationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutAppReplicationConfigurationRequestMarshaller.Instance;
            var unmarshaller = PutAppReplicationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutAppReplicationConfigurationRequest,PutAppReplicationConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartAppReplication

        internal virtual StartAppReplicationResponse StartAppReplication(StartAppReplicationRequest request)
        {
            var marshaller = StartAppReplicationRequestMarshaller.Instance;
            var unmarshaller = StartAppReplicationResponseUnmarshaller.Instance;

            return Invoke<StartAppReplicationRequest,StartAppReplicationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartAppReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAppReplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartAppReplication">REST API Reference for StartAppReplication Operation</seealso>
        public virtual Task<StartAppReplicationResponse> StartAppReplicationAsync(StartAppReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartAppReplicationRequestMarshaller.Instance;
            var unmarshaller = StartAppReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StartAppReplicationRequest,StartAppReplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartOnDemandReplicationRun

        internal virtual StartOnDemandReplicationRunResponse StartOnDemandReplicationRun(StartOnDemandReplicationRunRequest request)
        {
            var marshaller = StartOnDemandReplicationRunRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StartOnDemandReplicationRun">REST API Reference for StartOnDemandReplicationRun Operation</seealso>
        public virtual Task<StartOnDemandReplicationRunResponse> StartOnDemandReplicationRunAsync(StartOnDemandReplicationRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartOnDemandReplicationRunRequestMarshaller.Instance;
            var unmarshaller = StartOnDemandReplicationRunResponseUnmarshaller.Instance;

            return InvokeAsync<StartOnDemandReplicationRunRequest,StartOnDemandReplicationRunResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopAppReplication

        internal virtual StopAppReplicationResponse StopAppReplication(StopAppReplicationRequest request)
        {
            var marshaller = StopAppReplicationRequestMarshaller.Instance;
            var unmarshaller = StopAppReplicationResponseUnmarshaller.Instance;

            return Invoke<StopAppReplicationRequest,StopAppReplicationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopAppReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopAppReplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/StopAppReplication">REST API Reference for StopAppReplication Operation</seealso>
        public virtual Task<StopAppReplicationResponse> StopAppReplicationAsync(StopAppReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopAppReplicationRequestMarshaller.Instance;
            var unmarshaller = StopAppReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<StopAppReplicationRequest,StopAppReplicationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TerminateApp

        internal virtual TerminateAppResponse TerminateApp(TerminateAppRequest request)
        {
            var marshaller = TerminateAppRequestMarshaller.Instance;
            var unmarshaller = TerminateAppResponseUnmarshaller.Instance;

            return Invoke<TerminateAppRequest,TerminateAppResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/TerminateApp">REST API Reference for TerminateApp Operation</seealso>
        public virtual Task<TerminateAppResponse> TerminateAppAsync(TerminateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TerminateAppRequestMarshaller.Instance;
            var unmarshaller = TerminateAppResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateAppRequest,TerminateAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApp

        internal virtual UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            var marshaller = UpdateAppRequestMarshaller.Instance;
            var unmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return Invoke<UpdateAppRequest,UpdateAppResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateAppRequestMarshaller.Instance;
            var unmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAppRequest,UpdateAppResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateReplicationJob

        internal virtual UpdateReplicationJobResponse UpdateReplicationJob(UpdateReplicationJobRequest request)
        {
            var marshaller = UpdateReplicationJobRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sms-2016-10-24/UpdateReplicationJob">REST API Reference for UpdateReplicationJob Operation</seealso>
        public virtual Task<UpdateReplicationJobResponse> UpdateReplicationJobAsync(UpdateReplicationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateReplicationJobRequestMarshaller.Instance;
            var unmarshaller = UpdateReplicationJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateReplicationJobRequest,UpdateReplicationJobResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}