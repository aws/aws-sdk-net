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
    /// Container for the parameters to the UpdateBucketMetadataJournalTableConfiguration operation.
    /// Updates the journal table configuration for a general purpose bucket.
    /// </summary>
    public partial class UpdateBucketMetadataJournalTableConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private ChecksumAlgorithm checksumAlgorithm;
        private string contentMD5;
        private JournalTableConfigurationUpdates journalTableConfiguration;
        private string expectedBucketOwner;

        /// <summary>
        /// <para>
        /// The general purpose bucket that you want to update the journal table configuration for.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        internal bool IsSetBucketName()
        {
            return !String.IsNullOrEmpty(bucketName);
        }

        /// <summary>
        /// <para>
        /// The checksum algorithm to use with your journal table configuration update.
        /// </para>
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this.checksumAlgorithm; }
            set { this.checksumAlgorithm = value; }
        }

        internal bool IsSetChecksumAlgorithm()
        {
            return checksumAlgorithm != null;
        }

        /// <summary>
        /// <para>
        /// The <c>Content-MD5</c> header for the journal table configuration update.
        /// </para>
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
        /// <para>
        /// The journal table configuration updates.
        /// </para>
        /// </summary>
        public JournalTableConfigurationUpdates JournalTableConfiguration
        {
            get { return this.journalTableConfiguration; }
            set { this.journalTableConfiguration = value; }
        }

        internal bool IsSetJournalTableConfiguration()
        {
            return this.journalTableConfiguration != null;
        }

        /// <summary>
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does not 
        /// match the actual owner of the bucket, the request fails with the HTTP status code 
        /// <c>403 Forbidden</c> (access denied).
        /// </para>
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
    }
}