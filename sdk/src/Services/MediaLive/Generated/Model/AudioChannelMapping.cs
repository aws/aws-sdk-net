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
    /// Audio Channel Mapping
    /// </summary>
    public partial class AudioChannelMapping
    {
        private List<InputChannelLevel> _inputChannelLevels = new List<InputChannelLevel>();
        private int? _outputChannel;

        /// <summary>
        /// Gets and sets the property InputChannelLevels. Indices and gain values for each input
        /// channel that should be remixed into this output channel.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<InputChannelLevel> InputChannelLevels
        {
            get { return this._inputChannelLevels; }
            set { this._inputChannelLevels = value; }
        }

        // Check to see if InputChannelLevels property is set
        internal bool IsSetInputChannelLevels()
        {
            return this._inputChannelLevels != null && this._inputChannelLevels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputChannel. The index of the output channel being produced.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=7)]
        public int OutputChannel
        {
            get { return this._outputChannel.GetValueOrDefault(); }
            set { this._outputChannel = value; }
        }

        // Check to see if OutputChannel property is set
        internal bool IsSetOutputChannel()
        {
            return this._outputChannel.HasValue; 
        }

    }
}