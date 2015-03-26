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
    /// Container for the parameters to the CompleteMultipartUpload operation.
    /// <para>Completes a multipart upload by assembling previously uploaded parts.</para>
    /// </summary>
    public partial class CompleteMultipartUploadRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string key;
        private List<PartETag> partETags = new List<PartETag>();
        private string uploadId;

        /// <summary>
        /// The name of the bucketName containing the S3 object that was being uploaded in parts.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// The key of the S3 object that was being uploaded.
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
        public void AddPartETags(params PartETag[] partETags)
        {
            foreach (PartETag part in partETags)
            {
                this.PartETags.Add(part);
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags.
        /// </summary>
        /// <param name="partETags">PartETags that will added to this request.</param>
        public void AddPartETags(IEnumerable<PartETag> partETags)
        {
            foreach (PartETag part in partETags)
            {
                this.PartETags.Add(part);
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        public void AddPartETags(params UploadPartResponse[] responses)
        {
            foreach (UploadPartResponse response in responses)
            {
                this.PartETags.Add(new  PartETag(response.PartNumber, response.ETag));
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        public void AddPartETags(IEnumerable<UploadPartResponse> responses)
        {
            foreach (UploadPartResponse response in responses)
            {
                this.PartETags.Add(new PartETag(response.PartNumber, response.ETag));
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the CopyPartResponse into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from CopyParts.</param>
        public void AddPartETags(params CopyPartResponse[] responses)
        {
            foreach (CopyPartResponse response in responses)
            {
                this.PartETags.Add(new PartETag(response.PartNumber, response.ETag));
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the CopyPartResponse into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from CopyParts.</param>
        public void AddPartETags(IEnumerable<CopyPartResponse> responses)
        {
            foreach (CopyPartResponse response in responses)
            {
                this.PartETags.Add(new PartETag(response.PartNumber, response.ETag));
            }
        }

        /// <summary>
        /// The upload id for the in-progress multipart upload that should be completed.
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

    }
}
    
