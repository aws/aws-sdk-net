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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeOrganizationConfigRules operation. Returns
    /// a list of organization Config rules. <note> <para> When you specify the limit and
    /// the next token, you receive a paginated response. </para> <para> Limit and next token
    /// are not applicable if you specify organization Config rule names. It is only applicable,
    /// when you request all the organization Config rules. </para> <para> <i>For accounts
    /// within an organization</i> </para> <para> If you deploy an organizational rule or
    /// conformance pack in an organization administrator account, and then establish a delegated
    /// administrator and deploy an organizational rule or conformance pack in the delegated
    /// administrator account, you won't be able to see the organizational rule or conformance
    /// pack in the organization administrator account from the delegated administrator account
    /// or see the organizational rule or conformance pack in the delegated administrator
    /// account from organization administrator account. The <c>DescribeOrganizationConfigRules</c>
    /// and <c>DescribeOrganizationConformancePacks</c> APIs can only see and interact with
    /// the organization-related resource that were deployed from within the account calling
    /// those APIs. </para> </note>
    /// </summary>
    public partial class DescribeOrganizationConfigRulesRequest : AmazonConfigServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of organization Config rules returned on each page. If you do no
        /// specify a number, Config uses the default. The default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string returned on a previous page that you use to get the next
        /// page of results in a paginated response. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OrganizationConfigRuleNames. 
        /// <para>
        /// The names of organization Config rules for which you want details. If you do not specify
        /// any names, Config returns details for all your organization Config rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public List<string> OrganizationConfigRuleNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OrganizationConfigRuleNames property is set.
        /// </summary>
        internal bool IsSetOrganizationConfigRuleNames() => this.OrganizationConfigRuleNames != null && (this.OrganizationConfigRuleNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
