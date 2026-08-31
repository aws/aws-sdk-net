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

/*
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// This is the response object from the GetAttachmentUploadLinks operation.
    /// </summary>
    public partial class GetAttachmentUploadLinksResponse : AmazonWebServiceResponse
    {
        private int? _nextIndex;
        private long? _partSizeBytes;
        private int? _totalParts;
        private string _uploadId;
        private List<UploadUrl> _uploadUrls = AWSConfigs.InitializeCollections ? new List<UploadUrl>() : null;

        /// <summary>
        /// Gets and sets the property NextIndex. 
        /// <para>
        /// The next part index to request presigned URLs for. If all upload URLs for the file
        /// have been returned, this field is <c>null</c>. Use this value as the <c>startIndex</c>
        /// in <c>uploadRange</c> on a subsequent call to <c>GetAttachmentUploadLinks</c> to retrieve
        /// the next batch of upload URLs.
        /// </para>
        /// </summary>
        public int? NextIndex
        {
            get { return this._nextIndex; }
            set { this._nextIndex = value; }
        }

        // Check to see if NextIndex property is set
        internal bool IsSetNextIndex()
        {
            return this._nextIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartSizeBytes. 
        /// <para>
        /// The size, in bytes, of each part. Split the file into parts of this size before you
        /// upload them to the presigned URLs. For an upload with <c>n</c> total parts, parts
        /// 1 through <c>n</c> - 1 are exactly this size; the last part may be smaller. Maximum:
        /// 104,857,600 bytes (approximately 100 MB).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=104857600)]
        public long? PartSizeBytes
        {
            get { return this._partSizeBytes; }
            set { this._partSizeBytes = value; }
        }

        // Check to see if PartSizeBytes property is set
        internal bool IsSetPartSizeBytes()
        {
            return this._partSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalParts. 
        /// <para>
        /// The total number of parts that the file is split into. Upload one part to each presigned
        /// URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalParts
        {
            get { return this._totalParts; }
            set { this._totalParts = value; }
        }

        // Check to see if TotalParts property is set
        internal bool IsSetTotalParts()
        {
            return this._totalParts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The unique identifier for the multipart upload. Use this value in subsequent calls
        /// to <c>GetAttachmentUploadLinks</c>, <a>DescribeAttachmentUploadStatus</a>, and <a>CompleteAttachmentUpload</a>,
        /// and to attach the upload to a case through the <c>uploadIds</c> parameter on <a>CreateCase</a>
        /// or <a>AddCommunicationToCase</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

        /// <summary>
        /// Gets and sets the property UploadUrls. 
        /// <para>
        /// The list of presigned upload URLs for the requested range of parts. The list contains
        /// at most 10 URLs per call. Upload each part to its corresponding URL by using HTTP
        /// <c>PUT</c> before the URL expires.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<UploadUrl> UploadUrls
        {
            get { return this._uploadUrls; }
            set { this._uploadUrls = value; }
        }

        // Check to see if UploadUrls property is set
        internal bool IsSetUploadUrls()
        {
            return this._uploadUrls != null && (this._uploadUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}