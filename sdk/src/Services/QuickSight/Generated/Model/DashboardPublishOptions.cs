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
    /// Dashboard publish options.
    /// </summary>
    public partial class DashboardPublishOptions
    {
        private AdHocFilteringOption _adHocFilteringOption;
        private DataPointDrillUpDownOption _dataPointDrillUpDownOption;
        private DataPointMenuLabelOption _dataPointMenuLabelOption;
        private DataPointTooltipOption _dataPointTooltipOption;
        private ExportToCSVOption _exportToCSVOption;
        private ExportWithHiddenFieldsOption _exportWithHiddenFieldsOption;
        private SheetControlsOption _sheetControlsOption;
        private SheetLayoutElementMaximizationOption _sheetLayoutElementMaximizationOption;
        private VisualAxisSortOption _visualAxisSortOption;
        private VisualMenuOption _visualMenuOption;
        private DashboardVisualPublishOptions _visualPublishOptions;

        /// <summary>
        /// Gets and sets the property AdHocFilteringOption. 
        /// <para>
        /// Ad hoc (one-time) filtering option.
        /// </para>
        /// </summary>
        public AdHocFilteringOption AdHocFilteringOption
        {
            get { return this._adHocFilteringOption; }
            set { this._adHocFilteringOption = value; }
        }

        // Check to see if AdHocFilteringOption property is set
        internal bool IsSetAdHocFilteringOption()
        {
            return this._adHocFilteringOption != null;
        }

        /// <summary>
        /// Gets and sets the property DataPointDrillUpDownOption. 
        /// <para>
        /// The drill-down options of data points in a dashboard.
        /// </para>
        /// </summary>
        public DataPointDrillUpDownOption DataPointDrillUpDownOption
        {
            get { return this._dataPointDrillUpDownOption; }
            set { this._dataPointDrillUpDownOption = value; }
        }

        // Check to see if DataPointDrillUpDownOption property is set
        internal bool IsSetDataPointDrillUpDownOption()
        {
            return this._dataPointDrillUpDownOption != null;
        }

        /// <summary>
        /// Gets and sets the property DataPointMenuLabelOption. 
        /// <para>
        /// The data point menu label options of a dashboard.
        /// </para>
        /// </summary>
        public DataPointMenuLabelOption DataPointMenuLabelOption
        {
            get { return this._dataPointMenuLabelOption; }
            set { this._dataPointMenuLabelOption = value; }
        }

        // Check to see if DataPointMenuLabelOption property is set
        internal bool IsSetDataPointMenuLabelOption()
        {
            return this._dataPointMenuLabelOption != null;
        }

        /// <summary>
        /// Gets and sets the property DataPointTooltipOption. 
        /// <para>
        /// The data point tool tip options of a dashboard.
        /// </para>
        /// </summary>
        public DataPointTooltipOption DataPointTooltipOption
        {
            get { return this._dataPointTooltipOption; }
            set { this._dataPointTooltipOption = value; }
        }

        // Check to see if DataPointTooltipOption property is set
        internal bool IsSetDataPointTooltipOption()
        {
            return this._dataPointTooltipOption != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToCSVOption. 
        /// <para>
        /// Export to .csv option.
        /// </para>
        /// </summary>
        public ExportToCSVOption ExportToCSVOption
        {
            get { return this._exportToCSVOption; }
            set { this._exportToCSVOption = value; }
        }

        // Check to see if ExportToCSVOption property is set
        internal bool IsSetExportToCSVOption()
        {
            return this._exportToCSVOption != null;
        }

        /// <summary>
        /// Gets and sets the property ExportWithHiddenFieldsOption. 
        /// <para>
        /// Determines if hidden fields are exported with a dashboard.
        /// </para>
        /// </summary>
        public ExportWithHiddenFieldsOption ExportWithHiddenFieldsOption
        {
            get { return this._exportWithHiddenFieldsOption; }
            set { this._exportWithHiddenFieldsOption = value; }
        }

        // Check to see if ExportWithHiddenFieldsOption property is set
        internal bool IsSetExportWithHiddenFieldsOption()
        {
            return this._exportWithHiddenFieldsOption != null;
        }

        /// <summary>
        /// Gets and sets the property SheetControlsOption. 
        /// <para>
        /// Sheet controls option.
        /// </para>
        /// </summary>
        public SheetControlsOption SheetControlsOption
        {
            get { return this._sheetControlsOption; }
            set { this._sheetControlsOption = value; }
        }

        // Check to see if SheetControlsOption property is set
        internal bool IsSetSheetControlsOption()
        {
            return this._sheetControlsOption != null;
        }

        /// <summary>
        /// Gets and sets the property SheetLayoutElementMaximizationOption. 
        /// <para>
        /// The sheet layout maximization options of a dashbaord.
        /// </para>
        /// </summary>
        public SheetLayoutElementMaximizationOption SheetLayoutElementMaximizationOption
        {
            get { return this._sheetLayoutElementMaximizationOption; }
            set { this._sheetLayoutElementMaximizationOption = value; }
        }

        // Check to see if SheetLayoutElementMaximizationOption property is set
        internal bool IsSetSheetLayoutElementMaximizationOption()
        {
            return this._sheetLayoutElementMaximizationOption != null;
        }

        /// <summary>
        /// Gets and sets the property VisualAxisSortOption. 
        /// <para>
        /// The axis sort options of a dashboard.
        /// </para>
        /// </summary>
        public VisualAxisSortOption VisualAxisSortOption
        {
            get { return this._visualAxisSortOption; }
            set { this._visualAxisSortOption = value; }
        }

        // Check to see if VisualAxisSortOption property is set
        internal bool IsSetVisualAxisSortOption()
        {
            return this._visualAxisSortOption != null;
        }

        /// <summary>
        /// Gets and sets the property VisualMenuOption. 
        /// <para>
        /// The menu options of a visual in a dashboard.
        /// </para>
        /// </summary>
        public VisualMenuOption VisualMenuOption
        {
            get { return this._visualMenuOption; }
            set { this._visualMenuOption = value; }
        }

        // Check to see if VisualMenuOption property is set
        internal bool IsSetVisualMenuOption()
        {
            return this._visualMenuOption != null;
        }

        /// <summary>
        /// Gets and sets the property VisualPublishOptions. 
        /// <para>
        /// The visual publish options of a visual in a dashboard.
        /// </para>
        /// </summary>
        [Obsolete("VisualPublishOptions property will reach its end of standard support in a future release. To perform this action, use ExportWithHiddenFields.")]
        public DashboardVisualPublishOptions VisualPublishOptions
        {
            get { return this._visualPublishOptions; }
            set { this._visualPublishOptions = value; }
        }

        // Check to see if VisualPublishOptions property is set
        internal bool IsSetVisualPublishOptions()
        {
            return this._visualPublishOptions != null;
        }

    }
}