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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Esam
    /// </summary>
    public partial class Esam
    {
        private string _acquisitionPointId;
        private int? _adAvailOffset;
        private string _passwordParam;
        private string _poisEndpoint;
        private string _username;
        private string _zoneIdentity;

        /// <summary>
        /// Gets and sets the property AcquisitionPointId. Sent as acquisitionPointIdentity to
        /// identify the MediaLive channel to the POIS.
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string AcquisitionPointId
        {
            get { return this._acquisitionPointId; }
            set { this._acquisitionPointId = value; }
        }

        // Check to see if AcquisitionPointId property is set
        internal bool IsSetAcquisitionPointId()
        {
            return this._acquisitionPointId != null;
        }

        /// <summary>
        /// Gets and sets the property AdAvailOffset. When specified, this offset (in milliseconds)
        /// is added to the input Ad Avail PTS time. This only applies to embedded SCTE 104/35
        /// messages and does not apply to OOB messages.
        /// </summary>
        [AWSProperty(Min=-1000, Max=1000)]
        public int AdAvailOffset
        {
            get { return this._adAvailOffset.GetValueOrDefault(); }
            set { this._adAvailOffset = value; }
        }

        // Check to see if AdAvailOffset property is set
        internal bool IsSetAdAvailOffset()
        {
            return this._adAvailOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PasswordParam. Documentation update needed
        /// </summary>
        public string PasswordParam
        {
            get { return this._passwordParam; }
            set { this._passwordParam = value; }
        }

        // Check to see if PasswordParam property is set
        internal bool IsSetPasswordParam()
        {
            return this._passwordParam != null;
        }

        /// <summary>
        /// Gets and sets the property PoisEndpoint. The URL of the signal conditioner endpoint
        /// on the Placement Opportunity Information System (POIS). MediaLive sends SignalProcessingEvents
        /// here when SCTE-35 messages are read.
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string PoisEndpoint
        {
            get { return this._poisEndpoint; }
            set { this._poisEndpoint = value; }
        }

        // Check to see if PoisEndpoint property is set
        internal bool IsSetPoisEndpoint()
        {
            return this._poisEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Username. Documentation update needed
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Gets and sets the property ZoneIdentity. Optional data sent as zoneIdentity to identify
        /// the MediaLive channel to the POIS.
        /// </summary>
        [AWSProperty(Max=256)]
        public string ZoneIdentity
        {
            get { return this._zoneIdentity; }
            set { this._zoneIdentity = value; }
        }

        // Check to see if ZoneIdentity property is set
        internal bool IsSetZoneIdentity()
        {
            return this._zoneIdentity != null;
        }

    }
}