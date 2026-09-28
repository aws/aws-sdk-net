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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about the physical and logistical details for racks at sites. For more
    /// information about hardware requirements for racks, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/outposts-requirements.html#checklist">Network
    /// readiness checklist</a> in the Amazon Web Services Outposts User Guide.
    /// </summary>
    public partial class RackPhysicalProperties
    {
        /// <summary>
        /// Gets and sets the property FiberOpticCableType. 
        /// <para>
        /// The type of fiber used to attach the Outpost to the network. 
        /// </para>
        /// </summary>
        public FiberOpticCableType FiberOpticCableType { get; set; }

        /// <summary>
        /// Checks to see if the FiberOpticCableType property is set.
        /// </summary>
        internal bool IsSetFiberOpticCableType() => this.FiberOpticCableType != null;

        /// <summary>
        /// Gets and sets the property MaximumSupportedWeightLbs. 
        /// <para>
        /// The maximum rack weight that this site can support. <c>NO_LIMIT</c> is over 2000 lbs
        /// (907 kg). 
        /// </para>
        /// </summary>
        public MaximumSupportedWeightLbs MaximumSupportedWeightLbs { get; set; }

        /// <summary>
        /// Checks to see if the MaximumSupportedWeightLbs property is set.
        /// </summary>
        internal bool IsSetMaximumSupportedWeightLbs() => this.MaximumSupportedWeightLbs != null;

        /// <summary>
        /// Gets and sets the property OpticalStandard. 
        /// <para>
        /// The type of optical standard used to attach the Outpost to the network. This field
        /// is dependent on uplink speed, fiber type, and distance to the upstream device. For
        /// more information about networking requirements for racks, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/outposts-requirements.html#facility-networking">Network</a>
        /// in the Amazon Web Services Outposts User Guide. 
        /// </para>
        /// </summary>
        public OpticalStandard OpticalStandard { get; set; }

        /// <summary>
        /// Checks to see if the OpticalStandard property is set.
        /// </summary>
        internal bool IsSetOpticalStandard() => this.OpticalStandard != null;

        /// <summary>
        /// Gets and sets the property PowerConnector. 
        /// <para>
        /// The power connector for the hardware. 
        /// </para>
        /// </summary>
        public PowerConnector PowerConnector { get; set; }

        /// <summary>
        /// Checks to see if the PowerConnector property is set.
        /// </summary>
        internal bool IsSetPowerConnector() => this.PowerConnector != null;

        /// <summary>
        /// Gets and sets the property PowerDrawKva. 
        /// <para>
        /// The power draw available at the hardware placement position for the rack. 
        /// </para>
        /// </summary>
        public PowerDrawKva PowerDrawKva { get; set; }

        /// <summary>
        /// Checks to see if the PowerDrawKva property is set.
        /// </summary>
        internal bool IsSetPowerDrawKva() => this.PowerDrawKva != null;

        /// <summary>
        /// Gets and sets the property PowerFeedDrop. 
        /// <para>
        /// The position of the power feed.
        /// </para>
        /// </summary>
        public PowerFeedDrop PowerFeedDrop { get; set; }

        /// <summary>
        /// Checks to see if the PowerFeedDrop property is set.
        /// </summary>
        internal bool IsSetPowerFeedDrop() => this.PowerFeedDrop != null;

        /// <summary>
        /// Gets and sets the property PowerPhase. 
        /// <para>
        /// The power option that you can provide for hardware.
        /// </para>
        /// </summary>
        public PowerPhase PowerPhase { get; set; }

        /// <summary>
        /// Checks to see if the PowerPhase property is set.
        /// </summary>
        internal bool IsSetPowerPhase() => this.PowerPhase != null;

        /// <summary>
        /// Gets and sets the property UplinkCount. 
        /// <para>
        /// The number of uplinks each Outpost network device.
        /// </para>
        /// </summary>
        public UplinkCount UplinkCount { get; set; }

        /// <summary>
        /// Checks to see if the UplinkCount property is set.
        /// </summary>
        internal bool IsSetUplinkCount() => this.UplinkCount != null;

        /// <summary>
        /// Gets and sets the property UplinkGbps. 
        /// <para>
        /// The uplink speed the rack supports for the connection to the Region. 
        /// </para>
        /// </summary>
        public UplinkGbps UplinkGbps { get; set; }

        /// <summary>
        /// Checks to see if the UplinkGbps property is set.
        /// </summary>
        internal bool IsSetUplinkGbps() => this.UplinkGbps != null;
    }
}
