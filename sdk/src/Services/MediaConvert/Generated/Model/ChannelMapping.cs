/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Channel mapping (ChannelMapping) contains the group of fields that hold the remixing
    /// value for each channel. Units are in dB. Acceptable values are within the range from
    /// -60 (mute) through 6. A setting of 0 passes the input channel unchanged to the output
    /// channel (no attenuation or amplification).
    /// </summary>
    public partial class ChannelMapping
    {
        private List<OutputChannelMapping> _outputChannels = new List<OutputChannelMapping>();

        /// <summary>
        /// Gets and sets the property OutputChannels. List of output channels
        /// </summary>
        public List<OutputChannelMapping> OutputChannels
        {
            get { return this._outputChannels; }
            set { this._outputChannels = value; }
        }

        // Check to see if OutputChannels property is set
        internal bool IsSetOutputChannels()
        {
            return this._outputChannels != null && this._outputChannels.Count > 0; 
        }

    }
}