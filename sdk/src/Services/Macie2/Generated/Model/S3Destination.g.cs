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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies an S3 bucket to store data classification results in, and the encryption
    /// settings to use when storing results in that bucket. The bucket must be an existing
    /// general purpose bucket. It can be a bucket in your own account or a bucket that another
    /// account owns. If another account owns the bucket, you must specify both the unique
    /// identifier for the account and the name of the bucket.
    /// </summary>
    public partial class S3Destination
    {
        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket. This must be the name of an existing general purpose bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The unique identifier (ID) for the Amazon Web Services account that owns the bucket.
        /// This must be the ID for the account that owns the specified bucket.
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedBucketOwner property is set.
        /// </summary>
        internal bool IsSetExpectedBucketOwner() => this.ExpectedBucketOwner != null;

        /// <summary>
        /// Gets and sets the property KeyPrefix. 
        /// <para>
        /// The path prefix to use in the path to the location in the bucket. This prefix specifies
        /// where to store classification results in the bucket.
        /// </para>
        /// </summary>
        public string KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the KeyPrefix property is set.
        /// </summary>
        internal bool IsSetKeyPrefix() => this.KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed KMS key to use for encryption
        /// of the results. This must be the ARN of an existing, symmetric encryption KMS key
        /// that's enabled in the same Amazon Web Services Region as the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;
    }
}
