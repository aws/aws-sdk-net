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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the ListTelemetryRulesForOrganization operation. Lists
    /// all telemetry rules in your organization. This operation can only be called by the
    /// organization's management account or a delegated administrator account.
    /// </summary>
    public partial class ListTelemetryRulesForOrganizationRequest : AmazonObservabilityAdminRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of organization telemetry rules to return in a single call. 
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
        ///  The token for the next set of results. A previous call generates this token. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RuleNamePrefix. 
        /// <para>
        ///  A string to filter organization telemetry rules whose names begin with the specified
        /// prefix. 
        /// </para>
        /// </summary>
        public string RuleNamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the RuleNamePrefix property is set.
        /// </summary>
        internal bool IsSetRuleNamePrefix() => this.RuleNamePrefix != null;

        /// <summary>
        /// Gets and sets the property SourceAccountIds. 
        /// <para>
        ///  The list of account IDs to filter organization telemetry rules by their source accounts.
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
        public List<string> SourceAccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceAccountIds property is set.
        /// </summary>
        internal bool IsSetSourceAccountIds() => this.SourceAccountIds != null && (this.SourceAccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceOrganizationUnitIds. 
        /// <para>
        ///  The list of organizational unit IDs to filter organization telemetry rules by their
        /// source organizational units. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> SourceOrganizationUnitIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceOrganizationUnitIds property is set.
        /// </summary>
        internal bool IsSetSourceOrganizationUnitIds() => this.SourceOrganizationUnitIds != null && (this.SourceOrganizationUnitIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
