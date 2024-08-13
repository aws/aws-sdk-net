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
    /// Settings related to CEA/EIA-608 and CEA/EIA-708 (also called embedded or ancillary)
    /// captions. Set up embedded captions in the same output as your video. For more information,
    /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/embedded-output-captions.html.
    /// </summary>
    public partial class EmbeddedDestinationSettings
    {
        private int? _destination608ChannelNumber;
        private int? _destination708ServiceNumber;

        /// <summary>
        /// Gets and sets the property Destination608ChannelNumber. Ignore this setting unless
        /// your input captions are SCC format and your output captions are embedded in the video
        /// stream. Specify a CC number for each captions channel in this output. If you have
        /// two channels, choose CC numbers that aren't in the same field. For example, choose
        /// 1 and 3. For more information, see https://docs.aws.amazon.com/console/mediaconvert/dual-scc-to-embedded.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public int? Destination608ChannelNumber
        {
            get { return this._destination608ChannelNumber; }
            set { this._destination608ChannelNumber = value; }
        }

        // Check to see if Destination608ChannelNumber property is set
        internal bool IsSetDestination608ChannelNumber()
        {
            return this._destination608ChannelNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Destination708ServiceNumber. Ignore this setting unless
        /// your input captions are SCC format and you want both 608 and 708 captions embedded
        /// in your output stream. Optionally, specify the 708 service number for each output
        /// captions channel. Choose a different number for each channel. To use this setting,
        /// also set Force 608 to 708 upconvert to Upconvert in your input captions selector settings.
        /// If you choose to upconvert but don't specify a 708 service number, MediaConvert uses
        /// the number that you specify for CC channel number for the 708 service number. For
        /// more information, see https://docs.aws.amazon.com/console/mediaconvert/dual-scc-to-embedded.
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public int? Destination708ServiceNumber
        {
            get { return this._destination708ServiceNumber; }
            set { this._destination708ServiceNumber = value; }
        }

        // Check to see if Destination708ServiceNumber property is set
        internal bool IsSetDestination708ServiceNumber()
        {
            return this._destination708ServiceNumber.HasValue; 
        }

    }
}