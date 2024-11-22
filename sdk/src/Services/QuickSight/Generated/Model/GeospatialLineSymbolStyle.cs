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
    /// The symbol style for a line layer.
    /// </summary>
    public partial class GeospatialLineSymbolStyle
    {
        private GeospatialColor _fillColor;
        private GeospatialLineWidth _lineWidth;

        /// <summary>
        /// Gets and sets the property FillColor. 
        /// <para>
        /// The color and opacity values for the fill color.
        /// </para>
        /// </summary>
        public GeospatialColor FillColor
        {
            get { return this._fillColor; }
            set { this._fillColor = value; }
        }

        // Check to see if FillColor property is set
        internal bool IsSetFillColor()
        {
            return this._fillColor != null;
        }

        /// <summary>
        /// Gets and sets the property LineWidth. 
        /// <para>
        /// The width value for a line.
        /// </para>
        /// </summary>
        public GeospatialLineWidth LineWidth
        {
            get { return this._lineWidth; }
            set { this._lineWidth = value; }
        }

        // Check to see if LineWidth property is set
        internal bool IsSetLineWidth()
        {
            return this._lineWidth != null;
        }

    }
}