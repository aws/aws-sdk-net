/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Shows the final value for the objective metric for a training job that was launched
    /// by a hyperparameter tuning job. You define the objective metric in the <code>HyperParameterTuningJobObjective</code>
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
        /// The name of the objective metric.
        /// </para>
        /// </summary>
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
        /// Whether to minimize or maximize the objective metric. Valid values are Minimize and
        /// Maximize.
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