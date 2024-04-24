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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Defines the objective metric for a hyperparameter tuning job. Hyperparameter tuning
    /// uses the value of this metric to evaluate the training jobs it launches, and returns
    /// the training job that results in either the highest or lowest value for this metric,
    /// depending on the value you specify for the <c>Type</c> parameter. If you want to define
    /// a custom objective metric, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-define-metrics-variables.html">Define
    /// metrics and environment variables</a>.
    /// </summary>
    public partial class HyperParameterTuningJobObjective
    {
        private string _metricName;
        private HyperParameterTuningJobObjectiveType _type;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric to use for the objective metric.
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
        /// Whether to minimize or maximize the objective metric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}