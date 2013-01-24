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
    /// The PutObjectResponse contains any headers returned by S3.
    /// </summary>
    public class PutObjectResponse : S3Response
    {
        private string etag;
        private string versionId;
        private ServerSideEncryptionMethod serverSideEncryptionMethod;
        private Expiration expiration;

        /// <summary>
        /// Gets and sets the ETag property.
        /// </summary>
        public string ETag
        {
            get { return this.etag; }
            set { this.etag = value; }
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
        /// Gets and sets the Headers property.
        /// </summary>
        public override System.Net.WebHeaderCollection Headers
        {
            set
            {
                base.Headers = value;

                string hdr = null;
                if (!System.String.IsNullOrEmpty(hdr = value.Get(AWSSDKUtils.ETagHeader)))
                {
                    this.ETag = hdr;
                }

                if (!System.String.IsNullOrEmpty(hdr = value.Get(S3Constants.AmzVersionIdHeader)))
                {
                    this.VersionId = hdr;
                }

                if (!System.String.IsNullOrEmpty(hdr = value.Get(S3Constants.AmzExpirationHeader)))
                {
                    this.Expiration = new Expiration(hdr);
                }

                ServerSideEncryptionMethod = ServerSideEncryptionMethod.None;
                if (!System.String.IsNullOrEmpty(hdr = value.Get(S3Constants.AmzServerSideEncryptionHeader)))
                {
                    this.ServerSideEncryptionMethod = (ServerSideEncryptionMethod)Enum.Parse(typeof(ServerSideEncryptionMethod), hdr);
                }
            }
        }
    }
}