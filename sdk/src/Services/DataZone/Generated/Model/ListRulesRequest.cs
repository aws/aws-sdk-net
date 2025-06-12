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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the ListRules operation.
    /// Lists existing rules. In Amazon DataZone, a rule is a formal agreement that enforces
    /// specific requirements across user workflows (e.g., publishing assets to the catalog,
    /// requesting subscriptions, creating projects) within the Amazon DataZone data portal.
    /// These rules help maintain consistency, ensure compliance, and uphold governance standards
    /// in data management processes. For instance, a metadata enforcement rule can specify
    /// the required information for creating a subscription request or publishing a data
    /// asset to the catalog, ensuring alignment with organizational standards.
    /// </summary>
    public partial class ListRulesRequest : AmazonDataZoneRequest
    {
        private RuleAction _action;
        private List<string> _assetTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _dataProduct;
        private string _domainIdentifier;
        private bool? _includeCascaded;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _projectIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RuleType _ruleType;
        private string _targetIdentifier;
        private RuleTargetType _targetType;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action of the rule.
        /// </para>
        /// </summary>
        public RuleAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property AssetTypes. 
        /// <para>
        /// The asset types of the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssetTypes
        {
            get { return this._assetTypes; }
            set { this._assetTypes = value; }
        }

        // Check to see if AssetTypes property is set
        internal bool IsSetAssetTypes()
        {
            return this._assetTypes != null && (this._assetTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataProduct. 
        /// <para>
        /// The data product of the rule.
        /// </para>
        /// </summary>
        public bool? DataProduct
        {
            get { return this._dataProduct; }
            set { this._dataProduct = value; }
        }

        // Check to see if DataProduct property is set
        internal bool IsSetDataProduct()
        {
            return this._dataProduct.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain in which the rules are to be listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeCascaded. 
        /// <para>
        /// Specifies whether to include cascading rules in the results.
        /// </para>
        /// </summary>
        public bool? IncludeCascaded
        {
            get { return this._includeCascaded; }
            set { this._includeCascaded = value; }
        }

        // Check to see if IncludeCascaded property is set
        internal bool IsSetIncludeCascaded()
        {
            return this._includeCascaded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of rules to return in a single call to <c>ListRules</c>. When the
        /// number of rules to be listed is greater than the value of <c>MaxResults</c>, the response
        /// contains a <c>NextToken</c> value that you can use in a subsequent call to <c>ListRules</c>
        /// to list the next set of rules.
        /// </para>
        /// </summary>
        [AWSProperty(Min=25, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// When the number of rules is greater than the default value for the <c>MaxResults</c>
        /// parameter, or if you explicitly specify a value for <c>MaxResults</c> that is less
        /// than the number of rules, the response includes a pagination token named <c>NextToken</c>.
        /// You can specify this <c>NextToken</c> value in a subsequent call to <c>ListRules</c>
        /// to list the next set of rules.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
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
        /// Gets and sets the property ProjectIds. 
        /// <para>
        /// The IDs of projects in which rules are to be listed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProjectIds
        {
            get { return this._projectIds; }
            set { this._projectIds = value; }
        }

        // Check to see if ProjectIds property is set
        internal bool IsSetProjectIds()
        {
            return this._projectIds != null && (this._projectIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        /// The type of the rule.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TargetIdentifier. 
        /// <para>
        /// The target ID of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetIdentifier
        {
            get { return this._targetIdentifier; }
            set { this._targetIdentifier = value; }
        }

        // Check to see if TargetIdentifier property is set
        internal bool IsSetTargetIdentifier()
        {
            return this._targetIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The target type of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleTargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

    }
}