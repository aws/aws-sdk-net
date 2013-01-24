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
    /// The ListPartsResponse contains all the information about the
    /// ListParts method.
    /// </summary>
    public class ListPartsResponse : S3Response
    {
        private string bucketName;
        private string key;
        private string uploadId;
        private Owner owner;
        private Owner initiator;
        private string storageClass;
        private int partNumberMarker;
        private int nextPartNumberMarker;
        private int maxParts;
        private bool isTruncated;
        private List<PartDetail> parts;

        /// <summary>
        /// Gets and sets the name of the bucket to which the multipart upload was initiated.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Gets and sets the object key for which the multipart upload was initiated.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Gets and sets the upload ID identifying the multipart upload whose parts are being listed.
        /// </summary>
        public string UploadId
        {
            get { return this.uploadId; }
            set { this.uploadId = value; }
        }

        /// <summary>
        /// Gets and sets the Owner property.
        /// </summary>
        public Owner Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        /// <summary>
        /// Gets and sets the Initiator property.
        /// </summary>
        public Owner Initiator
        {
            get { return this.initiator; }
            set { this.initiator = value; }
        }

        /// <summary>
        /// Gets and sets the class of storage used to store the uploaded object.
        /// </summary>
        public string StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        /// <summary>
        /// Gets and sets the part number after which listing begins.
        /// </summary>
        public int PartNumberMarker
        {
            get { return this.partNumberMarker; }
            set { this.partNumberMarker = value; }
        }

        /// <summary>
        /// Gets and sets the NextPartNumberMarker property.
        /// <para>
        /// When a list is truncated, specifies the last part that should be skipped
        /// over to resume listing. Use this value for the PartNumberMarker
        /// request property in a subsequent request.
        /// </para>
        /// </summary>
        public int NextPartNumberMarker
        {
            get { return this.nextPartNumberMarker; }
            set { this.nextPartNumberMarker = value; }
        }

        /// <summary>
        /// Gets and sets the maximum number of parts allowed in a response.
        /// </summary>
        public int MaxParts
        {
            get { return this.maxParts; }
            set { this.maxParts = value; }
        }

        /// <summary>
        /// Gets and sets the IsTruncated property.
        /// <para>
        /// Indicates whether the returned list of parts is truncated. A value true
        /// indicates the list was truncated. A list may be truncated if the number of
        /// parts exceeds the limit specified by MaxParts.
        /// </para>
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated; }
            set { this.isTruncated = value; }
        }

        /// <summary>
        /// Gets and sets the Parts property.
        /// <para>
        /// PartDetails is a container for elements related to a particular part. A response can contain
        /// zero or more Part elements.
        /// </para>
        /// </summary>
        public List<PartDetail> Parts
        {
            get { return this.parts; }
            set { this.parts = value; }
        }

    }
}
