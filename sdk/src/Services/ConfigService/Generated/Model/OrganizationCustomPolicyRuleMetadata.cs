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
    /// An object that specifies metadata for your organization's Config Custom Policy rule.
    /// The metadata includes the runtime system in use, which accounts have debug logging
    /// enabled, and other custom rule metadata, such as resource type, resource ID of Amazon
    /// Web Services resource, and organization trigger types that initiate Config to evaluate
    /// Amazon Web Services resources against a rule.
    /// </summary>
    public partial class OrganizationCustomPolicyRuleMetadata
    {
        private List<string> _debugLogDeliveryAccounts = new List<string>();
        private string _description;
        private string _inputParameters;
        private MaximumExecutionFrequency _maximumExecutionFrequency;
        private List<string> _organizationConfigRuleTriggerTypes = new List<string>();
        private string _policyRuntime;
        private string _policyText;
        private string _resourceIdScope;
        private List<string> _resourceTypesScope = new List<string>();
        private string _tagKeyScope;
        private string _tagValueScope;

        /// <summary>
        /// Gets and sets the property DebugLogDeliveryAccounts. 
        /// <para>
        /// A list of accounts that you can enable debug logging for your organization Config
        /// Custom Policy rule. List is null when debug logging is enabled for all accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> DebugLogDeliveryAccounts
        {
            get { return this._debugLogDeliveryAccounts; }
            set { this._debugLogDeliveryAccounts = value; }
        }

        // Check to see if DebugLogDeliveryAccounts property is set
        internal bool IsSetDebugLogDeliveryAccounts()
        {
            return this._debugLogDeliveryAccounts != null && this._debugLogDeliveryAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description that you provide for your organization Config Custom Policy rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InputParameters. 
        /// <para>
        /// A string, in JSON format, that is passed to your organization Config Custom Policy
        /// rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string InputParameters
        {
            get { return this._inputParameters; }
            set { this._inputParameters = value; }
        }

        // Check to see if InputParameters property is set
        internal bool IsSetInputParameters()
        {
            return this._inputParameters != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumExecutionFrequency. 
        /// <para>
        /// The maximum frequency with which Config runs evaluations for a rule. Your Config Custom
        /// Policy rule is triggered when Config delivers the configuration snapshot. For more
        /// information, see <a>ConfigSnapshotDeliveryProperties</a>.
        /// </para>
        /// </summary>
        public MaximumExecutionFrequency MaximumExecutionFrequency
        {
            get { return this._maximumExecutionFrequency; }
            set { this._maximumExecutionFrequency = value; }
        }

        // Check to see if MaximumExecutionFrequency property is set
        internal bool IsSetMaximumExecutionFrequency()
        {
            return this._maximumExecutionFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationConfigRuleTriggerTypes. 
        /// <para>
        /// The type of notification that initiates Config to run an evaluation for a rule. For
        /// Config Custom Policy rules, Config supports change-initiated notification types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ConfigurationItemChangeNotification</code> - Initiates an evaluation when Config
        /// delivers a configuration item as a result of a resource change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OversizedConfigurationItemChangeNotification</code> - Initiates an evaluation
        /// when Config delivers an oversized configuration item. Config may generate this notification
        /// type when a resource changes and the notification exceeds the maximum size allowed
        /// by Amazon SNS.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> OrganizationConfigRuleTriggerTypes
        {
            get { return this._organizationConfigRuleTriggerTypes; }
            set { this._organizationConfigRuleTriggerTypes = value; }
        }

        // Check to see if OrganizationConfigRuleTriggerTypes property is set
        internal bool IsSetOrganizationConfigRuleTriggerTypes()
        {
            return this._organizationConfigRuleTriggerTypes != null && this._organizationConfigRuleTriggerTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PolicyRuntime. 
        /// <para>
        /// The runtime system for your organization Config Custom Policy rules. Guard is a policy-as-code
        /// language that allows you to write policies that are enforced by Config Custom Policy
        /// rules. For more information about Guard, see the <a href="https://github.com/aws-cloudformation/cloudformation-guard">Guard
        /// GitHub Repository</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string PolicyRuntime
        {
            get { return this._policyRuntime; }
            set { this._policyRuntime = value; }
        }

        // Check to see if PolicyRuntime property is set
        internal bool IsSetPolicyRuntime()
        {
            return this._policyRuntime != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyText. 
        /// <para>
        /// The policy definition containing the logic for your organization Config Custom Policy
        /// rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
        public string PolicyText
        {
            get { return this._policyText; }
            set { this._policyText = value; }
        }

        // Check to see if PolicyText property is set
        internal bool IsSetPolicyText()
        {
            return this._policyText != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdScope. 
        /// <para>
        /// The ID of the Amazon Web Services resource that was evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=768)]
        public string ResourceIdScope
        {
            get { return this._resourceIdScope; }
            set { this._resourceIdScope = value; }
        }

        // Check to see if ResourceIdScope property is set
        internal bool IsSetResourceIdScope()
        {
            return this._resourceIdScope != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTypesScope. 
        /// <para>
        /// The type of the Amazon Web Services resource that was evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ResourceTypesScope
        {
            get { return this._resourceTypesScope; }
            set { this._resourceTypesScope = value; }
        }

        // Check to see if ResourceTypesScope property is set
        internal bool IsSetResourceTypesScope()
        {
            return this._resourceTypesScope != null && this._resourceTypesScope.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagKeyScope. 
        /// <para>
        /// One part of a key-value pair that make up a tag. A key is a general label that acts
        /// like a category for more specific tag values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TagKeyScope
        {
            get { return this._tagKeyScope; }
            set { this._tagKeyScope = value; }
        }

        // Check to see if TagKeyScope property is set
        internal bool IsSetTagKeyScope()
        {
            return this._tagKeyScope != null;
        }

        /// <summary>
        /// Gets and sets the property TagValueScope. 
        /// <para>
        /// The optional part of a key-value pair that make up a tag. A value acts as a descriptor
        /// within a tag category (key).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TagValueScope
        {
            get { return this._tagValueScope; }
            set { this._tagValueScope = value; }
        }

        // Check to see if TagValueScope property is set
        internal bool IsSetTagValueScope()
        {
            return this._tagValueScope != null;
        }

    }
}