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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the ListParts operation.
    /// </summary>
    public partial class ListPartsResponse : AmazonWebServiceResponse
    {
        private DateTime? _abortDate;
        private string _abortRuleId;
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private ChecksumType _checksumType;
        private Initiator _initiator;
        private bool? _isTruncated;
        private string _key;
        private int? _maxParts;
        private int? _nextPartNumberMarker;
        private Owner _owner;
        private int? _partNumberMarker;
        private List<PartDetail> _parts = AWSConfigs.InitializeCollections ? new List<PartDetail>() : null;
        private RequestCharged _requestCharged;
        private string _storageClass;
        private string _uploadId;

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
        /// The response will also include the <c>x-amz-abort-rule-id</c> header that will provide
        /// the ID of the lifecycle configuration rule that defines this action.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime? AbortDate
        {
            get { return this._abortDate; }
            set { this._abortDate = value; }
        }

        // Check to see if AbortDate property is set
        internal bool IsSetAbortDate()
        {
            return this._abortDate.HasValue; 
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
            get { return this._abortRuleId; }
            set { this._abortRuleId = value; }
        }

        // Check to see if AbortRuleId property is set
        internal bool IsSetAbortRuleId()
        {
            return this._abortRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket to which the multipart upload was initiated. Does not return
        /// the access point ARN or access point alias if used.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
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
        /// Gets and sets the property ChecksumType. 
        /// <para>
        /// The checksum type, which determines how part-level checksums are combined to create
        /// an object-level checksum for multipart objects. You can use this header response to
        /// verify that the checksum type that is received is the same checksum type that was
        /// specified in <c>CreateMultipartUpload</c> request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity in the Amazon S3 User Guide</a>.
        /// </para>
        /// </summary>
        public ChecksumType ChecksumType
        {
            get { return this._checksumType; }
            set { this._checksumType = value; }
        }

        // Check to see if ChecksumType property is set
        internal bool IsSetChecksumType()
        {
            return this._checksumType != null;
        }

        /// <summary>
        /// Gets and sets the property Initiator. 
        /// <para>
        /// Container element that identifies who initiated the multipart upload. If the initiator
        /// is an Amazon Web Services account, this element provides the same information as the
        /// <c>Owner</c> element. If the initiator is an IAM User, this element provides the user
        /// ARN and display name.
        /// </para>
        /// </summary>
        public Initiator Initiator
        {
            get { return this._initiator; }
            set { this._initiator = value; }
        }

        // Check to see if Initiator property is set
        internal bool IsSetInitiator()
        {
            return this._initiator != null;
        }

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        ///  Indicates whether the returned list of parts is truncated. A true value indicates
        /// that the list was truncated. A list can be truncated if the number of parts exceeds
        /// the limit returned in the MaxParts element.
        /// </para>
        /// </summary>
        public bool? IsTruncated
        {
            get { return this._isTruncated; }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Object key for which the multipart upload was initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property MaxParts. 
        /// <para>
        /// Maximum number of parts that were allowed in the response.
        /// </para>
        /// </summary>
        public int? MaxParts
        {
            get { return this._maxParts; }
            set { this._maxParts = value; }
        }

        // Check to see if MaxParts property is set
        internal bool IsSetMaxParts()
        {
            return this._maxParts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextPartNumberMarker. 
        /// <para>
        /// When a list is truncated, this element specifies the last part in the list, as well
        /// as the value to use for the <c>part-number-marker</c> request parameter in a subsequent
        /// request.
        /// </para>
        /// </summary>
        public int? NextPartNumberMarker
        {
            get { return this._nextPartNumberMarker; }
            set { this._nextPartNumberMarker = value; }
        }

        // Check to see if NextPartNumberMarker property is set
        internal bool IsSetNextPartNumberMarker()
        {
            return this._nextPartNumberMarker.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// Container element that identifies the object owner, after the object is created. If
        /// multipart upload is initiated by an IAM user, this element provides the parent account
        /// ID and display name.
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
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property PartNumberMarker. 
        /// <para>
        /// Specifies the part after which listing should begin. Only parts with higher part numbers
        /// will be listed.
        /// </para>
        /// </summary>
        public int? PartNumberMarker
        {
            get { return this._partNumberMarker; }
            set { this._partNumberMarker = value; }
        }

        // Check to see if PartNumberMarker property is set
        internal bool IsSetPartNumberMarker()
        {
            return this._partNumberMarker.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Parts. 
        /// <para>
        /// Container for elements related to a particular part. A response can contain zero or
        /// more <c>Part</c> elements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PartDetail> Parts
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
        /// Gets and sets the property RequestCharged.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this._requestCharged; }
            set { this._requestCharged = value; }
        }

        // Check to see if RequestCharged property is set
        internal bool IsSetRequestCharged()
        {
            return this._requestCharged != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The class of storage used to store the uploaded object.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - Directory buckets only support <c>EXPRESS_ONEZONE</c>
        /// (the S3 Express One Zone storage class) in Availability Zones and <c>ONEZONE_IA</c>
        /// (the S3 One Zone-Infrequent Access storage class) in Dedicated Local Zones.
        /// </para>
        ///  </note>
        /// </summary>
        public string StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// Upload ID identifying the multipart upload whose parts are being listed.
        /// </para>
        /// </summary>
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

    }
}