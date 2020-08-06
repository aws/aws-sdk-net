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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The training metric details.
    /// </summary>
    public partial class TrainingMetrics
    {
        private float? _auc;
        private List<MetricDataPoint> _metricDataPoints = new List<MetricDataPoint>();

        /// <summary>
        /// Gets and sets the property Auc. 
        /// <para>
        /// The area under the curve. This summarizes true positive rate (TPR) and false positive
        /// rate (FPR) across all possible model score thresholds. A model with no predictive
        /// power has an AUC of 0.5, whereas a perfect model has a score of 1.0.
        /// </para>
        /// </summary>
        public float Auc
        {
            get { return this._auc.GetValueOrDefault(); }
            set { this._auc = value; }
        }

        // Check to see if Auc property is set
        internal bool IsSetAuc()
        {
            return this._auc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricDataPoints. 
        /// <para>
        /// The data points details.
        /// </para>
        /// </summary>
        public List<MetricDataPoint> MetricDataPoints
        {
            get { return this._metricDataPoints; }
            set { this._metricDataPoints = value; }
        }

        // Check to see if MetricDataPoints property is set
        internal bool IsSetMetricDataPoints()
        {
            return this._metricDataPoints != null && this._metricDataPoints.Count > 0; 
        }

    }
}