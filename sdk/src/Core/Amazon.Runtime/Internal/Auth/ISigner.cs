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

using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Identity;

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// <para>
    /// A signer is an entity within the SDK representing a way to generate a signature for a request.
    /// </para>
    /// <para>
    /// A signature is metadata attached to a request that will be sent to the service in order to allow
    /// the service to authenticate the SDK customer's identity.
    /// </para>
    /// </summary>
    public interface ISigner
    {
        /// <summary> 
        /// Signs the provided HTTP request using the provided identity. Throws an exception if the 
        /// identity is not compatible with this signer. 
        /// </summary> 
        /// <param name="request">The request to be signed</param> 
        /// <param name="clientConfig">Client configuration settings</param> 
        /// <param name="metrics">Request metrics to be tracked</param> 
        /// <param name="identity">The identity to be used for signing</param> 
        void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, BaseIdentity identity);

        /// <summary> 
        /// Asynchronously signs the provided HTTP request using the provided identity. Throws an exception if the 
        /// identity is not compatible with this signer. 
        /// </summary> 
        /// <param name="request">The request to be signed</param> 
        /// <param name="clientConfig">Client configuration settings</param> 
        /// <param name="metrics">Request metrics to be tracked</param> 
        /// <param name="identity">The identity to be used for signing</param> 
        /// <param name="token">Cancellation token for the async operation</param> 
        /// <returns>A Task representing the asynchronous signing operation</returns> 
        Task SignAsync(
        IRequest request,
        IClientConfig clientConfig,
        RequestMetrics metrics,
        BaseIdentity identity,
        CancellationToken token = default);

        /// <summary> 
        /// Gets the client protocol used by this signer. 
        /// </summary> 
        ClientProtocol Protocol { get; }

        /// <summary> 
        /// Signals to the <see cref="Signer"/> Pipeline Handler 
        /// if a Signer requires valid credentials in order to 
        /// correctly <see cref="Sign(IRequest,IClientConfig,RequestMetrics,BaseIdentity)"/>.
        /// </summary> 
        bool RequiresCredentials { get; }

        /// <summary>
        /// Creates an event signer based on the signer used to sign the request.
        /// </summary>
        /// <param name="identity">The identity to sign the request with.</param>
        /// <param name="region">The region to authenticate for.</param>
        /// <param name="service">The service to authenticate for.</param>
        /// <param name="requestSignature">The signature computed for the original request.</param>
        /// <returns></returns>
        IEventSigner CreateEventSigner(BaseIdentity identity, string region, string service, string requestSignature);
    }
}
