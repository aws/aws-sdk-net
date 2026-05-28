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
    /// Container for the parameters to the CreateAdvancedPromptOptimizationJob operation.
    /// Creates an asynchronous batch job for advanced prompt optimization.
    /// </summary>
    public partial class CreateAdvancedPromptOptimizationJobRequest : AmazonBedrockRequest
    {
        private string _clientToken;
        private string _encryptionKeyArn;
        private AdvancedPromptOptimizationInputConfig _inputConfig;
        private string _jobDescription;
        private string _jobName;
        private List<ModelConfiguration> _modelConfigurations = AWSConfigs.InitializeCollections ? new List<ModelConfiguration>() : null;
        private AdvancedPromptOptimizationOutputConfig _outputConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotency token for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// KMS key ARN for encrypting output data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Input data configuration for the advanced prompt optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AdvancedPromptOptimizationInputConfig InputConfig
        {
            get { return this._inputConfig; }
            set { this._inputConfig = value; }
        }

        // Check to see if InputConfig property is set
        internal bool IsSetInputConfig()
        {
            return this._inputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobDescription. 
        /// <para>
        /// Description of the advanced prompt optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string JobDescription
        {
            get { return this._jobDescription; }
            set { this._jobDescription = value; }
        }

        // Check to see if JobDescription property is set
        internal bool IsSetJobDescription()
        {
            return this._jobDescription != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// Name of the advanced prompt optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelConfigurations. 
        /// <para>
        /// Model configurations for advanced prompt optimization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<ModelConfiguration> ModelConfigurations
        {
            get { return this._modelConfigurations; }
            set { this._modelConfigurations = value; }
        }

        // Check to see if ModelConfigurations property is set
        internal bool IsSetModelConfigurations()
        {
            return this._modelConfigurations != null && (this._modelConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Output data configuration for the advanced prompt optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AdvancedPromptOptimizationOutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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