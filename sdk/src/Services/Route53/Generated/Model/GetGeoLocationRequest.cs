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
    /// Container for the parameters to the GetGeoLocation operation.
    /// Gets information about whether a specified geographic location is supported for Amazon
    /// Route 53 geolocation resource record sets.
    /// 
    ///  
    /// <para>
    /// Use the following syntax to determine whether a continent is supported for geolocation:
    /// </para>
    ///  
    /// <para>
    ///  <code>GET /2013-04-01/geolocation?ContinentCode=<i>two-letter abbreviation for a
    /// continent</i> </code> 
    /// </para>
    ///  
    /// <para>
    /// Use the following syntax to determine whether a country is supported for geolocation:
    /// </para>
    ///  
    /// <para>
    ///  <code>GET /2013-04-01/geolocation?CountryCode=<i>two-character country code</i> </code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// Use the following syntax to determine whether a subdivision of a country is supported
    /// for geolocation:
    /// </para>
    ///  
    /// <para>
    ///  <code>GET /2013-04-01/geolocation?CountryCode=<i>two-character country code</i>&amp;SubdivisionCode=<i>subdivision
    /// code</i> </code> 
    /// </para>
    /// </summary>
    public partial class GetGeoLocationRequest : AmazonRoute53Request
    {
        private string _continentCode;
        private string _countryCode;
        private string _subdivisionCode;

        /// <summary>
        /// Gets and sets the property ContinentCode. 
        /// <para>
        /// Amazon Route 53 supports the following continent codes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>AF</b>: Africa
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AN</b>: Antarctica
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AS</b>: Asia
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EU</b>: Europe
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OC</b>: Oceania
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>NA</b>: North America
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SA</b>: South America
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ContinentCode
        {
            get { return this._continentCode; }
            set { this._continentCode = value; }
        }

        // Check to see if ContinentCode property is set
        internal bool IsSetContinentCode()
        {
            return this._continentCode != null;
        }

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// Amazon Route 53 uses the two-letter country codes that are specified in <a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// standard 3166-1 alpha-2</a>.
        /// </para>
        /// </summary>
        public string CountryCode
        {
            get { return this._countryCode; }
            set { this._countryCode = value; }
        }

        // Check to see if CountryCode property is set
        internal bool IsSetCountryCode()
        {
            return this._countryCode != null;
        }

        /// <summary>
        /// Gets and sets the property SubdivisionCode. 
        /// <para>
        /// Amazon Route 53 uses the one- to three-letter subdivision codes that are specified
        /// in <a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO standard 3166-1
        /// alpha-2</a>. Amazon Route 53 doesn't support subdivision codes for all countries.
        /// If you specify <code>SubdivisionCode</code>, you must also specify <code>CountryCode</code>.
        /// 
        /// </para>
        /// </summary>
        public string SubdivisionCode
        {
            get { return this._subdivisionCode; }
            set { this._subdivisionCode = value; }
        }

        // Check to see if SubdivisionCode property is set
        internal bool IsSetSubdivisionCode()
        {
            return this._subdivisionCode != null;
        }

    }
}