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
    /// Display options related to tiles on a sheet.
    /// </summary>
    public partial class TileStyle
    {
        private string _backgroundColor;
        private BorderStyle _border;
        private string _borderRadius;
        private string _padding;

        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// The background color of a tile.
        /// </para>
        /// </summary>
        public string BackgroundColor
        {
            get { return this._backgroundColor; }
            set { this._backgroundColor = value; }
        }

        // Check to see if BackgroundColor property is set
        internal bool IsSetBackgroundColor()
        {
            return this._backgroundColor != null;
        }

        /// <summary>
        /// Gets and sets the property Border. 
        /// <para>
        /// The border around a tile.
        /// </para>
        /// </summary>
        public BorderStyle Border
        {
            get { return this._border; }
            set { this._border = value; }
        }

        // Check to see if Border property is set
        internal bool IsSetBorder()
        {
            return this._border != null;
        }

        /// <summary>
        /// Gets and sets the property BorderRadius. 
        /// <para>
        /// The border radius of a tile.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string BorderRadius
        {
            get { return this._borderRadius; }
            set { this._borderRadius = value; }
        }

        // Check to see if BorderRadius property is set
        internal bool IsSetBorderRadius()
        {
            return this._borderRadius != null;
        }

        /// <summary>
        /// Gets and sets the property Padding. 
        /// <para>
        /// The padding of a tile.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public string Padding
        {
            get { return this._padding; }
            set { this._padding = value; }
        }

        // Check to see if Padding property is set
        internal bool IsSetPadding()
        {
            return this._padding != null;
        }

    }
}