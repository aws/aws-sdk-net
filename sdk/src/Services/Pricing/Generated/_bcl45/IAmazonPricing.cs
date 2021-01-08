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
 * Do not modify this file. This file is generated from the pricing-2017-10-15.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Pricing.Model;

namespace Amazon.Pricing
{
    /// <summary>
    /// Interface for accessing Pricing
    ///
    /// AWS Price List Service API (AWS Price List Service) is a centralized and convenient
    /// way to programmatically query Amazon Web Services for services, products, and pricing
    /// information. The AWS Price List Service uses standardized product attributes such
    /// as <code>Location</code>, <code>Storage Class</code>, and <code>Operating System</code>,
    /// and provides prices at the SKU level. You can use the AWS Price List Service to build
    /// cost control and scenario planning tools, reconcile billing data, forecast future
    /// spend for budgeting purposes, and provide cost benefit analysis that compare your
    /// internal workloads with AWS.
    /// 
    ///  
    /// <para>
    /// Use <code>GetServices</code> without a service code to retrieve the service codes
    /// for all AWS services, then <code>GetServices</code> with a service code to retreive
    /// the attribute names for that service. After you have the service code and attribute
    /// names, you can use <code>GetAttributeValues</code> to see what values are available
    /// for an attribute. With the service code and an attribute name and value, you can use
    /// <code>GetProducts</code> to find specific products that you're interested in, such
    /// as an <code>AmazonEC2</code> instance, with a <code>Provisioned IOPS</code> <code>volumeType</code>.
    /// </para>
    ///  
    /// <para>
    /// Service Endpoint
    /// </para>
    ///  
    /// <para>
    /// AWS Price List Service API provides the following two endpoints:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// https://api.pricing.us-east-1.amazonaws.com
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// https://api.pricing.ap-south-1.amazonaws.com
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonPricing : IAmazonService, IDisposable
    {


        
        #region  DescribeServices


        /// <summary>
        /// Returns the metadata for one service or a list of the metadata for all services. Use
        /// this without a service code to get the service codes for all services. Use it with
        /// a service code, such as <code>AmazonEC2</code>, to get information specific to that
        /// service, such as the attribute names available for that service. For example, some
        /// of the attribute names available for EC2 are <code>volumeType</code>, <code>maxIopsVolume</code>,
        /// <code>operation</code>, <code>locationType</code>, and <code>instanceCapacity10xlarge</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices service method.</param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by Pricing.</returns>
        /// <exception cref="Amazon.Pricing.Model.ExpiredNextTokenException">
        /// The pagination token expired. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.NotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        DescribeServicesResponse DescribeServices(DescribeServicesRequest request);



        /// <summary>
        /// Returns the metadata for one service or a list of the metadata for all services. Use
        /// this without a service code to get the service codes for all services. Use it with
        /// a service code, such as <code>AmazonEC2</code>, to get information specific to that
        /// service, such as the attribute names available for that service. For example, some
        /// of the attribute names available for EC2 are <code>volumeType</code>, <code>maxIopsVolume</code>,
        /// <code>operation</code>, <code>locationType</code>, and <code>instanceCapacity10xlarge</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by Pricing.</returns>
        /// <exception cref="Amazon.Pricing.Model.ExpiredNextTokenException">
        /// The pagination token expired. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.NotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        Task<DescribeServicesResponse> DescribeServicesAsync(DescribeServicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAttributeValues


        /// <summary>
        /// Returns a list of attribute values. Attibutes are similar to the details in a Price
        /// List API offer file. For a list of available attributes, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/reading-an-offer.html#pps-defs">Offer
        /// File Definitions</a> in the <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/billing-what-is.html">AWS
        /// Billing and Cost Management User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttributeValues service method.</param>
        /// 
        /// <returns>The response from the GetAttributeValues service method, as returned by Pricing.</returns>
        /// <exception cref="Amazon.Pricing.Model.ExpiredNextTokenException">
        /// The pagination token expired. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.NotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetAttributeValues">REST API Reference for GetAttributeValues Operation</seealso>
        GetAttributeValuesResponse GetAttributeValues(GetAttributeValuesRequest request);



        /// <summary>
        /// Returns a list of attribute values. Attibutes are similar to the details in a Price
        /// List API offer file. For a list of available attributes, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/reading-an-offer.html#pps-defs">Offer
        /// File Definitions</a> in the <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/billing-what-is.html">AWS
        /// Billing and Cost Management User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttributeValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAttributeValues service method, as returned by Pricing.</returns>
        /// <exception cref="Amazon.Pricing.Model.ExpiredNextTokenException">
        /// The pagination token expired. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.NotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetAttributeValues">REST API Reference for GetAttributeValues Operation</seealso>
        Task<GetAttributeValuesResponse> GetAttributeValuesAsync(GetAttributeValuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetProducts


        /// <summary>
        /// Returns a list of all products that match the filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProducts service method.</param>
        /// 
        /// <returns>The response from the GetProducts service method, as returned by Pricing.</returns>
        /// <exception cref="Amazon.Pricing.Model.ExpiredNextTokenException">
        /// The pagination token expired. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.NotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetProducts">REST API Reference for GetProducts Operation</seealso>
        GetProductsResponse GetProducts(GetProductsRequest request);



        /// <summary>
        /// Returns a list of all products that match the filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProducts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProducts service method, as returned by Pricing.</returns>
        /// <exception cref="Amazon.Pricing.Model.ExpiredNextTokenException">
        /// The pagination token expired. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.NotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetProducts">REST API Reference for GetProducts Operation</seealso>
        Task<GetProductsResponse> GetProductsAsync(GetProductsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}