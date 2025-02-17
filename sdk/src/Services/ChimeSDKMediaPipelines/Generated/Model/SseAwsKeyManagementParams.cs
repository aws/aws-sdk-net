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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
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
namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Contains server side encryption parameters to be used by media capture pipeline. The
    /// parameters can also be used by media concatenation pipeline taking media capture pipeline
    /// as a media source.
    /// </summary>
    public partial class SseAwsKeyManagementParams
    {
        private string _awsKmsEncryptionContext;
        private string _awsKmsKeyId;

        /// <summary>
        /// Gets and sets the property AwsKmsEncryptionContext. 
        /// <para>
        /// Base64-encoded string of a UTF-8 encoded JSON, which contains the encryption context
        /// as non-secret key-value pair known as encryption context pairs, that provides an added
        /// layer of security for your data. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/encrypt_context.html">KMS
        /// encryption context</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Asymmetric
        /// keys in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string AwsKmsEncryptionContext
        {
            get { return this._awsKmsEncryptionContext; }
            set { this._awsKmsEncryptionContext = value; }
        }

        // Check to see if AwsKmsEncryptionContext property is set
        internal bool IsSetAwsKmsEncryptionContext()
        {
            return this._awsKmsEncryptionContext != null;
        }

        /// <summary>
        /// Gets and sets the property AwsKmsKeyId. 
        /// <para>
        /// The KMS key you want to use to encrypt your media pipeline output. Decryption is required
        /// for concatenation pipeline. If using a key located in the current Amazon Web Services
        /// account, you can specify your KMS key in one of four ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the KMS key ID itself. For example, <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use an alias for the KMS key ID. For example, <c>alias/ExampleAlias</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the Amazon Resource Name (ARN) for the KMS key ID. For example, <c>arn:aws:kms:region:account-ID:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the ARN for the KMS key alias. For example, <c>arn:aws:kms:region:account-ID:alias/ExampleAlias</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If using a key located in a different Amazon Web Services account than the current
        /// Amazon Web Services account, you can specify your KMS key in one of two ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the ARN for the KMS key ID. For example, <c>arn:aws:kms:region:account-ID:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the ARN for the KMS key alias. For example, <c>arn:aws:kms:region:account-ID:alias/ExampleAlias</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify an encryption key, your output is encrypted with the default
        /// Amazon S3 key (SSE-S3).
        /// </para>
        ///  
        /// <para>
        /// Note that the role specified in the <c>SinkIamRoleArn</c> request parameter must have
        /// permission to use the specified KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=4096)]
        public string AwsKmsKeyId
        {
            get { return this._awsKmsKeyId; }
            set { this._awsKmsKeyId = value; }
        }

        // Check to see if AwsKmsKeyId property is set
        internal bool IsSetAwsKmsKeyId()
        {
            return this._awsKmsKeyId != null;
        }

    }
}