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
    /// Container for the parameters to the ListBuckets operation.
    /// <note> 
    /// <para>This operation is not supported by directory buckets.</para>
    /// </note>
    ///  
    /// <para>
    /// Returns a list of all buckets owned by the authenticated sender of the request. To
    /// use this operation, you must have the <c>s3:ListAllMyBuckets</c> permission.
    /// </para>
    ///  
    /// <para>
    /// For information about Amazon S3 buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/creating-buckets-s3.html">Creating,
    /// configuring, and working with Amazon S3 buckets</a>.
    /// </para>
    /// </summary>
    public partial class ListBucketsRequest : AmazonWebServiceRequest
    {
        private string _continuationToken;
        private int? _maxBuckets;

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        /// <c>ContinuationToken</c> is included in the response when there are more buckets that can be listed with pagination. 
        /// The next <c>ListBuckets</c> request to Amazon S3 can be continued with this <c>ContinuationToken</c>. 
        /// <c>ContinuationToken</c> is obfuscated and is not a real bucket.
        /// </para>
        /// </summary>
        public string ContinuationToken
        {
            get { return this._continuationToken; }
            set { this._continuationToken = value; }
        }

        // Check to see if ContinuationToken property is set
        internal bool IsSetContinuationToken()
        {
            return this._continuationToken != null;
        }

        /// <summary>
        /// Gets and sets the property MaxBuckets.
        /// <para>
        /// Maximum number of buckets to be returned in response. When the number is more than the count of buckets that are
        /// owned by an Amazon Web Services account, return all the buckets in response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int MaxBuckets
        {
            get { return this._maxBuckets.GetValueOrDefault(); }
            set { this._maxBuckets = value; }
        }

        // Check to see if MaxBuckets property is set
        internal bool IsSetMaxBuckets()
        {
            return this._maxBuckets.HasValue;
        }
    }
}
    
