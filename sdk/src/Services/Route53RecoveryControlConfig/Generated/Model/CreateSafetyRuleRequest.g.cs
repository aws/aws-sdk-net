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
    /// Container for the parameters to the CreateSafetyRule operation. Creates a safety rule
    /// in a control panel. Safety rules let you add safeguards around changing routing control
    /// states, and for enabling and disabling routing controls, to help prevent unexpected
    /// outcomes. <para> There are two types of safety rules: assertion rules and gating rules.
    /// </para> <para> Assertion rule: An assertion rule enforces that, when you change a
    /// routing control state, that a certain criteria is met. For example, the criteria might
    /// be that at least one routing control state is On after the transaction so that traffic
    /// continues to flow to at least one cell for the application. This ensures that you
    /// avoid a fail-open scenario. </para> <para> Gating rule: A gating rule lets you configure
    /// a gating routing control as an overall "on/off" switch for a group of routing controls.
    /// Or, you can configure more complex gating scenarios, for example by configuring multiple
    /// gating routing controls. </para> <para> For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.safety-rules.html">Safety
    /// rules</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
    /// </para>
    /// </summary>
    public partial class CreateSafetyRuleRequest : AmazonRoute53RecoveryControlConfigRequest
    {
        /// <summary>
        /// Gets and sets the property AssertionRule. 
        /// <para>
        /// The assertion rule requested.
        /// </para>
        /// </summary>
        public NewAssertionRule AssertionRule { get; set; }

        /// <summary>
        /// Checks to see if the AssertionRule property is set.
        /// </summary>
        internal bool IsSetAssertionRule() => this.AssertionRule != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive string of up to 64 ASCII characters. To make an idempotent
        /// API request with an action, specify a client token in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property GatingRule. 
        /// <para>
        /// The gating rule requested.
        /// </para>
        /// </summary>
        public NewGatingRule GatingRule { get; set; }

        /// <summary>
        /// Checks to see if the GatingRule property is set.
        /// </summary>
        internal bool IsSetGatingRule() => this.GatingRule != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the safety rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
