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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Container for the parameters to the GenerateRuleConfiguration operation.
    /// Generates a rule configuration from a natural-language description. Provide a prompt
    /// along with the rule's firewall type and rule type. The service returns a configuration
    /// that you can use when you create or update a rule. If you also provide an existing
    /// configuration, the service edits that configuration instead of generating a new one.
    /// </summary>
    public partial class GenerateRuleConfigurationRequest : AmazonNetworkSecurityManagerRequest
    {
        private string _clientToken;
        private string _currentConfiguration;
        private string _prompt;
        private RuleFirewallType _ruleFirewallType;
        private RuleType _ruleType;
        private WAFConfigDataType _wafConfigDataType;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure that the operation completes
        /// no more than one time. If you retry a request with the same client token and the same
        /// parameters, the service returns the result of the original successful request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentConfiguration. 
        /// <para>
        /// An existing configuration to edit, as a JSON string. When you provide this value,
        /// the operation edits the configuration. When you omit it, the operation generates a
        /// new configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32768)]
        public string CurrentConfiguration
        {
            get { return this._currentConfiguration; }
            set { this._currentConfiguration = value; }
        }

        // Check to see if CurrentConfiguration property is set
        internal bool IsSetCurrentConfiguration()
        {
            return this._currentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Prompt. 
        /// <para>
        /// A natural-language description of the configuration that you want to generate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2000)]
        public string Prompt
        {
            get { return this._prompt; }
            set { this._prompt = value; }
        }

        // Check to see if Prompt property is set
        internal bool IsSetPrompt()
        {
            return this._prompt != null;
        }

        /// <summary>
        /// Gets and sets the property RuleFirewallType. 
        /// <para>
        /// The firewall type of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleFirewallType RuleFirewallType
        {
            get { return this._ruleFirewallType; }
            set { this._ruleFirewallType = value; }
        }

        // Check to see if RuleFirewallType property is set
        internal bool IsSetRuleFirewallType()
        {
            return this._ruleFirewallType != null;
        }

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        /// The type of the rule. <c>CONFIGURATION</c> rules contain firewall settings, and <c>INSPECTION</c>
        /// rules contain rule groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property WafConfigDataType. 
        /// <para>
        /// For AWS WAF configuration rules, the specific AWS WAF configuration variant to generate.
        /// This is optional; if you omit it, the service selects the variant.
        /// </para>
        /// </summary>
        public WAFConfigDataType WafConfigDataType
        {
            get { return this._wafConfigDataType; }
            set { this._wafConfigDataType = value; }
        }

        // Check to see if WafConfigDataType property is set
        internal bool IsSetWafConfigDataType()
        {
            return this._wafConfigDataType != null;
        }

    }
}