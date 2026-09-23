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

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Defines the settings for a video tile.
    /// </summary>
    public partial class VideoAttribute
    {
        /// <summary>
        /// Gets and sets the property BorderColor. 
        /// <para>
        /// Defines the border color of all video tiles.
        /// </para>
        /// </summary>
        public BorderColor BorderColor { get; set; }

        /// <summary>
        /// Checks to see if the BorderColor property is set.
        /// </summary>
        internal bool IsSetBorderColor() => this.BorderColor != null;

        /// <summary>
        /// Gets and sets the property BorderThickness. 
        /// <para>
        /// Defines the border thickness for all video tiles.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? BorderThickness { get; set; }

        /// <summary>
        /// Checks to see if the BorderThickness property is set.
        /// </summary>
        internal bool IsSetBorderThickness() => this.BorderThickness.HasValue;

        /// <summary>
        /// Gets and sets the property CornerRadius. 
        /// <para>
        /// Sets the corner radius of all video tiles.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? CornerRadius { get; set; }

        /// <summary>
        /// Checks to see if the CornerRadius property is set.
        /// </summary>
        internal bool IsSetCornerRadius() => this.CornerRadius.HasValue;

        /// <summary>
        /// Gets and sets the property HighlightColor. 
        /// <para>
        /// Defines the highlight color for the active video tile.
        /// </para>
        /// </summary>
        public HighlightColor HighlightColor { get; set; }

        /// <summary>
        /// Checks to see if the HighlightColor property is set.
        /// </summary>
        internal bool IsSetHighlightColor() => this.HighlightColor != null;
    }
}
