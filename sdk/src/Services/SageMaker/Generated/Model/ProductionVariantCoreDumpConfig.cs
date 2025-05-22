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
    /// Specifies configuration for a core dump from the model container when the process
    /// crashes.
    /// </summary>
    public partial class ProductionVariantCoreDumpConfig
    {
        private string _destinationS3Uri;
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property DestinationS3Uri. 
        /// <para>
        /// The Amazon S3 bucket to send the core dump to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=512)]
        public string DestinationS3Uri
        {
            get { return this._destinationS3Uri; }
            set { this._destinationS3Uri = value; }
        }

        // Check to see if DestinationS3Uri property is set
        internal bool IsSetDestinationS3Uri()
        {
            return this._destinationS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that
        /// SageMaker uses to encrypt the core dump data at rest using Amazon S3 server-side encryption.
        /// The <c>KmsKeyId</c> can be any of the following formats: 
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
        /// ID, SageMaker uses the default KMS key for Amazon S3 for your role's account. SageMaker
        /// uses server-side encryption with KMS-managed keys for <c>OutputDataConfig</c>. If
        /// you use a bucket policy with an <c>s3:PutObject</c> permission that only allows objects
        /// with server-side encryption, set the condition key of <c>s3:x-amz-server-side-encryption</c>
        /// to <c>"aws:kms"</c>. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">KMS-Managed
        /// Encryption Keys</a> in the <i>Amazon Simple Storage Service Developer Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// The KMS key policy must grant permission to the IAM role that you specify in your
        /// <c>CreateEndpoint</c> and <c>UpdateEndpoint</c> requests. For more information, see
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Using
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

    }
}