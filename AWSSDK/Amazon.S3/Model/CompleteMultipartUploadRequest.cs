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
using System.IO;
using System.Xml;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to request completion of a multipart upload by assembling previously uploaded parts.
    /// </summary>
    public class CompleteMultipartUploadRequest : S3Request
    {
        private string bucketName;
        private string key;
        private string uploadId;
        private List<PartETag> partETags = new List<PartETag>();
    
        #region BucketName

        /// <summary>
        /// The name of the bucket containing the S3 object that was being uploaded in parts.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket containing the S3 object that was being uploaded in parts.
        /// </summary>
        /// <param name="bucketName">S3 bucket name</param>
        /// <returns>the request with the BucketName set</returns>
        public CompleteMultipartUploadRequest WithBucketName(string bucketName)
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
        /// The key of the S3 object that was being uploaded.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets the key of the S3 object that was being uploaded.
        /// </summary>
        /// <param name="key">S3 object key</param>
        /// <returns>the request with the Key set</returns>
        public CompleteMultipartUploadRequest WithKey(string key)
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
        /// The upload id for the in-progress multipart upload that should be completed.
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }

        /// <summary>
        /// Sets the upload id for the in-progress multipart upload that should be completed.
        /// </summary>
        /// <param name="uploadId">Id of the multipart upload</param>
        /// <returns>the request with the UploadId set</returns>
        public CompleteMultipartUploadRequest WithUploadId(string uploadId)
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

        #region PartETags

        /// <summary>
        /// A collection of part numbers and corresponding etags.
        /// </summary>
        public List<PartETag> PartETags
        {
            get 
            {
                if (this.partETags == null)
                {
                    this.partETags = new List<PartETag>();
                }

                return this.partETags; 
            }
            set { this.partETags = value; }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags.
        /// </summary>
        /// <param name="partETags">PartETags that will added to this request.</param>
        /// <returns>the request with the PartETags set</returns>
        public CompleteMultipartUploadRequest WithPartETags(params PartETag[] partETags)
        {
            foreach (PartETag part in partETags)
            {
                this.PartETags.Add(part);
            }
            return this;
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags.
        /// </summary>
        /// <param name="partETags">PartETags that will added to this request.</param>
        /// <returns>The request with the PartETags set</returns>
        public CompleteMultipartUploadRequest WithPartETags(IEnumerable<PartETag> partETags)
        {
            foreach (PartETag part in partETags)
            {
                this.PartETags.Add(part);
            }
            return this;
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        /// <returns>The request with the PartETags set.</returns>
        public CompleteMultipartUploadRequest WithPartETags(params UploadPartResponse[] responses)
        {
            foreach (UploadPartResponse response in responses)
            {
                this.PartETags.Add(new PartETag(response.PartNumber, response.ETag));
            }
            return this;
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        /// <returns>The request with the PartETags set</returns>
        public CompleteMultipartUploadRequest WithPartETags(IEnumerable<UploadPartResponse> responses)
        {
            foreach (UploadPartResponse response in responses)
            {
                this.PartETags.Add(new PartETag(response.PartNumber, response.ETag));
            }
            return this;
        }


        #endregion

        internal string ContentXML
        {
            get
            {
                this.PartETags.Sort();
                StringWriter sw = new StringWriter();
                XmlTextWriter writer = new XmlTextWriter(sw);

                writer.WriteStartElement("CompleteMultipartUpload");
                foreach (PartETag etag in this.PartETags)
                {
                    writer.WriteStartElement("Part");
                    writer.WriteElementString("PartNumber", etag.PartNumber.ToString());
                    writer.WriteElementString("ETag", etag.ETag);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.Close();
                string xml = sw.ToString();
                return xml;
            }
        }
    }
}
