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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutOrganizationConfigRule operation.
    /// Adds or updates organization Config rule for your entire organization evaluating whether
    /// your Amazon Web Services resources comply with your desired configurations.
    /// 
    ///  
    /// <para>
    ///  Only a master account and a delegated administrator can create or update an organization
    /// Config rule. When calling this API with a delegated administrator, you must ensure
    /// Organizations <code>ListDelegatedAdministrator</code> permissions are added. 
    /// </para>
    ///  
    /// <para>
    /// This API enables organization service access through the <code>EnableAWSServiceAccess</code>
    /// action and creates a service linked role <code>AWSServiceRoleForConfigMultiAccountSetup</code>
    /// in the master or delegated administrator account of your organization. The service
    /// linked role is created only when the role does not exist in the caller account. Config
    /// verifies the existence of role with <code>GetRole</code> action.
    /// </para>
    ///  
    /// <para>
    /// To use this API with delegated administrator, register a delegated administrator by
    /// calling Amazon Web Services Organization <code>register-delegated-administrator</code>
    /// for <code>config-multiaccountsetup.amazonaws.com</code>. 
    /// </para>
    ///  
    /// <para>
    /// You can use this action to create both Config custom rules and Config managed rules.
    /// If you are adding a new Config custom rule, you must first create Lambda function
    /// in the master account or a delegated administrator that the rule invokes to evaluate
    /// your resources. You also need to create an IAM role in the managed-account that can
    /// be assumed by the Lambda function. When you use the <code>PutOrganizationConfigRule</code>
    /// action to add the rule to Config, you must specify the Amazon Resource Name (ARN)
    /// that Lambda assigns to the function. If you are adding an Config managed rule, specify
    /// the rule's identifier for the <code>RuleIdentifier</code> key.
    /// </para>
    ///  
    /// <para>
    /// The maximum number of organization Config rules that Config supports is 150 and 3
    /// delegated administrator per organization. 
    /// </para>
    ///  <note> 
    /// <para>
    /// Prerequisite: Ensure you call <code>EnableAllFeatures</code> API to enable all features
    /// in an organization.
    /// </para>
    ///  
    /// <para>
    /// Specify either <code>OrganizationCustomRuleMetadata</code> or <code>OrganizationManagedRuleMetadata</code>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutOrganizationConfigRuleRequest : AmazonConfigServiceRequest
    {
        private List<string> _excludedAccounts = new List<string>();
        private string _organizationConfigRuleName;
        private OrganizationCustomPolicyRuleMetadata _organizationCustomPolicyRuleMetadata;
        private OrganizationCustomRuleMetadata _organizationCustomRuleMetadata;
        private OrganizationManagedRuleMetadata _organizationManagedRuleMetadata;

        /// <summary>
        /// Gets and sets the property ExcludedAccounts. 
        /// <para>
        /// A comma-separated list of accounts that you want to exclude from an organization Config
        /// rule.
        /// </para>
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
            return this._excludedAccounts != null && this._excludedAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationConfigRuleName. 
        /// <para>
        /// The name that you assign to an organization Config rule.
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
        public OrganizationCustomPolicyRuleMetadata OrganizationCustomPolicyRuleMetadata
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
        /// An <code>OrganizationCustomRuleMetadata</code> object.
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
        /// An <code>OrganizationManagedRuleMetadata</code> object. 
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