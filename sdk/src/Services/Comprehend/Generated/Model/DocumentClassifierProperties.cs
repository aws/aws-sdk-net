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
    /// Provides information about a document classifier.
    /// </summary>
    public partial class DocumentClassifierProperties
    {
        private ClassifierMetadata _classifierMetadata;
        private string _dataAccessRoleArn;
        private string _documentClassifierArn;
        private DateTime? _endTime;
        private DocumentClassifierInputDataConfig _inputDataConfig;
        private LanguageCode _languageCode;
        private string _message;
        private DocumentClassifierMode _mode;
        private string _modelKmsKeyId;
        private DocumentClassifierOutputDataConfig _outputDataConfig;
        private string _sourceModelArn;
        private ModelStatus _status;
        private DateTime? _submitTime;
        private DateTime? _trainingEndTime;
        private DateTime? _trainingStartTime;
        private string _versionName;
        private string _volumeKmsKeyId;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property ClassifierMetadata. 
        /// <para>
        /// Information about the document classifier, including the number of documents used
        /// for training the classifier, the number of documents used for test the classifier,
        /// and an accuracy rating.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ClassifierMetadata ClassifierMetadata
        {
            get { return this._classifierMetadata; }
            set { this._classifierMetadata = value; }
        }

        // Check to see if ClassifierMetadata property is set
        internal bool IsSetClassifierMetadata()
        {
            return this._classifierMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Management (IAM) role that
        /// grants Amazon Comprehend read access to your input data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property DocumentClassifierArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the document classifier.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DocumentClassifierArn
        {
            get { return this._documentClassifierArn; }
            set { this._documentClassifierArn = value; }
        }

        // Check to see if DocumentClassifierArn property is set
        internal bool IsSetDocumentClassifierArn()
        {
            return this._documentClassifierArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that training the document classifier completed.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The input data configuration that you supplied when you created the document classifier
        /// for training.
        /// </para>
        /// </summary>
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
        /// The language code for the language of the documents that the classifier was trained
        /// on.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Message. 
        /// <para>
        /// Additional information about the status of the classifier.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Indicates the mode in which the specific classifier was trained. This also indicates
        /// the format of input documents and the format of the confusion matrix. Each classifier
        /// can only be trained in one mode and this cannot be changed once the classifier is
        /// trained.
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
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        ///  Provides output results configuration parameters for custom classifier jobs.
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
        /// Gets and sets the property SourceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source model. This model was imported from a
        /// different AWS account to create the document classifier model in your AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the document classifier. If the status is <code>TRAINED</code> the classifier
        /// is ready to use. If the status is <code>FAILED</code> you can see additional information
        /// about why the classifier wasn't trained in the <code>Message</code> field.
        /// </para>
        /// </summary>
        public ModelStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        /// The time that the document classifier was submitted for training.
        /// </para>
        /// </summary>
        public DateTime SubmitTime
        {
            get { return this._submitTime.GetValueOrDefault(); }
            set { this._submitTime = value; }
        }

        // Check to see if SubmitTime property is set
        internal bool IsSetSubmitTime()
        {
            return this._submitTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingEndTime. 
        /// <para>
        /// The time that training of the document classifier was completed. Indicates the time
        /// when the training completes on documentation classifiers. You are billed for the time
        /// interval between this time and the value of TrainingStartTime.
        /// </para>
        /// </summary>
        public DateTime TrainingEndTime
        {
            get { return this._trainingEndTime.GetValueOrDefault(); }
            set { this._trainingEndTime = value; }
        }

        // Check to see if TrainingEndTime property is set
        internal bool IsSetTrainingEndTime()
        {
            return this._trainingEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingStartTime. 
        /// <para>
        /// Indicates the time when the training starts on documentation classifiers. You are
        /// billed for the time interval between this time and the value of TrainingEndTime. 
        /// </para>
        /// </summary>
        public DateTime TrainingStartTime
        {
            get { return this._trainingStartTime.GetValueOrDefault(); }
            set { this._trainingStartTime = value; }
        }

        // Check to see if TrainingStartTime property is set
        internal bool IsSetTrainingStartTime()
        {
            return this._trainingStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The version name that you assigned to the document classifier.
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
        ///  Configuration parameters for a private Virtual Private Cloud (VPC) containing the
        /// resources you are using for your custom classifier. For more information, see <a href="https://docs.aws.amazon.com/vppc/latest/userguide/what-is-amazon-vpc.html">Amazon
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