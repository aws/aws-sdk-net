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
    /// Container for the parameters to the CreateProvisionedModelThroughput operation.
    /// Creates a provisioned throughput with dedicated capacity for a foundation model or
    /// a fine-tuned model.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
    /// throughput</a> in the Bedrock User Guide.
    /// </para>
    /// </summary>
    public partial class CreateProvisionedModelThroughputRequest : AmazonBedrockRequest
    {
        private string _clientRequestToken;
        private CommitmentDuration _commitmentDuration;
        private string _modelId;
        private int? _modelUnits;
        private string _provisionedModelName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique token value that you can provide. If this token matches a previous request,
        /// Bedrock ignores the request, but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property CommitmentDuration. 
        /// <para>
        /// Commitment duration requested for the provisioned throughput.
        /// </para>
        /// </summary>
        public CommitmentDuration CommitmentDuration
        {
            get { return this._commitmentDuration; }
            set { this._commitmentDuration = value; }
        }

        // Check to see if CommitmentDuration property is set
        internal bool IsSetCommitmentDuration()
        {
            return this._commitmentDuration != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// Name or ARN of the model to associate with this provisioned throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property ModelUnits. 
        /// <para>
        /// Number of model units to allocate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int ModelUnits
        {
            get { return this._modelUnits.GetValueOrDefault(); }
            set { this._modelUnits = value; }
        }

        // Check to see if ModelUnits property is set
        internal bool IsSetModelUnits()
        {
            return this._modelUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionedModelName. 
        /// <para>
        /// Unique name for this provisioned throughput.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ProvisionedModelName
        {
            get { return this._provisionedModelName; }
            set { this._provisionedModelName = value; }
        }

        // Check to see if ProvisionedModelName property is set
        internal bool IsSetProvisionedModelName()
        {
            return this._provisionedModelName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with this provisioned throughput.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}