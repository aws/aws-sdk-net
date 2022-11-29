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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The options for the legend setup of a visual.
    /// </summary>
    public partial class LegendOptions
    {
        private string _height;
        private LegendPosition _position;
        private LabelOptions _title;
        private Visibility _visibility;
        private string _width;

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// The height of the legend. If this value is omitted, a default height is used when
        /// rendering.
        /// </para>
        /// </summary>
        public string Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The positions for the legend. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AUTO</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RIGHT</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BOTTOM</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LEFT</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LegendPosition Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The custom title for the legend.
        /// </para>
        /// </summary>
        public LabelOptions Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// Determines whether or not the legend is visible.
        /// </para>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The width of the legend. If this value is omitted, a default width is used when rendering.
        /// </para>
        /// </summary>
        public string Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width != null;
        }

    }
}