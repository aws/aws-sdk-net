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
    /// Defines the configuration of custom metrics to be used in an evaluation job. To learn
    /// more about using custom metrics in Amazon Bedrock evaluation jobs, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-evaluation-custom-metrics-prompt-formats.html">Create
    /// a prompt for a custom metrics (LLM-as-a-judge model evaluations)</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-evaluation-custom-metrics-prompt-formats.html">Create
    /// a prompt for a custom metrics (RAG evaluations)</a>.
    /// </summary>
    public partial class AutomatedEvaluationCustomMetricConfig
    {
        private List<AutomatedEvaluationCustomMetricSource> _customMetrics = AWSConfigs.InitializeCollections ? new List<AutomatedEvaluationCustomMetricSource>() : null;
        private CustomMetricEvaluatorModelConfig _evaluatorModelConfig;

        /// <summary>
        /// Gets and sets the property CustomMetrics. 
        /// <para>
        /// Defines a list of custom metrics to be used in an Amazon Bedrock evaluation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<AutomatedEvaluationCustomMetricSource> CustomMetrics
        {
            get { return this._customMetrics; }
            set { this._customMetrics = value; }
        }

        // Check to see if CustomMetrics property is set
        internal bool IsSetCustomMetrics()
        {
            return this._customMetrics != null && (this._customMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluatorModelConfig. 
        /// <para>
        /// Configuration of the evaluator model you want to use to evaluate custom metrics in
        /// an Amazon Bedrock evaluation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomMetricEvaluatorModelConfig EvaluatorModelConfig
        {
            get { return this._evaluatorModelConfig; }
            set { this._evaluatorModelConfig = value; }
        }

        // Check to see if EvaluatorModelConfig property is set
        internal bool IsSetEvaluatorModelConfig()
        {
            return this._evaluatorModelConfig != null;
        }

    }
}