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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Tile and thumbnail settings applicable when imageBasedTrickPlay is ADVANCED
    /// </summary>
    public partial class DashIsoImageBasedTrickPlaySettings
    {
        private DashIsoIntervalCadence _intervalCadence;
        private int? _thumbnailHeight;
        private double? _thumbnailInterval;
        private int? _thumbnailWidth;
        private int? _tileHeight;
        private int? _tileWidth;

        /// <summary>
        /// Gets and sets the property IntervalCadence. The cadence MediaConvert follows for generating
        /// thumbnails. If set to FOLLOW_IFRAME, MediaConvert generates thumbnails for each IDR
        /// frame in the output (matching the GOP cadence). If set to FOLLOW_CUSTOM, MediaConvert
        /// generates thumbnails according to the interval you specify in thumbnailInterval.
        /// </summary>
        public DashIsoIntervalCadence IntervalCadence
        {
            get { return this._intervalCadence; }
            set { this._intervalCadence = value; }
        }

        // Check to see if IntervalCadence property is set
        internal bool IsSetIntervalCadence()
        {
            return this._intervalCadence != null;
        }

        /// <summary>
        /// Gets and sets the property ThumbnailHeight. Height of each thumbnail within each tile
        /// image, in pixels. Leave blank to maintain aspect ratio with thumbnail width. If following
        /// the aspect ratio would lead to a total tile height greater than 4096, then the job
        /// will be rejected. Must be divisible by 2.
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public int ThumbnailHeight
        {
            get { return this._thumbnailHeight.GetValueOrDefault(); }
            set { this._thumbnailHeight = value; }
        }

        // Check to see if ThumbnailHeight property is set
        internal bool IsSetThumbnailHeight()
        {
            return this._thumbnailHeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThumbnailInterval. Enter the interval, in seconds, that
        /// MediaConvert uses to generate thumbnails. If the interval you enter doesn't align
        /// with the output frame rate, MediaConvert automatically rounds the interval to align
        /// with the output frame rate. For example, if the output frame rate is 29.97 frames
        /// per second and you enter 5, MediaConvert uses a 150 frame interval to generate thumbnails.
        /// </summary>
        public double ThumbnailInterval
        {
            get { return this._thumbnailInterval.GetValueOrDefault(); }
            set { this._thumbnailInterval = value; }
        }

        // Check to see if ThumbnailInterval property is set
        internal bool IsSetThumbnailInterval()
        {
            return this._thumbnailInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThumbnailWidth. Width of each thumbnail within each tile
        /// image, in pixels. Default is 312. Must be divisible by 8.
        /// </summary>
        [AWSProperty(Min=8, Max=4096)]
        public int ThumbnailWidth
        {
            get { return this._thumbnailWidth.GetValueOrDefault(); }
            set { this._thumbnailWidth = value; }
        }

        // Check to see if ThumbnailWidth property is set
        internal bool IsSetThumbnailWidth()
        {
            return this._thumbnailWidth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TileHeight. Number of thumbnails in each column of a tile
        /// image. Set a value between 2 and 2048. Must be divisible by 2.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public int TileHeight
        {
            get { return this._tileHeight.GetValueOrDefault(); }
            set { this._tileHeight = value; }
        }

        // Check to see if TileHeight property is set
        internal bool IsSetTileHeight()
        {
            return this._tileHeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TileWidth. Number of thumbnails in each row of a tile image.
        /// Set a value between 1 and 512.
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public int TileWidth
        {
            get { return this._tileWidth.GetValueOrDefault(); }
            set { this._tileWidth = value; }
        }

        // Check to see if TileWidth property is set
        internal bool IsSetTileWidth()
        {
            return this._tileWidth.HasValue; 
        }

    }
}