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
 * Do not modify this file. This file is generated from the kinesis-video-signaling-2019-12-04.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.KinesisVideoSignalingChannels.Model;
using Amazon.KinesisVideoSignalingChannels.Model.Internal.MarshallTransformations;
using Amazon.KinesisVideoSignalingChannels.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.KinesisVideoSignalingChannels
{
    /// <summary>
    /// <para>Implementation for accessing KinesisVideoSignalingChannels</para>
    ///
    /// Kinesis Video Streams Signaling Service is a intermediate service that establishes
    /// a communication channel for discovering peers, transmitting offers and answers in
    /// order to establish peer-to-peer connection in webRTC technology.
    /// </summary>
    public partial class AmazonKinesisVideoSignalingChannelsClient : AmazonServiceClient, IAmazonKinesisVideoSignalingChannels
    {
        private static IServiceMetadata serviceMetadata = new AmazonKinesisVideoSignalingChannelsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonKinesisVideoSignalingChannelsClient with the credentials loaded from the application's
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
        public AmazonKinesisVideoSignalingChannelsClient()
            : base(new AmazonKinesisVideoSignalingChannelsConfig()) { }

        /// <summary>
        /// Constructs AmazonKinesisVideoSignalingChannelsClient with the credentials loaded from the application's
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
        public AmazonKinesisVideoSignalingChannelsClient(RegionEndpoint region)
            : base(new AmazonKinesisVideoSignalingChannelsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKinesisVideoSignalingChannelsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKinesisVideoSignalingChannelsClient Configuration Object</param>
        public AmazonKinesisVideoSignalingChannelsClient(AmazonKinesisVideoSignalingChannelsConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonKinesisVideoSignalingChannelsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKinesisVideoSignalingChannelsClient(AWSCredentials credentials)
            : this(credentials, new AmazonKinesisVideoSignalingChannelsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoSignalingChannelsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisVideoSignalingChannelsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKinesisVideoSignalingChannelsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoSignalingChannelsClient with AWS Credentials and an
        /// AmazonKinesisVideoSignalingChannelsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKinesisVideoSignalingChannelsClient Configuration Object</param>
        public AmazonKinesisVideoSignalingChannelsClient(AWSCredentials credentials, AmazonKinesisVideoSignalingChannelsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoSignalingChannelsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKinesisVideoSignalingChannelsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisVideoSignalingChannelsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoSignalingChannelsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisVideoSignalingChannelsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisVideoSignalingChannelsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoSignalingChannelsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisVideoSignalingChannelsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKinesisVideoSignalingChannelsClient Configuration Object</param>
        public AmazonKinesisVideoSignalingChannelsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisVideoSignalingChannelsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoSignalingChannelsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKinesisVideoSignalingChannelsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisVideoSignalingChannelsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoSignalingChannelsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisVideoSignalingChannelsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisVideoSignalingChannelsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisVideoSignalingChannelsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisVideoSignalingChannelsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKinesisVideoSignalingChannelsClient Configuration Object</param>
        public AmazonKinesisVideoSignalingChannelsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisVideoSignalingChannelsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKinesisVideoSignalingChannelsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKinesisVideoSignalingChannelsAuthSchemeHandler());
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


        #region  GetIceServerConfig

        internal virtual GetIceServerConfigResponse GetIceServerConfig(GetIceServerConfigRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIceServerConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIceServerConfigResponseUnmarshaller.Instance;

            return Invoke<GetIceServerConfigResponse>(request, options);
        }



        /// <summary>
        /// Gets the Interactive Connectivity Establishment (ICE) server configuration information,
        /// including URIs, username, and password which can be used to configure the WebRTC connection.
        /// The ICE component uses this configuration information to setup the WebRTC connection,
        /// including authenticating with the Traversal Using Relays around NAT (TURN) relay server.
        /// 
        /// 
        ///  
        /// <para>
        /// TURN is a protocol that is used to improve the connectivity of peer-to-peer applications.
        /// By providing a cloud-based relay service, TURN ensures that a connection can be established
        /// even when one or more peers are incapable of a direct peer-to-peer connection. For
        /// more information, see <a href="https://tools.ietf.org/html/draft-uberti-rtcweb-turn-rest-00">A
        /// REST API For Access To TURN Services</a>.
        /// </para>
        ///  
        /// <para>
        ///  You can invoke this API to establish a fallback mechanism in case either of the peers
        /// is unable to establish a direct peer-to-peer connection over a signaling channel.
        /// You must specify either a signaling channel ARN or the client ID in order to invoke
        /// this API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIceServerConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIceServerConfig service method, as returned by KinesisVideoSignalingChannels.</returns>
        /// <exception cref="Amazon.KinesisVideoSignalingChannels.Model.ClientLimitExceededException">
        /// Your request was throttled because you have exceeded the limit of allowed client calls.
        /// Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoSignalingChannels.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoSignalingChannels.Model.InvalidClientException">
        /// The specified client is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoSignalingChannels.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoSignalingChannels.Model.ResourceNotFoundException">
        /// The specified resource is not found.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoSignalingChannels.Model.SessionExpiredException">
        /// If the client session is expired. Once the client is connected, the session is valid
        /// for 45 minutes. Client should reconnect to the channel to continue sending/receiving
        /// messages.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-signaling-2019-12-04/GetIceServerConfig">REST API Reference for GetIceServerConfig Operation</seealso>
        public virtual Task<GetIceServerConfigResponse> GetIceServerConfigAsync(GetIceServerConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIceServerConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIceServerConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetIceServerConfigResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendAlexaOfferToMaster

        internal virtual SendAlexaOfferToMasterResponse SendAlexaOfferToMaster(SendAlexaOfferToMasterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendAlexaOfferToMasterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendAlexaOfferToMasterResponseUnmarshaller.Instance;

            return Invoke<SendAlexaOfferToMasterResponse>(request, options);
        }



        /// <summary>
        /// This API allows you to connect WebRTC-enabled devices with Alexa display devices.
        /// When invoked, it sends the Alexa Session Description Protocol (SDP) offer to the master
        /// peer. The offer is delivered as soon as the master is connected to the specified signaling
        /// channel. This API returns the SDP answer from the connected master. If the master
        /// is not connected to the signaling channel, redelivery requests are made until the
        /// message expires.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendAlexaOfferToMaster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendAlexaOfferToMaster service method, as returned by KinesisVideoSignalingChannels.</returns>
        /// <exception cref="Amazon.KinesisVideoSignalingChannels.Model.ClientLimitExceededException">
        /// Your request was throttled because you have exceeded the limit of allowed client calls.
        /// Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoSignalingChannels.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoSignalingChannels.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoSignalingChannels.Model.ResourceNotFoundException">
        /// The specified resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-signaling-2019-12-04/SendAlexaOfferToMaster">REST API Reference for SendAlexaOfferToMaster Operation</seealso>
        public virtual Task<SendAlexaOfferToMasterResponse> SendAlexaOfferToMasterAsync(SendAlexaOfferToMasterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendAlexaOfferToMasterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendAlexaOfferToMasterResponseUnmarshaller.Instance;

            return InvokeAsync<SendAlexaOfferToMasterResponse>(request, options, cancellationToken);
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