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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A filter that returns objects that are encrypted by server-side encryption with Amazon
    /// Web Services KMS (SSE-KMS).
    /// </summary>
    public partial class SSEKMSFilter
    {
        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Specifies whether Amazon S3 should use an S3 Bucket Key for object encryption with
        /// server-side encryption using Amazon Web Services Key Management Service (Amazon Web
        /// Services KMS) keys (SSE-KMS). If specified, will filter SSE-KMS encrypted objects
        /// by S3 Bucket Key status.
        /// </para>
        /// </summary>
        public bool? BucketKeyEnabled { get; set; }

        /// <summary>
        /// Checks to see if the BucketKeyEnabled property is set.
        /// </summary>
        internal bool IsSetBucketKeyEnabled() => this.BucketKeyEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed KMS key to use for the filter
        /// to return objects that are encrypted by the specified key. For best performance, use
        /// keys in the same Region as the S3 Batch Operations job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;
    }
}
