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
    /// Corresponds to SCTE-35 delivery_not_restricted_flag parameter. To declare delivery
    /// restrictions, include this element and its four "restriction" flags. To declare that
    /// there are no restrictions, omit this element.
    /// </summary>
    public partial class Scte35DeliveryRestrictions
    {
        /// <summary>
        /// Gets and sets the property ArchiveAllowedFlag. Corresponds to SCTE-35 archive_allowed_flag.
        /// </summary>
        [AWSProperty(Required = true)]
        public Scte35ArchiveAllowedFlag ArchiveAllowedFlag { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveAllowedFlag property is set.
        /// </summary>
        internal bool IsSetArchiveAllowedFlag() => this.ArchiveAllowedFlag != null;

        /// <summary>
        /// Gets and sets the property DeviceRestrictions. Corresponds to SCTE-35 device_restrictions
        /// parameter.
        /// </summary>
        [AWSProperty(Required = true)]
        public Scte35DeviceRestrictions DeviceRestrictions { get; set; }

        /// <summary>
        /// Checks to see if the DeviceRestrictions property is set.
        /// </summary>
        internal bool IsSetDeviceRestrictions() => this.DeviceRestrictions != null;

        /// <summary>
        /// Gets and sets the property NoRegionalBlackoutFlag. Corresponds to SCTE-35 no_regional_blackout_flag
        /// parameter.
        /// </summary>
        [AWSProperty(Required = true)]
        public Scte35NoRegionalBlackoutFlag NoRegionalBlackoutFlag { get; set; }

        /// <summary>
        /// Checks to see if the NoRegionalBlackoutFlag property is set.
        /// </summary>
        internal bool IsSetNoRegionalBlackoutFlag() => this.NoRegionalBlackoutFlag != null;

        /// <summary>
        /// Gets and sets the property WebDeliveryAllowedFlag. Corresponds to SCTE-35 web_delivery_allowed_flag
        /// parameter.
        /// </summary>
        [AWSProperty(Required = true)]
        public Scte35WebDeliveryAllowedFlag WebDeliveryAllowedFlag { get; set; }

        /// <summary>
        /// Checks to see if the WebDeliveryAllowedFlag property is set.
        /// </summary>
        internal bool IsSetWebDeliveryAllowedFlag() => this.WebDeliveryAllowedFlag != null;
    }
}
