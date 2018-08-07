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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Location data for the endpoint.
    /// </summary>
    public partial class EndpointLocation
    {
        private string _city;
        private string _country;
        private double? _latitude;
        private double? _longitude;
        private string _postalCode;
        private string _region;

        /// <summary>
        /// Gets and sets the property City. The city where the endpoint is located.
        /// </summary>
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }

        // Check to see if City property is set
        internal bool IsSetCity()
        {
            return this._city != null;
        }

        /// <summary>
        /// Gets and sets the property Country. The two-letter code for the country or region
        /// of the endpoint. Specified as an ISO 3166-1 Alpha-2 code, such as "US" for the United
        /// States.
        /// </summary>
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property Latitude. The latitude of the endpoint location, rounded
        /// to one decimal place.
        /// </summary>
        public double Latitude
        {
            get { return this._latitude.GetValueOrDefault(); }
            set { this._latitude = value; }
        }

        // Check to see if Latitude property is set
        internal bool IsSetLatitude()
        {
            return this._latitude.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Longitude. The longitude of the endpoint location, rounded
        /// to one decimal place.
        /// </summary>
        public double Longitude
        {
            get { return this._longitude.GetValueOrDefault(); }
            set { this._longitude = value; }
        }

        // Check to see if Longitude property is set
        internal bool IsSetLongitude()
        {
            return this._longitude.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PostalCode. The postal code or zip code of the endpoint.
        /// </summary>
        public string PostalCode
        {
            get { return this._postalCode; }
            set { this._postalCode = value; }
        }

        // Check to see if PostalCode property is set
        internal bool IsSetPostalCode()
        {
            return this._postalCode != null;
        }

        /// <summary>
        /// Gets and sets the property Region. The region of the endpoint location. For example,
        /// in the United States, this corresponds to a state.
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}