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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
        private List<string> _excludedAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastUpdateTime;
        private string _organizationConfigRuleArn;
        private string _organizationConfigRuleName;
        private OrganizationCustomPolicyRuleMetadataNoPolicy _organizationCustomPolicyRuleMetadata;
        private OrganizationCustomRuleMetadata _organizationCustomRuleMetadata;
        private OrganizationManagedRuleMetadata _organizationManagedRuleMetadata;

        /// <summary>
        /// Gets and sets the property ExcludedAccounts. 
        /// <para>
        /// A comma-separated list of accounts excluded from organization Config rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> ExcludedAccounts
        {
            get { return this._excludedAccounts; }
            set { this._excludedAccounts = value; }
        }

        // Check to see if ExcludedAccounts property is set
        internal bool IsSetExcludedAccounts()
        {
            return this._excludedAccounts != null && (this._excludedAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The timestamp of the last update.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationConfigRuleArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of organization Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string OrganizationConfigRuleArn
        {
            get { return this._organizationConfigRuleArn; }
            set { this._organizationConfigRuleArn = value; }
        }

        // Check to see if OrganizationConfigRuleArn property is set
        internal bool IsSetOrganizationConfigRuleArn()
        {
            return this._organizationConfigRuleArn != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationConfigRuleName. 
        /// <para>
        /// The name that you assign to organization Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string OrganizationConfigRuleName
        {
            get { return this._organizationConfigRuleName; }
            set { this._organizationConfigRuleName = value; }
        }

        // Check to see if OrganizationConfigRuleName property is set
        internal bool IsSetOrganizationConfigRuleName()
        {
            return this._organizationConfigRuleName != null;
        }

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
        public OrganizationCustomPolicyRuleMetadataNoPolicy OrganizationCustomPolicyRuleMetadata
        {
            get { return this._organizationCustomPolicyRuleMetadata; }
            set { this._organizationCustomPolicyRuleMetadata = value; }
        }

        // Check to see if OrganizationCustomPolicyRuleMetadata property is set
        internal bool IsSetOrganizationCustomPolicyRuleMetadata()
        {
            return this._organizationCustomPolicyRuleMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationCustomRuleMetadata. 
        /// <para>
        /// An <c>OrganizationCustomRuleMetadata</c> object.
        /// </para>
        /// </summary>
        public OrganizationCustomRuleMetadata OrganizationCustomRuleMetadata
        {
            get { return this._organizationCustomRuleMetadata; }
            set { this._organizationCustomRuleMetadata = value; }
        }

        // Check to see if OrganizationCustomRuleMetadata property is set
        internal bool IsSetOrganizationCustomRuleMetadata()
        {
            return this._organizationCustomRuleMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationManagedRuleMetadata. 
        /// <para>
        /// An <c>OrganizationManagedRuleMetadata</c> object.
        /// </para>
        /// </summary>
        public OrganizationManagedRuleMetadata OrganizationManagedRuleMetadata
        {
            get { return this._organizationManagedRuleMetadata; }
            set { this._organizationManagedRuleMetadata = value; }
        }

        // Check to see if OrganizationManagedRuleMetadata property is set
        internal bool IsSetOrganizationManagedRuleMetadata()
        {
            return this._organizationManagedRuleMetadata != null;
        }

    }
}