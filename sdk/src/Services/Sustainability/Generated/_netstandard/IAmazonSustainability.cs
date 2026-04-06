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
 * Do not modify this file. This file is generated from the sustainability-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Sustainability.Model;

#pragma warning disable CS1570
namespace Amazon.Sustainability
{
    /// <summary>
    /// <para>Interface for accessing Sustainability</para>
    ///
    /// The AWS Sustainability service provides programmatic access to estimated carbon emissions
    /// data for your Amazon Web Services usage. Use the AWS Sustainability service to retrieve,
    /// analyze, and track the carbon footprint of your cloud infrastructure over time. 
    /// 
    ///  
    /// <para>
    /// With the AWS Sustainability service, you can:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Retrieve estimated carbon emissions for your Amazon Web Services usage across different
    /// time periods 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Group emissions data by dimensions such as account, region, and service
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Filter emissions data to focus on specific accounts, regions, or services
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Access multiple emissions calculation methodologies including Location-based Method
    /// (LBM) and Market-based Method (MBM) 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Aggregate emissions data at various time granularities including monthly, quarterly,
    /// and yearly periods 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  The API supports pagination for efficient data retrieval and provides dimension values
    /// to help you understand the available grouping and filtering options for your account.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  All emissions values are calculated using methodologies aligned with the Greenhouse
    /// Gas (GHG) Protocol and are provided in metric tons of carbon dioxide-equivalent (MTCO2e).
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonSustainability : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISustainabilityPaginatorFactory Paginators { get; }
#endif
                
        #region  GetEstimatedCarbonEmissions



        /// <summary>
        /// Returns estimated carbon emission values based on customer grouping and filtering
        /// parameters. We recommend using pagination to ensure that the operation returns quickly
        /// and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEstimatedCarbonEmissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEstimatedCarbonEmissions service method, as returned by Sustainability.</returns>
        /// <exception cref="Amazon.Sustainability.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sustainability-2018-05-10/GetEstimatedCarbonEmissions">REST API Reference for GetEstimatedCarbonEmissions Operation</seealso>
        Task<GetEstimatedCarbonEmissionsResponse> GetEstimatedCarbonEmissionsAsync(GetEstimatedCarbonEmissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEstimatedCarbonEmissionsDimensionValues



        /// <summary>
        /// Returns the possible dimension values available for a customer's account. We recommend
        /// using pagination to ensure that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEstimatedCarbonEmissionsDimensionValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEstimatedCarbonEmissionsDimensionValues service method, as returned by Sustainability.</returns>
        /// <exception cref="Amazon.Sustainability.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Sustainability.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sustainability-2018-05-10/GetEstimatedCarbonEmissionsDimensionValues">REST API Reference for GetEstimatedCarbonEmissionsDimensionValues Operation</seealso>
        Task<GetEstimatedCarbonEmissionsDimensionValuesResponse> GetEstimatedCarbonEmissionsDimensionValuesAsync(GetEstimatedCarbonEmissionsDimensionValuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSustainabilityConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSustainabilityConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSustainabilityConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSustainabilityConfig to create AmazonSustainabilityClient");
            }

            return awsCredentials == null ? 
                    new AmazonSustainabilityClient(serviceClientConfig) :
                    new AmazonSustainabilityClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}