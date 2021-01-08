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

namespace Amazon.IoTSecureTunneling
{
    /// <summary>
    /// Interface for accessing IoTSecureTunneling
    ///
    /// AWS IoT Secure Tunneling 
    /// <para>
    /// AWS IoT Secure Tunnling enables you to create remote connections to devices deployed
    /// in the field.
    /// </para>
    ///  
    /// <para>
    /// For more information about how AWS IoT Secure Tunneling works, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/secure-tunneling.html">AWS
    /// IoT Secure Tunneling</a>.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
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
        /// Closes a tunnel identified by the unique tunnel id. When a <code>CloseTunnel</code>
        /// request is received, we close the WebSocket connections between the client and proxy
        /// server so no data can be transmitted.
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
        /// List all tunnels for an AWS account. Tunnels are listed by creation time in descending
        /// order, newer tunnels will be listed before older tunnels.
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
        /// to the AWS IoT Secure Tunneling proxy server.
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
        
    }
}