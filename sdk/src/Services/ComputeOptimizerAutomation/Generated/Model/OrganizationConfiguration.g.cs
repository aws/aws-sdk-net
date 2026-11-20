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
    /// Configuration settings that define the scope of an organization-wide automation rule.
    /// Each organizational unit (OU) list can contain up to 150 OUs or organization roots,
    /// and each account list can contain up to 50 accounts. Each included OU or organization
    /// root must have an effective organization rule mode of <c>AnyAllowed</c>. Exclusions
    /// take precedence over inclusions. An account that is in an included OU and is also
    /// excluded is excluded. The rule doesn't apply to the management account when the account
    /// is reached through an OU or the organization root.
    /// </summary>
    public partial class OrganizationConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The specific Amazon Web Services account IDs where the organization rule should be
        /// applied. You can specify up to 50 account IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> AccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIds property is set.
        /// </summary>
        internal bool IsSetAccountIds() => this.AccountIds != null && (this.AccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExcludedAccountIds. 
        /// <para>
        /// The Amazon Web Services account IDs to exclude from the organization rule scope. You
        /// can specify up to 50 account IDs. An excluded account remains excluded even if it
        /// is in an included OU.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> ExcludedAccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludedAccountIds property is set.
        /// </summary>
        internal bool IsSetExcludedAccountIds() => this.ExcludedAccountIds != null && (this.ExcludedAccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExcludedOrganizationalUnitIds. 
        /// <para>
        /// The organizational unit (OU) or organization root IDs to exclude from the organization
        /// rule scope. The rule doesn't apply to accounts in the specified OUs or their child
        /// OUs. You can specify up to 150 IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 150)]
        public List<string> ExcludedOrganizationalUnitIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludedOrganizationalUnitIds property is set.
        /// </summary>
        internal bool IsSetExcludedOrganizationalUnitIds() => this.ExcludedOrganizationalUnitIds != null && (this.ExcludedOrganizationalUnitIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrganizationalUnitIds. 
        /// <para>
        /// The organizational unit (OU) or organization root IDs to include in the organization
        /// rule scope. The rule applies to accounts in the specified OUs and their child OUs.
        /// You can specify up to 150 IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 150)]
        public List<string> OrganizationalUnitIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OrganizationalUnitIds property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitIds() => this.OrganizationalUnitIds != null && (this.OrganizationalUnitIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleApplyOrder. 
        /// <para>
        /// Specifies when organization rules should be applied relative to account rules.
        /// </para>
        /// </summary>
        public RuleApplyOrder RuleApplyOrder { get; set; }

        /// <summary>
        /// Checks to see if the RuleApplyOrder property is set.
        /// </summary>
        internal bool IsSetRuleApplyOrder() => this.RuleApplyOrder != null;
    }
}
