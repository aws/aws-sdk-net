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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISustainabilityPaginatorFactory Paginators { get; }

        
        #region  GetEstimatedCarbonEmissions


        /// <summary>
        /// Returns estimated carbon emission values based on customer grouping and filtering
        /// parameters. We recommend using pagination to ensure that the operation returns quickly
        /// and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEstimatedCarbonEmissions service method.</param>
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
        GetEstimatedCarbonEmissionsResponse GetEstimatedCarbonEmissions(GetEstimatedCarbonEmissionsRequest request);



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
        Task<GetEstimatedCarbonEmissionsResponse> GetEstimatedCarbonEmissionsAsync(GetEstimatedCarbonEmissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEstimatedCarbonEmissionsDimensionValues


        /// <summary>
        /// Returns the possible dimension values available for a customer's account. We recommend
        /// using pagination to ensure that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEstimatedCarbonEmissionsDimensionValues service method.</param>
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
        GetEstimatedCarbonEmissionsDimensionValuesResponse GetEstimatedCarbonEmissionsDimensionValues(GetEstimatedCarbonEmissionsDimensionValuesRequest request);



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
        Task<GetEstimatedCarbonEmissionsDimensionValuesResponse> GetEstimatedCarbonEmissionsDimensionValuesAsync(GetEstimatedCarbonEmissionsDimensionValuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}