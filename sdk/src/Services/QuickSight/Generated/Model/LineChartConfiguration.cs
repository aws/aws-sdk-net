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
    /// The configuration of a line chart.
    /// </summary>
    public partial class LineChartConfiguration
    {
        private List<ContributionAnalysisDefault> _contributionAnalysisDefaults = new List<ContributionAnalysisDefault>();
        private DataLabelOptions _dataLabels;
        private LineChartDefaultSeriesSettings _defaultSeriesSettings;
        private LineChartFieldWells _fieldWells;
        private List<ForecastConfiguration> _forecastConfigurations = new List<ForecastConfiguration>();
        private LegendOptions _legend;
        private LineSeriesAxisDisplayOptions _primaryYAxisDisplayOptions;
        private ChartAxisLabelOptions _primaryYAxisLabelOptions;
        private List<ReferenceLine> _referenceLines = new List<ReferenceLine>();
        private LineSeriesAxisDisplayOptions _secondaryYAxisDisplayOptions;
        private ChartAxisLabelOptions _secondaryYAxisLabelOptions;
        private List<SeriesItem> _series = new List<SeriesItem>();
        private SmallMultiplesOptions _smallMultiplesOptions;
        private LineChartSortConfiguration _sortConfiguration;
        private TooltipOptions _tooltip;
        private LineChartType _type;
        private VisualPalette _visualPalette;
        private AxisDisplayOptions _xAxisDisplayOptions;
        private ChartAxisLabelOptions _xAxisLabelOptions;

        /// <summary>
        /// Gets and sets the property ContributionAnalysisDefaults. 
        /// <para>
        /// The default configuration of a line chart's contribution analysis.
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
        /// The data label configuration of a line chart.
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
        /// Gets and sets the property DefaultSeriesSettings. 
        /// <para>
        /// The options that determine the default presentation of all line series in <code>LineChartVisual</code>.
        /// </para>
        /// </summary>
        public LineChartDefaultSeriesSettings DefaultSeriesSettings
        {
            get { return this._defaultSeriesSettings; }
            set { this._defaultSeriesSettings = value; }
        }

        // Check to see if DefaultSeriesSettings property is set
        internal bool IsSetDefaultSeriesSettings()
        {
            return this._defaultSeriesSettings != null;
        }

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field well configuration of a line chart.
        /// </para>
        /// </summary>
        public LineChartFieldWells FieldWells
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
        /// Gets and sets the property ForecastConfigurations. 
        /// <para>
        /// The forecast configuration of a line chart.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<ForecastConfiguration> ForecastConfigurations
        {
            get { return this._forecastConfigurations; }
            set { this._forecastConfigurations = value; }
        }

        // Check to see if ForecastConfigurations property is set
        internal bool IsSetForecastConfigurations()
        {
            return this._forecastConfigurations != null && this._forecastConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Legend. 
        /// <para>
        /// The legend configuration of a line chart.
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
        /// Gets and sets the property PrimaryYAxisDisplayOptions. 
        /// <para>
        /// The series axis configuration of a line chart.
        /// </para>
        /// </summary>
        public LineSeriesAxisDisplayOptions PrimaryYAxisDisplayOptions
        {
            get { return this._primaryYAxisDisplayOptions; }
            set { this._primaryYAxisDisplayOptions = value; }
        }

        // Check to see if PrimaryYAxisDisplayOptions property is set
        internal bool IsSetPrimaryYAxisDisplayOptions()
        {
            return this._primaryYAxisDisplayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryYAxisLabelOptions. 
        /// <para>
        /// The options that determine the presentation of the y-axis label.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions PrimaryYAxisLabelOptions
        {
            get { return this._primaryYAxisLabelOptions; }
            set { this._primaryYAxisLabelOptions = value; }
        }

        // Check to see if PrimaryYAxisLabelOptions property is set
        internal bool IsSetPrimaryYAxisLabelOptions()
        {
            return this._primaryYAxisLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceLines. 
        /// <para>
        /// The reference lines configuration of a line chart.
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
        /// Gets and sets the property SecondaryYAxisDisplayOptions. 
        /// <para>
        /// The series axis configuration of a line chart.
        /// </para>
        /// </summary>
        public LineSeriesAxisDisplayOptions SecondaryYAxisDisplayOptions
        {
            get { return this._secondaryYAxisDisplayOptions; }
            set { this._secondaryYAxisDisplayOptions = value; }
        }

        // Check to see if SecondaryYAxisDisplayOptions property is set
        internal bool IsSetSecondaryYAxisDisplayOptions()
        {
            return this._secondaryYAxisDisplayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryYAxisLabelOptions. 
        /// <para>
        /// The options that determine the presentation of the secondary y-axis label.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions SecondaryYAxisLabelOptions
        {
            get { return this._secondaryYAxisLabelOptions; }
            set { this._secondaryYAxisLabelOptions = value; }
        }

        // Check to see if SecondaryYAxisLabelOptions property is set
        internal bool IsSetSecondaryYAxisLabelOptions()
        {
            return this._secondaryYAxisLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Series. 
        /// <para>
        /// The series item configuration of a line chart.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<SeriesItem> Series
        {
            get { return this._series; }
            set { this._series = value; }
        }

        // Check to see if Series property is set
        internal bool IsSetSeries()
        {
            return this._series != null && this._series.Count > 0; 
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
        /// The sort configuration of a line chart.
        /// </para>
        /// </summary>
        public LineChartSortConfiguration SortConfiguration
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
        /// The tooltip configuration of a line chart.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// Determines the type of the line chart.
        /// </para>
        /// </summary>
        public LineChartType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VisualPalette. 
        /// <para>
        /// The visual palette configuration of a line chart.
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

        /// <summary>
        /// Gets and sets the property XAxisDisplayOptions. 
        /// <para>
        /// The options that determine the presentation of the x-axis.
        /// </para>
        /// </summary>
        public AxisDisplayOptions XAxisDisplayOptions
        {
            get { return this._xAxisDisplayOptions; }
            set { this._xAxisDisplayOptions = value; }
        }

        // Check to see if XAxisDisplayOptions property is set
        internal bool IsSetXAxisDisplayOptions()
        {
            return this._xAxisDisplayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property XAxisLabelOptions. 
        /// <para>
        /// The options that determine the presentation of the x-axis label.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions XAxisLabelOptions
        {
            get { return this._xAxisLabelOptions; }
            set { this._xAxisLabelOptions = value; }
        }

        // Check to see if XAxisLabelOptions property is set
        internal bool IsSetXAxisLabelOptions()
        {
            return this._xAxisLabelOptions != null;
        }

    }
}