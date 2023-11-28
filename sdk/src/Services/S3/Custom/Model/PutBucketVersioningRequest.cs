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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketVersioning operation.
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
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
    ///  <b>Enabled</b>�Enables versioning for the objects in the bucket. All objects added
    /// to the bucket receive a unique version ID.
    /// </para>
    ///  
    /// <para>
    ///  <b>Suspended</b>�Disables versioning for the objects in the bucket. All objects added
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
    /// include the <code>x-amz-mfa request</code> header and the <code>Status</code> and
    /// the <code>MfaDelete</code> request elements in a request to set the versioning state
    /// of the bucket.
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
    /// The following operations are related to <code>PutBucketVersioning</code>:
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
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketVersioningRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private MfaCodes mfaCodes;
        private S3BucketVersioningConfig config;
        private string expectedBucketOwner;

        /// <summary>
        /// The name of the bucket to be updated.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <code>x-amz-checksum</code>
        /// or <code>x-amz-trailer</code> header sent. Otherwise, Amazon S3 fails the request
        /// with the HTTP status code <code>400 Bad Request</code>. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an individual checksum, Amazon S3 ignores any provided <code>ChecksumAlgorithm</code>
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
        /// The MfaCodes Tuple associates the Serial Number and the current Token/Code displayed on the
        /// Multi-Factor Authentication device associated with your AWS Account. 
        /// </summary>
        /// <remarks>
        /// This is a required property for this request if:<br />
        /// 1. EnableMfaDelete was configured on the bucket
        /// containing this object's version.<br />
        /// 2. You are deleting an object's version
        /// </remarks>
        public MfaCodes MfaCodes
        {
            get { return this.mfaCodes; }
            set { this.mfaCodes = value; }
        }

        /// <summary>
        /// Checks if the MfaCodes property is set.
        /// </summary>
        /// <returns>true if the MfaCodes property is set.</returns>
        internal bool IsSetMfaCodes()
        {
            return (this.mfaCodes != null) &&
                (!System.String.IsNullOrEmpty(MfaCodes.SerialNumber)) &&
                (!System.String.IsNullOrEmpty(MfaCodes.AuthenticationValue));
        }

        /// <summary>
        /// The versioning configuration to apply to the bucket.
        /// </summary>
        /// <remarks>
        /// Once Versioning has been "Enabled" on a bucket, it can be "Suspended" 
        /// but cannot be switched "Off". If EnableMfaDelete is set,
        /// the MfaCodes property needs to contain the Serial of and current Token
        /// displayed on the MFA device.
        /// </remarks>
        public S3BucketVersioningConfig VersioningConfig
        {
            get 
            {
                if (this.config == null)
                    this.config = new S3BucketVersioningConfig();

                return this.config; 
            }
            set { this.config = value; }
        }

        // Check to see if VersioningConfiguration property is set
        internal bool IsSetVersioningConfiguration()
        {
            return this.config != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <code>403 Forbidden</code> (access denied).
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }
    }
}
    
