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
    /// Information about a location impacted by a health event in Amazon CloudWatch Internet
    /// Monitor.
    /// 
    ///  
    /// <para>
    /// Geographic regions are hierarchically categorized into country, subdivision, metro
    /// and city geographic granularities. The geographic region is identified based on the
    /// IP address used at the client locations.
    /// </para>
    /// </summary>
    public partial class ImpactedLocation
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
        /// Gets and sets the property CausedBy. 
        /// <para>
        /// The cause of the impairment. There are two types of network impairments: Amazon Web
        /// Services network issues or internet issues. Internet issues are typically a problem
        /// with a network provider, like an internet service provider (ISP).
        /// </para>
        /// </summary>
        public NetworkImpairment CausedBy { get; set; }

        /// <summary>
        /// Checks to see if the CausedBy property is set.
        /// </summary>
        internal bool IsSetCausedBy() => this.CausedBy != null;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The name of the city where the health event is located.
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
        /// The name of the country where the health event is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The country code where the health event is located. The ISO 3166-2 codes for the country
        /// is provided, when available. 
        /// </para>
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Checks to see if the CountryCode property is set.
        /// </summary>
        internal bool IsSetCountryCode() => this.CountryCode != null;

        /// <summary>
        /// Gets and sets the property InternetHealth. 
        /// <para>
        /// The calculated health at a specific location.
        /// </para>
        /// </summary>
        public InternetHealth InternetHealth { get; set; }

        /// <summary>
        /// Checks to see if the InternetHealth property is set.
        /// </summary>
        internal bool IsSetInternetHealth() => this.InternetHealth != null;

        /// <summary>
        /// Gets and sets the property Ipv4Prefixes. 
        /// <para>
        /// The IPv4 prefixes at the client location that was impacted by the health event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ipv4Prefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Ipv4Prefixes property is set.
        /// </summary>
        internal bool IsSetIpv4Prefixes() => this.Ipv4Prefixes != null && (this.Ipv4Prefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Latitude. 
        /// <para>
        /// The latitude where the health event is located.
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
        /// The longitude where the health event is located.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ServiceLocation. 
        /// <para>
        /// The service location where the health event is located.
        /// </para>
        /// </summary>
        public string ServiceLocation { get; set; }

        /// <summary>
        /// Checks to see if the ServiceLocation property is set.
        /// </summary>
        internal bool IsSetServiceLocation() => this.ServiceLocation != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the health event at an impacted location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HealthEventStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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

        /// <summary>
        /// Gets and sets the property SubdivisionCode. 
        /// <para>
        /// The subdivision code where the health event is located. The ISO 3166-2 codes for country
        /// subdivisions is provided, when available. 
        /// </para>
        /// </summary>
        public string SubdivisionCode { get; set; }

        /// <summary>
        /// Checks to see if the SubdivisionCode property is set.
        /// </summary>
        internal bool IsSetSubdivisionCode() => this.SubdivisionCode != null;
    }
}
