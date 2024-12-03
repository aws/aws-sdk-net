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
    /// <para>
    ///  Deletes a metadata table configuration from a general purpose bucket. For more
    /// information, see<a href ="https://docs.aws.amazon.com/AmazonS3/latest/userguide/metadata-tables-overview.html">Accelerating data
    ///    discovery with S3 Metadata</a> in the<i> Amazon S3 User Guide</i>. </para>
    /// <dl>
    ///    <dt>Permissions</dt>
    ///    <dd>
    ///       <para>To use this operation, you must have the <c>s3:DeleteBucketMetadataTableConfiguration</c> permission. For more
    ///          information, see<a href ="https://docs.aws.amazon.com/AmazonS3/latest/userguide/metadata-tables-permissions.html">Setting up
    ///             permissions for configuring metadata tables</a> in the
    ///          <i> Amazon S3 User Guide</i>. </para>
    ///    </dd>
    /// </dl>
    /// <para>The following operations are related to <c>DeleteBucketMetadataTableConfiguration</c>:</para>
    /// <ul>
    ///    <li>
    ///       <para>
    ///          <a href ="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucketMetadataTableConfiguration.html">CreateBucketMetadataTableConfiguration</a>
    ///       </para>
    ///    </li>
    ///    <li>
    ///       <para>
    ///          <a href ="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketMetadataTableConfiguration.html">GetBucketMetadataTableConfiguration</a>
    ///       </para>
    ///    </li>
    /// </ul>
    /// </summary>
    public partial class DeleteBucketMetadataTableConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string expectedBucketOwner;

        /// <summary>
        /// <para>
        /// The general purpose bucket that you want to remove the metadata table configuration from.
        /// </para>
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
        /// <para>
        /// The expected bucket owner of the general purpose bucket that you want to remove the
        /// metadata table configuration from.
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

