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
    /// Container for the parameters to the PutBucketVersioning operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// When you enable versioning on a bucket for the first time, it might take a short amount
    /// of time for the change to be fully propagated. While this change is propagating, you
    /// might encounter intermittent <c>HTTP 404 NoSuchKey</c> errors for requests to objects
    /// created or updated after enabling versioning. We recommend that you wait for 15 minutes
    /// after enabling versioning before issuing write operations (<c>PUT</c> or <c>DELETE</c>)
    /// on objects in the bucket. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Sets the versioning state of an existing bucket.
    /// </para>
    ///  
    /// <para>
    /// You can set the versioning state with one of the following values:
    /// </para>
    ///  
    /// <para>
    ///  <b>Enabled</b>—Enables versioning for the objects in the bucket. All objects added
    /// to the bucket receive a unique version ID.
    /// </para>
    ///  
    /// <para>
    ///  <b>Suspended</b>—Disables versioning for the objects in the bucket. All objects added
    /// to the bucket receive the version ID null.
    /// </para>
    ///  
    /// <para>
    /// If the versioning state has never been set on a bucket, it has no versioning state;
    /// a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketVersioning.html">GetBucketVersioning</a>
    /// request does not return a versioning state value.
    /// </para>
    ///  
    /// <para>
    /// In order to enable MFA Delete, you must be the bucket owner. If you are the bucket
    /// owner and want to enable MFA Delete in the bucket versioning configuration, you must
    /// include the <c>x-amz-mfa request</c> header and the <c>Status</c> and the <c>MfaDelete</c>
    /// request elements in a request to set the versioning state of the bucket.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you have an object expiration lifecycle configuration in your non-versioned bucket
    /// and you want to maintain the same permanent delete behavior when you enable versioning,
    /// you must add a noncurrent expiration policy. The noncurrent expiration lifecycle configuration
    /// will manage the deletes of the noncurrent object versions in the version-enabled bucket.
    /// (A version-enabled bucket maintains one current and zero or more noncurrent object
    /// versions.) For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html#lifecycle-and-other-bucket-config">Lifecycle
    /// and Versioning</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// The following operations are related to <c>PutBucketVersioning</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucket.html">DeleteBucket</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketVersioning.html">GetBucketVersioning</a>
    /// 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutBucketVersioningRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _expectedBucketOwner;
        private MfaCodes _mfaCodes;
        private S3BucketVersioningConfig _versioningConfig;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name.
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
        /// Indicates the algorithm used to create the checksum for the request when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <c>x-amz-checksum</c>
        /// or <c>x-amz-trailer</c> header sent. Otherwise, Amazon S3 fails the request with the
        /// HTTP status code <c>400 Bad Request</c>. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
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
            return !String.IsNullOrEmpty(this._expectedBucketOwner);
        }

        /// <summary>
        /// Gets and sets the property MfaCodes. 
        /// <para>
        /// The concatenation of the authentication device's serial number, a space, and the value
        /// that is displayed on your authentication device. The serial number is the number that
        /// uniquely identifies the MFA device. For physical MFA devices, this is the unique serial
        /// number that's provided with the device. For virtual MFA devices, the serial number
        /// is the device ARN. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/manage-versioning-examples.html">Enabling
        /// versioning on buckets</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/MultiFactorAuthenticationDelete.html">Configuring
        /// MFA delete</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// </para>
        /// </summary>
        public MfaCodes MfaCodes
        {
            get { return this._mfaCodes; }
            set { this._mfaCodes = value; }
        }

        // Check to see if MfaCodes property is set
        internal bool IsSetMfaCodes()
        {
            return this._mfaCodes != null && !System.String.IsNullOrEmpty(_mfaCodes.SerialNumber) && !System.String.IsNullOrEmpty(_mfaCodes.AuthenticationValue);
        }

        /// <summary>
        /// Gets and sets the property VersioningConfig. 
        /// <para>
        /// Container for setting the versioning state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3BucketVersioningConfig VersioningConfig
        {
            get { return this._versioningConfig ?? new S3BucketVersioningConfig(); }
            set { this._versioningConfig = value; }
        }

        // Check to see if VersioningConfig property is set
        internal bool IsSetVersioningConfig()
        {
            return this._versioningConfig != null;
        }

    }
}