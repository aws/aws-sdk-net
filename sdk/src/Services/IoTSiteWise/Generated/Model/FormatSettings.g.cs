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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains the output format configuration for video processing.
    /// </summary>
    public partial class FormatSettings
    {
        /// <summary>
        /// Gets and sets the property FramesPerSecond. 
        /// <para>
        /// The target frame rate for the output.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? FramesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the FramesPerSecond property is set.
        /// </summary>
        internal bool IsSetFramesPerSecond() => this.FramesPerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property HeightInPixels. 
        /// <para>
        /// The target height of the output, in pixels.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? HeightInPixels { get; set; }

        /// <summary>
        /// Checks to see if the HeightInPixels property is set.
        /// </summary>
        internal bool IsSetHeightInPixels() => this.HeightInPixels.HasValue;

        /// <summary>
        /// Gets and sets the property WidthInPixels. 
        /// <para>
        /// The target width of the output, in pixels.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? WidthInPixels { get; set; }

        /// <summary>
        /// Checks to see if the WidthInPixels property is set.
        /// </summary>
        internal bool IsSetWidthInPixels() => this.WidthInPixels.HasValue;
    }
}
