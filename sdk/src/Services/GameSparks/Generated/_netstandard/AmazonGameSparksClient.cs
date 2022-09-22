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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.GameSparks.Model;
using Amazon.GameSparks.Model.Internal.MarshallTransformations;
using Amazon.GameSparks.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.GameSparks
{
    /// <summary>
    /// Implementation for accessing GameSparks
    ///
    /// 
    /// </summary>
    public partial class AmazonGameSparksClient : AmazonServiceClient, IAmazonGameSparks
    {
        private static IServiceMetadata serviceMetadata = new AmazonGameSparksMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonGameSparksClient with the credentials loaded from the application's
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
        public AmazonGameSparksClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGameSparksConfig()) { }

        /// <summary>
        /// Constructs AmazonGameSparksClient with the credentials loaded from the application's
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
        public AmazonGameSparksClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGameSparksConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGameSparksClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGameSparksClient Configuration Object</param>
        public AmazonGameSparksClient(AmazonGameSparksConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonGameSparksClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGameSparksClient(AWSCredentials credentials)
            : this(credentials, new AmazonGameSparksConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameSparksClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameSparksClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGameSparksConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameSparksClient with AWS Credentials and an
        /// AmazonGameSparksClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGameSparksClient Configuration Object</param>
        public AmazonGameSparksClient(AWSCredentials credentials, AmazonGameSparksConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGameSparksClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGameSparksClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGameSparksConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameSparksClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameSparksClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGameSparksConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameSparksClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGameSparksClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGameSparksClient Configuration Object</param>
        public AmazonGameSparksClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGameSparksConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGameSparksClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGameSparksClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGameSparksConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameSparksClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameSparksClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGameSparksConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameSparksClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGameSparksClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGameSparksClient Configuration Object</param>
        public AmazonGameSparksClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGameSparksConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IGameSparksPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IGameSparksPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new GameSparksPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonGameSparksEndpointResolver());
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


        #region  CreateGame

        internal virtual CreateGameResponse CreateGame(CreateGameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameResponseUnmarshaller.Instance;

            return Invoke<CreateGameResponse>(request, options);
        }



        /// <summary>
        /// Creates a new game with an empty configuration. After creating your game, you can
        /// update the configuration using <code>UpdateGameConfiguration</code> or <code>ImportGameConfiguration</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGame service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGame service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ServiceQuotaExceededException">
        /// The request would result in exceeding service quota.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateGame">REST API Reference for CreateGame Operation</seealso>
        public virtual Task<CreateGameResponse> CreateGameAsync(CreateGameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of the game configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStage

        internal virtual CreateStageResponse CreateStage(CreateStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return Invoke<CreateStageResponse>(request, options);
        }



        /// <summary>
        /// Creates a new stage for stage-by-stage game development and deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStage service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual Task<CreateStageResponse> CreateStageAsync(CreateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGame

        internal virtual DeleteGameResponse DeleteGame(DeleteGameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameResponseUnmarshaller.Instance;

            return Invoke<DeleteGameResponse>(request, options);
        }



        /// <summary>
        /// Deletes a game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGame service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGame service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DeleteGame">REST API Reference for DeleteGame Operation</seealso>
        public virtual Task<DeleteGameResponse> DeleteGameAsync(DeleteGameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStage

        internal virtual DeleteStageResponse DeleteStage(DeleteStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return Invoke<DeleteStageResponse>(request, options);
        }



        /// <summary>
        /// Deletes a stage from a game, along with the associated game runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStage service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual Task<DeleteStageResponse> DeleteStageAsync(DeleteStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisconnectPlayer

        internal virtual DisconnectPlayerResponse DisconnectPlayer(DisconnectPlayerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectPlayerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectPlayerResponseUnmarshaller.Instance;

            return Invoke<DisconnectPlayerResponse>(request, options);
        }



        /// <summary>
        /// Disconnects a player from the game runtime.
        /// 
        ///  
        /// <para>
        ///  If a player has multiple connections, this operation attempts to close all of them.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectPlayer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisconnectPlayer service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DisconnectPlayer">REST API Reference for DisconnectPlayer Operation</seealso>
        public virtual Task<DisconnectPlayerResponse> DisconnectPlayerAsync(DisconnectPlayerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectPlayerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectPlayerResponseUnmarshaller.Instance;

            return InvokeAsync<DisconnectPlayerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportSnapshot

        internal virtual ExportSnapshotResponse ExportSnapshot(ExportSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportSnapshotResponseUnmarshaller.Instance;

            return Invoke<ExportSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Exports a game configuration snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportSnapshot service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ExportSnapshot">REST API Reference for ExportSnapshot Operation</seealso>
        public virtual Task<ExportSnapshotResponse> ExportSnapshotAsync(ExportSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<ExportSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetExtension

        internal virtual GetExtensionResponse GetExtension(GetExtensionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExtensionResponseUnmarshaller.Instance;

            return Invoke<GetExtensionResponse>(request, options);
        }



        /// <summary>
        /// Gets details about a specified extension.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExtension service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExtension service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetExtension">REST API Reference for GetExtension Operation</seealso>
        public virtual Task<GetExtensionResponse> GetExtensionAsync(GetExtensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExtensionResponseUnmarshaller.Instance;

            return InvokeAsync<GetExtensionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetExtensionVersion

        internal virtual GetExtensionVersionResponse GetExtensionVersion(GetExtensionVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExtensionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExtensionVersionResponseUnmarshaller.Instance;

            return Invoke<GetExtensionVersionResponse>(request, options);
        }



        /// <summary>
        /// Gets details about a specified extension version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExtensionVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExtensionVersion service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetExtensionVersion">REST API Reference for GetExtensionVersion Operation</seealso>
        public virtual Task<GetExtensionVersionResponse> GetExtensionVersionAsync(GetExtensionVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExtensionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExtensionVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetExtensionVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGame

        internal virtual GetGameResponse GetGame(GetGameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameResponseUnmarshaller.Instance;

            return Invoke<GetGameResponse>(request, options);
        }



        /// <summary>
        /// Gets details about a game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGame service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGame service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGame">REST API Reference for GetGame Operation</seealso>
        public virtual Task<GetGameResponse> GetGameAsync(GetGameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameResponseUnmarshaller.Instance;

            return InvokeAsync<GetGameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGameConfiguration

        internal virtual GetGameConfigurationResponse GetGameConfiguration(GetGameConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetGameConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets the configuration of the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGameConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGameConfiguration service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGameConfiguration">REST API Reference for GetGameConfiguration Operation</seealso>
        public virtual Task<GetGameConfigurationResponse> GetGameConfigurationAsync(GetGameConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetGameConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGeneratedCodeJob

        internal virtual GetGeneratedCodeJobResponse GetGeneratedCodeJob(GetGeneratedCodeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGeneratedCodeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeneratedCodeJobResponseUnmarshaller.Instance;

            return Invoke<GetGeneratedCodeJobResponse>(request, options);
        }



        /// <summary>
        /// Gets details about a job that is generating code for a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedCodeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGeneratedCodeJob service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGeneratedCodeJob">REST API Reference for GetGeneratedCodeJob Operation</seealso>
        public virtual Task<GetGeneratedCodeJobResponse> GetGeneratedCodeJobAsync(GetGeneratedCodeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGeneratedCodeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeneratedCodeJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetGeneratedCodeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPlayerConnectionStatus

        internal virtual GetPlayerConnectionStatusResponse GetPlayerConnectionStatus(GetPlayerConnectionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlayerConnectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlayerConnectionStatusResponseUnmarshaller.Instance;

            return Invoke<GetPlayerConnectionStatusResponse>(request, options);
        }



        /// <summary>
        /// Gets the status of a player's connection to the game runtime.
        /// 
        ///  
        /// <para>
        ///  It's possible for a single player to have multiple connections to the game runtime.
        /// If a player is not connected, this operation returns an empty list. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlayerConnectionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlayerConnectionStatus service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetPlayerConnectionStatus">REST API Reference for GetPlayerConnectionStatus Operation</seealso>
        public virtual Task<GetPlayerConnectionStatusResponse> GetPlayerConnectionStatusAsync(GetPlayerConnectionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlayerConnectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlayerConnectionStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetPlayerConnectionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSnapshot

        internal virtual GetSnapshotResponse GetSnapshot(GetSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Gets a copy of the game configuration in a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSnapshot service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        public virtual Task<GetSnapshotResponse> GetSnapshotAsync(GetSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<GetSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStage

        internal virtual GetStageResponse GetStage(GetStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return Invoke<GetStageResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStage service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual Task<GetStageResponse> GetStageAsync(GetStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return InvokeAsync<GetStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStageDeployment

        internal virtual GetStageDeploymentResponse GetStageDeployment(GetStageDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetStageDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a stage deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStageDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStageDeployment service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetStageDeployment">REST API Reference for GetStageDeployment Operation</seealso>
        public virtual Task<GetStageDeploymentResponse> GetStageDeploymentAsync(GetStageDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetStageDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportGameConfiguration

        internal virtual ImportGameConfigurationResponse ImportGameConfiguration(ImportGameConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportGameConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportGameConfigurationResponseUnmarshaller.Instance;

            return Invoke<ImportGameConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Imports a game configuration.
        /// 
        ///  
        /// <para>
        ///  This operation replaces the current configuration of the game with the provided input.
        /// This is not a reversible operation. If you want to preserve the previous configuration,
        /// use <code>CreateSnapshot</code> to make a new snapshot before importing. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportGameConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportGameConfiguration service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ServiceQuotaExceededException">
        /// The request would result in exceeding service quota.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ImportGameConfiguration">REST API Reference for ImportGameConfiguration Operation</seealso>
        public virtual Task<ImportGameConfigurationResponse> ImportGameConfigurationAsync(ImportGameConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportGameConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportGameConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ImportGameConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExtensions

        internal virtual ListExtensionsResponse ListExtensions(ListExtensionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExtensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensionsResponseUnmarshaller.Instance;

            return Invoke<ListExtensionsResponse>(request, options);
        }



        /// <summary>
        /// Gets a paginated list of available extensions.
        /// 
        ///  
        /// <para>
        ///  Extensions provide features that games can use from scripts. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExtensions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExtensions service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListExtensions">REST API Reference for ListExtensions Operation</seealso>
        public virtual Task<ListExtensionsResponse> ListExtensionsAsync(ListExtensionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExtensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExtensionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExtensionVersions

        internal virtual ListExtensionVersionsResponse ListExtensionVersions(ListExtensionVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExtensionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListExtensionVersionsResponse>(request, options);
        }



        /// <summary>
        /// Gets a paginated list of available versions for the extension.
        /// 
        ///  
        /// <para>
        ///  Each time an API change is made to an extension, the version is incremented. The
        /// list retrieved by this operation shows the versions that are currently available.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExtensionVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExtensionVersions service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListExtensionVersions">REST API Reference for ListExtensionVersions Operation</seealso>
        public virtual Task<ListExtensionVersionsResponse> ListExtensionVersionsAsync(ListExtensionVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExtensionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensionVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExtensionVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGames

        internal virtual ListGamesResponse ListGames(ListGamesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGamesResponseUnmarshaller.Instance;

            return Invoke<ListGamesResponse>(request, options);
        }



        /// <summary>
        /// Gets a paginated list of games.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGames service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListGames">REST API Reference for ListGames Operation</seealso>
        public virtual Task<ListGamesResponse> ListGamesAsync(ListGamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGamesResponseUnmarshaller.Instance;

            return InvokeAsync<ListGamesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGeneratedCodeJobs

        internal virtual ListGeneratedCodeJobsResponse ListGeneratedCodeJobs(ListGeneratedCodeJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGeneratedCodeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeneratedCodeJobsResponseUnmarshaller.Instance;

            return Invoke<ListGeneratedCodeJobsResponse>(request, options);
        }



        /// <summary>
        /// Gets a paginated list of code generation jobs for a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeneratedCodeJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGeneratedCodeJobs service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListGeneratedCodeJobs">REST API Reference for ListGeneratedCodeJobs Operation</seealso>
        public virtual Task<ListGeneratedCodeJobsResponse> ListGeneratedCodeJobsAsync(ListGeneratedCodeJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGeneratedCodeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeneratedCodeJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGeneratedCodeJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSnapshots

        internal virtual ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Gets a paginated list of snapshot summaries from the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSnapshots service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        public virtual Task<ListSnapshotsResponse> ListSnapshotsAsync(ListSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStageDeployments

        internal virtual ListStageDeploymentsResponse ListStageDeployments(ListStageDeploymentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStageDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStageDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListStageDeploymentsResponse>(request, options);
        }



        /// <summary>
        /// Gets a paginated list of stage deployment summaries from the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStageDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStageDeployments service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListStageDeployments">REST API Reference for ListStageDeployments Operation</seealso>
        public virtual Task<ListStageDeploymentsResponse> ListStageDeploymentsAsync(ListStageDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStageDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStageDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStageDeploymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStages

        internal virtual ListStagesResponse ListStages(ListStagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStagesResponseUnmarshaller.Instance;

            return Invoke<ListStagesResponse>(request, options);
        }



        /// <summary>
        /// Gets a paginated list of stage summaries from the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStages service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListStages">REST API Reference for ListStages Operation</seealso>
        public virtual Task<ListStagesResponse> ListStagesAsync(ListStagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListStagesResponse>(request, options, cancellationToken);
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
        /// Lists the tags associated with a GameSparks resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartGeneratedCodeJob

        internal virtual StartGeneratedCodeJobResponse StartGeneratedCodeJob(StartGeneratedCodeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGeneratedCodeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGeneratedCodeJobResponseUnmarshaller.Instance;

            return Invoke<StartGeneratedCodeJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous process that generates client code for system-defined and
        /// custom messages. The resulting code is collected as a .zip file and uploaded to a
        /// pre-signed Amazon S3 URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGeneratedCodeJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartGeneratedCodeJob service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/StartGeneratedCodeJob">REST API Reference for StartGeneratedCodeJob Operation</seealso>
        public virtual Task<StartGeneratedCodeJobResponse> StartGeneratedCodeJobAsync(StartGeneratedCodeJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGeneratedCodeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGeneratedCodeJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartGeneratedCodeJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartStageDeployment

        internal virtual StartStageDeploymentResponse StartStageDeployment(StartStageDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStageDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStageDeploymentResponseUnmarshaller.Instance;

            return Invoke<StartStageDeploymentResponse>(request, options);
        }



        /// <summary>
        /// Deploys a snapshot to the stage and creates a new game runtime.
        /// 
        ///  
        /// <para>
        ///  After you call this operation, you can check the deployment status by using <code>GetStageDeployment</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If there are any players connected to the previous game runtime, then both runtimes
        /// persist. Existing connections to the previous runtime are maintained. When players
        /// disconnect and reconnect, they connect to the new runtime. After there are no connections
        /// to the previous game runtime, it is deleted. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStageDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartStageDeployment service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ConflictException">
        /// The resource already exists, or another operation is in progress.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/StartStageDeployment">REST API Reference for StartStageDeployment Operation</seealso>
        public virtual Task<StartStageDeploymentResponse> StartStageDeploymentAsync(StartStageDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStageDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStageDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<StartStageDeploymentResponse>(request, options, cancellationToken);
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
        /// Adds tags to a GameSparks resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from a GameSparks resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGame

        internal virtual UpdateGameResponse UpdateGame(UpdateGameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameResponseUnmarshaller.Instance;

            return Invoke<UpdateGameResponse>(request, options);
        }



        /// <summary>
        /// Updates details of the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGame service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGame service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateGame">REST API Reference for UpdateGame Operation</seealso>
        public virtual Task<UpdateGameResponse> UpdateGameAsync(UpdateGameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGameConfiguration

        internal virtual UpdateGameConfigurationResponse UpdateGameConfiguration(UpdateGameConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateGameConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates one or more sections of the game configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGameConfiguration service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ServiceQuotaExceededException">
        /// The request would result in exceeding service quota.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateGameConfiguration">REST API Reference for UpdateGameConfiguration Operation</seealso>
        public virtual Task<UpdateGameConfigurationResponse> UpdateGameConfigurationAsync(UpdateGameConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSnapshot

        internal virtual UpdateSnapshotResponse UpdateSnapshot(UpdateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotResponseUnmarshaller.Instance;

            return Invoke<UpdateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Updates the metadata of a GameSparks snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSnapshot service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        public virtual Task<UpdateSnapshotResponse> UpdateSnapshotAsync(UpdateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStage

        internal virtual UpdateStageResponse UpdateStage(UpdateStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return Invoke<UpdateStageResponse>(request, options);
        }



        /// <summary>
        /// Updates the metadata of a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStage service method, as returned by GameSparks.</returns>
        /// <exception cref="Amazon.GameSparks.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.InternalServerException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ThrottlingException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.GameSparks.Model.ValidationException">
        /// One of the parameters in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual Task<UpdateStageResponse> UpdateStageAsync(UpdateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}