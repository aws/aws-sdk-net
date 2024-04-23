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
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the ListDirectoryBuckets operation.
    /// </summary>
    public partial class ListDirectoryBucketsResponse : AmazonWebServiceResponse
    {
        private List<S3Bucket> _buckets = AWSConfigs.InitializeCollections ? new List<S3Bucket>() : null;
        private string _continuationToken;

        /// <summary>
        /// Gets and sets the property Buckets. 
        /// <para>
        /// The list of buckets owned by the requester. 
        /// </para>
        /// </summary>
        public List<S3Bucket> Buckets
        {
            get { return this._buckets; }
            set { this._buckets = value; }
        }

        // Check to see if Buckets property is set
        internal bool IsSetBuckets()
        {
            return this._buckets != null && (this._buckets.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// Gets and sets the property ContinuationToken. 
        /// <para>
        /// If <code>ContinuationToken</code> was sent with the request, it is included in the
        /// response. You can use the returned <code>ContinuationToken</code> for pagination of
        /// the list response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
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

    }
}