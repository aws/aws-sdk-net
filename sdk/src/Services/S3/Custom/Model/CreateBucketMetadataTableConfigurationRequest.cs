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
    /// <para>Creates a metadata table configuration for a general purpose bucket. For more information, see <a
    ///        href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/metadata-tables-overview.html">Accelerating data
    ///        discovery with S3 Metadata</a> in the <i>Amazon S3 User Guide</i>. </para>
    /// <dl>
    ///    <dt>Permissions</dt>
    ///    <dd>
    ///        <para>To use this operation, you must have the following permissions. For more information, see <a
    ///                href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/metadata-tables-permissions.html">Setting up
    ///                permissions for configuring metadata tables</a> in the <i>Amazon S3 User Guide</i>.</para>
    ///        <para>If you also want to integrate your table bucket with Amazon Web Services analytics
    ///            services so that you can query your metadata table, you need additional permissions. For
    ///            more information, see <a
    ///                href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-integrating-aws.html">
    ///            Integrating Amazon S3 Tables with Amazon Web Services analytics services</a> in the <i>Amazon
    ///            S3 User Guide</i>.</para>
    ///        <ul>
    ///            <li>
    ///                <para>
    ///                    <c>s3:CreateBucketMetadataTableConfiguration</c>
    ///
    ///                </para>
    ///            </li>
    ///            <li>
    ///                <para>
    ///                    <c>s3tables:CreateNamespace</c>
    ///                </para>
    ///
    ///            </li>
    ///            <li>
    ///                <para>
    ///                    <c>s3tables:GetTable</c>
    ///                </para>
    ///            </li>
    ///            <li>
    ///                <para>
    ///
    ///                    <c>s3tables:CreateTable</c>
    ///                </para>
    ///            </li>
    ///            <li>
    ///                <para>
    ///                    <c>
    ///                        s3tables:PutTablePolicy</c>
    ///                </para>
    ///            </li>
    ///        </ul>
    ///    </dd>
    /// </dl>
    ///
    /// <para>The following operations are related to <c>CreateBucketMetadataTableConfiguration</c>:</para>
    ///
    /// <ul>
    ///    <li>
    ///        <para>
    ///            <a
    ///                href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketMetadataTableConfiguration.html">
    ///                DeleteBucketMetadataTableConfiguration</a>
    ///        </para>
    ///    </li>
    ///    <li>
    ///        <para>
    ///            <a
    ///                href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketMetadataTableConfiguration.html">
    ///                GetBucketMetadataTableConfiguration</a>
    ///        </para>
    ///    </li>
    /// </ul>
    /// </summary>
    public partial class CreateBucketMetadataTableConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private ChecksumAlgorithm checksumAlgorithm;
        private string contentMD5;
        private MetadataTableConfiguration metadataTableConfiguration;
        private string expectedBucketOwner;

        /// <summary>
        /// <para>
        /// The general purpose bucket that you want to create the metadata table configuration in.
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
        /// The checksum algorithm to use with your metadata table configuration.
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
        /// The <c>Content-MD5</c> header for the metadata table configuration.
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
        /// The contents of your metadata table configuration.
        /// </para>
        /// </summary>
        public MetadataTableConfiguration MetadataTableConfiguration
        {
            get { return this.metadataTableConfiguration; }
            set { this.metadataTableConfiguration = value; }
        }

        internal bool IsSetMetadataTableConfiguration()
        {
            return this.metadataTableConfiguration != null;
        }

        /// <summary>
        /// <para>
        /// The expected owner of the general purpose bucket that contains your metadata table configuration.
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

