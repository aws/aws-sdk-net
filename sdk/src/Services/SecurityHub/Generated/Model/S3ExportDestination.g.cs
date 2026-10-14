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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The Amazon S3 destination for an export, including the bucket, the Amazon Web Services
    /// KMS key used for encryption, and an optional object key prefix.
    /// </summary>
    public partial class S3ExportDestination
    {
        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket that Security Hub writes the
        /// export to. You must own the bucket, and its bucket policy must grant the Security
        /// Hub service principal (<c>exportv2.securityhub.amazonaws.com</c>) permission to write
        /// objects. For the required bucket policy, see the Examples section of <c>StartExportJobV2</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the BucketArn property is set.
        /// </summary>
        internal bool IsSetBucketArn() => this.BucketArn != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the Amazon Web Services KMS key that Security Hub uses to encrypt the export
        /// objects with server-side encryption. The key policy must allow the Security Hub service
        /// principal (<c>exportv2.securityhub.amazonaws.com</c>) to use the key through Amazon
        /// S3. For the required key policy, see the Examples section of <c>StartExportJobV2</c>.
        /// </para>
        ///  
        /// <para>
        /// The key must meet all of the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It must be a symmetric key with a key usage of <c>ENCRYPT_DECRYPT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It must be a single-Region key. Multi-Region keys, whose key IDs begin with <c>mrk-</c>,
        /// are rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the full key ARN. Key IDs and aliases are rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The key must be in the same Amazon Web Services account as the export job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The key must be in the same Amazon Web Services Region as the export job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The key must be in the <c>aws</c>, <c>aws-cn</c>, or <c>aws-us-gov</c> partition.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property ObjectPrefix. 
        /// <para>
        /// An optional key prefix that Security Hub prepends to the Amazon S3 object keys of
        /// the export output. Use a prefix to organize exports within the bucket. The value can
        /// be up to 512 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string ObjectPrefix { get; set; }

        /// <summary>
        /// Checks to see if the ObjectPrefix property is set.
        /// </summary>
        internal bool IsSetObjectPrefix() => this.ObjectPrefix != null;
    }
}
