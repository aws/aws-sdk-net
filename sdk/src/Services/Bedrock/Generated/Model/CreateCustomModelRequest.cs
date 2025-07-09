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
    /// Container for the parameters to the CreateCustomModel operation.
    /// Creates a new custom model in Amazon Bedrock. After the model is active, you can use
    /// it for inference.
    /// 
    ///  
    /// <para>
    /// To use the model for inference, you must purchase Provisioned Throughput for it. You
    /// can't use On-demand inference with these custom models. For more information about
    /// Provisioned Throughput, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
    /// Throughput</a>.
    /// </para>
    ///  
    /// <para>
    /// The model appears in <c>ListCustomModels</c> with a <c>customizationType</c> of <c>imported</c>.
    /// To track the status of the new model, you use the <c>GetCustomModel</c> API operation.
    /// The model can be in the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Creating</c> - Initial state during validation and registration
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Active</c> - Model is ready for use in inference
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Failed</c> - Creation process encountered an error
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModel.html">GetCustomModel</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModels.html">ListCustomModels</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModel.html">DeleteCustomModel</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateCustomModelRequest : AmazonBedrockRequest
    {
        private string _clientRequestToken;
        private string _modelKmsKeyArn;
        private string _modelName;
        private ModelDataSource _modelSourceConfig;
        private List<Tag> _modelTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _roleArn;

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
        /// Gets and sets the property ModelKmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed KMS key to encrypt the custom
        /// model. If you don't provide a KMS key, Amazon Bedrock uses an Amazon Web Services-managed
        /// KMS key to encrypt the model. 
        /// </para>
        ///  
        /// <para>
        /// If you provide a customer managed KMS key, your Amazon Bedrock service role must have
        /// permissions to use it. For more information see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/encryption-import-model.html">Encryption
        /// of imported models</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ModelKmsKeyArn
        {
            get { return this._modelKmsKeyArn; }
            set { this._modelKmsKeyArn = value; }
        }

        // Check to see if ModelKmsKeyArn property is set
        internal bool IsSetModelKmsKeyArn()
        {
            return this._modelKmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// A unique name for the custom model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelSourceConfig. 
        /// <para>
        /// The data source for the model. The Amazon S3 URI in the model source must be for the
        /// Amazon-managed Amazon S3 bucket containing your model artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelDataSource ModelSourceConfig
        {
            get { return this._modelSourceConfig; }
            set { this._modelSourceConfig = value; }
        }

        // Check to see if ModelSourceConfig property is set
        internal bool IsSetModelSourceConfig()
        {
            return this._modelSourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ModelTags. 
        /// <para>
        /// A list of key-value pairs to associate with the custom model resource. You can use
        /// these tags to organize and identify your resources.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/tagging.html">Tagging
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
        public List<Tag> ModelTags
        {
            get { return this._modelTags; }
            set { this._modelTags = value; }
        }

        // Check to see if ModelTags property is set
        internal bool IsSetModelTags()
        {
            return this._modelTags != null && (this._modelTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM service role that Amazon Bedrock assumes
        /// to perform tasks on your behalf. This role must have permissions to access the Amazon
        /// S3 bucket containing your model artifacts and the KMS key (if specified). For more
        /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-import-iam-role.html">Setting
        /// up an IAM service role for importing models</a> in the Amazon Bedrock User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}