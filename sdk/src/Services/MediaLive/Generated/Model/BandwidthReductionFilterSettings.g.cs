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
    /// Bandwidth Reduction Filter Settings
    /// </summary>
    public partial class BandwidthReductionFilterSettings
    {
        /// <summary>
        /// Gets and sets the property PostFilterSharpening. Configures the sharpening control,
        /// which is available when the bandwidth reduction filter is enabled. This control sharpens
        /// edges and contours, which produces a specific artistic effect that you might want.
        /// We recommend that you test each of the values (including DISABLED) to observe the
        /// sharpening effect on the content.
        /// </summary>
        public BandwidthReductionPostFilterSharpening PostFilterSharpening { get; set; }

        /// <summary>
        /// Checks to see if the PostFilterSharpening property is set.
        /// </summary>
        internal bool IsSetPostFilterSharpening() => this.PostFilterSharpening != null;

        /// <summary>
        /// Gets and sets the property Strength. Enables the bandwidth reduction filter. The filter
        /// strengths range from 1 to 4. We recommend that you always enable this filter and use
        /// AUTO, to let MediaLive apply the optimum filtering for the context.
        /// </summary>
        public BandwidthReductionFilterStrength Strength { get; set; }

        /// <summary>
        /// Checks to see if the Strength property is set.
        /// </summary>
        internal bool IsSetStrength() => this.Strength != null;
    }
}
