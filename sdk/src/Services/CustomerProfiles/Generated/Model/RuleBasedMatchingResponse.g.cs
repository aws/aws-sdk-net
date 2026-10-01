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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The response of the Rule-based matching request.
    /// </summary>
    public partial class RuleBasedMatchingResponse
    {
        /// <summary>
        /// Gets and sets the property AttributeTypesSelector. 
        /// <para>
        /// Configures information about the <c>AttributeTypesSelector</c> where the rule-based
        /// identity resolution uses to match profiles.
        /// </para>
        /// </summary>
        public AttributeTypesSelector AttributeTypesSelector { get; set; }

        /// <summary>
        /// Checks to see if the AttributeTypesSelector property is set.
        /// </summary>
        internal bool IsSetAttributeTypesSelector() => this.AttributeTypesSelector != null;

        /// <summary>
        /// Gets and sets the property ConflictResolution.
        /// </summary>
        public ConflictResolution ConflictResolution { get; set; }

        /// <summary>
        /// Checks to see if the ConflictResolution property is set.
        /// </summary>
        internal bool IsSetConflictResolution() => this.ConflictResolution != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// The flag that enables the rule-based matching process of duplicate profiles.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property ExportingConfig.
        /// </summary>
        public ExportingConfig ExportingConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExportingConfig property is set.
        /// </summary>
        internal bool IsSetExportingConfig() => this.ExportingConfig != null;

        /// <summary>
        /// Gets and sets the property MatchingRules. 
        /// <para>
        /// Configures how the rule-based matching process should match profiles. You can have
        /// up to 15 <c>MatchingRule</c> in the <c>MatchingRules</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public List<MatchingRule> MatchingRules { get; set; } = AWSConfigs.InitializeCollections ? new List<MatchingRule>() : null;

        /// <summary>
        /// Checks to see if the MatchingRules property is set.
        /// </summary>
        internal bool IsSetMatchingRules() => this.MatchingRules != null && (this.MatchingRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxAllowedRuleLevelForMatching. 
        /// <para>
        /// Indicates the maximum allowed rule level.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public int? MaxAllowedRuleLevelForMatching { get; set; }

        /// <summary>
        /// Checks to see if the MaxAllowedRuleLevelForMatching property is set.
        /// </summary>
        internal bool IsSetMaxAllowedRuleLevelForMatching() => this.MaxAllowedRuleLevelForMatching.HasValue;

        /// <summary>
        /// Gets and sets the property MaxAllowedRuleLevelForMerging. 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_MatchingRule.html">MatchingRule</a>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 15)]
        public int? MaxAllowedRuleLevelForMerging { get; set; }

        /// <summary>
        /// Checks to see if the MaxAllowedRuleLevelForMerging property is set.
        /// </summary>
        internal bool IsSetMaxAllowedRuleLevelForMerging() => this.MaxAllowedRuleLevelForMerging.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// PENDING
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The first status after configuration a rule-based matching rule. If it is an existing
        /// domain, the rule-based Identity Resolution waits one hour before creating the matching
        /// rule. If it is a new domain, the system will skip the <c>PENDING</c> stage.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// IN_PROGRESS
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The system is creating the rule-based matching rule. Under this status, the system
        /// is evaluating the existing data and you can no longer change the Rule-based matching
        /// configuration.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// ACTIVE
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The rule is ready to use. You can change the rule a day after the status is in <c>ACTIVE</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RuleBasedMatchingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
