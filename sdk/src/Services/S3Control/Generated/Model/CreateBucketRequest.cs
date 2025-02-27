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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBucket operation.
    /// <note> 
    /// <para>
    /// This action creates an Amazon S3 on Outposts bucket. To create an S3 bucket, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">Create
    /// Bucket</a> in the <i>Amazon S3 API Reference</i>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Creates a new Outposts bucket. By creating the bucket, you become the bucket owner.
    /// To create an Outposts bucket, you must have S3 on Outposts. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
    /// Amazon S3 on Outposts</a> in <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Not every string is an acceptable bucket name. For information on bucket naming restrictions,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/BucketRestrictions.html#bucketnamingrules">Working
    /// with Amazon S3 Buckets</a>.
    /// </para>
    ///  
    /// <para>
    /// S3 on Outposts buckets support:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Tags
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// LifecycleConfigurations for deleting expired objects
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For a complete list of restrictions and Amazon S3 feature limitations on S3 on Outposts,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3OnOutpostsRestrictionsLimitations.html">
    /// Amazon S3 on Outposts Restrictions and Limitations</a>.
    /// </para>
    ///  
    /// <para>
    /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
    /// Outposts endpoint hostname prefix and <c>x-amz-outpost-id</c> in your API request,
    /// see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateBucket.html#API_control_CreateBucket_Examples">Examples</a>
    /// section.
    /// </para>
    ///  
    /// <para>
    /// The following actions are related to <c>CreateBucket</c> for Amazon S3 on Outposts:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucket.html">GetBucket</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucket.html">DeleteBucket</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html">CreateAccessPoint</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutAccessPointPolicy.html">PutAccessPointPolicy</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateBucketRequest : AmazonS3ControlRequest
    {
        private BucketCannedACL _acl;
        private string _bucket;
        private CreateBucketConfiguration _createBucketConfiguration;
        private string _grantFullControl;
        private string _grantRead;
        private string _grantReadACP;
        private string _grantWrite;
        private string _grantWriteACP;
        private bool? _objectLockEnabledForBucket;
        private string _outpostId;

        /// <summary>
        /// Gets and sets the property ACL. 
        /// <para>
        /// The canned ACL to apply to the bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public BucketCannedACL ACL
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
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property CreateBucketConfiguration. 
        /// <para>
        /// The configuration information for the bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public CreateBucketConfiguration CreateBucketConfiguration
        {
            get { return this._createBucketConfiguration; }
            set { this._createBucketConfiguration = value; }
        }

        // Check to see if CreateBucketConfiguration property is set
        internal bool IsSetCreateBucketConfiguration()
        {
            return this._createBucketConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property GrantFullControl. 
        /// <para>
        /// Allows grantee the read, write, read ACP, and write ACP permissions on the bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
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
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
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
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
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
        /// Allows grantee to create, overwrite, and delete any object in the bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
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
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
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

        /// <summary>
        /// Gets and sets the property ObjectLockEnabledForBucket. 
        /// <para>
        /// Specifies whether you want S3 Object Lock to be enabled for the new bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ObjectLockEnabledForBucket
        {
            get { return this._objectLockEnabledForBucket; }
            set { this._objectLockEnabledForBucket = value; }
        }

        // Check to see if ObjectLockEnabledForBucket property is set
        internal bool IsSetObjectLockEnabledForBucket()
        {
            return this._objectLockEnabledForBucket.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// The ID of the Outposts where the bucket is being created.
        /// </para>
        ///  <note> 
        /// <para>
        /// This ID is required by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string OutpostId
        {
            get { return this._outpostId; }
            set { this._outpostId = value; }
        }

        // Check to see if OutpostId property is set
        internal bool IsSetOutpostId()
        {
            return this._outpostId != null;
        }

    }
}