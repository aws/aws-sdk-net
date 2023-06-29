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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies a metric to minimize or maximize as the objective of a job.
    /// </summary>
    public partial class AutoMLJobObjective
    {
        private AutoMLMetricEnum _metricName;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the objective metric used to measure the predictive quality of a machine
        /// learning system. During training, the model's parameters are updated iteratively to
        /// optimize its performance based on the feedback provided by the objective metric when
        /// evaluating the model on the validation dataset.
        /// </para>
        ///  
        /// <para>
        /// For the list of all available metrics supported by Autopilot, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-metrics-validation.html#autopilot-metrics">Autopilot
        /// metrics</a>.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a metric explicitly, the default behavior is to automatically
        /// use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For tabular problem types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Regression: <code>MSE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Binary classification: <code>F1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Multiclass classification: <code>Accuracy</code>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For image or text classification problem types: <code>Accuracy</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For time-series forecasting problem types: <code>AverageWeightedQuantileLoss</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoMLMetricEnum MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

    }
}