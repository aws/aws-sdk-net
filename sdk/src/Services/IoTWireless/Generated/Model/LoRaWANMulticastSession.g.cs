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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// The LoRaWAN information used with the multicast session.
    /// </summary>
    public partial class LoRaWANMulticastSession
    {
        /// <summary>
        /// Gets and sets the property DlDr.
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public int? DlDr { get; set; }

        /// <summary>
        /// Checks to see if the DlDr property is set.
        /// </summary>
        internal bool IsSetDlDr() => this.DlDr.HasValue;

        /// <summary>
        /// Gets and sets the property DlFreq.
        /// </summary>
        [AWSProperty(Min = 100000000, Max = 1000000000)]
        public int? DlFreq { get; set; }

        /// <summary>
        /// Checks to see if the DlFreq property is set.
        /// </summary>
        internal bool IsSetDlFreq() => this.DlFreq.HasValue;

        /// <summary>
        /// Gets and sets the property PingSlotPeriod. 
        /// <para>
        /// The PingSlotPeriod value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 4096)]
        public int? PingSlotPeriod { get; set; }

        /// <summary>
        /// Checks to see if the PingSlotPeriod property is set.
        /// </summary>
        internal bool IsSetPingSlotPeriod() => this.PingSlotPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property SessionStartTime.
        /// </summary>
        public DateTime? SessionStartTime { get; set; }

        /// <summary>
        /// Checks to see if the SessionStartTime property is set.
        /// </summary>
        internal bool IsSetSessionStartTime() => this.SessionStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property SessionTimeout.
        /// </summary>
        [AWSProperty(Min = 60, Max = 172800)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// Checks to see if the SessionTimeout property is set.
        /// </summary>
        internal bool IsSetSessionTimeout() => this.SessionTimeout.HasValue;
    }
}
