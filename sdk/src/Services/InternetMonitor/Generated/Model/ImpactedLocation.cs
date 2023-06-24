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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private string _asName;
        private long? _asNumber;
        private NetworkImpairment _causedBy;
        private string _city;
        private string _country;
        private string _countryCode;
        private InternetHealth _internetHealth;
        private double? _latitude;
        private double? _longitude;
        private string _metro;
        private string _serviceLocation;
        private HealthEventStatus _status;
        private string _subdivision;
        private string _subdivisionCode;

        /// <summary>
        /// Gets and sets the property ASName. 
        /// <para>
        /// The name of the network at an impacted location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ASName
        {
            get { return this._asName; }
            set { this._asName = value; }
        }

        // Check to see if ASName property is set
        internal bool IsSetASName()
        {
            return this._asName != null;
        }

        /// <summary>
        /// Gets and sets the property ASNumber. 
        /// <para>
        /// The Autonomous System Number (ASN) of the network at an impacted location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long ASNumber
        {
            get { return this._asNumber.GetValueOrDefault(); }
            set { this._asNumber = value; }
        }

        // Check to see if ASNumber property is set
        internal bool IsSetASNumber()
        {
            return this._asNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CausedBy. 
        /// <para>
        /// The cause of the impairment. There are two types of network impairments: Amazon Web
        /// Services network issues or internet issues. Internet issues are typically a problem
        /// with a network provider, like an internet service provider (ISP).
        /// </para>
        /// </summary>
        public NetworkImpairment CausedBy
        {
            get { return this._causedBy; }
            set { this._causedBy = value; }
        }

        // Check to see if CausedBy property is set
        internal bool IsSetCausedBy()
        {
            return this._causedBy != null;
        }

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The name of the city where the health event is located.
        /// </para>
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
        /// Gets and sets the property Country. 
        /// <para>
        /// The name of the country where the health event is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The country code where the health event is located. The ISO 3166-2 codes for the country
        /// is provided, when available. 
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
        /// Gets and sets the property InternetHealth. 
        /// <para>
        /// The calculated health at a specific location.
        /// </para>
        /// </summary>
        public InternetHealth InternetHealth
        {
            get { return this._internetHealth; }
            set { this._internetHealth = value; }
        }

        // Check to see if InternetHealth property is set
        internal bool IsSetInternetHealth()
        {
            return this._internetHealth != null;
        }

        /// <summary>
        /// Gets and sets the property Latitude. 
        /// <para>
        /// The latitude where the health event is located.
        /// </para>
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
        /// Gets and sets the property Longitude. 
        /// <para>
        /// The longitude where the health event is located.
        /// </para>
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
        public string Metro
        {
            get { return this._metro; }
            set { this._metro = value; }
        }

        // Check to see if Metro property is set
        internal bool IsSetMetro()
        {
            return this._metro != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceLocation. 
        /// <para>
        /// The service location where the health event is located.
        /// </para>
        /// </summary>
        public string ServiceLocation
        {
            get { return this._serviceLocation; }
            set { this._serviceLocation = value; }
        }

        // Check to see if ServiceLocation property is set
        internal bool IsSetServiceLocation()
        {
            return this._serviceLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the health event at an impacted location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HealthEventStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Subdivision. 
        /// <para>
        /// The subdivision location where the health event is located. The subdivision usually
        /// maps to states in most countries (including the United States). For United Kingdom,
        /// it maps to a country (England, Scotland, Wales) or province (Northern Ireland).
        /// </para>
        /// </summary>
        public string Subdivision
        {
            get { return this._subdivision; }
            set { this._subdivision = value; }
        }

        // Check to see if Subdivision property is set
        internal bool IsSetSubdivision()
        {
            return this._subdivision != null;
        }

        /// <summary>
        /// Gets and sets the property SubdivisionCode. 
        /// <para>
        /// The subdivision code where the health event is located. The ISO 3166-2 codes for country
        /// subdivisions is provided, when available. 
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