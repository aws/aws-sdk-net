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
    /// To retrieve a list of supported geo locations, send a <code>GET</code> request to
    /// the <code>2013-04-01/geolocations</code> resource. The response to this request includes
    /// a <code>GeoLocationDetailsList</code> element with zero, one, or multiple <code>GeoLocationDetails</code>
    /// child elements. The list is sorted by country code, and then subdivision code, followed
    /// by continents at the end of the list. 
    /// 
    ///  
    /// <para>
    /// By default, the list of geo locations is displayed on a single page. You can control
    /// the length of the page that is displayed by using the <code>MaxItems</code> parameter.
    /// If the list is truncated, <code>IsTruncated</code> will be set to <i>true</i> and
    /// a combination of <code>NextContinentCode, NextCountryCode, NextSubdivisionCode</code>
    /// will be populated. You can pass these as parameters to <code>StartContinentCode, StartCountryCode,
    /// StartSubdivisionCode</code> to control the geo location that the list begins with.
    /// 
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
        /// The first continent code in the lexicographic ordering of geo locations that you want
        /// the <code>ListGeoLocations</code> request to list. For non-continent geo locations,
        /// this should be null.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>AF</code> | <code>AN</code> | <code>AS</code> | <code>EU</code>
        /// | <code>OC</code> | <code>NA</code> | <code>SA</code>
        /// </para>
        ///  
        /// <para>
        /// Constraint: Specifying <code>ContinentCode</code> with either <code>CountryCode</code>
        /// or <code>SubdivisionCode</code> returns an <a>InvalidInput</a> error.
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
        /// The first country code in the lexicographic ordering of geo locations that you want
        /// the <code>ListGeoLocations</code> request to list.
        /// </para>
        ///  
        /// <para>
        /// The default geo location uses a <code>*</code> for the country code. All other country
        /// codes follow the ISO 3166 two-character code.
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
        /// The first subdivision code in the lexicographic ordering of geo locations that you
        /// want the <code>ListGeoLocations</code> request to list.
        /// </para>
        ///  
        /// <para>
        /// Constraint: Specifying <code>SubdivisionCode</code> without <code>CountryCode</code>
        /// returns an <a>InvalidInput</a> error.
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
        /// The maximum number of geo locations you want in the response body.
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