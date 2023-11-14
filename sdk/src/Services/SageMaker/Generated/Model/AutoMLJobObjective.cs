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
    /// Specifies a metric to minimize or maximize as the objective of an AutoML job.
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
        /// The list of available metrics supported by Autopilot and the default metric applied
        /// when you do not specify a metric name explicitly depend on the problem type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For tabular problem types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// List of available metrics: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Regression: <code>InferenceLatency</code>, <code>MAE</code>, <code>MSE</code>, <code>R2</code>,
        /// <code>RMSE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Binary classification: <code>Accuracy</code>, <code>AUC</code>, <code>BalancedAccuracy</code>,
        /// <code>F1</code>, <code>InferenceLatency</code>, <code>LogLoss</code>, <code>Precision</code>,
        /// <code>Recall</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Multiclass classification: <code>Accuracy</code>, <code>BalancedAccuracy</code>,
        /// <code>F1macro</code>, <code>InferenceLatency</code>, <code>LogLoss</code>, <code>PrecisionMacro</code>,
        /// <code>RecallMacro</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a description of each metric, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-metrics-validation.html#autopilot-metrics">Autopilot
        /// metrics for classification and regression</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Default objective metrics:
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
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// For image or text classification problem types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// List of available metrics: <code>Accuracy</code> 
        /// </para>
        ///  
        /// <para>
        /// For a description of each metric, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/text-classification-data-format-and-metric.html">Autopilot
        /// metrics for text and image classification</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Default objective metrics: <code>Accuracy</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For time-series forecasting problem types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// List of available metrics: <code>RMSE</code>, <code>wQL</code>, <code>Average wQL</code>,
        /// <code>MASE</code>, <code>MAPE</code>, <code>WAPE</code> 
        /// </para>
        ///  
        /// <para>
        /// For a description of each metric, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/timeseries-objective-metric.html">Autopilot
        /// metrics for time-series forecasting</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Default objective metrics: <code>AverageWeightedQuantileLoss</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For text generation problem types (LLMs fine-tuning): Fine-tuning language models
        /// in Autopilot does not require setting the <code>AutoMLJobObjective</code> field. Autopilot
        /// fine-tunes LLMs without requiring multiple candidates to be trained and evaluated.
        /// Instead, using your dataset, Autopilot directly fine-tunes your target model to enhance
        /// a default objective metric, the cross-entropy loss. After fine-tuning a language model,
        /// you can evaluate the quality of its generated text using different metrics. For a
        /// list of the available metrics, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-llms-finetuning-metrics.html">Metrics
        /// for fine-tuning LLMs in Autopilot</a>.
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