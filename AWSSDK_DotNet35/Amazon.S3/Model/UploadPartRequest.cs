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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to request upload of a part in a multipart upload operation.
    /// </summary>
    /// <remarks>
    /// <para>
    /// If PartSize is not specified then the rest of the content from the file
    /// or stream will be sent to Amazon S3.
    /// </para>
    /// <para>
    /// You must set either the FilePath or InputStream.  If FilePath is set then the FilePosition
    /// property must be set.
    /// </para>
    /// </remarks>
    public partial class UploadPartRequest : AmazonWebServiceRequest
    {
        private Stream inputStream;
        private string bucketName;
        private string key;
        private int? partNumber;
        private string uploadId;
        private long? partSize;
        private string md5Digest;

        private string filePath;
        private long? filePosition;

        private bool lastPart;
        
        internal int IVSize { get; set; }

        /// <summary>
        /// Caller needs to set this to true when uploading the last part. This property only needs to be set
        /// when using the AmazonS3EncryptionClient.
        /// </summary>
        public bool IsLastPart
        {
            get { return this.lastPart; }
            set { this.lastPart = value; }
        }

        /// <summary>
        /// Input stream for the request; content for the request will be read from the stream.
        /// </summary>
        public Stream InputStream
        {
            get { return this.inputStream; }
            set { this.inputStream = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetInputStream()
        {
            return this.inputStream != null;
        }

        /// <summary>
        /// The name of the bucket containing the object to receive the part.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// The key of the object.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// Part number of part being uploaded.
        ///  
        /// </summary>
        public int PartNumber
        {
            get { return this.partNumber.GetValueOrDefault(); }
            set { this.partNumber = value; }
        }

        // Check to see if PartNumber property is set
        internal bool IsSetPartNumber()
        {
            return this.partNumber.HasValue;
        }

        /// <summary>
        /// The size of the part to be uploaded.
        /// </summary>
        public long PartSize
        {
            get { return this.partSize.GetValueOrDefault(); }
            set { this.partSize = value; }
        }

        /// <summary>
        /// Checks if PartSize property is set.
        /// </summary>
        /// <returns>true if PartSize property is set.</returns>
        internal bool IsSetPartSize()
        {
            return this.partSize.HasValue;
        }

        /// <summary>
        /// Upload ID identifying the multipart upload whose part is being uploaded.
        ///  
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this.uploadId != null;
        }

        /// <summary>
        /// An MD5 digest for the part.
        /// </summary>
        public string MD5Digest
        {
            get { return this.md5Digest; }
            set { this.md5Digest = value; }
        }

        /// <summary>
		/// <para>
        /// Full path and name of a file from which the content for the part is retrieved.
		/// </para>
        /// <para>
        /// For WinRT and Windows Phone this property must be in the form of "ms-appdata:///local/file.txt".
        /// </para>
        /// </summary>
        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }

        /// <summary>
        /// Checks if the FilePath property is set.
        /// </summary>
        /// <returns>true if FilePath property is set.</returns>
        internal bool IsSetFilePath()
        {
            return !string.IsNullOrEmpty(this.filePath);
        }

        /// <summary>
        /// Position in the file specified by FilePath from which to retrieve the content of the part. 
        /// This field is required when a file path is specified. It is ignored when using the InputStream property.
        /// </summary>
        public long FilePosition
        {
            get { return this.filePosition.GetValueOrDefault(); }
            set { this.filePosition = value; }
        }

        /// <summary>
        /// Checks if the FilePosition property is set.
        /// </summary>
        /// <returns>true if FilePosition property is set.</returns>
        internal bool IsSetFilePosition()
        {
            return this.filePosition.HasValue;
        }

        /// <summary>
        /// Checks if the MD5Digest property is set.
        /// </summary>
        /// <returns>true if Md5Digest property is set.</returns>
        internal bool IsSetMD5Digest()
        {
            return !string.IsNullOrEmpty(this.md5Digest);
        }

        /// <summary>
        /// Attach a callback that will be called as data is being sent to the AWS Service.
        /// </summary>
        public EventHandler<Amazon.Runtime.StreamTransferProgressArgs> StreamTransferProgress
        {
            get
            {
                return this.StreamUploadProgressCallback;
            }
            set
            {
                this.StreamUploadProgressCallback = value;
            }
        }



        internal override bool IncludeSHA256Header
        {
            get
            {
                return false;
            }
        }

        internal override bool Expect100Continue
        {
            get
            {
                return true;
            }
        }
    }
}

