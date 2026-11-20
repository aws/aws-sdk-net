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
    /// Dynamic Multiview settings. Encodes this video output so that a downstream packager
    /// can combine it with other outputs in a Dynamic Multiview presentation, or replace
    /// parts of it. Available for H.264 and H.265 outputs. Enabling Dynamic Multiview reduces
    /// compression efficiency.
    /// </summary>
    public partial class DynamicMultiviewSettings
    {
        /// <summary>
        /// Gets and sets the property Enabled. Choose Enabled to encode this video output for
        /// Dynamic Multiview. With no regions, the whole frame is one view in the presentation.
        /// With regions, only those rectangles can be replaced. Keep the default value, Disabled,
        /// to leave Dynamic Multiview off; regions must then be empty. Dynamic Multiview outputs
        /// must be progressive and use a Dynamic sub-GOP of Static. MediaConvert also overrides
        /// some encoder settings on these outputs: Explicit weighted prediction for H.264, and
        /// Tree block size and MV temporal predictor for H.265.
        /// </summary>
        public DynamicMultiviewSettingsEnabled Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled != null;

        /// <summary>
        /// Gets and sets the property Regions. Optional rectangles that a downstream packager
        /// can replace with other content, such as an ad. MediaConvert fills each region with
        /// black and encodes it independently of the rest of the frame. Leave empty to use the
        /// whole frame as one view. H.264 outputs support up to 8 regions; H.265 outputs support
        /// 1.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Rectangle> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<Rectangle>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
