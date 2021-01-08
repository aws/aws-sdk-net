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
    /// An object that specifies organization managed rule metadata such as resource type
    /// and ID of AWS resource along with the rule identifier. It also provides the frequency
    /// with which you want AWS Config to run evaluations for the rule if the trigger type
    /// is periodic.
    /// </summary>
    public partial class OrganizationManagedRuleMetadata
    {
        private string _description;
        private string _inputParameters;
        private MaximumExecutionFrequency _maximumExecutionFrequency;
        private string _resourceIdScope;
        private List<string> _resourceTypesScope = new List<string>();
        private string _ruleIdentifier;
        private string _tagKeyScope;
        private string _tagValueScope;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description that you provide for organization config rule.
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
        /// A string, in JSON format, that is passed to organization config rule Lambda function.
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
        /// The maximum frequency with which AWS Config runs evaluations for a rule. You are using
        /// an AWS managed rule that is triggered at a periodic frequency.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, rules with a periodic trigger are evaluated every 24 hours. To change
        /// the frequency, specify a valid value for the <code>MaximumExecutionFrequency</code>
        /// parameter.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ResourceIdScope. 
        /// <para>
        /// The ID of the AWS resource that was evaluated.
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
        /// The type of the AWS resource that was evaluated.
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
        /// Gets and sets the property RuleIdentifier. 
        /// <para>
        /// For organization config managed rules, a predefined identifier from a list. For example,
        /// <code>IAM_PASSWORD_POLICY</code> is a managed rule. To reference a managed rule, see
        /// <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_use-managed-rules.html">Using
        /// AWS Managed Config Rules</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string RuleIdentifier
        {
            get { return this._ruleIdentifier; }
            set { this._ruleIdentifier = value; }
        }

        // Check to see if RuleIdentifier property is set
        internal bool IsSetRuleIdentifier()
        {
            return this._ruleIdentifier != null;
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