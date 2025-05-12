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
    /// Output configuration information for a labeling job.
    /// </summary>
    public partial class LabelingJobOutputConfig
    {
        private string _kmsKeyId;
        private string _s3OutputPath;
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service ID of the key used to encrypt the output
        /// data, if any.
        /// </para>
        ///  
        /// <para>
        /// If you provide your own KMS key ID, you must add the required permissions to your
        /// KMS key described in <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-security-permission.html#sms-security-kms-permissions">Encrypt
        /// Output Data and Storage Volume with Amazon Web Services KMS</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide a KMS key ID, Amazon SageMaker uses the default Amazon Web Services
        /// KMS key for Amazon S3 for your role's account to encrypt your output data.
        /// </para>
        ///  
        /// <para>
        /// If you use a bucket policy with an <c>s3:PutObject</c> permission that only allows
        /// objects with server-side encryption, set the condition key of <c>s3:x-amz-server-side-encryption</c>
        /// to <c>"aws:kms"</c>. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">KMS-Managed
        /// Encryption Keys</a> in the <i>Amazon Simple Storage Service Developer Guide.</i> 
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
        /// The Amazon S3 location to write output data.
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

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// An Amazon Simple Notification Service (Amazon SNS) output topic ARN. Provide a <c>SnsTopicArn</c>
        /// if you want to do real time chaining to another streaming job and receive an Amazon
        /// SNS notifications each time a data object is submitted by a worker.
        /// </para>
        ///  
        /// <para>
        /// If you provide an <c>SnsTopicArn</c> in <c>OutputConfig</c>, when workers complete
        /// labeling tasks, Ground Truth will send labeling task output data to the SNS output
        /// topic you specify here. 
        /// </para>
        ///  
        /// <para>
        /// To learn more, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-streaming-labeling-job.html#sms-streaming-how-it-works-output-data">Receive
        /// Output Data from a Streaming Labeling Job</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

    }
}