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
    /// Use to specify a automatic model evaluation job. The <c>EvaluationDatasetMetricConfig</c>
    /// object is used to specify the prompt datasets, task type, and metric names.
    /// </summary>
    public partial class AutomatedEvaluationConfig
    {
        private List<EvaluationDatasetMetricConfig> _datasetMetricConfigs = AWSConfigs.InitializeCollections ? new List<EvaluationDatasetMetricConfig>() : null;

        /// <summary>
        /// Gets and sets the property DatasetMetricConfigs. 
        /// <para>
        /// Specifies the required elements for an automatic model evaluation job.
        /// </para>
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

    }
}