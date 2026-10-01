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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// The configuration details of an automated evaluation job. The <c>EvaluationDatasetMetricConfig</c>
    /// object is used to specify the prompt datasets, task type, and metric names.
    /// </summary>
    public partial class AutomatedEvaluationConfig
    {
        /// <summary>
        /// Gets and sets the property CustomMetricConfig. 
        /// <para>
        /// Defines the configuration of custom metrics to be used in an evaluation job.
        /// </para>
        /// </summary>
        public AutomatedEvaluationCustomMetricConfig CustomMetricConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomMetricConfig property is set.
        /// </summary>
        internal bool IsSetCustomMetricConfig() => this.CustomMetricConfig != null;

        /// <summary>
        /// Gets and sets the property DatasetMetricConfigs. 
        /// <para>
        /// Configuration details of the prompt datasets and metrics you want to use for your
        /// evaluation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<EvaluationDatasetMetricConfig> DatasetMetricConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluationDatasetMetricConfig>() : null;

        /// <summary>
        /// Checks to see if the DatasetMetricConfigs property is set.
        /// </summary>
        internal bool IsSetDatasetMetricConfigs() => this.DatasetMetricConfigs != null && (this.DatasetMetricConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluatorModelConfig. 
        /// <para>
        /// Contains the evaluator model configuration details. <c>EvaluatorModelConfig</c> is
        /// required for evaluation jobs that use a knowledge base or in model evaluation job
        /// that use a model as judge. This model computes all evaluation related metrics.
        /// </para>
        /// </summary>
        public EvaluatorModelConfig EvaluatorModelConfig { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorModelConfig property is set.
        /// </summary>
        internal bool IsSetEvaluatorModelConfig() => this.EvaluatorModelConfig != null;
    }
}
