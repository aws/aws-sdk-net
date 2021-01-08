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
    /// Scte20 Source Settings
    /// </summary>
    public partial class Scte20SourceSettings
    {
        private Scte20Convert608To708 _convert608To708;
        private int? _source608ChannelNumber;

        /// <summary>
        /// Gets and sets the property Convert608To708. If upconvert, 608 data is both passed
        /// through via the "608 compatibility bytes" fields of the 708 wrapper as well as translated
        /// into 708. 708 data present in the source content will be discarded.
        /// </summary>
        public Scte20Convert608To708 Convert608To708
        {
            get { return this._convert608To708; }
            set { this._convert608To708 = value; }
        }

        // Check to see if Convert608To708 property is set
        internal bool IsSetConvert608To708()
        {
            return this._convert608To708 != null;
        }

        /// <summary>
        /// Gets and sets the property Source608ChannelNumber. Specifies the 608/708 channel number
        /// within the video track from which to extract captions. Unused for passthrough.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public int Source608ChannelNumber
        {
            get { return this._source608ChannelNumber.GetValueOrDefault(); }
            set { this._source608ChannelNumber = value; }
        }

        // Check to see if Source608ChannelNumber property is set
        internal bool IsSetSource608ChannelNumber()
        {
            return this._source608ChannelNumber.HasValue; 
        }

    }
}