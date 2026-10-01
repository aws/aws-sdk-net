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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Settings for ancillary captions source.
    /// </summary>
    public partial class AncillarySourceSettings
    {
        /// <summary>
        /// Gets and sets the property Convert608To708. Specify whether this set of input captions
        /// appears in your outputs in both 608 and 708 format. If you choose Upconvert, MediaConvert
        /// includes the captions data in two ways: it passes the 608 data through using the 608
        /// compatibility bytes fields of the 708 wrapper, and it also translates the 608 data
        /// into 708.
        /// </summary>
        public AncillaryConvert608To708 Convert608To708 { get; set; }

        /// <summary>
        /// Checks to see if the Convert608To708 property is set.
        /// </summary>
        internal bool IsSetConvert608To708() => this.Convert608To708 != null;

        /// <summary>
        /// Gets and sets the property SourceAncillaryChannelNumber. Specifies the 608 channel
        /// number in the ancillary data track from which to extract captions. Unused for passthrough.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public int? SourceAncillaryChannelNumber { get; set; }

        /// <summary>
        /// Checks to see if the SourceAncillaryChannelNumber property is set.
        /// </summary>
        internal bool IsSetSourceAncillaryChannelNumber() => this.SourceAncillaryChannelNumber.HasValue;

        /// <summary>
        /// Gets and sets the property TerminateCaptions. By default, the service terminates any
        /// unterminated captions at the end of each input. If you want the caption to continue
        /// onto your next input, disable this setting.
        /// </summary>
        public AncillaryTerminateCaptions TerminateCaptions { get; set; }

        /// <summary>
        /// Checks to see if the TerminateCaptions property is set.
        /// </summary>
        internal bool IsSetTerminateCaptions() => this.TerminateCaptions != null;
    }
}
