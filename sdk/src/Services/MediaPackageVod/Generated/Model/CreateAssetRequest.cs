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

/*
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAsset operation.
    /// Creates a new MediaPackage VOD Asset resource.
    /// </summary>
    public partial class CreateAssetRequest : AmazonMediaPackageVodRequest
    {
        private string _id;
        private string _packagingGroupId;
        private string _resourceId;
        private string _sourceArn;
        private string _sourceRoleArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Id. The unique identifier for the Asset.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property PackagingGroupId. The ID of the PackagingGroup for the
        /// Asset.
        /// </summary>
        [AWSProperty(Required=true)]
        public string PackagingGroupId
        {
            get { return this._packagingGroupId; }
            set { this._packagingGroupId = value; }
        }

        // Check to see if PackagingGroupId property is set
        internal bool IsSetPackagingGroupId()
        {
            return this._packagingGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. The resource ID to include in SPEKE key requests.
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. ARN of the source object in S3.
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRoleArn. The IAM role ARN used to access the source
        /// S3 bucket.
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceRoleArn
        {
            get { return this._sourceRoleArn; }
            set { this._sourceRoleArn = value; }
        }

        // Check to see if SourceRoleArn property is set
        internal bool IsSetSourceRoleArn()
        {
            return this._sourceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}