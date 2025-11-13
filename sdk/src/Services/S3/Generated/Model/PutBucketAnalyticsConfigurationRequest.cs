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
    /// Container for the parameters to the PutBucketAnalyticsConfiguration operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Sets an analytics configuration for the bucket (specified by the analytics configuration
    /// ID). You can have up to 1,000 analytics configurations per bucket.
    /// </para>
    ///  
    /// <para>
    /// You can choose to have storage class analysis export analysis reports sent to a comma-separated
    /// values (CSV) flat file. See the <c>DataExport</c> request element. Reports are updated
    /// daily and are based on the object filters that you configure. When selecting data
    /// export, you specify a destination bucket and an optional destination prefix where
    /// the file is written. You can export the data to a destination bucket in a different
    /// account. However, the destination bucket must be in the same Region as the bucket
    /// that you are making the PUT analytics configuration to. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/analytics-storage-class.html">Amazon
    /// S3 Analytics – Storage Class Analysis</a>. 
    /// </para>
    ///  <important> 
    /// <para>
    /// You must create a bucket policy on the destination bucket where the exported file
    /// is written to grant permissions to Amazon S3 to write objects to the bucket. For an
    /// example policy, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/example-bucket-policies.html#example-bucket-policies-use-case-9">Granting
    /// Permissions for Amazon S3 Inventory and Storage Class Analysis</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// To use this operation, you must have permissions to perform the <c>s3:PutAnalyticsConfiguration</c>
    /// action. The bucket owner has this permission by default. The bucket owner can grant
    /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a>.
    /// </para>
    ///  
    /// <para>
    ///  <c>PutBucketAnalyticsConfiguration</c> has the following special errors:
    /// </para>
    ///  <ul> <li> <ul> <li> 
    /// <para>
    ///  <i>HTTP Error: HTTP 400 Bad Request</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Code: InvalidArgument</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause: Invalid argument.</i> 
    /// </para>
    ///  </li> </ul> </li> <li> <ul> <li> 
    /// <para>
    ///  <i>HTTP Error: HTTP 400 Bad Request</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Code: TooManyConfigurations</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause: You are attempting to create a new configuration but have already reached
    /// the 1,000-configuration limit.</i> 
    /// </para>
    ///  </li> </ul> </li> <li> <ul> <li> 
    /// <para>
    ///  <i>HTTP Error: HTTP 403 Forbidden</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Code: AccessDenied</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause: You are not the owner of the specified bucket, or you do not have the s3:PutAnalyticsConfiguration
    /// bucket permission to set the configuration on the bucket.</i> 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// The following operations are related to <c>PutBucketAnalyticsConfiguration</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketAnalyticsConfiguration.html">GetBucketAnalyticsConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketAnalyticsConfiguration.html">DeleteBucketAnalyticsConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListBucketAnalyticsConfigurations.html">ListBucketAnalyticsConfigurations</a>
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
    public partial class PutBucketAnalyticsConfigurationRequest : AmazonWebServiceRequest
    {
        private AnalyticsConfiguration _analyticsConfiguration;
        private string _analyticsId;
        private string _bucketName;
        private string _expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property AnalyticsConfiguration. 
        /// <para>
        /// The configuration and any analyses for the analytics filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalyticsConfiguration AnalyticsConfiguration
        {
            get { return this._analyticsConfiguration; }
            set { this._analyticsConfiguration = value; }
        }

        // Check to see if AnalyticsConfiguration property is set
        internal bool IsSetAnalyticsConfiguration()
        {
            return this._analyticsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AnalyticsId. 
        /// <para>
        /// The ID that identifies the analytics configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AnalyticsId
        {
            get { return this._analyticsId; }
            set { this._analyticsId = value; }
        }

        // Check to see if AnalyticsId property is set
        internal bool IsSetAnalyticsId()
        {
            return this._analyticsId != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket to which an analytics configuration is stored.
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
            return !String.IsNullOrEmpty(this._expectedBucketOwner);
        }

    }
}