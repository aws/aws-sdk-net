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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IVS.Model;
using Amazon.IVS.Model.Internal.MarshallTransformations;
using Amazon.IVS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.IVS
{
    /// <summary>
    /// <para>Implementation for accessing IVS</para>
    ///
    /// <b>Introduction</b> 
    /// 
    ///  
    /// <para>
    /// The Amazon Interactive Video Service (IVS) API is REST compatible, using a standard
    /// HTTP API and an Amazon Web Services EventBridge event stream for responses. JSON is
    /// used for both requests and responses, including errors.
    /// </para>
    ///  
    /// <para>
    /// The API is an Amazon Web Services regional service. For a list of supported regions
    /// and Amazon IVS HTTPS service endpoints, see the <a href="https://docs.aws.amazon.com/general/latest/gr/ivs.html">Amazon
    /// IVS page</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    ///  
    /// <para>
    ///  <i> <b>All API request parameters and URLs are case sensitive. </b> </i> 
    /// </para>
    ///  
    /// <para>
    /// For a summary of notable documentation changes in each release, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/doc-history.html">
    /// Document History</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Allowed Header Values</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c> <b>Accept:</b> </c> application/json
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <b>Accept-Encoding:</b> </c> gzip, deflate
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c> <b>Content-Type:</b> </c>application/json
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Key Concepts</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Channel</b> — Stores configuration data related to your live stream. You first
    /// create a channel and then use the channel’s stream key to start your live stream.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Stream key</b> — An identifier assigned by Amazon IVS when you create a channel,
    /// which is then used to authorize streaming. <i> <b>Treat the stream key like a secret,
    /// since it allows anyone to stream to the channel.</b> </i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Playback key pair</b> — Video playback may be restricted using playback-authorization
    /// tokens, which use public-key encryption. A playback key pair is the public-private
    /// pair of keys used to sign and validate the playback-authorization token.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Recording configuration</b> — Stores configuration related to recording a live
    /// stream and where to store the recorded content. Multiple channels can reference the
    /// same recording configuration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Playback restriction policy</b> — Restricts playback by countries and/or origin
    /// sites.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about your IVS live stream, also see <a href="https://docs.aws.amazon.com/ivs/latest/LowLatencyUserGuide/getting-started.html">Getting
    /// Started with IVS Low-Latency Streaming</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Tagging</b> 
    /// </para>
    ///  
    /// <para>
    /// A <i>tag</i> is a metadata label that you assign to an Amazon Web Services resource.
    /// A tag comprises a <i>key</i> and a <i>value</i>, both set by you. For example, you
    /// might set a tag as <c>topic:nature</c> to label a particular video category. See <a
    /// href="https://docs.aws.amazon.com/tag-editor/latest/userguide/best-practices-and-strats.html">Best
    /// practices and strategies</a> in <i>Tagging Amazon Web Services Resources and Tag Editor</i>
    /// for details, including restrictions that apply to tags and "Tag naming limits and
    /// requirements"; Amazon IVS has no service-specific constraints beyond what is documented
    /// there.
    /// </para>
    ///  
    /// <para>
    /// Tags can help you identify and organize your Amazon Web Services resources. For example,
    /// you can use the same tag for different resources to indicate that they are related.
    /// You can also use tags to manage access (see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">
    /// Access Tags</a>). 
    /// </para>
    ///  
    /// <para>
    /// The Amazon IVS API has these tag-related operations: <a>TagResource</a>, <a>UntagResource</a>,
    /// and <a>ListTagsForResource</a>. The following resources support tagging: Channels,
    /// Stream Keys, Playback Key Pairs, and Recording Configurations.
    /// </para>
    ///  
    /// <para>
    /// At most 50 tags can be applied to a resource. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Authentication versus Authorization</b> 
    /// </para>
    ///  
    /// <para>
    /// Note the differences between these concepts:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Authentication</i> is about verifying identity. You need to be authenticated to
    /// sign Amazon IVS API requests.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Authorization</i> is about granting permissions. Your IAM roles need to have permissions
    /// for Amazon IVS API requests. In addition, authorization is needed to view <a href="https://docs.aws.amazon.com/ivs/latest/userguide/private-channels.html">Amazon
    /// IVS private channels</a>. (Private channels are channels that are enabled for "playback
    /// authorization.")
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Authentication</b> 
    /// </para>
    ///  
    /// <para>
    /// All Amazon IVS API requests must be authenticated with a signature. The Amazon Web
    /// Services Command-Line Interface (CLI) and Amazon IVS Player SDKs take care of signing
    /// the underlying API calls for you. However, if your application calls the Amazon IVS
    /// API directly, it’s your responsibility to sign the requests.
    /// </para>
    ///  
    /// <para>
    /// You generate a signature using valid Amazon Web Services credentials that have permission
    /// to perform the requested action. For example, you must sign PutMetadata requests with
    /// a signature generated from a user account that has the <c>ivs:PutMetadata</c> permission.
    /// </para>
    ///  
    /// <para>
    /// For more information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Authentication and generating signatures — See <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
    /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon Web Services
    /// General Reference</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Managing Amazon IVS permissions — See <a href="https://docs.aws.amazon.com/ivs/latest/userguide/security-iam.html">Identity
    /// and Access Management</a> on the Security page of the <i>Amazon IVS User Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Amazon Resource Names (ARNs)</b> 
    /// </para>
    ///  
    /// <para>
    /// ARNs uniquely identify AWS resources. An ARN is required when you need to specify
    /// a resource unambiguously across all of AWS, such as in IAM policies and API calls.
    /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
    /// Resource Names</a> in the <i>AWS General Reference</i>.
    /// </para>
    /// </summary>
    public partial class AmazonIVSClient : AmazonServiceClient, IAmazonIVS
    {
        private static IServiceMetadata serviceMetadata = new AmazonIVSMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonIVSClient with the credentials loaded from the application's
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
        public AmazonIVSClient()
            : base(new AmazonIVSConfig()) { }

        /// <summary>
        /// Constructs AmazonIVSClient with the credentials loaded from the application's
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
        public AmazonIVSClient(RegionEndpoint region)
            : base(new AmazonIVSConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIVSClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIVSClient Configuration Object</param>
        public AmazonIVSClient(AmazonIVSConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonIVSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIVSClient(AWSCredentials credentials)
            : this(credentials, new AmazonIVSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIVSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIVSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIVSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIVSClient with AWS Credentials and an
        /// AmazonIVSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIVSClient Configuration Object</param>
        public AmazonIVSClient(AWSCredentials credentials, AmazonIVSConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIVSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIVSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIVSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIVSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIVSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIVSConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIVSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIVSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIVSClient Configuration Object</param>
        public AmazonIVSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIVSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIVSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIVSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIVSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIVSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIVSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIVSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIVSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIVSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIVSClient Configuration Object</param>
        public AmazonIVSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIVSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IIVSPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIVSPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IVSPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIVSEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIVSAuthSchemeHandler());
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


        #region  BatchGetChannel

        internal virtual BatchGetChannelResponse BatchGetChannel(BatchGetChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetChannelResponseUnmarshaller.Instance;

            return Invoke<BatchGetChannelResponse>(request, options);
        }



        /// <summary>
        /// Performs <a>GetChannel</a> on multiple ARNs simultaneously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetChannel service method, as returned by IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetChannel">REST API Reference for BatchGetChannel Operation</seealso>
        public virtual Task<BatchGetChannelResponse> BatchGetChannelAsync(BatchGetChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetChannelResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetChannelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetStreamKey

        internal virtual BatchGetStreamKeyResponse BatchGetStreamKey(BatchGetStreamKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetStreamKeyResponseUnmarshaller.Instance;

            return Invoke<BatchGetStreamKeyResponse>(request, options);
        }



        /// <summary>
        /// Performs <a>GetStreamKey</a> on multiple ARNs simultaneously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetStreamKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetStreamKey service method, as returned by IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetStreamKey">REST API Reference for BatchGetStreamKey Operation</seealso>
        public virtual Task<BatchGetStreamKeyResponse> BatchGetStreamKeyAsync(BatchGetStreamKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetStreamKeyResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetStreamKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchStartViewerSessionRevocation

        internal virtual BatchStartViewerSessionRevocationResponse BatchStartViewerSessionRevocation(BatchStartViewerSessionRevocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchStartViewerSessionRevocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchStartViewerSessionRevocationResponseUnmarshaller.Instance;

            return Invoke<BatchStartViewerSessionRevocationResponse>(request, options);
        }



        /// <summary>
        /// Performs <a>StartViewerSessionRevocation</a> on multiple channel ARN and viewer ID
        /// pairs simultaneously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchStartViewerSessionRevocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchStartViewerSessionRevocation service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchStartViewerSessionRevocation">REST API Reference for BatchStartViewerSessionRevocation Operation</seealso>
        public virtual Task<BatchStartViewerSessionRevocationResponse> BatchStartViewerSessionRevocationAsync(BatchStartViewerSessionRevocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchStartViewerSessionRevocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchStartViewerSessionRevocationResponseUnmarshaller.Instance;

            return InvokeAsync<BatchStartViewerSessionRevocationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateChannel

        internal virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }



        /// <summary>
        /// Creates a new channel and an associated stream key to start streaming.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChannelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePlaybackRestrictionPolicy

        internal virtual CreatePlaybackRestrictionPolicyResponse CreatePlaybackRestrictionPolicy(CreatePlaybackRestrictionPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePlaybackRestrictionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlaybackRestrictionPolicyResponseUnmarshaller.Instance;

            return Invoke<CreatePlaybackRestrictionPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a new playback restriction policy, for constraining playback by countries
        /// and/or origins.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlaybackRestrictionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlaybackRestrictionPolicy service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreatePlaybackRestrictionPolicy">REST API Reference for CreatePlaybackRestrictionPolicy Operation</seealso>
        public virtual Task<CreatePlaybackRestrictionPolicyResponse> CreatePlaybackRestrictionPolicyAsync(CreatePlaybackRestrictionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePlaybackRestrictionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlaybackRestrictionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlaybackRestrictionPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRecordingConfiguration

        internal virtual CreateRecordingConfigurationResponse CreateRecordingConfiguration(CreateRecordingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRecordingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecordingConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateRecordingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new recording configuration, used to enable recording to Amazon S3.
        /// 
        ///  
        /// <para>
        ///  <b>Known issue:</b> In the us-east-1 region, if you use the Amazon Web Services CLI
        /// to create a recording configuration, it returns success even if the S3 bucket is in
        /// a different region. In this case, the <c>state</c> of the recording configuration
        /// is <c>CREATE_FAILED</c> (instead of <c>ACTIVE</c>). (In other regions, the CLI correctly
        /// returns failure if the bucket is in a different region.)
        /// </para>
        ///  
        /// <para>
        ///  <b>Workaround:</b> Ensure that your S3 bucket is in the same region as the recording
        /// configuration. If you create a recording configuration in a different region as your
        /// S3 bucket, delete that recording configuration and create a new one with an S3 bucket
        /// from the correct region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecordingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRecordingConfiguration service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateRecordingConfiguration">REST API Reference for CreateRecordingConfiguration Operation</seealso>
        public virtual Task<CreateRecordingConfigurationResponse> CreateRecordingConfigurationAsync(CreateRecordingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRecordingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecordingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRecordingConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStreamKey

        internal virtual CreateStreamKeyResponse CreateStreamKey(CreateStreamKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamKeyResponseUnmarshaller.Instance;

            return Invoke<CreateStreamKeyResponse>(request, options);
        }



        /// <summary>
        /// Creates a stream key, used to initiate a stream, for the specified channel ARN.
        /// 
        ///  
        /// <para>
        /// Note that <a>CreateChannel</a> creates a stream key. If you subsequently use CreateStreamKey
        /// on the same channel, it will fail because a stream key already exists and there is
        /// a limit of 1 stream key per channel. To reset the stream key on a channel, use <a>DeleteStreamKey</a>
        /// and then CreateStreamKey.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStreamKey service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateStreamKey">REST API Reference for CreateStreamKey Operation</seealso>
        public virtual Task<CreateStreamKeyResponse> CreateStreamKeyAsync(CreateStreamKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteChannel

        internal virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified channel and its associated stream keys.
        /// 
        ///  
        /// <para>
        /// If you try to delete a live channel, you will get an error (409 ConflictException).
        /// To delete a channel that is live, call <a>StopStream</a>, wait for the Amazon EventBridge
        /// "Stream End" event (to verify that the stream's state is no longer Live), then call
        /// DeleteChannel. (See <a href="https://docs.aws.amazon.com/ivs/latest/userguide/eventbridge.html">
        /// Using EventBridge with Amazon IVS</a>.) 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePlaybackKeyPair

        internal virtual DeletePlaybackKeyPairResponse DeletePlaybackKeyPair(DeletePlaybackKeyPairRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePlaybackKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackKeyPairResponseUnmarshaller.Instance;

            return Invoke<DeletePlaybackKeyPairResponse>(request, options);
        }



        /// <summary>
        /// Deletes a specified authorization key pair. This invalidates future viewer tokens
        /// generated using the key pair’s <c>privateKey</c>. For more information, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/private-channels.html">Setting
        /// Up Private Channels</a> in the <i>Amazon IVS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlaybackKeyPair service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeletePlaybackKeyPair">REST API Reference for DeletePlaybackKeyPair Operation</seealso>
        public virtual Task<DeletePlaybackKeyPairResponse> DeletePlaybackKeyPairAsync(DeletePlaybackKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePlaybackKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlaybackKeyPairResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePlaybackRestrictionPolicy

        internal virtual DeletePlaybackRestrictionPolicyResponse DeletePlaybackRestrictionPolicy(DeletePlaybackRestrictionPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePlaybackRestrictionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackRestrictionPolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePlaybackRestrictionPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified playback restriction policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackRestrictionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePlaybackRestrictionPolicy service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeletePlaybackRestrictionPolicy">REST API Reference for DeletePlaybackRestrictionPolicy Operation</seealso>
        public virtual Task<DeletePlaybackRestrictionPolicyResponse> DeletePlaybackRestrictionPolicyAsync(DeletePlaybackRestrictionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePlaybackRestrictionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackRestrictionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlaybackRestrictionPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRecordingConfiguration

        internal virtual DeleteRecordingConfigurationResponse DeleteRecordingConfiguration(DeleteRecordingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRecordingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecordingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteRecordingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the recording configuration for the specified ARN.
        /// 
        ///  
        /// <para>
        /// If you try to delete a recording configuration that is associated with a channel,
        /// you will get an error (409 ConflictException). To avoid this, for all channels that
        /// reference the recording configuration, first use <a>UpdateChannel</a> to set the <c>recordingConfigurationArn</c>
        /// field to an empty string, then use DeleteRecordingConfiguration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecordingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRecordingConfiguration service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteRecordingConfiguration">REST API Reference for DeleteRecordingConfiguration Operation</seealso>
        public virtual Task<DeleteRecordingConfigurationResponse> DeleteRecordingConfigurationAsync(DeleteRecordingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRecordingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecordingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRecordingConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteStreamKey

        internal virtual DeleteStreamKeyResponse DeleteStreamKey(DeleteStreamKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamKeyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the stream key for the specified ARN, so it can no longer be used to stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStreamKey service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteStreamKey">REST API Reference for DeleteStreamKey Operation</seealso>
        public virtual Task<DeleteStreamKeyResponse> DeleteStreamKeyAsync(DeleteStreamKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStreamKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetChannel

        internal virtual GetChannelResponse GetChannel(GetChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelResponseUnmarshaller.Instance;

            return Invoke<GetChannelResponse>(request, options);
        }



        /// <summary>
        /// Gets the channel configuration for the specified channel ARN. See also <a>BatchGetChannel</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannel service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetChannel">REST API Reference for GetChannel Operation</seealso>
        public virtual Task<GetChannelResponse> GetChannelAsync(GetChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelResponseUnmarshaller.Instance;

            return InvokeAsync<GetChannelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPlaybackKeyPair

        internal virtual GetPlaybackKeyPairResponse GetPlaybackKeyPair(GetPlaybackKeyPairRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlaybackKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackKeyPairResponseUnmarshaller.Instance;

            return Invoke<GetPlaybackKeyPairResponse>(request, options);
        }



        /// <summary>
        /// Gets a specified playback authorization key pair and returns the <c>arn</c> and <c>fingerprint</c>.
        /// The <c>privateKey</c> held by the caller can be used to generate viewer authorization
        /// tokens, to grant viewers access to private channels. For more information, see <a
        /// href="https://docs.aws.amazon.com/ivs/latest/userguide/private-channels.html">Setting
        /// Up Private Channels</a> in the <i>Amazon IVS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlaybackKeyPair service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetPlaybackKeyPair">REST API Reference for GetPlaybackKeyPair Operation</seealso>
        public virtual Task<GetPlaybackKeyPairResponse> GetPlaybackKeyPairAsync(GetPlaybackKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlaybackKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<GetPlaybackKeyPairResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPlaybackRestrictionPolicy

        internal virtual GetPlaybackRestrictionPolicyResponse GetPlaybackRestrictionPolicy(GetPlaybackRestrictionPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlaybackRestrictionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackRestrictionPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPlaybackRestrictionPolicyResponse>(request, options);
        }



        /// <summary>
        /// Gets the specified playback restriction policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackRestrictionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPlaybackRestrictionPolicy service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetPlaybackRestrictionPolicy">REST API Reference for GetPlaybackRestrictionPolicy Operation</seealso>
        public virtual Task<GetPlaybackRestrictionPolicyResponse> GetPlaybackRestrictionPolicyAsync(GetPlaybackRestrictionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPlaybackRestrictionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackRestrictionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPlaybackRestrictionPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRecordingConfiguration

        internal virtual GetRecordingConfigurationResponse GetRecordingConfiguration(GetRecordingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecordingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetRecordingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Gets the recording configuration for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecordingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecordingConfiguration service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetRecordingConfiguration">REST API Reference for GetRecordingConfiguration Operation</seealso>
        public virtual Task<GetRecordingConfigurationResponse> GetRecordingConfigurationAsync(GetRecordingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecordingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecordingConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetStream

        internal virtual GetStreamResponse GetStream(GetStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamResponseUnmarshaller.Instance;

            return Invoke<GetStreamResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the active (live) stream on a specified channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStream service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ChannelNotBroadcastingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStream">REST API Reference for GetStream Operation</seealso>
        public virtual Task<GetStreamResponse> GetStreamAsync(GetStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamResponseUnmarshaller.Instance;

            return InvokeAsync<GetStreamResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetStreamKey

        internal virtual GetStreamKeyResponse GetStreamKey(GetStreamKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamKeyResponseUnmarshaller.Instance;

            return Invoke<GetStreamKeyResponse>(request, options);
        }



        /// <summary>
        /// Gets stream-key information for a specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamKey service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStreamKey">REST API Reference for GetStreamKey Operation</seealso>
        public virtual Task<GetStreamKeyResponse> GetStreamKeyAsync(GetStreamKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GetStreamKeyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetStreamSession

        internal virtual GetStreamSessionResponse GetStreamSession(GetStreamSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStreamSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamSessionResponseUnmarshaller.Instance;

            return Invoke<GetStreamSessionResponse>(request, options);
        }



        /// <summary>
        /// Gets metadata on a specified stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStreamSession service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStreamSession">REST API Reference for GetStreamSession Operation</seealso>
        public virtual Task<GetStreamSessionResponse> GetStreamSessionAsync(GetStreamSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStreamSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamSessionResponseUnmarshaller.Instance;

            return InvokeAsync<GetStreamSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ImportPlaybackKeyPair

        internal virtual ImportPlaybackKeyPairResponse ImportPlaybackKeyPair(ImportPlaybackKeyPairRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportPlaybackKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportPlaybackKeyPairResponseUnmarshaller.Instance;

            return Invoke<ImportPlaybackKeyPairResponse>(request, options);
        }



        /// <summary>
        /// Imports the public portion of a new key pair and returns its <c>arn</c> and <c>fingerprint</c>.
        /// The <c>privateKey</c> can then be used to generate viewer authorization tokens, to
        /// grant viewers access to private channels. For more information, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/private-channels.html">Setting
        /// Up Private Channels</a> in the <i>Amazon IVS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportPlaybackKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportPlaybackKeyPair service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ImportPlaybackKeyPair">REST API Reference for ImportPlaybackKeyPair Operation</seealso>
        public virtual Task<ImportPlaybackKeyPairResponse> ImportPlaybackKeyPairAsync(ImportPlaybackKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportPlaybackKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportPlaybackKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<ImportPlaybackKeyPairResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListChannels

        internal virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }



        /// <summary>
        /// Gets summary information about all channels in your account, in the Amazon Web Services
        /// region where the API request is processed. This list can be filtered to match a specified
        /// name or recording-configuration ARN. Filters are mutually exclusive and cannot be
        /// used together. If you try to use both filters, you will get an error (409 ConflictException).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPlaybackKeyPairs

        internal virtual ListPlaybackKeyPairsResponse ListPlaybackKeyPairs(ListPlaybackKeyPairsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlaybackKeyPairsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackKeyPairsResponseUnmarshaller.Instance;

            return Invoke<ListPlaybackKeyPairsResponse>(request, options);
        }



        /// <summary>
        /// Gets summary information about playback key pairs. For more information, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/private-channels.html">Setting
        /// Up Private Channels</a> in the <i>Amazon IVS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackKeyPairs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlaybackKeyPairs service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListPlaybackKeyPairs">REST API Reference for ListPlaybackKeyPairs Operation</seealso>
        public virtual Task<ListPlaybackKeyPairsResponse> ListPlaybackKeyPairsAsync(ListPlaybackKeyPairsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlaybackKeyPairsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackKeyPairsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPlaybackKeyPairsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPlaybackRestrictionPolicies

        internal virtual ListPlaybackRestrictionPoliciesResponse ListPlaybackRestrictionPolicies(ListPlaybackRestrictionPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlaybackRestrictionPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackRestrictionPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPlaybackRestrictionPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Gets summary information about playback restriction policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackRestrictionPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlaybackRestrictionPolicies service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListPlaybackRestrictionPolicies">REST API Reference for ListPlaybackRestrictionPolicies Operation</seealso>
        public virtual Task<ListPlaybackRestrictionPoliciesResponse> ListPlaybackRestrictionPoliciesAsync(ListPlaybackRestrictionPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPlaybackRestrictionPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackRestrictionPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPlaybackRestrictionPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRecordingConfigurations

        internal virtual ListRecordingConfigurationsResponse ListRecordingConfigurations(ListRecordingConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecordingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecordingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListRecordingConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Gets summary information about all recording configurations in your account, in the
        /// Amazon Web Services region where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecordingConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecordingConfigurations service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListRecordingConfigurations">REST API Reference for ListRecordingConfigurations Operation</seealso>
        public virtual Task<ListRecordingConfigurationsResponse> ListRecordingConfigurationsAsync(ListRecordingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRecordingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecordingConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecordingConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStreamKeys

        internal virtual ListStreamKeysResponse ListStreamKeys(ListStreamKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamKeysResponseUnmarshaller.Instance;

            return Invoke<ListStreamKeysResponse>(request, options);
        }



        /// <summary>
        /// Gets summary information about stream keys for the specified channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamKeys service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreamKeys">REST API Reference for ListStreamKeys Operation</seealso>
        public virtual Task<ListStreamKeysResponse> ListStreamKeysAsync(ListStreamKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamKeysResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStreams

        internal virtual ListStreamsResponse ListStreams(ListStreamsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return Invoke<ListStreamsResponse>(request, options);
        }



        /// <summary>
        /// Gets summary information about live streams in your account, in the Amazon Web Services
        /// region where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStreamSessions

        internal virtual ListStreamSessionsResponse ListStreamSessions(ListStreamSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamSessionsResponseUnmarshaller.Instance;

            return Invoke<ListStreamSessionsResponse>(request, options);
        }



        /// <summary>
        /// Gets a summary of current and previous streams for a specified channel in your account,
        /// in the AWS region where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreamSessions service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreamSessions">REST API Reference for ListStreamSessions Operation</seealso>
        public virtual Task<ListStreamSessionsResponse> ListStreamSessionsAsync(ListStreamSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamSessionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Gets information about Amazon Web Services tags for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutMetadata

        internal virtual PutMetadataResponse PutMetadata(PutMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetadataResponseUnmarshaller.Instance;

            return Invoke<PutMetadataResponse>(request, options);
        }



        /// <summary>
        /// Inserts metadata into the active stream of the specified channel. At most 5 requests
        /// per second per channel are allowed, each with a maximum 1 KB payload. (If 5 TPS is
        /// not sufficient for your needs, we recommend batching your data into a single PutMetadata
        /// call.) At most 155 requests per second per account are allowed. Also see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/metadata.html">Embedding
        /// Metadata within a Video Stream</a> in the <i>Amazon IVS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMetadata service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ChannelNotBroadcastingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/PutMetadata">REST API Reference for PutMetadata Operation</seealso>
        public virtual Task<PutMetadataResponse> PutMetadataAsync(PutMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<PutMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartViewerSessionRevocation

        internal virtual StartViewerSessionRevocationResponse StartViewerSessionRevocation(StartViewerSessionRevocationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartViewerSessionRevocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartViewerSessionRevocationResponseUnmarshaller.Instance;

            return Invoke<StartViewerSessionRevocationResponse>(request, options);
        }



        /// <summary>
        /// Starts the process of revoking the viewer session associated with a specified channel
        /// ARN and viewer ID. Optionally, you can provide a version to revoke viewer sessions
        /// less than and including that version. For instructions on associating a viewer ID
        /// with a viewer session, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/private-channels.html">Setting
        /// Up Private Channels</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartViewerSessionRevocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartViewerSessionRevocation service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/StartViewerSessionRevocation">REST API Reference for StartViewerSessionRevocation Operation</seealso>
        public virtual Task<StartViewerSessionRevocationResponse> StartViewerSessionRevocationAsync(StartViewerSessionRevocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartViewerSessionRevocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartViewerSessionRevocationResponseUnmarshaller.Instance;

            return InvokeAsync<StartViewerSessionRevocationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopStream

        internal virtual StopStreamResponse StopStream(StopStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamResponseUnmarshaller.Instance;

            return Invoke<StopStreamResponse>(request, options);
        }



        /// <summary>
        /// Disconnects the incoming RTMPS stream for the specified channel. Can be used in conjunction
        /// with <a>DeleteStreamKey</a> to prevent further streaming to a channel.
        /// 
        ///  <note> 
        /// <para>
        /// Many streaming client-software libraries automatically reconnect a dropped RTMPS session,
        /// so to stop the stream permanently, you may want to first revoke the <c>streamKey</c>
        /// attached to the channel.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopStream service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ChannelNotBroadcastingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.StreamUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/StopStream">REST API Reference for StopStream Operation</seealso>
        public virtual Task<StopStreamResponse> StopStreamAsync(StopStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamResponseUnmarshaller.Instance;

            return InvokeAsync<StopStreamResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds or updates tags for the Amazon Web Services resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>The response from the UntagResource service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateChannel

        internal virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }



        /// <summary>
        /// Updates a channel's configuration. Live channels cannot be updated. You must stop
        /// the ongoing stream, update the channel, and restart the stream for the changes to
        /// take effect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChannelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePlaybackRestrictionPolicy

        internal virtual UpdatePlaybackRestrictionPolicyResponse UpdatePlaybackRestrictionPolicy(UpdatePlaybackRestrictionPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePlaybackRestrictionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlaybackRestrictionPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdatePlaybackRestrictionPolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates a specified playback restriction policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlaybackRestrictionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePlaybackRestrictionPolicy service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.PendingVerificationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/UpdatePlaybackRestrictionPolicy">REST API Reference for UpdatePlaybackRestrictionPolicy Operation</seealso>
        public virtual Task<UpdatePlaybackRestrictionPolicyResponse> UpdatePlaybackRestrictionPolicyAsync(UpdatePlaybackRestrictionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePlaybackRestrictionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePlaybackRestrictionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePlaybackRestrictionPolicyResponse>(request, options, cancellationToken);
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