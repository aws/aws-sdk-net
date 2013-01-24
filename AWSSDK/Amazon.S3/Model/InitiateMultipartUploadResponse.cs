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
using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The InitiateMultipartUploadResponse contains all the information about the
    /// InitiateMultipartUpload method.
    /// </summary>
    public class InitiateMultipartUploadResponse : S3Response
    {
        #region Private Members

        private string bucketName;
        private string key;
        private string uploadId;
        private ServerSideEncryptionMethod serverSideEncryptionMethod;

        #endregion

        /// <summary>
        /// Gets and sets the name of the bucket.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Gets and sets the object key for which the multipart upload was initiated.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Gets and sets the initiated multipart upload id.
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
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
        /// Gets and sets the Headers property.
        /// </summary>
        public override System.Net.WebHeaderCollection Headers
        {
            set
            {
                base.Headers = value;

                string hdr = null;

                ServerSideEncryptionMethod = ServerSideEncryptionMethod.None;
                if (!System.String.IsNullOrEmpty(hdr = value.Get(S3Constants.AmzServerSideEncryptionHeader)))
                {
                    this.ServerSideEncryptionMethod = (ServerSideEncryptionMethod)Enum.Parse(typeof(ServerSideEncryptionMethod), hdr);
                }
            }
        }
    }
}
