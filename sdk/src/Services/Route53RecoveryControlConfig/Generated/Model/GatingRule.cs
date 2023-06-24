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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// A gating rule verifies that a gating routing control or set of gating routing controls,
    /// evaluates as true, based on a rule configuration that you specify, which allows a
    /// set of routing control state changes to complete.
    /// 
    ///  
    /// <para>
    /// For example, if you specify one gating routing control and you set the Type in the
    /// rule configuration to OR, that indicates that you must set the gating routing control
    /// to On for the rule to evaluate as true; that is, for the gating control "switch" to
    /// be "On". When you do that, then you can update the routing control states for the
    /// target routing controls that you specify in the gating rule.
    /// </para>
    /// </summary>
    public partial class GatingRule
    {
        private string _controlPanelArn;
        private List<string> _gatingControls = new List<string>();
        private string _name;
        private RuleConfig _ruleConfig;
        private string _safetyRuleArn;
        private Status _status;
        private List<string> _targetControls = new List<string>();
        private int? _waitPeriodMs;

        /// <summary>
        /// Gets and sets the property ControlPanelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the control panel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ControlPanelArn
        {
            get { return this._controlPanelArn; }
            set { this._controlPanelArn = value; }
        }

        // Check to see if ControlPanelArn property is set
        internal bool IsSetControlPanelArn()
        {
            return this._controlPanelArn != null;
        }

        /// <summary>
        /// Gets and sets the property GatingControls. 
        /// <para>
        /// An array of gating routing control Amazon Resource Names (ARNs). For a simple "on/off"
        /// switch, specify the ARN for one routing control. The gating routing controls are evaluated
        /// by the rule configuration that you specify to determine if the target routing control
        /// states can be changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> GatingControls
        {
            get { return this._gatingControls; }
            set { this._gatingControls = value; }
        }

        // Check to see if GatingControls property is set
        internal bool IsSetGatingControls()
        {
            return this._gatingControls != null && this._gatingControls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the gating rule. You can use any non-white space character in the name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RuleConfig. 
        /// <para>
        /// The criteria that you set for gating routing controls that designate how many of the
        /// routing control states must be ON to allow you to update target routing control states.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleConfig RuleConfig
        {
            get { return this._ruleConfig; }
            set { this._ruleConfig = value; }
        }

        // Check to see if RuleConfig property is set
        internal bool IsSetRuleConfig()
        {
            return this._ruleConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SafetyRuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gating rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SafetyRuleArn
        {
            get { return this._safetyRuleArn; }
            set { this._safetyRuleArn = value; }
        }

        // Check to see if SafetyRuleArn property is set
        internal bool IsSetSafetyRuleArn()
        {
            return this._safetyRuleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The deployment status of a gating rule. Status can be one of the following: PENDING,
        /// DEPLOYED, PENDING_DELETION.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetControls. 
        /// <para>
        /// An array of target routing control Amazon Resource Names (ARNs) for which the states
        /// can only be updated if the rule configuration that you specify evaluates to true for
        /// the gating routing control. As a simple example, if you have a single gating control,
        /// it acts as an overall "on/off" switch for a set of target routing controls. You can
        /// use this to manually override automated failover, for example.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TargetControls
        {
            get { return this._targetControls; }
            set { this._targetControls = value; }
        }

        // Check to see if TargetControls property is set
        internal bool IsSetTargetControls()
        {
            return this._targetControls != null && this._targetControls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WaitPeriodMs. 
        /// <para>
        /// An evaluation period, in milliseconds (ms), during which any request against the target
        /// routing controls will fail. This helps prevent "flapping" of state. The wait period
        /// is 5000 ms by default, but you can choose a custom value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int WaitPeriodMs
        {
            get { return this._waitPeriodMs.GetValueOrDefault(); }
            set { this._waitPeriodMs = value; }
        }

        // Check to see if WaitPeriodMs property is set
        internal bool IsSetWaitPeriodMs()
        {
            return this._waitPeriodMs.HasValue; 
        }

    }
}