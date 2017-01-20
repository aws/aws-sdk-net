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
    /// <para>Returns a list of inventory configurations for the bucket.</para>
    /// </summary>
    public partial class ListBucketInventoryConfigurationsRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string token;

        /// <summary>
        /// The name of the bucket containing the inventory configurations to retrieve.
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
        /// The marker used to continue an inventory configuration listing that has been truncated. 
        /// Use the NextContinuationToken from a previously truncated list response to continue the listing. 
        /// The continuation token is an opaque value that Amazon S3 understands.
        /// </summary>
        public string ContinuationToken
        {
            get { return this.token; }
            set { this.token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetContinuationToken()
        {
            return !(string.IsNullOrEmpty(this.token));
        }
    }
}
