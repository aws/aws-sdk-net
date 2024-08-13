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
    /// Defines the configuration settings for a vertical layout.
    /// </summary>
    public partial class VerticalLayoutConfiguration
    {
        private string _tileAspectRatio;
        private int? _tileCount;
        private TileOrder _tileOrder;
        private VerticalTilePosition _tilePosition;

        /// <summary>
        /// Gets and sets the property TileAspectRatio. 
        /// <para>
        /// Sets the aspect ratio of the video tiles, such as 16:9.
        /// </para>
        /// </summary>
        public string TileAspectRatio
        {
            get { return this._tileAspectRatio; }
            set { this._tileAspectRatio = value; }
        }

        // Check to see if TileAspectRatio property is set
        internal bool IsSetTileAspectRatio()
        {
            return this._tileAspectRatio != null;
        }

        /// <summary>
        /// Gets and sets the property TileCount. 
        /// <para>
        /// The maximum number of tiles to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int? TileCount
        {
            get { return this._tileCount; }
            set { this._tileCount = value; }
        }

        // Check to see if TileCount property is set
        internal bool IsSetTileCount()
        {
            return this._tileCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TileOrder. 
        /// <para>
        /// Sets the automatic ordering of the video tiles.
        /// </para>
        /// </summary>
        public TileOrder TileOrder
        {
            get { return this._tileOrder; }
            set { this._tileOrder = value; }
        }

        // Check to see if TileOrder property is set
        internal bool IsSetTileOrder()
        {
            return this._tileOrder != null;
        }

        /// <summary>
        /// Gets and sets the property TilePosition. 
        /// <para>
        /// Sets the position of vertical tiles.
        /// </para>
        /// </summary>
        public VerticalTilePosition TilePosition
        {
            get { return this._tilePosition; }
            set { this._tilePosition = value; }
        }

        // Check to see if TilePosition property is set
        internal bool IsSetTilePosition()
        {
            return this._tilePosition != null;
        }

    }
}