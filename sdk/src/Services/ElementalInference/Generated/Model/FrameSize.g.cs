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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// The dimensions, in pixels, of each frame that a function sends. Elemental Inference
    /// resizes each frame to exactly this width and height.
    /// </summary>
    public partial class FrameSize
    {
        /// <summary>
        /// Gets and sets the property HeightPixels. 
        /// <para>
        /// The height of each frame, in pixels. Valid range: 1 to 720.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 720)]
        public int? HeightPixels { get; set; }

        /// <summary>
        /// Checks to see if the HeightPixels property is set.
        /// </summary>
        internal bool IsSetHeightPixels() => this.HeightPixels.HasValue;

        /// <summary>
        /// Gets and sets the property WidthPixels. 
        /// <para>
        /// The width of each frame, in pixels. Valid range: 1 to 1280.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1280)]
        public int? WidthPixels { get; set; }

        /// <summary>
        /// Checks to see if the WidthPixels property is set.
        /// </summary>
        internal bool IsSetWidthPixels() => this.WidthPixels.HasValue;
    }
}
