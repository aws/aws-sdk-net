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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// The ExplainabilityConfig data type defines the number of time series and time points
    /// included in <a>CreateExplainability</a>.
    /// 
    ///  
    /// <para>
    /// If you provide a predictor ARN for <code>ResourceArn</code>, you must set both <code>TimePointGranularity</code>
    /// and <code>TimeSeriesGranularity</code> to “ALL”. When creating Predictor Explainability,
    /// Amazon Forecast considers all time series and time points.
    /// </para>
    ///  
    /// <para>
    /// If you provide a forecast ARN for <code>ResourceArn</code>, you can set <code>TimePointGranularity</code>
    /// and <code>TimeSeriesGranularity</code> to either “ALL” or “Specific”.
    /// </para>
    /// </summary>
    public partial class ExplainabilityConfig
    {
        private TimePointGranularity _timePointGranularity;
        private TimeSeriesGranularity _timeSeriesGranularity;

        /// <summary>
        /// Gets and sets the property TimePointGranularity. 
        /// <para>
        /// To create an Explainability for all time points in your forecast horizon, use <code>ALL</code>.
        /// To create an Explainability for specific time points in your forecast horizon, use
        /// <code>SPECIFIC</code>.
        /// </para>
        ///  
        /// <para>
        /// Specify time points with the <code>StartDateTime</code> and <code>EndDateTime</code>
        /// parameters within the <a>CreateExplainability</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimePointGranularity TimePointGranularity
        {
            get { return this._timePointGranularity; }
            set { this._timePointGranularity = value; }
        }

        // Check to see if TimePointGranularity property is set
        internal bool IsSetTimePointGranularity()
        {
            return this._timePointGranularity != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesGranularity. 
        /// <para>
        /// To create an Explainability for all time series in your datasets, use <code>ALL</code>.
        /// To create an Explainability for specific time series in your datasets, use <code>SPECIFIC</code>.
        /// </para>
        ///  
        /// <para>
        /// Specify time series by uploading a CSV file to an Amazon S3 bucket and set the location
        /// within the <a>DataDestination</a> data type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeSeriesGranularity TimeSeriesGranularity
        {
            get { return this._timeSeriesGranularity; }
            set { this._timeSeriesGranularity = value; }
        }

        // Check to see if TimeSeriesGranularity property is set
        internal bool IsSetTimeSeriesGranularity()
        {
            return this._timeSeriesGranularity != null;
        }

    }
}