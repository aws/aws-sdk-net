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
 * Do not modify this file. This file is generated from the sagemaker-metrics-2022-09-30.normal.json service model.
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
namespace Amazon.SageMakerMetrics.Model
{
    /// <summary>
    /// An error that occured when putting the metric data.
    /// </summary>
    public partial class BatchPutMetricsError
    {
        private PutMetricsErrorCode _code;
        private int? _metricIndex;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code of an error that occured when attempting to put metrics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>METRIC_LIMIT_EXCEEDED</c>: The maximum amount of metrics per resource is exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERNAL_ERROR</c>: An internal error occured.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VALIDATION_ERROR</c>: The metric data failed validation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONFLICT_ERROR</c>: Multiple requests attempted to modify the same data simultaneously.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PutMetricsErrorCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property MetricIndex. 
        /// <para>
        /// An index that corresponds to the metric in the request.
        /// </para>
        /// </summary>
        public int? MetricIndex
        {
            get { return this._metricIndex; }
            set { this._metricIndex = value; }
        }

        // Check to see if MetricIndex property is set
        internal bool IsSetMetricIndex()
        {
            return this._metricIndex.HasValue; 
        }

    }
}