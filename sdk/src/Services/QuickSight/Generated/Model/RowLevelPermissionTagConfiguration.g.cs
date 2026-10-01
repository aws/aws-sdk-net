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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration of tags on a dataset to set row-level security.
    /// </summary>
    public partial class RowLevelPermissionTagConfiguration
    {
        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of row-level security tags. If enabled, the status is <c>ENABLED</c>. If
        /// disabled, the status is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TagRuleConfigurations. 
        /// <para>
        /// A list of tag configuration rules to apply to a dataset. All tag configurations have
        /// the OR condition. Tags within each tile will be joined (AND). At least one rule in
        /// this structure must have all tag values assigned to it to apply Row-level security
        /// (RLS) to the dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<List<string>> TagRuleConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;

        /// <summary>
        /// Checks to see if the TagRuleConfigurations property is set.
        /// </summary>
        internal bool IsSetTagRuleConfigurations() => this.TagRuleConfigurations != null && (this.TagRuleConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagRules. 
        /// <para>
        /// A set of rules associated with row-level security, such as the tag names and columns
        /// that they are assigned to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<RowLevelPermissionTagRule> TagRules { get; set; } = AWSConfigs.InitializeCollections ? new List<RowLevelPermissionTagRule>() : null;

        /// <summary>
        /// Checks to see if the TagRules property is set.
        /// </summary>
        internal bool IsSetTagRules() => this.TagRules != null && (this.TagRules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
