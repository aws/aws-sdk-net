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
    /// The vendor-specified custom profile options
    /// </summary>
    public partial class AbWatermarkingCustomProfile
    {
        /// <summary>
        /// Gets and sets the property EmbeddingFrequency. The frequency with which watermarks
        /// will be embedded, in milliseconds.
        /// </summary>
        [AWSProperty(Required = true)]
        public double? EmbeddingFrequency { get; set; }

        /// <summary>
        /// Checks to see if the EmbeddingFrequency property is set.
        /// </summary>
        internal bool IsSetEmbeddingFrequency() => this.EmbeddingFrequency.HasValue;

        /// <summary>
        /// Gets and sets the property SceneCut. The number of frames after scene-cut to embed
        /// the watermark.
        /// </summary>
        [AWSProperty(Required = true)]
        public double? SceneCut { get; set; }

        /// <summary>
        /// Checks to see if the SceneCut property is set.
        /// </summary>
        internal bool IsSetSceneCut() => this.SceneCut.HasValue;

        /// <summary>
        /// Gets and sets the property TargetPsnr. The target PSNR of the watermarked frame
        /// </summary>
        [AWSProperty(Required = true)]
        public double? TargetPsnr { get; set; }

        /// <summary>
        /// Checks to see if the TargetPsnr property is set.
        /// </summary>
        internal bool IsSetTargetPsnr() => this.TargetPsnr.HasValue;
    }
}
