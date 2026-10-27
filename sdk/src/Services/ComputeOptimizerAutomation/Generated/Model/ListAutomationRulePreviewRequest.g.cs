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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Container for the parameters to the ListAutomationRulePreview operation. Returns a
    /// preview of the recommended actions that match your Automation rule's configuration
    /// and criteria.
    /// </summary>
    public partial class ListAutomationRulePreviewRequest : AmazonComputeOptimizerAutomationRequest
    {
        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// A set of conditions that specify which recommended action qualify for implementation.
        /// When a rule is active and a recommended action matches these criteria, Compute Optimizer
        /// implements the action at the scheduled run time. 
        /// </para>
        /// </summary>
        public Criteria Criteria { get; set; }

        /// <summary>
        /// Checks to see if the Criteria property is set.
        /// </summary>
        internal bool IsSetCriteria() => this.Criteria != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of automation rule preview results to return in a single response.
        /// Valid range is 1-1000.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token used for pagination to retrieve the next set of results when the response
        /// is truncated.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OrganizationScope. 
        /// <para>
        ///  The organizational scope for the rule preview. 
        /// </para>
        /// </summary>
        public OrganizationScope OrganizationScope { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationScope property is set.
        /// </summary>
        internal bool IsSetOrganizationScope() => this.OrganizationScope != null;

        /// <summary>
        /// Gets and sets the property RecommendedActionTypes. 
        /// <para>
        ///  The types of recommended actions to include in the preview. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> RecommendedActionTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RecommendedActionTypes property is set.
        /// </summary>
        internal bool IsSetRecommendedActionTypes() => this.RecommendedActionTypes != null && (this.RecommendedActionTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        ///  The type of rule. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Only the management account or a delegated administrator can set the ruleType to be
        /// OrganizationRule.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuleType RuleType { get; set; }

        /// <summary>
        /// Checks to see if the RuleType property is set.
        /// </summary>
        internal bool IsSetRuleType() => this.RuleType != null;
    }
}
