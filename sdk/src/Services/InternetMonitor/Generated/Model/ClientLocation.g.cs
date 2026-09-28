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

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// The impacted location, such as a city, that Amazon Web Services clients access application
    /// resources from.
    /// </summary>
    public partial class ClientLocation
    {
        /// <summary>
        /// Gets and sets the property ASName. 
        /// <para>
        /// The name of the internet service provider (ISP) or network (ASN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ASName { get; set; }

        /// <summary>
        /// Checks to see if the ASName property is set.
        /// </summary>
        internal bool IsSetASName() => this.ASName != null;

        /// <summary>
        /// Gets and sets the property ASNumber. 
        /// <para>
        /// The Autonomous System Number (ASN) of the network at an impacted location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ASNumber { get; set; }

        /// <summary>
        /// Checks to see if the ASNumber property is set.
        /// </summary>
        internal bool IsSetASNumber() => this.ASNumber.HasValue;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The name of the city where the internet event is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The name of the country where the internet event is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property Latitude. 
        /// <para>
        /// The latitude where the internet event is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Checks to see if the Latitude property is set.
        /// </summary>
        internal bool IsSetLatitude() => this.Latitude.HasValue;

        /// <summary>
        /// Gets and sets the property Longitude. 
        /// <para>
        /// The longitude where the internet event is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Checks to see if the Longitude property is set.
        /// </summary>
        internal bool IsSetLongitude() => this.Longitude.HasValue;

        /// <summary>
        /// Gets and sets the property Metro. 
        /// <para>
        /// The metro area where the health event is located.
        /// </para>
        ///  
        /// <para>
        /// Metro indicates a metropolitan region in the United States, such as the region around
        /// New York City. In non-US countries, this is a second-level subdivision. For example,
        /// in the United Kingdom, it could be a county, a London borough, a unitary authority,
        /// council area, and so on.
        /// </para>
        /// </summary>
        public string Metro { get; set; }

        /// <summary>
        /// Checks to see if the Metro property is set.
        /// </summary>
        internal bool IsSetMetro() => this.Metro != null;

        /// <summary>
        /// Gets and sets the property Subdivision. 
        /// <para>
        /// The subdivision location where the health event is located. The subdivision usually
        /// maps to states in most countries (including the United States). For United Kingdom,
        /// it maps to a country (England, Scotland, Wales) or province (Northern Ireland).
        /// </para>
        /// </summary>
        public string Subdivision { get; set; }

        /// <summary>
        /// Checks to see if the Subdivision property is set.
        /// </summary>
        internal bool IsSetSubdivision() => this.Subdivision != null;
    }
}
