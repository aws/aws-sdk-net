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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the ListTelemetryRulesForOrganization operation.
    /// Lists all telemetry rules in your organization. This operation can only be called
    /// by the organization's management account or a delegated administrator account.
    /// </summary>
    public partial class ListTelemetryRulesForOrganizationRequest : AmazonObservabilityAdminRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _ruleNamePrefix;
        private List<string> _sourceAccountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sourceOrganizationUnitIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of organization telemetry rules to return in a single call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        ///  The token for the next set of results. A previous call generates this token. 
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
        /// Gets and sets the property RuleNamePrefix. 
        /// <para>
        ///  A string to filter organization telemetry rules whose names begin with the specified
        /// prefix. 
        /// </para>
        /// </summary>
        public string RuleNamePrefix
        {
            get { return this._ruleNamePrefix; }
            set { this._ruleNamePrefix = value; }
        }

        // Check to see if RuleNamePrefix property is set
        internal bool IsSetRuleNamePrefix()
        {
            return this._ruleNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAccountIds. 
        /// <para>
        ///  The list of account IDs to filter organization telemetry rules by their source accounts.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> SourceAccountIds
        {
            get { return this._sourceAccountIds; }
            set { this._sourceAccountIds = value; }
        }

        // Check to see if SourceAccountIds property is set
        internal bool IsSetSourceAccountIds()
        {
            return this._sourceAccountIds != null && (this._sourceAccountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceOrganizationUnitIds. 
        /// <para>
        ///  The list of organizational unit IDs to filter organization telemetry rules by their
        /// source organizational units. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> SourceOrganizationUnitIds
        {
            get { return this._sourceOrganizationUnitIds; }
            set { this._sourceOrganizationUnitIds = value; }
        }

        // Check to see if SourceOrganizationUnitIds property is set
        internal bool IsSetSourceOrganizationUnitIds()
        {
            return this._sourceOrganizationUnitIds != null && (this._sourceOrganizationUnitIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}