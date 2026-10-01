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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// For <c>AwsApiAction</c>, <c>NetworkConnectionAction</c>, and <c>PortProbeAction</c>,
    /// <c>RemoteIpDetails</c> provides information about the remote IP address that was involved
    /// in the action.
    /// </summary>
    public partial class ActionRemoteIpDetails
    {
        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city where the remote IP address is located.
        /// </para>
        /// </summary>
        public City City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country where the remote IP address is located.
        /// </para>
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property GeoLocation. 
        /// <para>
        /// The coordinates of the location of the remote IP address.
        /// </para>
        /// </summary>
        public GeoLocation GeoLocation { get; set; }

        /// <summary>
        /// Checks to see if the GeoLocation property is set.
        /// </summary>
        internal bool IsSetGeoLocation() => this.GeoLocation != null;

        /// <summary>
        /// Gets and sets the property IpAddressV4. 
        /// <para>
        /// The IP address.
        /// </para>
        /// </summary>
        public string IpAddressV4 { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressV4 property is set.
        /// </summary>
        internal bool IsSetIpAddressV4() => this.IpAddressV4 != null;

        /// <summary>
        /// Gets and sets the property Organization. 
        /// <para>
        /// The internet service provider (ISP) organization associated with the remote IP address.
        /// </para>
        /// </summary>
        public IpOrganizationDetails Organization { get; set; }

        /// <summary>
        /// Checks to see if the Organization property is set.
        /// </summary>
        internal bool IsSetOrganization() => this.Organization != null;
    }
}
