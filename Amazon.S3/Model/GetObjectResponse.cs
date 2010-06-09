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

using Amazon.Util;
using Amazon.S3.Util;

using System;

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
            }
        }
    }
}