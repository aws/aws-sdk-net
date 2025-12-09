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
    /// Container for the parameters to the DeleteObject operation.
    /// Removes an object from a bucket. The behavior depends on the bucket's versioning state:
    /// 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If bucket versioning is not enabled, the operation permanently deletes the object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If bucket versioning is enabled, the operation inserts a delete marker, which becomes
    /// the current version of the object. To permanently delete an object in a versioned
    /// bucket, you must include the object’s <c>versionId</c> in the request. For more information
    /// about versioning-enabled buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/DeletingObjectVersions.html">Deleting
    /// object versions from a versioning-enabled bucket</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If bucket versioning is suspended, the operation removes the object that has a null
    /// <c>versionId</c>, if there is one, and inserts a delete marker that becomes the current
    /// version of the object. If there isn't an object with a null <c>versionId</c>, and
    /// all versions of the object have a <c>versionId</c>, Amazon S3 does not remove the
    /// object and only inserts a delete marker. To permanently delete an object that has
    /// a <c>versionId</c>, you must include the object’s <c>versionId</c> in the request.
    /// For more information about versioning-suspended buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/DeletingObjectsfromVersioningSuspendedBuckets.html">Deleting
    /// objects from versioning-suspended buckets</a>.
    /// </para>
    ///  </li> </ul> <note> <ul> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - S3 Versioning isn't enabled and supported for directory
    /// buckets. For this API operation, only the <c>null</c> value of the version ID is supported
    /// by directory buckets. You can only specify <c>null</c> to the <c>versionId</c> query
    /// parameter in the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// To remove a specific version, you must use the <c>versionId</c> query parameter. Using
    /// this query parameter permanently deletes the version. If the object deleted is a delete
    /// marker, Amazon S3 sets the response header <c>x-amz-delete-marker</c> to true. 
    /// </para>
    ///  
    /// <para>
    /// If the object you want to delete is in a bucket where the bucket versioning configuration
    /// is MFA Delete enabled, you must include the <c>x-amz-mfa</c> request header in the
    /// DELETE <c>versionId</c> request. Requests that include <c>x-amz-mfa</c> must use HTTPS.
    /// For more information about MFA Delete, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMFADelete.html">Using
    /// MFA Delete</a> in the <i>Amazon S3 User Guide</i>. To see sample requests that use
    /// versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectDELETE.html#ExampleVersionObjectDelete">Sample
    /// Request</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - MFA delete is not supported by directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can delete objects by explicitly calling DELETE Object or calling (<a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketLifecycle.html">PutBucketLifecycle</a>)
    /// to enable Amazon S3 to remove them for you. If you want to block users or accounts
    /// from removing or deleting objects from your bucket, you must deny them the <c>s3:DeleteObject</c>,
    /// <c>s3:DeleteObjectVersion</c>, and <c>s3:PutLifeCycleConfiguration</c> actions. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets</b> - S3 Lifecycle is not supported by directory buckets.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - The following permissions are required
    /// in your policies when your <c>DeleteObjects</c> request includes specific headers.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b> <c>s3:DeleteObject</c> </b> - To delete an object from a bucket, you must always
    /// have the <c>s3:DeleteObject</c> permission.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <c>s3:DeleteObjectVersion</c> </b> - To delete a specific version of an object
    /// from a versioning-enabled bucket, you must have the <c>s3:DeleteObjectVersion</c>
    /// permission.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation on a
    /// directory bucket, we recommend that you use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <c>CreateSession</c> </a> API operation for session-based authorization. Specifically,
    /// you grant the <c>s3express:CreateSession</c> permission to the directory bucket in
    /// a bucket policy or an IAM identity-based policy. Then, you make the <c>CreateSession</c>
    /// API call on the bucket to obtain a session token. With the session token in your request
    /// header, you can make API requests to this operation. After the session token expires,
    /// you make another <c>CreateSession</c> API call to generate a new session token for
    /// use. Amazon Web Services CLI or SDKs create session and refresh the session token
    /// automatically to avoid service interruptions when a session expires. For more information
    /// about authorization, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <c>CreateSession</c> </a>.
    /// </para>
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following action is related to <c>DeleteObject</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteObjectRequest : AmazonWebServiceRequest
    {
        internal bool CustomMfaCodesIsSet()
        {
            return (this._mfaCodes != null) &&
                (!System.String.IsNullOrEmpty(MfaCodes.SerialNumber)) &&
                (!System.String.IsNullOrEmpty(MfaCodes.AuthenticationValue));
        }
    }
}

