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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Configuration for the Random Cut Forest algorithm used for anomaly detection in time-series
    /// data.
    /// </summary>
    public partial class RandomCutForestConfiguration
    {
        private IgnoreNearExpected _ignoreNearExpectedFromAbove;
        private IgnoreNearExpected _ignoreNearExpectedFromBelow;
        private string _query;
        private int? _sampleSize;
        private int? _shingleSize;

        /// <summary>
        /// Gets and sets the property IgnoreNearExpectedFromAbove. 
        /// <para>
        /// Configuration for ignoring values that are near expected values from above during
        /// anomaly detection.
        /// </para>
        /// </summary>
        public IgnoreNearExpected IgnoreNearExpectedFromAbove
        {
            get { return this._ignoreNearExpectedFromAbove; }
            set { this._ignoreNearExpectedFromAbove = value; }
        }

        // Check to see if IgnoreNearExpectedFromAbove property is set
        internal bool IsSetIgnoreNearExpectedFromAbove()
        {
            return this._ignoreNearExpectedFromAbove != null;
        }

        /// <summary>
        /// Gets and sets the property IgnoreNearExpectedFromBelow. 
        /// <para>
        /// Configuration for ignoring values that are near expected values from below during
        /// anomaly detection.
        /// </para>
        /// </summary>
        public IgnoreNearExpected IgnoreNearExpectedFromBelow
        {
            get { return this._ignoreNearExpectedFromBelow; }
            set { this._ignoreNearExpectedFromBelow = value; }
        }

        // Check to see if IgnoreNearExpectedFromBelow property is set
        internal bool IsSetIgnoreNearExpectedFromBelow()
        {
            return this._ignoreNearExpectedFromBelow != null;
        }

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The Prometheus query used to retrieve the time-series data for anomaly detection.
        /// </para>
        ///  <important> 
        /// <para>
        /// Random Cut Forest queries must be wrapped by a supported PromQL aggregation operator.
        /// For more information, see <a href="https://prometheus.io/docs/prometheus/latest/querying/operators/#aggregation-operators">Aggregation
        /// operators</a> on the <i>Prometheus docs</i> website.
        /// </para>
        ///  
        /// <para>
        ///  <b>Supported PromQL aggregation operators</b>: <c>avg</c>, <c>count</c>, <c>group</c>,
        /// <c>max</c>, <c>min</c>, <c>quantile</c>, <c>stddev</c>, <c>stdvar</c>, and <c>sum</c>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8192)]
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the property SampleSize. 
        /// <para>
        /// The number of data points sampled from the input stream for the Random Cut Forest
        /// algorithm. The default number is 256 consecutive data points.
        /// </para>
        /// </summary>
        [AWSProperty(Min=256, Max=1024)]
        public int? SampleSize
        {
            get { return this._sampleSize; }
            set { this._sampleSize = value; }
        }

        // Check to see if SampleSize property is set
        internal bool IsSetSampleSize()
        {
            return this._sampleSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShingleSize. 
        /// <para>
        /// The number of consecutive data points used to create a shingle for the Random Cut
        /// Forest algorithm. The default number is 8 consecutive data points.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=1024)]
        public int? ShingleSize
        {
            get { return this._shingleSize; }
            set { this._shingleSize = value; }
        }

        // Check to see if ShingleSize property is set
        internal bool IsSetShingleSize()
        {
            return this._shingleSize.HasValue; 
        }

    }
}