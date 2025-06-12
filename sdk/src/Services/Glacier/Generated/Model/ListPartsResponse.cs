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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
    /// Contains the Amazon S3 Glacier response to your request.
    /// </summary>
    public partial class ListPartsResponse : AmazonWebServiceResponse
    {
        private string _archiveDescription;
        private DateTime? _creationDate;
        private string _marker;
        private string _multipartUploadId;
        private List<PartListElement> _parts = AWSConfigs.InitializeCollections ? new List<PartListElement>() : null;
        private long? _partSizeInBytes;
        private string _vaultARN;

        /// <summary>
        /// Gets and sets the property ArchiveDescription. 
        /// <para>
        /// The description of the archive that was specified in the Initiate Multipart Upload
        /// request.
        /// </para>
        /// </summary>
        public string ArchiveDescription
        {
            get { return this._archiveDescription; }
            set { this._archiveDescription = value; }
        }

        // Check to see if ArchiveDescription property is set
        internal bool IsSetArchiveDescription()
        {
            return this._archiveDescription != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The UTC time at which the multipart upload was initiated.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string that represents where to continue pagination of the results. You
        /// use the marker in a new List Parts request to obtain more jobs in the list. If there
        /// are no more parts, this value is <c>null</c>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MultipartUploadId. 
        /// <para>
        /// The ID of the upload to which the parts are associated.
        /// </para>
        /// </summary>
        public string MultipartUploadId
        {
            get { return this._multipartUploadId; }
            set { this._multipartUploadId = value; }
        }

        // Check to see if MultipartUploadId property is set
        internal bool IsSetMultipartUploadId()
        {
            return this._multipartUploadId != null;
        }

        /// <summary>
        /// Gets and sets the property Parts. 
        /// <para>
        /// A list of the part sizes of the multipart upload. Each object in the array contains
        /// a <c>RangeBytes</c> and <c>sha256-tree-hash</c> name/value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PartListElement> Parts
        {
            get { return this._parts; }
            set { this._parts = value; }
        }

        // Check to see if Parts property is set
        internal bool IsSetParts()
        {
            return this._parts != null && (this._parts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PartSizeInBytes. 
        /// <para>
        /// The part size in bytes. This is the same value that you specified in the Initiate
        /// Multipart Upload request.
        /// </para>
        /// </summary>
        public long? PartSizeInBytes
        {
            get { return this._partSizeInBytes; }
            set { this._partSizeInBytes = value; }
        }

        // Check to see if PartSizeInBytes property is set
        internal bool IsSetPartSizeInBytes()
        {
            return this._partSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VaultARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vault to which the multipart upload was initiated.
        /// </para>
        /// </summary>
        public string VaultARN
        {
            get { return this._vaultARN; }
            set { this._vaultARN = value; }
        }

        // Check to see if VaultARN property is set
        internal bool IsSetVaultARN()
        {
            return this._vaultARN != null;
        }

    }
}