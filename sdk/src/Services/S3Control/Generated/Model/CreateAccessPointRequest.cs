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
    /// Container for the parameters to the CreateAccessPoint operation.
    /// Creates an access point and associates it to a specified bucket. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points.html">Managing
    /// access to shared datasets with access points</a> or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-directory-buckets.html">Managing
    /// access to shared datasets in directory buckets with access points</a> in the <i>Amazon
    /// S3 User Guide</i>.
    /// 
    ///  
    /// <para>
    /// To create an access point and attach it to a volume on an Amazon FSx file system,
    /// see <a href="https://docs.aws.amazon.com/fsx/latest/APIReference/API_CreateAndAttachS3AccessPoint.html">CreateAndAttachS3AccessPoint</a>
    /// in the <i>Amazon FSx API Reference</i>.
    /// </para>
    ///   <note> 
    /// <para>
    /// S3 on Outposts only supports VPC-style access points. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">
    /// Accessing Amazon S3 on Outposts using virtual private cloud (VPC) only access points</a>
    /// in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// All Amazon S3 on Outposts REST API requests for this action require an additional
    /// parameter of <c>x-amz-outpost-id</c> to be passed with the request. In addition, you
    /// must use an S3 on Outposts endpoint hostname prefix instead of <c>s3-control</c>.
    /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
    /// Outposts endpoint hostname prefix and the <c>x-amz-outpost-id</c> derived by using
    /// the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateAccessPoint.html#API_control_CreateAccessPoint_Examples">Examples</a>
    /// section.
    /// </para>
    ///   
    /// <para>
    /// The following actions are related to <c>CreateAccessPoint</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetAccessPoint.html">GetAccessPoint</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteAccessPoint.html">DeleteAccessPoint</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPoints.html">ListAccessPoints</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_ListAccessPointsForDirectoryBuckets.html">ListAccessPointsForDirectoryBuckets</a>
    /// 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateAccessPointRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _bucket;
        private string _bucketAccountId;
        private string _name;
        private PublicAccessBlockConfiguration _publicAccessBlockConfiguration;
        private Scope _scope;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private VpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the account that owns the specified access
        /// point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the bucket that you want to associate this access point with.
        /// </para>
        ///  
        /// <para>
        /// For using this parameter with Amazon S3 on Outposts with the REST API, you must specify
        /// the name and the x-amz-outpost-id as well.
        /// </para>
        ///  
        /// <para>
        /// For using this parameter with S3 on Outposts with the Amazon Web Services SDK and
        /// CLI, you must specify the ARN of the bucket accessed in the format <c>arn:aws:s3-outposts:&lt;Region&gt;:&lt;account-id&gt;:outpost/&lt;outpost-id&gt;/bucket/&lt;my-bucket-name&gt;</c>.
        /// For example, to access the bucket <c>reports</c> through Outpost <c>my-outpost</c>
        /// owned by account <c>123456789012</c> in Region <c>us-west-2</c>, use the URL encoding
        /// of <c>arn:aws:s3-outposts:us-west-2:123456789012:outpost/my-outpost/bucket/reports</c>.
        /// The value must be URL encoded. 
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
        /// Gets and sets the property BucketAccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the S3 bucket associated with this
        /// access point.
        /// </para>
        ///  
        /// <para>
        /// For same account access point when your bucket and access point belong to the same
        /// account owner, the <c>BucketAccountId</c> is not required. For cross-account access
        /// point when your bucket and access point are not in the same account, the <c>BucketAccountId</c>
        /// is required. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string BucketAccountId
        {
            get { return this._bucketAccountId; }
            set { this._bucketAccountId = value; }
        }

        // Check to see if BucketAccountId property is set
        internal bool IsSetBucketAccountId()
        {
            return this._bucketAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name you want to assign to this access point.
        /// </para>
        ///  
        /// <para>
        /// For directory buckets, the access point name must consist of a base name that you
        /// provide and suffix that includes the <c>ZoneID</c> (Amazon Web Services Availability
        /// Zone or Local Zone) of your bucket location, followed by <c>--xa-s3</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-directory-buckets.html">Managing
        /// access to shared datasets in directory buckets with access points</a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PublicAccessBlockConfiguration. 
        /// <para>
        ///  The <c>PublicAccessBlock</c> configuration that you want to apply to the access point.
        /// 
        /// </para>
        /// </summary>
        public PublicAccessBlockConfiguration PublicAccessBlockConfiguration
        {
            get { return this._publicAccessBlockConfiguration; }
            set { this._publicAccessBlockConfiguration = value; }
        }

        // Check to see if PublicAccessBlockConfiguration property is set
        internal bool IsSetPublicAccessBlockConfiguration()
        {
            return this._publicAccessBlockConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// For directory buckets, you can filter access control to specific prefixes, API operations,
        /// or a combination of both. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-directory-buckets.html">Managing
        /// access to shared datasets in directory buckets with access points</a> in the <i>Amazon
        /// S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Scope is only supported for access points attached to directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tags that you can apply to an access point. Tags are key-value pairs of
        /// metadata used to control access to your access points. For more information about
        /// tags, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html">Using
        /// tags with Amazon S3</a>. For information about tagging access points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html#using-tags-for-abac">Using
        /// tags for attribute-based access control (ABAC)</a>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// You must have the <c>s3:TagResource</c> permission to create an access point with
        /// tags for a general purpose bucket. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have the <c>s3express:TagResource</c> permission to create an access point
        /// with tags for a directory bucket.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// If you include this field, Amazon S3 restricts access to this access point to requests
        /// from the specified virtual private cloud (VPC).
        /// </para>
        ///  <note> 
        /// <para>
        /// This is required for creating an access point for Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public VpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}