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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Defines the prompt datasets, built-in metric names and custom metric names, and the
    /// task type.
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
        /// The names of the metrics you want to use for your evaluation job.
        /// </para>
        ///  
        /// <para>
        /// For knowledge base evaluation jobs that evaluate retrieval only, valid values are
        /// "<c>Builtin.ContextRelevance</c>", "<c>Builtin.ContextCoverage</c>".
        /// </para>
        ///  
        /// <para>
        /// For knowledge base evaluation jobs that evaluate retrieval with response generation,
        /// valid values are "<c>Builtin.Correctness</c>", "<c>Builtin.Completeness</c>", "<c>Builtin.Helpfulness</c>",
        /// "<c>Builtin.LogicalCoherence</c>", "<c>Builtin.Faithfulness</c>", "<c>Builtin.Harmfulness</c>",
        /// "<c>Builtin.Stereotyping</c>", "<c>Builtin.Refusal</c>".
        /// </para>
        ///  
        /// <para>
        /// For automated model evaluation jobs, valid values are "<c>Builtin.Accuracy</c>", "<c>Builtin.Robustness</c>",
        /// and "<c>Builtin.Toxicity</c>". In model evaluation jobs that use a LLM as judge you
        /// can specify "<c>Builtin.Correctness</c>", "<c>Builtin.Completeness"</c>, "<c>Builtin.Faithfulness"</c>,
        /// "<c>Builtin.Helpfulness</c>", "<c>Builtin.Coherence</c>", "<c>Builtin.Relevance</c>",
        /// "<c>Builtin.FollowingInstructions</c>", "<c>Builtin.ProfessionalStyleAndTone</c>",
        /// You can also specify the following responsible AI related metrics only for model evaluation
        /// job that use a LLM as judge "<c>Builtin.Harmfulness</c>", "<c>Builtin.Stereotyping</c>",
        /// and "<c>Builtin.Refusal</c>".
        /// </para>
        ///  
        /// <para>
        /// For human-based model evaluation jobs, the list of strings must match the <c>name</c>
        /// parameter specified in <c>HumanEvaluationCustomMetric</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
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
        /// The the type of task you want to evaluate for your evaluation job. This applies only
        /// to model evaluation jobs and is ignored for knowledge base evaluation jobs.
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