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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
        private FiberOpticCableType _fiberOpticCableType;
        private MaximumSupportedWeightLbs _maximumSupportedWeightLbs;
        private OpticalStandard _opticalStandard;
        private PowerConnector _powerConnector;
        private PowerDrawKva _powerDrawKva;
        private PowerFeedDrop _powerFeedDrop;
        private PowerPhase _powerPhase;
        private UplinkCount _uplinkCount;
        private UplinkGbps _uplinkGbps;

        /// <summary>
        /// Gets and sets the property FiberOpticCableType. 
        /// <para>
        /// The type of fiber used to attach the Outpost to the network. 
        /// </para>
        /// </summary>
        public FiberOpticCableType FiberOpticCableType
        {
            get { return this._fiberOpticCableType; }
            set { this._fiberOpticCableType = value; }
        }

        // Check to see if FiberOpticCableType property is set
        internal bool IsSetFiberOpticCableType()
        {
            return this._fiberOpticCableType != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumSupportedWeightLbs. 
        /// <para>
        /// The maximum rack weight that this site can support. <c>NO_LIMIT</c> is over 2000 lbs
        /// (907 kg). 
        /// </para>
        /// </summary>
        public MaximumSupportedWeightLbs MaximumSupportedWeightLbs
        {
            get { return this._maximumSupportedWeightLbs; }
            set { this._maximumSupportedWeightLbs = value; }
        }

        // Check to see if MaximumSupportedWeightLbs property is set
        internal bool IsSetMaximumSupportedWeightLbs()
        {
            return this._maximumSupportedWeightLbs != null;
        }

        /// <summary>
        /// Gets and sets the property OpticalStandard. 
        /// <para>
        /// The type of optical standard used to attach the Outpost to the network. This field
        /// is dependent on uplink speed, fiber type, and distance to the upstream device. For
        /// more information about networking requirements for racks, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/outposts-requirements.html#facility-networking">Network</a>
        /// in the Amazon Web Services Outposts User Guide. 
        /// </para>
        /// </summary>
        public OpticalStandard OpticalStandard
        {
            get { return this._opticalStandard; }
            set { this._opticalStandard = value; }
        }

        // Check to see if OpticalStandard property is set
        internal bool IsSetOpticalStandard()
        {
            return this._opticalStandard != null;
        }

        /// <summary>
        /// Gets and sets the property PowerConnector. 
        /// <para>
        /// The power connector for the hardware. 
        /// </para>
        /// </summary>
        public PowerConnector PowerConnector
        {
            get { return this._powerConnector; }
            set { this._powerConnector = value; }
        }

        // Check to see if PowerConnector property is set
        internal bool IsSetPowerConnector()
        {
            return this._powerConnector != null;
        }

        /// <summary>
        /// Gets and sets the property PowerDrawKva. 
        /// <para>
        /// The power draw available at the hardware placement position for the rack. 
        /// </para>
        /// </summary>
        public PowerDrawKva PowerDrawKva
        {
            get { return this._powerDrawKva; }
            set { this._powerDrawKva = value; }
        }

        // Check to see if PowerDrawKva property is set
        internal bool IsSetPowerDrawKva()
        {
            return this._powerDrawKva != null;
        }

        /// <summary>
        /// Gets and sets the property PowerFeedDrop. 
        /// <para>
        /// The position of the power feed.
        /// </para>
        /// </summary>
        public PowerFeedDrop PowerFeedDrop
        {
            get { return this._powerFeedDrop; }
            set { this._powerFeedDrop = value; }
        }

        // Check to see if PowerFeedDrop property is set
        internal bool IsSetPowerFeedDrop()
        {
            return this._powerFeedDrop != null;
        }

        /// <summary>
        /// Gets and sets the property PowerPhase. 
        /// <para>
        /// The power option that you can provide for hardware.
        /// </para>
        /// </summary>
        public PowerPhase PowerPhase
        {
            get { return this._powerPhase; }
            set { this._powerPhase = value; }
        }

        // Check to see if PowerPhase property is set
        internal bool IsSetPowerPhase()
        {
            return this._powerPhase != null;
        }

        /// <summary>
        /// Gets and sets the property UplinkCount. 
        /// <para>
        /// The number of uplinks each Outpost network device.
        /// </para>
        /// </summary>
        public UplinkCount UplinkCount
        {
            get { return this._uplinkCount; }
            set { this._uplinkCount = value; }
        }

        // Check to see if UplinkCount property is set
        internal bool IsSetUplinkCount()
        {
            return this._uplinkCount != null;
        }

        /// <summary>
        /// Gets and sets the property UplinkGbps. 
        /// <para>
        /// The uplink speed the rack supports for the connection to the Region. 
        /// </para>
        /// </summary>
        public UplinkGbps UplinkGbps
        {
            get { return this._uplinkGbps; }
            set { this._uplinkGbps = value; }
        }

        // Check to see if UplinkGbps property is set
        internal bool IsSetUplinkGbps()
        {
            return this._uplinkGbps != null;
        }

    }
}