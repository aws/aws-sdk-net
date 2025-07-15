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
 * Do not modify this file. This file is generated from the s3vectors-2025-07-15.normal.json service model.
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
namespace Amazon.S3Vectors.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
    /// 
    ///  </note> 
    /// <para>
    /// The encryption configuration for a vector bucket. By default, if you don't specify,
    /// all new vectors in Amazon S3 vector buckets use server-side encryption with Amazon
    /// S3 managed keys (SSE-S3), specifically <c>AES256</c>.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class EncryptionConfiguration
    {
        private string _kmsKeyArn;
        private SseType _sseType;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// Amazon Web Services Key Management Service (KMS) customer managed key ID to use for
        /// the encryption configuration. This parameter is allowed if and only if <c>sseType</c>
        /// is set to <c>aws:kms</c>.
        /// </para>
        ///  
        /// <para>
        /// To specify the KMS key, you must use the format of the KMS key Amazon Resource Name
        /// (ARN).
        /// </para>
        ///  
        /// <para>
        /// For example, specify Key ARN in the following format: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property SseType. 
        /// <para>
        /// The server-side encryption type to use for the encryption configuration of the vector
        /// bucket. By default, if you don't specify, all new vectors in Amazon S3 vector buckets
        /// use server-side encryption with Amazon S3 managed keys (SSE-S3), specifically <c>AES256</c>.
        /// </para>
        /// </summary>
        public SseType SseType
        {
            get { return this._sseType; }
            set { this._sseType = value; }
        }

        // Check to see if SseType property is set
        internal bool IsSetSseType()
        {
            return this._sseType != null;
        }

    }
}