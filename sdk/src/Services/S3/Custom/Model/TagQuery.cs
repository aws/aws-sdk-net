/*
 * Copyright 2010-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 
using System.Collections.Generic;

namespace Amazon.S3.Model
{
    /// <summary>
    /// An object to represent a query to search for objects based on tags.
    /// </summary>
    public class TagQuery
    {
        private int? maxKeys;
        private bool includeTags;
        private string continuationToken;
        private EncodingType encodingType;
        private List<TagQueryFilter> and = new List<TagQueryFilter>();

        /// <summary>
        /// Sets the maximum number of keys returned in the response. The response might contain fewer keys but will never contain more.
        /// </summary>
        public int? MaxKeys
        {
            get { return this.maxKeys; }
            set { this.maxKeys = value; }
        }

        internal bool IsSetMaxKeys()
        {
            return this.maxKeys.HasValue;
        }


        /// <summary>
        /// Include objects' tagsets into the list result.
        /// </summary>
        public bool IncludeTags
        {
            get { return this.includeTags; }
            set { this.includeTags = value; }
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

        internal bool IsSetContinuationToken()
        {
            return !string.IsNullOrEmpty(continuationToken);
        }


        /// <summary>
        /// Encoding type used by Amazon S3 to encode object keys in the response.
        /// </summary>
        public EncodingType EncondingType
        {
            get { return this.encodingType; }
            set { this.encodingType = value; }
        }

        internal bool IsSetEncodingType()
        {
            return encodingType != null;
        }


        /// <summary>
        /// Filtering criteria for listing objects by tags, if there are multiple filters
        /// they all must be satisfied for the objectto be included in the result.
        /// </summary>
        public List<TagQueryFilter> And
        {
            get { return this.and; }
            set { this.and = value; }
        }
    }


    /// <summary>
    /// TagQueryFilter contains a tag key and a list of possible values.
    /// </summary>
    public class TagQueryFilter
    {
        private string key;
        private List<string> or;


        /// <summary>
        /// Name of the tag.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }


        /// <summary>
        /// Filtering criteria for listing objects by tags.
        /// If there are multiple tag values in the filter, objects matching any value for that tag are returned.
        /// </summary>
        public List<string> Or
        {
            get { return this.or; }
            set { this.or = value; }
        }
    }


    /// <summary>
    /// TaggedResource contains the object name and optionally its tagset
    /// </summary>
    public class TaggedResource
    {
        private string key;
        private List<Tag> tags = new List<Tag>();
        private string versionId;

        /// <summary>
        /// Key of the s3 object.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Filtered list of tags
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        /// <summary>
        /// Object's verisonId
        /// </summary>
        public string VersionId
        {
            get { return versionId; }
            set { this.versionId = value; }
        }
    }
}