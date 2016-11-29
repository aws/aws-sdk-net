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
    /// Returns information about the ListObjectsByTags response and response metadata.
    /// </summary>
    public class ListObjectsByTagsResponse : AmazonWebServiceResponse
    {
        private string bucketName;
        private string continuationToken;
        private string nextContinuationToken;
        private int? maxKeys;
        private bool isTruncated;
        private EncodingType encodingType;
        private List<TaggedResource> contents = new List<TaggedResource>();

        /// <summary>
        /// Name of the bucket to list.
        /// </summary>
        public string BucketName
        {
            get { return bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// ContinuationToken indicates Amazon S3 that the list is being continued on this bucket with a token.
        /// ContinuationToken is obfuscated and is not a real key
        /// </summary>
        public string ContinuationToken
        {
            get { return this.continuationToken; }
            set { this.continuationToken = value; }
        }

        /// <summary>
        /// NextContinuationToken is sent when isTruncated is true which means there are more keys in the bucket that can be listed.
        /// The next list requests to Amazon S3 can be continued with this NextContinuationToken.
        /// NextContinuationToken is obfuscated and is not a real key
        /// </summary>
        public string NextContinuationToken
        {
            get { return this.nextContinuationToken; }
            set { this.nextContinuationToken = value; }
        }

        /// <summary>
        /// Sets the maximum number of keys returned in the response. The response might contain fewer keys but will never contain more.
        /// </summary>
        public int? MaxKeys
        {
            get { return this.maxKeys; }
            set { this.maxKeys = value; }
        }

        /// <summary>
        /// A flag that indicates whether or not Amazon S3 returned all of the results that satisfied the search criteria.
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated; }
            set { this.isTruncated = value; }
        }

        /// <summary>
        /// Encoding type used by Amazon S3 to encode object keys in the response.
        /// </summary>
        public EncodingType EncodingType
        {
            get { return this.encodingType; }
            set { this.encodingType = value; }
        }

        /// <summary>
        /// Object name and optionally tagset for each object returned.
        /// </summary>
        public List<TaggedResource> Contents
        {
            get { return this.contents; }
            set { this.contents = value; }
        }
    }
}
    
