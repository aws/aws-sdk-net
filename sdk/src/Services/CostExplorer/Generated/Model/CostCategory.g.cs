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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The structure of Cost Categories. This includes detailed metadata and the set of rules
    /// for the <c>CostCategory</c> object.
    /// </summary>
    public partial class CostCategory
    {
        /// <summary>
        /// Gets and sets the property CostCategoryArn. 
        /// <para>
        /// The unique identifier for your cost category. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string CostCategoryArn { get; set; }

        /// <summary>
        /// Checks to see if the CostCategoryArn property is set.
        /// </summary>
        internal bool IsSetCostCategoryArn() => this.CostCategoryArn != null;

        /// <summary>
        /// Gets and sets the property DefaultValue.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property EffectiveEnd. 
        /// <para>
        /// The effective end date of your cost category.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string EffectiveEnd { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveEnd property is set.
        /// </summary>
        internal bool IsSetEffectiveEnd() => this.EffectiveEnd != null;

        /// <summary>
        /// Gets and sets the property EffectiveStart. 
        /// <para>
        /// The effective start date of your cost category.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 25)]
        public string EffectiveStart { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveStart property is set.
        /// </summary>
        internal bool IsSetEffectiveStart() => this.EffectiveStart != null;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProcessingStatus. 
        /// <para>
        /// The list of processing statuses for Cost Management products for a specific cost category.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CostCategoryProcessingStatus> ProcessingStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<CostCategoryProcessingStatus>() : null;

        /// <summary>
        /// Checks to see if the ProcessingStatus property is set.
        /// </summary>
        internal bool IsSetProcessingStatus() => this.ProcessingStatus != null && (this.ProcessingStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleVersion.
        /// </summary>
        [AWSProperty(Required = true)]
        public CostCategoryRuleVersion RuleVersion { get; set; }

        /// <summary>
        /// Checks to see if the RuleVersion property is set.
        /// </summary>
        internal bool IsSetRuleVersion() => this.RuleVersion != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The rules are processed in order. If there are multiple rules that match the line
        /// item, then the first rule to match is used to determine that cost category value.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public List<CostCategoryRule> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<CostCategoryRule>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SplitChargeRules. 
        /// <para>
        ///  The split charge rules that are used to allocate your charges between your cost category
        /// values. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CostCategorySplitChargeRule> SplitChargeRules { get; set; } = AWSConfigs.InitializeCollections ? new List<CostCategorySplitChargeRule>() : null;

        /// <summary>
        /// Checks to see if the SplitChargeRules property is set.
        /// </summary>
        internal bool IsSetSplitChargeRules() => this.SplitChargeRules != null && (this.SplitChargeRules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
