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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  CopyPart response and response metadata.
    /// </summary>
    public class CopyPartResponse : AmazonWebServiceResponse
    {
        private DateTime? lastModified;
        private string eTag;
        private string copySourceVersionId;
        private int partNumber;
        private ServerSideEncryptionMethod serverSideEncryption;
        private string serverSideEncryptionKeyManagementServiceKeyId;

        /// <summary>
        /// The version of the source object that was copied, if you have enabled versioning on the source bucketName.
        ///  
        /// </summary>
        public string CopySourceVersionId
        {
            get { return this.copySourceVersionId; }
            set { this.copySourceVersionId = value; }
        }

        // Check to see if CopySourceVersionId property is set
        internal bool IsSetCopySourceVersionId()
        {
            return this.copySourceVersionId != null;
        }

        /// <summary>
        /// Entity tag of the object.
        ///  
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this.eTag != null;
        }

        /// <summary>
        /// Date and time at which the object was uploaded.
        ///  
        /// </summary>
        public DateTime LastModified
        {
            get { return this.lastModified ?? default(DateTime); }
            set { this.lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this.lastModified.HasValue;
        }

        /// <summary>
        /// The Server-side encryption algorithm used when storing this object in S3.
        ///  
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryption; }
            set { this.serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryption property is set
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this.serverSideEncryption != null;
        }

        /// <summary>
        /// Gets and sets the PartNumber property.
        /// This is the part number in it's multi-part upload that will uniquely identify the part 
        /// and determine the relative ordering within the destination object.
        /// </summary>
        public int PartNumber
        {
            get { return this.partNumber; }
            set { this.partNumber = value; }
        }

        /// <summary>
        /// The id of the AWS Key Management Service key that Amazon S3 uses to encrypt and decrypt the object.
        /// </summary>
        public string ServerSideEncryptionKeyManagementServiceKeyId
        {
            get { return this.serverSideEncryptionKeyManagementServiceKeyId; }
            set { this.serverSideEncryptionKeyManagementServiceKeyId = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionKeyManagementServiceKeyId property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceKeyId property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionKeyManagementServiceKeyId);
        }
    }
}
    
