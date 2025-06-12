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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Channel mapping contains the group of fields that hold the remixing value for each
    /// channel, in dB. Specify remix values to indicate how much of the content from your
    /// input audio channel you want in your output audio channels. Each instance of the InputChannels
    /// or InputChannelsFineTune array specifies these values for one output channel. Use
    /// one instance of this array for each output channel. In the console, each array corresponds
    /// to a column in the graphical depiction of the mapping matrix. The rows of the graphical
    /// matrix correspond to input channels. Valid values are within the range from -60 (mute)
    /// through 6. A setting of 0 passes the input channel unchanged to the output channel
    /// (no attenuation or amplification). Use InputChannels or InputChannelsFineTune to specify
    /// your remix values. Don't use both.
    /// </summary>
    public partial class ChannelMapping
    {
        private List<OutputChannelMapping> _outputChannels = AWSConfigs.InitializeCollections ? new List<OutputChannelMapping>() : null;

        /// <summary>
        /// Gets and sets the property OutputChannels. In your JSON job specification, include
        /// one child of OutputChannels for each audio channel that you want in your output. Each
        /// child should contain one instance of InputChannels or InputChannelsFineTune.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputChannelMapping> OutputChannels
        {
            get { return this._outputChannels; }
            set { this._outputChannels = value; }
        }

        // Check to see if OutputChannels property is set
        internal bool IsSetOutputChannels()
        {
            return this._outputChannels != null && (this._outputChannels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}