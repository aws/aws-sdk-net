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
    /// Container for the parameters to the UpdateSiteRackPhysicalProperties operation.
    /// Update the physical and logistical details for a rack at a site. For more information
    /// about hardware requirements for racks, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/outposts-requirements.html#checklist">Network
    /// readiness checklist</a> in the Amazon Web Services Outposts User Guide. 
    /// 
    ///  
    /// <para>
    /// To update a rack at a site with an order of <c>IN_PROGRESS</c>, you must wait for
    /// the order to complete or cancel the order.
    /// </para>
    /// </summary>
    public partial class UpdateSiteRackPhysicalPropertiesRequest : AmazonOutpostsRequest
    {
        private FiberOpticCableType _fiberOpticCableType;
        private MaximumSupportedWeightLbs _maximumSupportedWeightLbs;
        private OpticalStandard _opticalStandard;
        private PowerConnector _powerConnector;
        private PowerDrawKva _powerDrawKva;
        private PowerFeedDrop _powerFeedDrop;
        private PowerPhase _powerPhase;
        private string _siteId;
        private UplinkCount _uplinkCount;
        private UplinkGbps _uplinkGbps;

        /// <summary>
        /// Gets and sets the property FiberOpticCableType. 
        /// <para>
        /// The type of fiber that you will use to attach the Outpost to your network. 
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
        /// The maximum rack weight that this site can support. <c>NO_LIMIT</c> is over 2000lbs.
        /// 
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
        /// The type of optical standard that you will use to attach the Outpost to your network.
        /// This field is dependent on uplink speed, fiber type, and distance to the upstream
        /// device. For more information about networking requirements for racks, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/outposts-requirements.html#facility-networking">Network</a>
        /// in the Amazon Web Services Outposts User Guide. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OPTIC_10GBASE_SR</c>: 10GBASE-SR
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIC_10GBASE_IR</c>: 10GBASE-IR
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIC_10GBASE_LR</c>: 10GBASE-LR
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIC_40GBASE_SR</c>: 40GBASE-SR
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIC_40GBASE_ESR</c>: 40GBASE-ESR
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIC_40GBASE_IR4_LR4L</c>: 40GBASE-IR (LR4L)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIC_40GBASE_LR4</c>: 40GBASE-LR4
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIC_100GBASE_SR4</c>: 100GBASE-SR4
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIC_100GBASE_CWDM4</c>: 100GBASE-CWDM4
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIC_100GBASE_LR4</c>: 100GBASE-LR4
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIC_100G_PSM4_MSA</c>: 100G PSM4 MSA
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIC_1000BASE_LX</c>: 1000Base-LX
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPTIC_1000BASE_SX</c> : 1000Base-SX
        /// </para>
        ///  </li> </ul>
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
        /// The power connector that Amazon Web Services should plan to provide for connections
        /// to the hardware. Note the correlation between <c>PowerPhase</c> and <c>PowerConnector</c>.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Single-phase AC feed
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>L6-30P</b> – (common in US); 30A; single phase
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IEC309 (blue)</b> – P+N+E, 6hr; 32 A; single phase
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Three-phase AC feed
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>AH530P7W (red)</b> – 3P+N+E, 7hr; 30A; three phase
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>AH532P6W (red)</b> – 3P+N+E, 6hr; 32A; three phase
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CS8365C</b> – (common in US); 3P+E, 50A; three phase
        /// </para>
        ///  </li> </ul> </li> </ul>
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
        /// The power draw, in kVA, available at the hardware placement position for the rack.
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
        /// Indicates whether the power feed comes above or below the rack. 
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
        ///  <ul> <li> 
        /// <para>
        /// Single-phase AC feed: 200 V to 277 V, 50 Hz or 60 Hz
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Three-phase AC feed: 346 V to 480 V, 50 Hz or 60 Hz
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property SiteId. 
        /// <para>
        ///  The ID or the Amazon Resource Name (ARN) of the site. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string SiteId
        {
            get { return this._siteId; }
            set { this._siteId = value; }
        }

        // Check to see if SiteId property is set
        internal bool IsSetSiteId()
        {
            return this._siteId != null;
        }

        /// <summary>
        /// Gets and sets the property UplinkCount. 
        /// <para>
        /// Racks come with two Outpost network devices. Depending on the supported uplink speed
        /// at the site, the Outpost network devices provide a variable number of uplinks. Specify
        /// the number of uplinks for each Outpost network device that you intend to use to connect
        /// the rack to your network. Note the correlation between <c>UplinkGbps</c> and <c>UplinkCount</c>.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 1Gbps - Uplinks available: 1, 2, 4, 6, 8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 10Gbps - Uplinks available: 1, 2, 4, 8, 12, 16
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 40 and 100 Gbps- Uplinks available: 1, 2, 4
        /// </para>
        ///  </li> </ul>
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
        /// The uplink speed the rack should support for the connection to the Region. 
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