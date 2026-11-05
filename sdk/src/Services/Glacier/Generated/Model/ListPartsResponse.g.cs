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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// This is the response object from the ListParts operation.
    /// </summary>
    public partial class ListPartsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ArchiveDescription. 
        /// <para>
        /// The description of the archive that was specified in the Initiate Multipart Upload
        /// request.
        /// </para>
        /// </summary>
        public string ArchiveDescription { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveDescription property is set.
        /// </summary>
        internal bool IsSetArchiveDescription() => this.ArchiveDescription != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The UTC time at which the multipart upload was initiated.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string that represents where to continue pagination of the results. You
        /// use the marker in a new List Parts request to obtain more jobs in the list. If there
        /// are no more parts, this value is <c>null</c>.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MultipartUploadId. 
        /// <para>
        /// The ID of the upload to which the parts are associated.
        /// </para>
        /// </summary>
        public string MultipartUploadId { get; set; }

        /// <summary>
        /// Checks to see if the MultipartUploadId property is set.
        /// </summary>
        internal bool IsSetMultipartUploadId() => this.MultipartUploadId != null;

        /// <summary>
        /// Gets and sets the property PartSizeInBytes. 
        /// <para>
        /// The part size in bytes. This is the same value that you specified in the Initiate
        /// Multipart Upload request.
        /// </para>
        /// </summary>
        public long? PartSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the PartSizeInBytes property is set.
        /// </summary>
        internal bool IsSetPartSizeInBytes() => this.PartSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property Parts. 
        /// <para>
        /// A list of the part sizes of the multipart upload. Each object in the array contains
        /// a <c>RangeBytes</c> and <c>sha256-tree-hash</c> name/value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PartListElement> Parts { get; set; } = AWSConfigs.InitializeCollections ? new List<PartListElement>() : null;

        /// <summary>
        /// Checks to see if the Parts property is set.
        /// </summary>
        internal bool IsSetParts() => this.Parts != null && (this.Parts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VaultARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vault to which the multipart upload was initiated.
        /// </para>
        /// </summary>
        public string VaultARN { get; set; }

        /// <summary>
        /// Checks to see if the VaultARN property is set.
        /// </summary>
        internal bool IsSetVaultARN() => this.VaultARN != null;
    }
}
