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
    /// The display options for the layout of tiles on a sheet.
    /// </summary>
    public partial class TileLayoutStyle
    {
        private GutterStyle _gutter;
        private MarginStyle _margin;

        /// <summary>
        /// Gets and sets the property Gutter. 
        /// <para>
        /// The gutter settings that apply between tiles. 
        /// </para>
        /// </summary>
        public GutterStyle Gutter
        {
            get { return this._gutter; }
            set { this._gutter = value; }
        }

        // Check to see if Gutter property is set
        internal bool IsSetGutter()
        {
            return this._gutter != null;
        }

        /// <summary>
        /// Gets and sets the property Margin. 
        /// <para>
        /// The margin settings that apply around the outside edge of sheets.
        /// </para>
        /// </summary>
        public MarginStyle Margin
        {
            get { return this._margin; }
            set { this._margin = value; }
        }

        // Check to see if Margin property is set
        internal bool IsSetMargin()
        {
            return this._margin != null;
        }

    }
}