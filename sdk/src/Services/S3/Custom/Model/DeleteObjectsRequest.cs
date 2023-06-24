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
    /// Container for the parameters to the DeleteObjects operation.
    /// This action enables you to delete multiple objects from a bucket using a single HTTP
    /// request. If you know the object keys that you want to delete, then this action provides
    /// a suitable alternative to sending individual delete requests, reducing per-request
    /// overhead.
    /// 
    ///  
    /// <para>
    /// The request contains a list of up to 1000 keys that you want to delete. In the XML,
    /// you provide the object key names, and optionally, version IDs if you want to delete
    /// a specific version of the object from a versioning-enabled bucket. For each key, Amazon
    /// S3 performs a delete action and returns the result of that delete, success, or failure,
    /// in the response. Note that if the object specified in the request is not found, Amazon
    /// S3 returns the result as deleted.
    /// </para>
    ///  
    /// <para>
    ///  The action supports two modes for the response: verbose and quiet. By default, the
    /// action uses verbose mode in which the response includes the result of deletion of
    /// each key in your request. In quiet mode the response includes only keys where the
    /// delete action encountered an error. For a successful deletion, the action does not
    /// return any information about the delete in the response body.
    /// </para>
    ///  
    /// <para>
    /// When performing this action on an MFA Delete enabled bucket, that attempts to delete
    /// any versioned objects, you must include an MFA token. If you do not provide one, the
    /// entire request will fail, even if there are non-versioned objects you are trying to
    /// delete. If you provide an invalid token, whether there are versioned keys in the request
    /// or not, the entire Multi-Object Delete request will fail. For information about MFA
    /// Delete, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/Versioning.html#MultiFactorAuthenticationDelete">
    /// MFA Delete</a>.
    /// </para>
    ///  
    /// <para>
    /// Finally, the Content-MD5 header is required for all Multi-Object Delete requests.
    /// Amazon S3 uses the header value to ensure that your request body has not been altered
    /// in transit.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>DeleteObjects</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateMultipartUpload.html">CreateMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPart.html">UploadPart</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CompleteMultipartUpload.html">CompleteMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListParts.html">ListParts</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_AbortMultipartUpload.html">AbortMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteObjectsRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private bool? bypassGovernanceRetention;
        private ChecksumAlgorithm _checksumAlgorithm;
        private List<KeyVersion> objects = new List<KeyVersion>();
        private bool? quiet;
        private MfaCodes mfaCodes;
        private RequestPayer requestPayer;
        private string expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name containing the objects to delete. 
        /// </para>
        ///  
        /// <para>
        /// When using this action with an access point, you must direct requests to the access
        /// point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you use this action with Amazon S3 on Outposts, you must direct requests to the
        /// S3 on Outposts hostname. The S3 on Outposts hostname takes the form <code> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</code>.
        /// When you use this action with S3 on Outposts through the Amazon Web Services SDKs,
        /// you provide the Outposts access point ARN in place of the bucket name. For more information
        /// about S3 on Outposts ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property BypassGovernanceRetention. 
        /// <para>
        /// Specifies whether you want to delete this object even if it has a Governance-type
        /// Object Lock in place. To use this header, you must have the <code>s3:PutBucketPublicAccessBlock</code>
        /// permission.
        /// </para>
        /// </summary>
        public bool BypassGovernanceRetention
        {
            get { return this.bypassGovernanceRetention.GetValueOrDefault(); }
            set { this.bypassGovernanceRetention = value; }
        }

        // Check to see if BypassGovernanceRetention property is set
        internal bool IsSetBypassGovernanceRetention()
        {
            return this.bypassGovernanceRetention.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object. Amazon S3 will
        /// fail the request with a 400 error if there is no checksum associated with the object.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The account ID of the expected bucket owner. If the bucket is owned by a different
        /// account, the request will fail with an HTTP <code>403 (Access Denied)</code> error.
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

        /// <summary>
        /// List of object keys to delete.
        /// </summary>
        public List<KeyVersion> Objects
        {
            get 
            {
                if (this.objects == null)
                    this.objects = new List<KeyVersion>();

                return this.objects; 
            }
            set { this.objects = value; }
        }

        // Check to see if Objects property is set
        internal bool IsSetObjects()
        {
            return this.objects.Count > 0;
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
        /// Confirms that the requester knows that she or he will be charged for the request.
        /// Bucket owners need not specify this parameter in their requests.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this.requestPayer; }
            set { this.requestPayer = value; }
        }

        /// <summary>
        /// Checks to see if RequetsPayer is set.
        /// </summary>
        /// <returns>true, if RequestPayer property is set.</returns>
        internal bool IsSetRequestPayer()
        {
            return requestPayer != null;
        }

        /// <summary>
        /// Toggles between Quiet and Verbose mode for the operation.
        /// If set to true (Quiet mode), the response includes only those keys for objects on which
        /// the delete operation failed.
        /// </summary>
        /// <remarks>
        /// By default this property is false and keys for both successful deletes
        /// and failures are returned in the response.
        /// </remarks>
        public bool Quiet
        {
            get { return this.quiet ?? default(bool); }
            set { this.quiet = value; }
        }

        // Check to see if Quiet property is set
        internal bool IsSetQuiet()
        {
            return this.quiet.HasValue;
        }
       
    }
}
    
