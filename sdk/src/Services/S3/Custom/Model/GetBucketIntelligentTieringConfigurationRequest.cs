/*
 *Copyright Amazon.com, Inc.or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 *You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 *
 *or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the GetBucketIntelligentTieringConfiguration operation.
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Gets the S3 Intelligent-Tiering configuration from the specified bucket.
    /// </para>
    ///  
    /// <para>
    /// The S3 Intelligent-Tiering storage class is designed to optimize storage costs by
    /// automatically moving data to the most cost-effective storage access tier, without
    /// performance impact or operational overhead. S3 Intelligent-Tiering delivers automatic
    /// cost savings in three low latency and high throughput access tiers. To get the lowest
    /// storage cost on data that can be accessed in minutes to hours, you can choose to activate
    /// additional archiving capabilities.
    /// </para>
    ///  
    /// <para>
    /// The S3 Intelligent-Tiering storage class is the ideal storage class for data with
    /// unknown, changing, or unpredictable access patterns, independent of object size or
    /// retention period. If the size of an object is less than 128 KB, it is not monitored
    /// and not eligible for auto-tiering. Smaller objects can be stored, but they are always
    /// charged at the Frequent Access tier rates in the S3 Intelligent-Tiering storage class.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html#sc-dynamic-data-access">Storage
    /// class for automatically optimizing frequently and infrequently accessed objects</a>.
    /// </para>
    ///  
    /// <para>
    /// Operations related to <code>GetBucketIntelligentTieringConfiguration</code> include:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketIntelligentTieringConfiguration.html">DeleteBucketIntelligentTieringConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketIntelligentTieringConfiguration.html">PutBucketIntelligentTieringConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListBucketIntelligentTieringConfigurations.html">ListBucketIntelligentTieringConfigurations</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetBucketIntelligentTieringConfigurationRequest : AmazonWebServiceRequest
	{
        
        private string bucketName;
        private string expectedBucketOwner;
        private string intelligentTieringId;

        /// <summary>
        /// <para>The name of the Amazon S3 bucket whose configuration you want to modify or retrieve.</para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.BucketName != null;
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
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return this.expectedBucketOwner != null;
        }

        /// <summary>
        /// <para>The ID used to identify the S3 Intelligent-Tiering configuration.</para>
        /// </summary>
        public string IntelligentTieringId
		{
            get { return this.intelligentTieringId; }
            set { this.intelligentTieringId = value; }
        }

        // Check to see if IntelligentTieringId property is set
        internal bool IsSetIntelligentTieringId()
        {
            return !(string.IsNullOrEmpty(this.intelligentTieringId));
        }
    }
}
