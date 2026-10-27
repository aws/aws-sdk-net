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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Defines criteria for AMIs that are excluded from lifecycle actions.
    /// </summary>
    public partial class LifecyclePolicyDetailExclusionRulesAmis
    {
        /// <summary>
        /// Gets and sets the property IsPublic. 
        /// <para>
        /// Configures whether public AMIs are excluded from the lifecycle action.
        /// </para>
        /// </summary>
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Checks to see if the IsPublic property is set.
        /// </summary>
        internal bool IsSetIsPublic() => this.IsPublic.HasValue;

        /// <summary>
        /// Gets and sets the property LastLaunched. 
        /// <para>
        /// Configures Image Builder to exclude AMIs that were launched within the specified time
        /// period from lifecycle actions. AMIs with no recorded last-launched time aren't excluded
        /// by this rule.
        /// </para>
        /// </summary>
        public LifecyclePolicyDetailExclusionRulesAmisLastLaunched LastLaunched { get; set; }

        /// <summary>
        /// Checks to see if the LastLaunched property is set.
        /// </summary>
        internal bool IsSetLastLaunched() => this.LastLaunched != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// Configures Amazon Web Services Regions that are excluded from the lifecycle action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SharedAccounts. 
        /// <para>
        /// The lifecycle action doesn't apply to AMIs that are shared with any of the specified
        /// Amazon Web Services accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1536)]
        public List<string> SharedAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SharedAccounts property is set.
        /// </summary>
        internal bool IsSetSharedAccounts() => this.SharedAccounts != null && (this.SharedAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagMap. 
        /// <para>
        /// Lifecycle actions don't apply to AMIs that have any of these tags. Both the key and
        /// the value must match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> TagMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TagMap property is set.
        /// </summary>
        internal bool IsSetTagMap() => this.TagMap != null && (this.TagMap.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
