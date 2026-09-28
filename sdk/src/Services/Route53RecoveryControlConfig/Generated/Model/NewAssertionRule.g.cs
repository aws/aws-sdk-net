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
    /// A new assertion rule for a control panel.
    /// </summary>
    public partial class NewAssertionRule
    {
        /// <summary>
        /// Gets and sets the property AssertedControls. 
        /// <para>
        /// The routing controls that are part of transactions that are evaluated to determine
        /// if a request to change a routing control state is allowed. For example, you might
        /// include three routing controls, one for each of three Amazon Web Services Regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AssertedControls { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssertedControls property is set.
        /// </summary>
        internal bool IsSetAssertedControls() => this.AssertedControls != null && (this.AssertedControls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ControlPanelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the control panel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ControlPanelArn { get; set; }

        /// <summary>
        /// Checks to see if the ControlPanelArn property is set.
        /// </summary>
        internal bool IsSetControlPanelArn() => this.ControlPanelArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the assertion rule. You can use any non-white space character in the name.
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
        /// The criteria that you set for specific assertion controls (routing controls) that
        /// designate how many control states must be ON as the result of a transaction. For example,
        /// if you have three assertion controls, you might specify ATLEAST 2 for your rule configuration.
        /// This means that at least two assertion controls must be ON, so that at least two Amazon
        /// Web Services Regions have traffic flowing to them.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuleConfig RuleConfig { get; set; }

        /// <summary>
        /// Checks to see if the RuleConfig property is set.
        /// </summary>
        internal bool IsSetRuleConfig() => this.RuleConfig != null;

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
