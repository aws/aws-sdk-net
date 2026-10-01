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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a proposed segment change. In some cases, the segment change must first
    /// be evaluated and accepted.
    /// </summary>
    public partial class ProposedSegmentChange
    {
        /// <summary>
        /// Gets and sets the property AttachmentPolicyRuleNumber. 
        /// <para>
        /// The rule number in the policy document that applies to this change.
        /// </para>
        /// </summary>
        public int? AttachmentPolicyRuleNumber { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentPolicyRuleNumber property is set.
        /// </summary>
        internal bool IsSetAttachmentPolicyRuleNumber() => this.AttachmentPolicyRuleNumber.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The name of the segment to change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SegmentName { get; set; }

        /// <summary>
        /// Checks to see if the SegmentName property is set.
        /// </summary>
        internal bool IsSetSegmentName() => this.SegmentName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key-value tags that changed for the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
