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
    /// Container for the parameters to the PutBucketLogging operation.
    /// Set the logging parameters for a bucket and to specify permissions for who can view
    /// and modify the logging parameters. All logs are saved to buckets in the same Amazon
    /// Web Services Region as the source bucket. To set the logging status of a bucket, you
    /// must be the bucket owner.
    /// 
    ///  
    /// <para>
    /// The bucket owner is automatically granted FULL_CONTROL to all logs. You use the <code>Grantee</code>
    /// request element to grant access to other people. The <code>Permissions</code> request
    /// element specifies the kind of access the grantee has to the logs.
    /// </para>
    ///  <important> 
    /// <para>
    /// If the target bucket for log delivery uses the bucket owner enforced setting for S3
    /// Object Ownership, you can't use the <code>Grantee</code> request element to grant
    /// access to others. Permissions can only be granted using policies. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/enable-server-access-logging.html#grant-log-delivery-permissions-general">Permissions
    /// for server access log delivery</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </important> 
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
    /// DisplayName is optional and ignored in the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// By Email address:
    /// </para>
    ///  
    /// <para>
    ///  <code> &lt;Grantee xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:type="AmazonCustomerByEmail"&gt;&lt;EmailAddress&gt;&lt;&gt;Grantees@email.com&lt;&gt;&lt;/EmailAddress&gt;&lt;/Grantee&gt;</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// The grantee is resolved to the CanonicalUser and, in a response to a GET Object acl
    /// request, appears as the CanonicalUser.
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
    ///  </li> </ul> 
    /// <para>
    /// To enable logging, you use LoggingEnabled and its children request elements. To disable
    /// logging, you use an empty BucketLoggingStatus request element:
    /// </para>
    ///  
    /// <para>
    ///  <code>&lt;BucketLoggingStatus xmlns="http://doc.s3.amazonaws.com/2006-03-01" /&gt;</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// For more information about server access logging, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ServerLogs.html">Server
    /// Access Logging</a> in the <i>Amazon S3 User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// For more information about creating a bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>.
    /// For more information about returning the logging status of a bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketLogging.html">GetBucketLogging</a>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>PutBucketLogging</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucket.html">DeleteBucket</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketLogging.html">GetBucketLogging</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketLoggingRequest : AmazonWebServiceRequest
    {
        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        public string BucketName { get; set; }
        private ChecksumAlgorithm _checksumAlgorithm;
        private string expectedBucketOwner;

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.BucketName != null;
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
        /// Gets and sets the LoggingConfig property.
        /// </summary>
        public S3BucketLoggingConfig LoggingConfig { get; set; }

        // Check to see if BucketLoggingStatus property is set
        internal bool IsSetLoggingConfig()
        {
            return this.LoggingConfig != null;
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
    }
}
    
