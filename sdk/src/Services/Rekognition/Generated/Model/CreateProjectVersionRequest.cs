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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProjectVersion operation.
    /// Creates a new version of a model and begins training. Models are managed as part of
    /// an Amazon Rekognition Custom Labels project. You can specify one training dataset
    /// and one testing dataset. The response from <code>CreateProjectVersion</code> is an
    /// Amazon Resource Name (ARN) for the version of the model. 
    /// 
    ///  
    /// <para>
    /// Training takes a while to complete. You can get the current status by calling <a>DescribeProjectVersions</a>.
    /// </para>
    ///  
    /// <para>
    /// Once training has successfully completed, call <a>DescribeProjectVersions</a> to get
    /// the training results and evaluate the model. 
    /// </para>
    ///  
    /// <para>
    /// After evaluating the model, you start the model by calling <a>StartProjectVersion</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:CreateProjectVersion</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreateProjectVersionRequest : AmazonRekognitionRequest
    {
        private string _kmsKeyId;
        private OutputConfig _outputConfig;
        private string _projectArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private TestingData _testingData;
        private TrainingData _trainingData;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier for your AWS Key Management Service (AWS KMS) customer master key (CMK).
        /// You can supply the Amazon Resource Name (ARN) of your CMK, the ID of your CMK, an
        /// alias for your CMK, or an alias ARN. The key is used to encrypt training and test
        /// images copied into the service for model training. Your source images are unaffected.
        /// The key is also used to encrypt training results and manifest files written to the
        /// output Amazon S3 bucket (<code>OutputConfig</code>).
        /// </para>
        ///  
        /// <para>
        /// If you choose to use your own CMK, you need the following permissions on the CMK.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// kms:CreateGrant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:DescribeKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:GenerateDataKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:Decrypt
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a value for <code>KmsKeyId</code>, images copied into the service
        /// are encrypted using a key that AWS owns and manages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The Amazon S3 bucket location to store the results of training. The S3 bucket can
        /// be in any AWS account as long as the caller has <code>s3:PutObject</code> permissions
        /// on the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputConfig OutputConfig
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
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The ARN of the Amazon Rekognition Custom Labels project that manages the model that
        /// you want to train.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A set of tags (key-value pairs) that you want to attach to the model. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property TestingData. 
        /// <para>
        /// The dataset to use for testing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestingData TestingData
        {
            get { return this._testingData; }
            set { this._testingData = value; }
        }

        // Check to see if TestingData property is set
        internal bool IsSetTestingData()
        {
            return this._testingData != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingData. 
        /// <para>
        /// The dataset to use for training. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingData TrainingData
        {
            get { return this._trainingData; }
            set { this._trainingData = value; }
        }

        // Check to see if TrainingData property is set
        internal bool IsSetTrainingData()
        {
            return this._trainingData != null;
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// A name for the version of the model. This value must be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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

    }
}