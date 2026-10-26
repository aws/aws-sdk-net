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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Esam
    /// </summary>
    public partial class Esam
    {
        /// <summary>
        /// Gets and sets the property AcquisitionPointId. Sent as acquisitionPointIdentity to
        /// identify the MediaLive channel to the POIS.
        /// </summary>
        [AWSProperty(Required = true)]
        public string AcquisitionPointId { get; set; }

        /// <summary>
        /// Checks to see if the AcquisitionPointId property is set.
        /// </summary>
        internal bool IsSetAcquisitionPointId() => this.AcquisitionPointId != null;

        /// <summary>
        /// Gets and sets the property AdAvailOffset. When specified, this offset (in milliseconds)
        /// is added to the input Ad Avail PTS time. This only applies to embedded SCTE 104/35
        /// messages and does not apply to OOB messages.
        /// </summary>
        public int? AdAvailOffset { get; set; }

        /// <summary>
        /// Checks to see if the AdAvailOffset property is set.
        /// </summary>
        internal bool IsSetAdAvailOffset() => this.AdAvailOffset.HasValue;

        /// <summary>
        /// Gets and sets the property PasswordParam. Documentation update needed
        /// </summary>
        public string PasswordParam { get; set; }

        /// <summary>
        /// Checks to see if the PasswordParam property is set.
        /// </summary>
        internal bool IsSetPasswordParam() => this.PasswordParam != null;

        /// <summary>
        /// Gets and sets the property PoisEndpoint. The URL of the signal conditioner endpoint
        /// on the Placement Opportunity Information System (POIS). MediaLive sends SignalProcessingEvents
        /// here when SCTE-35 messages are read.
        /// </summary>
        [AWSProperty(Required = true)]
        public string PoisEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the PoisEndpoint property is set.
        /// </summary>
        internal bool IsSetPoisEndpoint() => this.PoisEndpoint != null;

        /// <summary>
        /// Gets and sets the property Username. Documentation update needed
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;

        /// <summary>
        /// Gets and sets the property ZoneIdentity. Optional data sent as zoneIdentity to identify
        /// the MediaLive channel to the POIS.
        /// </summary>
        public string ZoneIdentity { get; set; }

        /// <summary>
        /// Checks to see if the ZoneIdentity property is set.
        /// </summary>
        internal bool IsSetZoneIdentity() => this.ZoneIdentity != null;
    }
}
