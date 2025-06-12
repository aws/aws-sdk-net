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
    /// Specifies the custom metrics, how tasks will be rated, the flow definition ARN, and
    /// your custom prompt datasets. Model evaluation jobs use human workers <i>only</i> support
    /// the use of custom prompt datasets. To learn more about custom prompt datasets and
    /// the required format, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-evaluation-prompt-datasets-custom.html">Custom
    /// prompt datasets</a>.
    /// 
    ///  
    /// <para>
    /// When you create custom metrics in <c>HumanEvaluationCustomMetric</c> you must specify
    /// the metric's <c>name</c>. The list of <c>names</c> specified in the <c>HumanEvaluationCustomMetric</c>
    /// array, must match the <c>metricNames</c> array of strings specified in <c>EvaluationDatasetMetricConfig</c>.
    /// For example, if in the <c>HumanEvaluationCustomMetric</c> array your specified the
    /// names <c>"accuracy", "toxicity", "readability"</c> as custom metrics <i>then</i> the
    /// <c>metricNames</c> array would need to look like the following <c>["accuracy", "toxicity",
    /// "readability"]</c> in <c>EvaluationDatasetMetricConfig</c>.
    /// </para>
    /// </summary>
    public partial class HumanEvaluationConfig
    {
        private List<HumanEvaluationCustomMetric> _customMetrics = AWSConfigs.InitializeCollections ? new List<HumanEvaluationCustomMetric>() : null;
        private List<EvaluationDatasetMetricConfig> _datasetMetricConfigs = AWSConfigs.InitializeCollections ? new List<EvaluationDatasetMetricConfig>() : null;
        private HumanWorkflowConfig _humanWorkflowConfig;

        /// <summary>
        /// Gets and sets the property CustomMetrics. 
        /// <para>
        /// A <c>HumanEvaluationCustomMetric</c> object. It contains the names the metrics, how
        /// the metrics are to be evaluated, an optional description.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<HumanEvaluationCustomMetric> CustomMetrics
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
        /// Gets and sets the property DatasetMetricConfigs. 
        /// <para>
        /// Use to specify the metrics, task, and prompt dataset to be used in your model evaluation
        /// job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<EvaluationDatasetMetricConfig> DatasetMetricConfigs
        {
            get { return this._datasetMetricConfigs; }
            set { this._datasetMetricConfigs = value; }
        }

        // Check to see if DatasetMetricConfigs property is set
        internal bool IsSetDatasetMetricConfigs()
        {
            return this._datasetMetricConfigs != null && (this._datasetMetricConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HumanWorkflowConfig. 
        /// <para>
        /// The parameters of the human workflow.
        /// </para>
        /// </summary>
        public HumanWorkflowConfig HumanWorkflowConfig
        {
            get { return this._humanWorkflowConfig; }
            set { this._humanWorkflowConfig = value; }
        }

        // Check to see if HumanWorkflowConfig property is set
        internal bool IsSetHumanWorkflowConfig()
        {
            return this._humanWorkflowConfig != null;
        }

    }
}