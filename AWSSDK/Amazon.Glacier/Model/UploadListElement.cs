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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// <para>A list of in-progress multipart uploads for a vault.</para>
    /// </summary>
    public class UploadListElement  
    {
        
        private string multipartUploadId;
        private string vaultARN;
        private string archiveDescription;
        private long? partSizeInBytes;
        private DateTime? creationDate;

        /// <summary>
        /// The ID of a multipart upload.
        ///  
        /// </summary>
        public string MultipartUploadId
        {
            get { return this.multipartUploadId; }
            set { this.multipartUploadId = value; }
        }

        /// <summary>
        /// Sets the MultipartUploadId property
        /// </summary>
        /// <param name="multipartUploadId">The value to set for the MultipartUploadId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UploadListElement WithMultipartUploadId(string multipartUploadId)
        {
            this.multipartUploadId = multipartUploadId;
            return this;
        }
            

        // Check to see if MultipartUploadId property is set
        internal bool IsSetMultipartUploadId()
        {
            return this.multipartUploadId != null;       
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the vault that contains the archive.
        ///  
        /// </summary>
        public string VaultARN
        {
            get { return this.vaultARN; }
            set { this.vaultARN = value; }
        }

        /// <summary>
        /// Sets the VaultARN property
        /// </summary>
        /// <param name="vaultARN">The value to set for the VaultARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UploadListElement WithVaultARN(string vaultARN)
        {
            this.vaultARN = vaultARN;
            return this;
        }
            

        // Check to see if VaultARN property is set
        internal bool IsSetVaultARN()
        {
            return this.vaultARN != null;       
        }

        /// <summary>
        /// The description of the archive that was specified in the Initiate Multipart Upload request.
        ///  
        /// </summary>
        public string ArchiveDescription
        {
            get { return this.archiveDescription; }
            set { this.archiveDescription = value; }
        }

        /// <summary>
        /// Sets the ArchiveDescription property
        /// </summary>
        /// <param name="archiveDescription">The value to set for the ArchiveDescription property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UploadListElement WithArchiveDescription(string archiveDescription)
        {
            this.archiveDescription = archiveDescription;
            return this;
        }
            

        // Check to see if ArchiveDescription property is set
        internal bool IsSetArchiveDescription()
        {
            return this.archiveDescription != null;       
        }

        /// <summary>
        /// The part size, in bytes, specified in the Initiate Multipart Upload request. This is the size of all the parts in the upload except the last
        /// part, which may be smaller than this size.
        ///  
        /// </summary>
        public long PartSizeInBytes
        {
            get { return this.partSizeInBytes ?? default(long); }
            set { this.partSizeInBytes = value; }
        }

        /// <summary>
        /// Sets the PartSizeInBytes property
        /// </summary>
        /// <param name="partSizeInBytes">The value to set for the PartSizeInBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UploadListElement WithPartSizeInBytes(long partSizeInBytes)
        {
            this.partSizeInBytes = partSizeInBytes;
            return this;
        }
            

        // Check to see if PartSizeInBytes property is set
        internal bool IsSetPartSizeInBytes()
        {
            return this.partSizeInBytes.HasValue;       
        }

        /// <summary>
        /// The UTC time at which the multipart upload was initiated.
        ///  
        /// </summary>
        public DateTime CreationDate
        {
            get { return this.creationDate ?? default(DateTime); }
            set { this.creationDate = value; }
        }

        /// <summary>
        /// Sets the CreationDate property
        /// </summary>
        /// <param name="creationDate">The value to set for the CreationDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UploadListElement WithCreationDate(DateTime creationDate)
        {
            this.creationDate = creationDate;
            return this;
        }
            

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this.creationDate.HasValue;       
        }
    }
}
