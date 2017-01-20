/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the ListInventoryConfigurationsRequest operation.
    /// <para>Lists the analytics configurations for the bucket.</para>
    /// </summary>
    public partial class ListBucketAnalyticsConfigurationsRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string token;

        /// <summary>
        /// The name of the bucket containing the analytics configurations to retrieve.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return !(string.IsNullOrEmpty(this.bucketName));
        }

        /// <summary>
        /// The ContinuationToken that represents a placeholder from where this request should begin.
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
    }
}
