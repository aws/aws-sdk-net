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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEntityRecognizer operation.
    /// Creates an entity recognizer using submitted files. After your <code>CreateEntityRecognizer</code>
    /// request is submitted, you can check job status using the API.
    /// </summary>
    public partial class CreateEntityRecognizerRequest : AmazonComprehendRequest
    {
        private string _clientRequestToken;
        private string _dataAccessRoleArn;
        private EntityRecognizerInputDataConfig _inputDataConfig;
        private LanguageCode _languageCode;
        private string _modelKmsKeyId;
        private string _modelPolicy;
        private string _recognizerName;
        private List<Tag> _tags = new List<Tag>();
        private string _versionName;
        private string _volumeKmsKeyId;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        ///  A unique identifier for the request. If you don't set the client request token, Amazon
        /// Comprehend generates one.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Management (IAM) role that
        /// grants Amazon Comprehend read access to your input data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Specifies the format and location of the input data. The S3 bucket containing the
        /// input data must be located in the same region as the entity recognizer being created.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntityRecognizerInputDataConfig InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        ///  You can specify any of the following languages: English ("en"), Spanish ("es"), French
        /// ("fr"), Italian ("it"), German ("de"), or Portuguese ("pt"). If you plan to use this
        /// entity recognizer with PDF, Word, or image input files, you must specify English as
        /// the language. All training documents must be in the same language.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property ModelKmsKeyId. 
        /// <para>
        /// ID for the AWS Key Management Service (KMS) key that Amazon Comprehend uses to encrypt
        /// trained custom models. The ModelKmsKeyId can be either of the following formats
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS Key ID: <code>"1234abcd-12ab-34cd-56ef-1234567890ab"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS Key: <code>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property ModelPolicy. 
        /// <para>
        /// The JSON resource-based policy to attach to your custom entity recognizer model. You
        /// can use this policy to allow another AWS account to import your custom model.
        /// </para>
        ///  
        /// <para>
        /// Provide your JSON as a UTF-8 encoded string without line breaks. To provide valid
        /// JSON for your policy, enclose the attribute names and values in double quotes. If
        /// the JSON body is also enclosed in double quotes, then you must escape the double quotes
        /// that are inside the policy:
        /// </para>
        ///  
        /// <para>
        ///  <code>"{\"attribute\": \"value\", \"attribute\": [\"value\"]}"</code> 
        /// </para>
        ///  
        /// <para>
        /// To avoid escaping quotes, you can use single quotes to enclose the policy and double
        /// quotes to enclose the JSON names and values:
        /// </para>
        ///  
        /// <para>
        ///  <code>'{"attribute": "value", "attribute": ["value"]}'</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20000)]
        public string ModelPolicy
        {
            get { return this._modelPolicy; }
            set { this._modelPolicy = value; }
        }

        // Check to see if ModelPolicy property is set
        internal bool IsSetModelPolicy()
        {
            return this._modelPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property RecognizerName. 
        /// <para>
        /// The name given to the newly created recognizer. Recognizer names can be a maximum
        /// of 256 characters. Alphanumeric characters, hyphens (-) and underscores (_) are allowed.
        /// The name must be unique in the account/region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string RecognizerName
        {
            get { return this._recognizerName; }
            set { this._recognizerName = value; }
        }

        // Check to see if RecognizerName property is set
        internal bool IsSetRecognizerName()
        {
            return this._recognizerName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to be associated with the entity recognizer being created. A tag is a key-value
        /// pair that adds as a metadata to a resource used by Amazon Comprehend. For example,
        /// a tag with "Sales" as the key might be added to a resource to indicate its use by
        /// the sales department. 
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The version name given to the newly created recognizer. Version names can be a maximum
        /// of 256 characters. Alphanumeric characters, hyphens (-) and underscores (_) are allowed.
        /// The version name must be unique among all models with the same recognizer name in
        /// the account/ AWS Region.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeKmsKeyId. 
        /// <para>
        /// ID for the AWS Key Management Service (KMS) key that Amazon Comprehend uses to encrypt
        /// data on the storage volume attached to the ML compute instance(s) that process the
        /// analysis job. The VolumeKmsKeyId can be either of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS Key ID: <code>"1234abcd-12ab-34cd-56ef-1234567890ab"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS Key: <code>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string VolumeKmsKeyId
        {
            get { return this._volumeKmsKeyId; }
            set { this._volumeKmsKeyId = value; }
        }

        // Check to see if VolumeKmsKeyId property is set
        internal bool IsSetVolumeKmsKeyId()
        {
            return this._volumeKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// Configuration parameters for an optional private Virtual Private Cloud (VPC) containing
        /// the resources you are using for your custom entity recognizer. For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/what-is-amazon-vpc.html">Amazon
        /// VPC</a>. 
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