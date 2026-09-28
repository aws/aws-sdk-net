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
    /// A new gating rule for a control panel.
    /// </summary>
    public partial class NewGatingRule
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
        /// The gating controls for the new gating rule. That is, routing controls that are evaluated
        /// by the rule configuration that you specify.
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
        /// The name for the new gating rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RuleConfig. 
        /// <para>
        /// The criteria that you set for specific gating controls (routing controls) that designate
        /// how many control states must be ON to allow you to change (set or unset) the target
        /// control states.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuleConfig RuleConfig { get; set; }

        /// <summary>
        /// Checks to see if the RuleConfig property is set.
        /// </summary>
        internal bool IsSetRuleConfig() => this.RuleConfig != null;

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
