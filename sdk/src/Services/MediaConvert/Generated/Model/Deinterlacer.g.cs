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
    /// Settings for deinterlacer
    /// </summary>
    public partial class Deinterlacer
    {
        /// <summary>
        /// Gets and sets the property Algorithm. Only applies when you set Deinterlace mode to
        /// Deinterlace or Adaptive. Interpolate produces sharper pictures, while blend produces
        /// smoother motion. If your source file includes a ticker, such as a scrolling headline
        /// at the bottom of the frame: Choose Interpolate ticker or Blend ticker. To apply field
        /// doubling: Choose Linear interpolation. Note that Linear interpolation may introduce
        /// video artifacts into your output.
        /// </summary>
        public DeinterlaceAlgorithm Algorithm { get; set; }

        /// <summary>
        /// Checks to see if the Algorithm property is set.
        /// </summary>
        internal bool IsSetAlgorithm() => this.Algorithm != null;

        /// <summary>
        /// Gets and sets the property Control. - When set to NORMAL (default), the deinterlacer
        /// does not convert frames that are tagged in metadata as progressive. It will only convert
        /// those that are tagged as some other type. - When set to FORCE_ALL_FRAMES, the deinterlacer
        /// converts every frame to progressive - even those that are already tagged as progressive.
        /// Turn Force mode on only if there is a good chance that the metadata has tagged frames
        /// as progressive when they are not progressive. Do not turn on otherwise; processing
        /// frames that are already progressive into progressive will probably result in lower
        /// quality video.
        /// </summary>
        public DeinterlacerControl Control { get; set; }

        /// <summary>
        /// Checks to see if the Control property is set.
        /// </summary>
        internal bool IsSetControl() => this.Control != null;

        /// <summary>
        /// Gets and sets the property Mode. Use Deinterlacer to choose how the service will do
        /// deinterlacing. Default is Deinterlace. - Deinterlace converts interlaced to progressive.
        /// - Inverse telecine converts Hard Telecine 29.97i to progressive 23.976p. - Adaptive
        /// auto-detects and converts to progressive.
        /// </summary>
        public DeinterlacerMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;
    }
}
