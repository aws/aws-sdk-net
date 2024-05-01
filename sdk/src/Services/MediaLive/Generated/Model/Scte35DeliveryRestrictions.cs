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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private Scte35ArchiveAllowedFlag _archiveAllowedFlag;
        private Scte35DeviceRestrictions _deviceRestrictions;
        private Scte35NoRegionalBlackoutFlag _noRegionalBlackoutFlag;
        private Scte35WebDeliveryAllowedFlag _webDeliveryAllowedFlag;

        /// <summary>
        /// Gets and sets the property ArchiveAllowedFlag. Corresponds to SCTE-35 archive_allowed_flag.
        /// </summary>
        [AWSProperty(Required=true)]
        public Scte35ArchiveAllowedFlag ArchiveAllowedFlag
        {
            get { return this._archiveAllowedFlag; }
            set { this._archiveAllowedFlag = value; }
        }

        // Check to see if ArchiveAllowedFlag property is set
        internal bool IsSetArchiveAllowedFlag()
        {
            return this._archiveAllowedFlag != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceRestrictions. Corresponds to SCTE-35 device_restrictions
        /// parameter.
        /// </summary>
        [AWSProperty(Required=true)]
        public Scte35DeviceRestrictions DeviceRestrictions
        {
            get { return this._deviceRestrictions; }
            set { this._deviceRestrictions = value; }
        }

        // Check to see if DeviceRestrictions property is set
        internal bool IsSetDeviceRestrictions()
        {
            return this._deviceRestrictions != null;
        }

        /// <summary>
        /// Gets and sets the property NoRegionalBlackoutFlag. Corresponds to SCTE-35 no_regional_blackout_flag
        /// parameter.
        /// </summary>
        [AWSProperty(Required=true)]
        public Scte35NoRegionalBlackoutFlag NoRegionalBlackoutFlag
        {
            get { return this._noRegionalBlackoutFlag; }
            set { this._noRegionalBlackoutFlag = value; }
        }

        // Check to see if NoRegionalBlackoutFlag property is set
        internal bool IsSetNoRegionalBlackoutFlag()
        {
            return this._noRegionalBlackoutFlag != null;
        }

        /// <summary>
        /// Gets and sets the property WebDeliveryAllowedFlag. Corresponds to SCTE-35 web_delivery_allowed_flag
        /// parameter.
        /// </summary>
        [AWSProperty(Required=true)]
        public Scte35WebDeliveryAllowedFlag WebDeliveryAllowedFlag
        {
            get { return this._webDeliveryAllowedFlag; }
            set { this._webDeliveryAllowedFlag = value; }
        }

        // Check to see if WebDeliveryAllowedFlag property is set
        internal bool IsSetWebDeliveryAllowedFlag()
        {
            return this._webDeliveryAllowedFlag != null;
        }

    }
}