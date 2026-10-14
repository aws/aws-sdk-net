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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Shows the latest objective metric emitted by a training job that was launched by a
    /// hyperparameter tuning job. You define the objective metric in the <c>HyperParameterTuningJobObjective</c>
    /// parameter of <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html">HyperParameterTuningJobConfig</a>.
    /// </summary>
    public partial class FinalHyperParameterTuningJobObjectiveMetric
    {
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
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Select if you want to minimize or maximize the objective metric during hyperparameter
        /// tuning. 
        /// </para>
        /// </summary>
        public HyperParameterTuningJobObjectiveType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the objective metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public float? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
