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
    /// A complex type that contains the codes and full continent, country, and subdivision
    /// names for the specified <c>geolocation</c> code.
    /// </summary>
    public partial class GeoLocationDetails
    {
        private string _continentCode;
        private string _continentName;
        private string _countryCode;
        private string _countryName;
        private string _subdivisionCode;
        private string _subdivisionName;

        /// <summary>
        /// Gets and sets the property ContinentCode. 
        /// <para>
        /// The two-letter code for the continent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
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
        /// Gets and sets the property ContinentName. 
        /// <para>
        /// The full name of the continent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string ContinentName
        {
            get { return this._continentName; }
            set { this._continentName = value; }
        }

        // Check to see if ContinentName property is set
        internal bool IsSetContinentName()
        {
            return this._continentName != null;
        }

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The two-letter code for the country.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
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
        /// Gets and sets the property CountryName. 
        /// <para>
        /// The name of the country.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CountryName
        {
            get { return this._countryName; }
            set { this._countryName = value; }
        }

        // Check to see if CountryName property is set
        internal bool IsSetCountryName()
        {
            return this._countryName != null;
        }

        /// <summary>
        /// Gets and sets the property SubdivisionCode. 
        /// <para>
        /// The code for the subdivision, such as a particular state within the United States.
        /// For a list of US state abbreviations, see <a href="https://pe.usps.com/text/pub28/28apb.htm">Appendix
        /// B: Two–Letter State and Possession Abbreviations</a> on the United States Postal Service
        /// website. For a list of all supported subdivision codes, use the <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_ListGeoLocations.html">ListGeoLocations</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
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

        /// <summary>
        /// Gets and sets the property SubdivisionName. 
        /// <para>
        /// The full name of the subdivision. Route 53 currently supports only states in the United
        /// States.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SubdivisionName
        {
            get { return this._subdivisionName; }
            set { this._subdivisionName = value; }
        }

        // Check to see if SubdivisionName property is set
        internal bool IsSetSubdivisionName()
        {
            return this._subdivisionName != null;
        }

    }
}