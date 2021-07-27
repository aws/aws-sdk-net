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
    /// Container for the parameters to the CreateSafetyRule operation.
    /// Creates a safety rule in a control panel. Safety rules let you add safeguards around
    /// enabling and disabling routing controls, to help prevent unexpected outcomes.
    /// 
    ///  
    /// <para>
    /// There are two types of safety rules: assertion rules and gating rules.
    /// </para>
    ///  
    /// <para>
    /// Assertion rule: An assertion rule enforces that, when a routing control state is changed,
    /// the criteria set by the rule configuration is met. Otherwise, the change to the routing
    /// control is not accepted.
    /// </para>
    ///  
    /// <para>
    /// Gating rule: A gating rule verifies that a set of gating controls evaluates as true,
    /// based on a rule configuration that you specify. If the gating rule evaluates to true,
    /// Amazon Route 53 Application Recovery Controller allows a set of routing control state
    /// changes to run and complete against the set of target controls.
    /// </para>
    /// </summary>
    public partial class CreateSafetyRuleRequest : AmazonRoute53RecoveryControlConfigRequest
    {
        private NewAssertionRule _assertionRule;
        private string _clientToken;
        private NewGatingRule _gatingRule;

        /// <summary>
        /// Gets and sets the property AssertionRule.
        /// </summary>
        public NewAssertionRule AssertionRule
        {
            get { return this._assertionRule; }
            set { this._assertionRule = value; }
        }

        // Check to see if AssertionRule property is set
        internal bool IsSetAssertionRule()
        {
            return this._assertionRule != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique client idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property GatingRule.
        /// </summary>
        public NewGatingRule GatingRule
        {
            get { return this._gatingRule; }
            set { this._gatingRule = value; }
        }

        // Check to see if GatingRule property is set
        internal bool IsSetGatingRule()
        {
            return this._gatingRule != null;
        }

    }
}