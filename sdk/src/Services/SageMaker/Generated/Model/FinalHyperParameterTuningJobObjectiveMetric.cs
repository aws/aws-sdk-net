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
    /// Shows the latest objective metric emitted by a training job that was launched by a
    /// hyperparameter tuning job. You define the objective metric in the <code>HyperParameterTuningJobObjective</code>
    /// parameter of <a>HyperParameterTuningJobConfig</a>.
    /// </summary>
    public partial class FinalHyperParameterTuningJobObjectiveMetric
    {
        private string _metricName;
        private HyperParameterTuningJobObjectiveType _type;
        private float? _value;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the objective metric. For SageMaker built-in algorithms, metrics are defined
        /// per algorithm. See the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/xgboost-tuning.html">metrics
        /// for XGBoost</a> as an example. You can also use a custom algorithm for training and
        /// define your own metrics. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-define-metrics-variables.html">Define
        /// metrics and environment variables</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Select if you want to minimize or maximize the objective metric during hyperparameter
        /// tuning. 
        /// </para>
        /// </summary>
        public HyperParameterTuningJobObjectiveType Type
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the objective metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public float Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}