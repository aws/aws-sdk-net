/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that controls the countries in which your content is distributed. 
    ///       For more information about geo restriction, go to Customizing Error Responses
    /// in        the Amazon CloudFront Developer Guide.       CloudFront determines the location
    /// of your users using MaxMind GeoIP databases.        For information about the accuracy
    /// of these databases, see How accurate are        your GeoIP databases? on the MaxMind
    /// website.
    /// </summary>
    public partial class GeoRestriction
    {
        private List<string> _items = new List<string>();
        private int? _quantity;
        private string _restrictionType;


        /// <summary>
        /// Gets and sets the property Items. A complex type that contains a Location element
        /// for each country in which you want        CloudFront either to distribute your content
        /// (whitelist) or not distribute your        content (blacklist).        The Location
        /// element is a two-letter, uppercase country code for a country that        you want
        /// to include in your blacklist or whitelist. Include one Location element        for
        /// each country.       CloudFront and MaxMind both use ISO 3166 country codes. For the
        /// current list of        countries and the corresponding codes, see ISO 3166-1-alpha-2
        /// code on the International        Organization for Standardization website. You can
        /// also refer to the country list        in the CloudFront console, which includes both
        /// country names and codes.
        /// </summary>
        public List<string> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        /// <summary>
        /// Sets the Items property
        /// </summary>
        /// <param name="items">The values to add to the Items collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GeoRestriction WithItems(params string[] items)
        {
            foreach (var element in items)
            {
                this._items.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Items property
        /// </summary>
        /// <param name="items">The values to add to the Items collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GeoRestriction WithItems(IEnumerable<string> items)
        {
            foreach (var element in items)
            {
                this._items.Add(element);
            }
            return this;
        }
        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Quantity. When geo restriction is enabled, this is the
        /// number of countries in your whitelist        or blacklist. Otherwise, when it is not
        /// enabled, Quantity is 0, and you can omit Items.
        /// </summary>
        public int Quantity
        {
            get { return this._quantity.GetValueOrDefault(); }
            set { this._quantity = value; }
        }


        /// <summary>
        /// Sets the Quantity property
        /// </summary>
        /// <param name="quantity">The value to set for the Quantity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GeoRestriction WithQuantity(int quantity)
        {
            this._quantity = quantity;
            return this;
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property RestrictionType. The method that you want to use to restrict
        /// distribution of your content by country:       - none: No geo restriction is enabled,
        /// meaning access to content is not restricted                    by client geo location.
        ///       - blacklist: The Location elements specify the countries in which you do not
        /// want                     CloudFront to distribute your content.       - whitelist:
        /// The Location elements specify the countries in which you want CloudFront         
        ///            to distribute your content.
        /// </summary>
        public string RestrictionType
        {
            get { return this._restrictionType; }
            set { this._restrictionType = value; }
        }


        /// <summary>
        /// Sets the RestrictionType property
        /// </summary>
        /// <param name="restrictionType">The value to set for the RestrictionType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GeoRestriction WithRestrictionType(string restrictionType)
        {
            this._restrictionType = restrictionType;
            return this;
        }

        // Check to see if RestrictionType property is set
        internal bool IsSetRestrictionType()
        {
            return this._restrictionType != null;
        }

    }
}