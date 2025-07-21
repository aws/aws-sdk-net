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
using System.Linq;
using System.Text;
using Amazon.S3.Model.Internal;
namespace Amazon.S3.Model
{
    /// <summary>
    /// The configuration information for a bucket
    /// </summary>
    public class PutBucketConfiguration
    {
        private BucketInfo _bucketInfo;
        private LocationInfo _location;
        private BucketLocationConstraint _bucketLocationConstraint;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property LocationConstraint.
        /// </summary>
        public BucketLocationConstraint LocationConstraint
        {
            get { return this._bucketLocationConstraint; }
            set { this._bucketLocationConstraint = value; }
        }

        // Check to see if LocationConstraint property is set
        internal bool IsSetLocationConstraint()
        {
            return this._bucketLocationConstraint != null;
        }

        /// <summary>
        /// Gets and sets the property BucketInfo.
        /// </summary>
        public BucketInfo BucketInfo
        {
            get { return this._bucketInfo; }
            set { this._bucketInfo = value; }
        }

        // Check to see if BucketInfo property is set
        internal bool IsSetBucketInfo()
        {
            return this._bucketInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Location.
        /// </summary>
        public LocationInfo Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para>
        /// An array of tags that you can apply to the bucket that you're creating. 
        /// Tags are key-value pairs of metadata used to categorize and organize your buckets, track costs, and control access. 
        /// </para> 
        /// <note>
        /// <para>
        /// This parameter is only supported for S3 directory buckets. 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-tagging.html">Using tags with directory buckets</a>.
        /// </para>
        /// </note>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections);
        }
    }
}
