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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SavingsPlans.Model;

#pragma warning disable CS1570
namespace Amazon.SavingsPlans
{
    /// <summary>
    /// <para>Interface for accessing SavingsPlans</para>
    ///
    /// Savings Plans are a pricing model that offer significant savings on Amazon Web Services
    /// usage (for example, on Amazon EC2 instances). You commit to a consistent amount of
    /// usage per hour, in the specified currency, for a term of one or three years, and receive
    /// a lower price for that usage. For more information, see the <a href="https://docs.aws.amazon.com/savingsplans/latest/userguide/">Amazon
    /// Web Services Savings Plans User Guide</a>.
    /// </summary>
    public partial interface IAmazonSavingsPlans : IAmazonService, IDisposable
    {
                
        #region  CreateSavingsPlan



        /// <summary>
        /// Creates a Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSavingsPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/CreateSavingsPlan">REST API Reference for CreateSavingsPlan Operation</seealso>
        Task<CreateSavingsPlanResponse> CreateSavingsPlanAsync(CreateSavingsPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteQueuedSavingsPlan



        /// <summary>
        /// Deletes the queued purchase for the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueuedSavingsPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueuedSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DeleteQueuedSavingsPlan">REST API Reference for DeleteQueuedSavingsPlan Operation</seealso>
        Task<DeleteQueuedSavingsPlanResponse> DeleteQueuedSavingsPlanAsync(DeleteQueuedSavingsPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSavingsPlanRates



        /// <summary>
        /// Describes the rates for the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlanRates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSavingsPlanRates service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlanRates">REST API Reference for DescribeSavingsPlanRates Operation</seealso>
        Task<DescribeSavingsPlanRatesResponse> DescribeSavingsPlanRatesAsync(DescribeSavingsPlanRatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSavingsPlans



        /// <summary>
        /// Describes the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSavingsPlans service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlans">REST API Reference for DescribeSavingsPlans Operation</seealso>
        Task<DescribeSavingsPlansResponse> DescribeSavingsPlansAsync(DescribeSavingsPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSavingsPlansOfferingRates



        /// <summary>
        /// Describes the offering rates for the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferingRates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSavingsPlansOfferingRates service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferingRates">REST API Reference for DescribeSavingsPlansOfferingRates Operation</seealso>
        Task<DescribeSavingsPlansOfferingRatesResponse> DescribeSavingsPlansOfferingRatesAsync(DescribeSavingsPlansOfferingRatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSavingsPlansOfferings



        /// <summary>
        /// Describes the offerings for the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSavingsPlansOfferings service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferings">REST API Reference for DescribeSavingsPlansOfferings Operation</seealso>
        Task<DescribeSavingsPlansOfferingsResponse> DescribeSavingsPlansOfferingsAsync(DescribeSavingsPlansOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <returns>The response from the ListTagsForResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReturnSavingsPlan



        /// <summary>
        /// Returns the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReturnSavingsPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReturnSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ReturnSavingsPlan">REST API Reference for ReturnSavingsPlan Operation</seealso>
        Task<ReturnSavingsPlanResponse> ReturnSavingsPlanAsync(ReturnSavingsPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSavingsPlansConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSavingsPlansConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSavingsPlansConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSavingsPlansConfig to create AmazonSavingsPlansClient");
            }

            return awsCredentials == null ? 
                    new AmazonSavingsPlansClient(serviceClientConfig) :
                    new AmazonSavingsPlansClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}