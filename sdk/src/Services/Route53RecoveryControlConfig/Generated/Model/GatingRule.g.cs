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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ControlPanelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the control panel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ControlPanelArn { get; set; }

        /// <summary>
        /// Checks to see if the ControlPanelArn property is set.
        /// </summary>
        internal bool IsSetControlPanelArn() => this.ControlPanelArn != null;

        /// <summary>
        /// Gets and sets the property GatingControls. 
        /// <para>
        /// An array of gating routing control Amazon Resource Names (ARNs). For a simple "on/off"
        /// switch, specify the ARN for one routing control. The gating routing controls are evaluated
        /// by the rule configuration that you specify to determine if the target routing control
        /// states can be changed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> GatingControls { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GatingControls property is set.
        /// </summary>
        internal bool IsSetGatingControls() => this.GatingControls != null && (this.GatingControls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the gating rule. You can use any non-white space character in the name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services account ID of the gating rule owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property RuleConfig. 
        /// <para>
        /// The criteria that you set for gating routing controls that designate how many of the
        /// routing control states must be ON to allow you to update target routing control states.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuleConfig RuleConfig { get; set; }

        /// <summary>
        /// Checks to see if the RuleConfig property is set.
        /// </summary>
        internal bool IsSetRuleConfig() => this.RuleConfig != null;

        /// <summary>
        /// Gets and sets the property SafetyRuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gating rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SafetyRuleArn { get; set; }

        /// <summary>
        /// Checks to see if the SafetyRuleArn property is set.
        /// </summary>
        internal bool IsSetSafetyRuleArn() => this.SafetyRuleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The deployment status of a gating rule. Status can be one of the following: PENDING,
        /// DEPLOYED, PENDING_DELETION.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetControls. 
        /// <para>
        /// An array of target routing control Amazon Resource Names (ARNs) for which the states
        /// can only be updated if the rule configuration that you specify evaluates to true for
        /// the gating routing control. As a simple example, if you have a single gating control,
        /// it acts as an overall "on/off" switch for a set of target routing controls. You can
        /// use this to manually override automated failover, for example.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> TargetControls { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetControls property is set.
        /// </summary>
        internal bool IsSetTargetControls() => this.TargetControls != null && (this.TargetControls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WaitPeriodMs. 
        /// <para>
        /// An evaluation period, in milliseconds (ms), during which any request against the target
        /// routing controls will fail. This helps prevent "flapping" of state. The wait period
        /// is 5000 ms by default, but you can choose a custom value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? WaitPeriodMs { get; set; }

        /// <summary>
        /// Checks to see if the WaitPeriodMs property is set.
        /// </summary>
        internal bool IsSetWaitPeriodMs() => this.WaitPeriodMs.HasValue;
    }
}
