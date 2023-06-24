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
    /// Adds or updates an Config rule for your entire organization to evaluate if your Amazon
    /// Web Services resources comply with your desired configurations. For information on
    /// how many organization Config rules you can have per account, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/configlimits.html">
    /// <b>Service Limits</b> </a> in the <i>Config Developer Guide</i>.
    /// 
    ///  
    /// <para>
    ///  Only a management account and a delegated administrator can create or update an organization
    /// Config rule. When calling this API with a delegated administrator, you must ensure
    /// Organizations <code>ListDelegatedAdministrator</code> permissions are added. An organization
    /// can have up to 3 delegated administrators.
    /// </para>
    ///  
    /// <para>
    /// This API enables organization service access through the <code>EnableAWSServiceAccess</code>
    /// action and creates a service-linked role <code>AWSServiceRoleForConfigMultiAccountSetup</code>
    /// in the management or delegated administrator account of your organization. The service-linked
    /// role is created only when the role does not exist in the caller account. Config verifies
    /// the existence of role with <code>GetRole</code> action.
    /// </para>
    ///  
    /// <para>
    /// To use this API with delegated administrator, register a delegated administrator by
    /// calling Amazon Web Services Organization <code>register-delegated-administrator</code>
    /// for <code>config-multiaccountsetup.amazonaws.com</code>. 
    /// </para>
    ///  
    /// <para>
    /// There are two types of rules: <i>Config Managed Rules</i> and <i>Config Custom Rules</i>.
    /// You can use <code>PutOrganizationConfigRule</code> to create both Config Managed Rules
    /// and Config Custom Rules.
    /// </para>
    ///  
    /// <para>
    /// Config Managed Rules are predefined, customizable rules created by Config. For a list
    /// of managed rules, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/managed-rules-by-aws-config.html">List
    /// of Config Managed Rules</a>. If you are adding an Config managed rule, you must specify
    /// the rule's identifier for the <code>RuleIdentifier</code> key.
    /// </para>
    ///  
    /// <para>
    /// Config Custom Rules are rules that you create from scratch. There are two ways to
    /// create Config custom rules: with Lambda functions (<a href="https://docs.aws.amazon.com/config/latest/developerguide/gettingstarted-concepts.html#gettingstarted-concepts-function">
    /// Lambda Developer Guide</a>) and with Guard (<a href="https://github.com/aws-cloudformation/cloudformation-guard">Guard
    /// GitHub Repository</a>), a policy-as-code language. Config custom rules created with
    /// Lambda are called <i>Config Custom Lambda Rules</i> and Config custom rules created
    /// with Guard are called <i>Config Custom Policy Rules</i>.
    /// </para>
    ///  
    /// <para>
    /// If you are adding a new Config Custom Lambda rule, you first need to create an Lambda
    /// function in the management account or a delegated administrator that the rule invokes
    /// to evaluate your resources. You also need to create an IAM role in the managed account
    /// that can be assumed by the Lambda function. When you use <code>PutOrganizationConfigRule</code>
    /// to add a Custom Lambda rule to Config, you must specify the Amazon Resource Name (ARN)
    /// that Lambda assigns to the function.
    /// </para>
    ///  <note> 
    /// <para>
    /// Prerequisite: Ensure you call <code>EnableAllFeatures</code> API to enable all features
    /// in an organization.
    /// </para>
    ///  
    /// <para>
    /// Make sure to specify one of either <code>OrganizationCustomPolicyRuleMetadata</code>
    /// for Custom Policy rules, <code>OrganizationCustomRuleMetadata</code> for Custom Lambda
    /// rules, or <code>OrganizationManagedRuleMetadata</code> for managed rules.
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
        /// An <code>OrganizationCustomPolicyRuleMetadata</code> object. This object specifies
        /// metadata for your organization's Config Custom Policy rule. The metadata includes
        /// the runtime system in use, which accounts have debug logging enabled, and other custom
        /// rule metadata, such as resource type, resource ID of Amazon Web Services resource,
        /// and organization trigger types that initiate Config to evaluate Amazon Web Services
        /// resources against a rule.
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
        /// An <code>OrganizationCustomRuleMetadata</code> object. This object specifies organization
        /// custom rule metadata such as resource type, resource ID of Amazon Web Services resource,
        /// Lambda function ARN, and organization trigger types that trigger Config to evaluate
        /// your Amazon Web Services resources against a rule. It also provides the frequency
        /// with which you want Config to run evaluations for the rule if the trigger type is
        /// periodic.
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
        /// An <code>OrganizationManagedRuleMetadata</code> object. This object specifies organization
        /// managed rule metadata such as resource type and ID of Amazon Web Services resource
        /// along with the rule identifier. It also provides the frequency with which you want
        /// Config to run evaluations for the rule if the trigger type is periodic.
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