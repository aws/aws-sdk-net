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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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

        /// <summary>
        /// Creates a new game with an empty configuration. After creating your game, you can
        /// update the configuration using <code>UpdateGameConfiguration</code> or <code>ImportGameConfiguration</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGame service method.</param>
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
        public virtual CreateGameResponse CreateGame(CreateGameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameResponseUnmarshaller.Instance;

            return Invoke<CreateGameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGame operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGame operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGame
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateGame">REST API Reference for CreateGame Operation</seealso>
        public virtual IAsyncResult BeginCreateGame(CreateGameRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGame operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGame.</param>
        /// 
        /// <returns>Returns a  CreateGameResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateGame">REST API Reference for CreateGame Operation</seealso>
        public virtual CreateGameResponse EndCreateGame(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGameResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSnapshot

        /// <summary>
        /// Creates a snapshot of the game configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
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
        public virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStage

        /// <summary>
        /// Creates a new stage for stage-by-stage game development and deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
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
        public virtual CreateStageResponse CreateStage(CreateStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return Invoke<CreateStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStage operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual IAsyncResult BeginCreateStage(CreateStageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStage.</param>
        /// 
        /// <returns>Returns a  CreateStageResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual CreateStageResponse EndCreateStage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGame

        /// <summary>
        /// Deletes a game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGame service method.</param>
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
        public virtual DeleteGameResponse DeleteGame(DeleteGameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameResponseUnmarshaller.Instance;

            return Invoke<DeleteGameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGame operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGame operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGame
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DeleteGame">REST API Reference for DeleteGame Operation</seealso>
        public virtual IAsyncResult BeginDeleteGame(DeleteGameRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGame operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGame.</param>
        /// 
        /// <returns>Returns a  DeleteGameResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DeleteGame">REST API Reference for DeleteGame Operation</seealso>
        public virtual DeleteGameResponse EndDeleteGame(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGameResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStage

        /// <summary>
        /// Deletes a stage from a game, along with the associated game runtime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
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
        public virtual DeleteStageResponse DeleteStage(DeleteStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return Invoke<DeleteStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual IAsyncResult BeginDeleteStage(DeleteStageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStage.</param>
        /// 
        /// <returns>Returns a  DeleteStageResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual DeleteStageResponse EndDeleteStage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStageResponse>(asyncResult);
        }

        #endregion
        
        #region  DisconnectPlayer

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
        public virtual DisconnectPlayerResponse DisconnectPlayer(DisconnectPlayerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectPlayerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectPlayerResponseUnmarshaller.Instance;

            return Invoke<DisconnectPlayerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisconnectPlayer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisconnectPlayer operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisconnectPlayer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DisconnectPlayer">REST API Reference for DisconnectPlayer Operation</seealso>
        public virtual IAsyncResult BeginDisconnectPlayer(DisconnectPlayerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectPlayerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectPlayerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisconnectPlayer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisconnectPlayer.</param>
        /// 
        /// <returns>Returns a  DisconnectPlayerResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/DisconnectPlayer">REST API Reference for DisconnectPlayer Operation</seealso>
        public virtual DisconnectPlayerResponse EndDisconnectPlayer(IAsyncResult asyncResult)
        {
            return EndInvoke<DisconnectPlayerResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportSnapshot

        /// <summary>
        /// Exports a game configuration snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportSnapshot service method.</param>
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
        public virtual ExportSnapshotResponse ExportSnapshot(ExportSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportSnapshotResponseUnmarshaller.Instance;

            return Invoke<ExportSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportSnapshot operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ExportSnapshot">REST API Reference for ExportSnapshot Operation</seealso>
        public virtual IAsyncResult BeginExportSnapshot(ExportSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportSnapshot.</param>
        /// 
        /// <returns>Returns a  ExportSnapshotResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ExportSnapshot">REST API Reference for ExportSnapshot Operation</seealso>
        public virtual ExportSnapshotResponse EndExportSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  GetExtension

        /// <summary>
        /// Gets details about a specified extension.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExtension service method.</param>
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
        public virtual GetExtensionResponse GetExtension(GetExtensionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExtensionResponseUnmarshaller.Instance;

            return Invoke<GetExtensionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExtension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExtension operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExtension
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetExtension">REST API Reference for GetExtension Operation</seealso>
        public virtual IAsyncResult BeginGetExtension(GetExtensionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExtensionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExtension operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExtension.</param>
        /// 
        /// <returns>Returns a  GetExtensionResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetExtension">REST API Reference for GetExtension Operation</seealso>
        public virtual GetExtensionResponse EndGetExtension(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExtensionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetExtensionVersion

        /// <summary>
        /// Gets details about a specified extension version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExtensionVersion service method.</param>
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
        public virtual GetExtensionVersionResponse GetExtensionVersion(GetExtensionVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExtensionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExtensionVersionResponseUnmarshaller.Instance;

            return Invoke<GetExtensionVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExtensionVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExtensionVersion operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExtensionVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetExtensionVersion">REST API Reference for GetExtensionVersion Operation</seealso>
        public virtual IAsyncResult BeginGetExtensionVersion(GetExtensionVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetExtensionVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExtensionVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExtensionVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExtensionVersion.</param>
        /// 
        /// <returns>Returns a  GetExtensionVersionResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetExtensionVersion">REST API Reference for GetExtensionVersion Operation</seealso>
        public virtual GetExtensionVersionResponse EndGetExtensionVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExtensionVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGame

        /// <summary>
        /// Gets details about a game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGame service method.</param>
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
        public virtual GetGameResponse GetGame(GetGameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameResponseUnmarshaller.Instance;

            return Invoke<GetGameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGame operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGame operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGame
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGame">REST API Reference for GetGame Operation</seealso>
        public virtual IAsyncResult BeginGetGame(GetGameRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGame operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGame.</param>
        /// 
        /// <returns>Returns a  GetGameResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGame">REST API Reference for GetGame Operation</seealso>
        public virtual GetGameResponse EndGetGame(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGameResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGameConfiguration

        /// <summary>
        /// Gets the configuration of the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGameConfiguration service method.</param>
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
        public virtual GetGameConfigurationResponse GetGameConfiguration(GetGameConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetGameConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGameConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGameConfiguration operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGameConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGameConfiguration">REST API Reference for GetGameConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetGameConfiguration(GetGameConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGameConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGameConfiguration.</param>
        /// 
        /// <returns>Returns a  GetGameConfigurationResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGameConfiguration">REST API Reference for GetGameConfiguration Operation</seealso>
        public virtual GetGameConfigurationResponse EndGetGameConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGameConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGeneratedCodeJob

        /// <summary>
        /// Gets details about a job that is generating code for a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedCodeJob service method.</param>
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
        public virtual GetGeneratedCodeJobResponse GetGeneratedCodeJob(GetGeneratedCodeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGeneratedCodeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeneratedCodeJobResponseUnmarshaller.Instance;

            return Invoke<GetGeneratedCodeJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGeneratedCodeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGeneratedCodeJob operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGeneratedCodeJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGeneratedCodeJob">REST API Reference for GetGeneratedCodeJob Operation</seealso>
        public virtual IAsyncResult BeginGetGeneratedCodeJob(GetGeneratedCodeJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGeneratedCodeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGeneratedCodeJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGeneratedCodeJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGeneratedCodeJob.</param>
        /// 
        /// <returns>Returns a  GetGeneratedCodeJobResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetGeneratedCodeJob">REST API Reference for GetGeneratedCodeJob Operation</seealso>
        public virtual GetGeneratedCodeJobResponse EndGetGeneratedCodeJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGeneratedCodeJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPlayerConnectionStatus

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
        public virtual GetPlayerConnectionStatusResponse GetPlayerConnectionStatus(GetPlayerConnectionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlayerConnectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlayerConnectionStatusResponseUnmarshaller.Instance;

            return Invoke<GetPlayerConnectionStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlayerConnectionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlayerConnectionStatus operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlayerConnectionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetPlayerConnectionStatus">REST API Reference for GetPlayerConnectionStatus Operation</seealso>
        public virtual IAsyncResult BeginGetPlayerConnectionStatus(GetPlayerConnectionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlayerConnectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlayerConnectionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlayerConnectionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlayerConnectionStatus.</param>
        /// 
        /// <returns>Returns a  GetPlayerConnectionStatusResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetPlayerConnectionStatus">REST API Reference for GetPlayerConnectionStatus Operation</seealso>
        public virtual GetPlayerConnectionStatusResponse EndGetPlayerConnectionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPlayerConnectionStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSnapshot

        /// <summary>
        /// Gets a copy of the game configuration in a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshot service method.</param>
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
        public virtual GetSnapshotResponse GetSnapshot(GetSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshot operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        public virtual IAsyncResult BeginGetSnapshot(GetSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSnapshot.</param>
        /// 
        /// <returns>Returns a  GetSnapshotResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        public virtual GetSnapshotResponse EndGetSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStage

        /// <summary>
        /// Gets information about a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
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
        public virtual GetStageResponse GetStage(GetStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return Invoke<GetStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStage operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual IAsyncResult BeginGetStage(GetStageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStage.</param>
        /// 
        /// <returns>Returns a  GetStageResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual GetStageResponse EndGetStage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStageDeployment

        /// <summary>
        /// Gets information about a stage deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStageDeployment service method.</param>
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
        public virtual GetStageDeploymentResponse GetStageDeployment(GetStageDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetStageDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStageDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStageDeployment operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStageDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetStageDeployment">REST API Reference for GetStageDeployment Operation</seealso>
        public virtual IAsyncResult BeginGetStageDeployment(GetStageDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStageDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStageDeployment.</param>
        /// 
        /// <returns>Returns a  GetStageDeploymentResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/GetStageDeployment">REST API Reference for GetStageDeployment Operation</seealso>
        public virtual GetStageDeploymentResponse EndGetStageDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStageDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportGameConfiguration

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
        public virtual ImportGameConfigurationResponse ImportGameConfiguration(ImportGameConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportGameConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportGameConfigurationResponseUnmarshaller.Instance;

            return Invoke<ImportGameConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportGameConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportGameConfiguration operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportGameConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ImportGameConfiguration">REST API Reference for ImportGameConfiguration Operation</seealso>
        public virtual IAsyncResult BeginImportGameConfiguration(ImportGameConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportGameConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportGameConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportGameConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportGameConfiguration.</param>
        /// 
        /// <returns>Returns a  ImportGameConfigurationResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ImportGameConfiguration">REST API Reference for ImportGameConfiguration Operation</seealso>
        public virtual ImportGameConfigurationResponse EndImportGameConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportGameConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExtensions

        /// <summary>
        /// Gets a paginated list of available extensions.
        /// 
        ///  
        /// <para>
        ///  Extensions provide features that games can use from scripts. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExtensions service method.</param>
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
        public virtual ListExtensionsResponse ListExtensions(ListExtensionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExtensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensionsResponseUnmarshaller.Instance;

            return Invoke<ListExtensionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExtensions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExtensions operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExtensions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListExtensions">REST API Reference for ListExtensions Operation</seealso>
        public virtual IAsyncResult BeginListExtensions(ListExtensionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExtensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExtensions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExtensions.</param>
        /// 
        /// <returns>Returns a  ListExtensionsResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListExtensions">REST API Reference for ListExtensions Operation</seealso>
        public virtual ListExtensionsResponse EndListExtensions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExtensionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListExtensionVersions

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
        public virtual ListExtensionVersionsResponse ListExtensionVersions(ListExtensionVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExtensionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensionVersionsResponseUnmarshaller.Instance;

            return Invoke<ListExtensionVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListExtensionVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExtensionVersions operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExtensionVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListExtensionVersions">REST API Reference for ListExtensionVersions Operation</seealso>
        public virtual IAsyncResult BeginListExtensionVersions(ListExtensionVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExtensionVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExtensionVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListExtensionVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExtensionVersions.</param>
        /// 
        /// <returns>Returns a  ListExtensionVersionsResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListExtensionVersions">REST API Reference for ListExtensionVersions Operation</seealso>
        public virtual ListExtensionVersionsResponse EndListExtensionVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListExtensionVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGames

        /// <summary>
        /// Gets a paginated list of games.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGames service method.</param>
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
        public virtual ListGamesResponse ListGames(ListGamesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGamesResponseUnmarshaller.Instance;

            return Invoke<ListGamesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGames operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListGames">REST API Reference for ListGames Operation</seealso>
        public virtual IAsyncResult BeginListGames(ListGamesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGamesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGames.</param>
        /// 
        /// <returns>Returns a  ListGamesResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListGames">REST API Reference for ListGames Operation</seealso>
        public virtual ListGamesResponse EndListGames(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGamesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGeneratedCodeJobs

        /// <summary>
        /// Gets a paginated list of code generation jobs for a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGeneratedCodeJobs service method.</param>
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
        public virtual ListGeneratedCodeJobsResponse ListGeneratedCodeJobs(ListGeneratedCodeJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGeneratedCodeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeneratedCodeJobsResponseUnmarshaller.Instance;

            return Invoke<ListGeneratedCodeJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGeneratedCodeJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGeneratedCodeJobs operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGeneratedCodeJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListGeneratedCodeJobs">REST API Reference for ListGeneratedCodeJobs Operation</seealso>
        public virtual IAsyncResult BeginListGeneratedCodeJobs(ListGeneratedCodeJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGeneratedCodeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGeneratedCodeJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGeneratedCodeJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGeneratedCodeJobs.</param>
        /// 
        /// <returns>Returns a  ListGeneratedCodeJobsResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListGeneratedCodeJobs">REST API Reference for ListGeneratedCodeJobs Operation</seealso>
        public virtual ListGeneratedCodeJobsResponse EndListGeneratedCodeJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGeneratedCodeJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSnapshots

        /// <summary>
        /// Gets a paginated list of snapshot summaries from the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshots service method.</param>
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
        public virtual ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListSnapshotsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshots operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        public virtual IAsyncResult BeginListSnapshots(ListSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSnapshots.</param>
        /// 
        /// <returns>Returns a  ListSnapshotsResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        public virtual ListSnapshotsResponse EndListSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStageDeployments

        /// <summary>
        /// Gets a paginated list of stage deployment summaries from the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStageDeployments service method.</param>
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
        public virtual ListStageDeploymentsResponse ListStageDeployments(ListStageDeploymentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStageDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStageDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListStageDeploymentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStageDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStageDeployments operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStageDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListStageDeployments">REST API Reference for ListStageDeployments Operation</seealso>
        public virtual IAsyncResult BeginListStageDeployments(ListStageDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStageDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStageDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStageDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStageDeployments.</param>
        /// 
        /// <returns>Returns a  ListStageDeploymentsResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListStageDeployments">REST API Reference for ListStageDeployments Operation</seealso>
        public virtual ListStageDeploymentsResponse EndListStageDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStageDeploymentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStages

        /// <summary>
        /// Gets a paginated list of stage summaries from the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStages service method.</param>
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
        public virtual ListStagesResponse ListStages(ListStagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStagesResponseUnmarshaller.Instance;

            return Invoke<ListStagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStages operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListStages">REST API Reference for ListStages Operation</seealso>
        public virtual IAsyncResult BeginListStages(ListStagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStages.</param>
        /// 
        /// <returns>Returns a  ListStagesResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListStages">REST API Reference for ListStages Operation</seealso>
        public virtual ListStagesResponse EndListStages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags associated with a GameSparks resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartGeneratedCodeJob

        /// <summary>
        /// Starts an asynchronous process that generates client code for system-defined and
        /// custom messages. The resulting code is collected as a .zip file and uploaded to a
        /// pre-signed Amazon S3 URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGeneratedCodeJob service method.</param>
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
        public virtual StartGeneratedCodeJobResponse StartGeneratedCodeJob(StartGeneratedCodeJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGeneratedCodeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGeneratedCodeJobResponseUnmarshaller.Instance;

            return Invoke<StartGeneratedCodeJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartGeneratedCodeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGeneratedCodeJob operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartGeneratedCodeJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/StartGeneratedCodeJob">REST API Reference for StartGeneratedCodeJob Operation</seealso>
        public virtual IAsyncResult BeginStartGeneratedCodeJob(StartGeneratedCodeJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGeneratedCodeJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGeneratedCodeJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartGeneratedCodeJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartGeneratedCodeJob.</param>
        /// 
        /// <returns>Returns a  StartGeneratedCodeJobResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/StartGeneratedCodeJob">REST API Reference for StartGeneratedCodeJob Operation</seealso>
        public virtual StartGeneratedCodeJobResponse EndStartGeneratedCodeJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartGeneratedCodeJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartStageDeployment

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
        public virtual StartStageDeploymentResponse StartStageDeployment(StartStageDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStageDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStageDeploymentResponseUnmarshaller.Instance;

            return Invoke<StartStageDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartStageDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStageDeployment operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartStageDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/StartStageDeployment">REST API Reference for StartStageDeployment Operation</seealso>
        public virtual IAsyncResult BeginStartStageDeployment(StartStageDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStageDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStageDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartStageDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartStageDeployment.</param>
        /// 
        /// <returns>Returns a  StartStageDeploymentResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/StartStageDeployment">REST API Reference for StartStageDeployment Operation</seealso>
        public virtual StartStageDeploymentResponse EndStartStageDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<StartStageDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds tags to a GameSparks resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a GameSparks resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGame

        /// <summary>
        /// Updates details of the game.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGame service method.</param>
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
        public virtual UpdateGameResponse UpdateGame(UpdateGameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameResponseUnmarshaller.Instance;

            return Invoke<UpdateGameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGame operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGame operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGame
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateGame">REST API Reference for UpdateGame Operation</seealso>
        public virtual IAsyncResult BeginUpdateGame(UpdateGameRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGame operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGame.</param>
        /// 
        /// <returns>Returns a  UpdateGameResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateGame">REST API Reference for UpdateGame Operation</seealso>
        public virtual UpdateGameResponse EndUpdateGame(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGameResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGameConfiguration

        /// <summary>
        /// Updates one or more sections of the game configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameConfiguration service method.</param>
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
        public virtual UpdateGameConfigurationResponse UpdateGameConfiguration(UpdateGameConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateGameConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGameConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameConfiguration operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGameConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateGameConfiguration">REST API Reference for UpdateGameConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateGameConfiguration(UpdateGameConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGameConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGameConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateGameConfigurationResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateGameConfiguration">REST API Reference for UpdateGameConfiguration Operation</seealso>
        public virtual UpdateGameConfigurationResponse EndUpdateGameConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGameConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSnapshot

        /// <summary>
        /// Updates the metadata of a GameSparks snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot service method.</param>
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
        public virtual UpdateSnapshotResponse UpdateSnapshot(UpdateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotResponseUnmarshaller.Instance;

            return Invoke<UpdateSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        public virtual IAsyncResult BeginUpdateSnapshot(UpdateSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSnapshot.</param>
        /// 
        /// <returns>Returns a  UpdateSnapshotResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        public virtual UpdateSnapshotResponse EndUpdateSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStage

        /// <summary>
        /// Updates the metadata of a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
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
        public virtual UpdateStageResponse UpdateStage(UpdateStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return Invoke<UpdateStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage operation on AmazonGameSparksClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual IAsyncResult BeginUpdateStage(UpdateStageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStage.</param>
        /// 
        /// <returns>Returns a  UpdateStageResult from GameSparks.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamesparks-2021-08-17/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual UpdateStageResponse EndUpdateStage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStageResponse>(asyncResult);
        }

        #endregion
        
    }
}