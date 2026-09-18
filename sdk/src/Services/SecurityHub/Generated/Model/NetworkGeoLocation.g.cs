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
    /// Contains information about the location of a network endpoint involved in an Amazon
    /// GuardDuty Extended Threat Detection attack sequence. GuardDuty generates an attack
    /// sequence finding when multiple events align to a potentially suspicious activity.
    /// To receive GuardDuty attack sequence findings in Security Hub CSPM, you must have
    /// GuardDuty enabled. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty-extended-threat-detection.html">GuardDuty
    /// Extended Threat Detection </a> in the <i>Amazon GuardDuty User Guide</i>.
    /// </summary>
    public partial class NetworkGeoLocation
    {
        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        ///  The name of the city. 
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
        ///  The name of the country. 
        /// </para>
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property Lat. 
        /// <para>
        ///  The latitude information of the endpoint location. 
        /// </para>
        /// </summary>
        public double? Lat { get; set; }

        /// <summary>
        /// Checks to see if the Lat property is set.
        /// </summary>
        internal bool IsSetLat() => this.Lat.HasValue;

        /// <summary>
        /// Gets and sets the property Lon. 
        /// <para>
        ///  The longitude information of the endpoint location. 
        /// </para>
        /// </summary>
        public double? Lon { get; set; }

        /// <summary>
        /// Checks to see if the Lon property is set.
        /// </summary>
        internal bool IsSetLon() => this.Lon.HasValue;
    }
}
