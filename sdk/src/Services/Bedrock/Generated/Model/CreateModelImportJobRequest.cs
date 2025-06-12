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
    /// Container for the parameters to the CreateModelImportJob operation.
    /// Creates a model import job to import model that you have customized in other environments,
    /// such as Amazon SageMaker. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
    /// a customized model</a>
    /// </summary>
    public partial class CreateModelImportJobRequest : AmazonBedrockRequest
    {
        private string _clientRequestToken;
        private string _importedModelKmsKeyId;
        private string _importedModelName;
        private List<Tag> _importedModelTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _jobName;
        private List<Tag> _jobTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ModelDataSource _modelDataSource;
        private string _roleArn;
        private VpcConfig _vpcConfig;

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
        /// Gets and sets the property ImportedModelKmsKeyId. 
        /// <para>
        /// The imported model is encrypted at rest using this key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ImportedModelKmsKeyId
        {
            get { return this._importedModelKmsKeyId; }
            set { this._importedModelKmsKeyId = value; }
        }

        // Check to see if ImportedModelKmsKeyId property is set
        internal bool IsSetImportedModelKmsKeyId()
        {
            return this._importedModelKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedModelName. 
        /// <para>
        /// The name of the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ImportedModelName
        {
            get { return this._importedModelName; }
            set { this._importedModelName = value; }
        }

        // Check to see if ImportedModelName property is set
        internal bool IsSetImportedModelName()
        {
            return this._importedModelName != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedModelTags. 
        /// <para>
        /// Tags to attach to the imported model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> ImportedModelTags
        {
            get { return this._importedModelTags; }
            set { this._importedModelTags = value; }
        }

        // Check to see if ImportedModelTags property is set
        internal bool IsSetImportedModelTags()
        {
            return this._importedModelTags != null && (this._importedModelTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property JobTags. 
        /// <para>
        /// Tags to attach to this import job. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> JobTags
        {
            get { return this._jobTags; }
            set { this._jobTags = value; }
        }

        // Check to see if JobTags property is set
        internal bool IsSetJobTags()
        {
            return this._jobTags != null && (this._jobTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelDataSource. 
        /// <para>
        /// The data source for the imported model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelDataSource ModelDataSource
        {
            get { return this._modelDataSource; }
            set { this._modelDataSource = value; }
        }

        // Check to see if ModelDataSource property is set
        internal bool IsSetModelDataSource()
        {
            return this._modelDataSource != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// VPC configuration parameters for the private Virtual Private Cloud (VPC) that contains
        /// the resources you are using for the import job.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}