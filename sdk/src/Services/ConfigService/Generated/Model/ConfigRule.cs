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
    /// Config rules evaluate the configuration settings of your Amazon Web Services resources.
    /// A rule can run when Config detects a configuration change to an Amazon Web Services
    /// resource or at a periodic frequency that you choose (for example, every 24 hours).
    /// There are two types of rules: Config Managed Rules and Config Custom Rules. Managed
    /// rules are predefined, customizable rules created by Config. For a list of managed
    /// rules, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/managed-rules-by-aws-config.html">List
    /// of Config Managed Rules</a>.
    /// 
    ///  
    /// <para>
    /// Custom rules are rules that you can create using either Guard or Lambda functions.
    /// Guard (<a href="https://github.com/aws-cloudformation/cloudformation-guard">Guard
    /// GitHub Repository</a>) is a policy-as-code language that allows you to write policies
    /// that are enforced by Config Custom Policy rules. Lambda uses custom code that you
    /// upload to evaluate a custom rule. It is invoked by events that are published to it
    /// by an event source, which Config invokes when the custom rule is initiated.
    /// </para>
    ///  
    /// <para>
    /// For more information about developing and using Config rules, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config.html">Evaluating
    /// Amazon Web Services resource Configurations with Config</a> in the <i>Config Developer
    /// Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can use the Amazon Web Services CLI and Amazon Web Services SDKs if you want to
    /// create a rule that triggers evaluations for your resources when Config delivers the
    /// configuration snapshot. For more information, see <a>ConfigSnapshotDeliveryProperties</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ConfigRule
    {
        private string _configRuleArn;
        private string _configRuleId;
        private string _configRuleName;
        private ConfigRuleState _configRuleState;
        private string _createdBy;
        private string _description;
        private List<EvaluationModeConfiguration> _evaluationModes = new List<EvaluationModeConfiguration>();
        private string _inputParameters;
        private MaximumExecutionFrequency _maximumExecutionFrequency;
        private Scope _scope;
        private Source _source;

        /// <summary>
        /// Gets and sets the property ConfigRuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ConfigRuleArn
        {
            get { return this._configRuleArn; }
            set { this._configRuleArn = value; }
        }

        // Check to see if ConfigRuleArn property is set
        internal bool IsSetConfigRuleArn()
        {
            return this._configRuleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleId. 
        /// <para>
        /// The ID of the Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ConfigRuleId
        {
            get { return this._configRuleId; }
            set { this._configRuleId = value; }
        }

        // Check to see if ConfigRuleId property is set
        internal bool IsSetConfigRuleId()
        {
            return this._configRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name that you assign to the Config rule. The name is required if you are adding
        /// a new rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ConfigRuleName
        {
            get { return this._configRuleName; }
            set { this._configRuleName = value; }
        }

        // Check to see if ConfigRuleName property is set
        internal bool IsSetConfigRuleName()
        {
            return this._configRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleState. 
        /// <para>
        /// Indicates whether the Config rule is active or is currently being deleted by Config.
        /// It can also indicate the evaluation status for the Config rule.
        /// </para>
        ///  
        /// <para>
        /// Config sets the state of the rule to <code>EVALUATING</code> temporarily after you
        /// use the <code>StartConfigRulesEvaluation</code> request to evaluate your resources
        /// against the Config rule.
        /// </para>
        ///  
        /// <para>
        /// Config sets the state of the rule to <code>DELETING_RESULTS</code> temporarily after
        /// you use the <code>DeleteEvaluationResults</code> request to delete the current evaluation
        /// results for the Config rule.
        /// </para>
        ///  
        /// <para>
        /// Config temporarily sets the state of a rule to <code>DELETING</code> after you use
        /// the <code>DeleteConfigRule</code> request to delete the rule. After Config deletes
        /// the rule, the rule and all of its evaluations are erased and are no longer available.
        /// </para>
        /// </summary>
        public ConfigRuleState ConfigRuleState
        {
            get { return this._configRuleState; }
            set { this._configRuleState = value; }
        }

        // Check to see if ConfigRuleState property is set
        internal bool IsSetConfigRuleState()
        {
            return this._configRuleState != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Service principal name of the service that created the rule.
        /// </para>
        ///  <note> 
        /// <para>
        /// The field is populated only if the service-linked rule is created by a service. The
        /// field is empty if you create your own rule.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description that you provide for the Config rule.
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
        /// Gets and sets the property EvaluationModes. 
        /// <para>
        /// The modes the Config rule can be evaluated in. The valid values are distinct objects.
        /// By default, the value is Detective evaluation mode only.
        /// </para>
        /// </summary>
        public List<EvaluationModeConfiguration> EvaluationModes
        {
            get { return this._evaluationModes; }
            set { this._evaluationModes = value; }
        }

        // Check to see if EvaluationModes property is set
        internal bool IsSetEvaluationModes()
        {
            return this._evaluationModes != null && this._evaluationModes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputParameters. 
        /// <para>
        /// A string, in JSON format, that is passed to the Config rule Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The maximum frequency with which Config runs evaluations for a rule. You can specify
        /// a value for <code>MaximumExecutionFrequency</code> when:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This is for an Config managed rule that is triggered at a periodic frequency.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your custom rule is triggered when Config delivers the configuration snapshot. For
        /// more information, see <a>ConfigSnapshotDeliveryProperties</a>.
        /// </para>
        ///  </li> </ul> <note> 
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
        /// Gets and sets the property Scope. 
        /// <para>
        /// Defines which resources can trigger an evaluation for the rule. The scope can include
        /// one or more resource types, a combination of one resource type and one resource ID,
        /// or a combination of a tag key and value. Specify a scope to constrain the resources
        /// that can trigger an evaluation for the rule. If you do not specify a scope, evaluations
        /// are triggered when any resource in the recording group changes.
        /// </para>
        ///  <note> 
        /// <para>
        /// The scope can be empty. 
        /// </para>
        ///  </note>
        /// </summary>
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Provides the rule owner (<code>Amazon Web Services</code> for managed rules, <code>CUSTOM_POLICY</code>
        /// for Custom Policy rules, and <code>CUSTOM_LAMBDA</code> for Custom Lambda rules),
        /// the rule identifier, and the notifications that cause the function to evaluate your
        /// Amazon Web Services resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Source Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}