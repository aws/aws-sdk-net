/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// The ListMultipartUploadsResponse contains all the information about the
    /// ListMultipartUploads method.
    /// </summary>
    public class ListMultipartUploadsResponse : S3Response
    {
        private string bucketName;
        private string keyMarker;
        private string uploadIdMarker;
        private string nextKeyMarker;
        private string nextUploadIdMarker;
        private int maxUploads;
        private bool isTruncated;
        private List<MultipartUpload> multipartUploads;


        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Gets and sets the KeyMarker which is the key at or after which the listing began.
        /// </summary>
        public string KeyMarker
        {
            get { return this.keyMarker; }
            set { this.keyMarker = value; }
        }

        /// <summary>
        /// Gets and sets the UploadIdMarker property.
        /// </summary>
        public string UploadIdMarker
        {
            get { return this.uploadIdMarker; }
            set { this.uploadIdMarker = value; }
        }

        /// <summary>
        /// Gets and sets the NextKeyMarker property.
        /// <para>
        /// When a list is truncated, specifies the last multipart upload that should
        /// be skipped over to resume listing. Use this value for the KeyMarker
        /// request parameter in a subsequent request.        
        /// </para>
        /// </summary>
        public string NextKeyMarker
        {
            get { return this.nextKeyMarker; }
            set { this.nextKeyMarker = value; }
        }

        /// <summary>
        /// Gets and sets the NextUploadIdMarker property.
        /// <para>
        /// When a list is truncated, specifies the last multipart upload that should
        /// be skipped over to resume listing. Use this value for the
        /// UploadIdMarker request parameter in a subsequent request.
        /// </para>
        /// </summary>
        public string NextUploadIdMarker
        {
            get { return this.nextUploadIdMarker; }
            set { this.nextUploadIdMarker = value; }
        }

        /// <summary>
        /// Gets and sets the MaxUploads property.
        /// </summary>
        public int MaxUploads
        {
            get { return this.maxUploads; }
            set { this.maxUploads = value; }
        }

        /// <summary>
        /// Gets and sets the IsTruncated property.
        /// <para>
        /// Indicates whether the returned list of multipart uploads is truncated. A
        /// value true indicates the list was truncated. The list may be truncated if
        /// the number of multipart uploads exceeds the limit specified by
        /// MaxUploads.
        /// </para>
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated; }
            set { this.isTruncated = value; }
        }

        /// <summary>
        /// Gets and sets the MultipartUploads property.
        /// <para>
        /// Container for elements related to a particular multipart upload. A response
        /// can contain zero or more Upload elements.
        /// </para>
        /// </summary>
        public List<MultipartUpload> MultipartUploads
        {
            get { return this.multipartUploads; }
            set { this.multipartUploads = value; }
        }

    }
}
