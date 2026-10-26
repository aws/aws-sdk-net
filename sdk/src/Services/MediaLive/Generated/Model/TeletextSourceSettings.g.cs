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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Teletext Source Settings
    /// </summary>
    public partial class TeletextSourceSettings
    {
        /// <summary>
        /// Gets and sets the property OutputRectangle. Optionally defines a region where TTML
        /// style captions will be displayed
        /// </summary>
        public CaptionRectangle OutputRectangle { get; set; }

        /// <summary>
        /// Checks to see if the OutputRectangle property is set.
        /// </summary>
        internal bool IsSetOutputRectangle() => this.OutputRectangle != null;

        /// <summary>
        /// Gets and sets the property PageNumber. Specifies the teletext page number within the
        /// data stream from which to extract captions. Range of 0x100 (256) to 0x8FF (2303).
        /// Unused for passthrough. Should be specified as a hexadecimal string with no "0x" prefix.
        /// </summary>
        public string PageNumber { get; set; }

        /// <summary>
        /// Checks to see if the PageNumber property is set.
        /// </summary>
        internal bool IsSetPageNumber() => this.PageNumber != null;
    }
}
