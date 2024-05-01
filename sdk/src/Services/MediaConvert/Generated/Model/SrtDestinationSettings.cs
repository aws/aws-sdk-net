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
    /// Settings related to SRT captions. SRT is a sidecar format that holds captions in a
    /// file that is separate from the video container. Set up sidecar captions in the same
    /// output group, but different output from your video.
    /// </summary>
    public partial class SrtDestinationSettings
    {
        private SrtStylePassthrough _stylePassthrough;

        /// <summary>
        /// Gets and sets the property StylePassthrough. Set Style passthrough to ENABLED to use
        /// the available style, color, and position information from your input captions. MediaConvert
        /// uses default settings for any missing style and position information in your input
        /// captions. Set Style passthrough to DISABLED, or leave blank, to ignore the style and
        /// position information from your input captions and use simplified output captions.
        /// </summary>
        public SrtStylePassthrough StylePassthrough
        {
            get { return this._stylePassthrough; }
            set { this._stylePassthrough = value; }
        }

        // Check to see if StylePassthrough property is set
        internal bool IsSetStylePassthrough()
        {
            return this._stylePassthrough != null;
        }

    }
}