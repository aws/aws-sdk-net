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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCostCategoryDefinition operation.
    /// Updates an existing Cost Category. Changes made to the Cost Category rules will be
    /// used to categorize the current month’s expenses and future expenses. This won’t change
    /// categorization for the previous months.
    /// </summary>
    public partial class UpdateCostCategoryDefinitionRequest : AmazonCostExplorerRequest
    {
        private string _costCategoryArn;
        private string _defaultValue;
        private string _effectiveStart;
        private List<CostCategoryRule> _rules = AWSConfigs.InitializeCollections ? new List<CostCategoryRule>() : null;
        private CostCategoryRuleVersion _ruleVersion;
        private List<CostCategorySplitChargeRule> _splitChargeRules = AWSConfigs.InitializeCollections ? new List<CostCategorySplitChargeRule>() : null;

        /// <summary>
        /// Gets and sets the property CostCategoryArn. 
        /// <para>
        /// The unique identifier for your Cost Category.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string CostCategoryArn
        {
            get { return this._costCategoryArn; }
            set { this._costCategoryArn = value; }
        }

        // Check to see if CostCategoryArn property is set
        internal bool IsSetCostCategoryArn()
        {
            return this._costCategoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultValue.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveStart. 
        /// <para>
        /// The Cost Category's effective start date. It can only be a billing start date (first
        /// day of the month). If the date isn't provided, it's the first day of the current month.
        /// Dates can't be before the previous twelve months, or in the future.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string EffectiveStart
        {
            get { return this._effectiveStart; }
            set { this._effectiveStart = value; }
        }

        // Check to see if EffectiveStart property is set
        internal bool IsSetEffectiveStart()
        {
            return this._effectiveStart != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The <c>Expression</c> object used to categorize costs. For more information, see <a
        /// href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_CostCategoryRule.html">CostCategoryRule
        /// </a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public List<CostCategoryRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleVersion.
        /// </summary>
        [AWSProperty(Required=true)]
        public CostCategoryRuleVersion RuleVersion
        {
            get { return this._ruleVersion; }
            set { this._ruleVersion = value; }
        }

        // Check to see if RuleVersion property is set
        internal bool IsSetRuleVersion()
        {
            return this._ruleVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SplitChargeRules. 
        /// <para>
        ///  The split charge rules used to allocate your charges between your Cost Category values.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<CostCategorySplitChargeRule> SplitChargeRules
        {
            get { return this._splitChargeRules; }
            set { this._splitChargeRules = value; }
        }

        // Check to see if SplitChargeRules property is set
        internal bool IsSetSplitChargeRules()
        {
            return this._splitChargeRules != null && (this._splitChargeRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}