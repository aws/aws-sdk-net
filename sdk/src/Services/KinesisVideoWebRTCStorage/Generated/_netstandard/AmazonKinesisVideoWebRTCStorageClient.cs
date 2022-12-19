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
 * Do not modify this file. This file is generated from the kinesis-video-webrtc-storage-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.KinesisVideoWebRTCStorage.Model;
using Amazon.KinesisVideoWebRTCStorage.Model.Internal.MarshallTransformations;
using Amazon.KinesisVideoWebRTCStorage.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KinesisVideoWebRTCStorage
{
    /// <summary>
    /// Implementation for accessing KinesisVideoWebRTCStorage
    ///
    /// 
    /// </summary>
    public partial class AmazonKinesisVideoWebRTCStorageClient : AmazonServiceClient, IAmazonKinesisVideoWebRTCStorage
    {
        private static IServiceMetadata serviceMetadata = new AmazonKinesisVideoWebRTCStorageMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonKinesisVideoWebRTCStorageClient with the credentials loaded from the application's
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
        public AmazonKinesisVideoWebRTCStorageClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisVideoWebRTCStorageConfig()) { }

        /// <summary>
        /// Constructs AmazonKinesisVideoWebRTCStorageClient with the credentials loaded from the application's
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
        public AmazonKinesisVideoWebRTCStorageClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisVideoWebRTCStorageConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKinesisVideoWebRTCStorageClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKinesisVideoWebRTCStorageClient Configuration Object</param>
        public AmazonKinesisVideoWebRTCStorageClient(AmazonKinesisVideoWebRTCStorageConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonKinesisVideoWebRTCStorageClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKinesisVideoWebRTCStorageClient(AWSCredentials credentials)
            : this(credentials, new AmazonKinesisVideoWebRTCStorageConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoWebRTCStorageClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisVideoWebRTCStorageClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKinesisVideoWebRTCStorageConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoWebRTCStorageClient with AWS Credentials and an
        /// AmazonKinesisVideoWebRTCStorageClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKinesisVideoWebRTCStorageClient Configuration Object</param>
        public AmazonKinesisVideoWebRTCStorageClient(AWSCredentials credentials, AmazonKinesisVideoWebRTCStorageConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoWebRTCStorageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKinesisVideoWebRTCStorageClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisVideoWebRTCStorageConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoWebRTCStorageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisVideoWebRTCStorageClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisVideoWebRTCStorageConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoWebRTCStorageClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisVideoWebRTCStorageClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKinesisVideoWebRTCStorageClient Configuration Object</param>
        public AmazonKinesisVideoWebRTCStorageClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisVideoWebRTCStorageConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoWebRTCStorageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKinesisVideoWebRTCStorageClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisVideoWebRTCStorageConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoWebRTCStorageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisVideoWebRTCStorageClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisVideoWebRTCStorageConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoWebRTCStorageClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisVideoWebRTCStorageClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKinesisVideoWebRTCStorageClient Configuration Object</param>
        public AmazonKinesisVideoWebRTCStorageClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisVideoWebRTCStorageConfig clientConfig)
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKinesisVideoWebRTCStorageEndpointResolver());
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


        #region  JoinStorageSession

        internal virtual JoinStorageSessionResponse JoinStorageSession(JoinStorageSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JoinStorageSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JoinStorageSessionResponseUnmarshaller.Instance;

            return Invoke<JoinStorageSessionResponse>(request, options);
        }



        /// <summary>
        /// Join the ongoing one way-video and/or multi-way audio WebRTC session as a video producing
        /// device for an input channel. If there’s no existing session for the channel, a new
        /// streaming session needs to be created, and the Amazon Resource Name (ARN) of the signaling
        /// channel must be provided. 
        /// 
        ///  
        /// <para>
        /// Currently for the <code>SINGLE_MASTER</code> type, a video producing device is able
        /// to ingest both audio and video media into a stream, while viewers can only ingest
        /// audio. Both a video producing device and viewers can join the session first, and wait
        /// for other participants.
        /// </para>
        ///  
        /// <para>
        /// While participants are having peer to peer conversations through webRTC, the ingested
        /// media session will be stored into the Kinesis Video Stream. Multiple viewers are able
        /// to playback real-time media.
        /// </para>
        ///  
        /// <para>
        /// Customers can also use existing Kinesis Video Streams features like <code>HLS</code>
        /// or <code>DASH</code> playback, Image generation, and more with ingested WebRTC media.
        /// </para>
        ///  <note> 
        /// <para>
        /// Assume that only one video producing device client can be associated with a session
        /// for the channel. If more than one client joins the session of a specific channel as
        /// a video producing device, the most recent client request takes precedence. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JoinStorageSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JoinStorageSession service method, as returned by KinesisVideoWebRTCStorage.</returns>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.AccessDeniedException">
        /// <ol> <li> 
        /// <para>
        /// You do not have required permissions to perform this operation
        /// </para>
        ///  </li> </ol> <ol> <li> 
        /// <para>
        /// The <code>AccessDeniedException</code> can be thrown for operation access as well
        /// as tokens or resource access
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.InvalidArgumentException">
        /// <ol> <li> 
        /// <para>
        /// The value for this input parameter is invalid.
        /// </para>
        ///  </li> </ol> <ol> <li> 
        /// <para>
        /// Additional details may <b>not</b>be returned.
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.ResourceNotFoundException">
        /// <ol> <li> 
        /// <para>
        /// The specified resource is not found
        /// </para>
        ///  </li> </ol> <ol> <li> 
        /// <para>
        /// You have not specified a channel in this API call.
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-webrtc-storage-2018-05-10/JoinStorageSession">REST API Reference for JoinStorageSession Operation</seealso>
        public virtual Task<JoinStorageSessionResponse> JoinStorageSessionAsync(JoinStorageSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JoinStorageSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JoinStorageSessionResponseUnmarshaller.Instance;

            return InvokeAsync<JoinStorageSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  JoinStorageSessionAsViewer

        internal virtual JoinStorageSessionAsViewerResponse JoinStorageSessionAsViewer(JoinStorageSessionAsViewerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JoinStorageSessionAsViewerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JoinStorageSessionAsViewerResponseUnmarshaller.Instance;

            return Invoke<JoinStorageSessionAsViewerResponse>(request, options);
        }



        /// <summary>
        /// Join the ongoing one way-video and/or multi-way audio WebRTC session as a viewer
        /// for an input channel. If there’s no existing session for the channel, create a new
        /// streaming session and provide the Amazon Resource Name (ARN) of the signaling channel
        /// (<code>channelArn</code>) and client id (<code>clientId</code>). 
        /// 
        ///  
        /// <para>
        /// Currently for <code>SINGLE_MASTER</code> type, a video producing device is able to
        /// ingest both audio and video media into a stream, while viewers can only ingest audio.
        /// Both a video producing device and viewers can join a session first and wait for other
        /// participants. While participants are having peer to peer conversations through webRTC,
        /// the ingested media session will be stored into the Kinesis Video Stream. Multiple
        /// viewers are able to playback real-time media. 
        /// </para>
        ///  
        /// <para>
        /// Customers can also use existing Kinesis Video Streams features like <code>HLS</code>
        /// or <code>DASH</code> playback, Image generation, and more with ingested WebRTC media.
        /// If there’s an existing session with the same <code>clientId</code> that's found in
        /// the join session request, the new request takes precedence.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JoinStorageSessionAsViewer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JoinStorageSessionAsViewer service method, as returned by KinesisVideoWebRTCStorage.</returns>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.AccessDeniedException">
        /// <ol> <li> 
        /// <para>
        /// You do not have required permissions to perform this operation
        /// </para>
        ///  </li> </ol> <ol> <li> 
        /// <para>
        /// The <code>AccessDeniedException</code> can be thrown for operation access as well
        /// as tokens or resource access
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.InvalidArgumentException">
        /// <ol> <li> 
        /// <para>
        /// The value for this input parameter is invalid.
        /// </para>
        ///  </li> </ol> <ol> <li> 
        /// <para>
        /// Additional details may <b>not</b>be returned.
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoWebRTCStorage.Model.ResourceNotFoundException">
        /// <ol> <li> 
        /// <para>
        /// The specified resource is not found
        /// </para>
        ///  </li> </ol> <ol> <li> 
        /// <para>
        /// You have not specified a channel in this API call.
        /// </para>
        ///  </li> </ol>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-webrtc-storage-2018-05-10/JoinStorageSessionAsViewer">REST API Reference for JoinStorageSessionAsViewer Operation</seealso>
        public virtual Task<JoinStorageSessionAsViewerResponse> JoinStorageSessionAsViewerAsync(JoinStorageSessionAsViewerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = JoinStorageSessionAsViewerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = JoinStorageSessionAsViewerResponseUnmarshaller.Instance;

            return InvokeAsync<JoinStorageSessionAsViewerResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}