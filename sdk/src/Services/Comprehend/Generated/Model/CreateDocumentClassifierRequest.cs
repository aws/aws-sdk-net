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
    /// Container for the parameters to the CreateDocumentClassifier operation.
    /// Creates a new document classifier that you can use to categorize documents. To create
    /// a classifier, you provide a set of training documents that labeled with the categories
    /// that you want to use. After the classifier is trained you can use it to categorize
    /// a set of labeled documents into the categories. For more information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-document-classification.html">Document
    /// Classification</a> in the Comprehend Developer Guide.
    /// </summary>
    public partial class CreateDocumentClassifierRequest : AmazonComprehendRequest
    {
        private string _clientRequestToken;
        private string _dataAccessRoleArn;
        private string _documentClassifierName;
        private DocumentClassifierInputDataConfig _inputDataConfig;
        private LanguageCode _languageCode;
        private DocumentClassifierMode _mode;
        private string _modelKmsKeyId;
        private string _modelPolicy;
        private DocumentClassifierOutputDataConfig _outputDataConfig;
        private List<Tag> _tags = new List<Tag>();
        private string _versionName;
        private string _volumeKmsKeyId;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for the request. If you don't set the client request token, Amazon
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
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that grants Amazon Comprehend read access to your input data.
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
        /// Gets and sets the property DocumentClassifierName. 
        /// <para>
        /// The name of the document classifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string DocumentClassifierName
        {
            get { return this._documentClassifierName; }
            set { this._documentClassifierName = value; }
        }

        // Check to see if DocumentClassifierName property is set
        internal bool IsSetDocumentClassifierName()
        {
            return this._documentClassifierName != null;
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Specifies the format and location of the input data for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DocumentClassifierInputDataConfig InputDataConfig
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
        /// The language of the input documents. You can specify any of the languages supported
        /// by Amazon Comprehend. All documents must be in the same language.
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
        /// Gets and sets the property Mode. 
        /// <para>
        /// Indicates the mode in which the classifier will be trained. The classifier can be
        /// trained in multi-class mode, which identifies one and only one class for each document,
        /// or multi-label mode, which identifies one or more labels for each document. In multi-label
        /// mode, multiple labels for an individual document are separated by a delimiter. The
        /// default delimiter between labels is a pipe (|).
        /// </para>
        /// </summary>
        public DocumentClassifierMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property ModelKmsKeyId. 
        /// <para>
        /// ID for the AWS Key Management Service (KMS) key that Amazon Comprehend uses to encrypt
        /// trained custom models. The ModelKmsKeyId can be either of the following formats:
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
        /// The resource-based policy to attach to your custom document classifier model. You
        /// can use this policy to allow another AWS account to import your custom model.
        /// </para>
        ///  
        /// <para>
        /// Provide your policy as a JSON body that you enter as a UTF-8 encoded string without
        /// line breaks. To provide valid JSON, enclose the attribute names and values in double
        /// quotes. If the JSON body is also enclosed in double quotes, then you must escape the
        /// double quotes that are inside the policy:
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
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Enables the addition of output results configuration parameters for custom classifier
        /// jobs.
        /// </para>
        /// </summary>
        public DocumentClassifierOutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the document classifier. A tag is a key-value pair that adds
        /// as a metadata to a resource used by Amazon Comprehend. For example, a tag with "Sales"
        /// as the key might be added to a resource to indicate its use by the sales department.
        /// 
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
        /// The version name given to the newly created classifier. Version names can have a maximum
        /// of 256 characters. Alphanumeric characters, hyphens (-) and underscores (_) are allowed.
        /// The version name must be unique among all models with the same classifier name in
        /// the account/AWS Region.
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
        /// the resources you are using for your custom classifier. For more information, see
        /// <a href="https://docs.aws.amazon.com/vpc/latest/userguide/what-is-amazon-vpc.html">Amazon
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