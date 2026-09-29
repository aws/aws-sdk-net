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
    /// Options that determine the layout and display options of a chart's small multiples.
    /// </summary>
    public partial class SmallMultiplesOptions
    {
        /// <summary>
        /// Gets and sets the property MaxVisibleColumns. 
        /// <para>
        /// Sets the maximum number of visible columns to display in the grid of small multiples
        /// panels.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>Auto</c>, which automatically adjusts the columns in the grid to
        /// fit the overall layout and size of the given chart.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public long? MaxVisibleColumns { get; set; }

        /// <summary>
        /// Checks to see if the MaxVisibleColumns property is set.
        /// </summary>
        internal bool IsSetMaxVisibleColumns() => this.MaxVisibleColumns.HasValue;

        /// <summary>
        /// Gets and sets the property MaxVisibleRows. 
        /// <para>
        /// Sets the maximum number of visible rows to display in the grid of small multiples
        /// panels.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>Auto</c>, which automatically adjusts the rows in the grid
        /// to fit the overall layout and size of the given chart.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public long? MaxVisibleRows { get; set; }

        /// <summary>
        /// Checks to see if the MaxVisibleRows property is set.
        /// </summary>
        internal bool IsSetMaxVisibleRows() => this.MaxVisibleRows.HasValue;

        /// <summary>
        /// Gets and sets the property PanelConfiguration. 
        /// <para>
        /// Configures the display options for each small multiples panel.
        /// </para>
        /// </summary>
        public PanelConfiguration PanelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PanelConfiguration property is set.
        /// </summary>
        internal bool IsSetPanelConfiguration() => this.PanelConfiguration != null;

        /// <summary>
        /// Gets and sets the property XAxis. 
        /// <para>
        /// The properties of a small multiples X axis.
        /// </para>
        /// </summary>
        public SmallMultiplesAxisProperties XAxis { get; set; }

        /// <summary>
        /// Checks to see if the XAxis property is set.
        /// </summary>
        internal bool IsSetXAxis() => this.XAxis != null;

        /// <summary>
        /// Gets and sets the property YAxis. 
        /// <para>
        /// The properties of a small multiples Y axis.
        /// </para>
        /// </summary>
        public SmallMultiplesAxisProperties YAxis { get; set; }

        /// <summary>
        /// Checks to see if the YAxis property is set.
        /// </summary>
        internal bool IsSetYAxis() => this.YAxis != null;
    }
}
