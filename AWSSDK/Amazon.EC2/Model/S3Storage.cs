/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// S3 storage configuration
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class S3Storage
    {    
        private string bucketField;
        private string prefixField;
        private string AWSAccessKeyIdField;
        private string uploadPolicyField;
        private string uploadPolicySignatureField;

        /// <summary>
        /// The bucket in which to store the AMI.
        /// You can specify a bucket that you already own or a new bucket that Amazon
        /// EC2 creates on your behalf. If you specify a bucket that belongs
        /// to someone else, Amazon EC2 returns an error.
        /// </summary>
        [XmlElementAttribute(ElementName = "Bucket")]
        public string Bucket
        {
            get { return this.bucketField; }
            set { this.bucketField = value; }
        }

        /// <summary>
        /// Sets the bucket in which to store the AMI.
        /// </summary>
        /// <param name="bucket">The bucket in which to store the AMI. You can
        /// specify a bucket that you
        /// already own or a new bucket that Amazon
        /// EC2 creates on your behalf. If you
        /// specify a bucket that belongs
        /// to someone else, Amazon EC2 returns an
        /// error.</param>
        /// <returns>this instance</returns>
        public S3Storage WithBucket(string bucket)
        {
            this.bucketField = bucket;
            return this;
        }

        /// <summary>
        /// Checks if Bucket property is set
        /// </summary>
        /// <returns>true if Bucket property is set</returns>
        public bool IsSetBucket()
        {
            return this.bucketField != null;
        }

        /// <summary>
        /// The beginning of the file name of the AMI.
        /// </summary>
        [XmlElementAttribute(ElementName = "Prefix")]
        public string Prefix
        {
            get { return this.prefixField; }
            set { this.prefixField = value; }
        }

        /// <summary>
        /// Sets the beginning of the file name of the AMI.
        /// </summary>
        /// <param name="prefix">Specifies the beginning of the file name of the AMI.</param>
        /// <returns>this instance</returns>
        public S3Storage WithPrefix(string prefix)
        {
            this.prefixField = prefix;
            return this;
        }

        /// <summary>
        /// Checks if Prefix property is set
        /// </summary>
        /// <returns>true if Prefix property is set</returns>
        public bool IsSetPrefix()
        {
            return this.prefixField != null;
        }

        /// <summary>
        /// The Access Key ID of the owner of the Amazon S3 bucket.
        /// </summary>
        [XmlElementAttribute(ElementName = "AWSAccessKeyId")]
        public string AWSAccessKeyId
        {
            get { return this.AWSAccessKeyIdField; }
            set { this.AWSAccessKeyIdField = value; }
        }

        /// <summary>
        /// Sets the Access Key ID of the owner of the Amazon S3 bucket.
        /// </summary>
        /// <param name="AWSAccessKeyId">The Access Key ID of the owner of the Amazon S3 bucket.</param>
        /// <returns>this instance</returns>
        public S3Storage WithAWSAccessKeyId(string AWSAccessKeyId)
        {
            this.AWSAccessKeyIdField = AWSAccessKeyId;
            return this;
        }

        /// <summary>
        /// Checks if AWSAccessKeyId property is set
        /// </summary>
        /// <returns>true if AWSAccessKeyId property is set</returns>
        public bool IsSetAWSAccessKeyId()
        {
            return this.AWSAccessKeyIdField != null;
        }

        /// <summary>
        /// A Base64-encoded Amazon S3 upload policy that gives Amazon EC2
        /// permission to upload items into Amazon S3 on the user's behalf.
        /// </summary>
        [XmlElementAttribute(ElementName = "UploadPolicy")]
        public string UploadPolicy
        {
            get { return this.uploadPolicyField; }
            set { this.uploadPolicyField = value; }
        }

        /// <summary>
        /// Sets a Base64-encoded Amazon S3 upload policy that gives Amazon EC2
        /// permission to upload items into Amazon S3 on the user's behalf.
        /// </summary>
        /// <param name="uploadPolicy">A Base64-encoded Amazon S3 upload policy that
        /// gives Amazon EC2 permission to upload items into
        /// Amazon S3 on the user's behalf</param>
        /// <returns>this instance</returns>
        public S3Storage WithUploadPolicy(string uploadPolicy)
        {
            this.uploadPolicyField = uploadPolicy;
            return this;
        }

        /// <summary>
        /// Checks if UploadPolicy property is set
        /// </summary>
        /// <returns>true if UploadPolicy property is set</returns>
        public bool IsSetUploadPolicy()
        {
            return this.uploadPolicyField != null;
        }

        /// <summary>
        /// The signature of the Base64 encoded JSON document.
        /// </summary>
        [XmlElementAttribute(ElementName = "UploadPolicySignature")]
        public string UploadPolicySignature
        {
            get { return this.uploadPolicySignatureField; }
            set { this.uploadPolicySignatureField = value; }
        }

        /// <summary>
        /// Sets the signature of the Base64 encoded JSON document.
        /// </summary>
        /// <param name="uploadPolicySignature">The signature of the Base64 encoded JSON
        /// document.</param>
        /// <returns>this instance</returns>
        public S3Storage WithUploadPolicySignature(string uploadPolicySignature)
        {
            this.uploadPolicySignatureField = uploadPolicySignature;
            return this;
        }

        /// <summary>
        /// Checks if UploadPolicySignature property is set
        /// </summary>
        /// <returns>true if UploadPolicySignature property is set</returns>
        public bool IsSetUploadPolicySignature()
        {
            return this.uploadPolicySignatureField != null;
        }

    }
}
