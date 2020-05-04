/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Adds or updates organization config rule for your entire organization evaluating whether
    /// your AWS resources comply with your desired configurations. Only a master account
    /// can create or update an organization config rule.
    /// 
    ///  
    /// <para>
    /// This API enables organization service access through the <code>EnableAWSServiceAccess</code>
    /// action and creates a service linked role <code>AWSServiceRoleForConfigMultiAccountSetup</code>
    /// in the master account of your organization. The service linked role is created only
    /// when the role does not exist in the master account. AWS Config verifies the existence
    /// of role with <code>GetRole</code> action.
    /// </para>
    ///  
    /// <para>
    /// You can use this action to create both custom AWS Config rules and AWS managed Config
    /// rules. If you are adding a new custom AWS Config rule, you must first create AWS Lambda
    /// function in the master account that the rule invokes to evaluate your resources. When
    /// you use the <code>PutOrganizationConfigRule</code> action to add the rule to AWS Config,
    /// you must specify the Amazon Resource Name (ARN) that AWS Lambda assigns to the function.
    /// If you are adding an AWS managed Config rule, specify the rule's identifier for the
    /// <code>RuleIdentifier</code> key.
    /// </para>
    ///  
    /// <para>
    /// The maximum number of organization config rules that AWS Config supports is 150.
    /// </para>
    ///  <note> 
    /// <para>
    /// Specify either <code>OrganizationCustomRuleMetadata</code> or <code>OrganizationManagedRuleMetadata</code>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutOrganizationConfigRuleRequest : AmazonConfigServiceRequest
    {
        private List<string> _excludedAccounts = new List<string>();
        private string _organizationConfigRuleName;
        private OrganizationCustomRuleMetadata _organizationCustomRuleMetadata;
        private OrganizationManagedRuleMetadata _organizationManagedRuleMetadata;

        /// <summary>
        /// Gets and sets the property ExcludedAccounts. 
        /// <para>
        /// A comma-separated list of accounts that you want to exclude from an organization config
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
        /// The name that you assign to an organization config rule.
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