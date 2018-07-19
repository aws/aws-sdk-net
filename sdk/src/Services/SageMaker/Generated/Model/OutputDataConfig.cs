/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides information about how to store model training results (model artifacts).
    /// </summary>
    public partial class OutputDataConfig
    {
        private string _kmsKeyId;
        private string _s3OutputPath;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The AWS Key Management Service (AWS KMS) key that Amazon SageMaker uses to encrypt
        /// the model artifacts at rest using Amazon S3 server-side encryption. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't provide the KMS key ID, Amazon SageMaker uses the default KMS key for
        /// Amazon S3 for your role's account. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">KMS-Managed
        /// Encryption Keys</a> in Amazon Simple Storage Service developer guide.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  The KMS key policy must grant permission to the IAM role you specify in your <code>CreateTrainingJob</code>
        /// request. <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Using
        /// Key Policies in AWS KMS</a> in the AWS Key Management Service Developer Guide. 
        /// </para>
        ///  </note>
        /// </summary>
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
        /// Gets and sets the property S3OutputPath. 
        /// <para>
        /// Identifies the S3 path where you want Amazon SageMaker to store the model artifacts.
        /// For example, <code>s3://bucket-name/key-name-prefix</code>. 
        /// </para>
        /// </summary>
        public string S3OutputPath
        {
            get { return this._s3OutputPath; }
            set { this._s3OutputPath = value; }
        }

        // Check to see if S3OutputPath property is set
        internal bool IsSetS3OutputPath()
        {
            return this._s3OutputPath != null;
        }

    }
}