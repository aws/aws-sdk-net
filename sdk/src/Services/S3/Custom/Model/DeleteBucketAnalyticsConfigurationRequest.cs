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
    /// Container for the parameters to the DeleteBucketAnalyticsConfiguration operation.
    /// <para>Deletes an analytics configuration for the bucket (specified by the analytics configuration ID).</para>
    /// </summary>
    public partial class DeleteBucketAnalyticsConfigurationRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string analyticsId;
        private string expectedBucketOwner;

        /// <summary>
        /// The name of the bucket from which an analytics configuration is deleted.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return !(string.IsNullOrEmpty(this.bucketName));
        }

        /// <summary>
        /// The identifier used to represent an analytics configuration.
        /// </summary>
        public string AnalyticsId
        {
            get { return this.analyticsId; }
            set { this.analyticsId = value; }
        }

        // Check to see if InventoryId property is set
        internal bool IsSetAnalyticsId()
        {
            return !(string.IsNullOrEmpty(this.analyticsId));
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <code>403 Forbidden</code> (access denied).
        /// </para>
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
