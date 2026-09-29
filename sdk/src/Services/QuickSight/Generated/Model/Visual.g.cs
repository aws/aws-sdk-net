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
        /// <summary>
        /// Gets and sets the property BarChartVisual. 
        /// <para>
        /// A bar chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/bar-charts.html">Using
        /// bar charts</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public BarChartVisual BarChartVisual { get; set; }

        /// <summary>
        /// Checks to see if the BarChartVisual property is set.
        /// </summary>
        internal bool IsSetBarChartVisual() => this.BarChartVisual != null;

        /// <summary>
        /// Gets and sets the property BoxPlotVisual. 
        /// <para>
        /// A box plot.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/box-plots.html">Using
        /// box plots</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public BoxPlotVisual BoxPlotVisual { get; set; }

        /// <summary>
        /// Checks to see if the BoxPlotVisual property is set.
        /// </summary>
        internal bool IsSetBoxPlotVisual() => this.BoxPlotVisual != null;

        /// <summary>
        /// Gets and sets the property ComboChartVisual. 
        /// <para>
        /// A combo chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/combo-charts.html">Using
        /// combo charts</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public ComboChartVisual ComboChartVisual { get; set; }

        /// <summary>
        /// Checks to see if the ComboChartVisual property is set.
        /// </summary>
        internal bool IsSetComboChartVisual() => this.ComboChartVisual != null;

        /// <summary>
        /// Gets and sets the property CustomContentVisual. 
        /// <para>
        /// A visual that contains custom content.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/custom-visual-content.html">Using
        /// custom visual content</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public CustomContentVisual CustomContentVisual { get; set; }

        /// <summary>
        /// Checks to see if the CustomContentVisual property is set.
        /// </summary>
        internal bool IsSetCustomContentVisual() => this.CustomContentVisual != null;

        /// <summary>
        /// Gets and sets the property EmptyVisual. 
        /// <para>
        /// An empty visual.
        /// </para>
        /// </summary>
        public EmptyVisual EmptyVisual { get; set; }

        /// <summary>
        /// Checks to see if the EmptyVisual property is set.
        /// </summary>
        internal bool IsSetEmptyVisual() => this.EmptyVisual != null;

        /// <summary>
        /// Gets and sets the property FilledMapVisual. 
        /// <para>
        /// A filled map.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/filled-maps.html">Creating
        /// filled maps</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public FilledMapVisual FilledMapVisual { get; set; }

        /// <summary>
        /// Checks to see if the FilledMapVisual property is set.
        /// </summary>
        internal bool IsSetFilledMapVisual() => this.FilledMapVisual != null;

        /// <summary>
        /// Gets and sets the property FunnelChartVisual. 
        /// <para>
        /// A funnel chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/funnel-visual-content.html">Using
        /// funnel charts</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public FunnelChartVisual FunnelChartVisual { get; set; }

        /// <summary>
        /// Checks to see if the FunnelChartVisual property is set.
        /// </summary>
        internal bool IsSetFunnelChartVisual() => this.FunnelChartVisual != null;

        /// <summary>
        /// Gets and sets the property GaugeChartVisual. 
        /// <para>
        /// A gauge chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/gauge-chart.html">Using
        /// gauge charts</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public GaugeChartVisual GaugeChartVisual { get; set; }

        /// <summary>
        /// Checks to see if the GaugeChartVisual property is set.
        /// </summary>
        internal bool IsSetGaugeChartVisual() => this.GaugeChartVisual != null;

        /// <summary>
        /// Gets and sets the property GeospatialMapVisual. 
        /// <para>
        /// A geospatial map or a points on map visual.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/point-maps.html">Creating
        /// point maps</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public GeospatialMapVisual GeospatialMapVisual { get; set; }

        /// <summary>
        /// Checks to see if the GeospatialMapVisual property is set.
        /// </summary>
        internal bool IsSetGeospatialMapVisual() => this.GeospatialMapVisual != null;

        /// <summary>
        /// Gets and sets the property HeatMapVisual. 
        /// <para>
        /// A heat map.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/heat-map.html">Using
        /// heat maps</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public HeatMapVisual HeatMapVisual { get; set; }

        /// <summary>
        /// Checks to see if the HeatMapVisual property is set.
        /// </summary>
        internal bool IsSetHeatMapVisual() => this.HeatMapVisual != null;

        /// <summary>
        /// Gets and sets the property HistogramVisual. 
        /// <para>
        /// A histogram.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/histogram-charts.html">Using
        /// histograms</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public HistogramVisual HistogramVisual { get; set; }

        /// <summary>
        /// Checks to see if the HistogramVisual property is set.
        /// </summary>
        internal bool IsSetHistogramVisual() => this.HistogramVisual != null;

        /// <summary>
        /// Gets and sets the property InsightVisual. 
        /// <para>
        /// An insight visual.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/computational-insights.html">Working
        /// with insights</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public InsightVisual InsightVisual { get; set; }

        /// <summary>
        /// Checks to see if the InsightVisual property is set.
        /// </summary>
        internal bool IsSetInsightVisual() => this.InsightVisual != null;

        /// <summary>
        /// Gets and sets the property KPIVisual. 
        /// <para>
        /// A key performance indicator (KPI).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/kpi.html">Using
        /// KPIs</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public KPIVisual KPIVisual { get; set; }

        /// <summary>
        /// Checks to see if the KPIVisual property is set.
        /// </summary>
        internal bool IsSetKPIVisual() => this.KPIVisual != null;

        /// <summary>
        /// Gets and sets the property LayerMapVisual. 
        /// <para>
        /// The properties for a layer map visual
        /// </para>
        /// </summary>
        public LayerMapVisual LayerMapVisual { get; set; }

        /// <summary>
        /// Checks to see if the LayerMapVisual property is set.
        /// </summary>
        internal bool IsSetLayerMapVisual() => this.LayerMapVisual != null;

        /// <summary>
        /// Gets and sets the property LineChartVisual. 
        /// <para>
        /// A line chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/line-charts.html">Using
        /// line charts</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public LineChartVisual LineChartVisual { get; set; }

        /// <summary>
        /// Checks to see if the LineChartVisual property is set.
        /// </summary>
        internal bool IsSetLineChartVisual() => this.LineChartVisual != null;

        /// <summary>
        /// Gets and sets the property PieChartVisual. 
        /// <para>
        /// A pie or donut chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/pie-chart.html">Using
        /// pie charts</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public PieChartVisual PieChartVisual { get; set; }

        /// <summary>
        /// Checks to see if the PieChartVisual property is set.
        /// </summary>
        internal bool IsSetPieChartVisual() => this.PieChartVisual != null;

        /// <summary>
        /// Gets and sets the property PivotTableVisual. 
        /// <para>
        /// A pivot table.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/pivot-table.html">Using
        /// pivot tables</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public PivotTableVisual PivotTableVisual { get; set; }

        /// <summary>
        /// Checks to see if the PivotTableVisual property is set.
        /// </summary>
        internal bool IsSetPivotTableVisual() => this.PivotTableVisual != null;

        /// <summary>
        /// Gets and sets the property PluginVisual. 
        /// <para>
        /// The custom plugin visual type.
        /// </para>
        /// </summary>
        public PluginVisual PluginVisual { get; set; }

        /// <summary>
        /// Checks to see if the PluginVisual property is set.
        /// </summary>
        internal bool IsSetPluginVisual() => this.PluginVisual != null;

        /// <summary>
        /// Gets and sets the property RadarChartVisual. 
        /// <para>
        /// A radar chart visual.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/radar-chart.html">Using
        /// radar charts</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public RadarChartVisual RadarChartVisual { get; set; }

        /// <summary>
        /// Checks to see if the RadarChartVisual property is set.
        /// </summary>
        internal bool IsSetRadarChartVisual() => this.RadarChartVisual != null;

        /// <summary>
        /// Gets and sets the property SankeyDiagramVisual. 
        /// <para>
        /// A sankey diagram.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/sankey-diagram.html">Using
        /// Sankey diagrams</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public SankeyDiagramVisual SankeyDiagramVisual { get; set; }

        /// <summary>
        /// Checks to see if the SankeyDiagramVisual property is set.
        /// </summary>
        internal bool IsSetSankeyDiagramVisual() => this.SankeyDiagramVisual != null;

        /// <summary>
        /// Gets and sets the property ScatterPlotVisual. 
        /// <para>
        /// A scatter plot.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/scatter-plot.html">Using
        /// scatter plots</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public ScatterPlotVisual ScatterPlotVisual { get; set; }

        /// <summary>
        /// Checks to see if the ScatterPlotVisual property is set.
        /// </summary>
        internal bool IsSetScatterPlotVisual() => this.ScatterPlotVisual != null;

        /// <summary>
        /// Gets and sets the property TableVisual. 
        /// <para>
        /// A table visual.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/tabular.html">Using
        /// tables as visuals</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public TableVisual TableVisual { get; set; }

        /// <summary>
        /// Checks to see if the TableVisual property is set.
        /// </summary>
        internal bool IsSetTableVisual() => this.TableVisual != null;

        /// <summary>
        /// Gets and sets the property TreeMapVisual. 
        /// <para>
        /// A tree map.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/tree-map.html">Using
        /// tree maps</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public TreeMapVisual TreeMapVisual { get; set; }

        /// <summary>
        /// Checks to see if the TreeMapVisual property is set.
        /// </summary>
        internal bool IsSetTreeMapVisual() => this.TreeMapVisual != null;

        /// <summary>
        /// Gets and sets the property WaterfallVisual. 
        /// <para>
        /// A waterfall chart.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/waterfall-chart.html">Using
        /// waterfall charts</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public WaterfallVisual WaterfallVisual { get; set; }

        /// <summary>
        /// Checks to see if the WaterfallVisual property is set.
        /// </summary>
        internal bool IsSetWaterfallVisual() => this.WaterfallVisual != null;

        /// <summary>
        /// Gets and sets the property WordCloudVisual. 
        /// <para>
        /// A word cloud.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/word-cloud.html">Using
        /// word clouds</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// </summary>
        public WordCloudVisual WordCloudVisual { get; set; }

        /// <summary>
        /// Checks to see if the WordCloudVisual property is set.
        /// </summary>
        internal bool IsSetWordCloudVisual() => this.WordCloudVisual != null;
    }
}
