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
    /// Container for the parameters to the CreateCostCategoryDefinition operation. Creates
    /// a new cost category with the requested name and rules.
    /// </summary>
    public partial class CreateCostCategoryDefinitionRequest : AmazonCostExplorerRequest
    {
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
        /// Gets and sets the property EffectiveStart. 
        /// <para>
        /// The cost category's effective start date. It can only be a billing start date (first
        /// day of the month). If the date isn't provided, it's the first day of the current month.
        /// Dates can't be before the previous twelve months, or in the future.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
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
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// An optional list of tags to associate with the specified <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_CostCategory.html">
        /// <c>CostCategory</c> </a>. You can use resource tags to control access to your <c>cost
        /// category</c> using IAM policies.
        /// </para>
        ///  
        /// <para>
        /// Each tag consists of a key and a value, and each key must be unique for the resource.
        /// The following restrictions apply to resource tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Although the maximum number of array members is 200, you can assign a maximum of 50
        /// user-tags to one resource. The remaining are reserved for Amazon Web Services use
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum length of a key is 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum length of a value is 256 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys and values can only contain alphanumeric characters, spaces, and any of the following:
        /// <c>_.:/=+@-</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys and values are case sensitive
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys and values are trimmed for any leading or trailing whitespaces
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Don’t use <c>aws:</c> as a prefix for your keys. This prefix is reserved for Amazon
        /// Web Services use
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ResourceTag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// The cost category rules used to categorize costs. For more information, see <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_CostCategoryRule.html">CostCategoryRule</a>.
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
        ///  The split charge rules used to allocate your charges between your cost category values.
        /// 
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
