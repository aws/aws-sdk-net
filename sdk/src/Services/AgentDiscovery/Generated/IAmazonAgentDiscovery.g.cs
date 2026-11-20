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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.AgentDiscovery.Model;

#pragma warning disable CS1570

namespace Amazon.AgentDiscovery
{
    /// <summary>
    /// <para>Interface for accessing AgentDiscovery</para>
    ///
    /// Agent Discovery lets you search public records for AI agents, tools, skills, and other
    /// resources that their publishers have made discoverable.
    /// </summary>
    public partial interface IAmazonAgentDiscovery : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAgentDiscoveryPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Search public agent records across the authoritative + crawler indexes. Hybrid keyword
        /// + neural ranking, merged and fused (weighted RRF), with filters, org governance policy,
        /// and descriptor-visibility enforcement applied server-side. Public, authenticated (D-1).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPublicRecords service method.</param>
        /// <returns>The response from the SearchPublicRecords service method, as returned by AgentDiscovery.</returns>
        /// <exception cref="Amazon.AgentDiscovery.Model.InternalServerException">
        /// Thrown on an internal defect — a bug or malformed state, not a failed dependency.
        /// 
        /// &lt;para&gt;
        /// ⚠️ Deliberately a **permanent** failure. Repeating a request that failed to serialize
        /// will fail identically, so treating a 500 as retryable would spin a poison message
        /// through redelivery forever instead of letting it reach a dead-letter queue. Dependency
        /// failures that *are* worth retrying use `ServiceUnavailableException` and its 503 instead.
        /// </exception>
        /// <exception cref="Amazon.AgentDiscovery.Model.ThrottlingException">
        /// Thrown when the caller exceeds a rate/burst limit (D-9). ARD's code for it is `RATE_LIMIT_EXCEEDED`.
        /// </exception>
        /// <exception cref="Amazon.AgentDiscovery.Model.ValidationException">
        /// Thrown when a request fails input validation. 
        /// &lt;para&gt;
        /// `errorCode` carries ARD's Appendix B code, `INVALID_ARGUMENT`, which ARD's OpenAPI
        /// makes a required member of every error body on the ARD surface. The Amazon-shaped
        /// and internal surfaces leave it unset.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-discovery-2022-07-26/SearchPublicRecords">REST API Reference for SearchPublicRecords Operation</seealso>
        SearchPublicRecordsResponse SearchPublicRecords(SearchPublicRecordsRequest request);
#endif

        /// <summary>
        /// Search public agent records across the authoritative + crawler indexes. Hybrid keyword
        /// + neural ranking, merged and fused (weighted RRF), with filters, org governance policy,
        /// and descriptor-visibility enforcement applied server-side. Public, authenticated (D-1).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchPublicRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SearchPublicRecords service method, as returned by AgentDiscovery.</returns>
        /// <exception cref="Amazon.AgentDiscovery.Model.InternalServerException">
        /// Thrown on an internal defect — a bug or malformed state, not a failed dependency.
        /// 
        /// &lt;para&gt;
        /// ⚠️ Deliberately a **permanent** failure. Repeating a request that failed to serialize
        /// will fail identically, so treating a 500 as retryable would spin a poison message
        /// through redelivery forever instead of letting it reach a dead-letter queue. Dependency
        /// failures that *are* worth retrying use `ServiceUnavailableException` and its 503 instead.
        /// </exception>
        /// <exception cref="Amazon.AgentDiscovery.Model.ThrottlingException">
        /// Thrown when the caller exceeds a rate/burst limit (D-9). ARD's code for it is `RATE_LIMIT_EXCEEDED`.
        /// </exception>
        /// <exception cref="Amazon.AgentDiscovery.Model.ValidationException">
        /// Thrown when a request fails input validation. 
        /// &lt;para&gt;
        /// `errorCode` carries ARD's Appendix B code, `INVALID_ARGUMENT`, which ARD's OpenAPI
        /// makes a required member of every error body on the ARD surface. The Amazon-shaped
        /// and internal surfaces leave it unset.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-discovery-2022-07-26/SearchPublicRecords">REST API Reference for SearchPublicRecords Operation</seealso>
        Task<SearchPublicRecordsResponse> SearchPublicRecordsAsync(SearchPublicRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonAgentDiscoveryConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonAgentDiscoveryConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonAgentDiscoveryConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonAgentDiscoveryConfig to create AmazonAgentDiscoveryClient");
            }

            return awsCredentials == null ?
                    new AmazonAgentDiscoveryClient(serviceClientConfig) :
                    new AmazonAgentDiscoveryClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
