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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies geographic information about an endpoint.
    /// </summary>
    public partial class EndpointLocation
    {
        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The name of the city where the endpoint is located.
        /// </para>
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region where
        /// the endpoint is located. For example, US for the United States.
        /// </para>
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property Latitude. 
        /// <para>
        /// The latitude coordinate of the endpoint location, rounded to one decimal place.
        /// </para>
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        /// Checks to see if the Latitude property is set.
        /// </summary>
        internal bool IsSetLatitude() => this.Latitude.HasValue;

        /// <summary>
        /// Gets and sets the property Longitude. 
        /// <para>
        /// The longitude coordinate of the endpoint location, rounded to one decimal place.
        /// </para>
        /// </summary>
        public double? Longitude { get; set; }

        /// <summary>
        /// Checks to see if the Longitude property is set.
        /// </summary>
        internal bool IsSetLongitude() => this.Longitude.HasValue;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal or ZIP code for the area where the endpoint is located.
        /// </para>
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The name of the region where the endpoint is located. For locations in the United
        /// States, this value is the name of a state.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;
    }
}
