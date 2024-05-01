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
    /// Input Channel Level
    /// </summary>
    public partial class InputChannelLevel
    {
        private int? _gain;
        private int? _inputChannel;

        /// <summary>
        /// Gets and sets the property Gain. Remixing value. Units are in dB and acceptable values
        /// are within the range from -60 (mute) and 6 dB.
        /// </summary>
        [AWSProperty(Required=true, Min=-60, Max=6)]
        public int? Gain
        {
            get { return this._gain; }
            set { this._gain = value; }
        }

        // Check to see if Gain property is set
        internal bool IsSetGain()
        {
            return this._gain.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputChannel. The index of the input channel used as a
        /// source.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=15)]
        public int? InputChannel
        {
            get { return this._inputChannel; }
            set { this._inputChannel = value; }
        }

        // Check to see if InputChannel property is set
        internal bool IsSetInputChannel()
        {
            return this._inputChannel.HasValue; 
        }

    }
}