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
    /// Container for the parameters to the CreateProvisionedModelThroughput operation.
    /// Creates dedicated throughput for a base or custom model with the model units and for
    /// the duration that you specify. For pricing details, see <a href="http://aws.amazon.com/bedrock/pricing/">Amazon
    /// Bedrock Pricing</a>. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
    /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
    /// Bedrock User Guide</a>.
    /// </summary>
    public partial class CreateProvisionedModelThroughputRequest : AmazonBedrockRequest
    {
        private string _clientRequestToken;
        private CommitmentDuration _commitmentDuration;
        private string _modelId;
        private int? _modelUnits;
        private string _provisionedModelName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the Amazon S3 User Guide.
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
        /// The commitment duration requested for the Provisioned Throughput. Billing occurs hourly
        /// and is discounted for longer commitment terms. To request a no-commit Provisioned
        /// Throughput, omit this field.
        /// </para>
        ///  
        /// <para>
        /// Custom models support all levels of commitment. To see which base models support no
        /// commitment, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/pt-supported.html">Supported
        /// regions and models for Provisioned Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a> 
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
        /// The Amazon Resource Name (ARN) or name of the model to associate with this Provisioned
        /// Throughput. For a list of models for which you can purchase Provisioned Throughput,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-ids.html#prov-throughput-models">Amazon
        /// Bedrock model IDs for purchasing Provisioned Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
        /// Number of model units to allocate. A model unit delivers a specific throughput level
        /// for the specified model. The throughput level of a model unit specifies the total
        /// number of input and output tokens that it can process and generate within a span of
        /// one minute. By default, your account has no model units for purchasing Provisioned
        /// Throughputs with commitment. You must first visit the <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=service-limit-increase">Amazon
        /// Web Services support center</a> to request MUs.
        /// </para>
        ///  
        /// <para>
        /// For model unit quotas, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/quotas.html#prov-thru-quotas">Provisioned
        /// Throughput quotas</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about what an MU specifies, contact your Amazon Web Services
        /// account manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? ModelUnits
        {
            get { return this._modelUnits; }
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
        /// The name for this Provisioned Throughput.
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
        /// Tags to associate with this Provisioned Throughput.
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