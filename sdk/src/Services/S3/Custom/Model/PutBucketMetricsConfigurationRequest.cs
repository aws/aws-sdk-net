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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketMetricsConfiguration operation.
    /// Sets a metrics configuration (specified by the metrics configuration ID) for the bucket.
    /// You can have up to 1,000 metrics configurations per bucket. If you're updating an
    /// existing metrics configuration, note that this is a full replacement of the existing
    /// metrics configuration. If you don't include the elements you want to keep, they are
    /// erased.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must have permissions to perform the <code>s3:PutMetricsConfiguration</code>
    /// action. The bucket owner has this permission by default. The bucket owner can grant
    /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about CloudWatch request metrics for Amazon S3, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cloudwatch-monitoring.html">Monitoring
    /// Metrics with Amazon CloudWatch</a>.
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>PutBucketMetricsConfiguration</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketMetricsConfiguration.html">DeleteBucketMetricsConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketMetricsConfiguration.html">GetBucketMetricsConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListBucketMetricsConfigurations.html">ListBucketMetricsConfigurations</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <code>GetBucketLifecycle</code> has the following special error:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Error code: <code>TooManyConfigurations</code> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Description: You are attempting to create a new configuration but have already reached
    /// the 1,000-configuration limit.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// HTTP Status Code: HTTP 400 Bad Request
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class PutBucketMetricsConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string metricsId;
        private MetricsConfiguration metricsConfiguration;
        private string expectedBucketOwner;

        /// <summary>
        /// The name of the bucket for which the metrics configuration is set.
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
        /// <para>
        /// The ID used to identify the metrics configuration. 
        /// The ID has a 64 character limit and can only contain letters, numbers, periods, dashes, and underscores.
        /// </para>
        /// </summary>
        public string MetricsId
        {
            get { return this.metricsId; }
            set { this.metricsId = value; }
        }

        // Check to see if MetricsId property is set
        internal bool IsSetMetricsId()
        {
            return this.metricsId != null;
        }

        /// <summary>
        /// Specifies the metrics configuration.
        /// </summary>
        public MetricsConfiguration MetricsConfiguration
        {
            get { return this.metricsConfiguration; }
            set { this.metricsConfiguration = value; }
        }

        // Check to see if MetricsConfiguration property is set
        internal bool IsSetMetricsConfiguration()
        {
            return this.metricsConfiguration != null;
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
