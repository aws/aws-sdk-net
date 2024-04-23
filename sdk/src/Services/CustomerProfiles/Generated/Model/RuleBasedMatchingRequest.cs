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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The request to enable the rule-based matching.
    /// </summary>
    public partial class RuleBasedMatchingRequest
    {
        private AttributeTypesSelector _attributeTypesSelector;
        private ConflictResolution _conflictResolution;
        private bool? _enabled;
        private ExportingConfig _exportingConfig;
        private List<MatchingRule> _matchingRules = AWSConfigs.InitializeCollections ? new List<MatchingRule>() : null;
        private int? _maxAllowedRuleLevelForMatching;
        private int? _maxAllowedRuleLevelForMerging;

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
        [AWSProperty(Required=true)]
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
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
        public int MaxAllowedRuleLevelForMatching
        {
            get { return this._maxAllowedRuleLevelForMatching.GetValueOrDefault(); }
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
        public int MaxAllowedRuleLevelForMerging
        {
            get { return this._maxAllowedRuleLevelForMerging.GetValueOrDefault(); }
            set { this._maxAllowedRuleLevelForMerging = value; }
        }

        // Check to see if MaxAllowedRuleLevelForMerging property is set
        internal bool IsSetMaxAllowedRuleLevelForMerging()
        {
            return this._maxAllowedRuleLevelForMerging.HasValue; 
        }

    }
}