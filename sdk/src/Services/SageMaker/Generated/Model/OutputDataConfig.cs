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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides information about how to store model training results (model artifacts).
    /// </summary>
    public partial class OutputDataConfig
    {
        private OutputCompressionType _compressionType;
        private string _kmsKeyId;
        private string _s3OutputPath;

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// The model output compression type. Select <c>None</c> to output an uncompressed model,
        /// recommended for large model outputs. Defaults to gzip.
        /// </para>
        /// </summary>
        public OutputCompressionType CompressionType
        {
            get { return this._compressionType; }
            set { this._compressionType = value; }
        }

        // Check to see if CompressionType property is set
        internal bool IsSetCompressionType()
        {
            return this._compressionType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that
        /// SageMaker uses to encrypt the model artifacts at rest using Amazon S3 server-side
        /// encryption. The <c>KmsKeyId</c> can be any of the following formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// // KMS Key ID
        /// </para>
        ///  
        /// <para>
        ///  <c>"1234abcd-12ab-34cd-56ef-1234567890ab"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // Amazon Resource Name (ARN) of a KMS Key
        /// </para>
        ///  
        /// <para>
        ///  <c>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // KMS Key Alias
        /// </para>
        ///  
        /// <para>
        ///  <c>"alias/ExampleAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // Amazon Resource Name (ARN) of a KMS Key Alias
        /// </para>
        ///  
        /// <para>
        ///  <c>"arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias"</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you use a KMS key ID or an alias of your KMS key, the SageMaker execution role
        /// must include permissions to call <c>kms:Encrypt</c>. If you don't provide a KMS key
        /// ID, SageMaker uses the default KMS key for Amazon S3 for your role's account. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/UsingKMSEncryption.html">KMS-Managed
        /// Encryption Keys</a> in the <i>Amazon Simple Storage Service Developer Guide</i>. If
        /// the output data is stored in Amazon S3 Express One Zone, it is encrypted with server-side
        /// encryption with Amazon S3 managed keys (SSE-S3). KMS key is not supported for Amazon
        /// S3 Express One Zone
        /// </para>
        ///  
        /// <para>
        /// The KMS key policy must grant permission to the IAM role that you specify in your
        /// <c>CreateTrainingJob</c>, <c>CreateTransformJob</c>, or <c>CreateHyperParameterTuningJob</c>
        /// requests. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Using
        /// Key Policies in Amazon Web Services KMS</a> in the <i>Amazon Web Services Key Management
        /// Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Identifies the S3 path where you want SageMaker to store the model artifacts. For
        /// example, <c>s3://bucket-name/key-name-prefix</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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