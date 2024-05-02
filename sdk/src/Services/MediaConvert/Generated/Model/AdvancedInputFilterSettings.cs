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
    /// Optional settings for Advanced input filter when you set Advanced input filter to
    /// Enabled.
    /// </summary>
    public partial class AdvancedInputFilterSettings
    {
        private AdvancedInputFilterAddTexture _addTexture;
        private AdvancedInputFilterSharpen _sharpening;

        /// <summary>
        /// Gets and sets the property AddTexture. Add texture and detail to areas of your input
        /// video content that were lost after applying the Advanced input filter. To adaptively
        /// add texture and reduce softness: Choose Enabled. To not add any texture: Keep the
        /// default value, Disabled. We recommend that you choose Disabled for input video content
        /// that doesn't have texture, including screen recordings, computer graphics, or cartoons.
        /// </summary>
        public AdvancedInputFilterAddTexture AddTexture
        {
            get { return this._addTexture; }
            set { this._addTexture = value; }
        }

        // Check to see if AddTexture property is set
        internal bool IsSetAddTexture()
        {
            return this._addTexture != null;
        }

        /// <summary>
        /// Gets and sets the property Sharpening. Optionally specify the amount of sharpening
        /// to apply when you use the Advanced input filter. Sharpening adds contrast to the edges
        /// of your video content and can reduce softness. To apply no sharpening: Keep the default
        /// value, Off. To apply a minimal amount of sharpening choose Low, or for the maximum
        /// choose High.
        /// </summary>
        public AdvancedInputFilterSharpen Sharpening
        {
            get { return this._sharpening; }
            set { this._sharpening = value; }
        }

        // Check to see if Sharpening property is set
        internal bool IsSetSharpening()
        {
            return this._sharpening != null;
        }

    }
}