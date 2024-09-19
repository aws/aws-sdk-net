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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private BandwidthReductionPostFilterSharpening _postFilterSharpening;
        private BandwidthReductionFilterStrength _strength;

        /// <summary>
        /// Gets and sets the property PostFilterSharpening. Configures the sharpening control,
        /// which is available when the bandwidth reduction filter is enabled. Thiscontrol sharpens
        /// edges and contours, which produces a specific artistic effect that you might want.We
        /// recommend that you test each of the values (including DISABLED) to observe the sharpening
        /// effect on thecontent.
        /// </summary>
        public BandwidthReductionPostFilterSharpening PostFilterSharpening
        {
            get { return this._postFilterSharpening; }
            set { this._postFilterSharpening = value; }
        }

        // Check to see if PostFilterSharpening property is set
        internal bool IsSetPostFilterSharpening()
        {
            return this._postFilterSharpening != null;
        }

        /// <summary>
        /// Gets and sets the property Strength. Enables the bandwidth reduction filter. The filter
        /// strengths range from 1 to 4. We recommend that you alwaysenable this filter and use
        /// AUTO, to let MediaLive apply the optimum filtering for the context.
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