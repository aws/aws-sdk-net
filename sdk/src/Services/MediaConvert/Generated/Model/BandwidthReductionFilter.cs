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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
    /// The Bandwidth reduction filter increases the video quality of your output relative
    /// to its bitrate. Use to lower the bitrate of your constant quality QVBR output, with
    /// little or no perceptual decrease in quality. Or, use to increase the video quality
    /// of outputs with other rate control modes relative to the bitrate that you specify.
    /// Bandwidth reduction increases further when your input is low quality or noisy. Outputs
    /// that use this feature incur pro-tier pricing. When you include Bandwidth reduction
    /// filter, you cannot include the Noise reducer preprocessor.
    /// </summary>
    public partial class BandwidthReductionFilter
    {
        private BandwidthReductionFilterSharpening _sharpening;
        private BandwidthReductionFilterStrength _strength;

        /// <summary>
        /// Gets and sets the property Sharpening. Optionally specify the level of sharpening
        /// to apply when you use the Bandwidth reduction filter. Sharpening adds contrast to
        /// the edges of your video content and can reduce softness. Keep the default value Off
        /// to apply no sharpening. Set Sharpening strength to Low to apply a minimal amount of
        /// sharpening, or High to apply a maximum amount of sharpening.
        /// </summary>
        public BandwidthReductionFilterSharpening Sharpening
        {
            get { return this._sharpening; }
            set { this._sharpening = value; }
        }

        // Check to see if Sharpening property is set
        internal bool IsSetSharpening()
        {
            return this._sharpening != null;
        }

        /// <summary>
        /// Gets and sets the property Strength. Specify the strength of the Bandwidth reduction
        /// filter. For most workflows, we recommend that you choose Auto to reduce the bandwidth
        /// of your output with little to no perceptual decrease in video quality. For high quality
        /// and high bitrate outputs, choose Low. For the most bandwidth reduction, choose High.
        /// We recommend that you choose High for low bitrate outputs. Note that High may incur
        /// a slight increase in the softness of your output.
        /// </summary>
        public BandwidthReductionFilterStrength Strength
        {
            get { return this._strength; }
            set { this._strength = value; }
        }

        // Check to see if Strength property is set
        internal bool IsSetStrength()
        {
            return this._strength != null;
        }

    }
}