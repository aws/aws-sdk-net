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

namespace Amazon.Pricing.Model
{
    /// <summary>
    /// This is the response object from the ListPriceLists operation.
    /// </summary>
    public partial class ListPriceListsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PriceList> _priceLists = new List<PriceList>();

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
        /// Gets and sets the property PriceLists. 
        /// <para>
        /// The type of price list references that match your request. 
        /// </para>
        /// </summary>
        public List<PriceList> PriceLists
        {
            get { return this._priceLists; }
            set { this._priceLists = value; }
        }

        // Check to see if PriceLists property is set
        internal bool IsSetPriceLists()
        {
            return this._priceLists != null && this._priceLists.Count > 0; 
        }

    }
}