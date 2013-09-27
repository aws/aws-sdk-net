/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to request a list of in-progress multipart uploads. An in-progress multipart upload 
    /// is a multipart upload that has been initiated, using the Initiate Multipart Upload request, but has 
    /// not yet been completed or aborted. 
    /// </summary>
    public class ListMultipartUploadsRequest : S3Request
    {
        private string bucketName;
        private int? maxUploads;
        private string keyMarker;
        private string uploadIdMarker;
        private string prefix;
        private string delimiter;

        #region BucketName

        /// <summary>
        /// The name of the bucket receiving the multipart upload(s)
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket receiving the multipart upload(s)
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>the request with the BucketName set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListMultipartUploadsRequest WithBucketName(string bucketName)
        {
            this.bucketName = bucketName;
            return this;
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.bucketName);
        }

        #endregion

        #region MaxUploads

        /// <summary>
        /// The maximum number of multipart uploads, from 1 to 1,000, to return in the response body. 
        /// 1,000 is the maximum number of uploads that can be returned in a response.
        /// </summary>
        public int MaxUploads
        {
            get { return this.maxUploads.GetValueOrDefault(); }
            set { this.maxUploads = value; }
        }

        /// <summary>
        /// Sets the maximum number of multipart uploads, from 1 to 1,000, to return in the response body. 
        /// 1,000 is the maximum number of uploads that can be returned in a response.
        /// </summary>
        /// <param name="maxUploads">Maximum uploads to return</param>
        /// <returns>the request with the MaxUploads set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListMultipartUploadsRequest WithMaxUploads(int maxUploads)
        {
            this.maxUploads = maxUploads;
            return this;
        }

        /// <summary>
        /// Checks if MaxUploads property is set.
        /// </summary>
        /// <returns>true if MaxUploads property is set.</returns>
        internal bool IsSetMaxUploads()
        {
            return maxUploads.HasValue;
        }

        #endregion

        #region KeyMarker

        /// <summary>
        /// Together with upload-id-marker, this parameter specifies the multipart upload after which listing should begin.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If UploadIdMarker is not specified, only the keys lexicographically
        /// greater than the specified key-marker will be included in the list.
        /// </para>
        /// <para>
        /// If UploadIdMarker is specified, any multipart uploads for a key
        /// equal to the key-marker may also be included, provided those multipart
        /// uploads have upload IDs lexicographically greater than the specified
        /// UploadIdMarker.
        /// </para>
        /// </remarks>
        public string KeyMarker
        {
            get { return this.keyMarker; }
            set { this.keyMarker = value; }
        }

        /// <summary>
        /// Together with upload-id-marker, this parameter specifies the multipart upload after which listing should begin.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If UploadIdMarker is not specified, only the keys lexicographically
        /// greater than the specified key-marker will be included in the list.
        /// </para>
        /// <para>
        /// If UploadIdMarker is specified, any multipart uploads for a key
        /// equal to the key-marker may also be included, provided those multipart
        /// uploads have upload IDs lexicographically greater than the specified
        /// UploadIdMarker.
        /// </para>
        /// </remarks>
        /// <param name="keyMarker">The key marker</param>
        /// <returns>the request with the KeyMarker set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListMultipartUploadsRequest WithKeyMarker(string keyMarker)
        {
            this.keyMarker = keyMarker;
            return this;
        }

        /// <summary>
        /// Checks if KeyMarker property is set.
        /// </summary>
        /// <returns>true if KeyMarker property is set.</returns>
        internal bool IsSetKeyMarker()
        {
            return !string.IsNullOrEmpty(this.keyMarker);
        }

        #endregion

        #region UploadIdMarker

        /// <summary>
        /// Together with key-marker, specifies the multipart upload after which listing should begin. 
        /// </summary>
        /// <remarks>
        /// If key-marker is not specified, the upload-id-marker parameter is ignored. Otherwise, any 
        /// multipart uploads for a key equal to the key-marker might be included in the list only if 
        /// they have an upload ID lexicographically greater than the specified upload-id-marker. 
        /// </remarks>
        public string UploadIdMarker
        {
            get { return this.uploadIdMarker; }
            set { this.uploadIdMarker = value; }
        }

        /// <summary>
        /// Together with key-marker, specifies the multipart upload after which listing should begin. 
        /// </summary>
        /// <remarks>
        /// If key-marker is not specified, the upload-id-marker parameter is ignored. Otherwise, any 
        /// multipart uploads for a key equal to the key-marker might be included in the list only if 
        /// they have an upload ID lexicographically greater than the specified upload-id-marker. 
        /// </remarks>
        /// <param name="uploadIdMarker">The upload id marker value</param>
        /// <returns>the request with the UploadIdMarker set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListMultipartUploadsRequest WithUploadIdMarker(string uploadIdMarker)
        {
            this.uploadIdMarker = uploadIdMarker;
            return this;
        }

        /// <summary>
        /// Checks if UploadIdMarker property is set.
        /// </summary>
        /// <returns>true if UploadIdMarker property is set.</returns>
        internal bool IsSetUploadIdMarker()
        {
            return !string.IsNullOrEmpty(this.uploadIdMarker);
        }

        #endregion

        #region Prefix

        /// <summary>
        /// Lists in-progress uploads only for those keys that begin with the specified prefix. 
        /// You can use prefixes to separate a bucket into different grouping of keys. (You 
        /// can think of using prefix to make groups in the same way you'd use a folder in a 
        /// file system.) 
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        /// <summary>
        /// Lists in-progress uploads only for those keys that begin with the specified prefix. 
        /// You can use prefixes to separate a bucket into different grouping of keys. (You 
        /// can think of using prefix to make groups in the same way you'd use a folder in a 
        /// file system.) 
        /// </summary>
        /// <param name="prefix">The prefix value</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListMultipartUploadsRequest WithPrefix(string prefix)
        {
            this.prefix = prefix;
            return this;
        }

        /// <summary>
        /// Checks if Prefix property is set
        /// </summary>
        /// <returns>true if Prefix property is set</returns>
        internal bool IsSetPrefix()
        {
            return !System.String.IsNullOrEmpty(this.prefix);
        }

        #endregion

        #region Delimiter

        /// <summary>
        /// Character you use to group keys. 
        /// </summary>
        /// <remarks>
        /// All keys that contain the same string between the prefix, 
        /// if specified, and the first occurrence of the delimiter 
        /// after the prefix are grouped under a single result element, 
        /// CommonPrefixes. If you don't specify the prefix parameter, 
        /// then the substring starts at the beginning of the key. The 
        /// keys that are grouped under CommonPrefixes result element 
        /// are not returned elsewhere in the response.
        /// </remarks>
        public string Delimiter
        {
            get { return this.delimiter; }
            set { this.delimiter = value; }
        }

        /// <summary>
        /// Character you use to group keys. 
        /// </summary>
        /// <remarks>
        /// All keys that contain the same string between the prefix, 
        /// if specified, and the first occurrence of the delimiter 
        /// after the prefix are grouped under a single result element, 
        /// CommonPrefixes. If you don't specify the prefix parameter, 
        /// then the substring starts at the beginning of the key. The 
        /// keys that are grouped under CommonPrefixes result element 
        /// are not returned elsewhere in the response.
        /// </remarks>
        /// <param name="delimiter">The delimiter value</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListMultipartUploadsRequest WithDelimiter(string delimiter)
        {
            this.delimiter = delimiter;
            return this;
        }

        /// <summary>
        /// Checks if Delimiter property is set
        /// </summary>
        /// <returns>true if Delimiter property is set</returns>
        internal bool IsSetDelimiter()
        {
            return !System.String.IsNullOrEmpty(this.delimiter);
        }

        #endregion

    }
}
