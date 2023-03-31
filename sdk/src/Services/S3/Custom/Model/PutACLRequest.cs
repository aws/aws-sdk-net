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
    /// Container for the parameters to the PutACL operation.
    /// Sets the permissions on an existing bucket using access control lists (ACL). For more
    /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
    /// ACLs</a>. To set the ACL of a bucket, you must have <code>WRITE_ACP</code> permission.
    /// 
    ///  
    /// <para>
    /// You can use one of the following two ways to set a bucket's permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify the ACL in the request body
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify permissions using request headers
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// You cannot specify access permission using both the body and the request headers.
    /// </para>
    ///  </note> 
    /// <para>
    /// Depending on your application needs, you may choose to set the ACL on a bucket using
    /// either the request body or the headers. For example, if you have an existing application
    /// that updates a bucket ACL using the request body, then you can continue to use that
    /// approach.
    /// </para>
    ///  <important> 
    /// <para>
    /// If your bucket uses the bucket owner enforced setting for S3 Object Ownership, ACLs
    /// are disabled and no longer affect permissions. You must use policies to grant access
    /// to your bucket and the objects in it. Requests to set ACLs or update ACLs fail and
    /// return the <code>AccessControlListNotSupported</code> error code. Requests to read
    /// ACLs are still supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">Controlling
    /// object ownership</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </important> 
    /// <para>
    ///  <b>Access Permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// You can set access permissions using one of the following methods:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify a canned ACL with the <code>x-amz-acl</code> request header. Amazon S3 supports
    /// a set of predefined ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined
    /// set of grantees and permissions. Specify the canned ACL name as the value of <code>x-amz-acl</code>.
    /// If you use this header, you cannot use other access control-specific headers in your
    /// request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
    /// ACL</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify access permissions explicitly with the <code>x-amz-grant-read</code>, <code>x-amz-grant-read-acp</code>,
    /// <code>x-amz-grant-write-acp</code>, and <code>x-amz-grant-full-control</code> headers.
    /// When using these headers, you specify explicit access permissions and grantees (Amazon
    /// Web Services accounts or Amazon S3 groups) who will receive the permission. If you
    /// use these ACL-specific headers, you cannot use the <code>x-amz-acl</code> header to
    /// set a canned ACL. These parameters map to the set of permissions that Amazon S3 supports
    /// in an ACL. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
    /// Control List (ACL) Overview</a>.
    /// </para>
    ///  
    /// <para>
    /// You specify each grantee as a type=value pair, where the type is one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>id</code> – if the value specified is the canonical user ID of an Amazon Web
    /// Services account
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>uri</code> – if you are granting permissions to a predefined group
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>emailAddress</code> – if the value specified is the email address of an Amazon
    /// Web Services account
    /// </para>
    ///  <note> 
    /// <para>
    /// Using email addresses to specify a grantee is only supported in the following Amazon
    /// Web Services Regions: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// US East (N. Virginia)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// US West (N. California)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  US West (Oregon)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Asia Pacific (Singapore)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Asia Pacific (Sydney)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Asia Pacific (Tokyo)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Europe (Ireland)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// South America (São Paulo)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For a list of all the Amazon S3 supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
    /// and Endpoints</a> in the Amazon Web Services General Reference.
    /// </para>
    ///  </note> </li> </ul> 
    /// <para>
    /// For example, the following <code>x-amz-grant-write</code> header grants create, overwrite,
    /// and delete objects permission to LogDelivery group predefined by Amazon S3 and two
    /// Amazon Web Services accounts identified by their email addresses.
    /// </para>
    ///  
    /// <para>
    ///  <code>x-amz-grant-write: uri="http://acs.amazonaws.com/groups/s3/LogDelivery", id="111122223333",
    /// id="555566667777" </code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can use either a canned ACL or specify access permissions explicitly. You cannot
    /// do both.
    /// </para>
    ///  
    /// <para>
    ///  <b>Grantee Values</b> 
    /// </para>
    ///  
    /// <para>
    /// You can specify the person (grantee) to whom you're assigning access rights (using
    /// request elements) in the following ways:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// By the person's ID:
    /// </para>
    ///  
    /// <para>
    ///  <code>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="CanonicalUser"&gt;&lt;ID&gt;&lt;&gt;ID&lt;&gt;&lt;/ID&gt;&lt;DisplayName&gt;&lt;&gt;GranteesEmail&lt;&gt;&lt;/DisplayName&gt;
    /// &lt;/Grantee&gt;</code> 
    /// </para>
    ///  
    /// <para>
    /// DisplayName is optional and ignored in the request
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// By URI:
    /// </para>
    ///  
    /// <para>
    ///  <code>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="Group"&gt;&lt;URI&gt;&lt;&gt;http://acs.amazonaws.com/groups/global/AuthenticatedUsers&lt;&gt;&lt;/URI&gt;&lt;/Grantee&gt;</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// By Email address:
    /// </para>
    ///  
    /// <para>
    ///  <code>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="AmazonCustomerByEmail"&gt;&lt;EmailAddress&gt;&lt;&gt;Grantees@email.com&lt;&gt;&lt;/EmailAddress&gt;lt;/Grantee&gt;</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// The grantee is resolved to the CanonicalUser and, in a response to a GET Object acl
    /// request, appears as the CanonicalUser. 
    /// </para>
    ///  <note> 
    /// <para>
    /// Using email addresses to specify a grantee is only supported in the following Amazon
    /// Web Services Regions: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// US East (N. Virginia)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// US West (N. California)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  US West (Oregon)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Asia Pacific (Singapore)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Asia Pacific (Sydney)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Asia Pacific (Tokyo)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Europe (Ireland)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// South America (São Paulo)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For a list of all the Amazon S3 supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
    /// and Endpoints</a> in the Amazon Web Services General Reference.
    /// </para>
    ///  </note> </li> </ul> <p class="title"> <b>Related Resources</b> 
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
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectAcl.html">GetObjectAcl</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutACLRequest : AmazonWebServiceRequest
    {
        private S3AccessControlList accessControlPolicy;
        private S3CannedACL cannedACL;
        private string bucket;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string expectedBucketOwner;
        private string key;
        private string versionId;
        
        /// <summary>
        /// Custom ACLs to be applied to the bucket or object.
        /// </summary>
        public S3AccessControlList AccessControlList
        {
            get { return this.accessControlPolicy; }
            set { this.accessControlPolicy = value; }
        }

        // Check to see if AccessControlPolicy property is set
        internal bool IsSetAccessControlPolicy()
        {
            return this.accessControlPolicy != null;
        }

        /// <summary>
        /// The canned ACL to apply to the bucket.
        ///  
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this.cannedACL; }
            set { this.cannedACL = value; }
        }

        // Check to see if CannedACL property is set
        internal bool IsSetCannedACL()
        {
            return this.cannedACL != null;
        }
        
        /// <summary>
        /// <para>The bucket name that contains the object to which you want to attach the ACL.</para>
        /// <para>When using this API with an access point, you must direct requests to the access point hostname. 
        /// The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. 
        /// When using this operation with an access point through the AWS SDKs, you provide the access point 
        /// ARN in place of the bucket name. For more information about access point ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> 
        /// in the <i>Amazon Simple Storage Service Developer Guide</i>.</para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucket; }
            set { this.bucket = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucket != null;
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
        /// The key of an S3 object.
        /// If not specified, the ACLs are applied to the bucket.
        /// <para>
        /// Key for which the PUT action was initiated.
        /// </para>
        /// <para>
        /// When using this action with an access point, you must direct requests to the access point hostname.
        /// The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. 
        /// When using this action with an access point through the Amazon Web Services SDKs, you provide the access point ARN in place of the bucket name. 
        /// For more information about access point ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using Access Points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <para>
        /// When you use this action with Amazon S3 on Outposts, you must direct requests to the S3 on Outposts hostname. 
        /// The S3 on Outposts hostname takes the form <code> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</code>.
        /// When you use this action with S3 on Outposts through the Amazon Web Services SDKs, you provide the Outposts access point ARN in place of the bucket name. 
        /// For more information about S3 on Outposts ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts">What is S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        /// <remarks>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory. For further information view the documentation for 
        /// the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
        /// </remarks>
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
        /// If set and an object key has been specified, the ACLs are applied
        /// to the specific version of the object.
        /// This property is ignored if the ACL is to be set on a Bucket.
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Checks if VersionId property is set.
        /// </summary>
        /// <returns>true if VersionId property is set.</returns>
        internal bool IsSetVersionId()
        {
            return this.versionId != null;
        }

    }
}
    
