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
    /// Dashboard publish options.
    /// </summary>
    public partial class DashboardPublishOptions
    {
        /// <summary>
        /// Gets and sets the property AdHocFilteringOption. 
        /// <para>
        /// Ad hoc (one-time) filtering option.
        /// </para>
        /// </summary>
        public AdHocFilteringOption AdHocFilteringOption { get; set; }

        /// <summary>
        /// Checks to see if the AdHocFilteringOption property is set.
        /// </summary>
        internal bool IsSetAdHocFilteringOption() => this.AdHocFilteringOption != null;

        /// <summary>
        /// Gets and sets the property DataPointDrillUpDownOption. 
        /// <para>
        /// The drill-down options of data points in a dashboard.
        /// </para>
        /// </summary>
        public DataPointDrillUpDownOption DataPointDrillUpDownOption { get; set; }

        /// <summary>
        /// Checks to see if the DataPointDrillUpDownOption property is set.
        /// </summary>
        internal bool IsSetDataPointDrillUpDownOption() => this.DataPointDrillUpDownOption != null;

        /// <summary>
        /// Gets and sets the property DataPointMenuLabelOption. 
        /// <para>
        /// The data point menu label options of a dashboard.
        /// </para>
        /// </summary>
        public DataPointMenuLabelOption DataPointMenuLabelOption { get; set; }

        /// <summary>
        /// Checks to see if the DataPointMenuLabelOption property is set.
        /// </summary>
        internal bool IsSetDataPointMenuLabelOption() => this.DataPointMenuLabelOption != null;

        /// <summary>
        /// Gets and sets the property DataPointTooltipOption. 
        /// <para>
        /// The data point tool tip options of a dashboard.
        /// </para>
        /// </summary>
        public DataPointTooltipOption DataPointTooltipOption { get; set; }

        /// <summary>
        /// Checks to see if the DataPointTooltipOption property is set.
        /// </summary>
        internal bool IsSetDataPointTooltipOption() => this.DataPointTooltipOption != null;

        /// <summary>
        /// Gets and sets the property DataQAEnabledOption. 
        /// <para>
        /// Adds Q&amp;A capabilities to an Quick Sight dashboard. If no topic is linked, Dashboard
        /// Q&amp;A uses the data values that are rendered on the dashboard. End users can use
        /// Dashboard Q&amp;A to ask for different slices of the data that they see on the dashboard.
        /// If a topic is linked, Topic Q&amp;A is used.
        /// </para>
        /// </summary>
        public DataQAEnabledOption DataQAEnabledOption { get; set; }

        /// <summary>
        /// Checks to see if the DataQAEnabledOption property is set.
        /// </summary>
        internal bool IsSetDataQAEnabledOption() => this.DataQAEnabledOption != null;

        /// <summary>
        /// Gets and sets the property DataStoriesSharingOption. 
        /// <para>
        /// Data stories sharing option.
        /// </para>
        /// </summary>
        public DataStoriesSharingOption DataStoriesSharingOption { get; set; }

        /// <summary>
        /// Checks to see if the DataStoriesSharingOption property is set.
        /// </summary>
        internal bool IsSetDataStoriesSharingOption() => this.DataStoriesSharingOption != null;

        /// <summary>
        /// Gets and sets the property ExecutiveSummaryOption. 
        /// <para>
        /// Executive summary option.
        /// </para>
        /// </summary>
        public ExecutiveSummaryOption ExecutiveSummaryOption { get; set; }

        /// <summary>
        /// Checks to see if the ExecutiveSummaryOption property is set.
        /// </summary>
        internal bool IsSetExecutiveSummaryOption() => this.ExecutiveSummaryOption != null;

        /// <summary>
        /// Gets and sets the property ExportToCSVOption. 
        /// <para>
        /// Export to .csv option.
        /// </para>
        /// </summary>
        public ExportToCSVOption ExportToCSVOption { get; set; }

        /// <summary>
        /// Checks to see if the ExportToCSVOption property is set.
        /// </summary>
        internal bool IsSetExportToCSVOption() => this.ExportToCSVOption != null;

        /// <summary>
        /// Gets and sets the property ExportWithHiddenFieldsOption. 
        /// <para>
        /// Determines if hidden fields are exported with a dashboard.
        /// </para>
        /// </summary>
        public ExportWithHiddenFieldsOption ExportWithHiddenFieldsOption { get; set; }

        /// <summary>
        /// Checks to see if the ExportWithHiddenFieldsOption property is set.
        /// </summary>
        internal bool IsSetExportWithHiddenFieldsOption() => this.ExportWithHiddenFieldsOption != null;

        /// <summary>
        /// Gets and sets the property QuickSuiteActionsOption. 
        /// <para>
        /// Determines if Actions in Amazon Quick Suite are enabled in a dashboard.
        /// </para>
        /// </summary>
        public QuickSuiteActionsOption QuickSuiteActionsOption { get; set; }

        /// <summary>
        /// Checks to see if the QuickSuiteActionsOption property is set.
        /// </summary>
        internal bool IsSetQuickSuiteActionsOption() => this.QuickSuiteActionsOption != null;

        /// <summary>
        /// Gets and sets the property SheetControlsOption. 
        /// <para>
        /// Sheet controls option.
        /// </para>
        /// </summary>
        public SheetControlsOption SheetControlsOption { get; set; }

        /// <summary>
        /// Checks to see if the SheetControlsOption property is set.
        /// </summary>
        internal bool IsSetSheetControlsOption() => this.SheetControlsOption != null;

        /// <summary>
        /// Gets and sets the property SheetLayoutElementMaximizationOption. 
        /// <para>
        /// The sheet layout maximization options of a dashbaord.
        /// </para>
        /// </summary>
        public SheetLayoutElementMaximizationOption SheetLayoutElementMaximizationOption { get; set; }

        /// <summary>
        /// Checks to see if the SheetLayoutElementMaximizationOption property is set.
        /// </summary>
        internal bool IsSetSheetLayoutElementMaximizationOption() => this.SheetLayoutElementMaximizationOption != null;

        /// <summary>
        /// Gets and sets the property VisualAxisSortOption. 
        /// <para>
        /// The axis sort options of a dashboard.
        /// </para>
        /// </summary>
        public VisualAxisSortOption VisualAxisSortOption { get; set; }

        /// <summary>
        /// Checks to see if the VisualAxisSortOption property is set.
        /// </summary>
        internal bool IsSetVisualAxisSortOption() => this.VisualAxisSortOption != null;

        /// <summary>
        /// Gets and sets the property VisualMenuOption. 
        /// <para>
        /// The menu options of a visual in a dashboard.
        /// </para>
        /// </summary>
        public VisualMenuOption VisualMenuOption { get; set; }

        /// <summary>
        /// Checks to see if the VisualMenuOption property is set.
        /// </summary>
        internal bool IsSetVisualMenuOption() => this.VisualMenuOption != null;

        /// <summary>
        /// Gets and sets the property VisualPublishOptions. 
        /// <para>
        /// The visual publish options of a visual in a dashboard.
        /// </para>
        /// </summary>
        [Obsolete("VisualPublishOptions property will reach its end of standard support in a future release. To perform this action, use ExportWithHiddenFields.")]
        public DashboardVisualPublishOptions VisualPublishOptions { get; set; }

        /// <summary>
        /// Checks to see if the VisualPublishOptions property is set.
        /// </summary>
        internal bool IsSetVisualPublishOptions() => this.VisualPublishOptions != null;
    }
}
