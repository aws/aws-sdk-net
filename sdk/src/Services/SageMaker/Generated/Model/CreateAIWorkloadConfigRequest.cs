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
    /// Container for the parameters to the CreateAIWorkloadConfig operation.
    /// Creates a reusable AI workload configuration that defines datasets, data sources,
    /// and benchmark tool settings for consistent performance testing of generative AI inference
    /// deployments on Amazon SageMaker AI.
    /// </summary>
    public partial class CreateAIWorkloadConfigRequest : AmazonSageMakerRequest
    {
        private string _aiWorkloadConfigName;
        private AIWorkloadConfigs _aiWorkloadConfigs;
        private AIDatasetConfig _datasetConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AIWorkloadConfigName. 
        /// <para>
        /// The name of the AI workload configuration. The name must be unique within your Amazon
        /// Web Services account in the current Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string AIWorkloadConfigName
        {
            get { return this._aiWorkloadConfigName; }
            set { this._aiWorkloadConfigName = value; }
        }

        // Check to see if AIWorkloadConfigName property is set
        internal bool IsSetAIWorkloadConfigName()
        {
            return this._aiWorkloadConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property AIWorkloadConfigs. 
        /// <para>
        /// The benchmark tool configuration and workload specification. Provide the specification
        /// as an inline YAML or JSON string.
        /// </para>
        /// </summary>
        public AIWorkloadConfigs AIWorkloadConfigs
        {
            get { return this._aiWorkloadConfigs; }
            set { this._aiWorkloadConfigs = value; }
        }

        // Check to see if AIWorkloadConfigs property is set
        internal bool IsSetAIWorkloadConfigs()
        {
            return this._aiWorkloadConfigs != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetConfig. 
        /// <para>
        /// The dataset configuration for the workload. Specify input data channels with their
        /// data sources for benchmark workloads.
        /// </para>
        /// </summary>
        public AIDatasetConfig DatasetConfig
        {
            get { return this._datasetConfig; }
            set { this._datasetConfig = value; }
        }

        // Check to see if DatasetConfig property is set
        internal bool IsSetDatasetConfig()
        {
            return this._datasetConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to Amazon Web Services resources to help you categorize
        /// and organize them. Each tag consists of a key and a value, both of which you define.
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a> in the Amazon Web Services General Reference.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}