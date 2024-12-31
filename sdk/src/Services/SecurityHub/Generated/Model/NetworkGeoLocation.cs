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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
    /// To receive GuardDuty attack sequence findings in Security Hub, you must have GuardDuty
    /// enabled. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty-extended-threat-detection.html">GuardDuty
    /// Extended Threat Detection </a> in the <i>Amazon GuardDuty User Guide</i>.
    /// </summary>
    public partial class NetworkGeoLocation
    {
        private string _city;
        private string _country;
        private double? _lat;
        private double? _lon;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        ///  The name of the city. 
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
        ///  The name of the country. 
        /// </para>
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
        /// Gets and sets the property Lat. 
        /// <para>
        ///  The latitude information of the endpoint location. 
        /// </para>
        /// </summary>
        public double? Lat
        {
            get { return this._lat; }
            set { this._lat = value; }
        }

        // Check to see if Lat property is set
        internal bool IsSetLat()
        {
            return this._lat.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lon. 
        /// <para>
        ///  The longitude information of the endpoint location. 
        /// </para>
        /// </summary>
        public double? Lon
        {
            get { return this._lon; }
            set { this._lon = value; }
        }

        // Check to see if Lon property is set
        internal bool IsSetLon()
        {
            return this._lon.HasValue; 
        }

    }
}