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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAsset operation. Creates a new MediaPackage
    /// VOD Asset resource.
    /// </summary>
    public partial class CreateAssetRequest : AmazonMediaPackageVodRequest
    {
        /// <summary>
        /// Gets and sets the property Id. The unique identifier for the Asset.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PackagingGroupId. The ID of the PackagingGroup for the
        /// Asset.
        /// </summary>
        [AWSProperty(Required = true)]
        public string PackagingGroupId { get; set; }

        /// <summary>
        /// Checks to see if the PackagingGroupId property is set.
        /// </summary>
        internal bool IsSetPackagingGroupId() => this.PackagingGroupId != null;

        /// <summary>
        /// Gets and sets the property ResourceId. The resource ID to include in SPEKE key requests.
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property SourceArn. ARN of the source object in S3.
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property SourceRoleArn. The IAM role ARN used to access the source
        /// S3 bucket.
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceRoleArn property is set.
        /// </summary>
        internal bool IsSetSourceRoleArn() => this.SourceRoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
