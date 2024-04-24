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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
    ///  
    /// <para>
    /// Route 53 does not perform authorization for this API because it retrieves information
    /// that is already available to the public.
    /// </para>
    ///  
    /// <para>
    /// For a list of supported geolocation codes, see the <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GeoLocation.html">GeoLocation</a>
    /// data type.
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
        /// of results, if <c>IsTruncated</c> is true, and if <c>NextContinentCode</c> from the
        /// previous response has a value, enter that value in <c>startcontinentcode</c> to return
        /// the next page of results.
        /// </para>
        ///  
        /// <para>
        /// Include <c>startcontinentcode</c> only if you want to list continents. Don't include
        /// <c>startcontinentcode</c> when you're listing countries or countries with their subdivisions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
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
        /// of results, if <c>IsTruncated</c> is <c>true</c>, and if <c>NextCountryCode</c> from
        /// the previous response has a value, enter that value in <c>startcountrycode</c> to
        /// return the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
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
        /// The code for the state of the United States with which you want to start listing locations
        /// that Amazon Route 53 supports for geolocation. If Route 53 has already returned a
        /// page or more of results, if <c>IsTruncated</c> is <c>true</c>, and if <c>NextSubdivisionCode</c>
        /// from the previous response has a value, enter that value in <c>startsubdivisioncode</c>
        /// to return the next page of results.
        /// </para>
        ///  
        /// <para>
        /// To list subdivisions (U.S. states), you must include both <c>startcountrycode</c>
        /// and <c>startsubdivisioncode</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
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
        /// for this request. If more than <c>maxitems</c> geolocations remain to be listed, then
        /// the value of the <c>IsTruncated</c> element in the response is <c>true</c>.
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