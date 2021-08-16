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
    /// Container for the parameters to the PutBucketTagging operation.
    /// Sets the tags for a bucket.
    /// 
    ///  
    /// <para>
    /// Use tags to organize your Amazon Web Services bill to reflect your own cost structure.
    /// To do this, sign up to get your Amazon Web Services account bill with tag key values
    /// included. Then, to see the cost of combined resources, organize your billing information
    /// according to resources with the same tag key values. For example, you can tag several
    /// resources with a specific application name, and then organize your billing information
    /// to see the total cost of that application across several services. For more information,
    /// see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Cost
    /// Allocation and Tagging</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CostAllocTagging.html">Using
    /// Cost Allocation in Amazon S3 Bucket Tags</a>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  When this operation sets the tags for a bucket, it will overwrite any current tags
    /// the bucket already has. You cannot use this operation to add tags to an existing list
    /// of tags.
    /// </para>
    ///  </note> 
    /// <para>
    /// To use this operation, you must have permissions to perform the <code>s3:PutBucketTagging</code>
    /// action. The bucket owner has this permission by default and can grant this permission
    /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a>.
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
    /// did not pass input validation. For information about tag restrictions, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-Defined
    /// Tag Restrictions</a> and <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/aws-tag-restrictions.html">Amazon
    /// Web Services-Generated Cost Allocation Tag Restrictions</a>.
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
    /// resource. Please try again.
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
    /// The following operations are related to <code>PutBucketTagging</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketTagging.html">GetBucketTagging</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketTagging.html">DeleteBucketTagging</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketTaggingRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private List<Tag> tagSet = new List<Tag>();
        private string expectedBucketOwner;

        /// <summary>
        /// The name of the bucket to apply the tags to.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// The collection of tags.
        /// </summary>
        public List<Tag> TagSet
        {
            get { return this.tagSet; }
            set { this.tagSet = value; }
        }

        // Check to see if TagSet property is set
        internal bool IsSetTagSet()
        {
            return this.tagSet.Count > 0;
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
    
