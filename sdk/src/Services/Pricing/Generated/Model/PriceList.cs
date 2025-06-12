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
    /// <i> <b>This feature is in preview release and is subject to change. Your use of Amazon
    /// Web Services Price List API is subject to the Beta Service Participation terms of
    /// the <a href="https://aws.amazon.com/service-terms/">Amazon Web Services Service Terms</a>
    /// (Section 1.10).</b> </i> 
    /// 
    ///  
    /// <para>
    /// This is the type of price list references that match your request. 
    /// </para>
    /// </summary>
    public partial class PriceList
    {
        private string _currencyCode;
        private List<string> _fileFormats = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _priceListArn;
        private string _regionCode;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The three alphabetical character ISO-4217 currency code the Price List files are denominated
        /// in. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FileFormats. 
        /// <para>
        /// The format you want to retrieve your Price List files. The <c>FileFormat</c> can be
        /// obtained from the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_pricing_ListPriceLists.html">
        /// <c>ListPriceList</c> </a> response. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FileFormats
        {
            get { return this._fileFormats; }
            set { this._fileFormats = value; }
        }

        // Check to see if FileFormats property is set
        internal bool IsSetFileFormats()
        {
            return this._fileFormats != null && (this._fileFormats.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PriceListArn. 
        /// <para>
        /// The unique identifier that maps to where your Price List files are located. <c>PriceListArn</c>
        /// can be obtained from the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_pricing_ListPriceLists.html">
        /// <c>ListPriceList</c> </a> response. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=18, Max=2048)]
        public string PriceListArn
        {
            get { return this._priceListArn; }
            set { this._priceListArn = value; }
        }

        // Check to see if PriceListArn property is set
        internal bool IsSetPriceListArn()
        {
            return this._priceListArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegionCode. 
        /// <para>
        /// This is used to filter the Price List by Amazon Web Services Region. For example,
        /// to get the price list only for the <c>US East (N. Virginia)</c> Region, use <c>us-east-1</c>.
        /// If nothing is specified, you retrieve price lists for all applicable Regions. The
        /// available <c>RegionCode</c> list can be retrieved from <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_pricing_GetAttributeValues.html">
        /// <c>GetAttributeValues</c> </a> API. 
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

    }
}