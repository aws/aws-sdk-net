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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Writes the MIME content of the email to an S3 bucket.
    /// </summary>
    public partial class S3Action
    {
        /// <summary>
        /// Gets and sets the property ActionFailurePolicy. 
        /// <para>
        /// A policy that states what to do in the case of failure. The action will fail if there
        /// are configuration errors. For example, the specified the bucket has been deleted.
        /// </para>
        /// </summary>
        public ActionFailurePolicy ActionFailurePolicy { get; set; }

        /// <summary>
        /// Checks to see if the ActionFailurePolicy property is set.
        /// </summary>
        internal bool IsSetActionFailurePolicy() => this.ActionFailurePolicy != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Role to use while writing to S3. This role
        /// must have access to the s3:PutObject, kms:Encrypt, and kms:GenerateDataKey APIs for
        /// the given bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The bucket name of the S3 bucket to write to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 62)]
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The S3 prefix to use for the write to the s3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 62)]
        public string S3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the S3Prefix property is set.
        /// </summary>
        internal bool IsSetS3Prefix() => this.S3Prefix != null;

        /// <summary>
        /// Gets and sets the property S3SseKmsKeyId. 
        /// <para>
        /// The KMS Key ID to use to encrypt the message in S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string S3SseKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the S3SseKmsKeyId property is set.
        /// </summary>
        internal bool IsSetS3SseKmsKeyId() => this.S3SseKmsKeyId != null;
    }
}
