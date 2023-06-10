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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Pricing.Model;

namespace Amazon.Pricing
{
    /// <summary>
    /// Interface for accessing Pricing
    ///
    /// Amazon Web Services Price List API is a centralized and convenient way to programmatically
    /// query Amazon Web Services for services, products, and pricing information. The Amazon
    /// Web Services Price List uses standardized product attributes such as <code>Location</code>,
    /// <code>Storage Class</code>, and <code>Operating System</code>, and provides prices
    /// at the SKU level. You can use the Amazon Web Services Price List to build cost control
    /// and scenario planning tools, reconcile billing data, forecast future spend for budgeting
    /// purposes, and provide cost benefit analysis that compare your internal workloads with
    /// Amazon Web Services.
    /// 
    ///  
    /// <para>
    /// Use <code>GetServices</code> without a service code to retrieve the service codes
    /// for all AWS services, then <code>GetServices</code> with a service code to retrieve
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
    /// Amazon Web Services Price List service API provides the following two endpoints:
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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPricingPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the DescribeServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices operation on AmazonPricingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        IAsyncResult BeginDescribeServices(DescribeServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServices.</param>
        /// 
        /// <returns>Returns a  DescribeServicesResult from Pricing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        DescribeServicesResponse EndDescribeServices(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAttributeValues


        /// <summary>
        /// Returns a list of attribute values. Attributes are similar to the details in a Price
        /// List API offer file. For a list of available attributes, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/reading-an-offer.html#pps-defs">Offer
        /// File Definitions</a> in the <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/billing-what-is.html">Billing
        /// and Cost Management User Guide</a>.
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
        /// Initiates the asynchronous execution of the GetAttributeValues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAttributeValues operation on AmazonPricingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAttributeValues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetAttributeValues">REST API Reference for GetAttributeValues Operation</seealso>
        IAsyncResult BeginGetAttributeValues(GetAttributeValuesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAttributeValues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAttributeValues.</param>
        /// 
        /// <returns>Returns a  GetAttributeValuesResult from Pricing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetAttributeValues">REST API Reference for GetAttributeValues Operation</seealso>
        GetAttributeValuesResponse EndGetAttributeValues(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPriceListFileUrl


        /// <summary>
        /// <i> <b>This feature is in preview release and is subject to change. Your use of Amazon
        /// Web Services Price List API is subject to the Beta Service Participation terms of
        /// the <a href="https://aws.amazon.com/service-terms/">Amazon Web Services Service Terms</a>
        /// (Section 1.10).</b> </i> 
        /// 
        ///  
        /// <para>
        /// This returns the URL that you can retrieve your Price List file from. This URL is
        /// based on the <code>PriceListArn</code> and <code>FileFormat</code> that you retrieve
        /// from the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_pricing_ListPriceLists.html">
        /// <code>ListPriceLists</code> </a> response. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPriceListFileUrl service method.</param>
        /// 
        /// <returns>The response from the GetPriceListFileUrl service method, as returned by Pricing.</returns>
        /// <exception cref="Amazon.Pricing.Model.AccessDeniedException">
        /// General authentication failure. The request wasn't signed correctly.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.NotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetPriceListFileUrl">REST API Reference for GetPriceListFileUrl Operation</seealso>
        GetPriceListFileUrlResponse GetPriceListFileUrl(GetPriceListFileUrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPriceListFileUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPriceListFileUrl operation on AmazonPricingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPriceListFileUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetPriceListFileUrl">REST API Reference for GetPriceListFileUrl Operation</seealso>
        IAsyncResult BeginGetPriceListFileUrl(GetPriceListFileUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPriceListFileUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPriceListFileUrl.</param>
        /// 
        /// <returns>Returns a  GetPriceListFileUrlResult from Pricing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetPriceListFileUrl">REST API Reference for GetPriceListFileUrl Operation</seealso>
        GetPriceListFileUrlResponse EndGetPriceListFileUrl(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProducts operation on AmazonPricingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetProducts">REST API Reference for GetProducts Operation</seealso>
        IAsyncResult BeginGetProducts(GetProductsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProducts.</param>
        /// 
        /// <returns>Returns a  GetProductsResult from Pricing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetProducts">REST API Reference for GetProducts Operation</seealso>
        GetProductsResponse EndGetProducts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPriceLists


        /// <summary>
        /// <i> <b>This feature is in preview release and is subject to change. Your use of Amazon
        /// Web Services Price List API is subject to the Beta Service Participation terms of
        /// the <a href="https://aws.amazon.com/service-terms/">Amazon Web Services Service Terms</a>
        /// (Section 1.10).</b> </i> 
        /// 
        ///  
        /// <para>
        /// This returns a list of Price List references that the requester if authorized to view,
        /// given a <code>ServiceCode</code>, <code>CurrencyCode</code>, and an <code>EffectiveDate</code>.
        /// Use without a <code>RegionCode</code> filter to list Price List references from all
        /// available Amazon Web Services Regions. Use with a <code>RegionCode</code> filter to
        /// get the Price List reference that's specific to a specific Amazon Web Services Region.
        /// You can use the <code>PriceListArn</code> from the response to get your preferred
        /// Price List files through the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_pricing_GetPriceListFileUrl.html">
        /// <code>GetPriceListFileUrl</code> </a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPriceLists service method.</param>
        /// 
        /// <returns>The response from the ListPriceLists service method, as returned by Pricing.</returns>
        /// <exception cref="Amazon.Pricing.Model.AccessDeniedException">
        /// General authentication failure. The request wasn't signed correctly.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/ListPriceLists">REST API Reference for ListPriceLists Operation</seealso>
        ListPriceListsResponse ListPriceLists(ListPriceListsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPriceLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPriceLists operation on AmazonPricingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPriceLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/ListPriceLists">REST API Reference for ListPriceLists Operation</seealso>
        IAsyncResult BeginListPriceLists(ListPriceListsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPriceLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPriceLists.</param>
        /// 
        /// <returns>Returns a  ListPriceListsResult from Pricing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/ListPriceLists">REST API Reference for ListPriceLists Operation</seealso>
        ListPriceListsResponse EndListPriceLists(IAsyncResult asyncResult);

        #endregion
        
    }
}