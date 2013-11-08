/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  ListMultipartUploads response and response metadata.
    /// </summary>
    public class ListMultipartUploadsResponse : AmazonWebServiceResponse
    {
        private string bucketName;
        private string keyMarker;
        private string uploadIdMarker;
        private string nextKeyMarker;
        private string nextUploadIdMarker;
        private int? maxUploads;
        private bool? isTruncated;

        private List<MultipartUpload> multipartUploads;
        private string delimiter;
        private List<string> commonPrefixes;
        private string prefix;

        /// <summary>
        /// Name of the bucketName to which the multipart upload was initiated.
        ///  
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// The key at or after which the listing began.
        ///  
        /// </summary>
        public string KeyMarker
        {
            get { return this.keyMarker; }
            set { this.keyMarker = value; }
        }

        // Check to see if KeyMarker property is set
        internal bool IsSetKeyMarker()
        {
            return this.keyMarker != null;
        }

        /// <summary>
        /// Upload ID after which listing began.
        ///  
        /// </summary>
        public string UploadIdMarker
        {
            get { return this.uploadIdMarker; }
            set { this.uploadIdMarker = value; }
        }

        // Check to see if UploadIdMarker property is set
        internal bool IsSetUploadIdMarker()
        {
            return this.uploadIdMarker != null;
        }

        /// <summary>
        /// When a list is truncated, this element specifies the value that should be used for the key-marker request parameter in a subsequent request.
        ///  
        /// </summary>
        public string NextKeyMarker
        {
            get { return this.nextKeyMarker; }
            set { this.nextKeyMarker = value; }
        }

        // Check to see if NextKeyMarker property is set
        internal bool IsSetNextKeyMarker()
        {
            return this.nextKeyMarker != null;
        }

        /// <summary>
        /// When a list is truncated, this element specifies the value that should be used for the upload-id-marker request parameter in a subsequent
        /// request.
        ///  
        /// </summary>
        public string NextUploadIdMarker
        {
            get { return this.nextUploadIdMarker; }
            set { this.nextUploadIdMarker = value; }
        }

        // Check to see if NextUploadIdMarker property is set
        internal bool IsSetNextUploadIdMarker()
        {
            return this.nextUploadIdMarker != null;
        }

        /// <summary>
        /// Maximum number of multipart uploads that could have been included in the response.
        ///  
        /// </summary>
        public int MaxUploads
        {
            get { return this.maxUploads ?? default(int); }
            set { this.maxUploads = value; }
        }

        // Check to see if MaxUploads property is set
        internal bool IsSetMaxUploads()
        {
            return this.maxUploads.HasValue;
        }

        /// <summary>
        /// Indicates whether the returned list of multipart uploads is truncated. A value of true indicates that the list was truncated. The list can
        /// be truncated if the number of multipart uploads exceeds the limit allowed or specified by max uploads.
        ///  
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated ?? default(bool); }
            set { this.isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;
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
            get 
            {
                if (this.multipartUploads == null)
                    this.multipartUploads = new List<MultipartUpload>();

                return this.multipartUploads; 
            }
            set { this.multipartUploads = value; }
        }

        /// <summary>
        /// Gets and sets the Prefix property.
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        /// <summary>
        /// Gets and sets the Delimiter property.
        /// </summary>
        public string Delimiter
        {
            get { return this.delimiter; }
            set { this.delimiter = value; }
        }

        /// <summary>
        /// Gets the CommonPrefixes property. 
        /// A response can contain CommonPrefixes only if you specify a delimiter. 
        /// When you do, CommonPrefixes contains all (if there are any) keys between 
        /// Prefix and the next occurrence of the string specified by delimiter. In effect, 
        /// CommonPrefixes lists keys that act like subdirectories in the directory specified 
        /// by Prefix. For example, if prefix is notes/ and delimiter is a slash (/), in 
        /// notes/summer/july, the common prefix is notes/summer/.
        /// </summary>
        public List<string> CommonPrefixes
        {
            get
            {
                if (this.commonPrefixes == null)
                {
                    this.commonPrefixes = new List<string>();
                }
                return this.commonPrefixes;
            }
        }
    }
}
    
