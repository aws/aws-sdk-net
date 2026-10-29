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
    /// An organization Config rule that has information about Config rules that Config creates
    /// in member accounts.
    /// </summary>
    public partial class OrganizationConfigRule
    {
        /// <summary>
        /// Gets and sets the property ExcludedAccounts. 
        /// <para>
        /// A comma-separated list of accounts excluded from organization Config rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<string> ExcludedAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludedAccounts property is set.
        /// </summary>
        internal bool IsSetExcludedAccounts() => this.ExcludedAccounts != null && (this.ExcludedAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The timestamp of the last update.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property OrganizationConfigRuleArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of organization Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OrganizationConfigRuleArn { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationConfigRuleArn property is set.
        /// </summary>
        internal bool IsSetOrganizationConfigRuleArn() => this.OrganizationConfigRuleArn != null;

        /// <summary>
        /// Gets and sets the property OrganizationConfigRuleName. 
        /// <para>
        /// The name that you assign to organization Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string OrganizationConfigRuleName { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationConfigRuleName property is set.
        /// </summary>
        internal bool IsSetOrganizationConfigRuleName() => this.OrganizationConfigRuleName != null;

        /// <summary>
        /// Gets and sets the property OrganizationCustomPolicyRuleMetadata. 
        /// <para>
        /// An object that specifies metadata for your organization's Config Custom Policy rule.
        /// The metadata includes the runtime system in use, which accounts have debug logging
        /// enabled, and other custom rule metadata, such as resource type, resource ID of Amazon
        /// Web Services resource, and organization trigger types that initiate Config to evaluate
        /// Amazon Web Services resources against a rule.
        /// </para>
        /// </summary>
        public OrganizationCustomPolicyRuleMetadataNoPolicy OrganizationCustomPolicyRuleMetadata { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationCustomPolicyRuleMetadata property is set.
        /// </summary>
        internal bool IsSetOrganizationCustomPolicyRuleMetadata() => this.OrganizationCustomPolicyRuleMetadata != null;

        /// <summary>
        /// Gets and sets the property OrganizationCustomRuleMetadata. 
        /// <para>
        /// An <c>OrganizationCustomRuleMetadata</c> object.
        /// </para>
        /// </summary>
        public OrganizationCustomRuleMetadata OrganizationCustomRuleMetadata { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationCustomRuleMetadata property is set.
        /// </summary>
        internal bool IsSetOrganizationCustomRuleMetadata() => this.OrganizationCustomRuleMetadata != null;

        /// <summary>
        /// Gets and sets the property OrganizationManagedRuleMetadata. 
        /// <para>
        /// An <c>OrganizationManagedRuleMetadata</c> object.
        /// </para>
        /// </summary>
        public OrganizationManagedRuleMetadata OrganizationManagedRuleMetadata { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationManagedRuleMetadata property is set.
        /// </summary>
        internal bool IsSetOrganizationManagedRuleMetadata() => this.OrganizationManagedRuleMetadata != null;
    }
}
