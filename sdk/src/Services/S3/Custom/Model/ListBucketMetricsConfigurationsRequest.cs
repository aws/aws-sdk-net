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
    /// Container for the parameters to the ListBucketMetricsConfigurationRequest operation.
    /// <para>Lists the metrics configurations for the bucket.</para>
    /// </summary>
    public partial class ListBucketMetricsConfigurationsRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string token;
        private string expectedBucketOwner;

        /// <summary>
        /// The name of the bucket containing the metrics configurations to retrieve.
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
        /// <para>
        /// The marker that is used to continue a metrics configuration listing that has been truncated. 
        /// Use the<code>NextContinuationToken</code> from a previously truncated
        /// list response to continue the listing. The continuation token is an opaque value that
        /// Amazon S3 understands.
        /// </para>
        /// </summary>
        public string ContinuationToken
        {
            get { return this.token; }
            set { this.token = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return !(string.IsNullOrEmpty(this.ContinuationToken));
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
