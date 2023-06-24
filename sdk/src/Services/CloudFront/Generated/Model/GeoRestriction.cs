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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that controls the countries in which your content is distributed. CloudFront
    /// determines the location of your users using <code>MaxMind</code> GeoIP databases.
    /// </summary>
    public partial class GeoRestriction
    {
        private List<string> _items = new List<string>();
        private int? _quantity;
        private GeoRestrictionType _restrictionType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GeoRestriction() { }

        /// <summary>
        /// Instantiates GeoRestriction with the parameterized properties
        /// </summary>
        /// <param name="restrictionType">The method that you want to use to restrict distribution of your content by country: <ul> <li>  <code>none</code>: No geo restriction is enabled, meaning access to content is not restricted by client geo location. </li> <li>  <code>blacklist</code>: The <code>Location</code> elements specify the countries in which you don't want CloudFront to distribute your content. </li> <li>  <code>whitelist</code>: The <code>Location</code> elements specify the countries in which you want CloudFront to distribute your content. </li> </ul></param>
        public GeoRestriction(GeoRestrictionType restrictionType)
        {
            _restrictionType = restrictionType;
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// A complex type that contains a <code>Location</code> element for each country in which
        /// you want CloudFront either to distribute your content (<code>whitelist</code>) or
        /// not distribute your content (<code>blacklist</code>).
        /// </para>
        ///  
        /// <para>
        /// The <code>Location</code> element is a two-letter, uppercase country code for a country
        /// that you want to include in your <code>blacklist</code> or <code>whitelist</code>.
        /// Include one <code>Location</code> element for each country.
        /// </para>
        ///  
        /// <para>
        /// CloudFront and <code>MaxMind</code> both use <code>ISO 3166</code> country codes.
        /// For the current list of countries and the corresponding codes, see <code>ISO 3166-1-alpha-2</code>
        /// code on the <i>International Organization for Standardization</i> website. You can
        /// also refer to the country list on the CloudFront console, which includes both country
        /// names and codes.
        /// </para>
        /// </summary>
        public List<string> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// When geo restriction is <code>enabled</code>, this is the number of countries in your
        /// <code>whitelist</code> or <code>blacklist</code>. Otherwise, when it is not enabled,
        /// <code>Quantity</code> is <code>0</code>, and you can omit <code>Items</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Quantity
        {
            get { return this._quantity.GetValueOrDefault(); }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestrictionType. 
        /// <para>
        /// The method that you want to use to restrict distribution of your content by country:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>none</code>: No geo restriction is enabled, meaning access to content is not
        /// restricted by client geo location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>blacklist</code>: The <code>Location</code> elements specify the countries
        /// in which you don't want CloudFront to distribute your content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>whitelist</code>: The <code>Location</code> elements specify the countries
        /// in which you want CloudFront to distribute your content.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeoRestrictionType RestrictionType
        {
            get { return this._restrictionType; }
            set { this._restrictionType = value; }
        }

        // Check to see if RestrictionType property is set
        internal bool IsSetRestrictionType()
        {
            return this._restrictionType != null;
        }

    }
}