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

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for elements related to a particular multipart upload.
    /// </summary>
    public class MultipartUpload
    {

        private string key;
        private string uploadId;
        private Owner owner;
        private Initiator initiator;
        private DateTime? initiated;
        private S3StorageClass storageClass;

        /// <summary>
        /// Date and time at which the multipart upload was initiated.
        ///  
        /// </summary>
        public DateTime Initiated
        {
            get { return this.initiated ?? default(DateTime); }
            set { this.initiated = value; }
        }

        // Check to see if Initiated property is set
        internal bool IsSetInitiated()
        {
            return this.initiated.HasValue;
        }

        /// <summary>
        /// Identifies who initiated the multipart upload.
        ///  
        /// </summary>
        public Initiator Initiator
        {
            get { return this.initiator; }
            set { this.initiator = value; }
        }

        // Check to see if Initiator property is set
        internal bool IsSetInitiator()
        {
            return this.initiator != null;
        }

        /// <summary>
        /// Key of the object for which the multipart upload was initiated.
        ///  
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
        /// Gets and sets the Owner property.
        /// </summary>
        public Owner Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this.owner != null;
        }

        /// <summary>
        /// The class of storage used to store the object.
        ///  
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this.storageClass != null;
        }

        /// <summary>
        /// Upload ID that identifies the multipart upload.
        ///  
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
