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
    /// The UploadPartRequest contains the parameters used for the UploadPart method. 
    /// <para>
    /// If PartSize is not specified then the rest of the content from the file
    /// or stream will be sent to Amazon S3.
    /// </para>
    /// <para>
    /// You must set either the FilePath or InputStream.  If FilePath is set then the FilePosition
    /// property must be set.
    /// </para>
    /// <br />Required Parameters: BucketName, Key, UploadId, PartNumber
    /// </summary>
    public class UploadPartRequest : S3Request
    {
        private string bucketName;
        private string key;
        private string uploadId;
        private int? partNumber;
        private long? partSize;
        private string md5Digest;
        private bool fGenerateMD5Digest;
        private int timeout = 0;

        private string filePath;
        private long? filePosition;

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
        /// This is the S3 Bucket where the S3 Object you are
        /// creating gets put.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>the request with the BucketName set</returns>
        public UploadPartRequest WithBucketName(string bucketName)
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

        #region Key
        /// <summary>
        /// Gets and sets the Key property.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the Key property for this request.
        /// This is the Key for the S3 Object you create.
        /// </summary>
        /// <param name="key">The value that Key is set to</param>
        /// <returns>the request with the Key set</returns>
        public UploadPartRequest WithKey(string key)
        {
            this.key = key;
            return this;
        }

        /// <summary>
        /// Checks if Key property is set.
        /// </summary>
        /// <returns>true if Key property is set.</returns>
        internal bool IsSetKey()
        {
            return !System.String.IsNullOrEmpty(this.key);
        }

        #endregion

        #region UploadId
        /// <summary>
        /// Gets and sets the UploadId property.
        /// This is the upload id for the multipart upload in process.
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }

        /// <summary>
        /// Sets the UploadId property for this request.
        /// This is the upload id for the multipart upload in process.
        /// </summary>
        /// <param name="uploadId">The value that UploadId is set to</param>
        /// <returns>the request with the UploadId set</returns>
        public UploadPartRequest WithUploadId(string uploadId)
        {
            this.uploadId = uploadId;
            return this;
        }

        /// <summary>
        /// Checks if UploadId property is set.
        /// </summary>
        /// <returns>true if UploadId property is set.</returns>
        internal bool IsSetUploadId()
        {
            return !System.String.IsNullOrEmpty(this.uploadId);
        }

        #endregion

        #region PartNumber
        /// <summary>
        /// Gets and sets the PartNumber property.
        /// </summary>
        public int PartNumber
        {
            get { return this.partNumber.GetValueOrDefault(); }
            set { this.partNumber = value; }
        }

        /// <summary>
        /// Sets the PartNumber property for this request.
        /// </summary>
        /// <param name="partNumber">The value that PartNumber is set to</param>
        /// <returns>the request with the PartNumber set</returns>
        public UploadPartRequest WithPartNumber(int partNumber)
        {
            this.partNumber = partNumber;
            return this;
        }

        /// <summary>
        /// Checks if PartNumber property is set.
        /// </summary>
        /// <returns>true if PartNumber property is set.</returns>
        internal bool IsSetPartNumber()
        {
            return this.partNumber.HasValue;
        }

        #endregion

        #region PartSize
        /// <summary>
        /// Gets and sets the PartSize property.
        /// </summary>
        public long PartSize
        {
            get { return this.partSize.GetValueOrDefault(); }
            set { this.partSize = value; }
        }

        /// <summary>
        /// Sets the PartSize property for this request.
        /// </summary>
        /// <param name="partSize">The value that PartSize is set to</param>
        /// <returns>the request with the PartSize set</returns>
        public UploadPartRequest WithPartSize(long partSize)
        {
            this.partSize = partSize;
            return this;
        }

        /// <summary>
        /// Checks if PartSize property is set.
        /// </summary>
        /// <returns>true if PartSize property is set.</returns>
        internal bool IsSetPartSize()
        {
            return this.partSize.HasValue;
        }

        #endregion

        #region MD5Digest
        /// <summary>
        /// Gets and sets the MD5Digest property.
        /// </summary>
        public string MD5Digest
        {
            get { return this.md5Digest; }
            set { this.md5Digest = value; }
        }

        /// <summary>
        /// Sets the MD5Digest property for this request.
        /// </summary>
        /// <param name="md5Digest">The value that Md5Digest is set to</param>
        /// <returns>the request with the Md5Digest set</returns>
        public UploadPartRequest WithMD5Digest(string md5Digest)
        {
            this.md5Digest = md5Digest;
            return this;
        }

        /// <summary>
        /// Checks if Md5Digest property is set.
        /// </summary>
        /// <returns>true if Md5Digest property is set.</returns>
        internal bool IsSetMD5Digest()
        {
            return !string.IsNullOrEmpty(this.md5Digest);
        }

        #endregion

        #region GenerateMD5Digest
        /// <summary>
        /// Gets and Sets the property that governs whether
        /// a md5Digest is generated for the part being
        /// PUT into S3.
        /// </summary>
        public bool GenerateMD5Digest
        {
            get { return this.fGenerateMD5Digest; }
            set { this.fGenerateMD5Digest = value; }
        }

        /// <summary>
        /// Sets the GenerateMD5Digest property. If this property is set,
        /// the MD5 md5Digest of the part to be uploaded is generated
        /// prior to the data being sent to S3.
        /// </summary>
        /// <param name="fGenerateMD5Digest">GenerateMD5Digest property</param>
        /// <returns>this instance</returns>
        /// <remarks>This is a computationally expensive operation,
        /// and will add to the total time it will take to upload
        /// data to S3. Please use this option judicially.
        /// </remarks>
        public UploadPartRequest WithGenerateChecksum(bool fGenerateMD5Digest)
        {
            this.fGenerateMD5Digest = fGenerateMD5Digest;
            return this;
        }

        #endregion

        #region FilePath
        /// <summary>
        /// Gets and sets the FilePath property.
        /// </summary>
        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }

        /// <summary>
        /// Sets the FilePath property for this request.
        /// </summary>
        /// <param name="filePath">The value that FilePath is set to</param>
        /// <returns>the request with the FilePath set</returns>
        public UploadPartRequest WithFilePath(string filePath)
        {
            this.filePath = filePath;
            return this;
        }

        /// <summary>
        /// Checks if FilePath property is set.
        /// </summary>
        /// <returns>true if FilePath property is set.</returns>
        internal bool IsSetFilePath()
        {
            return !string.IsNullOrEmpty(this.filePath);
        }

        #endregion

        #region FilePosition
        /// <summary>
        /// Gets and sets the FilePosition property.  This field is required when
        /// a file path is specified.  It is ignored when using the InputStream property.
        /// </summary>
        public long FilePosition
        {
            get { return this.filePosition.GetValueOrDefault(); }
            set { this.filePosition = value; }
        }

        /// <summary>
        /// Sets the FilePosition property for this request.
        /// </summary>
        /// <param name="filePosition">The value that FilePosition is set to</param>
        /// <returns>the request with the FilePosition set</returns>
        public UploadPartRequest WithFilePosition(long filePosition)
        {
            this.filePosition = filePosition;
            return this;
        }

        /// <summary>
        /// Checks if FilePosition property is set.
        /// </summary>
        /// <returns>true if FilePosition property is set.</returns>
        internal bool IsSetFilePosition()
        {
            return this.filePosition.HasValue;
        }

        #endregion

        #region Timeout

        /// <summary>
        /// Gets and sets of the Timeout property (in milliseconds).
        /// The value of this property is assigned to the
        /// ReadWriteTimeout and Timeout properties of the
        /// HTTPWebRequest object used for S3 PUT Object requests.
        /// </summary>
        /// <remarks>A value less than or equal to 0 will be silently ignored</remarks>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        public int Timeout
        {
            get { return this.timeout; }
            set
            {
                if (value > 0)
                {
                    this.timeout = value;
                }
            }
        }

        /// <summary>
        /// Sets the Timeout property (in milliseconds).
        /// Please set the timeout only if you are certain that
        /// the file will not be transferred within the default intervals
        /// for an HttpWebRequest.
        /// </summary>
        /// <param name="timeout">Timeout property</param>
        /// <remarks>A value less than or equal to 0 will be silently ignored</remarks>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        public UploadPartRequest WithTimeout(int timeout)
        {
            Timeout = timeout;
            return this;
        }

        internal override bool SupportTimeout
        {
            get { return true; }
        }

        #endregion


        /// <summary>
        /// The event for Put Object progress notifications. All
        /// subscribers will be notified when a new progress
        /// event is raised.
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// put object progress notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void displayProgress(object sender, PutObjectProgressArgs args)
        /// {
        ///     Console.WriteLine(args);
        /// }
        /// </code>
        /// 2. Add this method to the Put Object Progress Event delegate's invocation list
        /// <code>
        /// PutObjectRequest request = new PutObjectRequest();
        /// request.PutObjectProgressEvent += displayProgress;
        /// </code>
        /// </remarks>
        public event EventHandler<UploadPartProgressArgs> UploadPartProgressEvent;

        /// <summary>
        /// The "handler" will be notified every time a put
        /// object progress event is raised.
        /// </summary>
        /// <param name="handler">A method that consumes the put object progress notification</param>
        /// <returns>this instance of the PutObjectRequest</returns>
        public UploadPartRequest WithSubscriber(EventHandler<UploadPartProgressArgs> handler)
        {
            this.UploadPartProgressEvent += handler;
            return this;
        }

        /// <summary>
        /// This method is called by a producer of put object progress
        /// notifications. When called, all the subscribers in the 
        /// invocation list will be called sequentially.
        /// </summary>
        /// <param name="incrementTransferred">The number of bytes transferred since last event</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        internal override void OnRaiseProgressEvent(long incrementTransferred, long transferred, long total)
        {
            // Make a temporary copy of the event to avoid the possibility of
            // a race condition if the last and only subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            EventHandler<UploadPartProgressArgs> handler = UploadPartProgressEvent;
            try
            {
                // Event will be null if there are no subscribers
                if (handler != null)
                {
                    // This automatically calls all subscribers sequentially
                    // http://msdn.microsoft.com/en-us/library/ms173172%28VS.80%29.aspx
                    handler(this, new UploadPartProgressArgs(incrementTransferred, transferred, total));
                }
            }
            catch
            {
            }
        }


        internal override bool Expect100Continue
        {
            get { return true; }
        }
    }

    /// <summary>
    /// Encapsulates the information needed to provide
    /// transfer progress to subscribers of the Put Object
    /// Event.
    /// </summary>
    public class UploadPartProgressArgs : TransferProgressArgs
    {
        /// <summary>
        /// The constructor takes the number of
        /// currently transferred bytes and the
        /// total number of bytes to be transferred
        /// </summary>
        /// <param name="incrementTransferred">The number of bytes transferred since last event</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        public UploadPartProgressArgs(long incrementTransferred, long transferred, long total)
            : base(incrementTransferred, transferred, total)
        {
        }
    }
}
