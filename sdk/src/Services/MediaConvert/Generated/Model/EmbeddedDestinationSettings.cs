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

        /// <summary>
        /// Gets and sets the property Destination608ChannelNumber. Ignore this setting unless
        /// your input captions are SCC format and your output container is MXF. With this combination
        /// of input captions format and output container, you can optionally use this setting
        /// to replace the input channel number with the track number that you specify. Specify
        /// a different number for each output captions track. If you don't specify an output
        /// track number, the system uses the input channel number for the output channel number.
        /// This setting applies to each output individually. You can optionally combine two captions
        /// channels in your output. The two output channel numbers can be one of the following
        /// pairs: 1,3; 2,4; 1,4; or 2,3.
        /// </summary>
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

    }
}