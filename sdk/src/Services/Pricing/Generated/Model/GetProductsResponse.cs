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
    /// This is the response object from the GetProducts operation.
    /// </summary>
    public partial class GetProductsResponse : AmazonWebServiceResponse
    {
        private string _formatVersion;
        private string _nextToken;
        private List<string> _priceList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FormatVersion. 
        /// <para>
        /// The format version of the response. For example, aws_v1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string FormatVersion
        {
            get { return this._formatVersion; }
            set { this._formatVersion = value; }
        }

        // Check to see if FormatVersion property is set
        internal bool IsSetFormatVersion()
        {
            return this._formatVersion != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token that indicates the next set of results to retrieve.
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
        /// Gets and sets the property PriceList. 
        /// <para>
        /// The list of products that match your filters. The list contains both the product metadata
        /// and the price information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PriceList
        {
            get { return this._priceList; }
            set { this._priceList = value; }
        }

        // Check to see if PriceList property is set
        internal bool IsSetPriceList()
        {
            return this._priceList != null && (this._priceList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}