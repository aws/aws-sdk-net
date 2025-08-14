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
    /// Container for the parameters to the PutBucketAcl operation.
    /// <important> 
    /// <para>
    /// End of support notice: Beginning October 1, 2025, Amazon S3 will discontinue support
    /// for creating new Email Grantee Access Control Lists (ACL). Email Grantee ACLs created
    /// prior to this date will continue to work and remain accessible through the Amazon
    /// Web Services Management Console, Command Line Interface (CLI), SDKs, and REST API.
    /// However, you will no longer be able to create new Email Grantee ACLs. 
    /// </para>
    ///  
    /// <para>
    /// This change affects the following Amazon Web Services Regions: US East (N. Virginia)
    /// Region, US West (N. California) Region, US West (Oregon) Region, Asia Pacific (Singapore)
    /// Region, Asia Pacific (Sydney) Region, Asia Pacific (Tokyo) Region, Europe (Ireland)
    /// Region, and South America (São Paulo) Region.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Sets the permissions on an existing bucket using access control lists (ACL). For more
    /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
    /// ACLs</a>. To set the ACL of a bucket, you must have the <c>WRITE_ACP</c> permission.
    /// </para>
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
    /// return the <c>AccessControlListNotSupported</c> error code. Requests to read ACLs
    /// are still supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">Controlling
    /// object ownership</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </important> <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You can set access permissions by using one of the following methods:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify a canned ACL with the <c>x-amz-acl</c> request header. Amazon S3 supports
    /// a set of predefined ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined
    /// set of grantees and permissions. Specify the canned ACL name as the value of <c>x-amz-acl</c>.
    /// If you use this header, you cannot use other access control-specific headers in your
    /// request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
    /// ACL</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify access permissions explicitly with the <c>x-amz-grant-read</c>, <c>x-amz-grant-read-acp</c>,
    /// <c>x-amz-grant-write-acp</c>, and <c>x-amz-grant-full-control</c> headers. When using
    /// these headers, you specify explicit access permissions and grantees (Amazon Web Services
    /// accounts or Amazon S3 groups) who will receive the permission. If you use these ACL-specific
    /// headers, you cannot use the <c>x-amz-acl</c> header to set a canned ACL. These parameters
    /// map to the set of permissions that Amazon S3 supports in an ACL. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
    /// Control List (ACL) Overview</a>.
    /// </para>
    ///  
    /// <para>
    /// You specify each grantee as a type=value pair, where the type is one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>id</c> – if the value specified is the canonical user ID of an Amazon Web Services
    /// account
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>uri</c> – if you are granting permissions to a predefined group
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>emailAddress</c> – if the value specified is the email address of an Amazon Web
    /// Services account
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
    /// For example, the following <c>x-amz-grant-write</c> header grants create, overwrite,
    /// and delete objects permission to LogDelivery group predefined by Amazon S3 and two
    /// Amazon Web Services accounts identified by their email addresses.
    /// </para>
    ///  
    /// <para>
    ///  <c>x-amz-grant-write: uri="http://acs.amazonaws.com/groups/s3/LogDelivery", id="111122223333",
    /// id="555566667777" </c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can use either a canned ACL or specify access permissions explicitly. You cannot
    /// do both.
    /// </para>
    ///  </dd> <dt>Grantee Values</dt> <dd> 
    /// <para>
    /// You can specify the person (grantee) to whom you're assigning access rights (using
    /// request elements) in the following ways. For examples of how to specify these grantee
    /// values in JSON format, see the Amazon Web Services CLI example in <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/enable-server-access-logging.html">
    /// Enabling Amazon S3 server access logging</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// By the person's ID:
    /// </para>
    ///  
    /// <para>
    ///  <c>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="CanonicalUser"&gt;&lt;ID&gt;&lt;&gt;ID&lt;&gt;&lt;/ID&gt;&lt;DisplayName&gt;&lt;&gt;GranteesEmail&lt;&gt;&lt;/DisplayName&gt;
    /// &lt;/Grantee&gt;</c> 
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
    ///  <c>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="Group"&gt;&lt;URI&gt;&lt;&gt;http://acs.amazonaws.com/groups/global/AuthenticatedUsers&lt;&gt;&lt;/URI&gt;&lt;/Grantee&gt;</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// By Email address:
    /// </para>
    ///  
    /// <para>
    ///  <c>&lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="AmazonCustomerByEmail"&gt;&lt;EmailAddress&gt;&lt;&gt;Grantees@email.com&lt;&gt;&lt;/EmailAddress&gt;&amp;&lt;/Grantee&gt;</c>
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
    ///  </note> </li> </ul> </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>PutBucketAcl</c>:
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
    public partial class PutBucketAclRequest : AmazonWebServiceRequest
    {
        private S3AccessControlList _accessControlPolicy;
        private S3CannedACL _acl;
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _contentMD5;
        private string _expectedBucketOwner;
        private string _grantFullControl;
        private string _grantRead;
        private string _grantReadACP;
        private string _grantWrite;
        private string _grantWriteACP;

        /// <summary>
        /// Gets and sets the property AccessControlPolicy. 
        /// <para>
        /// Contains the elements that set the ACL permissions for an object per grantee.
        /// </para>
        /// </summary>
        public S3AccessControlList AccessControlPolicy
        {
            get { return this._accessControlPolicy; }
            set { this._accessControlPolicy = value; }
        }

        // Check to see if AccessControlPolicy property is set
        internal bool IsSetAccessControlPolicy()
        {
            return this._accessControlPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ACL. 
        /// <para>
        /// The canned ACL to apply to the bucket.
        /// </para>
        /// </summary>
        public S3CannedACL ACL
        {
            get { return this._acl; }
            set { this._acl = value; }
        }

        // Check to see if ACL property is set
        internal bool IsSetACL()
        {
            return this._acl != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket to which to apply the ACL.
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
        /// Gets and sets the property ContentMD5. 
        /// <para>
        /// The Base64 encoded 128-bit <c>MD5</c> digest of the data. This header must be used
        /// as a message integrity check to verify that the request body was not corrupted in
        /// transit. For more information, go to <a href="http://www.ietf.org/rfc/rfc1864.txt">RFC
        /// 1864.</a> 
        /// </para>
        ///  
        /// <para>
        /// For requests made using the Amazon Web Services Command Line Interface (CLI) or Amazon
        /// Web Services SDKs, this field is calculated automatically.
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
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property GrantFullControl. 
        /// <para>
        /// Allows grantee the read, write, read ACP, and write ACP permissions on the bucket.
        /// </para>
        /// </summary>
        public string GrantFullControl
        {
            get { return this._grantFullControl; }
            set { this._grantFullControl = value; }
        }

        // Check to see if GrantFullControl property is set
        internal bool IsSetGrantFullControl()
        {
            return this._grantFullControl != null;
        }

        /// <summary>
        /// Gets and sets the property GrantRead. 
        /// <para>
        /// Allows grantee to list the objects in the bucket.
        /// </para>
        /// </summary>
        public string GrantRead
        {
            get { return this._grantRead; }
            set { this._grantRead = value; }
        }

        // Check to see if GrantRead property is set
        internal bool IsSetGrantRead()
        {
            return this._grantRead != null;
        }

        /// <summary>
        /// Gets and sets the property GrantReadACP. 
        /// <para>
        /// Allows grantee to read the bucket ACL.
        /// </para>
        /// </summary>
        public string GrantReadACP
        {
            get { return this._grantReadACP; }
            set { this._grantReadACP = value; }
        }

        // Check to see if GrantReadACP property is set
        internal bool IsSetGrantReadACP()
        {
            return this._grantReadACP != null;
        }

        /// <summary>
        /// Gets and sets the property GrantWrite. 
        /// <para>
        /// Allows grantee to create new objects in the bucket.
        /// </para>
        ///  
        /// <para>
        /// For the bucket and object owners of existing objects, also allows deletions and overwrites
        /// of those objects.
        /// </para>
        /// </summary>
        public string GrantWrite
        {
            get { return this._grantWrite; }
            set { this._grantWrite = value; }
        }

        // Check to see if GrantWrite property is set
        internal bool IsSetGrantWrite()
        {
            return this._grantWrite != null;
        }

        /// <summary>
        /// Gets and sets the property GrantWriteACP. 
        /// <para>
        /// Allows grantee to write the ACL for the applicable bucket.
        /// </para>
        /// </summary>
        public string GrantWriteACP
        {
            get { return this._grantWriteACP; }
            set { this._grantWriteACP = value; }
        }

        // Check to see if GrantWriteACP property is set
        internal bool IsSetGrantWriteACP()
        {
            return this._grantWriteACP != null;
        }

    }
}