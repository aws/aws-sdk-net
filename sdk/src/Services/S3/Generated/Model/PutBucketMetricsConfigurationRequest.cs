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
    /// Container for the parameters to the PutBucketMetricsConfiguration operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Sets a metrics configuration (specified by the metrics configuration ID) for the bucket.
    /// You can have up to 1,000 metrics configurations per bucket. If you're updating an
    /// existing metrics configuration, note that this is a full replacement of the existing
    /// metrics configuration. If you don't include the elements you want to keep, they are
    /// erased.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must have permissions to perform the <c>s3:PutMetricsConfiguration</c>
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
    /// The following operations are related to <c>PutBucketMetricsConfiguration</c>:
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
    ///  <c>PutBucketMetricsConfiguration</c> has the following special error:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Error code: <c>TooManyConfigurations</c> 
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
    ///  </li> </ul> </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutBucketMetricsConfigurationRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private string _expectedBucketOwner;
        private MetricsConfiguration _metricsConfiguration;
        private string _metricsId;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket for which the metrics configuration is set.
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
        /// Gets and sets the property MetricsConfiguration. 
        /// <para>
        /// Specifies the metrics configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricsConfiguration MetricsConfiguration
        {
            get { return this._metricsConfiguration; }
            set { this._metricsConfiguration = value; }
        }

        // Check to see if MetricsConfiguration property is set
        internal bool IsSetMetricsConfiguration()
        {
            return this._metricsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsId. 
        /// <para>
        /// The ID used to identify the metrics configuration. The ID has a 64 character limit
        /// and can only contain letters, numbers, periods, dashes, and underscores.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MetricsId
        {
            get { return this._metricsId; }
            set { this._metricsId = value; }
        }

        // Check to see if MetricsId property is set
        internal bool IsSetMetricsId()
        {
            return this._metricsId != null;
        }

    }
}