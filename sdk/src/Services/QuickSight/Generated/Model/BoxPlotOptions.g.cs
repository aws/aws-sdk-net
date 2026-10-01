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
    /// The options of a box plot visual.
    /// </summary>
    public partial class BoxPlotOptions
    {
        /// <summary>
        /// Gets and sets the property AllDataPointsVisibility. 
        /// <para>
        /// Determines the visibility of all data points of the box plot.
        /// </para>
        /// </summary>
        public Visibility AllDataPointsVisibility { get; set; }

        /// <summary>
        /// Checks to see if the AllDataPointsVisibility property is set.
        /// </summary>
        internal bool IsSetAllDataPointsVisibility() => this.AllDataPointsVisibility != null;

        /// <summary>
        /// Gets and sets the property OutlierVisibility. 
        /// <para>
        /// Determines the visibility of the outlier in a box plot.
        /// </para>
        /// </summary>
        public Visibility OutlierVisibility { get; set; }

        /// <summary>
        /// Checks to see if the OutlierVisibility property is set.
        /// </summary>
        internal bool IsSetOutlierVisibility() => this.OutlierVisibility != null;

        /// <summary>
        /// Gets and sets the property StyleOptions. 
        /// <para>
        /// The style options of the box plot.
        /// </para>
        /// </summary>
        public BoxPlotStyleOptions StyleOptions { get; set; }

        /// <summary>
        /// Checks to see if the StyleOptions property is set.
        /// </summary>
        internal bool IsSetStyleOptions() => this.StyleOptions != null;
    }
}
