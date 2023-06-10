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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the storage parameters for Amazon S3 and Amazon S3 buckets for an instance
    /// store-backed AMI.
    /// </summary>
    public partial class S3Storage
    {
        private string _awsAccessKeyId;
        private string _bucket;
        private string _prefix;
        private string _uploadPolicy;
        private string _uploadPolicySignature;

        /// <summary>
        /// Gets and sets the property AWSAccessKeyId. 
        /// <para>
        /// The access key ID of the owner of the bucket. Before you specify a value for your
        /// access key ID, review and follow the guidance in <a href="https://docs.aws.amazon.com/accounts/latest/reference/best-practices.html">Best
        /// Practices for Amazon Web Services accounts</a> in the <i>Account ManagementReference
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string AWSAccessKeyId
        {
            get { return this._awsAccessKeyId; }
            set { this._awsAccessKeyId = value; }
        }

        // Check to see if AWSAccessKeyId property is set
        internal bool IsSetAWSAccessKeyId()
        {
            return this._awsAccessKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The bucket in which to store the AMI. You can specify a bucket that you already own
        /// or a new bucket that Amazon EC2 creates on your behalf. If you specify a bucket that
        /// belongs to someone else, Amazon EC2 returns an error.
        /// </para>
        /// </summary>
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The beginning of the file name of the AMI.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property UploadPolicy. 
        /// <para>
        /// An Amazon S3 upload policy that gives Amazon EC2 permission to upload items into Amazon
        /// S3 on your behalf.
        /// </para>
        /// </summary>
        public string UploadPolicy
        {
            get { return this._uploadPolicy; }
            set { this._uploadPolicy = value; }
        }

        // Check to see if UploadPolicy property is set
        internal bool IsSetUploadPolicy()
        {
            return this._uploadPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property UploadPolicySignature. 
        /// <para>
        /// The signature of the JSON document.
        /// </para>
        /// </summary>
        public string UploadPolicySignature
        {
            get { return this._uploadPolicySignature; }
            set { this._uploadPolicySignature = value; }
        }

        // Check to see if UploadPolicySignature property is set
        internal bool IsSetUploadPolicySignature()
        {
            return this._uploadPolicySignature != null;
        }

    }
}