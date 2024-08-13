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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KinesisVideoSignalingChannels.Model;

#pragma warning disable CS1570
namespace Amazon.KinesisVideoSignalingChannels
{
    /// <summary>
    /// <para>Interface for accessing KinesisVideoSignalingChannels</para>
    ///
    /// Kinesis Video Streams Signaling Service is a intermediate service that establishes
    /// a communication channel for discovering peers, transmitting offers and answers in
    /// order to establish peer-to-peer connection in webRTC technology.
    /// </summary>
    public partial interface IAmazonKinesisVideoSignalingChannels : IAmazonService, IDisposable
    {
                
        #region  GetIceServerConfig



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
        Task<GetIceServerConfigResponse> GetIceServerConfigAsync(GetIceServerConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendAlexaOfferToMaster



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
        Task<SendAlexaOfferToMasterResponse> SendAlexaOfferToMasterAsync(SendAlexaOfferToMasterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonKinesisVideoSignalingChannelsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonKinesisVideoSignalingChannelsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonKinesisVideoSignalingChannelsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonKinesisVideoSignalingChannelsConfig to create AmazonKinesisVideoSignalingChannelsClient");
            }

            return awsCredentials == null ? 
                    new AmazonKinesisVideoSignalingChannelsClient(serviceClientConfig) :
                    new AmazonKinesisVideoSignalingChannelsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}