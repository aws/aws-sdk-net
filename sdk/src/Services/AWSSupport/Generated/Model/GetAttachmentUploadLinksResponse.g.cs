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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property NextIndex. 
        /// <para>
        /// The next part index to request presigned URLs for. If all upload URLs for the file
        /// have been returned, this field is <c>null</c>. Use this value as the <c>startIndex</c>
        /// in <c>uploadRange</c> on a subsequent call to <c>GetAttachmentUploadLinks</c> to retrieve
        /// the next batch of upload URLs.
        /// </para>
        /// </summary>
        public int? NextIndex { get; set; }

        /// <summary>
        /// Checks to see if the NextIndex property is set.
        /// </summary>
        internal bool IsSetNextIndex() => this.NextIndex.HasValue;

        /// <summary>
        /// Gets and sets the property PartSizeBytes. 
        /// <para>
        /// The size, in bytes, of each part. Split the file into parts of this size before you
        /// upload them to the presigned URLs. For an upload with <c>n</c> total parts, parts
        /// 1 through <c>n</c> - 1 are exactly this size; the last part may be smaller. Maximum:
        /// 104,857,600 bytes (approximately 100 MB).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 104857600)]
        public long? PartSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the PartSizeBytes property is set.
        /// </summary>
        internal bool IsSetPartSizeBytes() => this.PartSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property TotalParts. 
        /// <para>
        /// The total number of parts that the file is split into. Upload one part to each presigned
        /// URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalParts { get; set; }

        /// <summary>
        /// Checks to see if the TotalParts property is set.
        /// </summary>
        internal bool IsSetTotalParts() => this.TotalParts.HasValue;

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The unique identifier for the multipart upload. Use this value in subsequent calls
        /// to <c>GetAttachmentUploadLinks</c>, <a>DescribeAttachmentUploadStatus</a>, and <a>CompleteAttachmentUpload</a>,
        /// and to attach the upload to a case through the <c>uploadIds</c> parameter on <a>CreateCase</a>
        /// or <a>AddCommunicationToCase</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string UploadId { get; set; }

        /// <summary>
        /// Checks to see if the UploadId property is set.
        /// </summary>
        internal bool IsSetUploadId() => this.UploadId != null;

        /// <summary>
        /// Gets and sets the property UploadUrls. 
        /// <para>
        /// The list of presigned upload URLs for the requested range of parts. The list contains
        /// at most 10 URLs per call. Upload each part to its corresponding URL by using HTTP
        /// <c>PUT</c> before the URL expires.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<UploadUrl> UploadUrls { get; set; } = AWSConfigs.InitializeCollections ? new List<UploadUrl>() : null;

        /// <summary>
        /// Checks to see if the UploadUrls property is set.
        /// </summary>
        internal bool IsSetUploadUrls() => this.UploadUrls != null && (this.UploadUrls.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
