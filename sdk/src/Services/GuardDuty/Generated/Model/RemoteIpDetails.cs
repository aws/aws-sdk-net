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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the remote IP address of the connection.
    /// </summary>
    public partial class RemoteIpDetails
    {
        private City _city;
        private Country _country;
        private GeoLocation _geoLocation;
        private string _ipAddressV4;
        private string _ipAddressV6;
        private Organization _organization;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city information of the remote IP address.
        /// </para>
        /// </summary>
        public City City
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
        /// The country code of the remote IP address.
        /// </para>
        /// </summary>
        public Country Country
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
        /// Gets and sets the property GeoLocation. 
        /// <para>
        /// The location information of the remote IP address.
        /// </para>
        /// </summary>
        public GeoLocation GeoLocation
        {
            get { return this._geoLocation; }
            set { this._geoLocation = value; }
        }

        // Check to see if GeoLocation property is set
        internal bool IsSetGeoLocation()
        {
            return this._geoLocation != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressV4. 
        /// <para>
        /// The IPv4 remote address of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string IpAddressV4
        {
            get { return this._ipAddressV4; }
            set { this._ipAddressV4 = value; }
        }

        // Check to see if IpAddressV4 property is set
        internal bool IsSetIpAddressV4()
        {
            return this._ipAddressV4 != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressV6. 
        /// <para>
        /// The IPv6 remote address of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string IpAddressV6
        {
            get { return this._ipAddressV6; }
            set { this._ipAddressV6 = value; }
        }

        // Check to see if IpAddressV6 property is set
        internal bool IsSetIpAddressV6()
        {
            return this._ipAddressV6 != null;
        }

        /// <summary>
        /// Gets and sets the property Organization. 
        /// <para>
        /// The ISP organization information of the remote IP address.
        /// </para>
        /// </summary>
        public Organization Organization
        {
            get { return this._organization; }
            set { this._organization = value; }
        }

        // Check to see if Organization property is set
        internal bool IsSetOrganization()
        {
            return this._organization != null;
        }

    }
}