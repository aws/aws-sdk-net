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
    /// The computation union that is used in an insight visual.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class Computation
    {
        private ForecastComputation _forecast;
        private GrowthRateComputation _growthRate;
        private MaximumMinimumComputation _maximumMinimum;
        private MetricComparisonComputation _metricComparison;
        private PeriodOverPeriodComputation _periodOverPeriod;
        private PeriodToDateComputation _periodToDate;
        private TopBottomMoversComputation _topBottomMovers;
        private TopBottomRankedComputation _topBottomRanked;
        private TotalAggregationComputation _totalAggregation;
        private UniqueValuesComputation _uniqueValues;

        /// <summary>
        /// Gets and sets the property Forecast. 
        /// <para>
        /// The forecast computation configuration.
        /// </para>
        /// </summary>
        public ForecastComputation Forecast
        {
            get { return this._forecast; }
            set { this._forecast = value; }
        }

        // Check to see if Forecast property is set
        internal bool IsSetForecast()
        {
            return this._forecast != null;
        }

        /// <summary>
        /// Gets and sets the property GrowthRate. 
        /// <para>
        /// The growth rate computation configuration.
        /// </para>
        /// </summary>
        public GrowthRateComputation GrowthRate
        {
            get { return this._growthRate; }
            set { this._growthRate = value; }
        }

        // Check to see if GrowthRate property is set
        internal bool IsSetGrowthRate()
        {
            return this._growthRate != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumMinimum. 
        /// <para>
        /// The maximum and minimum computation configuration.
        /// </para>
        /// </summary>
        public MaximumMinimumComputation MaximumMinimum
        {
            get { return this._maximumMinimum; }
            set { this._maximumMinimum = value; }
        }

        // Check to see if MaximumMinimum property is set
        internal bool IsSetMaximumMinimum()
        {
            return this._maximumMinimum != null;
        }

        /// <summary>
        /// Gets and sets the property MetricComparison. 
        /// <para>
        /// The metric comparison computation configuration.
        /// </para>
        /// </summary>
        public MetricComparisonComputation MetricComparison
        {
            get { return this._metricComparison; }
            set { this._metricComparison = value; }
        }

        // Check to see if MetricComparison property is set
        internal bool IsSetMetricComparison()
        {
            return this._metricComparison != null;
        }

        /// <summary>
        /// Gets and sets the property PeriodOverPeriod. 
        /// <para>
        /// The period over period computation configuration.
        /// </para>
        /// </summary>
        public PeriodOverPeriodComputation PeriodOverPeriod
        {
            get { return this._periodOverPeriod; }
            set { this._periodOverPeriod = value; }
        }

        // Check to see if PeriodOverPeriod property is set
        internal bool IsSetPeriodOverPeriod()
        {
            return this._periodOverPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property PeriodToDate. 
        /// <para>
        /// The period to <code>DataSetIdentifier</code> computation configuration.
        /// </para>
        /// </summary>
        public PeriodToDateComputation PeriodToDate
        {
            get { return this._periodToDate; }
            set { this._periodToDate = value; }
        }

        // Check to see if PeriodToDate property is set
        internal bool IsSetPeriodToDate()
        {
            return this._periodToDate != null;
        }

        /// <summary>
        /// Gets and sets the property TopBottomMovers. 
        /// <para>
        /// The top movers and bottom movers computation configuration.
        /// </para>
        /// </summary>
        public TopBottomMoversComputation TopBottomMovers
        {
            get { return this._topBottomMovers; }
            set { this._topBottomMovers = value; }
        }

        // Check to see if TopBottomMovers property is set
        internal bool IsSetTopBottomMovers()
        {
            return this._topBottomMovers != null;
        }

        /// <summary>
        /// Gets and sets the property TopBottomRanked. 
        /// <para>
        /// The top ranked and bottom ranked computation configuration.
        /// </para>
        /// </summary>
        public TopBottomRankedComputation TopBottomRanked
        {
            get { return this._topBottomRanked; }
            set { this._topBottomRanked = value; }
        }

        // Check to see if TopBottomRanked property is set
        internal bool IsSetTopBottomRanked()
        {
            return this._topBottomRanked != null;
        }

        /// <summary>
        /// Gets and sets the property TotalAggregation. 
        /// <para>
        /// The total aggregation computation configuration.
        /// </para>
        /// </summary>
        public TotalAggregationComputation TotalAggregation
        {
            get { return this._totalAggregation; }
            set { this._totalAggregation = value; }
        }

        // Check to see if TotalAggregation property is set
        internal bool IsSetTotalAggregation()
        {
            return this._totalAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property UniqueValues. 
        /// <para>
        /// The unique values computation configuration.
        /// </para>
        /// </summary>
        public UniqueValuesComputation UniqueValues
        {
            get { return this._uniqueValues; }
            set { this._uniqueValues = value; }
        }

        // Check to see if UniqueValues property is set
        internal bool IsSetUniqueValues()
        {
            return this._uniqueValues != null;
        }

    }
}