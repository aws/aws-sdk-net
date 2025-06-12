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
    /// Container for the parameters to the CreateModelCopyJob operation.
    /// Copies a model to another region so that it can be used there. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/copy-model.html">Copy
    /// models to be used in other regions</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
    /// Bedrock User Guide</a>.
    /// </summary>
    public partial class CreateModelCopyJobRequest : AmazonBedrockRequest
    {
        private string _clientRequestToken;
        private string _modelKmsKeyId;
        private string _sourceModelArn;
        private string _targetModelName;
        private List<Tag> _targetModelTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        /// Gets and sets the property ModelKmsKeyId. 
        /// <para>
        /// The ARN of the KMS key that you use to encrypt the model copy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ModelKmsKeyId
        {
            get { return this._modelKmsKeyId; }
            set { this._modelKmsKeyId = value; }
        }

        // Check to see if ModelKmsKeyId property is set
        internal bool IsSetModelKmsKeyId()
        {
            return this._modelKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model to be copied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string SourceModelArn
        {
            get { return this._sourceModelArn; }
            set { this._sourceModelArn = value; }
        }

        // Check to see if SourceModelArn property is set
        internal bool IsSetSourceModelArn()
        {
            return this._sourceModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetModelName. 
        /// <para>
        /// A name for the copied model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string TargetModelName
        {
            get { return this._targetModelName; }
            set { this._targetModelName = value; }
        }

        // Check to see if TargetModelName property is set
        internal bool IsSetTargetModelName()
        {
            return this._targetModelName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetModelTags. 
        /// <para>
        /// Tags to associate with the target model. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/tagging.html">Tag
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
        public List<Tag> TargetModelTags
        {
            get { return this._targetModelTags; }
            set { this._targetModelTags = value; }
        }

        // Check to see if TargetModelTags property is set
        internal bool IsSetTargetModelTags()
        {
            return this._targetModelTags != null && (this._targetModelTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}