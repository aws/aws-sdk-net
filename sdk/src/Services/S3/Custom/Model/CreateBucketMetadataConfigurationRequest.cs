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
using System;
using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBucketMetadataConfiguration operation.
    /// </summary>
    public partial class CreateBucketMetadataConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private ChecksumAlgorithm checksumAlgorithm;
        private string contentMD5;
        private string expectedBucketOwner;
        private MetadataConfiguration metadataConfiguration;

        /// <summary>
        /// Gets and sets the property BucketName.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        internal bool IsSetBucketName()
        {
            return !String.IsNullOrEmpty(this.bucketName);
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm.
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this.checksumAlgorithm; }
            set { this.checksumAlgorithm = value; }
        }

        internal bool IsSetChecksumAlgorithm()
        {
            return this.checksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ContentMD5.
        /// </summary>
        public string ContentMD5
        {
            get { return this.contentMD5; }
            set { this.contentMD5 = value; }
        }

        internal bool IsSetContentMD5()
        {
            return !String.IsNullOrEmpty(this.contentMD5);
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner.
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }

        /// <summary>
        /// Gets and sets the property MetadataConfiguration.
        /// </summary>
        public MetadataConfiguration MetadataConfiguration
        {
            get { return this.metadataConfiguration; }
            set { this.metadataConfiguration = value; }
        }

        internal bool IsSetMetadataConfiguration()
        {
            return this.metadataConfiguration != null;
        }

    }
}