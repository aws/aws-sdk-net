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
 * Do not modify this file. This file is generated from the agent-registry-2025-12-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AgentRegistry.Model;

#pragma warning disable CS1570
namespace Amazon.AgentRegistry
{
    /// <summary>
    /// <para>Interface for accessing AgentRegistry</para>
    ///
    /// Agent Registry lets callers discover, list, and retrieve approved records published
    /// to a registry.
    /// </summary>
    public partial interface IAmazonAgentRegistry : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAgentRegistryPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchGetDiscoverableRegistryRecord



        /// <summary>
        /// Retrieves multiple discoverable registry records by ID from a single registry. Records
        /// that cannot be retrieved are reported individually in the <c>errors</c> list rather
        /// than failing the entire request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetDiscoverableRegistryRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetDiscoverableRegistryRecord service method, as returned by AgentRegistry.</returns>
        /// <exception cref="Amazon.AgentRegistry.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.UnauthorizedException">
        /// The request could not be authenticated.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-2025-12-01/BatchGetDiscoverableRegistryRecord">REST API Reference for BatchGetDiscoverableRegistryRecord Operation</seealso>
        Task<BatchGetDiscoverableRegistryRecordResponse> BatchGetDiscoverableRegistryRecordAsync(BatchGetDiscoverableRegistryRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDiscoverableRegistryRecords



        /// <summary>
        /// Lists the discoverable registry records in a registry. You can optionally filter
        /// and paginate the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoverableRegistryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDiscoverableRegistryRecords service method, as returned by AgentRegistry.</returns>
        /// <exception cref="Amazon.AgentRegistry.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.UnauthorizedException">
        /// The request could not be authenticated.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-2025-12-01/ListDiscoverableRegistryRecords">REST API Reference for ListDiscoverableRegistryRecords Operation</seealso>
        Task<ListDiscoverableRegistryRecordsResponse> ListDiscoverableRegistryRecordsAsync(ListDiscoverableRegistryRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchDiscoverableRegistryRecords



        /// <summary>
        /// Searches the discoverable registry records in a registry using a natural language
        /// query. Returns metadata for the matching records ordered by relevance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDiscoverableRegistryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchDiscoverableRegistryRecords service method, as returned by AgentRegistry.</returns>
        /// <exception cref="Amazon.AgentRegistry.Model.AccessDeniedException">
        /// The caller is not authorized to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.InternalServerException">
        /// The request failed due to an unexpected internal error; the caller may retry.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ThrottlingException">
        /// The request was denied due to request throttling; the caller may retry after a delay.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.UnauthorizedException">
        /// The request could not be authenticated.
        /// </exception>
        /// <exception cref="Amazon.AgentRegistry.Model.ValidationException">
        /// The request failed validation of one or more input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/agent-registry-2025-12-01/SearchDiscoverableRegistryRecords">REST API Reference for SearchDiscoverableRegistryRecords Operation</seealso>
        Task<SearchDiscoverableRegistryRecordsResponse> SearchDiscoverableRegistryRecordsAsync(SearchDiscoverableRegistryRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonAgentRegistryConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonAgentRegistryConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonAgentRegistryConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonAgentRegistryConfig to create AmazonAgentRegistryClient");
            }

            return awsCredentials == null ? 
                    new AmazonAgentRegistryClient(serviceClientConfig) :
                    new AmazonAgentRegistryClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}