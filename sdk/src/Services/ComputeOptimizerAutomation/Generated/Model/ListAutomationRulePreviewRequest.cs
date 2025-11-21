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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
    /// Container for the parameters to the ListAutomationRulePreview operation.
    /// Returns a preview of the recommended actions that match your Automation rule's configuration
    /// and criteria.
    /// </summary>
    public partial class ListAutomationRulePreviewRequest : AmazonComputeOptimizerAutomationRequest
    {
        private Criteria _criteria;
        private int? _maxResults;
        private string _nextToken;
        private OrganizationScope _organizationScope;
        private List<string> _recommendedActionTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RuleType _ruleType;

        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// A set of conditions that specify which recommended action qualify for implementation.
        /// When a rule is active and a recommended action matches these criteria, Compute Optimizer
        /// implements the action at the scheduled run time. 
        /// </para>
        /// </summary>
        public Criteria Criteria
        {
            get { return this._criteria; }
            set { this._criteria = value; }
        }

        // Check to see if Criteria property is set
        internal bool IsSetCriteria()
        {
            return this._criteria != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of automation rule preview results to return in a single response.
        /// Valid range is 1-1000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token used for pagination to retrieve the next set of results when the response
        /// is truncated.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationScope. 
        /// <para>
        ///  The organizational scope for the rule preview. 
        /// </para>
        /// </summary>
        public OrganizationScope OrganizationScope
        {
            get { return this._organizationScope; }
            set { this._organizationScope = value; }
        }

        // Check to see if OrganizationScope property is set
        internal bool IsSetOrganizationScope()
        {
            return this._organizationScope != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedActionTypes. 
        /// <para>
        ///  The types of recommended actions to include in the preview. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RecommendedActionTypes
        {
            get { return this._recommendedActionTypes; }
            set { this._recommendedActionTypes = value; }
        }

        // Check to see if RecommendedActionTypes property is set
        internal bool IsSetRecommendedActionTypes()
        {
            return this._recommendedActionTypes != null && (this._recommendedActionTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Required=true)]
        public RuleType RuleType
        {
            get { return this._ruleType; }
            set { this._ruleType = value; }
        }

        // Check to see if RuleType property is set
        internal bool IsSetRuleType()
        {
            return this._ruleType != null;
        }

    }
}