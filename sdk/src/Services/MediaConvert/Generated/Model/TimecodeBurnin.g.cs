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
    /// Settings for burning the output timecode and specified prefix into the output.
    /// </summary>
    public partial class TimecodeBurnin
    {
        /// <summary>
        /// Gets and sets the property FontSize. Use Font size to set the font size of any burned-in
        /// timecode. Valid values are 10, 16, 32, 48.
        /// </summary>
        [AWSProperty(Min = 10, Max = 48)]
        public int? FontSize { get; set; }

        /// <summary>
        /// Checks to see if the FontSize property is set.
        /// </summary>
        internal bool IsSetFontSize() => this.FontSize.HasValue;

        /// <summary>
        /// Gets and sets the property Position. Use Position under Timecode burn-in to specify
        /// the location the burned-in timecode on output video.
        /// </summary>
        public TimecodeBurninPosition Position { get; set; }

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null;

        /// <summary>
        /// Gets and sets the property Prefix. Use Prefix to place ASCII characters before any
        /// burned-in timecode. For example, a prefix of "EZ-" will result in the timecode "EZ-00:00:00:00".
        /// Provide either the characters themselves or the ASCII code equivalents. The supported
        /// range of characters is 0x20 through 0x7e. This includes letters, numbers, and all
        /// special characters represented on a standard English keyboard.
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;
    }
}
