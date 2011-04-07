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
using System.IO;
using System.Xml;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The CompleteMultipartUploadRequest contains the parameters used for the CompleteMultipartUpload method.
    /// <br />Required Parameters: BucketName, Key, UploadId, PartETags
    /// </summary>
    public class CompleteMultipartUploadRequest : S3Request
    {
        private string bucketName;
        private string key;
        private string uploadId;
        private List<PartETag> partETags = new List<PartETag>();
    
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
        /// <param name="uploadId">The value that Key is set to</param>
        /// <returns>the request with the Key set</returns>
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
        /// Gets and sets the PartETags property. This collection contains an entry for every part uploaded 
        /// with its part number and etag.
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
        /// Adds the elements from the array in the collection of PartETags for this request.
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
        /// Adds the elements from the array in the collection of PartETags for this request.
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
        /// Transforms the UploadPartResponses into PartETags and adds them to the request.
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
        /// Transforms the UploadPartResponses into PartETags and adds them to the request.
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
