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
    /// Container for the parameters to the PutObject operation.
    /// Adds an object to a bucket.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// Amazon S3 never adds partial objects; if you receive a success response, Amazon S3
    /// added the entire object to the bucket. You cannot use <c>PutObject</c> to only update
    /// a single piece of metadata for an existing object. You must put the entire object
    /// with updated metadata if you want to update some values.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your bucket uses the bucket owner enforced setting for Object Ownership, ACLs are
    /// disabled and no longer affect permissions. All objects written to the bucket by any
    /// account will be owned by the bucket owner.
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
    /// Amazon S3 is a distributed system. If it receives multiple write requests for the
    /// same object simultaneously, it overwrites all but the last object written. However,
    /// Amazon S3 provides features that can modify this behavior:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>S3 Object Lock</b> - To prevent objects from being deleted or overwritten, you
    /// can use <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lock.html">Amazon
    /// S3 Object Lock</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This functionality is not supported for directory buckets.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    ///  <b>S3 Versioning</b> - When you enable versioning for a bucket, if Amazon S3 receives
    /// multiple write requests for the same object simultaneously, it stores all versions
    /// of the objects. For each write request that is made to the same object, Amazon S3
    /// automatically generates a unique version ID of that object being stored in Amazon
    /// S3. You can retrieve, replace, or delete any version of the object. For more information
    /// about versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/AddingObjectstoVersioningEnabledBuckets.html">Adding
    /// Objects to Versioning-Enabled Buckets</a> in the <i>Amazon S3 User Guide</i>. For
    /// information about returning the versioning state of a bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketVersioning.html">GetBucketVersioning</a>.
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// This functionality is not supported for directory buckets.
    /// </para>
    ///  </note> </li> </ul> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - The following permissions are required
    /// in your policies when your <c>PutObject</c> request includes specific headers.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b> <c>s3:PutObject</c> </b> - To successfully complete the <c>PutObject</c> request,
    /// you must always have the <c>s3:PutObject</c> permission on a bucket to add an object
    /// to it.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <c>s3:PutObjectAcl</c> </b> - To successfully change the objects ACL of your
    /// <c>PutObject</c> request, you must have the <c>s3:PutObjectAcl</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <c>s3:PutObjectTagging</c> </b> - To successfully set the tag-set with your <c>PutObject</c>
    /// request, you must have the <c>s3:PutObjectTagging</c>.
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
    ///  </li> </ul> </dd> <dt>Data integrity with Content-MD5</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket</b> - To ensure that data is not corrupted traversing the
    /// network, use the <c>Content-MD5</c> header. When you use this header, Amazon S3 checks
    /// the object against the provided MD5 value and, if they do not match, Amazon S3 returns
    /// an error. Alternatively, when the object's ETag is its MD5 digest, you can calculate
    /// the MD5 while putting the object to Amazon S3 and compare the returned ETag to the
    /// calculated MD5 value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket</b> - This functionality is not supported for directory buckets.
    /// </para>
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// For more information about related Amazon S3 APIs, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteObject.html">DeleteObject</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutObjectRequest : PutWithACLRequest
    {
        /// <summary>
        /// Overrides the default request timeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the value is set, the value is assigned to the Timeout property of the HTTPWebRequest/HttpClient object used
        /// to send requests.
        /// </para>
        /// <para>
        /// Please specify a timeout value only if the operation will not complete within the default intervals
        /// specified for an HttpWebRequest/HttpClient.
        /// </para>
        /// </remarks>
        /// <exception cref="System.ArgumentNullException">The timeout specified is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">The timeout specified is less than or equal to zero and is not Infinite.</exception>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        /// <seealso cref="P:System.Net.Http.HttpClient.Timeout"/>
        public TimeSpan? Timeout
        {
            get { return this.TimeoutInternal; }
            set { this.TimeoutInternal = value; }
        }


        /// <summary>
        /// Overrides the default ReadWriteTimeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the value is set, the value is assigned to the ReadWriteTimeout property of the HTTPWebRequest/WebRequestHandler object used
        /// to send requests.
        /// </para>
        /// <exception cref="System.ArgumentNullException">The timeout specified is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">The timeout specified is less than or equal to zero and is not Infinite.</exception>
        /// </remarks>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.Http.WebRequestHandler.ReadWriteTimeout"/>
        public TimeSpan? ReadWriteTimeout
        {
            get { return this.ReadWriteTimeoutInternal; }
            set { this.ReadWriteTimeoutInternal = value; }
        }

        internal void SetupForFilePath()
        {
            this.InputStream = new FileStream(this.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read);

            if (string.IsNullOrEmpty(this.Key))
            {
                this.Key = Path.GetFileName(this.FilePath);
            }
        }
    }
}
