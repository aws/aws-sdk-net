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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the ListRules operation. Lists existing rules. In
    /// Amazon DataZone, a rule is a formal agreement that enforces specific requirements
    /// across user workflows (e.g., publishing assets to the catalog, requesting subscriptions,
    /// creating projects) within the Amazon DataZone data portal. These rules help maintain
    /// consistency, ensure compliance, and uphold governance standards in data management
    /// processes. For instance, a metadata enforcement rule can specify the required information
    /// for creating a subscription request or publishing a data asset to the catalog, ensuring
    /// alignment with organizational standards.
    /// </summary>
    public partial class ListRulesRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action of the rule.
        /// </para>
        /// </summary>
        public RuleAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property AssetTypes. 
        /// <para>
        /// The asset types of the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssetTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssetTypes property is set.
        /// </summary>
        internal bool IsSetAssetTypes() => this.AssetTypes != null && (this.AssetTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataProduct. 
        /// <para>
        /// The data product of the rule.
        /// </para>
        /// </summary>
        public bool? DataProduct { get; set; }

        /// <summary>
        /// Checks to see if the DataProduct property is set.
        /// </summary>
        internal bool IsSetDataProduct() => this.DataProduct.HasValue;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain in which the rules are to be listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property IncludeCascaded. 
        /// <para>
        /// Specifies whether to include cascading rules in the results.
        /// </para>
        /// </summary>
        public bool? IncludeCascaded { get; set; }

        /// <summary>
        /// Checks to see if the IncludeCascaded property is set.
        /// </summary>
        internal bool IsSetIncludeCascaded() => this.IncludeCascaded.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of rules to return in a single call to <c>ListRules</c>. When the
        /// number of rules to be listed is greater than the value of <c>MaxResults</c>, the response
        /// contains a <c>NextToken</c> value that you can use in a subsequent call to <c>ListRules</c>
        /// to list the next set of rules.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 25, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of rules is greater than the default value for the <c>MaxResults</c>
        /// parameter, or if you explicitly specify a value for <c>MaxResults</c> that is less
        /// than the number of rules, the response includes a pagination token named <c>NextToken</c>.
        /// You can specify this <c>NextToken</c> value in a subsequent call to <c>ListRules</c>
        /// to list the next set of rules.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ProjectIds. 
        /// <para>
        /// The IDs of projects in which rules are to be listed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProjectIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ProjectIds property is set.
        /// </summary>
        internal bool IsSetProjectIds() => this.ProjectIds != null && (this.ProjectIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        /// The type of the rule.
        /// </para>
        /// </summary>
        public RuleType RuleType { get; set; }

        /// <summary>
        /// Checks to see if the RuleType property is set.
        /// </summary>
        internal bool IsSetRuleType() => this.RuleType != null;

        /// <summary>
        /// Gets and sets the property TargetIdentifier. 
        /// <para>
        /// The target ID of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TargetIdentifier property is set.
        /// </summary>
        internal bool IsSetTargetIdentifier() => this.TargetIdentifier != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The target type of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuleTargetType TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;
    }
}
