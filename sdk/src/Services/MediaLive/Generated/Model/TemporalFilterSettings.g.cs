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
    /// Temporal Filter Settings
    /// </summary>
    public partial class TemporalFilterSettings
    {
        /// <summary>
        /// Gets and sets the property PostFilterSharpening. If you enable this filter, the results
        /// are the following: - If the source content is noisy (it contains excessive digital
        /// artifacts), the filter cleans up the source. - If the source content is already clean,
        /// the filter tends to decrease the bitrate, especially when the rate control mode is
        /// QVBR.
        /// </summary>
        public TemporalFilterPostFilterSharpening PostFilterSharpening { get; set; }

        /// <summary>
        /// Checks to see if the PostFilterSharpening property is set.
        /// </summary>
        internal bool IsSetPostFilterSharpening() => this.PostFilterSharpening != null;

        /// <summary>
        /// Gets and sets the property Strength. Choose a filter strength. We recommend a strength
        /// of 1 or 2. A higher strength might take out good information, resulting in an image
        /// that is overly soft.
        /// </summary>
        public TemporalFilterStrength Strength { get; set; }

        /// <summary>
        /// Checks to see if the Strength property is set.
        /// </summary>
        internal bool IsSetStrength() => this.Strength != null;
    }
}
