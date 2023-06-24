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
    /// A new gating rule for a control panel.
    /// </summary>
    public partial class NewGatingRule
    {
        private string _controlPanelArn;
        private List<string> _gatingControls = new List<string>();
        private string _name;
        private RuleConfig _ruleConfig;
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
        /// The gating controls for the new gating rule. That is, routing controls that are evaluated
        /// by the rule configuration that you specify.
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
        /// The name for the new gating rule.
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
        /// The criteria that you set for specific gating controls (routing controls) that designate
        /// how many control states must be ON to allow you to change (set or unset) the target
        /// control states.
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
        /// Gets and sets the property TargetControls. 
        /// <para>
        /// Routing controls that can only be set or unset if the specified RuleConfig evaluates
        /// to true for the specified GatingControls. For example, say you have three gating controls,
        /// one for each of three Amazon Web Services Regions. Now you specify ATLEAST 2 as your
        /// RuleConfig. With these settings, you can only change (set or unset) the routing controls
        /// that you have specified as TargetControls if that rule evaluates to true.
        /// </para>
        ///  
        /// <para>
        /// In other words, your ability to change the routing controls that you have specified
        /// as TargetControls is gated by the rule that you set for the routing controls in GatingControls.
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