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
    /// Container for the parameters to the UpdateSafetyRule operation. Update a safety rule
    /// (an assertion rule or gating rule). You can only update the name and the waiting period
    /// for a safety rule. To make other updates, delete the safety rule and create a new
    /// one.
    /// </summary>
    public partial class UpdateSafetyRuleRequest : AmazonRoute53RecoveryControlConfigRequest
    {
        /// <summary>
        /// Gets and sets the property AssertionRuleUpdate. 
        /// <para>
        /// The assertion rule to update.
        /// </para>
        /// </summary>
        public AssertionRuleUpdate AssertionRuleUpdate { get; set; }

        /// <summary>
        /// Checks to see if the AssertionRuleUpdate property is set.
        /// </summary>
        internal bool IsSetAssertionRuleUpdate() => this.AssertionRuleUpdate != null;

        /// <summary>
        /// Gets and sets the property GatingRuleUpdate. 
        /// <para>
        /// The gating rule to update.
        /// </para>
        /// </summary>
        public GatingRuleUpdate GatingRuleUpdate { get; set; }

        /// <summary>
        /// Checks to see if the GatingRuleUpdate property is set.
        /// </summary>
        internal bool IsSetGatingRuleUpdate() => this.GatingRuleUpdate != null;
    }
}
