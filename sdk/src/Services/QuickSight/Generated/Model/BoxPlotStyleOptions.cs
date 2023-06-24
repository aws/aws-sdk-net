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
    /// The style options of the box plot.
    /// </summary>
    public partial class BoxPlotStyleOptions
    {
        private BoxPlotFillStyle _fillStyle;

        /// <summary>
        /// Gets and sets the property FillStyle. 
        /// <para>
        /// The fill styles (solid, transparent) of the box plot.
        /// </para>
        /// </summary>
        public BoxPlotFillStyle FillStyle
        {
            get { return this._fillStyle; }
            set { this._fillStyle = value; }
        }

        // Check to see if FillStyle property is set
        internal bool IsSetFillStyle()
        {
            return this._fillStyle != null;
        }

    }
}