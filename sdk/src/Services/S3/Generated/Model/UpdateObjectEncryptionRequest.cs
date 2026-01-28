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
    /// Container for the parameters to the UpdateObjectEncryption operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets or Amazon S3 on Outposts buckets.
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    ///  Updates the server-side encryption type of an existing encrypted object in a general
    /// purpose bucket. You can use the <c>UpdateObjectEncryption</c> operation to change
    /// encrypted objects from server-side encryption with Amazon S3 managed keys (SSE-S3)
    /// to server-side encryption with Key Management Service (KMS) keys (SSE-KMS), or to
    /// apply S3 Bucket Keys. You can also use the <c>UpdateObjectEncryption</c> operation
    /// to change the customer-managed KMS key used to encrypt your data so that you can comply
    /// with custom key-rotation standards. 
    /// </para>
    ///  
    /// <para>
    /// Using the <c>UpdateObjectEncryption</c> operation, you can atomically update the server-side
    /// encryption type of an existing object in a general purpose bucket without any data
    /// movement. The <c>UpdateObjectEncryption</c> operation uses envelope encryption to
    /// re-encrypt the data key used to encrypt and decrypt your object with your newly specified
    /// server-side encryption type. In other words, when you use the <c>UpdateObjectEncryption</c>
    /// operation, your data isn't copied, archived objects in the S3 Glacier Flexible Retrieval
    /// and S3 Glacier Deep Archive storage classes aren't restored, and objects in the S3
    /// Intelligent-Tiering storage class aren't moved between tiers. Additionally, the <c>UpdateObjectEncryption</c>
    /// operation preserves all object metadata properties, including the storage class, creation
    /// date, last modified date, ETag, and checksum properties. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/update-sse-encryption.html">
    /// Updating server-side encryption for existing objects</a> in the <i>Amazon S3 User
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// By default, all <c>UpdateObjectEncryption</c> requests that specify a customer-managed
    /// KMS key are restricted to KMS keys that are owned by the bucket owner's Amazon Web
    /// Services account. If you're using Organizations, you can request the ability to use
    /// KMS keys owned by other member accounts within your organization by contacting Amazon
    /// Web Services Support.
    /// </para>
    ///  <note> 
    /// <para>
    /// Source objects that are unencrypted, or encrypted with either dual-layer server-side
    /// encryption with KMS keys (DSSE-KMS) or server-side encryption with customer-provided
    /// keys (SSE-C) aren't supported by this operation. Additionally, you cannot specify
    /// SSE-S3 encryption as the requested new encryption type <c>UpdateObjectEncryption</c>
    /// request.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    /// To use the <c>UpdateObjectEncryption</c> operation, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>s3:PutObject</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>s3:UpdateObjectEncryption</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>kms:Encrypt</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>kms:Decrypt</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>kms:GenerateDataKey</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>kms:ReEncrypt*</c> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// If you're using Organizations, to use this operation with customer-managed KMS keys
    /// from other Amazon Web Services accounts within your organization, you must have the
    /// <c>organizations:DescribeAccount</c> permission.
    /// </para>
    ///  </li> </ul> </dd> </dl> <dl> <dt>Errors</dt> <dd> <ul> <li> 
    /// <para>
    /// You might receive an <c>InvalidRequest</c> error for several reasons. Depending on
    /// the reason for the error, you might receive one of the following messages:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <c>UpdateObjectEncryption</c> operation doesn't supported unencrypted source objects.
    /// Only source objects encrypted with SSE-S3 or SSE-KMS are supported.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>UpdateObjectEncryption</c> operation doesn't support source objects with the
    /// encryption type DSSE-KMS or SSE-C. Only source objects encrypted with SSE-S3 or SSE-KMS
    /// are supported.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>UpdateObjectEncryption</c> operation doesn't support updating the encryption
    /// type to DSSE-KMS or SSE-C. Modify the request to specify SSE-KMS for the updated encryption
    /// type, and then try again.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Requests that modify an object encryption configuration require Amazon Web Services
    /// Signature Version 4. Modify the request to use Amazon Web Services Signature Version
    /// 4, and then try again.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Requests that modify an object encryption configuration require a valid new encryption
    /// type. Valid values are <c>SSEKMS</c>. Modify the request to specify SSE-KMS for the
    /// updated encryption type, and then try again.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Requests that modify an object's encryption type to SSE-KMS require an Amazon Web
    /// Services KMS key Amazon Resource Name (ARN). Modify the request to specify a KMS key
    /// ARN, and then try again.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Requests that modify an object's encryption type to SSE-KMS require a valid Amazon
    /// Web Services KMS key Amazon Resource Name (ARN). Confirm that you have a correctly
    /// formatted KMS key ARN in your request, and then try again.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>BucketKeyEnabled</c> value isn't valid. Valid values are <c>true</c> or <c>false</c>.
    /// Modify the request to specify a valid value, and then try again.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// You might receive an <c>AccessDenied</c> error for several reasons. Depending on the
    /// reason for the error, you might receive one of the following messages:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The Amazon Web Services KMS key in the request must be owned by the same account as
    /// the bucket. Modify the request to specify a KMS key from the same account, and then
    /// try again.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The bucket owner's account was approved to make <c>UpdateObjectEncryption</c> requests
    /// that use any Amazon Web Services KMS key in their organization, but the bucket owner's
    /// account isn't part of an organization in Organizations. Make sure that the bucket
    /// owner's account and the specified KMS key belong to the same organization, and then
    /// try again. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The specified Amazon Web Services KMS key must be from the same organization in Organizations
    /// as the bucket. Specify a KMS key that belongs to the same organization as the bucket,
    /// and then try again. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The encryption type for the specified object can’t be updated because that object
    /// is protected by S3 Object Lock. If the object has a governance-mode retention period
    /// or a legal hold, you must first remove the Object Lock status on the object before
    /// you issue your <c>UpdateObjectEncryption</c> request. You can't use the <c>UpdateObjectEncryption</c>
    /// operation with objects that have an Object Lock compliance mode retention period applied
    /// to them.
    /// </para>
    ///  </li> </ul> </li> </ul> </dd> </dl>
    /// </summary>
    public partial class UpdateObjectEncryptionRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _contentMD5;
        private string _expectedBucketOwner;
        private string _key;
        private ObjectEncryption _objectEncryption;
        private RequestPayer _requestPayer;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        ///  The name of the general purpose bucket that contains the specified object key name.
        /// 
        /// </para>
        ///  
        /// <para>
        /// When you use this operation with an access point attached to a general purpose bucket,
        /// you must either provide the alias of the access point in place of the bucket name
        /// or you must specify the access point Amazon Resource Name (ARN). When using the access
        /// point ARN, you must direct requests to the access point hostname. The access point
        /// hostname takes the form <c> <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com</c>.
        /// When using this operation with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-naming.html">
        /// Referencing access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  Indicates the algorithm used to create the checksum for the object when you use an
        /// Amazon Web Services SDK. This header doesn't provide any additional functionality
        /// if you don't use the SDK. When you send this header, there must be a corresponding
        /// <c>x-amz-checksum</c> or <c>x-amz-trailer</c> header sent. Otherwise, Amazon S3 fails
        /// the request with the HTTP status code <c>400 Bad Request</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity </a> in the <i>Amazon S3 User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// If you provide an individual checksum, Amazon S3 ignores any provided <c>ChecksumAlgorithm</c>
        /// parameter.
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
        /// Gets and sets the property ContentMD5. 
        /// <para>
        ///  The MD5 hash for the request body. For requests made using the Amazon Web Services
        /// Command Line Interface (CLI) or Amazon Web Services SDKs, this field is calculated
        /// automatically. 
        /// </para>
        /// </summary>
        public string ContentMD5
        {
            get { return this._contentMD5; }
            set { this._contentMD5 = value; }
        }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this._contentMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        ///  The account ID of the expected bucket owner. If the account ID that you provide doesn't
        /// match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied). 
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        ///  The key name of the object that you want to update the server-side encryption type
        /// for. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property ObjectEncryption. 
        /// <para>
        ///  The updated server-side encryption type for this object. The <c>UpdateObjectEncryption</c>
        /// operation supports the SSE-S3 and SSE-KMS encryption types. 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>SSES3</c> | <c>SSEKMS</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectEncryption ObjectEncryption
        {
            get { return this._objectEncryption; }
            set { this._objectEncryption = value; }
        }

        // Check to see if ObjectEncryption property is set
        internal bool IsSetObjectEncryption()
        {
            return this._objectEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property RequestPayer.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this._requestPayer; }
            set { this._requestPayer = value; }
        }

        // Check to see if RequestPayer property is set
        internal bool IsSetRequestPayer()
        {
            return this._requestPayer != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        ///  The version ID of the object that you want to update the server-side encryption type
        /// for. 
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}