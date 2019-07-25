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
    /// Settings specific to embedded/ancillary caption outputs, including 608/708 Channel
    /// destination number.
    /// </summary>
    public partial class EmbeddedDestinationSettings
    {
        private int? _destination608ChannelNumber;
        private int? _destination708ServiceNumber;

        /// <summary>
        /// Gets and sets the property Destination608ChannelNumber. Ignore this setting unless
        /// your input captions are SCC format. With SCC inputs, you can optionally use this setting
        /// to replace the input channel number with the channel number that you specify. Specify
        /// a different number for each output captions track for a particular output. If you
        /// don't specify an output channel number, the system uses the input channel number for
        /// the output channel number. You can optionally combine two captions channels in your
        /// output. The two output channel numbers can be one of the following pairs: 1,3; 2,4;
        /// 1,4; or 2,3.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public int Destination608ChannelNumber
        {
            get { return this._destination608ChannelNumber.GetValueOrDefault(); }
            set { this._destination608ChannelNumber = value; }
        }

        // Check to see if Destination608ChannelNumber property is set
        internal bool IsSetDestination608ChannelNumber()
        {
            return this._destination608ChannelNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Destination708ServiceNumber. Ignore this setting unless
        /// your input captions are SCC format and you are performing SCC upconvert. With SCC
        /// inputs, you can optionally use this setting to specify the 708 service number that
        /// is in the output. Specify a different service number for each output captions track
        /// for a particular output. If you don't specify an output track number, the system uses
        /// the 608 channel number for the output 708 service number. You can combine two captions
        /// channels in your output. Service numbers must be distinct.
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public int Destination708ServiceNumber
        {
            get { return this._destination708ServiceNumber.GetValueOrDefault(); }
            set { this._destination708ServiceNumber = value; }
        }

        // Check to see if Destination708ServiceNumber property is set
        internal bool IsSetDestination708ServiceNumber()
        {
            return this._destination708ServiceNumber.HasValue; 
        }

    }
}