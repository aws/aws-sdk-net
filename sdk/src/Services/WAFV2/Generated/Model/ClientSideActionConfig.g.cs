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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// This is part of the configuration for the managed rules <c>AWSManagedRulesAntiDDoSRuleSet</c>
    /// in <c>ManagedRuleGroupConfig</c>.
    /// </summary>
    public partial class ClientSideActionConfig
    {
        /// <summary>
        /// Gets and sets the property Challenge. 
        /// <para>
        /// Configuration for the use of the <c>AWSManagedRulesAntiDDoSRuleSet</c> rules <c>ChallengeAllDuringEvent</c>
        /// and <c>ChallengeDDoSRequests</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This setting isn't related to the configuration of the <c>Challenge</c> action itself.
        /// It only configures the use of the two anti-DDoS rules named here. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can enable or disable the use of these rules, and you can configure how to use
        /// them when they are enabled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClientSideAction Challenge { get; set; }

        /// <summary>
        /// Checks to see if the Challenge property is set.
        /// </summary>
        internal bool IsSetChallenge() => this.Challenge != null;
    }
}
