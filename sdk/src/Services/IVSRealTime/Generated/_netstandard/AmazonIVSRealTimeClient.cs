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

namespace Amazon.IVSRealTime
{
    /// <summary>
    /// Implementation for accessing IVSRealTime
    ///
    /// <b>Introduction</b> 
    /// 
    ///  
    /// <para>
    /// The Amazon Interactive Video Service (IVS) stage API is REST compatible, using a standard
    /// HTTP API and an AWS EventBridge event stream for responses. JSON is used for both
    /// requests and responses, including errors. 
    /// </para>
    ///  
    /// <para>
    /// Terminology: The IVS stage API sometimes is referred to as the IVS RealTime API.
    /// </para>
    ///  
    /// <para>
    ///  <b>Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// The following resources contain information about your IVS live stream (see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/getting-started.html">Getting
    /// Started with Amazon IVS</a>):
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Stage</b> — A stage is a virtual space where multiple participants can exchange
    /// audio and video in real time.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tagging</b> 
    /// </para>
    ///  
    /// <para>
    /// A <i>tag</i> is a metadata label that you assign to an AWS resource. A tag comprises
    /// a <i>key</i> and a <i>value</i>, both set by you. For example, you might set a tag
    /// as <code>topic:nature</code> to label a particular video category. See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
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
    /// The Amazon IVS stage API has these tag-related endpoints: <a>TagResource</a>, <a>UntagResource</a>,
    /// and <a>ListTagsForResource</a>. The following resource supports tagging: Stage.
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
    ///  <a>GetStage</a> — Gets information for the specified stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStages</a> — Gets summary information about all stages in your account, in
    /// the AWS region where the API request is processed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateStage</a> — Updates a stage’s configuration.
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


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
        
    }
}