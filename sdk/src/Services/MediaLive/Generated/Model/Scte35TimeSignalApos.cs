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
    /// Atypical configuration that applies segment breaks only on SCTE-35 time signal placement
    /// opportunities and breaks.
    /// </summary>
    public partial class Scte35TimeSignalApos
    {
        private int? _adAvailOffset;
        private Scte35AposNoRegionalBlackoutBehavior _noRegionalBlackoutFlag;
        private Scte35AposWebDeliveryAllowedBehavior _webDeliveryAllowedFlag;

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
        /// Gets and sets the property NoRegionalBlackoutFlag. When set to ignore, Segment Descriptors
        /// with noRegionalBlackoutFlag set to 0 will no longer trigger blackouts or Ad Avail
        /// slates
        /// </summary>
        public Scte35AposNoRegionalBlackoutBehavior NoRegionalBlackoutFlag
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
        /// Gets and sets the property WebDeliveryAllowedFlag. When set to ignore, Segment Descriptors
        /// with webDeliveryAllowedFlag set to 0 will no longer trigger blackouts or Ad Avail
        /// slates
        /// </summary>
        public Scte35AposWebDeliveryAllowedBehavior WebDeliveryAllowedFlag
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