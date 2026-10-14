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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// A network interface that specifies the on-board diagnostic (OBD) II network protocol.
    /// </summary>
    public partial class ObdInterface
    {
        /// <summary>
        /// Gets and sets the property DtcRequestIntervalSeconds. 
        /// <para>
        /// The maximum number message requests per diagnostic trouble code per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? DtcRequestIntervalSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DtcRequestIntervalSeconds property is set.
        /// </summary>
        internal bool IsSetDtcRequestIntervalSeconds() => this.DtcRequestIntervalSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property HasTransmissionEcu. 
        /// <para>
        /// Whether the vehicle has a transmission control module (TCM).
        /// </para>
        /// </summary>
        public bool? HasTransmissionEcu { get; set; }

        /// <summary>
        /// Checks to see if the HasTransmissionEcu property is set.
        /// </summary>
        internal bool IsSetHasTransmissionEcu() => this.HasTransmissionEcu.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ObdStandard. 
        /// <para>
        /// The standard OBD II PID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ObdStandard { get; set; }

        /// <summary>
        /// Checks to see if the ObdStandard property is set.
        /// </summary>
        internal bool IsSetObdStandard() => this.ObdStandard != null;

        /// <summary>
        /// Gets and sets the property PidRequestIntervalSeconds. 
        /// <para>
        /// The maximum number message requests per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? PidRequestIntervalSeconds { get; set; }

        /// <summary>
        /// Checks to see if the PidRequestIntervalSeconds property is set.
        /// </summary>
        internal bool IsSetPidRequestIntervalSeconds() => this.PidRequestIntervalSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property RequestMessageId. 
        /// <para>
        /// The ID of the message requesting vehicle data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public int? RequestMessageId { get; set; }

        /// <summary>
        /// Checks to see if the RequestMessageId property is set.
        /// </summary>
        internal bool IsSetRequestMessageId() => this.RequestMessageId.HasValue;

        /// <summary>
        /// Gets and sets the property UseExtendedIds. 
        /// <para>
        /// Whether to use extended IDs in the message.
        /// </para>
        /// </summary>
        public bool? UseExtendedIds { get; set; }

        /// <summary>
        /// Checks to see if the UseExtendedIds property is set.
        /// </summary>
        internal bool IsSetUseExtendedIds() => this.UseExtendedIds.HasValue;
    }
}
