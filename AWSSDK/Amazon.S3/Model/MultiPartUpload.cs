/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

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
        private Owner initiator;
        private string storageClass;
        private DateTime initiated;

        /// <summary>
        /// The key of the object for which the multipart upload was initiated.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Identifies the multipart upload.
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }

        /// <summary>
        /// The owner of the object.
        /// </summary>
        public Owner Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        /// <summary>
        /// The owner of the upload.
        /// </summary>
        public Owner Initiator
        {
            get { return this.initiator; }
            set { this.initiator = value; }
        }


        /// <summary>
        /// The class of storage that will be used to store the object when multipart upload is complete.
        /// </summary>
        public string StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        /// <summary>
        /// The date and time at which the multipart upload was initiated.
        /// </summary>
        public DateTime Initiated
        {
            get { return this.initiated; }
            set { this.initiated = value; }
        }

    }
}
