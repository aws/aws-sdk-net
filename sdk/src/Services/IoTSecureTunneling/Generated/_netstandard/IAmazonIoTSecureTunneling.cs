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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTSecureTunneling.Model;

#pragma warning disable CS1570
namespace Amazon.IoTSecureTunneling
{
    /// <summary>
    /// <para>Interface for accessing IoTSecureTunneling</para>
    ///
    /// IoT Secure Tunneling 
    /// <para>
    /// IoT Secure Tunneling creates remote connections to devices deployed in the field.
    /// </para>
    ///  
    /// <para>
    /// For more information about how IoT Secure Tunneling works, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/secure-tunneling.html">IoT
    /// Secure Tunneling</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonIoTSecureTunneling : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTSecureTunnelingPaginatorFactory Paginators { get; }
#endif
                
        #region  CloseTunnel



        /// <summary>
        /// Closes a tunnel identified by the unique tunnel id. When a <c>CloseTunnel</c> request
        /// is received, we close the WebSocket connections between the client and proxy server
        /// so no data can be transmitted.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CloseTunnel</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloseTunnel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CloseTunnel service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/CloseTunnel">REST API Reference for CloseTunnel Operation</seealso>
        Task<CloseTunnelResponse> CloseTunnelAsync(CloseTunnelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTunnel



        /// <summary>
        /// Gets information about a tunnel identified by the unique tunnel id.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeTunnel</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTunnel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTunnel service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/DescribeTunnel">REST API Reference for DescribeTunnel Operation</seealso>
        Task<DescribeTunnelResponse> DescribeTunnelAsync(DescribeTunnelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTunnels



        /// <summary>
        /// List all tunnels for an Amazon Web Services account. Tunnels are listed by creation
        /// time in descending order, newer tunnels will be listed before older tunnels.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListTunnels</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTunnels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTunnels service method, as returned by IoTSecureTunneling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/ListTunnels">REST API Reference for ListTunnels Operation</seealso>
        Task<ListTunnelsResponse> ListTunnelsAsync(ListTunnelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  OpenTunnel



        /// <summary>
        /// Creates a new tunnel, and returns two client access tokens for clients to use to connect
        /// to the IoT Secure Tunneling proxy server.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">OpenTunnel</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OpenTunnel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OpenTunnel service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.LimitExceededException">
        /// Thrown when a tunnel limit is exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/OpenTunnel">REST API Reference for OpenTunnel Operation</seealso>
        Task<OpenTunnelResponse> OpenTunnelAsync(OpenTunnelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RotateTunnelAccessToken



        /// <summary>
        /// Revokes the current client access token (CAT) and returns new CAT for clients to use
        /// when reconnecting to secure tunneling to access the same tunnel.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RotateTunnelAccessToken</a>
        /// action.
        /// </para>
        ///  <note> 
        /// <para>
        /// Rotating the CAT doesn't extend the tunnel duration. For example, say the tunnel duration
        /// is 12 hours and the tunnel has already been open for 4 hours. When you rotate the
        /// access tokens, the new tokens that are generated can only be used for the remaining
        /// 8 hours.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateTunnelAccessToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RotateTunnelAccessToken service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/RotateTunnelAccessToken">REST API Reference for RotateTunnelAccessToken Operation</seealso>
        Task<RotateTunnelAccessTokenResponse> RotateTunnelAccessTokenAsync(RotateTunnelAccessTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// A resource tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTSecureTunneling.</returns>
        /// <exception cref="Amazon.IoTSecureTunneling.Model.ResourceNotFoundException">
        /// Thrown when an operation is attempted on a resource that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsecuretunneling-2018-10-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonIoTSecureTunnelingConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonIoTSecureTunnelingConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonIoTSecureTunnelingConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonIoTSecureTunnelingConfig to create AmazonIoTSecureTunnelingClient");
            }

            return awsCredentials == null ? 
                    new AmazonIoTSecureTunnelingClient(serviceClientConfig) :
                    new AmazonIoTSecureTunnelingClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}