/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    public partial class CompleteMultipartUploadRequest : AmazonWebServiceRequest
    {
        /// <summary>
        /// Adds a collection of parts (including ETags and checksums) to this request.
        /// </summary>
        /// <param name="partETags">PartETags that will added to this request.</param>
        public void AddPartETags(params PartETag[] partETags)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (partETags != null)
            {
                foreach (PartETag part in partETags)
                {
                    this.PartETags.Add(part);
                }
            }
        }

        /// <summary>
        /// Adds a collection of parts (including ETags and checksums) to this request.
        /// </summary>
        /// <param name="partETags">PartETags that will added to this request.</param>
        public void AddPartETags(IEnumerable<PartETag> partETags)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (partETags != null)
            {
                foreach (PartETag part in partETags)
                {
                    this.PartETags.Add(part);
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        /// <remarks>
        /// This method only includes ETags. Use one of the <c>AddPartETagsAndChecksums</c> overloads to include checksums as well.
        /// </remarks>
        public void AddPartETags(params UploadPartResponse[] responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (UploadPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: false));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        /// <remarks>
        /// This method only includes ETags. Use one of the <c>AddPartETagsAndChecksums</c> overloads to include checksums as well.
        /// </remarks>
        public void AddPartETags(IEnumerable<UploadPartResponse> responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (UploadPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: false));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers, ETags and checksums by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        public void AddPartETagsAndChecksums(params UploadPartResponse[] responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (UploadPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: true));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers, ETags and checksums by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from UploadParts.</param>
        public void AddPartETagsAndChecksums(IEnumerable<UploadPartResponse> responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (UploadPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: true));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the CopyPartResponse into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from CopyParts.</param>
        /// <remarks>
        /// This method only includes ETags. Use one of the <c>AddPartETagsAndChecksums</c> overloads to include checksums as well.
        /// </remarks>
        public void AddPartETags(params CopyPartResponse[] responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (CopyPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: false));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers and corresponding etags by transforming the CopyPartResponse into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from CopyParts.</param>
        /// <remarks>
        /// This method only includes ETags. Use one of the <c>AddPartETagsAndChecksums</c> overloads to include checksums as well.
        /// </remarks>
        public void AddPartETags(IEnumerable<CopyPartResponse> responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (CopyPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: false));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers, ETags and checksums by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from CopyParts.</param>
        public void AddPartETagsAndChecksums(params CopyPartResponse[] responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (CopyPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: true));
                }
            }
        }

        /// <summary>
        /// Adds a collection of part numbers, ETags and checksums by transforming the UploadPartResponses into PartETags.
        /// </summary>
        /// <param name="responses">The list of response objects return from CopyParts.</param>
        public void AddPartETagsAndChecksums(IEnumerable<CopyPartResponse> responses)
        {
            if (PartETags == null)
            {
                PartETags = new List<PartETag>();
            }

            if (responses != null)
            {
                foreach (CopyPartResponse response in responses)
                {
                    this.PartETags.Add(new PartETag(response, copyChecksums: true));
                }
            }
        }
    }
}
