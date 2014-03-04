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
using Amazon.S3.Util;
using Amazon.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The GetObjectMetadataResponse contains any headers returned by S3.
    /// </summary>
    public class GetObjectMetadataResponse : S3Response
    {
        private DateTime? lastModified;
        private string etag;
        private long contentLength;
        private string contentType;
        private string versionId;
        private ServerSideEncryptionMethod serverSideEncryptionMethod;
        private Expiration expiration;
        private string websiteRedirectLocation;
        
        private DateTime? restoreExpiration;
        private bool restoreInProgress;

        /// <summary>
        /// Gets and sets the lastModified property.
        /// </summary>
        public DateTime LastModified
        {
            get { return this.lastModified.GetValueOrDefault(); }
            set { this.lastModified = value; }
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
                if (!String.IsNullOrEmpty(hdr = value.Get("Last-Modified")))
                {
                    this.LastModified = DateTime.SpecifyKind(DateTime.ParseExact(hdr,
                                                                                 AWSSDKUtils.GMTDateFormat, 
                                                                                 System.Globalization.CultureInfo.InvariantCulture),
                                                             DateTimeKind.Utc);
                }

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

                if (!System.String.IsNullOrEmpty(hdr = value.Get(Util.S3Constants.AmzVersionIdHeader)))
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

                if (!string.IsNullOrEmpty(hdr = value.Get(S3Constants.AmzRestoreHeader)))
                {
                    AmazonS3Util.ParseAmzRestoreHeader(hdr, out this.restoreInProgress, out this.restoreExpiration);
                }
            }
        }
    }
}