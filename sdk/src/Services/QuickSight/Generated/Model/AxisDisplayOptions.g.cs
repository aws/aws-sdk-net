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
    /// The display options for the axis label.
    /// </summary>
    public partial class AxisDisplayOptions
    {
        /// <summary>
        /// Gets and sets the property AxisLineVisibility. 
        /// <para>
        /// Determines whether or not the axis line is visible.
        /// </para>
        /// </summary>
        public Visibility AxisLineVisibility { get; set; }

        /// <summary>
        /// Checks to see if the AxisLineVisibility property is set.
        /// </summary>
        internal bool IsSetAxisLineVisibility() => this.AxisLineVisibility != null;

        /// <summary>
        /// Gets and sets the property AxisOffset. 
        /// <para>
        /// The offset value that determines the starting placement of the axis within a visual's
        /// bounds.
        /// </para>
        /// </summary>
        public string AxisOffset { get; set; }

        /// <summary>
        /// Checks to see if the AxisOffset property is set.
        /// </summary>
        internal bool IsSetAxisOffset() => this.AxisOffset != null;

        /// <summary>
        /// Gets and sets the property DataOptions. 
        /// <para>
        /// The data options for an axis.
        /// </para>
        /// </summary>
        public AxisDataOptions DataOptions { get; set; }

        /// <summary>
        /// Checks to see if the DataOptions property is set.
        /// </summary>
        internal bool IsSetDataOptions() => this.DataOptions != null;

        /// <summary>
        /// Gets and sets the property GridLineVisibility. 
        /// <para>
        /// Determines whether or not the grid line is visible.
        /// </para>
        /// </summary>
        public Visibility GridLineVisibility { get; set; }

        /// <summary>
        /// Checks to see if the GridLineVisibility property is set.
        /// </summary>
        internal bool IsSetGridLineVisibility() => this.GridLineVisibility != null;

        /// <summary>
        /// Gets and sets the property ScrollbarOptions. 
        /// <para>
        /// The scroll bar options for an axis.
        /// </para>
        /// </summary>
        public ScrollBarOptions ScrollbarOptions { get; set; }

        /// <summary>
        /// Checks to see if the ScrollbarOptions property is set.
        /// </summary>
        internal bool IsSetScrollbarOptions() => this.ScrollbarOptions != null;

        /// <summary>
        /// Gets and sets the property TickLabelOptions. 
        /// <para>
        /// The tick label options of an axis.
        /// </para>
        /// </summary>
        public AxisTickLabelOptions TickLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the TickLabelOptions property is set.
        /// </summary>
        internal bool IsSetTickLabelOptions() => this.TickLabelOptions != null;
    }
}
