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
    /// Specifies how Elemental Inference chooses frames from the media of each run, and how
    /// many frames it chooses. The media of a run is the interval, shot, scene, or clips
    /// that the run covers.
    /// </summary>
    public partial class FrameSamplingStrategy
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of frames to send on each run. Valid range: 1 to 64. The default is 1.
        /// Each frame adds to the size of the model request and to what the model charges for
        /// it. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Which frames of the window to send: FIRST (the first frames), UNIFORM (frames spread
        /// evenly across the window), or LAST (the last frames). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FrameSamplingMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;
    }
}
