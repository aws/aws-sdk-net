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
    /// Container for the parameters to the CreateInferenceProfile operation.
    /// Creates an application inference profile to track metrics and costs when invoking
    /// a model. To create an application inference profile for a foundation model in one
    /// region, specify the ARN of the model in that region. To create an application inference
    /// profile for a foundation model across multiple regions, specify the ARN of the system-defined
    /// inference profile that contains the regions that you want to route requests to. For
    /// more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
    /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
    /// Amazon Bedrock User Guide.
    /// </summary>
    public partial class CreateInferenceProfileRequest : AmazonBedrockRequest
    {
        private string _clientRequestToken;
        private string _description;
        private string _inferenceProfileName;
        private InferenceProfileModelSource _modelSource;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the inference profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceProfileName. 
        /// <para>
        /// A name for the inference profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string InferenceProfileName
        {
            get { return this._inferenceProfileName; }
            set { this._inferenceProfileName = value; }
        }

        // Check to see if InferenceProfileName property is set
        internal bool IsSetInferenceProfileName()
        {
            return this._inferenceProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelSource. 
        /// <para>
        /// The foundation model or system-defined inference profile that the inference profile
        /// will track metrics and costs for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InferenceProfileModelSource ModelSource
        {
            get { return this._modelSource; }
            set { this._modelSource = value; }
        }

        // Check to see if ModelSource property is set
        internal bool IsSetModelSource()
        {
            return this._modelSource != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects, each of which contains a tag and its value. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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