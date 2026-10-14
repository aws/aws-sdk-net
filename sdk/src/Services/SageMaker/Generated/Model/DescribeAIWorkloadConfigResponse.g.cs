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
    /// This is the response object from the DescribeAIWorkloadConfig operation.
    /// </summary>
    public partial class DescribeAIWorkloadConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AIWorkloadConfigArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AI workload configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string AIWorkloadConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the AIWorkloadConfigArn property is set.
        /// </summary>
        internal bool IsSetAIWorkloadConfigArn() => this.AIWorkloadConfigArn != null;

        /// <summary>
        /// Gets and sets the property AIWorkloadConfigName. 
        /// <para>
        /// The name of the AI workload configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string AIWorkloadConfigName { get; set; }

        /// <summary>
        /// Checks to see if the AIWorkloadConfigName property is set.
        /// </summary>
        internal bool IsSetAIWorkloadConfigName() => this.AIWorkloadConfigName != null;

        /// <summary>
        /// Gets and sets the property AIWorkloadConfigs. 
        /// <para>
        /// The benchmark tool configuration and workload specification.
        /// </para>
        /// </summary>
        public AIWorkloadConfigs AIWorkloadConfigs { get; set; }

        /// <summary>
        /// Checks to see if the AIWorkloadConfigs property is set.
        /// </summary>
        internal bool IsSetAIWorkloadConfigs() => this.AIWorkloadConfigs != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that indicates when the AI workload configuration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetConfig. 
        /// <para>
        /// The dataset configuration for the workload.
        /// </para>
        /// </summary>
        public AIDatasetConfig DatasetConfig { get; set; }

        /// <summary>
        /// Checks to see if the DatasetConfig property is set.
        /// </summary>
        internal bool IsSetDatasetConfig() => this.DatasetConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the AI workload configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
