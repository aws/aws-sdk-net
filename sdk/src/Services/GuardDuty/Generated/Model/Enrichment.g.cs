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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains additional context about activity, such as geolocation and threat intelligence
    /// information. Not every member is set.
    /// </summary>
    public partial class Enrichment
    {
        /// <summary>
        /// Gets and sets the property AsnOrg. 
        /// <para>
        /// The name of the organization that owns the autonomous system number (ASN).
        /// </para>
        /// </summary>
        public string AsnOrg { get; set; }

        /// <summary>
        /// Checks to see if the AsnOrg property is set.
        /// </summary>
        internal bool IsSetAsnOrg() => this.AsnOrg != null;

        /// <summary>
        /// Gets and sets the property CountryName. 
        /// <para>
        /// The name of the country associated with the activity.
        /// </para>
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// Checks to see if the CountryName property is set.
        /// </summary>
        internal bool IsSetCountryName() => this.CountryName != null;

        /// <summary>
        /// Gets and sets the property ThreatListName. 
        /// <para>
        /// The name of the threat list that contains the indicator.
        /// </para>
        /// </summary>
        public string ThreatListName { get; set; }

        /// <summary>
        /// Checks to see if the ThreatListName property is set.
        /// </summary>
        internal bool IsSetThreatListName() => this.ThreatListName != null;

        /// <summary>
        /// Gets and sets the property ThreatName. 
        /// <para>
        /// The name of the threat.
        /// </para>
        /// </summary>
        public string ThreatName { get; set; }

        /// <summary>
        /// Checks to see if the ThreatName property is set.
        /// </summary>
        internal bool IsSetThreatName() => this.ThreatName != null;
    }
}
