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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Defines the built-in prompt datasets, built-in metric names and custom metric names,
    /// and the task type.
    /// </summary>
    public partial class EvaluationDatasetMetricConfig
    {
        private EvaluationDataset _dataset;
        private List<string> _metricNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EvaluationTaskType _taskType;

        /// <summary>
        /// Gets and sets the property Dataset. 
        /// <para>
        /// Specifies the prompt dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationDataset Dataset
        {
            get { return this._dataset; }
            set { this._dataset = value; }
        }

        // Check to see if Dataset property is set
        internal bool IsSetDataset()
        {
            return this._dataset != null;
        }

        /// <summary>
        /// Gets and sets the property MetricNames. 
        /// <para>
        /// The names of the metrics used. For automated model evaluation jobs valid values are
        /// <c>"Builtin.Accuracy"</c>, <c>"Builtin.Robustness"</c>, and <c>"Builtin.Toxicity"</c>.
        /// In human-based model evaluation jobs the array of strings must match the <c>name</c>
        /// parameter specified in <c>HumanEvaluationCustomMetric</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> MetricNames
        {
            get { return this._metricNames; }
            set { this._metricNames = value; }
        }

        // Check to see if MetricNames property is set
        internal bool IsSetMetricNames()
        {
            return this._metricNames != null && (this._metricNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskType. 
        /// <para>
        /// The task type you want the model to carry out. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public EvaluationTaskType TaskType
        {
            get { return this._taskType; }
            set { this._taskType = value; }
        }

        // Check to see if TaskType property is set
        internal bool IsSetTaskType()
        {
            return this._taskType != null;
        }

    }
}