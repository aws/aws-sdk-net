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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// The result of the lifecycle policy preview.
    /// </summary>
    public partial class LifecyclePolicyPreviewResult
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of action to be taken.
        /// </para>
        /// </summary>
        public LifecyclePolicyRuleAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property AppliedRulePriority. 
        /// <para>
        /// The priority of the applied rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? AppliedRulePriority { get; set; }

        /// <summary>
        /// Checks to see if the AppliedRulePriority property is set.
        /// </summary>
        internal bool IsSetAppliedRulePriority() => this.AppliedRulePriority.HasValue;

        /// <summary>
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// The <c>sha256</c> digest of the image manifest.
        /// </para>
        /// </summary>
        public string ImageDigest { get; set; }

        /// <summary>
        /// Checks to see if the ImageDigest property is set.
        /// </summary>
        internal bool IsSetImageDigest() => this.ImageDigest != null;

        /// <summary>
        /// Gets and sets the property ImagePushedAt. 
        /// <para>
        /// The date and time, expressed in standard JavaScript date format, at which the current
        /// image was pushed to the repository.
        /// </para>
        /// </summary>
        public DateTime? ImagePushedAt { get; set; }

        /// <summary>
        /// Checks to see if the ImagePushedAt property is set.
        /// </summary>
        internal bool IsSetImagePushedAt() => this.ImagePushedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The list of tags associated with this image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImageTags { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImageTags property is set.
        /// </summary>
        internal bool IsSetImageTags() => this.ImageTags != null && (this.ImageTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The storage class of the image.
        /// </para>
        /// </summary>
        public LifecyclePolicyStorageClass StorageClass { get; set; }

        /// <summary>
        /// Checks to see if the StorageClass property is set.
        /// </summary>
        internal bool IsSetStorageClass() => this.StorageClass != null;
    }
}
