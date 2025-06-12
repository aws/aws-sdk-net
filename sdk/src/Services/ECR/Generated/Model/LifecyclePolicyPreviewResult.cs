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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
        private LifecyclePolicyRuleAction _action;
        private int? _appliedRulePriority;
        private string _imageDigest;
        private DateTime? _imagePushedAt;
        private List<string> _imageTags = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of action to be taken.
        /// </para>
        /// </summary>
        public LifecyclePolicyRuleAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property AppliedRulePriority. 
        /// <para>
        /// The priority of the applied rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? AppliedRulePriority
        {
            get { return this._appliedRulePriority; }
            set { this._appliedRulePriority = value; }
        }

        // Check to see if AppliedRulePriority property is set
        internal bool IsSetAppliedRulePriority()
        {
            return this._appliedRulePriority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// The <c>sha256</c> digest of the image manifest.
        /// </para>
        /// </summary>
        public string ImageDigest
        {
            get { return this._imageDigest; }
            set { this._imageDigest = value; }
        }

        // Check to see if ImageDigest property is set
        internal bool IsSetImageDigest()
        {
            return this._imageDigest != null;
        }

        /// <summary>
        /// Gets and sets the property ImagePushedAt. 
        /// <para>
        /// The date and time, expressed in standard JavaScript date format, at which the current
        /// image was pushed to the repository.
        /// </para>
        /// </summary>
        public DateTime? ImagePushedAt
        {
            get { return this._imagePushedAt; }
            set { this._imagePushedAt = value; }
        }

        // Check to see if ImagePushedAt property is set
        internal bool IsSetImagePushedAt()
        {
            return this._imagePushedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The list of tags associated with this image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImageTags
        {
            get { return this._imageTags; }
            set { this._imageTags = value; }
        }

        // Check to see if ImageTags property is set
        internal bool IsSetImageTags()
        {
            return this._imageTags != null && (this._imageTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}