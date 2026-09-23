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
    /// Defines the configuration settings for a vertical layout.
    /// </summary>
    public partial class VerticalLayoutConfiguration
    {
        /// <summary>
        /// Gets and sets the property TileAspectRatio. 
        /// <para>
        /// Sets the aspect ratio of the video tiles, such as 16:9.
        /// </para>
        /// </summary>
        public string TileAspectRatio { get; set; }

        /// <summary>
        /// Checks to see if the TileAspectRatio property is set.
        /// </summary>
        internal bool IsSetTileAspectRatio() => this.TileAspectRatio != null;

        /// <summary>
        /// Gets and sets the property TileCount. 
        /// <para>
        /// The maximum number of tiles to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? TileCount { get; set; }

        /// <summary>
        /// Checks to see if the TileCount property is set.
        /// </summary>
        internal bool IsSetTileCount() => this.TileCount.HasValue;

        /// <summary>
        /// Gets and sets the property TileOrder. 
        /// <para>
        /// Sets the automatic ordering of the video tiles.
        /// </para>
        /// </summary>
        public TileOrder TileOrder { get; set; }

        /// <summary>
        /// Checks to see if the TileOrder property is set.
        /// </summary>
        internal bool IsSetTileOrder() => this.TileOrder != null;

        /// <summary>
        /// Gets and sets the property TilePosition. 
        /// <para>
        /// Sets the position of vertical tiles.
        /// </para>
        /// </summary>
        public VerticalTilePosition TilePosition { get; set; }

        /// <summary>
        /// Checks to see if the TilePosition property is set.
        /// </summary>
        internal bool IsSetTilePosition() => this.TilePosition != null;
    }
}
