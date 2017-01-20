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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutObjectTagging operation.
    /// </summary>
    public partial class PutObjectTaggingRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string key;
        private Tagging tagging = new Tagging();
        private string versionId;

        private string md5Digest;
        
        /// <summary>
        /// The name of the bucket to contain the object.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Check to see if Bucket property is set 
        /// </summary>
        internal bool IsSetBucket()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets Key property. This key is used to identify the object in S3.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Check to see if Key property is set
        /// </summary>
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// The tag-set for the object. The tag-set must be encoded as URL Query parameters
        /// </summary>
        public Tagging Tagging
        {
            get { return this.tagging; }
            set { this.tagging = value; }
        }

        /// <summary>
        /// Checks if Tagging property is set.
        /// </summary>
        internal bool IsSetTagging()
        {
            return this.tagging != null;
        }

        /// <summary>
        /// VersionId used to reference a specific version of the object.
        ///  
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return !string.IsNullOrEmpty(this.versionId);
        }
    }
}
    
