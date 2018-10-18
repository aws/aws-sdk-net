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

/*
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListGeoLocations operation.
    /// Retrieves a list of supported geographic locations.
    /// 
    ///  
    /// <para>
    /// Countries are listed first, and continents are listed last. If Amazon Route 53 supports
    /// subdivisions for a country (for example, states or provinces), the subdivisions for
    /// that country are listed in alphabetical order immediately after the corresponding
    /// country.
    /// </para>
    /// </summary>
    public partial class ListGeoLocationsRequest : AmazonRoute53Request
    {
        private string _startContinentCode;
        private string _startCountryCode;
        private string _startSubdivisionCode;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property StartContinentCode. 
        /// <para>
        /// The code for the continent with which you want to start listing locations that Amazon
        /// Route 53 supports for geolocation. If Route 53 has already returned a page or more
        /// of results, if <code>IsTruncated</code> is true, and if <code>NextContinentCode</code>
        /// from the previous response has a value, enter that value in <code>startcontinentcode</code>
        /// to return the next page of results.
        /// </para>
        ///  
        /// <para>
        /// Include <code>startcontinentcode</code> only if you want to list continents. Don't
        /// include <code>startcontinentcode</code> when you're listing countries or countries
        /// with their subdivisions.
        /// </para>
        /// </summary>
        public string StartContinentCode
        {
            get { return this._startContinentCode; }
            set { this._startContinentCode = value; }
        }

        // Check to see if StartContinentCode property is set
        internal bool IsSetStartContinentCode()
        {
            return this._startContinentCode != null;
        }

        /// <summary>
        /// Gets and sets the property StartCountryCode. 
        /// <para>
        /// The code for the country with which you want to start listing locations that Amazon
        /// Route 53 supports for geolocation. If Route 53 has already returned a page or more
        /// of results, if <code>IsTruncated</code> is <code>true</code>, and if <code>NextCountryCode</code>
        /// from the previous response has a value, enter that value in <code>startcountrycode</code>
        /// to return the next page of results.
        /// </para>
        ///  
        /// <para>
        /// Route 53 uses the two-letter country codes that are specified in <a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// standard 3166-1 alpha-2</a>.
        /// </para>
        /// </summary>
        public string StartCountryCode
        {
            get { return this._startCountryCode; }
            set { this._startCountryCode = value; }
        }

        // Check to see if StartCountryCode property is set
        internal bool IsSetStartCountryCode()
        {
            return this._startCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the property StartSubdivisionCode. 
        /// <para>
        /// The code for the subdivision (for example, state or province) with which you want
        /// to start listing locations that Amazon Route 53 supports for geolocation. If Route
        /// 53 has already returned a page or more of results, if <code>IsTruncated</code> is
        /// <code>true</code>, and if <code>NextSubdivisionCode</code> from the previous response
        /// has a value, enter that value in <code>startsubdivisioncode</code> to return the next
        /// page of results.
        /// </para>
        ///  
        /// <para>
        /// To list subdivisions of a country, you must include both <code>startcountrycode</code>
        /// and <code>startsubdivisioncode</code>.
        /// </para>
        /// </summary>
        public string StartSubdivisionCode
        {
            get { return this._startSubdivisionCode; }
            set { this._startSubdivisionCode = value; }
        }

        // Check to see if StartSubdivisionCode property is set
        internal bool IsSetStartSubdivisionCode()
        {
            return this._startSubdivisionCode != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// (Optional) The maximum number of geolocations to be included in the response body
        /// for this request. If more than <code>maxitems</code> geolocations remain to be listed,
        /// then the value of the <code>IsTruncated</code> element in the response is <code>true</code>.
        /// </para>
        /// </summary>
        public string MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems != null;
        }

    }
}