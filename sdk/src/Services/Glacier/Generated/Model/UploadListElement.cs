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
    /// A list of in-progress multipart uploads for a vault.
    /// </summary>
    public partial class UploadListElement
    {
        private string _archiveDescription;
        private DateTime? _creationDate;
        private string _multipartUploadId;
        private long? _partSizeInBytes;
        private string _vaultARN;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UploadListElement() { }

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
        /// Gets and sets the property MultipartUploadId. 
        /// <para>
        /// The ID of a multipart upload.
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
        /// Gets and sets the property PartSizeInBytes. 
        /// <para>
        /// The part size, in bytes, specified in the Initiate Multipart Upload request. This
        /// is the size of all the parts in the upload except the last part, which may be smaller
        /// than this size.
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
        /// The Amazon Resource Name (ARN) of the vault that contains the archive.
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