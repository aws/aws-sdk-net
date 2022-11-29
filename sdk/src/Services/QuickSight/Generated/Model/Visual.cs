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
    /// A visual displayed on a sheet in an analysis, dashboard, or template.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class Visual
    {
        private BarChartVisual _barChartVisual;
        private BoxPlotVisual _boxPlotVisual;
        private ComboChartVisual _comboChartVisual;
        private CustomContentVisual _customContentVisual;
        private EmptyVisual _emptyVisual;
        private FilledMapVisual _filledMapVisual;
        private FunnelChartVisual _funnelChartVisual;
        private GaugeChartVisual _gaugeChartVisual;
        private GeospatialMapVisual _geospatialMapVisual;
        private HeatMapVisual _heatMapVisual;
        private HistogramVisual _histogramVisual;
        private InsightVisual _insightVisual;
        private KPIVisual _kpiVisual;
        private LineChartVisual _lineChartVisual;
        private PieChartVisual _pieChartVisual;
        private PivotTableVisual _pivotTableVisual;
        private SankeyDiagramVisual _sankeyDiagramVisual;
        private ScatterPlotVisual _scatterPlotVisual;
        private TableVisual _tableVisual;
        private TreeMapVisual _treeMapVisual;
        private WaterfallVisual _waterfallVisual;
        private WordCloudVisual _wordCloudVisual;

        /// <summary>
        /// Gets and sets the property BarChartVisual. 
        /// <para>
        /// A bar chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/bar-charts.html">Using
        /// bar charts</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public BarChartVisual BarChartVisual
        {
            get { return this._barChartVisual; }
            set { this._barChartVisual = value; }
        }

        // Check to see if BarChartVisual property is set
        internal bool IsSetBarChartVisual()
        {
            return this._barChartVisual != null;
        }

        /// <summary>
        /// Gets and sets the property BoxPlotVisual. 
        /// <para>
        /// A box plot.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/box-plots.html">Using
        /// box plots</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public BoxPlotVisual BoxPlotVisual
        {
            get { return this._boxPlotVisual; }
            set { this._boxPlotVisual = value; }
        }

        // Check to see if BoxPlotVisual property is set
        internal bool IsSetBoxPlotVisual()
        {
            return this._boxPlotVisual != null;
        }

        /// <summary>
        /// Gets and sets the property ComboChartVisual. 
        /// <para>
        /// A combo chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/combo-charts.html">Using
        /// combo charts</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public ComboChartVisual ComboChartVisual
        {
            get { return this._comboChartVisual; }
            set { this._comboChartVisual = value; }
        }

        // Check to see if ComboChartVisual property is set
        internal bool IsSetComboChartVisual()
        {
            return this._comboChartVisual != null;
        }

        /// <summary>
        /// Gets and sets the property CustomContentVisual. 
        /// <para>
        /// A visual that contains custom content.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/custom-visual-content.html">Using
        /// custom visual content</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public CustomContentVisual CustomContentVisual
        {
            get { return this._customContentVisual; }
            set { this._customContentVisual = value; }
        }

        // Check to see if CustomContentVisual property is set
        internal bool IsSetCustomContentVisual()
        {
            return this._customContentVisual != null;
        }

        /// <summary>
        /// Gets and sets the property EmptyVisual. 
        /// <para>
        /// An empty visual.
        /// </para>
        /// </summary>
        public EmptyVisual EmptyVisual
        {
            get { return this._emptyVisual; }
            set { this._emptyVisual = value; }
        }

        // Check to see if EmptyVisual property is set
        internal bool IsSetEmptyVisual()
        {
            return this._emptyVisual != null;
        }

        /// <summary>
        /// Gets and sets the property FilledMapVisual. 
        /// <para>
        /// A filled map.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/filled-maps.html">Creating
        /// filled maps</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public FilledMapVisual FilledMapVisual
        {
            get { return this._filledMapVisual; }
            set { this._filledMapVisual = value; }
        }

        // Check to see if FilledMapVisual property is set
        internal bool IsSetFilledMapVisual()
        {
            return this._filledMapVisual != null;
        }

        /// <summary>
        /// Gets and sets the property FunnelChartVisual. 
        /// <para>
        /// A funnel chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/funnel-visual-content.html">Using
        /// funnel charts</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public FunnelChartVisual FunnelChartVisual
        {
            get { return this._funnelChartVisual; }
            set { this._funnelChartVisual = value; }
        }

        // Check to see if FunnelChartVisual property is set
        internal bool IsSetFunnelChartVisual()
        {
            return this._funnelChartVisual != null;
        }

        /// <summary>
        /// Gets and sets the property GaugeChartVisual. 
        /// <para>
        /// A gauge chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/gauge-chart.html">Using
        /// gauge charts</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public GaugeChartVisual GaugeChartVisual
        {
            get { return this._gaugeChartVisual; }
            set { this._gaugeChartVisual = value; }
        }

        // Check to see if GaugeChartVisual property is set
        internal bool IsSetGaugeChartVisual()
        {
            return this._gaugeChartVisual != null;
        }

        /// <summary>
        /// Gets and sets the property GeospatialMapVisual. 
        /// <para>
        /// A geospatial map or a points on map visual.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/point-maps.html">Creating
        /// point maps</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public GeospatialMapVisual GeospatialMapVisual
        {
            get { return this._geospatialMapVisual; }
            set { this._geospatialMapVisual = value; }
        }

        // Check to see if GeospatialMapVisual property is set
        internal bool IsSetGeospatialMapVisual()
        {
            return this._geospatialMapVisual != null;
        }

        /// <summary>
        /// Gets and sets the property HeatMapVisual. 
        /// <para>
        /// A heat map.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/heat-map.html">Using
        /// heat maps</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public HeatMapVisual HeatMapVisual
        {
            get { return this._heatMapVisual; }
            set { this._heatMapVisual = value; }
        }

        // Check to see if HeatMapVisual property is set
        internal bool IsSetHeatMapVisual()
        {
            return this._heatMapVisual != null;
        }

        /// <summary>
        /// Gets and sets the property HistogramVisual. 
        /// <para>
        /// A histogram.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/histogram-charts.html">Using
        /// histograms</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public HistogramVisual HistogramVisual
        {
            get { return this._histogramVisual; }
            set { this._histogramVisual = value; }
        }

        // Check to see if HistogramVisual property is set
        internal bool IsSetHistogramVisual()
        {
            return this._histogramVisual != null;
        }

        /// <summary>
        /// Gets and sets the property InsightVisual. 
        /// <para>
        /// An insight visual.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/computational-insights.html">Working
        /// with insights</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public InsightVisual InsightVisual
        {
            get { return this._insightVisual; }
            set { this._insightVisual = value; }
        }

        // Check to see if InsightVisual property is set
        internal bool IsSetInsightVisual()
        {
            return this._insightVisual != null;
        }

        /// <summary>
        /// Gets and sets the property KPIVisual. 
        /// <para>
        /// A key performance indicator (KPI).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/kpi.html">Using
        /// KPIs</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public KPIVisual KPIVisual
        {
            get { return this._kpiVisual; }
            set { this._kpiVisual = value; }
        }

        // Check to see if KPIVisual property is set
        internal bool IsSetKPIVisual()
        {
            return this._kpiVisual != null;
        }

        /// <summary>
        /// Gets and sets the property LineChartVisual. 
        /// <para>
        /// A line chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/line-charts.html">Using
        /// line charts</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public LineChartVisual LineChartVisual
        {
            get { return this._lineChartVisual; }
            set { this._lineChartVisual = value; }
        }

        // Check to see if LineChartVisual property is set
        internal bool IsSetLineChartVisual()
        {
            return this._lineChartVisual != null;
        }

        /// <summary>
        /// Gets and sets the property PieChartVisual. 
        /// <para>
        /// A pie or donut chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/pie-chart.html">Using
        /// pie charts</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public PieChartVisual PieChartVisual
        {
            get { return this._pieChartVisual; }
            set { this._pieChartVisual = value; }
        }

        // Check to see if PieChartVisual property is set
        internal bool IsSetPieChartVisual()
        {
            return this._pieChartVisual != null;
        }

        /// <summary>
        /// Gets and sets the property PivotTableVisual. 
        /// <para>
        /// A pivot table.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/pivot-table.html">Using
        /// pivot tables</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public PivotTableVisual PivotTableVisual
        {
            get { return this._pivotTableVisual; }
            set { this._pivotTableVisual = value; }
        }

        // Check to see if PivotTableVisual property is set
        internal bool IsSetPivotTableVisual()
        {
            return this._pivotTableVisual != null;
        }

        /// <summary>
        /// Gets and sets the property SankeyDiagramVisual. 
        /// <para>
        /// A sankey diagram.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/sankey-diagram.html">Using
        /// Sankey diagrams</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public SankeyDiagramVisual SankeyDiagramVisual
        {
            get { return this._sankeyDiagramVisual; }
            set { this._sankeyDiagramVisual = value; }
        }

        // Check to see if SankeyDiagramVisual property is set
        internal bool IsSetSankeyDiagramVisual()
        {
            return this._sankeyDiagramVisual != null;
        }

        /// <summary>
        /// Gets and sets the property ScatterPlotVisual. 
        /// <para>
        /// A scatter plot.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/scatter-plot.html">Using
        /// scatter plots</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public ScatterPlotVisual ScatterPlotVisual
        {
            get { return this._scatterPlotVisual; }
            set { this._scatterPlotVisual = value; }
        }

        // Check to see if ScatterPlotVisual property is set
        internal bool IsSetScatterPlotVisual()
        {
            return this._scatterPlotVisual != null;
        }

        /// <summary>
        /// Gets and sets the property TableVisual. 
        /// <para>
        /// A table visual.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/tabular.html">Using
        /// tables as visuals</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public TableVisual TableVisual
        {
            get { return this._tableVisual; }
            set { this._tableVisual = value; }
        }

        // Check to see if TableVisual property is set
        internal bool IsSetTableVisual()
        {
            return this._tableVisual != null;
        }

        /// <summary>
        /// Gets and sets the property TreeMapVisual. 
        /// <para>
        /// A tree map.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/tree-map.html">Using
        /// tree maps</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public TreeMapVisual TreeMapVisual
        {
            get { return this._treeMapVisual; }
            set { this._treeMapVisual = value; }
        }

        // Check to see if TreeMapVisual property is set
        internal bool IsSetTreeMapVisual()
        {
            return this._treeMapVisual != null;
        }

        /// <summary>
        /// Gets and sets the property WaterfallVisual. 
        /// <para>
        /// A waterfall chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/waterfall-chart.html">Using
        /// waterfall charts</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public WaterfallVisual WaterfallVisual
        {
            get { return this._waterfallVisual; }
            set { this._waterfallVisual = value; }
        }

        // Check to see if WaterfallVisual property is set
        internal bool IsSetWaterfallVisual()
        {
            return this._waterfallVisual != null;
        }

        /// <summary>
        /// Gets and sets the property WordCloudVisual. 
        /// <para>
        /// A word cloud.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/word-cloud.html">Using
        /// word clouds</a> in the <i>Amazon QuickSight User Guide</i>.
        /// </para>
        /// </summary>
        public WordCloudVisual WordCloudVisual
        {
            get { return this._wordCloudVisual; }
            set { this._wordCloudVisual = value; }
        }

        // Check to see if WordCloudVisual property is set
        internal bool IsSetWordCloudVisual()
        {
            return this._wordCloudVisual != null;
        }

    }
}