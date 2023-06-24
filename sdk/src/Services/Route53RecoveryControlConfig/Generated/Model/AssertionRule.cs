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
    /// An assertion rule enforces that, when you change a routing control state, that the
    /// criteria that you set in the rule configuration is met. Otherwise, the change to the
    /// routing control is not accepted. For example, the criteria might be that at least
    /// one routing control state is On after the transaction so that traffic continues to
    /// flow to at least one cell for the application. This ensures that you avoid a fail-open
    /// scenario.
    /// </summary>
    public partial class AssertionRule
    {
        private List<string> _assertedControls = new List<string>();
        private string _controlPanelArn;
        private string _name;
        private RuleConfig _ruleConfig;
        private string _safetyRuleArn;
        private Status _status;
        private int? _waitPeriodMs;

        /// <summary>
        /// Gets and sets the property AssertedControls. 
        /// <para>
        /// The routing controls that are part of transactions that are evaluated to determine
        /// if a request to change a routing control state is allowed. For example, you might
        /// include three routing controls, one for each of three Amazon Web Services Regions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AssertedControls
        {
            get { return this._assertedControls; }
            set { this._assertedControls = value; }
        }

        // Check to see if AssertedControls property is set
        internal bool IsSetAssertedControls()
        {
            return this._assertedControls != null && this._assertedControls.Count > 0; 
        }

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
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the assertion rule. You can use any non-white space character in the name.
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
        /// The criteria that you set for specific assertion routing controls (AssertedControls)
        /// that designate how many routing control states must be ON as the result of a transaction.
        /// For example, if you have three assertion routing controls, you might specify ATLEAST
        /// 2 for your rule configuration. This means that at least two assertion routing control
        /// states must be ON, so that at least two Amazon Web Services Regions have traffic flowing
        /// to them.
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
        /// The Amazon Resource Name (ARN) of the assertion rule.
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
        /// The deployment status of an assertion rule. Status can be one of the following: PENDING,
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