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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DataSync.Model;
using Amazon.DataSync.Model.Internal.MarshallTransformations;
using Amazon.DataSync.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.DataSync
{
    /// <summary>
    /// <para>Implementation for accessing DataSync</para>
    ///
    /// DataSync 
    /// <para>
    /// DataSync is an online data movement and discovery service that simplifies data migration
    /// and helps you quickly, easily, and securely transfer your file or object data to,
    /// from, and between Amazon Web Services storage services.
    /// </para>
    ///  
    /// <para>
    /// This API interface reference includes documentation for using DataSync programmatically.
    /// For complete information, see the <i> <a href="https://docs.aws.amazon.com/datasync/latest/userguide/what-is-datasync.html">DataSync
    /// User Guide</a> </i>.
    /// </para>
    /// </summary>
    public partial class AmazonDataSyncClient : AmazonServiceClient, IAmazonDataSync
    {
        private static IServiceMetadata serviceMetadata = new AmazonDataSyncMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonDataSyncClient with the credentials loaded from the application's
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
        public AmazonDataSyncClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataSyncConfig()) { }

        /// <summary>
        /// Constructs AmazonDataSyncClient with the credentials loaded from the application's
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
        public AmazonDataSyncClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataSyncConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDataSyncClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(AmazonDataSyncConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDataSyncClient(AWSCredentials credentials)
            : this(credentials, new AmazonDataSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataSyncClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDataSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Credentials and an
        /// AmazonDataSyncClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(AWSCredentials credentials, AmazonDataSyncConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataSyncConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDataSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDataSyncClient Configuration Object</param>
        public AmazonDataSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDataSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IDataSyncPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDataSyncPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DataSyncPaginatorFactory(this);
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
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDataSyncEndpointResolver());
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


        #region  AddStorageSystem

        internal virtual AddStorageSystemResponse AddStorageSystem(AddStorageSystemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddStorageSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddStorageSystemResponseUnmarshaller.Instance;

            return Invoke<AddStorageSystemResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Web Services resource for an on-premises storage system that you
        /// want DataSync Discovery to collect information about.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddStorageSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddStorageSystem service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/AddStorageSystem">REST API Reference for AddStorageSystem Operation</seealso>
        public virtual Task<AddStorageSystemResponse> AddStorageSystemAsync(AddStorageSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddStorageSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddStorageSystemResponseUnmarshaller.Instance;

            return InvokeAsync<AddStorageSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelTaskExecution

        internal virtual CancelTaskExecutionResponse CancelTaskExecution(CancelTaskExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelTaskExecutionResponse>(request, options);
        }



        /// <summary>
        /// Stops an DataSync task execution that's in progress. The transfer of some files are
        /// abruptly interrupted. File contents that're transferred to the destination might be
        /// incomplete or inconsistent with the source files.
        /// 
        ///  
        /// <para>
        /// However, if you start a new task execution using the same task and allow it to finish,
        /// file content on the destination will be complete and consistent. This applies to other
        /// unexpected failures that interrupt a task execution. In all of these cases, DataSync
        /// successfully completes the transfer when you start the next task execution.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTaskExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CancelTaskExecution">REST API Reference for CancelTaskExecution Operation</seealso>
        public virtual Task<CancelTaskExecutionResponse> CancelTaskExecutionAsync(CancelTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelTaskExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAgent

        internal virtual CreateAgentResponse CreateAgent(CreateAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentResponseUnmarshaller.Instance;

            return Invoke<CreateAgentResponse>(request, options);
        }



        /// <summary>
        /// Activates an DataSync agent that you've deployed in your storage environment. The
        /// activation process associates the agent with your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you haven't deployed an agent yet, see the following topics to learn more:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/agent-requirements.html">Agent
        /// requirements</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/configure-agent.html">Create
        /// an agent</a> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you're transferring between Amazon Web Services storage services, you don't need
        /// a DataSync agent. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        public virtual Task<CreateAgentResponse> CreateAgentAsync(CreateAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAgentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationAzureBlob

        internal virtual CreateLocationAzureBlobResponse CreateLocationAzureBlob(CreateLocationAzureBlobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationAzureBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationAzureBlobResponseUnmarshaller.Instance;

            return Invoke<CreateLocationAzureBlobResponse>(request, options);
        }



        /// <summary>
        /// Creates a transfer <i>location</i> for a Microsoft Azure Blob Storage container. DataSync
        /// can use this location as a transfer source or destination.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure you know <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access">how
        /// DataSync accesses Azure Blob Storage</a> and works with <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access-tiers">access
        /// tiers</a> and <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#blob-types">blob
        /// types</a>. You also need a <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-creating-agent">DataSync
        /// agent</a> that can connect to your container.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationAzureBlob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationAzureBlob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationAzureBlob">REST API Reference for CreateLocationAzureBlob Operation</seealso>
        public virtual Task<CreateLocationAzureBlobResponse> CreateLocationAzureBlobAsync(CreateLocationAzureBlobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationAzureBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationAzureBlobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationAzureBlobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationEfs

        internal virtual CreateLocationEfsResponse CreateLocationEfs(CreateLocationEfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationEfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationEfsResponse>(request, options);
        }



        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon EFS file system. DataSync can use
        /// this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html#create-efs-location-access">accesses
        /// Amazon EFS file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationEfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationEfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationEfs">REST API Reference for CreateLocationEfs Operation</seealso>
        public virtual Task<CreateLocationEfsResponse> CreateLocationEfsAsync(CreateLocationEfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationEfsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationEfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationFsxLustre

        internal virtual CreateLocationFsxLustreResponse CreateLocationFsxLustre(CreateLocationFsxLustreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxLustreResponseUnmarshaller.Instance;

            return Invoke<CreateLocationFsxLustreResponse>(request, options);
        }



        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for Lustre file system. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-lustre-location.html#create-lustre-location-access">accesses
        /// FSx for Lustre file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxLustre service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationFsxLustre service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxLustre">REST API Reference for CreateLocationFsxLustre Operation</seealso>
        public virtual Task<CreateLocationFsxLustreResponse> CreateLocationFsxLustreAsync(CreateLocationFsxLustreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxLustreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationFsxLustreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationFsxOntap

        internal virtual CreateLocationFsxOntapResponse CreateLocationFsxOntap(CreateLocationFsxOntapRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxOntapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxOntapResponseUnmarshaller.Instance;

            return Invoke<CreateLocationFsxOntapResponse>(request, options);
        }



        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for NetApp ONTAP file system.
        /// DataSync can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html#create-ontap-location-access">accesses
        /// FSx for ONTAP file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxOntap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationFsxOntap service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOntap">REST API Reference for CreateLocationFsxOntap Operation</seealso>
        public virtual Task<CreateLocationFsxOntapResponse> CreateLocationFsxOntapAsync(CreateLocationFsxOntapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxOntapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxOntapResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationFsxOntapResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationFsxOpenZfs

        internal virtual CreateLocationFsxOpenZfsResponse CreateLocationFsxOpenZfs(CreateLocationFsxOpenZfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationFsxOpenZfsResponse>(request, options);
        }



        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for OpenZFS file system. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-openzfs-location.html#create-openzfs-access">accesses
        /// FSx for OpenZFS file systems</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Request parameters related to <c>SMB</c> aren't supported with the <c>CreateLocationFsxOpenZfs</c>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxOpenZfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationFsxOpenZfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOpenZfs">REST API Reference for CreateLocationFsxOpenZfs Operation</seealso>
        public virtual Task<CreateLocationFsxOpenZfsResponse> CreateLocationFsxOpenZfsAsync(CreateLocationFsxOpenZfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationFsxOpenZfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationFsxWindows

        internal virtual CreateLocationFsxWindowsResponse CreateLocationFsxWindows(CreateLocationFsxWindowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxWindowsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationFsxWindowsResponse>(request, options);
        }



        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for Windows File Server file
        /// system. DataSync can use this location as a source or destination for transferring
        /// data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-fsx-location.html#create-fsx-location-access">accesses
        /// FSx for Windows File Server file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxWindows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationFsxWindows service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxWindows">REST API Reference for CreateLocationFsxWindows Operation</seealso>
        public virtual Task<CreateLocationFsxWindowsResponse> CreateLocationFsxWindowsAsync(CreateLocationFsxWindowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationFsxWindowsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationFsxWindowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationHdfs

        internal virtual CreateLocationHdfsResponse CreateLocationHdfs(CreateLocationHdfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationHdfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationHdfsResponse>(request, options);
        }



        /// <summary>
        /// Creates a transfer <i>location</i> for a Hadoop Distributed File System (HDFS). DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-hdfs-location.html#accessing-hdfs">accesses
        /// HDFS clusters</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationHdfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationHdfs">REST API Reference for CreateLocationHdfs Operation</seealso>
        public virtual Task<CreateLocationHdfsResponse> CreateLocationHdfsAsync(CreateLocationHdfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationHdfsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationHdfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationNfs

        internal virtual CreateLocationNfsResponse CreateLocationNfs(CreateLocationNfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationNfsResponseUnmarshaller.Instance;

            return Invoke<CreateLocationNfsResponse>(request, options);
        }



        /// <summary>
        /// Creates a transfer <i>location</i> for a Network File System (NFS) file server. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html#accessing-nfs">accesses
        /// NFS file servers</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're copying data to or from an Snowcone device, you can also use <c>CreateLocationNfs</c>
        /// to create your transfer location. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/nfs-on-snowcone.html">Configuring
        /// transfers with Snowcone</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationNfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationNfs">REST API Reference for CreateLocationNfs Operation</seealso>
        public virtual Task<CreateLocationNfsResponse> CreateLocationNfsAsync(CreateLocationNfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationNfsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationNfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationObjectStorage

        internal virtual CreateLocationObjectStorageResponse CreateLocationObjectStorage(CreateLocationObjectStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationObjectStorageResponseUnmarshaller.Instance;

            return Invoke<CreateLocationObjectStorageResponse>(request, options);
        }



        /// <summary>
        /// Creates a transfer <i>location</i> for an object storage system. DataSync can use
        /// this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html#create-object-location-prerequisites">prerequisites</a>
        /// for DataSync to work with object storage systems.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationObjectStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationObjectStorage">REST API Reference for CreateLocationObjectStorage Operation</seealso>
        public virtual Task<CreateLocationObjectStorageResponse> CreateLocationObjectStorageAsync(CreateLocationObjectStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationObjectStorageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationObjectStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationS3

        internal virtual CreateLocationS3Response CreateLocationS3(CreateLocationS3Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationS3ResponseUnmarshaller.Instance;

            return Invoke<CreateLocationS3Response>(request, options);
        }



        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon S3 bucket. DataSync can use this
        /// location as a source or destination for transferring data.
        /// 
        ///  <important> 
        /// <para>
        /// Before you begin, make sure that you read the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
        /// class considerations with Amazon S3 locations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">Evaluating
        /// S3 request costs when using DataSync</a> 
        /// </para>
        ///  </li> </ul> </important> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html">Configuring
        /// transfers with Amazon S3</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationS3 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationS3 service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationS3">REST API Reference for CreateLocationS3 Operation</seealso>
        public virtual Task<CreateLocationS3Response> CreateLocationS3Async(CreateLocationS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationS3ResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationS3Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLocationSmb

        internal virtual CreateLocationSmbResponse CreateLocationSmb(CreateLocationSmbRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationSmbResponseUnmarshaller.Instance;

            return Invoke<CreateLocationSmbResponse>(request, options);
        }



        /// <summary>
        /// Creates a transfer <i>location</i> for a Server Message Block (SMB) file server. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html#configuring-smb">accesses
        /// SMB file servers</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationSmb service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationSmb">REST API Reference for CreateLocationSmb Operation</seealso>
        public virtual Task<CreateLocationSmbResponse> CreateLocationSmbAsync(CreateLocationSmbRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLocationSmbResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLocationSmbResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTask

        internal virtual CreateTaskResponse CreateTask(CreateTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return Invoke<CreateTaskResponse>(request, options);
        }



        /// <summary>
        /// Configures a <i>task</i>, which defines where and how DataSync transfers your data.
        /// 
        ///  
        /// <para>
        /// A task includes a source location, destination location, and transfer options (such
        /// as bandwidth limits, scheduling, and more).
        /// </para>
        ///  <important> 
        /// <para>
        /// If you're planning to transfer data to or from an Amazon S3 location, review <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">how
        /// DataSync can affect your S3 request charges</a> and the <a href="http://aws.amazon.com/datasync/pricing/">DataSync
        /// pricing page</a> before you begin.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateTask">REST API Reference for CreateTask Operation</seealso>
        public virtual Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAgent

        internal virtual DeleteAgentResponse DeleteAgent(DeleteAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentResponseUnmarshaller.Instance;

            return Invoke<DeleteAgentResponse>(request, options);
        }



        /// <summary>
        /// Removes an DataSync agent resource from your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Keep in mind that this operation (which can't be undone) doesn't remove the agent's
        /// virtual machine (VM) or Amazon EC2 instance from your storage environment. For next
        /// steps, you can delete the VM or instance from your storage environment or reuse it
        /// to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/activate-agent.html">activate
        /// a new agent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        public virtual Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAgentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLocation

        internal virtual DeleteLocationResponse DeleteLocation(DeleteLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLocationResponseUnmarshaller.Instance;

            return Invoke<DeleteLocationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a transfer location resource from DataSync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLocation service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteLocation">REST API Reference for DeleteLocation Operation</seealso>
        public virtual Task<DeleteLocationResponse> DeleteLocationAsync(DeleteLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLocationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTask

        internal virtual DeleteTaskResponse DeleteTask(DeleteTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteTaskResponse>(request, options);
        }



        /// <summary>
        /// Deletes a transfer task resource from DataSync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteTask">REST API Reference for DeleteTask Operation</seealso>
        public virtual Task<DeleteTaskResponse> DeleteTaskAsync(DeleteTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAgent

        internal virtual DescribeAgentResponse DescribeAgent(DescribeAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentResponseUnmarshaller.Instance;

            return Invoke<DescribeAgentResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an DataSync agent, such as its name, service endpoint type,
        /// and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeAgent">REST API Reference for DescribeAgent Operation</seealso>
        public virtual Task<DescribeAgentResponse> DescribeAgentAsync(DescribeAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAgentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDiscoveryJob

        internal virtual DescribeDiscoveryJobResponse DescribeDiscoveryJob(DescribeDiscoveryJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDiscoveryJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDiscoveryJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDiscoveryJobResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a DataSync discovery job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDiscoveryJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDiscoveryJob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeDiscoveryJob">REST API Reference for DescribeDiscoveryJob Operation</seealso>
        public virtual Task<DescribeDiscoveryJobResponse> DescribeDiscoveryJobAsync(DescribeDiscoveryJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDiscoveryJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDiscoveryJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDiscoveryJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationAzureBlob

        internal virtual DescribeLocationAzureBlobResponse DescribeLocationAzureBlob(DescribeLocationAzureBlobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationAzureBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationAzureBlobResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationAzureBlobResponse>(request, options);
        }



        /// <summary>
        /// Provides details about how an DataSync transfer location for Microsoft Azure Blob
        /// Storage is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationAzureBlob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationAzureBlob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationAzureBlob">REST API Reference for DescribeLocationAzureBlob Operation</seealso>
        public virtual Task<DescribeLocationAzureBlobResponse> DescribeLocationAzureBlobAsync(DescribeLocationAzureBlobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationAzureBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationAzureBlobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationAzureBlobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationEfs

        internal virtual DescribeLocationEfsResponse DescribeLocationEfs(DescribeLocationEfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationEfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationEfsResponse>(request, options);
        }



        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon EFS file system
        /// is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationEfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationEfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationEfs">REST API Reference for DescribeLocationEfs Operation</seealso>
        public virtual Task<DescribeLocationEfsResponse> DescribeLocationEfsAsync(DescribeLocationEfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationEfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationEfsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationEfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationFsxLustre

        internal virtual DescribeLocationFsxLustreResponse DescribeLocationFsxLustre(DescribeLocationFsxLustreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxLustreResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationFsxLustreResponse>(request, options);
        }



        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for Lustre
        /// file system is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxLustre service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationFsxLustre service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxLustre">REST API Reference for DescribeLocationFsxLustre Operation</seealso>
        public virtual Task<DescribeLocationFsxLustreResponse> DescribeLocationFsxLustreAsync(DescribeLocationFsxLustreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxLustreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxLustreResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationFsxLustreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationFsxOntap

        internal virtual DescribeLocationFsxOntapResponse DescribeLocationFsxOntap(DescribeLocationFsxOntapRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxOntapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxOntapResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationFsxOntapResponse>(request, options);
        }



        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for NetApp
        /// ONTAP file system is configured.
        /// 
        ///  <note> 
        /// <para>
        /// If your location uses SMB, the <c>DescribeLocationFsxOntap</c> operation doesn't actually
        /// return a <c>Password</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxOntap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationFsxOntap service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOntap">REST API Reference for DescribeLocationFsxOntap Operation</seealso>
        public virtual Task<DescribeLocationFsxOntapResponse> DescribeLocationFsxOntapAsync(DescribeLocationFsxOntapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxOntapRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxOntapResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationFsxOntapResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationFsxOpenZfs

        internal virtual DescribeLocationFsxOpenZfsResponse DescribeLocationFsxOpenZfs(DescribeLocationFsxOpenZfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationFsxOpenZfsResponse>(request, options);
        }



        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for OpenZFS
        /// file system is configured.
        /// 
        ///  <note> 
        /// <para>
        /// Response elements related to <c>SMB</c> aren't supported with the <c>DescribeLocationFsxOpenZfs</c>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxOpenZfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationFsxOpenZfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOpenZfs">REST API Reference for DescribeLocationFsxOpenZfs Operation</seealso>
        public virtual Task<DescribeLocationFsxOpenZfsResponse> DescribeLocationFsxOpenZfsAsync(DescribeLocationFsxOpenZfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxOpenZfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxOpenZfsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationFsxOpenZfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationFsxWindows

        internal virtual DescribeLocationFsxWindowsResponse DescribeLocationFsxWindows(DescribeLocationFsxWindowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxWindowsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationFsxWindowsResponse>(request, options);
        }



        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for Windows
        /// File Server file system is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxWindows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationFsxWindows service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxWindows">REST API Reference for DescribeLocationFsxWindows Operation</seealso>
        public virtual Task<DescribeLocationFsxWindowsResponse> DescribeLocationFsxWindowsAsync(DescribeLocationFsxWindowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationFsxWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationFsxWindowsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationFsxWindowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationHdfs

        internal virtual DescribeLocationHdfsResponse DescribeLocationHdfs(DescribeLocationHdfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationHdfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationHdfsResponse>(request, options);
        }



        /// <summary>
        /// Provides details about how an DataSync transfer location for a Hadoop Distributed
        /// File System (HDFS) is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationHdfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationHdfs">REST API Reference for DescribeLocationHdfs Operation</seealso>
        public virtual Task<DescribeLocationHdfsResponse> DescribeLocationHdfsAsync(DescribeLocationHdfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationHdfsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationHdfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationNfs

        internal virtual DescribeLocationNfsResponse DescribeLocationNfs(DescribeLocationNfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationNfsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationNfsResponse>(request, options);
        }



        /// <summary>
        /// Provides details about how an DataSync transfer location for a Network File System
        /// (NFS) file server is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationNfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationNfs">REST API Reference for DescribeLocationNfs Operation</seealso>
        public virtual Task<DescribeLocationNfsResponse> DescribeLocationNfsAsync(DescribeLocationNfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationNfsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationNfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationObjectStorage

        internal virtual DescribeLocationObjectStorageResponse DescribeLocationObjectStorage(DescribeLocationObjectStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationObjectStorageResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationObjectStorageResponse>(request, options);
        }



        /// <summary>
        /// Provides details about how an DataSync transfer location for an object storage system
        /// is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationObjectStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationObjectStorage">REST API Reference for DescribeLocationObjectStorage Operation</seealso>
        public virtual Task<DescribeLocationObjectStorageResponse> DescribeLocationObjectStorageAsync(DescribeLocationObjectStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationObjectStorageResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationObjectStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationS3

        internal virtual DescribeLocationS3Response DescribeLocationS3(DescribeLocationS3Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationS3ResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationS3Response>(request, options);
        }



        /// <summary>
        /// Provides details about how an DataSync transfer location for an S3 bucket is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationS3 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationS3 service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationS3">REST API Reference for DescribeLocationS3 Operation</seealso>
        public virtual Task<DescribeLocationS3Response> DescribeLocationS3Async(DescribeLocationS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationS3RequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationS3ResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationS3Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocationSmb

        internal virtual DescribeLocationSmbResponse DescribeLocationSmb(DescribeLocationSmbRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationSmbResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationSmbResponse>(request, options);
        }



        /// <summary>
        /// Provides details about how an DataSync transfer location for a Server Message Block
        /// (SMB) file server is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationSmb service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationSmb">REST API Reference for DescribeLocationSmb Operation</seealso>
        public virtual Task<DescribeLocationSmbResponse> DescribeLocationSmbAsync(DescribeLocationSmbRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationSmbResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationSmbResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStorageSystem

        internal virtual DescribeStorageSystemResponse DescribeStorageSystem(DescribeStorageSystemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageSystemResponseUnmarshaller.Instance;

            return Invoke<DescribeStorageSystemResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an on-premises storage system that you're using with DataSync
        /// Discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStorageSystem service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeStorageSystem">REST API Reference for DescribeStorageSystem Operation</seealso>
        public virtual Task<DescribeStorageSystemResponse> DescribeStorageSystemAsync(DescribeStorageSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageSystemResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStorageSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStorageSystemResourceMetrics

        internal virtual DescribeStorageSystemResourceMetricsResponse DescribeStorageSystemResourceMetrics(DescribeStorageSystemResourceMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageSystemResourceMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageSystemResourceMetricsResponseUnmarshaller.Instance;

            return Invoke<DescribeStorageSystemResourceMetricsResponse>(request, options);
        }



        /// <summary>
        /// Returns information, including performance data and capacity usage, which DataSync
        /// Discovery collects about a specific resource in your-premises storage system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageSystemResourceMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStorageSystemResourceMetrics service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeStorageSystemResourceMetrics">REST API Reference for DescribeStorageSystemResourceMetrics Operation</seealso>
        public virtual Task<DescribeStorageSystemResourceMetricsResponse> DescribeStorageSystemResourceMetricsAsync(DescribeStorageSystemResourceMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageSystemResourceMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageSystemResourceMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStorageSystemResourceMetricsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStorageSystemResources

        internal virtual DescribeStorageSystemResourcesResponse DescribeStorageSystemResources(DescribeStorageSystemResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageSystemResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageSystemResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeStorageSystemResourcesResponse>(request, options);
        }



        /// <summary>
        /// Returns information that DataSync Discovery collects about resources in your on-premises
        /// storage system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageSystemResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStorageSystemResources service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeStorageSystemResources">REST API Reference for DescribeStorageSystemResources Operation</seealso>
        public virtual Task<DescribeStorageSystemResourcesResponse> DescribeStorageSystemResourcesAsync(DescribeStorageSystemResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStorageSystemResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageSystemResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStorageSystemResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTask

        internal virtual DescribeTaskResponse DescribeTask(DescribeTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskResponse>(request, options);
        }



        /// <summary>
        /// Provides information about a <i>task</i>, which defines where and how DataSync transfers
        /// your data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        public virtual Task<DescribeTaskResponse> DescribeTaskAsync(DescribeTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTaskExecution

        internal virtual DescribeTaskExecutionResponse DescribeTaskExecution(DescribeTaskExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskExecutionResponse>(request, options);
        }



        /// <summary>
        /// Provides information about an execution of your DataSync task. You can use this operation
        /// to help monitor the progress of an ongoing transfer or check the results of the transfer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTaskExecution">REST API Reference for DescribeTaskExecution Operation</seealso>
        public virtual Task<DescribeTaskExecutionResponse> DescribeTaskExecutionAsync(DescribeTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTaskExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateRecommendations

        internal virtual GenerateRecommendationsResponse GenerateRecommendations(GenerateRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GenerateRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Creates recommendations about where to migrate your data to in Amazon Web Services.
        /// Recommendations are generated based on information that DataSync Discovery collects
        /// about your on-premises storage system's resources. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-understand-recommendations.html">Recommendations
        /// provided by DataSync Discovery</a>.
        /// 
        ///  
        /// <para>
        /// Once generated, you can view your recommendations by using the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeStorageSystemResources.html">DescribeStorageSystemResources</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRecommendations service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/GenerateRecommendations">REST API Reference for GenerateRecommendations Operation</seealso>
        public virtual Task<GenerateRecommendationsResponse> GenerateRecommendationsAsync(GenerateRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAgents

        internal virtual ListAgentsResponse ListAgents(ListAgentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentsResponseUnmarshaller.Instance;

            return Invoke<ListAgentsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of DataSync agents that belong to an Amazon Web Services account in
        /// the Amazon Web Services Region specified in the request.
        /// 
        ///  
        /// <para>
        /// With pagination, you can reduce the number of agents returned in a response. If you
        /// get a truncated list of agents in a response, the response contains a marker that
        /// you can specify in your next request to fetch the next page of agents.
        /// </para>
        ///  
        /// <para>
        ///  <c>ListAgents</c> is eventually consistent. This means the result of running the
        /// operation might not reflect that you just created or deleted an agent. For example,
        /// if you create an agent with <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_CreateAgent.html">CreateAgent</a>
        /// and then immediately run <c>ListAgents</c>, that agent might not show up in the list
        /// right away. In situations like this, you can always confirm whether an agent has been
        /// created (or deleted) by using <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeAgent.html">DescribeAgent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgents service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListAgents">REST API Reference for ListAgents Operation</seealso>
        public virtual Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAgentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAgentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAgentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDiscoveryJobs

        internal virtual ListDiscoveryJobsResponse ListDiscoveryJobs(ListDiscoveryJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDiscoveryJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveryJobsResponseUnmarshaller.Instance;

            return Invoke<ListDiscoveryJobsResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of the existing discovery jobs in the Amazon Web Services Region and
        /// Amazon Web Services account where you're using DataSync Discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveryJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDiscoveryJobs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListDiscoveryJobs">REST API Reference for ListDiscoveryJobs Operation</seealso>
        public virtual Task<ListDiscoveryJobsResponse> ListDiscoveryJobsAsync(ListDiscoveryJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDiscoveryJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveryJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDiscoveryJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLocations

        internal virtual ListLocationsResponse ListLocations(ListLocationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocationsResponseUnmarshaller.Instance;

            return Invoke<ListLocationsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of source and destination locations.
        /// 
        ///  
        /// <para>
        /// If you have more locations than are returned in a response (that is, the response
        /// returns only a truncated list of your agents), the response contains a token that
        /// you can specify in your next request to fetch the next page of locations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLocations service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListLocations">REST API Reference for ListLocations Operation</seealso>
        public virtual Task<ListLocationsResponse> ListLocationsAsync(ListLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLocationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStorageSystems

        internal virtual ListStorageSystemsResponse ListStorageSystems(ListStorageSystemsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStorageSystemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageSystemsResponseUnmarshaller.Instance;

            return Invoke<ListStorageSystemsResponse>(request, options);
        }



        /// <summary>
        /// Lists the on-premises storage systems that you're using with DataSync Discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageSystems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStorageSystems service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListStorageSystems">REST API Reference for ListStorageSystems Operation</seealso>
        public virtual Task<ListStorageSystemsResponse> ListStorageSystemsAsync(ListStorageSystemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStorageSystemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageSystemsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStorageSystemsResponse>(request, options, cancellationToken);
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
        /// Returns all the tags associated with an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTaskExecutions

        internal virtual ListTaskExecutionsResponse ListTaskExecutions(ListTaskExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTaskExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListTaskExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of executions for an DataSync transfer task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTaskExecutions service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTaskExecutions">REST API Reference for ListTaskExecutions Operation</seealso>
        public virtual Task<ListTaskExecutionsResponse> ListTaskExecutionsAsync(ListTaskExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTaskExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTaskExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTaskExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTasks

        internal virtual ListTasksResponse ListTasks(ListTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return Invoke<ListTasksResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the DataSync tasks you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveStorageSystem

        internal virtual RemoveStorageSystemResponse RemoveStorageSystem(RemoveStorageSystemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveStorageSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveStorageSystemResponseUnmarshaller.Instance;

            return Invoke<RemoveStorageSystemResponse>(request, options);
        }



        /// <summary>
        /// Permanently removes a storage system resource from DataSync Discovery, including the
        /// associated discovery jobs, collected data, and recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveStorageSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveStorageSystem service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/RemoveStorageSystem">REST API Reference for RemoveStorageSystem Operation</seealso>
        public virtual Task<RemoveStorageSystemResponse> RemoveStorageSystemAsync(RemoveStorageSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveStorageSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveStorageSystemResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveStorageSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDiscoveryJob

        internal virtual StartDiscoveryJobResponse StartDiscoveryJob(StartDiscoveryJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDiscoveryJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDiscoveryJobResponseUnmarshaller.Instance;

            return Invoke<StartDiscoveryJobResponse>(request, options);
        }



        /// <summary>
        /// Runs a DataSync discovery job on your on-premises storage system. If you haven't added
        /// the storage system to DataSync Discovery yet, do this first by using the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_AddStorageSystem.html">AddStorageSystem</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDiscoveryJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDiscoveryJob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartDiscoveryJob">REST API Reference for StartDiscoveryJob Operation</seealso>
        public virtual Task<StartDiscoveryJobResponse> StartDiscoveryJobAsync(StartDiscoveryJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDiscoveryJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDiscoveryJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartDiscoveryJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartTaskExecution

        internal virtual StartTaskExecutionResponse StartTaskExecution(StartTaskExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<StartTaskExecutionResponse>(request, options);
        }



        /// <summary>
        /// Starts an DataSync transfer task. For each task, you can only run one task execution
        /// at a time.
        /// 
        ///  
        /// <para>
        /// There are several phases to a task execution. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/working-with-task-executions.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you're planning to transfer data to or from an Amazon S3 location, review <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">how
        /// DataSync can affect your S3 request charges</a> and the <a href="http://aws.amazon.com/datasync/pricing/">DataSync
        /// pricing page</a> before you begin.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTaskExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartTaskExecution">REST API Reference for StartTaskExecution Operation</seealso>
        public virtual Task<StartTaskExecutionResponse> StartTaskExecutionAsync(StartTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartTaskExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopDiscoveryJob

        internal virtual StopDiscoveryJobResponse StopDiscoveryJob(StopDiscoveryJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDiscoveryJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDiscoveryJobResponseUnmarshaller.Instance;

            return Invoke<StopDiscoveryJobResponse>(request, options);
        }



        /// <summary>
        /// Stops a running DataSync discovery job.
        /// 
        ///  
        /// <para>
        /// You can stop a discovery job anytime. A job that's stopped before it's scheduled to
        /// end likely will provide you some information about your on-premises storage system
        /// resources. To get recommendations for a stopped job, you must use the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_GenerateRecommendations.html">GenerateRecommendations</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDiscoveryJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDiscoveryJob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StopDiscoveryJob">REST API Reference for StopDiscoveryJob Operation</seealso>
        public virtual Task<StopDiscoveryJobResponse> StopDiscoveryJobAsync(StopDiscoveryJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDiscoveryJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDiscoveryJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopDiscoveryJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Applies a <i>tag</i> to an Amazon Web Services resource. Tags are key-value pairs
        /// that can help you manage, filter, and search for your resources.
        /// 
        ///  
        /// <para>
        /// These include DataSync resources, such as locations, tasks, and task executions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes tags from an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAgent

        internal virtual UpdateAgentResponse UpdateAgent(UpdateAgentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentResponseUnmarshaller.Instance;

            return Invoke<UpdateAgentResponse>(request, options);
        }



        /// <summary>
        /// Updates the name of an DataSync agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        public virtual Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAgentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAgentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAgentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDiscoveryJob

        internal virtual UpdateDiscoveryJobResponse UpdateDiscoveryJob(UpdateDiscoveryJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDiscoveryJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDiscoveryJobResponseUnmarshaller.Instance;

            return Invoke<UpdateDiscoveryJobResponse>(request, options);
        }



        /// <summary>
        /// Edits a DataSync discovery job configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDiscoveryJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDiscoveryJob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateDiscoveryJob">REST API Reference for UpdateDiscoveryJob Operation</seealso>
        public virtual Task<UpdateDiscoveryJobResponse> UpdateDiscoveryJobAsync(UpdateDiscoveryJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDiscoveryJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDiscoveryJobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDiscoveryJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLocationAzureBlob

        internal virtual UpdateLocationAzureBlobResponse UpdateLocationAzureBlob(UpdateLocationAzureBlobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationAzureBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationAzureBlobResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationAzureBlobResponse>(request, options);
        }



        /// <summary>
        /// Modifies some configurations of the Microsoft Azure Blob Storage transfer location
        /// that you're using with DataSync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationAzureBlob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationAzureBlob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationAzureBlob">REST API Reference for UpdateLocationAzureBlob Operation</seealso>
        public virtual Task<UpdateLocationAzureBlobResponse> UpdateLocationAzureBlobAsync(UpdateLocationAzureBlobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationAzureBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationAzureBlobResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLocationAzureBlobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLocationHdfs

        internal virtual UpdateLocationHdfsResponse UpdateLocationHdfs(UpdateLocationHdfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationHdfsResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationHdfsResponse>(request, options);
        }



        /// <summary>
        /// Updates some parameters of a previously created location for a Hadoop Distributed
        /// File System cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationHdfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationHdfs">REST API Reference for UpdateLocationHdfs Operation</seealso>
        public virtual Task<UpdateLocationHdfsResponse> UpdateLocationHdfsAsync(UpdateLocationHdfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationHdfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationHdfsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLocationHdfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLocationNfs

        internal virtual UpdateLocationNfsResponse UpdateLocationNfs(UpdateLocationNfsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationNfsResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationNfsResponse>(request, options);
        }



        /// <summary>
        /// Modifies some configurations of the Network File System (NFS) transfer location that
        /// you're using with DataSync.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html">Configuring
        /// transfers to or from an NFS file server</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationNfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationNfs">REST API Reference for UpdateLocationNfs Operation</seealso>
        public virtual Task<UpdateLocationNfsResponse> UpdateLocationNfsAsync(UpdateLocationNfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationNfsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationNfsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLocationNfsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLocationObjectStorage

        internal virtual UpdateLocationObjectStorageResponse UpdateLocationObjectStorage(UpdateLocationObjectStorageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationObjectStorageResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationObjectStorageResponse>(request, options);
        }



        /// <summary>
        /// Updates some parameters of an existing object storage location that DataSync accesses
        /// for a transfer. For information about creating a self-managed object storage location,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html">Creating
        /// a location for object storage</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationObjectStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationObjectStorage">REST API Reference for UpdateLocationObjectStorage Operation</seealso>
        public virtual Task<UpdateLocationObjectStorageResponse> UpdateLocationObjectStorageAsync(UpdateLocationObjectStorageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationObjectStorageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationObjectStorageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLocationObjectStorageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLocationSmb

        internal virtual UpdateLocationSmbResponse UpdateLocationSmb(UpdateLocationSmbRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationSmbResponseUnmarshaller.Instance;

            return Invoke<UpdateLocationSmbResponse>(request, options);
        }



        /// <summary>
        /// Updates some of the parameters of a Server Message Block (SMB) file server location
        /// that you can use for DataSync transfers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationSmb service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationSmb">REST API Reference for UpdateLocationSmb Operation</seealso>
        public virtual Task<UpdateLocationSmbResponse> UpdateLocationSmbAsync(UpdateLocationSmbRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLocationSmbRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLocationSmbResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLocationSmbResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStorageSystem

        internal virtual UpdateStorageSystemResponse UpdateStorageSystem(UpdateStorageSystemRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStorageSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStorageSystemResponseUnmarshaller.Instance;

            return Invoke<UpdateStorageSystemResponse>(request, options);
        }



        /// <summary>
        /// Modifies some configurations of an on-premises storage system resource that you're
        /// using with DataSync Discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStorageSystem service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateStorageSystem">REST API Reference for UpdateStorageSystem Operation</seealso>
        public virtual Task<UpdateStorageSystemResponse> UpdateStorageSystemAsync(UpdateStorageSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStorageSystemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStorageSystemResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStorageSystemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTask

        internal virtual UpdateTaskResponse UpdateTask(UpdateTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateTaskResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of a <i>task</i>, which defines where and how DataSync transfers
        /// your data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        public virtual Task<UpdateTaskResponse> UpdateTaskAsync(UpdateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTaskExecution

        internal virtual UpdateTaskExecutionResponse UpdateTaskExecution(UpdateTaskExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskExecutionResponseUnmarshaller.Instance;

            return Invoke<UpdateTaskExecutionResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of a running DataSync task execution.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, the only <c>Option</c> that you can modify with <c>UpdateTaskExecution</c>
        /// is <c> <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_Options.html#DataSync-Type-Options-BytesPerSecond">BytesPerSecond</a>
        /// </c>, which throttles bandwidth for a running or queued task execution.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTaskExecution">REST API Reference for UpdateTaskExecution Operation</seealso>
        public virtual Task<UpdateTaskExecutionResponse> UpdateTaskExecutionAsync(UpdateTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTaskExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTaskExecutionResponse>(request, options, cancellationToken);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonDataSyncEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}