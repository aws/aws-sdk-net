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
    /// Tile and thumbnail settings applicable when imageBasedTrickPlay is ADVANCED
    /// </summary>
    public partial class CmafImageBasedTrickPlaySettings
    {
        /// <summary>
        /// Gets and sets the property IntervalCadence. The cadence MediaConvert follows for generating
        /// thumbnails. If set to FOLLOW_IFRAME, MediaConvert generates thumbnails for each IDR
        /// frame in the output (matching the GOP cadence). If set to FOLLOW_CUSTOM, MediaConvert
        /// generates thumbnails according to the interval you specify in thumbnailInterval. If
        /// set to FOLLOW_SEGMENTATION, MediaConvert generates thumbnail playlist entries that
        /// align exactly with video segment boundaries. FOLLOW_SEGMENTATION requires 1x1 tiling.
        /// </summary>
        public CmafIntervalCadence IntervalCadence { get; set; }

        /// <summary>
        /// Checks to see if the IntervalCadence property is set.
        /// </summary>
        internal bool IsSetIntervalCadence() => this.IntervalCadence != null;

        /// <summary>
        /// Gets and sets the property ThumbnailHeight. Height of each thumbnail within each tile
        /// image, in pixels. Leave blank to maintain aspect ratio with thumbnail width. If following
        /// the aspect ratio would lead to a total tile height greater than 4096, then the job
        /// will be rejected. Must be divisible by 2.
        /// </summary>
        [AWSProperty(Min = 2, Max = 4096)]
        public int? ThumbnailHeight { get; set; }

        /// <summary>
        /// Checks to see if the ThumbnailHeight property is set.
        /// </summary>
        internal bool IsSetThumbnailHeight() => this.ThumbnailHeight.HasValue;

        /// <summary>
        /// Gets and sets the property ThumbnailInterval. Enter the interval, in seconds, that
        /// MediaConvert uses to generate thumbnails. If the interval you enter doesn't align
        /// with the output frame rate, MediaConvert automatically rounds the interval to align
        /// with the output frame rate. For example, if the output frame rate is 29.97 frames
        /// per second and you enter 5, MediaConvert uses a 150 frame interval to generate thumbnails.
        /// </summary>
        public double? ThumbnailInterval { get; set; }

        /// <summary>
        /// Checks to see if the ThumbnailInterval property is set.
        /// </summary>
        internal bool IsSetThumbnailInterval() => this.ThumbnailInterval.HasValue;

        /// <summary>
        /// Gets and sets the property ThumbnailWidth. Width of each thumbnail within each tile
        /// image, in pixels. Default is 312. Must be divisible by 8.
        /// </summary>
        [AWSProperty(Min = 8, Max = 4096)]
        public int? ThumbnailWidth { get; set; }

        /// <summary>
        /// Checks to see if the ThumbnailWidth property is set.
        /// </summary>
        internal bool IsSetThumbnailWidth() => this.ThumbnailWidth.HasValue;

        /// <summary>
        /// Gets and sets the property TileHeight. Number of thumbnails in each column of a tile
        /// image. Set a value between 1 and 2048.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public int? TileHeight { get; set; }

        /// <summary>
        /// Checks to see if the TileHeight property is set.
        /// </summary>
        internal bool IsSetTileHeight() => this.TileHeight.HasValue;

        /// <summary>
        /// Gets and sets the property TileWidth. Number of thumbnails in each row of a tile image.
        /// Set a value between 1 and 512.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public int? TileWidth { get; set; }

        /// <summary>
        /// Checks to see if the TileWidth property is set.
        /// </summary>
        internal bool IsSetTileWidth() => this.TileWidth.HasValue;
    }
}
