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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that controls the countries in which your content is distributed. CloudFront
    /// determines the location of your users using <c>MaxMind</c> GeoIP databases.
    /// </summary>
    public partial class GeoRestriction
    {
        private List<string> _items = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _quantity;
        private GeoRestrictionType _restrictionType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GeoRestriction() { }

        /// <summary>
        /// Instantiates GeoRestriction with the parameterized properties
        /// </summary>
        /// <param name="restrictionType">The method that you want to use to restrict distribution of your content by country: <ul> <li>  <c>none</c>: No geo restriction is enabled, meaning access to content is not restricted by client geo location. </li> <li>  <c>blacklist</c>: The <c>Location</c> elements specify the countries in which you don't want CloudFront to distribute your content. </li> <li>  <c>whitelist</c>: The <c>Location</c> elements specify the countries in which you want CloudFront to distribute your content. </li> </ul></param>
        public GeoRestriction(GeoRestrictionType restrictionType)
        {
            _restrictionType = restrictionType;
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// A complex type that contains a <c>Location</c> element for each country in which you
        /// want CloudFront either to distribute your content (<c>whitelist</c>) or not distribute
        /// your content (<c>blacklist</c>).
        /// </para>
        ///  
        /// <para>
        /// The <c>Location</c> element is a two-letter, uppercase country code for a country
        /// that you want to include in your <c>blacklist</c> or <c>whitelist</c>. Include one
        /// <c>Location</c> element for each country.
        /// </para>
        ///  
        /// <para>
        /// CloudFront and <c>MaxMind</c> both use <c>ISO 3166</c> country codes. For the current
        /// list of countries and the corresponding codes, see <c>ISO 3166-1-alpha-2</c> code
        /// on the <i>International Organization for Standardization</i> website. You can also
        /// refer to the country list on the CloudFront console, which includes both country names
        /// and codes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// When geo restriction is <c>enabled</c>, this is the number of countries in your <c>whitelist</c>
        /// or <c>blacklist</c>. Otherwise, when it is not enabled, <c>Quantity</c> is <c>0</c>,
        /// and you can omit <c>Items</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Quantity
        {
            get { return this._quantity; }
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
        ///  <c>none</c>: No geo restriction is enabled, meaning access to content is not restricted
        /// by client geo location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>blacklist</c>: The <c>Location</c> elements specify the countries in which you
        /// don't want CloudFront to distribute your content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>whitelist</c>: The <c>Location</c> elements specify the countries in which you
        /// want CloudFront to distribute your content.
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