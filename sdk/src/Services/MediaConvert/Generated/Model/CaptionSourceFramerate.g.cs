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
    /// Ignore this setting unless your input captions format is SCC. To have the service
    /// compensate for differing frame rates between your input captions and input video,
    /// specify the frame rate of the captions file. Specify this value as a fraction. For
    /// example, you might specify 24 / 1 for 24 fps, 25 / 1 for 25 fps, 24000 / 1001 for
    /// 23.976 fps, or 30000 / 1001 for 29.97 fps.
    /// </summary>
    public partial class CaptionSourceFramerate
    {
        /// <summary>
        /// Gets and sets the property FramerateDenominator. Specify the denominator of the fraction
        /// that represents the frame rate for the setting Caption source frame rate. Use this
        /// setting along with the setting Framerate numerator.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1001)]
        public int? FramerateDenominator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateDenominator property is set.
        /// </summary>
        internal bool IsSetFramerateDenominator() => this.FramerateDenominator.HasValue;

        /// <summary>
        /// Gets and sets the property FramerateNumerator. Specify the numerator of the fraction
        /// that represents the frame rate for the setting Caption source frame rate. Use this
        /// setting along with the setting Framerate denominator.
        /// </summary>
        [AWSProperty(Min = 1, Max = 60000)]
        public int? FramerateNumerator { get; set; }

        /// <summary>
        /// Checks to see if the FramerateNumerator property is set.
        /// </summary>
        internal bool IsSetFramerateNumerator() => this.FramerateNumerator.HasValue;
    }
}
