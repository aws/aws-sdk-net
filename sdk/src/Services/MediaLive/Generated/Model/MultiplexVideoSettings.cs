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
    /// The video configuration for each program in a multiplex.
    /// </summary>
    public partial class MultiplexVideoSettings
    {
        private int? _constantBitrate;
        private MultiplexStatmuxVideoSettings _statmuxSettings;

        /// <summary>
        /// Gets and sets the property ConstantBitrate. The constant bitrate configuration for
        /// the video encode.When this field is defined, StatmuxSettings must be undefined.
        /// </summary>
        [AWSProperty(Min=100000, Max=100000000)]
        public int? ConstantBitrate
        {
            get { return this._constantBitrate; }
            set { this._constantBitrate = value; }
        }

        // Check to see if ConstantBitrate property is set
        internal bool IsSetConstantBitrate()
        {
            return this._constantBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatmuxSettings. Statmux rate control settings.When this
        /// field is defined, ConstantBitrate must be undefined.
        /// </summary>
        public MultiplexStatmuxVideoSettings StatmuxSettings
        {
            get { return this._statmuxSettings; }
            set { this._statmuxSettings = value; }
        }

        // Check to see if StatmuxSettings property is set
        internal bool IsSetStatmuxSettings()
        {
            return this._statmuxSettings != null;
        }

    }
}