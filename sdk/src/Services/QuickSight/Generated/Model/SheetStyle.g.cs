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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The theme display options for sheets.
    /// </summary>
    public partial class SheetStyle
    {
        /// <summary>
        /// Gets and sets the property Background. 
        /// <para>
        /// The background for sheets.
        /// </para>
        /// </summary>
        public SheetBackgroundStyle Background { get; set; }

        /// <summary>
        /// Checks to see if the Background property is set.
        /// </summary>
        internal bool IsSetBackground() => this.Background != null;

        /// <summary>
        /// Gets and sets the property Tile. 
        /// <para>
        /// The display options for tiles.
        /// </para>
        /// </summary>
        public TileStyle Tile { get; set; }

        /// <summary>
        /// Checks to see if the Tile property is set.
        /// </summary>
        internal bool IsSetTile() => this.Tile != null;

        /// <summary>
        /// Gets and sets the property TileLayout. 
        /// <para>
        /// The layout options for tiles.
        /// </para>
        /// </summary>
        public TileLayoutStyle TileLayout { get; set; }

        /// <summary>
        /// Checks to see if the TileLayout property is set.
        /// </summary>
        internal bool IsSetTileLayout() => this.TileLayout != null;
    }
}
