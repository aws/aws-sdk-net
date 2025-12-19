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
        // Custom IsSet method to preserve backwards compatibility
        bool CustomMfaCodesIsSet()
        {
            return (this._mfaCodes != null) &&
                (!System.String.IsNullOrEmpty(MfaCodes.SerialNumber)) &&
                (!System.String.IsNullOrEmpty(MfaCodes.AuthenticationValue));
        }
        // Custom Getter to preserve backwards compatibility
        S3BucketVersioningConfig CustomVersioningConfigGetter()
        {
            if (this._versioningConfig == null)
                this._versioningConfig = new S3BucketVersioningConfig();

            return this._versioningConfig;
        }
    }
}
    
