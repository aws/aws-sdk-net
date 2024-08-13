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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Pricing.Model
{
    /// <summary>
    /// Container for the parameters to the ListPriceLists operation.
    /// <i> <b>This feature is in preview release and is subject to change. Your use of Amazon
    /// Web Services Price List API is subject to the Beta Service Participation terms of
    /// the <a href="https://aws.amazon.com/service-terms/">Amazon Web Services Service Terms</a>
    /// (Section 1.10).</b> </i> 
    /// 
    ///  
    /// <para>
    /// This returns a list of Price List references that the requester if authorized to view,
    /// given a <c>ServiceCode</c>, <c>CurrencyCode</c>, and an <c>EffectiveDate</c>. Use
    /// without a <c>RegionCode</c> filter to list Price List references from all available
    /// Amazon Web Services Regions. Use with a <c>RegionCode</c> filter to get the Price
    /// List reference that's specific to a specific Amazon Web Services Region. You can use
    /// the <c>PriceListArn</c> from the response to get your preferred Price List files through
    /// the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_pricing_GetPriceListFileUrl.html">GetPriceListFileUrl</a>
    /// API.
    /// </para>
    /// </summary>
    public partial class ListPriceListsRequest : AmazonPricingRequest
    {
        private string _currencyCode;
        private DateTime? _effectiveDate;
        private int? _maxResults;
        private string _nextToken;
        private string _regionCode;
        private string _serviceCode;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The three alphabetical character ISO-4217 currency code that the Price List files
        /// are denominated in. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveDate. 
        /// <para>
        /// The date that the Price List file prices are effective from. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EffectiveDate
        {
            get { return this._effectiveDate; }
            set { this._effectiveDate = value; }
        }

        // Check to see if EffectiveDate property is set
        internal bool IsSetEffectiveDate()
        {
            return this._effectiveDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token that indicates the next set of results that you want to retrieve.
        /// 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RegionCode. 
        /// <para>
        /// This is used to filter the Price List by Amazon Web Services Region. For example,
        /// to get the price list only for the <c>US East (N. Virginia)</c> Region, use <c>us-east-1</c>.
        /// If nothing is specified, you retrieve price lists for all applicable Regions. The
        /// available <c>RegionCode</c> list can be retrieved from <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_pricing_GetAttributeValues.html">GetAttributeValues</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RegionCode
        {
            get { return this._regionCode; }
            set { this._regionCode = value; }
        }

        // Check to see if RegionCode property is set
        internal bool IsSetRegionCode()
        {
            return this._regionCode != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// The service code or the Savings Plan service code for the attributes that you want
        /// to retrieve. For example, to get the list of applicable Amazon EC2 price lists, use
        /// <c>AmazonEC2</c>. For a full list of service codes containing On-Demand and Reserved
        /// Instance (RI) pricing, use the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_pricing_DescribeServices.html#awscostmanagement-pricing_DescribeServices-request-FormatVersion">DescribeServices</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the Reserved Instance and Compute Savings Plan price lists, use <c>ComputeSavingsPlans</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To retrieve Machine Learning Savings Plans price lists, use <c>MachineLearningSavingsPlans</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

    }
}