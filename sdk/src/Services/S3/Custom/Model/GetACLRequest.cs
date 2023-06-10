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
    /// Container for the parameters to the GetACL operation.
    /// This implementation of the <code>GET</code> action uses the <code>acl</code> subresource
    /// to return the access control list (ACL) of a bucket. To use <code>GET</code> to return
    /// the ACL of the bucket, you must have <code>READ_ACP</code> access to the bucket. If
    /// <code>READ_ACP</code> permission is granted to the anonymous user, you can return
    /// the ACL of the bucket without using an authorization header.
    /// 
    /// <para>
    /// To use this API operation against an access point, provide the alias of the access
    /// point in place of the bucket name.
    /// </para>
    ///  
    /// <para>
    /// To use this API operation against an Object Lambda access point, provide the alias
    /// of the Object Lambda access point in place of the bucket name. If the Object Lambda
    /// access point alias in a request is not valid, the error code <code>InvalidAccessPointAliasError</code>
    /// is returned. For more information about <code>InvalidAccessPointAliasError</code>,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/ErrorResponses.html#ErrorCodeList">List
    /// of Error Codes</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If your bucket uses the bucket owner enforced setting for S3 Object Ownership, requests
    /// to read ACLs are still supported and return the <code>bucket-owner-full-control</code>
    /// ACL with the owner being the account that created the bucket. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">
    /// Controlling object ownership and disabling ACLs</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The following operations are related to <code>GetBucketAcl</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListObjects.html">ListObjects</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetACLRequest : AmazonWebServiceRequest
    {
        private string expectedBucketOwner;

        /// <summary>
        /// <para>The bucket name that contains the object for which to get the ACL information.</para>
        /// <para>When using this API with an access point, you must direct requests to the access point hostname. 
        /// The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. 
        /// When using this operation with an access point through the AWS SDKs, you provide the access point 
        /// ARN in place of the bucket name. For more information about access point ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> 
        /// in the <i>Amazon Simple Storage Service Developer Guide</i>.</para>
        /// </summary>
        public string BucketName { get; set; }

        // Check to see if BucketName property is set
        internal bool IsSetBucket()
        {
            return this.BucketName != null;
        }

        /// <summary>
        /// The account ID of the expected bucket owner. 
        /// If the bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.
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
        /// The key of the S3 object to be queried.
        /// </summary>
        /// <remarks>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory. For further information view the documentation for 
        /// the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
        /// </remarks>
        public string Key { get; set; }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.Key != null;
        }

        /// <summary>
        /// VersionId used to reference a specific version of the object.
        /// </summary>
        public string VersionId { get; set; }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this.VersionId != null;
        }
    }
}
    
