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
    /// Container for the parameters to the CreateAdvancedPromptOptimizationJob operation.
    /// Creates an advanced prompt optimization job. The job optimizes your prompt templates
    /// for specific models using your evaluation dataset and criteria.
    /// </summary>
    public partial class CreateAdvancedPromptOptimizationJobRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used for encrypting the output data.
        /// If not specified, the output is encrypted with an Amazon-owned KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Specifies the S3 location of your JSONL input file containing prompt templates and
        /// evaluation samples.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AdvancedPromptOptimizationInputConfig InputConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputConfig property is set.
        /// </summary>
        internal bool IsSetInputConfig() => this.InputConfig != null;

        /// <summary>
        /// Gets and sets the property JobDescription. 
        /// <para>
        /// A description of the advanced prompt optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string JobDescription { get; set; }

        /// <summary>
        /// Checks to see if the JobDescription property is set.
        /// </summary>
        internal bool IsSetJobDescription() => this.JobDescription != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// A name for the advanced prompt optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property ModelConfigurations. 
        /// <para>
        /// A list of model configurations specifying the target models for prompt optimization.
        /// You can specify up to 5 models.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<ModelConfiguration> ModelConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ModelConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ModelConfigurations property is set.
        /// </summary>
        internal bool IsSetModelConfigurations() => this.ModelConfigurations != null && (this.ModelConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Specifies the S3 location where optimization results will be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AdvancedPromptOptimizationOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the advanced prompt optimization job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
