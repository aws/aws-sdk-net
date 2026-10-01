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
        /// <summary>
        /// Gets and sets the property Forecast. 
        /// <para>
        /// The forecast computation configuration.
        /// </para>
        /// </summary>
        public ForecastComputation Forecast { get; set; }

        /// <summary>
        /// Checks to see if the Forecast property is set.
        /// </summary>
        internal bool IsSetForecast() => this.Forecast != null;

        /// <summary>
        /// Gets and sets the property GrowthRate. 
        /// <para>
        /// The growth rate computation configuration.
        /// </para>
        /// </summary>
        public GrowthRateComputation GrowthRate { get; set; }

        /// <summary>
        /// Checks to see if the GrowthRate property is set.
        /// </summary>
        internal bool IsSetGrowthRate() => this.GrowthRate != null;

        /// <summary>
        /// Gets and sets the property MaximumMinimum. 
        /// <para>
        /// The maximum and minimum computation configuration.
        /// </para>
        /// </summary>
        public MaximumMinimumComputation MaximumMinimum { get; set; }

        /// <summary>
        /// Checks to see if the MaximumMinimum property is set.
        /// </summary>
        internal bool IsSetMaximumMinimum() => this.MaximumMinimum != null;

        /// <summary>
        /// Gets and sets the property MetricComparison. 
        /// <para>
        /// The metric comparison computation configuration.
        /// </para>
        /// </summary>
        public MetricComparisonComputation MetricComparison { get; set; }

        /// <summary>
        /// Checks to see if the MetricComparison property is set.
        /// </summary>
        internal bool IsSetMetricComparison() => this.MetricComparison != null;

        /// <summary>
        /// Gets and sets the property PeriodOverPeriod. 
        /// <para>
        /// The period over period computation configuration.
        /// </para>
        /// </summary>
        public PeriodOverPeriodComputation PeriodOverPeriod { get; set; }

        /// <summary>
        /// Checks to see if the PeriodOverPeriod property is set.
        /// </summary>
        internal bool IsSetPeriodOverPeriod() => this.PeriodOverPeriod != null;

        /// <summary>
        /// Gets and sets the property PeriodToDate. 
        /// <para>
        /// The period to <c>DataSetIdentifier</c> computation configuration.
        /// </para>
        /// </summary>
        public PeriodToDateComputation PeriodToDate { get; set; }

        /// <summary>
        /// Checks to see if the PeriodToDate property is set.
        /// </summary>
        internal bool IsSetPeriodToDate() => this.PeriodToDate != null;

        /// <summary>
        /// Gets and sets the property TopBottomMovers. 
        /// <para>
        /// The top movers and bottom movers computation configuration.
        /// </para>
        /// </summary>
        public TopBottomMoversComputation TopBottomMovers { get; set; }

        /// <summary>
        /// Checks to see if the TopBottomMovers property is set.
        /// </summary>
        internal bool IsSetTopBottomMovers() => this.TopBottomMovers != null;

        /// <summary>
        /// Gets and sets the property TopBottomRanked. 
        /// <para>
        /// The top ranked and bottom ranked computation configuration.
        /// </para>
        /// </summary>
        public TopBottomRankedComputation TopBottomRanked { get; set; }

        /// <summary>
        /// Checks to see if the TopBottomRanked property is set.
        /// </summary>
        internal bool IsSetTopBottomRanked() => this.TopBottomRanked != null;

        /// <summary>
        /// Gets and sets the property TotalAggregation. 
        /// <para>
        /// The total aggregation computation configuration.
        /// </para>
        /// </summary>
        public TotalAggregationComputation TotalAggregation { get; set; }

        /// <summary>
        /// Checks to see if the TotalAggregation property is set.
        /// </summary>
        internal bool IsSetTotalAggregation() => this.TotalAggregation != null;

        /// <summary>
        /// Gets and sets the property UniqueValues. 
        /// <para>
        /// The unique values computation configuration.
        /// </para>
        /// </summary>
        public UniqueValuesComputation UniqueValues { get; set; }

        /// <summary>
        /// Checks to see if the UniqueValues property is set.
        /// </summary>
        internal bool IsSetUniqueValues() => this.UniqueValues != null;
    }
}
