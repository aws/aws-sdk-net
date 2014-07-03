/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes the S3 bucket for an instance store-backed AMI.</para>
    /// </summary>
    public partial class S3Storage
    {
        
        private string bucket;
        private string prefix;
        private string aWSAccessKeyId;
        private string uploadPolicy;
        private string uploadPolicySignature;


        /// <summary>
        /// The bucket in which to store the AMI. You can specify a bucket that you already own or a new bucket that Amazon EC2 creates on your behalf.
        /// If you specify a bucket that belongs to someone else, Amazon EC2 returns an error.
        ///  
        /// </summary>
        public string Bucket
        {
            get { return this.bucket; }
            set { this.bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this.bucket != null;
        }

        /// <summary>
        /// The beginning of the file name of the AMI.
        ///  
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this.prefix != null;
        }

        /// <summary>
        /// The access key ID of the owner of the bucket. Before you specify a value for your access key ID, review and follow the guidance in <a
        /// href="http://docs.aws.amazon.com/general/latest/gr/aws-access-keys-best-practices.html">Best Practices for Managing AWS Access Keys</a>.
        ///  
        /// </summary>
        public string AWSAccessKeyId
        {
            get { return this.aWSAccessKeyId; }
            set { this.aWSAccessKeyId = value; }
        }

        // Check to see if AWSAccessKeyId property is set
        internal bool IsSetAWSAccessKeyId()
        {
            return this.aWSAccessKeyId != null;
        }

        /// <summary>
        /// A Base64-encoded Amazon S3 upload policy that gives Amazon EC2 permission to upload items into Amazon S3 on your behalf.
        ///  
        /// </summary>
        public string UploadPolicy
        {
            get { return this.uploadPolicy; }
            set { this.uploadPolicy = value; }
        }

        // Check to see if UploadPolicy property is set
        internal bool IsSetUploadPolicy()
        {
            return this.uploadPolicy != null;
        }

        /// <summary>
        /// The signature of the Base64 encoded JSON document.
        ///  
        /// </summary>
        public string UploadPolicySignature
        {
            get { return this.uploadPolicySignature; }
            set { this.uploadPolicySignature = value; }
        }

        // Check to see if UploadPolicySignature property is set
        internal bool IsSetUploadPolicySignature()
        {
            return this.uploadPolicySignature != null;
        }
    }
}
