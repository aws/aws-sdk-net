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
    /// Container for the parameters to the CreateVectorBucket operation.
    /// <note> 
    /// <para>
    /// Amazon S3 Vectors is in preview release for Amazon S3 and is subject to change.
    /// 
    ///  </note> 
    /// <para>
    /// Creates a vector bucket in the Amazon Web Services Region that you want your bucket
    /// to be in. 
    /// </para>
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3vectors:CreateVectorBucket</c> permission to use this operation.
    /// 
    /// </para>
    ///  </dd> </dl>
    /// </para>
    /// </summary>
    public partial class CreateVectorBucketRequest : AmazonS3VectorsRequest
    {
        private EncryptionConfiguration _encryptionConfiguration;
        private string _vectorBucketName;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for the vector bucket. By default, if you don't specify,
        /// all new vectors in Amazon S3 vector buckets use server-side encryption with Amazon
        /// S3 managed keys (SSE-S3), specifically <c>AES256</c>. 
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VectorBucketName. 
        /// <para>
        /// The name of the vector bucket to create. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string VectorBucketName
        {
            get { return this._vectorBucketName; }
            set { this._vectorBucketName = value; }
        }

        // Check to see if VectorBucketName property is set
        internal bool IsSetVectorBucketName()
        {
            return this._vectorBucketName != null;
        }

    }
}