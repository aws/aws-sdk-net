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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IVSRealTime.Model;
using Amazon.IVSRealTime.Model.Internal.MarshallTransformations;
using Amazon.IVSRealTime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.IVSRealTime
{
    /// <summary>
    /// <para>Implementation for accessing IVSRealTime</para>
    ///
    /// <b>Introduction</b> 
    /// 
    ///  
    /// <para>
    /// The Amazon Interactive Video Service (IVS) real-time API is REST compatible, using
    /// a standard HTTP API and an AWS EventBridge event stream for responses. JSON is used
    /// for both requests and responses, including errors. 
    /// </para>
    ///  
    /// <para>
    /// Terminology:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A <i>stage</i> is a virtual space where participants can exchange video in real time.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <i>participant token</i> is a token that authenticates a participant when they join
    /// a stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <i>participant object</i> represents participants (people) in the stage and contains
    /// information about them. When a token is created, it includes a participant ID; when
    /// a participant uses that token to join a stage, the participant is associated with
    /// that participant ID. There is a 1:1 mapping between participant tokens and participants.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Server-side composition: The <i>composition</i> process composites participants of
    /// a stage into a single video and forwards it to a set of outputs (e.g., IVS channels).
    /// Composition endpoints support this process.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Server-side composition: A <i>composition</i> controls the look of the outputs, including
    /// how participants are positioned in the video.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// The following resources contain information about your IVS live stream (see <a href="https://docs.aws.amazon.com/ivs/latest/RealTimeUserGuide/getting-started.html">Getting
    /// Started with Amazon IVS Real-Time Streaming</a>):
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Stage</b> — A stage is a virtual space where participants can exchange video in
    /// real time.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tagging</b> 
    /// </para>
    ///  
    /// <para>
    /// A <i>tag</i> is a metadata label that you assign to an AWS resource. A tag comprises
    /// a <i>key</i> and a <i>value</i>, both set by you. For example, you might set a tag
    /// as <c>topic:nature</c> to label a particular video category. See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
    /// AWS Resources</a> for more information, including restrictions that apply to tags
    /// and "Tag naming limits and requirements"; Amazon IVS stages has no service-specific
    /// constraints beyond what is documented there.
    /// </para>
    ///  
    /// <para>
    /// Tags can help you identify and organize your AWS resources. For example, you can use
    /// the same tag for different resources to indicate that they are related. You can also
    /// use tags to manage access (see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Access
    /// Tags</a>).
    /// </para>
    ///  
    /// <para>
    /// The Amazon IVS real-time API has these tag-related endpoints: <a>TagResource</a>,
    /// <a>UntagResource</a>, and <a>ListTagsForResource</a>. The following resource supports
    /// tagging: Stage.
    /// </para>
    ///  
    /// <para>
    /// At most 50 tags can be applied to a resource.
    /// </para>
    ///  
    /// <para>
    ///  <b>Stages Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateParticipantToken</a> — Creates an additional token for a specified stage.
    /// This can be done after stage creation or when tokens expire.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateStage</a> — Creates a new stage (and optionally participant tokens).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteStage</a> — Shuts down and deletes the specified stage (disconnecting all
    /// participants).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisconnectParticipant</a> — Disconnects a specified participant and revokes the
    /// participant permanently from a specified stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetParticipant</a> — Gets information about the specified participant token.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetStage</a> — Gets information for the specified stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetStageSession</a> — Gets information for the specified stage session.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListParticipantEvents</a> — Lists events for a specified participant that occurred
    /// during a specified stage session.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListParticipants</a> — Lists all participants in a specified stage session.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStages</a> — Gets summary information about all stages in your account, in
    /// the AWS region where the API request is processed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStageSessions</a> — Gets all sessions for a specified stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateStage</a> — Updates a stage’s configuration.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Composition Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GetComposition</a> — Gets information about the specified Composition resource.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListCompositions</a> — Gets summary information about all Compositions in your
    /// account, in the AWS region where the API request is processed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartComposition</a> — Starts a Composition from a stage based on the configuration
    /// provided in the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopComposition</a> — Stops and deletes a Composition resource. Any broadcast
    /// from the Composition resource is stopped.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>EncoderConfiguration Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateEncoderConfiguration</a> — Creates an EncoderConfiguration object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteEncoderConfiguration</a> — Deletes an EncoderConfiguration resource. Ensures
    /// that no Compositions are using this template; otherwise, returns an error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetEncoderConfiguration</a> — Gets information about the specified EncoderConfiguration
    /// resource.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListEncoderConfigurations</a> — Gets summary information about all EncoderConfigurations
    /// in your account, in the AWS region where the API request is processed.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>StorageConfiguration Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateStorageConfiguration</a> — Creates a new storage configuration, used to
    /// enable recording to Amazon S3.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteStorageConfiguration</a> — Deletes the storage configuration for the specified
    /// ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetStorageConfiguration</a> — Gets the storage configuration for the specified
    /// ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStorageConfigurations</a> — Gets summary information about all storage configurations
    /// in your account, in the AWS region where the API request is processed.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tags Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a> — Gets information about AWS tags for the specified ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a> — Adds or updates tags for the AWS resource with the specified
    /// ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a> — Removes tags from the resource with the specified ARN.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonIVSRealTimeClient : AmazonServiceClient, IAmazonIVSRealTime
    {
        private static IServiceMetadata serviceMetadata = new AmazonIVSRealTimeMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with the credentials loaded from the application's
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
        public AmazonIVSRealTimeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIVSRealTimeConfig()) { }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with the credentials loaded from the application's
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
        public AmazonIVSRealTimeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIVSRealTimeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIVSRealTimeClient Configuration Object</param>
        public AmazonIVSRealTimeClient(AmazonIVSRealTimeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIVSRealTimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonIVSRealTimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIVSRealTimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIVSRealTimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Credentials and an
        /// AmazonIVSRealTimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIVSRealTimeClient Configuration Object</param>
        public AmazonIVSRealTimeClient(AWSCredentials credentials, AmazonIVSRealTimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIVSRealTimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIVSRealTimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIVSRealTimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIVSRealTimeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIVSRealTimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIVSRealTimeClient Configuration Object</param>
        public AmazonIVSRealTimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIVSRealTimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIVSRealTimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIVSRealTimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIVSRealTimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIVSRealTimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIVSRealTimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIVSRealTimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIVSRealTimeClient Configuration Object</param>
        public AmazonIVSRealTimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIVSRealTimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IIVSRealTimePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIVSRealTimePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IVSRealTimePaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIVSRealTimeEndpointResolver());
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


        #region  CreateEncoderConfiguration

        internal virtual CreateEncoderConfigurationResponse CreateEncoderConfiguration(CreateEncoderConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEncoderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEncoderConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateEncoderConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates an EncoderConfiguration object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEncoderConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEncoderConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateEncoderConfiguration">REST API Reference for CreateEncoderConfiguration Operation</seealso>
        public virtual Task<CreateEncoderConfigurationResponse> CreateEncoderConfigurationAsync(CreateEncoderConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEncoderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEncoderConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEncoderConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateParticipantToken

        internal virtual CreateParticipantTokenResponse CreateParticipantToken(CreateParticipantTokenRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParticipantTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParticipantTokenResponseUnmarshaller.Instance;

            return Invoke<CreateParticipantTokenResponse>(request, options);
        }



        /// <summary>
        /// Creates an additional token for a specified stage. This can be done after stage creation
        /// or when tokens expire. Tokens always are scoped to the stage for which they are created.
        /// 
        ///  
        /// <para>
        /// Encryption keys are owned by Amazon IVS and never used directly by your application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParticipantToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateParticipantToken service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateParticipantToken">REST API Reference for CreateParticipantToken Operation</seealso>
        public virtual Task<CreateParticipantTokenResponse> CreateParticipantTokenAsync(CreateParticipantTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParticipantTokenRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParticipantTokenResponseUnmarshaller.Instance;

            return InvokeAsync<CreateParticipantTokenResponse>(request, options, cancellationToken);
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
        /// Creates a new stage (and optionally participant tokens).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStage service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual Task<CreateStageResponse> CreateStageAsync(CreateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStorageConfiguration

        internal virtual CreateStorageConfigurationResponse CreateStorageConfiguration(CreateStorageConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateStorageConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new storage configuration, used to enable recording to Amazon S3. When a
        /// StorageConfiguration is created, IVS will modify the S3 bucketPolicy of the provided
        /// bucket. This will ensure that IVS has sufficient permissions to write content to the
        /// provided bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStorageConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/CreateStorageConfiguration">REST API Reference for CreateStorageConfiguration Operation</seealso>
        public virtual Task<CreateStorageConfigurationResponse> CreateStorageConfigurationAsync(CreateStorageConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorageConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStorageConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEncoderConfiguration

        internal virtual DeleteEncoderConfigurationResponse DeleteEncoderConfiguration(DeleteEncoderConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEncoderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEncoderConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEncoderConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an EncoderConfiguration resource. Ensures that no Compositions are using this
        /// template; otherwise, returns an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEncoderConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEncoderConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteEncoderConfiguration">REST API Reference for DeleteEncoderConfiguration Operation</seealso>
        public virtual Task<DeleteEncoderConfigurationResponse> DeleteEncoderConfigurationAsync(DeleteEncoderConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEncoderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEncoderConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEncoderConfigurationResponse>(request, options, cancellationToken);
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
        /// Shuts down and deletes the specified stage (disconnecting all participants).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStage service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual Task<DeleteStageResponse> DeleteStageAsync(DeleteStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStorageConfiguration

        internal virtual DeleteStorageConfigurationResponse DeleteStorageConfiguration(DeleteStorageConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteStorageConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the storage configuration for the specified ARN.
        /// 
        ///  
        /// <para>
        /// If you try to delete a storage configuration that is used by a Composition, you will
        /// get an error (409 ConflictException). To avoid this, for all Compositions that reference
        /// the storage configuration, first use <a>StopComposition</a> and wait for it to complete,
        /// then use DeleteStorageConfiguration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStorageConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DeleteStorageConfiguration">REST API Reference for DeleteStorageConfiguration Operation</seealso>
        public virtual Task<DeleteStorageConfigurationResponse> DeleteStorageConfigurationAsync(DeleteStorageConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStorageConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStorageConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisconnectParticipant

        internal virtual DisconnectParticipantResponse DisconnectParticipant(DisconnectParticipantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectParticipantResponseUnmarshaller.Instance;

            return Invoke<DisconnectParticipantResponse>(request, options);
        }



        /// <summary>
        /// Disconnects a specified participant and revokes the participant permanently from a
        /// specified stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectParticipant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisconnectParticipant service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/DisconnectParticipant">REST API Reference for DisconnectParticipant Operation</seealso>
        public virtual Task<DisconnectParticipantResponse> DisconnectParticipantAsync(DisconnectParticipantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectParticipantResponseUnmarshaller.Instance;

            return InvokeAsync<DisconnectParticipantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComposition

        internal virtual GetCompositionResponse GetComposition(GetCompositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCompositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompositionResponseUnmarshaller.Instance;

            return Invoke<GetCompositionResponse>(request, options);
        }



        /// <summary>
        /// Get information about the specified Composition resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComposition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComposition service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetComposition">REST API Reference for GetComposition Operation</seealso>
        public virtual Task<GetCompositionResponse> GetCompositionAsync(GetCompositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCompositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCompositionResponseUnmarshaller.Instance;

            return InvokeAsync<GetCompositionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEncoderConfiguration

        internal virtual GetEncoderConfigurationResponse GetEncoderConfiguration(GetEncoderConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEncoderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncoderConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetEncoderConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the specified EncoderConfiguration resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEncoderConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEncoderConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetEncoderConfiguration">REST API Reference for GetEncoderConfiguration Operation</seealso>
        public virtual Task<GetEncoderConfigurationResponse> GetEncoderConfigurationAsync(GetEncoderConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEncoderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEncoderConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetEncoderConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetParticipant

        internal virtual GetParticipantResponse GetParticipant(GetParticipantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParticipantResponseUnmarshaller.Instance;

            return Invoke<GetParticipantResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the specified participant token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParticipant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParticipant service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetParticipant">REST API Reference for GetParticipant Operation</seealso>
        public virtual Task<GetParticipantResponse> GetParticipantAsync(GetParticipantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParticipantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParticipantResponseUnmarshaller.Instance;

            return InvokeAsync<GetParticipantResponse>(request, options, cancellationToken);
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
        /// Gets information for the specified stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStage service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual Task<GetStageResponse> GetStageAsync(GetStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return InvokeAsync<GetStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStageSession

        internal virtual GetStageSessionResponse GetStageSession(GetStageSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageSessionResponseUnmarshaller.Instance;

            return Invoke<GetStageSessionResponse>(request, options);
        }



        /// <summary>
        /// Gets information for the specified stage session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStageSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStageSession service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStageSession">REST API Reference for GetStageSession Operation</seealso>
        public virtual Task<GetStageSessionResponse> GetStageSessionAsync(GetStageSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageSessionResponseUnmarshaller.Instance;

            return InvokeAsync<GetStageSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStorageConfiguration

        internal virtual GetStorageConfigurationResponse GetStorageConfiguration(GetStorageConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetStorageConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets the storage configuration for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStorageConfiguration service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/GetStorageConfiguration">REST API Reference for GetStorageConfiguration Operation</seealso>
        public virtual Task<GetStorageConfigurationResponse> GetStorageConfigurationAsync(GetStorageConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStorageConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetStorageConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCompositions

        internal virtual ListCompositionsResponse ListCompositions(ListCompositionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompositionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompositionsResponseUnmarshaller.Instance;

            return Invoke<ListCompositionsResponse>(request, options);
        }



        /// <summary>
        /// Gets summary information about all Compositions in your account, in the AWS region
        /// where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCompositions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCompositions service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListCompositions">REST API Reference for ListCompositions Operation</seealso>
        public virtual Task<ListCompositionsResponse> ListCompositionsAsync(ListCompositionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCompositionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompositionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCompositionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEncoderConfigurations

        internal virtual ListEncoderConfigurationsResponse ListEncoderConfigurations(ListEncoderConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEncoderConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEncoderConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListEncoderConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Gets summary information about all EncoderConfigurations in your account, in the AWS
        /// region where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEncoderConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEncoderConfigurations service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListEncoderConfigurations">REST API Reference for ListEncoderConfigurations Operation</seealso>
        public virtual Task<ListEncoderConfigurationsResponse> ListEncoderConfigurationsAsync(ListEncoderConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEncoderConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEncoderConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEncoderConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListParticipantEvents

        internal virtual ListParticipantEventsResponse ListParticipantEvents(ListParticipantEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParticipantEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParticipantEventsResponseUnmarshaller.Instance;

            return Invoke<ListParticipantEventsResponse>(request, options);
        }



        /// <summary>
        /// Lists events for a specified participant that occurred during a specified stage session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParticipantEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListParticipantEvents service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListParticipantEvents">REST API Reference for ListParticipantEvents Operation</seealso>
        public virtual Task<ListParticipantEventsResponse> ListParticipantEventsAsync(ListParticipantEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParticipantEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParticipantEventsResponseUnmarshaller.Instance;

            return InvokeAsync<ListParticipantEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListParticipants

        internal virtual ListParticipantsResponse ListParticipants(ListParticipantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParticipantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParticipantsResponseUnmarshaller.Instance;

            return Invoke<ListParticipantsResponse>(request, options);
        }



        /// <summary>
        /// Lists all participants in a specified stage session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParticipants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListParticipants service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListParticipants">REST API Reference for ListParticipants Operation</seealso>
        public virtual Task<ListParticipantsResponse> ListParticipantsAsync(ListParticipantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParticipantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParticipantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListParticipantsResponse>(request, options, cancellationToken);
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
        /// Gets summary information about all stages in your account, in the AWS region where
        /// the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStages service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStages">REST API Reference for ListStages Operation</seealso>
        public virtual Task<ListStagesResponse> ListStagesAsync(ListStagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListStagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStageSessions

        internal virtual ListStageSessionsResponse ListStageSessions(ListStageSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStageSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStageSessionsResponseUnmarshaller.Instance;

            return Invoke<ListStageSessionsResponse>(request, options);
        }



        /// <summary>
        /// Gets all sessions for a specified stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStageSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStageSessions service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStageSessions">REST API Reference for ListStageSessions Operation</seealso>
        public virtual Task<ListStageSessionsResponse> ListStageSessionsAsync(ListStageSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStageSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStageSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStageSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStorageConfigurations

        internal virtual ListStorageConfigurationsResponse ListStorageConfigurations(ListStorageConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStorageConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListStorageConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Gets summary information about all storage configurations in your account, in the
        /// AWS region where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStorageConfigurations service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListStorageConfigurations">REST API Reference for ListStorageConfigurations Operation</seealso>
        public virtual Task<ListStorageConfigurationsResponse> ListStorageConfigurationsAsync(ListStorageConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStorageConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStorageConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStorageConfigurationsResponse>(request, options, cancellationToken);
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
        /// Gets information about AWS tags for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartComposition

        internal virtual StartCompositionResponse StartComposition(StartCompositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCompositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCompositionResponseUnmarshaller.Instance;

            return Invoke<StartCompositionResponse>(request, options);
        }



        /// <summary>
        /// Starts a Composition from a stage based on the configuration provided in the request.
        /// 
        ///  
        /// <para>
        /// A Composition is an ephemeral resource that exists after this endpoint returns successfully.
        /// Composition stops and the resource is deleted:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When <a>StopComposition</a> is called.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After a 1-minute timeout, when all participants are disconnected from the stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After a 1-minute timeout, if there are no participants in the stage when StartComposition
        /// is called.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When broadcasting to the IVS channel fails and all retries are exhausted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When broadcasting is disconnected and all attempts to reconnect are exhausted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartComposition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartComposition service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/StartComposition">REST API Reference for StartComposition Operation</seealso>
        public virtual Task<StartCompositionResponse> StartCompositionAsync(StartCompositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCompositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCompositionResponseUnmarshaller.Instance;

            return InvokeAsync<StartCompositionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopComposition

        internal virtual StopCompositionResponse StopComposition(StopCompositionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCompositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCompositionResponseUnmarshaller.Instance;

            return Invoke<StopCompositionResponse>(request, options);
        }



        /// <summary>
        /// Stops and deletes a Composition resource. Any broadcast from the Composition resource
        /// is stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopComposition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopComposition service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/StopComposition">REST API Reference for StopComposition Operation</seealso>
        public virtual Task<StopCompositionResponse> StopCompositionAsync(StopCompositionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopCompositionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopCompositionResponseUnmarshaller.Instance;

            return InvokeAsync<StopCompositionResponse>(request, options, cancellationToken);
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
        /// Adds or updates tags for the AWS resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from the resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
        /// Updates a stage’s configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStage service method, as returned by IVSRealTime.</returns>
        /// <exception cref="Amazon.IVSRealTime.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVSRealTime.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-realtime-2020-07-14/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual Task<UpdateStageResponse> UpdateStageAsync(UpdateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStageResponse>(request, options, cancellationToken);
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
            var resolver = new AmazonIVSRealTimeEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}