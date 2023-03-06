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
using System.Collections.Generic;
using System.Net;

using Amazon.IVS.Model;
using Amazon.IVS.Model.Internal.MarshallTransformations;
using Amazon.IVS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IVS
{
    /// <summary>
    /// Implementation for accessing IVS
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
    ///  <code> <b>Accept:</b> </code> application/json
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code> <b>Accept-Encoding:</b> </code> gzip, deflate
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code> <b>Content-Type:</b> </code>application/json
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// The following resources contain information about your IVS live stream (see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/getting-started.html">
    /// Getting Started with Amazon IVS</a>):
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Channel — Stores configuration data related to your live stream. You first create
    /// a channel and then use the channel’s stream key to start your live stream. See the
    /// Channel endpoints for more information. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Stream key — An identifier assigned by Amazon IVS when you create a channel, which
    /// is then used to authorize streaming. See the StreamKey endpoints for more information.
    /// <i> <b>Treat the stream key like a secret, since it allows anyone to stream to the
    /// channel.</b> </i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Playback key pair — Video playback may be restricted using playback-authorization
    /// tokens, which use public-key encryption. A playback key pair is the public-private
    /// pair of keys used to sign and validate the playback-authorization token. See the PlaybackKeyPair
    /// endpoints for more information.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Recording configuration — Stores configuration related to recording a live stream
    /// and where to store the recorded content. Multiple channels can reference the same
    /// recording configuration. See the Recording Configuration endpoints for more information.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Tagging</b> 
    /// </para>
    ///  
    /// <para>
    /// A <i>tag</i> is a metadata label that you assign to an Amazon Web Services resource.
    /// A tag comprises a <i>key</i> and a <i>value</i>, both set by you. For example, you
    /// might set a tag as <code>topic:nature</code> to label a particular video category.
    /// See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
    /// Amazon Web Services Resources</a> for more information, including restrictions that
    /// apply to tags and "Tag naming limits and requirements"; Amazon IVS has no service-specific
    /// constraints beyond what is documented there.
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
    /// The Amazon IVS API has these tag-related endpoints: <a>TagResource</a>, <a>UntagResource</a>,
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
    /// a signature generated from a user account that has the <code>ivs:PutMetadata</code>
    /// permission.
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
    ///  
    /// <para>
    ///  <b>Channel Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateChannel</a> — Creates a new channel and an associated stream key to start
    /// streaming.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetChannel</a> — Gets the channel configuration for the specified channel ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>BatchGetChannel</a> — Performs <a>GetChannel</a> on multiple ARNs simultaneously.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListChannels</a> — Gets summary information about all channels in your account,
    /// in the Amazon Web Services region where the API request is processed. This list can
    /// be filtered to match a specified name or recording-configuration ARN. Filters are
    /// mutually exclusive and cannot be used together. If you try to use both filters, you
    /// will get an error (409 Conflict Exception).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateChannel</a> — Updates a channel's configuration. This does not affect an
    /// ongoing stream of this channel. You must stop and restart the stream for the changes
    /// to take effect.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteChannel</a> — Deletes the specified channel.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>StreamKey Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateStreamKey</a> — Creates a stream key, used to initiate a stream, for the
    /// specified channel ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetStreamKey</a> — Gets stream key information for the specified ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>BatchGetStreamKey</a> — Performs <a>GetStreamKey</a> on multiple ARNs simultaneously.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStreamKeys</a> — Gets summary information about stream keys for the specified
    /// channel.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteStreamKey</a> — Deletes the stream key for the specified ARN, so it can
    /// no longer be used to stream.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Stream Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GetStream</a> — Gets information about the active (live) stream on a specified
    /// channel.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetStreamSession</a> — Gets metadata on a specified stream.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStreams</a> — Gets summary information about live streams in your account,
    /// in the Amazon Web Services region where the API request is processed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListStreamSessions</a> — Gets a summary of current and previous streams for a
    /// specified channel in your account, in the AWS region where the API request is processed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopStream</a> — Disconnects the incoming RTMPS stream for the specified channel.
    /// Can be used in conjunction with <a>DeleteStreamKey</a> to prevent further streaming
    /// to a channel.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutMetadata</a> — Inserts metadata into the active stream of the specified channel.
    /// At most 5 requests per second per channel are allowed, each with a maximum 1 KB payload.
    /// (If 5 TPS is not sufficient for your needs, we recommend batching your data into a
    /// single PutMetadata call.) At most 155 requests per second per account are allowed.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>PlaybackKeyPair Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/private-channels.html">Setting
    /// Up Private Channels</a> in the <i>Amazon IVS User Guide</i>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ImportPlaybackKeyPair</a> — Imports the public portion of a new key pair and returns
    /// its <code>arn</code> and <code>fingerprint</code>. The <code>privateKey</code> can
    /// then be used to generate viewer authorization tokens, to grant viewers access to private
    /// channels (channels enabled for playback authorization).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPlaybackKeyPair</a> — Gets a specified playback authorization key pair and
    /// returns the <code>arn</code> and <code>fingerprint</code>. The <code>privateKey</code>
    /// held by the caller can be used to generate viewer authorization tokens, to grant viewers
    /// access to private channels.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListPlaybackKeyPairs</a> — Gets summary information about playback key pairs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeletePlaybackKeyPair</a> — Deletes a specified authorization key pair. This invalidates
    /// future viewer tokens generated using the key pair’s <code>privateKey</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>RecordingConfiguration Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateRecordingConfiguration</a> — Creates a new recording configuration, used
    /// to enable recording to Amazon S3.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetRecordingConfiguration</a> — Gets the recording-configuration metadata for
    /// the specified ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListRecordingConfigurations</a> — Gets summary information about all recording
    /// configurations in your account, in the Amazon Web Services region where the API request
    /// is processed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteRecordingConfiguration</a> — Deletes the recording configuration for the
    /// specified ARN.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Amazon Web Services Tags Endpoints</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>TagResource</a> — Adds or updates tags for the Amazon Web Services resource with
    /// the specified ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a> — Removes tags from the resource with the specified ARN.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a> — Gets information about Amazon Web Services tags for
    /// the specified ARN.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonIVSClient : AmazonServiceClient, IAmazonIVS
    {
        private static IServiceMetadata serviceMetadata = new AmazonIVSMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIVSConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIVSConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIVSEndpointResolver());
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

        /// <summary>
        /// Performs <a>GetChannel</a> on multiple ARNs simultaneously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetChannel service method.</param>
        /// 
        /// <returns>The response from the BatchGetChannel service method, as returned by IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetChannel">REST API Reference for BatchGetChannel Operation</seealso>
        public virtual BatchGetChannelResponse BatchGetChannel(BatchGetChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetChannelResponseUnmarshaller.Instance;

            return Invoke<BatchGetChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetChannel operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetChannel">REST API Reference for BatchGetChannel Operation</seealso>
        public virtual IAsyncResult BeginBatchGetChannel(BatchGetChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetChannel.</param>
        /// 
        /// <returns>Returns a  BatchGetChannelResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetChannel">REST API Reference for BatchGetChannel Operation</seealso>
        public virtual BatchGetChannelResponse EndBatchGetChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetStreamKey

        /// <summary>
        /// Performs <a>GetStreamKey</a> on multiple ARNs simultaneously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetStreamKey service method.</param>
        /// 
        /// <returns>The response from the BatchGetStreamKey service method, as returned by IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetStreamKey">REST API Reference for BatchGetStreamKey Operation</seealso>
        public virtual BatchGetStreamKeyResponse BatchGetStreamKey(BatchGetStreamKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetStreamKeyResponseUnmarshaller.Instance;

            return Invoke<BatchGetStreamKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetStreamKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetStreamKey operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetStreamKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetStreamKey">REST API Reference for BatchGetStreamKey Operation</seealso>
        public virtual IAsyncResult BeginBatchGetStreamKey(BatchGetStreamKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetStreamKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetStreamKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetStreamKey.</param>
        /// 
        /// <returns>Returns a  BatchGetStreamKeyResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/BatchGetStreamKey">REST API Reference for BatchGetStreamKey Operation</seealso>
        public virtual BatchGetStreamKeyResponse EndBatchGetStreamKey(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetStreamKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannel

        /// <summary>
        /// Creates a new channel and an associated stream key to start streaming.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
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
        public virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRecordingConfiguration

        /// <summary>
        /// Creates a new recording configuration, used to enable recording to Amazon S3.
        /// 
        ///  
        /// <para>
        ///  <b>Known issue:</b> In the us-east-1 region, if you use the Amazon Web Services CLI
        /// to create a recording configuration, it returns success even if the S3 bucket is in
        /// a different region. In this case, the <code>state</code> of the recording configuration
        /// is <code>CREATE_FAILED</code> (instead of <code>ACTIVE</code>). (In other regions,
        /// the CLI correctly returns failure if the bucket is in a different region.)
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
        public virtual CreateRecordingConfigurationResponse CreateRecordingConfiguration(CreateRecordingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRecordingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecordingConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateRecordingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRecordingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRecordingConfiguration operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRecordingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateRecordingConfiguration">REST API Reference for CreateRecordingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateRecordingConfiguration(CreateRecordingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRecordingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecordingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRecordingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRecordingConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateRecordingConfigurationResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateRecordingConfiguration">REST API Reference for CreateRecordingConfiguration Operation</seealso>
        public virtual CreateRecordingConfigurationResponse EndCreateRecordingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRecordingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStreamKey

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
        public virtual CreateStreamKeyResponse CreateStreamKey(CreateStreamKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamKeyResponseUnmarshaller.Instance;

            return Invoke<CreateStreamKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamKey operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStreamKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateStreamKey">REST API Reference for CreateStreamKey Operation</seealso>
        public virtual IAsyncResult BeginCreateStreamKey(CreateStreamKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStreamKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStreamKey.</param>
        /// 
        /// <returns>Returns a  CreateStreamKeyResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/CreateStreamKey">REST API Reference for CreateStreamKey Operation</seealso>
        public virtual CreateStreamKeyResponse EndCreateStreamKey(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStreamKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteChannel

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
        public virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePlaybackKeyPair

        /// <summary>
        /// Deletes a specified authorization key pair. This invalidates future viewer tokens
        /// generated using the key pair’s <code>privateKey</code>. For more information, see
        /// <a href="https://docs.aws.amazon.com/ivs/latest/userguide/private-channels.html">Setting
        /// Up Private Channels</a> in the <i>Amazon IVS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackKeyPair service method.</param>
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
        public virtual DeletePlaybackKeyPairResponse DeletePlaybackKeyPair(DeletePlaybackKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlaybackKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackKeyPairResponseUnmarshaller.Instance;

            return Invoke<DeletePlaybackKeyPairResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlaybackKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlaybackKeyPair operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlaybackKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeletePlaybackKeyPair">REST API Reference for DeletePlaybackKeyPair Operation</seealso>
        public virtual IAsyncResult BeginDeletePlaybackKeyPair(DeletePlaybackKeyPairRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlaybackKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlaybackKeyPairResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlaybackKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlaybackKeyPair.</param>
        /// 
        /// <returns>Returns a  DeletePlaybackKeyPairResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeletePlaybackKeyPair">REST API Reference for DeletePlaybackKeyPair Operation</seealso>
        public virtual DeletePlaybackKeyPairResponse EndDeletePlaybackKeyPair(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePlaybackKeyPairResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRecordingConfiguration

        /// <summary>
        /// Deletes the recording configuration for the specified ARN.
        /// 
        ///  
        /// <para>
        /// If you try to delete a recording configuration that is associated with a channel,
        /// you will get an error (409 ConflictException). To avoid this, for all channels that
        /// reference the recording configuration, first use <a>UpdateChannel</a> to set the <code>recordingConfigurationArn</code>
        /// field to an empty string, then use DeleteRecordingConfiguration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecordingConfiguration service method.</param>
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
        public virtual DeleteRecordingConfigurationResponse DeleteRecordingConfiguration(DeleteRecordingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecordingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecordingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteRecordingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecordingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecordingConfiguration operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecordingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteRecordingConfiguration">REST API Reference for DeleteRecordingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteRecordingConfiguration(DeleteRecordingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecordingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecordingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecordingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecordingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteRecordingConfigurationResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteRecordingConfiguration">REST API Reference for DeleteRecordingConfiguration Operation</seealso>
        public virtual DeleteRecordingConfigurationResponse EndDeleteRecordingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRecordingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStreamKey

        /// <summary>
        /// Deletes the stream key for the specified ARN, so it can no longer be used to stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamKey service method.</param>
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
        public virtual DeleteStreamKeyResponse DeleteStreamKey(DeleteStreamKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamKey operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStreamKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteStreamKey">REST API Reference for DeleteStreamKey Operation</seealso>
        public virtual IAsyncResult BeginDeleteStreamKey(DeleteStreamKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStreamKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStreamKey.</param>
        /// 
        /// <returns>Returns a  DeleteStreamKeyResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/DeleteStreamKey">REST API Reference for DeleteStreamKey Operation</seealso>
        public virtual DeleteStreamKeyResponse EndDeleteStreamKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStreamKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChannel

        /// <summary>
        /// Gets the channel configuration for the specified channel ARN. See also <a>BatchGetChannel</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannel service method.</param>
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
        public virtual GetChannelResponse GetChannel(GetChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelResponseUnmarshaller.Instance;

            return Invoke<GetChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannel operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetChannel">REST API Reference for GetChannel Operation</seealso>
        public virtual IAsyncResult BeginGetChannel(GetChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannel.</param>
        /// 
        /// <returns>Returns a  GetChannelResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetChannel">REST API Reference for GetChannel Operation</seealso>
        public virtual GetChannelResponse EndGetChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPlaybackKeyPair

        /// <summary>
        /// Gets a specified playback authorization key pair and returns the <code>arn</code>
        /// and <code>fingerprint</code>. The <code>privateKey</code> held by the caller can be
        /// used to generate viewer authorization tokens, to grant viewers access to private channels.
        /// For more information, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/private-channels.html">Setting
        /// Up Private Channels</a> in the <i>Amazon IVS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackKeyPair service method.</param>
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
        public virtual GetPlaybackKeyPairResponse GetPlaybackKeyPair(GetPlaybackKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaybackKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackKeyPairResponseUnmarshaller.Instance;

            return Invoke<GetPlaybackKeyPairResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlaybackKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlaybackKeyPair operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlaybackKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetPlaybackKeyPair">REST API Reference for GetPlaybackKeyPair Operation</seealso>
        public virtual IAsyncResult BeginGetPlaybackKeyPair(GetPlaybackKeyPairRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPlaybackKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPlaybackKeyPairResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlaybackKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlaybackKeyPair.</param>
        /// 
        /// <returns>Returns a  GetPlaybackKeyPairResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetPlaybackKeyPair">REST API Reference for GetPlaybackKeyPair Operation</seealso>
        public virtual GetPlaybackKeyPairResponse EndGetPlaybackKeyPair(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPlaybackKeyPairResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecordingConfiguration

        /// <summary>
        /// Gets the recording configuration for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecordingConfiguration service method.</param>
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
        public virtual GetRecordingConfigurationResponse GetRecordingConfiguration(GetRecordingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecordingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetRecordingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecordingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecordingConfiguration operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecordingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetRecordingConfiguration">REST API Reference for GetRecordingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetRecordingConfiguration(GetRecordingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecordingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecordingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecordingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetRecordingConfigurationResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetRecordingConfiguration">REST API Reference for GetRecordingConfiguration Operation</seealso>
        public virtual GetRecordingConfigurationResponse EndGetRecordingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecordingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStream

        /// <summary>
        /// Gets information about the active (live) stream on a specified channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStream service method.</param>
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
        public virtual GetStreamResponse GetStream(GetStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamResponseUnmarshaller.Instance;

            return Invoke<GetStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStream operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStream">REST API Reference for GetStream Operation</seealso>
        public virtual IAsyncResult BeginGetStream(GetStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStream.</param>
        /// 
        /// <returns>Returns a  GetStreamResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStream">REST API Reference for GetStream Operation</seealso>
        public virtual GetStreamResponse EndGetStream(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStreamKey

        /// <summary>
        /// Gets stream-key information for a specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamKey service method.</param>
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
        public virtual GetStreamKeyResponse GetStreamKey(GetStreamKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamKeyResponseUnmarshaller.Instance;

            return Invoke<GetStreamKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamKey operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStreamKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStreamKey">REST API Reference for GetStreamKey Operation</seealso>
        public virtual IAsyncResult BeginGetStreamKey(GetStreamKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStreamKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamKey.</param>
        /// 
        /// <returns>Returns a  GetStreamKeyResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStreamKey">REST API Reference for GetStreamKey Operation</seealso>
        public virtual GetStreamKeyResponse EndGetStreamKey(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStreamKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStreamSession

        /// <summary>
        /// Gets metadata on a specified stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStreamSession service method.</param>
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
        public virtual GetStreamSessionResponse GetStreamSession(GetStreamSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStreamSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamSessionResponseUnmarshaller.Instance;

            return Invoke<GetStreamSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStreamSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStreamSession operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStreamSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStreamSession">REST API Reference for GetStreamSession Operation</seealso>
        public virtual IAsyncResult BeginGetStreamSession(GetStreamSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStreamSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStreamSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStreamSession.</param>
        /// 
        /// <returns>Returns a  GetStreamSessionResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/GetStreamSession">REST API Reference for GetStreamSession Operation</seealso>
        public virtual GetStreamSessionResponse EndGetStreamSession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStreamSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportPlaybackKeyPair

        /// <summary>
        /// Imports the public portion of a new key pair and returns its <code>arn</code> and
        /// <code>fingerprint</code>. The <code>privateKey</code> can then be used to generate
        /// viewer authorization tokens, to grant viewers access to private channels. For more
        /// information, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/private-channels.html">Setting
        /// Up Private Channels</a> in the <i>Amazon IVS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportPlaybackKeyPair service method.</param>
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
        public virtual ImportPlaybackKeyPairResponse ImportPlaybackKeyPair(ImportPlaybackKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportPlaybackKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportPlaybackKeyPairResponseUnmarshaller.Instance;

            return Invoke<ImportPlaybackKeyPairResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportPlaybackKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportPlaybackKeyPair operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportPlaybackKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ImportPlaybackKeyPair">REST API Reference for ImportPlaybackKeyPair Operation</seealso>
        public virtual IAsyncResult BeginImportPlaybackKeyPair(ImportPlaybackKeyPairRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportPlaybackKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportPlaybackKeyPairResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportPlaybackKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportPlaybackKeyPair.</param>
        /// 
        /// <returns>Returns a  ImportPlaybackKeyPairResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ImportPlaybackKeyPair">REST API Reference for ImportPlaybackKeyPair Operation</seealso>
        public virtual ImportPlaybackKeyPairResponse EndImportPlaybackKeyPair(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportPlaybackKeyPairResponse>(asyncResult);
        }

        #endregion
        
        #region  ListChannels

        /// <summary>
        /// Gets summary information about all channels in your account, in the Amazon Web Services
        /// region where the API request is processed. This list can be filtered to match a specified
        /// name or recording-configuration ARN. Filters are mutually exclusive and cannot be
        /// used together. If you try to use both filters, you will get an error (409 ConflictException).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
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
        public virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse EndListChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPlaybackKeyPairs

        /// <summary>
        /// Gets summary information about playback key pairs. For more information, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/private-channels.html">Setting
        /// Up Private Channels</a> in the <i>Amazon IVS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackKeyPairs service method.</param>
        /// 
        /// <returns>The response from the ListPlaybackKeyPairs service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListPlaybackKeyPairs">REST API Reference for ListPlaybackKeyPairs Operation</seealso>
        public virtual ListPlaybackKeyPairsResponse ListPlaybackKeyPairs(ListPlaybackKeyPairsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlaybackKeyPairsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackKeyPairsResponseUnmarshaller.Instance;

            return Invoke<ListPlaybackKeyPairsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlaybackKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlaybackKeyPairs operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlaybackKeyPairs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListPlaybackKeyPairs">REST API Reference for ListPlaybackKeyPairs Operation</seealso>
        public virtual IAsyncResult BeginListPlaybackKeyPairs(ListPlaybackKeyPairsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlaybackKeyPairsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlaybackKeyPairsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlaybackKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlaybackKeyPairs.</param>
        /// 
        /// <returns>Returns a  ListPlaybackKeyPairsResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListPlaybackKeyPairs">REST API Reference for ListPlaybackKeyPairs Operation</seealso>
        public virtual ListPlaybackKeyPairsResponse EndListPlaybackKeyPairs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPlaybackKeyPairsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRecordingConfigurations

        /// <summary>
        /// Gets summary information about all recording configurations in your account, in the
        /// Amazon Web Services region where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecordingConfigurations service method.</param>
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
        public virtual ListRecordingConfigurationsResponse ListRecordingConfigurations(ListRecordingConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecordingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecordingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListRecordingConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecordingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecordingConfigurations operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecordingConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListRecordingConfigurations">REST API Reference for ListRecordingConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListRecordingConfigurations(ListRecordingConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecordingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecordingConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecordingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecordingConfigurations.</param>
        /// 
        /// <returns>Returns a  ListRecordingConfigurationsResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListRecordingConfigurations">REST API Reference for ListRecordingConfigurations Operation</seealso>
        public virtual ListRecordingConfigurationsResponse EndListRecordingConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRecordingConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStreamKeys

        /// <summary>
        /// Gets summary information about stream keys for the specified channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamKeys service method.</param>
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
        public virtual ListStreamKeysResponse ListStreamKeys(ListStreamKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamKeysResponseUnmarshaller.Instance;

            return Invoke<ListStreamKeysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamKeys operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreamKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreamKeys">REST API Reference for ListStreamKeys Operation</seealso>
        public virtual IAsyncResult BeginListStreamKeys(ListStreamKeysRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamKeysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreamKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamKeys.</param>
        /// 
        /// <returns>Returns a  ListStreamKeysResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreamKeys">REST API Reference for ListStreamKeys Operation</seealso>
        public virtual ListStreamKeysResponse EndListStreamKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStreamKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStreams

        /// <summary>
        /// Gets summary information about live streams in your account, in the Amazon Web Services
        /// region where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by IVS.</returns>
        /// <exception cref="Amazon.IVS.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IVS.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual ListStreamsResponse ListStreams(ListStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return Invoke<ListStreamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreams operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual IAsyncResult BeginListStreams(ListStreamsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreams.</param>
        /// 
        /// <returns>Returns a  ListStreamsResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreams">REST API Reference for ListStreams Operation</seealso>
        public virtual ListStreamsResponse EndListStreams(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStreamsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStreamSessions

        /// <summary>
        /// Gets a summary of current and previous streams for a specified channel in your account,
        /// in the AWS region where the API request is processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamSessions service method.</param>
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
        public virtual ListStreamSessionsResponse ListStreamSessions(ListStreamSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamSessionsResponseUnmarshaller.Instance;

            return Invoke<ListStreamSessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamSessions operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreamSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreamSessions">REST API Reference for ListStreamSessions Operation</seealso>
        public virtual IAsyncResult BeginListStreamSessions(ListStreamSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreamSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreamSessions.</param>
        /// 
        /// <returns>Returns a  ListStreamSessionsResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListStreamSessions">REST API Reference for ListStreamSessions Operation</seealso>
        public virtual ListStreamSessionsResponse EndListStreamSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStreamSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Gets information about Amazon Web Services tags for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutMetadata

        /// <summary>
        /// Inserts metadata into the active stream of the specified channel. At most 5 requests
        /// per second per channel are allowed, each with a maximum 1 KB payload. (If 5 TPS is
        /// not sufficient for your needs, we recommend batching your data into a single PutMetadata
        /// call.) At most 155 requests per second per account are allowed. Also see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/metadata.html">Embedding
        /// Metadata within a Video Stream</a> in the <i>Amazon IVS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetadata service method.</param>
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
        public virtual PutMetadataResponse PutMetadata(PutMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetadataResponseUnmarshaller.Instance;

            return Invoke<PutMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetadata operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/PutMetadata">REST API Reference for PutMetadata Operation</seealso>
        public virtual IAsyncResult BeginPutMetadata(PutMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetadata.</param>
        /// 
        /// <returns>Returns a  PutMetadataResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/PutMetadata">REST API Reference for PutMetadata Operation</seealso>
        public virtual PutMetadataResponse EndPutMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  StopStream

        /// <summary>
        /// Disconnects the incoming RTMPS stream for the specified channel. Can be used in conjunction
        /// with <a>DeleteStreamKey</a> to prevent further streaming to a channel.
        /// 
        ///  <note> 
        /// <para>
        /// Many streaming client-software libraries automatically reconnect a dropped RTMPS session,
        /// so to stop the stream permanently, you may want to first revoke the <code>streamKey</code>
        /// attached to the channel.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStream service method.</param>
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
        public virtual StopStreamResponse StopStream(StopStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamResponseUnmarshaller.Instance;

            return Invoke<StopStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStream operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/StopStream">REST API Reference for StopStream Operation</seealso>
        public virtual IAsyncResult BeginStopStream(StopStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopStream.</param>
        /// 
        /// <returns>Returns a  StopStreamResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/StopStream">REST API Reference for StopStream Operation</seealso>
        public virtual StopStreamResponse EndStopStream(IAsyncResult asyncResult)
        {
            return EndInvoke<StopStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or updates tags for the Amazon Web Services resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from the resource with the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChannel

        /// <summary>
        /// Updates a channel's configuration. This does not affect an ongoing stream of this
        /// channel. You must stop and restart the stream for the changes to take effect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
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
        public virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonIVSClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from IVS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ivs-2020-07-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelResponse>(asyncResult);
        }

        #endregion
        
    }
}