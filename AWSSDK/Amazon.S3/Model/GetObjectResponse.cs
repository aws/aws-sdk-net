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
using System.IO;

using Amazon.S3.Util;
using Amazon.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The GetObjectResponse contains any header or metadata returned by S3. 
    /// GetObjectResponse's contain resources that need to be disposed. The
    /// recommended way for handling GetObjectResponse objects is wrapping them
    /// in using clauses, like so:
    /// <code>
    /// using (GetObjectResponse response = s3Client.GetObject(request))
    /// {
    ///     ...
    /// }
    /// </code>
    /// This will ensure that any network resources, file streams and web headers
    /// have been returned back to the system for future use.
    /// </summary>
    public class GetObjectResponse : S3Response
    {
        private string etag;
        private long contentLength;
        private string contentType;
        private string versionId;
        private ServerSideEncryptionMethod serverSideEncryptionMethod;
        private Expiration expiration;
        private string websiteRedirectLocation;

        private DateTime? restoreExpiration;
        private bool restoreInProgress;

        string bucketName;
        string key;



        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Gets and sets the Key property.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Gets and sets the ETag property.
        /// </summary>
        public string ETag
        {
            get { return this.etag; }
            set { this.etag = value; }
        }

        /// <summary>
        /// Gets and sets the ContentType property.
        /// </summary>
        public string ContentType
        {
            get { return this.contentType; }
            set { this.contentType = value; }
        }

        /// <summary>
        /// Gets and sets the ContentLength property.
        /// </summary>
        public long ContentLength
        {
            get { return this.contentLength; }
            set { this.contentLength = value; }
        }

        /// <summary>
        /// Gets and sets the VersionId property.
        /// This is the version-id of the S3 object
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Gets and sets the ServerSideEncryptionMethod property.
        /// Specifies the encryption used on the server to
        /// store the content.
        /// Default is None.
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryptionMethod; }
            set { this.serverSideEncryptionMethod = value; }
        }

        /// <summary>
        /// Gets and sets the Expiration property.
        /// Specifies the expiration date for the object and the
        /// rule governing the expiration.
        /// Is null if expiration is not applicable.
        /// </summary>
        public Expiration Expiration
        {
            get { return this.expiration; }
            set { this.expiration = value; }
        }

        /// <summary>
        /// Gets and sets the WebsiteRedirectLocation property.
        /// If this is set then when a GET request is made from the S3 website endpoint a 301 HTTP status code
        /// will be returned indicating a redirect with this value as the redirect location.
        /// </summary>
        public string WebsiteRedirectLocation
        {
            get { return this.websiteRedirectLocation; }
            set { this.websiteRedirectLocation = value; }
        }

        /// <summary>
        /// Gets and sets the RestoreExpiration property.
        /// RestoreExpiration will be set for objects that have been restored from Amazon Glacier.  
        /// It indiciates for those objects how long the restored object will exist.
        /// </summary>
        public DateTime? RestoreExpiration
        {
            get { return this.restoreExpiration; }
            set { this.restoreExpiration = value; }
        }

        /// <summary>
        /// Gets and sets the RestoreInProgress
        /// Will be true when the object is in the process of being restored from Amazon Glacier.
        /// </summary>
        public bool RestoreInProgress
        {
            get { return this.restoreInProgress; }
            set { this.restoreInProgress = value; }
        }

        /// <summary>
        /// Gets and sets the Headers property.
        /// </summary>
        public override System.Net.WebHeaderCollection Headers
        {
            set
            {
                base.Headers = value;

                string hdr = null;
                if (!String.IsNullOrEmpty(hdr = value.Get(AWSSDKUtils.ETagHeader)))
                {
                    this.ETag = hdr;
                }

                if (!String.IsNullOrEmpty(hdr = value.Get(AWSSDKUtils.ContentTypeHeader)))
                {
                    this.ContentType = hdr;
                }

                if (!String.IsNullOrEmpty(hdr = value.Get(AWSSDKUtils.ContentLengthHeader)))
                {
                    this.ContentLength = System.Convert.ToInt64(hdr);
                }

                if (!String.IsNullOrEmpty(hdr = value.Get(S3Constants.AmzVersionIdHeader)))
                {
                    this.VersionId = hdr;
                }

                if (!System.String.IsNullOrEmpty(hdr = value.Get(S3Constants.AmzExpirationHeader)))
                {
                    this.Expiration = new Expiration(hdr);
                }

                if (!System.String.IsNullOrEmpty(hdr = value.Get(S3Constants.AmzWebsiteRedirectLocationHeader)))
                {
                    this.WebsiteRedirectLocation = hdr;
                }

                ServerSideEncryptionMethod = ServerSideEncryptionMethod.None;
                if (!System.String.IsNullOrEmpty(hdr = value.Get(S3Constants.AmzServerSideEncryptionHeader)))
                {
                    this.ServerSideEncryptionMethod = (ServerSideEncryptionMethod)Enum.Parse(typeof(ServerSideEncryptionMethod), hdr);
                }

                if (string.IsNullOrEmpty(hdr = value.Get(S3Constants.AmzRestoreHeader)))
                {
                    AmazonS3Util.ParseAmzRestoreHeader(hdr, out this.restoreInProgress, out this.restoreExpiration);
                }
            }
        }

        /// <summary>
        /// Writes the content of the ResponseStream a file indicated by the filePath argument.
        /// </summary>
        /// <param name="filePath">The location where to write the ResponseStream</param>
        public void WriteResponseStreamToFile(string filePath)
        {
            WriteResponseStreamToFile(filePath, false);
        }

        /// <summary>
        /// Writes the content of the ResponseStream a file indicated by the filePath argument.
        /// </summary>
        /// <param name="filePath">The location where to write the ResponseStream</param>
        /// <param name="append">Whether or not to append to the file if it exists</param>
        public void WriteResponseStreamToFile(string filePath, bool append)
        {
            // Make sure the directory exists to write too.
            FileInfo fi = new FileInfo(filePath);
            Directory.CreateDirectory(fi.DirectoryName);

            Stream downloadStream;
            if(append && File.Exists(filePath))
                downloadStream= new BufferedStream(new FileStream(filePath, FileMode.Append));
            else
                downloadStream = new BufferedStream(new FileStream(filePath, FileMode.Create));

            try
            {
                long current = 0;
                BufferedStream bufferedStream = new BufferedStream(this.ResponseStream);
                byte[] buffer = new byte[S3Constants.DefaultBufferSize];
                int bytesRead = 0;
                while ((bytesRead = bufferedStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    downloadStream.Write(buffer, 0, bytesRead);
                    current += bytesRead;

                    this.OnRaiseProgressEvent(bytesRead, current, this.contentLength);
                }
            }
            finally
            {
                downloadStream.Close();
            }
        }

        #region Progress Event

        /// <summary>
        /// The event for Write Object progress notifications. All
        /// subscribers will be notified when a new progress
        /// event is raised.
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// put object progress notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void displayProgress(object sender, WriteObjectProgressArgs args)
        /// {
        ///     Console.WriteLine(args);
        /// }
        /// </code>
        /// 2. Add this method to the Put Object Progress Event delegate's invocation list
        /// <code>
        /// GetObjectResponse response = s3Client.GetObject(request);
        /// response.WriteObjectProgressEvent += displayProgress;
        /// </code>
        /// </remarks>
        public event EventHandler<WriteObjectProgressArgs> WriteObjectProgressEvent;

        /// <summary>
        /// The "handler" will be notified every time a put
        /// object progress event is raised.
        /// </summary>
        /// <param name="handler">A method that consumes the put object progress notification</param>
        /// <returns>this instance of the PutObjectRequest</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetObjectResponse WithSubscriber(EventHandler<WriteObjectProgressArgs> handler)
        {
            this.WriteObjectProgressEvent += handler;
            return this;
        }

        #endregion

        /// <summary>
        /// This method is called by a producer of write object progress
        /// notifications. When called, all the subscribers in the 
        /// invocation list will be called sequentially.
        /// </summary>
        /// <param name="incrementTransferred">The number of bytes transferred since last event</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        internal void OnRaiseProgressEvent(long incrementTransferred, long transferred, long total)
        {
            AWSSDKUtils.InvokeInBackground(WriteObjectProgressEvent, new WriteObjectProgressArgs(this.bucketName, this.key, this.versionId, incrementTransferred, transferred, total), this);
        }
    }

    /// <summary>
    /// Encapsulates the information needed to provide
    /// download progress for the Write Object Event.
    /// </summary>
    public class WriteObjectProgressArgs : TransferProgressArgs
    {
        string bucketName;
        string key;
        string versionId;

        /// <summary>
        /// The constructor takes the number of
        /// currently transferred bytes and the
        /// total number of bytes to be transferred
        /// </summary>
        /// <param name="bucketName">The bucket name for the S3 object being written.</param>
        /// <param name="key">The object key for the S3 object being written.</param>
        /// <param name="versionId">The version-id of the S3 object.</param>
        /// <param name="incrementTransferred">The number of bytes transferred since last event</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        internal WriteObjectProgressArgs(string bucketName, string key, string versionId, long incrementTransferred, long transferred, long total)
            : base(incrementTransferred, transferred, total)
        {
            this.bucketName = bucketName;
            this.key = key;
            this.versionId = versionId;
        }

        /// <summary>
        /// Gets the bucket name for the S3 object being written.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
        }

        /// <summary>
        /// Gets the object key for the S3 object being written.
        /// </summary>
        public string Key
        {
            get { return this.key; }
        }

        /// <summary>
        /// Gets the version-id of the S3 object.
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
        }
    }

}
