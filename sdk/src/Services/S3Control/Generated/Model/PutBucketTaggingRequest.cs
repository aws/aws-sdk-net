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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketTagging operation.
    /// <note> 
    /// <para>
    /// This action puts tags on an Amazon S3 on Outposts bucket. To put tags on an S3 bucket,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketTagging.html">PutBucketTagging</a>
    /// in the <i>Amazon S3 API Reference</i>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Sets the tags for an S3 on Outposts bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
    /// Amazon S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Use tags to organize your Amazon Web Services bill to reflect your own cost structure.
    /// To do this, sign up to get your Amazon Web Services account bill with tag key values
    /// included. Then, to see the cost of combined resources, organize your billing information
    /// according to resources with the same tag key values. For example, you can tag several
    /// resources with a specific application name, and then organize your billing information
    /// to see the total cost of that application across several services. For more information,
    /// see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Cost
    /// allocation and tagging</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Within a bucket, if you add a tag that has the same key as an existing tag, the new
    /// value overwrites the old value. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/CostAllocTagging.html">
    /// Using cost allocation in Amazon S3 bucket tags</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// To use this action, you must have permissions to perform the <code>s3-outposts:PutBucketTagging</code>
    /// action. The Outposts bucket owner has this permission by default and can grant this
    /// permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">
    /// Permissions Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// access permissions to your Amazon S3 resources</a>.
    /// </para>
    ///  
    /// <para>
    ///  <code>PutBucketTagging</code> has the following special errors:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Error code: <code>InvalidTagError</code> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: The tag provided was not a valid tag. This error can occur if the tag
    /// did not pass input validation. For information about tag restrictions, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">
    /// User-Defined Tag Restrictions</a> and <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/aws-tag-restrictions.html">
    /// Amazon Web Services-Generated Cost Allocation Tag Restrictions</a>.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Error code: <code>MalformedXMLError</code> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: The XML provided does not match the schema.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Error code: <code>OperationAbortedError </code> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: A conflicting conditional action is currently in progress against this
    /// resource. Try again.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Error code: <code>InternalError</code> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: The service was unable to apply the provided tag to the bucket.
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// All Amazon S3 on Outposts REST API requests for this action require an additional
    /// parameter of <code>x-amz-outpost-id</code> to be passed with the request. In addition,
    /// you must use an S3 on Outposts endpoint hostname prefix instead of <code>s3-control</code>.
    /// For an example of the request syntax for Amazon S3 on Outposts that uses the S3 on
    /// Outposts endpoint hostname prefix and the <code>x-amz-outpost-id</code> derived by
    /// using the access point ARN, see the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutBucketTagging.html#API_control_PutBucketTagging_Examples">Examples</a>
    /// section.
    /// </para>
    ///  
    /// <para>
    /// The following actions are related to <code>PutBucketTagging</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetBucketTagging.html">GetBucketTagging</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteBucketTagging.html">DeleteBucketTagging</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketTaggingRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _bucket;
        private Tagging _tagging;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the Outposts bucket.
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
        /// The Amazon Resource Name (ARN) of the bucket.
        /// </para>
        ///  
        /// <para>
        /// For using this parameter with Amazon S3 on Outposts with the REST API, you must specify
        /// the name and the x-amz-outpost-id as well.
        /// </para>
        ///  
        /// <para>
        /// For using this parameter with S3 on Outposts with the Amazon Web Services SDK and
        /// CLI, you must specify the ARN of the bucket accessed in the format <code>arn:aws:s3-outposts:&lt;Region&gt;:&lt;account-id&gt;:outpost/&lt;outpost-id&gt;/bucket/&lt;my-bucket-name&gt;</code>.
        /// For example, to access the bucket <code>reports</code> through Outpost <code>my-outpost</code>
        /// owned by account <code>123456789012</code> in Region <code>us-west-2</code>, use the
        /// URL encoding of <code>arn:aws:s3-outposts:us-west-2:123456789012:outpost/my-outpost/bucket/reports</code>.
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
        /// Gets and sets the property Tagging.
        /// </summary>
        [AWSProperty(Required=true)]
        public Tagging Tagging
        {
            get { return this._tagging; }
            set { this._tagging = value; }
        }

        // Check to see if Tagging property is set
        internal bool IsSetTagging()
        {
            return this._tagging != null;
        }

    }
}