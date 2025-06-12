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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
        private AttributeTypesSelector _attributeTypesSelector;
        private ConflictResolution _conflictResolution;
        private bool? _enabled;
        private ExportingConfig _exportingConfig;
        private List<MatchingRule> _matchingRules = AWSConfigs.InitializeCollections ? new List<MatchingRule>() : null;
        private int? _maxAllowedRuleLevelForMatching;
        private int? _maxAllowedRuleLevelForMerging;
        private RuleBasedMatchingStatus _status;

        /// <summary>
        /// Gets and sets the property AttributeTypesSelector. 
        /// <para>
        /// Configures information about the <c>AttributeTypesSelector</c> where the rule-based
        /// identity resolution uses to match profiles.
        /// </para>
        /// </summary>
        public AttributeTypesSelector AttributeTypesSelector
        {
            get { return this._attributeTypesSelector; }
            set { this._attributeTypesSelector = value; }
        }

        // Check to see if AttributeTypesSelector property is set
        internal bool IsSetAttributeTypesSelector()
        {
            return this._attributeTypesSelector != null;
        }

        /// <summary>
        /// Gets and sets the property ConflictResolution.
        /// </summary>
        public ConflictResolution ConflictResolution
        {
            get { return this._conflictResolution; }
            set { this._conflictResolution = value; }
        }

        // Check to see if ConflictResolution property is set
        internal bool IsSetConflictResolution()
        {
            return this._conflictResolution != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// The flag that enables the rule-based matching process of duplicate profiles.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportingConfig.
        /// </summary>
        public ExportingConfig ExportingConfig
        {
            get { return this._exportingConfig; }
            set { this._exportingConfig = value; }
        }

        // Check to see if ExportingConfig property is set
        internal bool IsSetExportingConfig()
        {
            return this._exportingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MatchingRules. 
        /// <para>
        /// Configures how the rule-based matching process should match profiles. You can have
        /// up to 15 <c>MatchingRule</c> in the <c>MatchingRules</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public List<MatchingRule> MatchingRules
        {
            get { return this._matchingRules; }
            set { this._matchingRules = value; }
        }

        // Check to see if MatchingRules property is set
        internal bool IsSetMatchingRules()
        {
            return this._matchingRules != null && (this._matchingRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxAllowedRuleLevelForMatching. 
        /// <para>
        /// Indicates the maximum allowed rule level.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public int? MaxAllowedRuleLevelForMatching
        {
            get { return this._maxAllowedRuleLevelForMatching; }
            set { this._maxAllowedRuleLevelForMatching = value; }
        }

        // Check to see if MaxAllowedRuleLevelForMatching property is set
        internal bool IsSetMaxAllowedRuleLevelForMatching()
        {
            return this._maxAllowedRuleLevelForMatching.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxAllowedRuleLevelForMerging. 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_MatchingRule.html">MatchingRule</a>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public int? MaxAllowedRuleLevelForMerging
        {
            get { return this._maxAllowedRuleLevelForMerging; }
            set { this._maxAllowedRuleLevelForMerging = value; }
        }

        // Check to see if MaxAllowedRuleLevelForMerging property is set
        internal bool IsSetMaxAllowedRuleLevelForMerging()
        {
            return this._maxAllowedRuleLevelForMerging.HasValue; 
        }

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
        public RuleBasedMatchingStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}