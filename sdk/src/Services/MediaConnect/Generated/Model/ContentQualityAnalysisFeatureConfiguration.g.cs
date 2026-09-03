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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Configures the content quality analysis features for the router input.
    /// </summary>
    public partial class ContentQualityAnalysisFeatureConfiguration
    {
        /// <summary>
        /// Gets and sets the property BlackFrames. 
        /// <para>
        /// Settings for black frames detection.
        /// </para>
        /// </summary>
        public BlackFramesConfiguration BlackFrames { get; set; }

        /// <summary>
        /// Checks to see if the BlackFrames property is set.
        /// </summary>
        internal bool IsSetBlackFrames() => this.BlackFrames != null;

        /// <summary>
        /// Gets and sets the property FrozenFrames. 
        /// <para>
        /// Settings for frozen frames detection.
        /// </para>
        /// </summary>
        public FrozenFramesConfiguration FrozenFrames { get; set; }

        /// <summary>
        /// Checks to see if the FrozenFrames property is set.
        /// </summary>
        internal bool IsSetFrozenFrames() => this.FrozenFrames != null;

        /// <summary>
        /// Gets and sets the property SilentAudio. 
        /// <para>
        /// Settings for silent audio detection.
        /// </para>
        /// </summary>
        public SilentAudioConfiguration SilentAudio { get; set; }

        /// <summary>
        /// Checks to see if the SilentAudio property is set.
        /// </summary>
        internal bool IsSetSilentAudio() => this.SilentAudio != null;
    }
}
