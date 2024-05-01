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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The theme display options for sheets.
    /// </summary>
    public partial class SheetStyle
    {
        private TileStyle _tile;
        private TileLayoutStyle _tileLayout;

        /// <summary>
        /// Gets and sets the property Tile. 
        /// <para>
        /// The display options for tiles.
        /// </para>
        /// </summary>
        public TileStyle Tile
        {
            get { return this._tile; }
            set { this._tile = value; }
        }

        // Check to see if Tile property is set
        internal bool IsSetTile()
        {
            return this._tile != null;
        }

        /// <summary>
        /// Gets and sets the property TileLayout. 
        /// <para>
        /// The layout options for tiles.
        /// </para>
        /// </summary>
        public TileLayoutStyle TileLayout
        {
            get { return this._tileLayout; }
            set { this._tileLayout = value; }
        }

        // Check to see if TileLayout property is set
        internal bool IsSetTileLayout()
        {
            return this._tileLayout != null;
        }

    }
}