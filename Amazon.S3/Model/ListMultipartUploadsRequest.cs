/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// The ListMultipartUploadsRequest contains the parameters used for the ListMultipartUploads method.
    /// <br />Required Parameters: BucketName
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
        /// Gets and sets the BucketName property.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the BucketName property for this request.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>the request with the BucketName set</returns>
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
        /// Gets and sets the MaxUploads property.
        /// <para>
        /// Sets the maximum number of multipart uploads to return in the response 
        /// body
        /// </para>
        /// </summary>
        public int MaxUploads
        {
            get { return this.maxUploads.GetValueOrDefault(); }
            set { this.maxUploads = value; }
        }

        /// <summary>
        /// Sets the MaxUploads property for this request.
        /// </summary>
        /// <param name="maxUploads">The value that MaxUploads is set to</param>
        /// <returns>the request with the MaxUploads set</returns>
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
        /// Gets and sets the KeyMarker property.
        /// <para>
        /// Together with UploadIdMarker, specifies the multipart upload after
        /// which listing should begin.
        /// </para>
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
        /// </summary>
        public string KeyMarker
        {
            get { return this.keyMarker; }
            set { this.keyMarker = value; }
        }

        /// <summary>
        /// Sets the KeyMarker property for this request.
        /// </summary>
        /// <param name="keyMarker">The value that KeyMarker is set to</param>
        /// <returns>the request with the KeyMarker set</returns>
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
        /// Gets and sets the UploadIdMarker property.
        /// <para>
        /// Together with KeyMarker, specifies the multipart upload after which
        /// listing should begin. If KeyMarker is not specified, the
        /// UploadIdMarker parameter is ignored. Otherwise, any multipart
        /// uploads for a key equal to the KeyMarker may be included in the list
        /// only if they have an upload ID lexicographically greater than the specified
        /// </para>
        /// </summary>
        public string UploadIdMarker
        {
            get { return this.uploadIdMarker; }
            set { this.uploadIdMarker = value; }
        }

        /// <summary>
        /// Sets the UploadIdMarker property for this request.
        /// </summary>
        /// <param name="uploadIdMarker">The value that UploadIdMarker is set to</param>
        /// <returns>the request with the UploadIdMarker set</returns>
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
        /// Gets and sets the Prefix property.
        /// All keys matched will have this prefix.
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        /// <summary>
        /// Sets the Prefix property for this request.
        /// All keys matched will have this prefix.
        /// </summary>
        /// <param name="prefix">The value that Prefix is set to</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Delimiter property.
        /// Causes keys that contain the same string between the prefix and the 
        /// first occurrence of the delimiter to be rolled up into a single result 
        /// element in the CommonPrefixes collection.
        /// </summary>
        /// <remarks>
        /// These rolled-up keys are not returned elsewhere in the response.
        /// </remarks>
        public string Delimiter
        {
            get { return this.delimiter; }
            set { this.delimiter = value; }
        }

        /// <summary>
        /// Sets the Delimiter property for this request.
        /// Causes keys that contain the same string between the prefix and the 
        /// first occurrence of the delimiter to be rolled up into a single result 
        /// element in the CommonPrefixes collection. 
        /// These rolled-up keys are not returned elsewhere in the response.
        /// </summary>
        /// <param name="delimiter">the value that Delimiter is set to.</param>
        /// <returns>this instance</returns>
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
