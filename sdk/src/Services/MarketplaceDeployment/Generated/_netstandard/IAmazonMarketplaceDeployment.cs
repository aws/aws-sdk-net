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
 * Do not modify this file. This file is generated from the marketplace-deployment-2023-01-25.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MarketplaceDeployment.Model;

#pragma warning disable CS1570
namespace Amazon.MarketplaceDeployment
{
    /// <summary>
    /// <para>Interface for accessing MarketplaceDeployment</para>
    ///
    /// The AWS Marketplace Deployment Service supports the Quick Launch experience, which
    /// is a deployment option for software as a service (SaaS) products. Quick Launch simplifies
    /// and reduces the time, resources, and steps required to configure, deploy, and launch
    /// a products. The AWS Marketplace Deployment Service provides sellers with a secure
    /// method for passing deployment parameters, such as API keys and external IDs, to buyers
    /// during the Quick Launch experience.
    /// </summary>
    public partial interface IAmazonMarketplaceDeployment : IAmazonService, IDisposable
    {
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all tags that have been added to a deployment parameter resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutDeploymentParameter



        /// <summary>
        /// Creates or updates a deployment parameter and is targeted by <c>catalog</c> and <c>agreementId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeploymentParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDeploymentParameter service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ServiceQuotaExceededException">
        /// The maximum number of requests per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/PutDeploymentParameter">REST API Reference for PutDeploymentParameter Operation</seealso>
        Task<PutDeploymentParameterResponse> PutDeploymentParameterAsync(PutDeploymentParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a tag or list of tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MarketplaceDeployment.</returns>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.InternalServerException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceDeployment.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-deployment-2023-01-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonMarketplaceDeploymentConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonMarketplaceDeploymentConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonMarketplaceDeploymentConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonMarketplaceDeploymentConfig to create AmazonMarketplaceDeploymentClient");
            }

            return awsCredentials == null ? 
                    new AmazonMarketplaceDeploymentClient(serviceClientConfig) :
                    new AmazonMarketplaceDeploymentClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}