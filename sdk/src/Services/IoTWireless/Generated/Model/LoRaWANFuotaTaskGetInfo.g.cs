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
    /// The LoRaWAN information returned from getting a FUOTA task.
    /// </summary>
    public partial class LoRaWANFuotaTaskGetInfo
    {
        /// <summary>
        /// Gets and sets the property RfRegion.
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string RfRegion { get; set; }

        /// <summary>
        /// Checks to see if the RfRegion property is set.
        /// </summary>
        internal bool IsSetRfRegion() => this.RfRegion != null;

        /// <summary>
        /// Gets and sets the property StartTime.
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
