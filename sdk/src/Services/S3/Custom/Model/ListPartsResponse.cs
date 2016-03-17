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
    /// Returns information about the  ListParts response and response metadata.
    /// </summary>
    public class ListPartsResponse : AmazonWebServiceResponse
    {
        private string bucketName;
        private string key;
        private string uploadId;
        private Owner owner;
        private Initiator initiator;
        private S3StorageClass storageClass;
        private int? partNumberMarker;
        private int? nextPartNumberMarker;
        private int? maxParts;
        private bool? isTruncated;
        private List<PartDetail> parts = new List<PartDetail>();
        private DateTime? abortDate;
        private string abortRuleId;

        /// <summary>
        /// Name of the bucketName to which the multipart upload was initiated.
        ///  
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Object key for which the multipart upload was initiated.
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
        /// Upload ID identifying the multipart upload whose parts are being listed.
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

        /// <summary>
        /// Part number after which listing begins.
        ///  
        /// </summary>
        public int PartNumberMarker
        {
            get { return this.partNumberMarker ?? default(int); }
            set { this.partNumberMarker = value; }
        }

        // Check to see if PartNumberMarker property is set
        internal bool IsSetPartNumberMarker()
        {
            return this.partNumberMarker.HasValue;
        }

        /// <summary>
        /// When a list is truncated, this element specifies the last part in the list, as well as the value to use for the part-number-marker request
        /// parameter in a subsequent request.
        ///  
        /// </summary>
        public int NextPartNumberMarker
        {
            get { return this.nextPartNumberMarker ?? default(int); }
            set { this.nextPartNumberMarker = value; }
        }

        // Check to see if NextPartNumberMarker property is set
        internal bool IsSetNextPartNumberMarker()
        {
            return this.nextPartNumberMarker.HasValue;
        }

        /// <summary>
        /// Maximum number of parts that were allowed in the response.
        ///  
        /// </summary>
        public int MaxParts
        {
            get { return this.maxParts ?? default(int); }
            set { this.maxParts = value; }
        }

        // Check to see if MaxParts property is set
        internal bool IsSetMaxParts()
        {
            return this.maxParts.HasValue;
        }

        /// <summary>
        /// Indicates whether the returned list of parts is truncated.
        ///  
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated ?? default(bool); }
            set { this.isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;
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

        // Check to see if Parts property is set
        internal bool IsSetParts()
        {
            return this.parts.Count > 0;
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
        public string StorageClass
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
        /// Date when multipart upload will become eligible for abort operation by lifecycle.
        /// </summary>
        public DateTime AbortDate
        {
            get { return this.abortDate.GetValueOrDefault(); }
            set { this.abortDate = value; }
        }

        // Check to see if AbortDate property is set
        internal bool IsSetAbortDate()
        {
            return this.abortDate.HasValue;
        }

        /// <summary>
        /// Id of the lifecycle rule that makes a multipart upload eligible for abort operation.
        /// </summary>
        public string AbortRuleId
        {
            get { return this.abortRuleId; }
            set { this.abortRuleId = value; }
        }

        // Check to see if AbortRuleId property is set
        internal bool IsSetAbortRuleId()
        {
            return this.abortRuleId != null;
        }
    }
}
    
