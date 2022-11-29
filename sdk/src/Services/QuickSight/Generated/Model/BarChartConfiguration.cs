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
    /// The configuration of a <code>BarChartVisual</code>.
    /// </summary>
    public partial class BarChartConfiguration
    {
        private BarsArrangement _barsArrangement;
        private AxisDisplayOptions _categoryAxis;
        private ChartAxisLabelOptions _categoryLabelOptions;
        private ChartAxisLabelOptions _colorLabelOptions;
        private List<ContributionAnalysisDefault> _contributionAnalysisDefaults = new List<ContributionAnalysisDefault>();
        private DataLabelOptions _dataLabels;
        private BarChartFieldWells _fieldWells;
        private LegendOptions _legend;
        private BarChartOrientation _orientation;
        private List<ReferenceLine> _referenceLines = new List<ReferenceLine>();
        private SmallMultiplesOptions _smallMultiplesOptions;
        private BarChartSortConfiguration _sortConfiguration;
        private TooltipOptions _tooltip;
        private AxisDisplayOptions _valueAxis;
        private ChartAxisLabelOptions _valueLabelOptions;
        private VisualPalette _visualPalette;

        /// <summary>
        /// Gets and sets the property BarsArrangement. 
        /// <para>
        /// Determines the arrangement of the bars. The orientation and arrangement of bars determine
        /// the type of bar that is used in the visual.
        /// </para>
        /// </summary>
        public BarsArrangement BarsArrangement
        {
            get { return this._barsArrangement; }
            set { this._barsArrangement = value; }
        }

        // Check to see if BarsArrangement property is set
        internal bool IsSetBarsArrangement()
        {
            return this._barsArrangement != null;
        }

        /// <summary>
        /// Gets and sets the property CategoryAxis. 
        /// <para>
        /// The label display options (grid line, range, scale, axis step) for bar chart category.
        /// </para>
        /// </summary>
        public AxisDisplayOptions CategoryAxis
        {
            get { return this._categoryAxis; }
            set { this._categoryAxis = value; }
        }

        // Check to see if CategoryAxis property is set
        internal bool IsSetCategoryAxis()
        {
            return this._categoryAxis != null;
        }

        /// <summary>
        /// Gets and sets the property CategoryLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility and sort icon visibility) for a bar
        /// chart.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions CategoryLabelOptions
        {
            get { return this._categoryLabelOptions; }
            set { this._categoryLabelOptions = value; }
        }

        // Check to see if CategoryLabelOptions property is set
        internal bool IsSetCategoryLabelOptions()
        {
            return this._categoryLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ColorLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility and sort icon visibility) for a color
        /// that is used in a bar chart.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions ColorLabelOptions
        {
            get { return this._colorLabelOptions; }
            set { this._colorLabelOptions = value; }
        }

        // Check to see if ColorLabelOptions property is set
        internal bool IsSetColorLabelOptions()
        {
            return this._colorLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ContributionAnalysisDefaults. 
        /// <para>
        /// The contribution analysis (anomaly configuration) setup of the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<ContributionAnalysisDefault> ContributionAnalysisDefaults
        {
            get { return this._contributionAnalysisDefaults; }
            set { this._contributionAnalysisDefaults = value; }
        }

        // Check to see if ContributionAnalysisDefaults property is set
        internal bool IsSetContributionAnalysisDefaults()
        {
            return this._contributionAnalysisDefaults != null && this._contributionAnalysisDefaults.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataLabels. 
        /// <para>
        /// The options that determine if visual data labels are displayed.
        /// </para>
        /// </summary>
        public DataLabelOptions DataLabels
        {
            get { return this._dataLabels; }
            set { this._dataLabels = value; }
        }

        // Check to see if DataLabels property is set
        internal bool IsSetDataLabels()
        {
            return this._dataLabels != null;
        }

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field wells of the visual.
        /// </para>
        /// </summary>
        public BarChartFieldWells FieldWells
        {
            get { return this._fieldWells; }
            set { this._fieldWells = value; }
        }

        // Check to see if FieldWells property is set
        internal bool IsSetFieldWells()
        {
            return this._fieldWells != null;
        }

        /// <summary>
        /// Gets and sets the property Legend. 
        /// <para>
        /// The legend display setup of the visual.
        /// </para>
        /// </summary>
        public LegendOptions Legend
        {
            get { return this._legend; }
            set { this._legend = value; }
        }

        // Check to see if Legend property is set
        internal bool IsSetLegend()
        {
            return this._legend != null;
        }

        /// <summary>
        /// Gets and sets the property Orientation. 
        /// <para>
        /// The orientation of the bars in a bar chart visual. There are two valid values in this
        /// structure:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>HORIZONTAL</code>: Used for charts that have horizontal bars. Visuals that
        /// use this value are horizontal bar charts, horizontal stacked bar charts, and horizontal
        /// stacked 100% bar charts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VERTICAL</code>: Used for charts that have vertical bars. Visuals that use
        /// this value are vertical bar charts, vertical stacked bar charts, and vertical stacked
        /// 100% bar charts.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BarChartOrientation Orientation
        {
            get { return this._orientation; }
            set { this._orientation = value; }
        }

        // Check to see if Orientation property is set
        internal bool IsSetOrientation()
        {
            return this._orientation != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceLines. 
        /// <para>
        /// The reference line setup of the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public List<ReferenceLine> ReferenceLines
        {
            get { return this._referenceLines; }
            set { this._referenceLines = value; }
        }

        // Check to see if ReferenceLines property is set
        internal bool IsSetReferenceLines()
        {
            return this._referenceLines != null && this._referenceLines.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SmallMultiplesOptions. 
        /// <para>
        /// The small multiples setup for the visual.
        /// </para>
        /// </summary>
        public SmallMultiplesOptions SmallMultiplesOptions
        {
            get { return this._smallMultiplesOptions; }
            set { this._smallMultiplesOptions = value; }
        }

        // Check to see if SmallMultiplesOptions property is set
        internal bool IsSetSmallMultiplesOptions()
        {
            return this._smallMultiplesOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a <code>BarChartVisual</code>.
        /// </para>
        /// </summary>
        public BarChartSortConfiguration SortConfiguration
        {
            get { return this._sortConfiguration; }
            set { this._sortConfiguration = value; }
        }

        // Check to see if SortConfiguration property is set
        internal bool IsSetSortConfiguration()
        {
            return this._sortConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tooltip. 
        /// <para>
        /// The tooltip display setup of the visual.
        /// </para>
        /// </summary>
        public TooltipOptions Tooltip
        {
            get { return this._tooltip; }
            set { this._tooltip = value; }
        }

        // Check to see if Tooltip property is set
        internal bool IsSetTooltip()
        {
            return this._tooltip != null;
        }

        /// <summary>
        /// Gets and sets the property ValueAxis. 
        /// <para>
        /// The label display options (grid line, range, scale, axis step) for a bar chart value.
        /// </para>
        /// </summary>
        public AxisDisplayOptions ValueAxis
        {
            get { return this._valueAxis; }
            set { this._valueAxis = value; }
        }

        // Check to see if ValueAxis property is set
        internal bool IsSetValueAxis()
        {
            return this._valueAxis != null;
        }

        /// <summary>
        /// Gets and sets the property ValueLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility and sort icon visibility) for a bar
        /// chart value.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions ValueLabelOptions
        {
            get { return this._valueLabelOptions; }
            set { this._valueLabelOptions = value; }
        }

        // Check to see if ValueLabelOptions property is set
        internal bool IsSetValueLabelOptions()
        {
            return this._valueLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VisualPalette. 
        /// <para>
        /// The palette (chart color) display setup of the visual.
        /// </para>
        /// </summary>
        public VisualPalette VisualPalette
        {
            get { return this._visualPalette; }
            set { this._visualPalette = value; }
        }

        // Check to see if VisualPalette property is set
        internal bool IsSetVisualPalette()
        {
            return this._visualPalette != null;
        }

    }
}