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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the storage parameters for Amazon S3 and Amazon S3 buckets for an instance
    /// store-backed AMI.
    /// </summary>
    public partial class S3Storage
    {
        /// <summary>
        /// Gets and sets the property AWSAccessKeyId. 
        /// <para>
        /// The access key ID of the owner of the bucket. Before you specify a value for your
        /// access key ID, review and follow the guidance in <a href="https://docs.aws.amazon.com/accounts/latest/reference/best-practices.html">Best
        /// Practices for Amazon Web Services accounts</a> in the <i>Account ManagementReference
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string AWSAccessKeyId { get; set; }

        /// <summary>
        /// Checks to see if the AWSAccessKeyId property is set.
        /// </summary>
        internal bool IsSetAWSAccessKeyId() => this.AWSAccessKeyId != null;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The bucket in which to store the AMI. You can specify a bucket that you already own
        /// or a new bucket that Amazon EC2 creates on your behalf. If you specify a bucket that
        /// belongs to someone else, Amazon EC2 returns an error.
        /// </para>
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The beginning of the file name of the AMI.
        /// </para>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property UploadPolicy. 
        /// <para>
        /// An Amazon S3 upload policy that gives Amazon EC2 permission to upload items into Amazon
        /// S3 on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public MemoryStream UploadPolicy { get; set; }

        /// <summary>
        /// Checks to see if the UploadPolicy property is set.
        /// </summary>
        internal bool IsSetUploadPolicy() => this.UploadPolicy != null;

        /// <summary>
        /// Gets and sets the property UploadPolicySignature. 
        /// <para>
        /// The signature of the JSON document.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string UploadPolicySignature { get; set; }

        /// <summary>
        /// Checks to see if the UploadPolicySignature property is set.
        /// </summary>
        internal bool IsSetUploadPolicySignature() => this.UploadPolicySignature != null;
    }
}
