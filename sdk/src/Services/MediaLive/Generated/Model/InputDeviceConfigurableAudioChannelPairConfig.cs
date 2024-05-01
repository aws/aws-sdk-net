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
    /// One audio configuration that specifies the format for one audio pair that the device
    /// produces as output.
    /// </summary>
    public partial class InputDeviceConfigurableAudioChannelPairConfig
    {
        private int? _id;
        private InputDeviceConfigurableAudioChannelPairProfile _profile;

        /// <summary>
        /// Gets and sets the property Id. The ID for one audio pair configuration, a value from
        /// 1 to 8.
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Profile. The profile to set for one audio pair configuration.
        /// Choose an enumeration value. Each value describes one audio configuration using the
        /// format (rate control algorithm)-(codec)_(quality)-(bitrate in bytes). For example,
        /// CBR-AAC_HQ-192000. Or choose DISABLED, in which case the device won't produce audio
        /// for this pair.
        /// </summary>
        public InputDeviceConfigurableAudioChannelPairProfile Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this._profile != null;
        }

    }
}