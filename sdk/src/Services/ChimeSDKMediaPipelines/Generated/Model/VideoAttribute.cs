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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
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
        private BorderColor _borderColor;
        private int? _borderThickness;
        private int? _cornerRadius;
        private HighlightColor _highlightColor;

        /// <summary>
        /// Gets and sets the property BorderColor. 
        /// <para>
        /// Defines the border color of all video tiles.
        /// </para>
        /// </summary>
        public BorderColor BorderColor
        {
            get { return this._borderColor; }
            set { this._borderColor = value; }
        }

        // Check to see if BorderColor property is set
        internal bool IsSetBorderColor()
        {
            return this._borderColor != null;
        }

        /// <summary>
        /// Gets and sets the property BorderThickness. 
        /// <para>
        /// Defines the border thickness for all video tiles.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int? BorderThickness
        {
            get { return this._borderThickness; }
            set { this._borderThickness = value; }
        }

        // Check to see if BorderThickness property is set
        internal bool IsSetBorderThickness()
        {
            return this._borderThickness.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CornerRadius. 
        /// <para>
        /// Sets the corner radius of all video tiles.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int? CornerRadius
        {
            get { return this._cornerRadius; }
            set { this._cornerRadius = value; }
        }

        // Check to see if CornerRadius property is set
        internal bool IsSetCornerRadius()
        {
            return this._cornerRadius.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HighlightColor. 
        /// <para>
        /// Defines the highlight color for the active video tile.
        /// </para>
        /// </summary>
        public HighlightColor HighlightColor
        {
            get { return this._highlightColor; }
            set { this._highlightColor = value; }
        }

        // Check to see if HighlightColor property is set
        internal bool IsSetHighlightColor()
        {
            return this._highlightColor != null;
        }

    }
}