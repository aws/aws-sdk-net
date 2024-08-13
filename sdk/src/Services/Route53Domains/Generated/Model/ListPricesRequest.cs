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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
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
namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the ListPrices operation.
    /// Lists the following prices for either all the TLDs supported by Route 53, or the specified
    /// TLD:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Registration
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Transfer
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Owner change
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Domain renewal
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Domain restoration
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListPricesRequest : AmazonRoute53DomainsRequest
    {
        private string _marker;
        private int? _maxItems;
        private string _tld;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// For an initial request for a list of prices, omit this element. If the number of prices
        /// that are not yet complete is greater than the value that you specified for <c>MaxItems</c>,
        /// you can use <c>Marker</c> to return additional prices. Get the value of <c>NextPageMarker</c>
        /// from the previous response, and submit another request that includes the value of
        /// <c>NextPageMarker</c> in the <c>Marker</c> element. 
        /// </para>
        ///  
        /// <para>
        /// Used only for all TLDs. If you specify a TLD, don't specify a <c>Marker</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Number of <c>Prices</c> to be returned.
        /// </para>
        ///  
        /// <para>
        /// Used only for all TLDs. If you specify a TLD, don't specify a <c>MaxItems</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tld. 
        /// <para>
        /// The TLD for which you want to receive the pricing information. For example. <c>.net</c>.
        /// </para>
        ///  
        /// <para>
        /// If a <c>Tld</c> value is not provided, a list of prices for all TLDs supported by
        /// Route 53 is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=255)]
        public string Tld
        {
            get { return this._tld; }
            set { this._tld = value; }
        }

        // Check to see if Tld property is set
        internal bool IsSetTld()
        {
            return this._tld != null;
        }

    }
}