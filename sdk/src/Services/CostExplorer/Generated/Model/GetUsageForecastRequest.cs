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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetUsageForecast operation.
    /// Retrieves a forecast for how much Amazon Web Services predicts that you will use over
    /// the forecast time period that you select, based on your past usage.
    /// </summary>
    public partial class GetUsageForecastRequest : AmazonCostExplorerRequest
    {
        private Expression _filter;
        private Granularity _granularity;
        private Metric _metric;
        private int? _predictionIntervalLevel;
        private DateInterval _timePeriod;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The filters that you want to use to filter your forecast. Cost Explorer API supports
        /// all of the Cost Explorer filters.
        /// </para>
        /// </summary>
        public Expression Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Granularity. 
        /// <para>
        /// How granular you want the forecast to be. You can get 3 months of <code>DAILY</code>
        /// forecasts or 12 months of <code>MONTHLY</code> forecasts.
        /// </para>
        ///  
        /// <para>
        /// The <code>GetUsageForecast</code> operation supports only <code>DAILY</code> and <code>MONTHLY</code>
        /// granularities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Granularity Granularity
        {
            get { return this._granularity; }
            set { this._granularity = value; }
        }

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this._granularity != null;
        }

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// Which metric Cost Explorer uses to create your forecast.
        /// </para>
        ///  
        /// <para>
        /// Valid values for a <code>GetUsageForecast</code> call are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// USAGE_QUANTITY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NORMALIZED_USAGE_AMOUNT
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Metric Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

        /// <summary>
        /// Gets and sets the property PredictionIntervalLevel. 
        /// <para>
        /// Cost Explorer always returns the mean forecast as a single point. You can request
        /// a prediction interval around the mean by specifying a confidence level. The higher
        /// the confidence level, the more confident Cost Explorer is about the actual value falling
        /// in the prediction interval. Higher confidence levels result in wider prediction intervals.
        /// </para>
        /// </summary>
        [AWSProperty(Min=51, Max=99)]
        public int PredictionIntervalLevel
        {
            get { return this._predictionIntervalLevel.GetValueOrDefault(); }
            set { this._predictionIntervalLevel = value; }
        }

        // Check to see if PredictionIntervalLevel property is set
        internal bool IsSetPredictionIntervalLevel()
        {
            return this._predictionIntervalLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The start and end dates of the period that you want to retrieve usage forecast for.
        /// The start date is inclusive, but the end date is exclusive. For example, if <code>start</code>
        /// is <code>2017-01-01</code> and <code>end</code> is <code>2017-05-01</code>, then the
        /// cost and usage data is retrieved from <code>2017-01-01</code> up to and including
        /// <code>2017-04-30</code> but not including <code>2017-05-01</code>. The start date
        /// must be equal to or later than the current date to avoid a validation error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateInterval TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}