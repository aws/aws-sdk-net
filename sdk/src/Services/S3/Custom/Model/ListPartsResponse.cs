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
        private ChecksumAlgorithm _checksumAlgorithm;
        private string key;
        private string uploadId;
        private Owner owner;
        private Initiator initiator;
        private S3StorageClass storageClass;
        private int? partNumberMarker;
        private int? nextPartNumberMarker;
        private int? maxParts;
        private bool? isTruncated;
        private List<PartDetail> parts = AWSConfigs.InitializeCollections ? new List<PartDetail>() : null;
        private DateTime? abortDate;
        private string abortRuleId;
        private RequestCharged requestCharged;
        private ChecksumType checksumType;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket to which the multipart upload was initiated. Does not return
        /// the access point ARN or access point alias if used.
        /// </para>
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
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// The algorithm that was used to create a checksum of the object.
        /// </para>
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
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
        /// Gets and sets the property PartNumberMarker. 
        /// <para>
        /// Specifies the part after which listing should begin. Only parts with higher part numbers
        /// will be listed.
        /// </para>
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
        /// Gets and sets the property NextPartNumberMarker. 
        /// <para>
        /// When a list is truncated, this element specifies the last part in the list, as well
        /// as the value to use for the <c>part-number-marker</c> request parameter in a
        /// subsequent request.
        /// </para>
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
            return this.parts != null && (this.parts.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// Gets and sets the property Initiator. 
        /// <para>
        /// Container element that identifies who initiated the multipart upload. If the initiator
        /// is an Amazon Web Services account, this element provides the same information as the
        /// <c>Owner</c> element. If the initiator is an IAM User, this element provides the user
        /// ARN.
        /// </para>
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// Container element that identifies the object owner, after the object is created. If
        /// multipart upload is initiated by an IAM user, this element provides the parent account
        /// ID.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - The bucket owner is returned as the object owner for all
        /// the parts.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The class of storage used to store the uploaded object.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - Only the S3 Express One Zone storage class is supported
        /// by directory buckets to store objects.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property AbortDate. 
        /// <para>
        /// If the bucket has a lifecycle rule configured with an action to abort incomplete multipart
        /// uploads and the prefix in the lifecycle rule matches the object name in the request,
        /// then the response includes this header indicating when the initiated multipart upload
        /// will become eligible for abort operation. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html#mpu-abort-incomplete-mpu-lifecycle-config">Aborting
        /// Incomplete Multipart Uploads Using a Bucket Lifecycle Configuration</a>.
        /// </para>
        ///  
        /// <para>
        /// The response will also include the <c>x-amz-abort-rule-id</c> header that will
        /// provide the ID of the lifecycle configuration rule that defines this action.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property AbortRuleId. 
        /// <para>
        /// This header is returned along with the <c>x-amz-abort-date</c> header. It identifies
        /// applicable lifecycle configuration rule that defines the action to abort incomplete
        /// multipart uploads.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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

        /// <summary>
        /// If present, indicates that the requester was successfully charged for the request.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this.requestCharged; }
            set { this.requestCharged = value; }
        }

        /// <summary>
        /// Checks to see if RequestCharged is set.
        /// </summary>
        /// <returns>true, if RequestCharged property is set.</returns>
        internal bool IsSetRequestCharged()
        {
            return requestCharged != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumType.
        /// <para>
        /// The checksum type, which determines how part-level checksums are combined to 
        /// create an object-level checksum for multipart objects. You can use this header 
        /// response to verify that the checksum type that is received is the same checksum 
        /// type that was specified in the <c>CreateMultipartUpload</c> request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity in the Amazon S3 User Guide</a>.
        /// </para>
        /// </summary>
        public ChecksumType ChecksumType
        {
            get { return this.checksumType; }
            set { this.checksumType = value; }
        }

        /// <summary>
        /// Checks to see if ChecksumType is set.
        /// </summary>
        /// <returns>true, if ChecksumType property is set.</returns>
        internal bool IsSetChecksumType()
        {
            return checksumType != null;
        }
    }
}
    
