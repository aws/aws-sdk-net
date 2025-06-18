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
using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the RenameObject operation.
    /// Renames an object or directory (prefix with delimiter) as an atomic operation in a directory bucket.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This operation is only supported for directory buckets.
    /// </para>
    /// <para>
    /// To rename an object or directory, you must have permissions to perform both the <c>s3:GetObject</c> and <c>s3:PutObject</c> actions.
    /// </para>
    /// <para>
    /// If a directory is specified in the rename request, all objects with the specified prefix are atomically renamed. However, 
    /// existing objects that are encrypted with customer-provided encryption keys (SSE-C) won't be renamed.
    /// </para>
    /// <para>
    /// The following operations are related to <c>RenameObject</c>:
    /// <list type="bullet">
    /// <item><description><a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a></description></item>
    /// <item><description><a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a></description></item>
    /// <item><description><a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteObject.html">DeleteObject</a></description></item>
    /// </list>
    /// </para>
    /// </remarks>
    public partial class RenameObjectRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string key;
        private string renameSource;
        private string destinationIfMatch;
        private string destinationIfNoneMatch;
        private DateTime? destinationIfModifiedSince;
        private DateTime? destinationIfUnmodifiedSince;
        private string sourceIfMatch;
        private string sourceIfNoneMatch;
        private DateTime? sourceIfModifiedSince;
        private DateTime? sourceIfUnmodifiedSince;
        private string clientToken;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket in which the object or directory will be renamed.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The new key name (full path) for the object or directory.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Gets and sets the property RenameSource. 
        /// <para>
        /// The key name (full path) of the source object or directory to be renamed. It must be URL-encoded.
        /// </para>
        /// <para>
        /// Format: /bucket-name/object-key
        /// </para>
        /// </summary>
        public string RenameSource
        {
            get { return this.renameSource; }
            set { this.renameSource = value; }
        }

        /// <summary>
        /// Gets and sets the property DestinationIfMatch. 
        /// <para>
        /// If the specified entity tag (ETag) matches the destination object's ETag, Amazon S3
        /// will process the request.
        /// </para>
        /// </summary>
        public string DestinationIfMatch
        {
            get { return this.destinationIfMatch; }
            set { this.destinationIfMatch = value; }
        }

        /// <summary>
        /// Gets and sets the property DestinationIfNoneMatch. 
        /// <para>
        /// If the specified entity tag (ETag) does not match the destination object's ETag, Amazon S3
        /// will process the request.
        /// </para>
        /// </summary>
        public string DestinationIfNoneMatch
        {
            get { return this.destinationIfNoneMatch; }
            set { this.destinationIfNoneMatch = value; }
        }

        /// <summary>
        /// Gets and sets the property DestinationIfModifiedSince. 
        /// <para>
        /// If the destination object was modified after the specified time, Amazon S3 will process
        /// the request.
        /// </para>
        /// </summary>
        public DateTime DestinationIfModifiedSince
        {
            get { return this.destinationIfModifiedSince.GetValueOrDefault(); }
            set { this.destinationIfModifiedSince = value; }
        }

        /// <summary>
        /// Gets and sets the property DestinationIfUnmodifiedSince. 
        /// <para>
        /// If the destination object was not modified after the specified time, Amazon S3 will process
        /// the request.
        /// </para>
        /// </summary>
        public DateTime DestinationIfUnmodifiedSince
        {
            get { return this.destinationIfUnmodifiedSince.GetValueOrDefault(); }
            set { this.destinationIfUnmodifiedSince = value; }
        }

        /// <summary>
        /// Gets and sets the property SourceIfMatch. 
        /// <para>
        /// If the specified entity tag (ETag) matches the source object's ETag, Amazon S3
        /// will process the request.
        /// </para>
        /// </summary>
        public string SourceIfMatch
        {
            get { return this.sourceIfMatch; }
            set { this.sourceIfMatch = value; }
        }

        /// <summary>
        /// Gets and sets the property SourceIfNoneMatch. 
        /// <para>
        /// If the specified entity tag (ETag) does not match the source object's ETag, Amazon S3
        /// will process the request.
        /// </para>
        /// </summary>
        public string SourceIfNoneMatch
        {
            get { return this.sourceIfNoneMatch; }
            set { this.sourceIfNoneMatch = value; }
        }

        /// <summary>
        /// Gets and sets the property SourceIfModifiedSince. 
        /// <para>
        /// If the source object was modified after the specified time, Amazon S3 will process
        /// the request.
        /// </para>
        /// </summary>
        public DateTime SourceIfModifiedSince
        {
            get { return this.sourceIfModifiedSince.GetValueOrDefault(); }
            set { this.sourceIfModifiedSince = value; }
        }

        /// <summary>
        /// Gets and sets the property SourceIfUnmodifiedSince. 
        /// <para>
        /// If the source object was not modified after the specified time, Amazon S3 will process
        /// the request.
        /// </para>
        /// </summary>
        public DateTime SourceIfUnmodifiedSince
        {
            get { return this.sourceIfUnmodifiedSince.GetValueOrDefault(); }
            set { this.sourceIfUnmodifiedSince = value; }
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token to ensure that the rename request is idempotent. It's suitable to use the same client token
        /// across multiple requests when you're retrying a failed operation.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this.clientToken; }
            set { this.clientToken = value; }
        }

        #region Internal helper methods

        /// <summary>
        /// Checks if BucketName property is set
        /// </summary>
        /// <returns>true if BucketName property is set</returns>
        internal bool IsSetBucketName()
        {
            return !string.IsNullOrEmpty(this.bucketName);
        }

        /// <summary>
        /// Checks if Key property is set
        /// </summary>
        /// <returns>true if Key property is set</returns>
        internal bool IsSetKey()
        {
            return !string.IsNullOrEmpty(this.key);
        }

        /// <summary>
        /// Checks if RenameSource property is set
        /// </summary>
        /// <returns>true if RenameSource property is set</returns>
        internal bool IsSetRenameSource()
        {
            return !string.IsNullOrEmpty(this.renameSource);
        }

        /// <summary>
        /// Checks if DestinationIfMatch property is set
        /// </summary>
        /// <returns>true if DestinationIfMatch property is set</returns>
        internal bool IsSetDestinationIfMatch()
        {
            return !string.IsNullOrEmpty(this.destinationIfMatch);
        }

        /// <summary>
        /// Checks if DestinationIfNoneMatch property is set
        /// </summary>
        /// <returns>true if DestinationIfNoneMatch property is set</returns>
        internal bool IsSetDestinationIfNoneMatch()
        {
            return !string.IsNullOrEmpty(this.destinationIfNoneMatch);
        }

        /// <summary>
        /// Checks if DestinationIfModifiedSince property is set.
        /// </summary>
        /// <returns>true if DestinationIfModifiedSince property is set</returns>
        internal bool IsSetDestinationIfModifiedSince()
        {
            return this.destinationIfModifiedSince.HasValue;
        }

        /// <summary>
        /// Checks if DestinationIfUnmodifiedSince property is set.
        /// </summary>
        /// <returns>true if DestinationIfUnmodifiedSince property is set</returns>
        internal bool IsSetDestinationIfUnmodifiedSince()
        {
            return this.destinationIfUnmodifiedSince.HasValue;
        }

        /// <summary>
        /// Checks if SourceIfMatch property is set
        /// </summary>
        /// <returns>true if SourceIfMatch property is set</returns>
        internal bool IsSetSourceIfMatch()
        {
            return !string.IsNullOrEmpty(this.sourceIfMatch);
        }

        /// <summary>
        /// Checks if SourceIfNoneMatch property is set
        /// </summary>
        /// <returns>true if SourceIfNoneMatch property is set</returns>
        internal bool IsSetSourceIfNoneMatch()
        {
            return !string.IsNullOrEmpty(this.sourceIfNoneMatch);
        }
        
        /// <summary>
        /// Checks if SourceIfModifiedSince property is set.
        /// </summary>
        /// <returns>true if SourceIfModifiedSince property is set</returns>
        internal bool IsSetSourceIfModifiedSince()
        {
            return this.sourceIfModifiedSince.HasValue;
        }

        /// <summary>
        /// Checks if SourceIfUnmodifiedSince property is set.
        /// </summary>
        /// <returns>true if SourceIfUnmodifiedSince property is set</returns>
        internal bool IsSetSourceIfUnmodifiedSince()
        {
            return this.sourceIfUnmodifiedSince.HasValue;
        }

        /// <summary>
        /// Checks if ClientToken property is set
        /// </summary>
        /// <returns>true if ClientToken property is set</returns>
        internal bool IsSetClientToken()
        {
            return !string.IsNullOrEmpty(this.clientToken);
        }

        #endregion
    }
}