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
    /// The configuration for a <c>PivotTableVisual</c>.
    /// </summary>
    public partial class PivotTableConfiguration
    {
        /// <summary>
        /// Gets and sets the property DashboardCustomizationVisualOptions. 
        /// <para>
        /// The options that define customizations available to dashboard readers for a specific
        /// visual
        /// </para>
        /// </summary>
        public DashboardCustomizationVisualOptions DashboardCustomizationVisualOptions { get; set; }

        /// <summary>
        /// Checks to see if the DashboardCustomizationVisualOptions property is set.
        /// </summary>
        internal bool IsSetDashboardCustomizationVisualOptions() => this.DashboardCustomizationVisualOptions != null;

        /// <summary>
        /// Gets and sets the property FieldOptions. 
        /// <para>
        /// The field options for a pivot table visual.
        /// </para>
        /// </summary>
        public PivotTableFieldOptions FieldOptions { get; set; }

        /// <summary>
        /// Checks to see if the FieldOptions property is set.
        /// </summary>
        internal bool IsSetFieldOptions() => this.FieldOptions != null;

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field wells of the visual.
        /// </para>
        /// </summary>
        public PivotTableFieldWells FieldWells { get; set; }

        /// <summary>
        /// Checks to see if the FieldWells property is set.
        /// </summary>
        internal bool IsSetFieldWells() => this.FieldWells != null;

        /// <summary>
        /// Gets and sets the property Interactions. 
        /// <para>
        /// The general visual interactions setup for a visual.
        /// </para>
        /// </summary>
        public VisualInteractionOptions Interactions { get; set; }

        /// <summary>
        /// Checks to see if the Interactions property is set.
        /// </summary>
        internal bool IsSetInteractions() => this.Interactions != null;

        /// <summary>
        /// Gets and sets the property PaginatedReportOptions. 
        /// <para>
        /// The paginated report options for a pivot table visual.
        /// </para>
        /// </summary>
        public PivotTablePaginatedReportOptions PaginatedReportOptions { get; set; }

        /// <summary>
        /// Checks to see if the PaginatedReportOptions property is set.
        /// </summary>
        internal bool IsSetPaginatedReportOptions() => this.PaginatedReportOptions != null;

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration for a <c>PivotTableVisual</c>.
        /// </para>
        /// </summary>
        public PivotTableSortConfiguration SortConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SortConfiguration property is set.
        /// </summary>
        internal bool IsSetSortConfiguration() => this.SortConfiguration != null;

        /// <summary>
        /// Gets and sets the property TableOptions. 
        /// <para>
        /// The table options for a pivot table visual.
        /// </para>
        /// </summary>
        public PivotTableOptions TableOptions { get; set; }

        /// <summary>
        /// Checks to see if the TableOptions property is set.
        /// </summary>
        internal bool IsSetTableOptions() => this.TableOptions != null;

        /// <summary>
        /// Gets and sets the property Tooltip.
        /// </summary>
        public TooltipOptions Tooltip { get; set; }

        /// <summary>
        /// Checks to see if the Tooltip property is set.
        /// </summary>
        internal bool IsSetTooltip() => this.Tooltip != null;

        /// <summary>
        /// Gets and sets the property TotalOptions. 
        /// <para>
        /// The total options for a pivot table visual.
        /// </para>
        /// </summary>
        public PivotTableTotalOptions TotalOptions { get; set; }

        /// <summary>
        /// Checks to see if the TotalOptions property is set.
        /// </summary>
        internal bool IsSetTotalOptions() => this.TotalOptions != null;
    }
}
