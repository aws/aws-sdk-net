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
    /// The border options for a table border.
    /// </summary>
    public partial class TableBorderOptions
    {
        private string _color;
        private TableBorderStyle _style;
        private int? _thickness;

        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// The color of a table border.
        /// </para>
        /// </summary>
        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        // Check to see if Color property is set
        internal bool IsSetColor()
        {
            return this._color != null;
        }

        /// <summary>
        /// Gets and sets the property Style. 
        /// <para>
        /// The style (none, solid) of a table border.
        /// </para>
        /// </summary>
        public TableBorderStyle Style
        {
            get { return this._style; }
            set { this._style = value; }
        }

        // Check to see if Style property is set
        internal bool IsSetStyle()
        {
            return this._style != null;
        }

        /// <summary>
        /// Gets and sets the property Thickness. 
        /// <para>
        /// The thickness of a table border.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public int Thickness
        {
            get { return this._thickness.GetValueOrDefault(); }
            set { this._thickness = value; }
        }

        // Check to see if Thickness property is set
        internal bool IsSetThickness()
        {
            return this._thickness.HasValue; 
        }

    }
}