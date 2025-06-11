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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
    /// Configures the use of the anti-DDoS managed rule group, <c>AWSManagedRulesAntiDDoSRuleSet</c>.
    /// This configuration is used in <c>ManagedRuleGroupConfig</c>. 
    /// 
    ///  
    /// <para>
    /// The configuration that you provide here determines whether and how the rules in the
    /// rule group are used. 
    /// </para>
    ///  
    /// <para>
    /// For additional information about this and the other intelligent threat mitigation
    /// rule groups, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-managed-protections">Intelligent
    /// threat mitigation in WAF</a> and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/aws-managed-rule-groups-list">Amazon
    /// Web Services Managed Rules rule groups list</a> in the <i>WAF Developer Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial class AWSManagedRulesAntiDDoSRuleSet
    {
        private ClientSideActionConfig _clientSideActionConfig;
        private SensitivityToAct _sensitivityToBlock;

        /// <summary>
        /// Gets and sets the property ClientSideActionConfig. 
        /// <para>
        /// Configures the request handling that's applied by the managed rule group rules <c>ChallengeAllDuringEvent</c>
        /// and <c>ChallengeDDoSRequests</c> during a distributed denial of service (DDoS) attack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClientSideActionConfig ClientSideActionConfig
        {
            get { return this._clientSideActionConfig; }
            set { this._clientSideActionConfig = value; }
        }

        // Check to see if ClientSideActionConfig property is set
        internal bool IsSetClientSideActionConfig()
        {
            return this._clientSideActionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SensitivityToBlock. 
        /// <para>
        /// The sensitivity that the rule group rule <c>DDoSRequests</c> uses when matching against
        /// the DDoS suspicion labeling on a request. The managed rule group adds the labeling
        /// during DDoS events, before the <c>DDoSRequests</c> rule runs. 
        /// </para>
        ///  
        /// <para>
        /// The higher the sensitivity, the more levels of labeling that the rule matches: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Low sensitivity is less sensitive, causing the rule to match only on the most likely
        /// participants in an attack, which are the requests with the high suspicion label <c>awswaf:managed:aws:anti-ddos:high-suspicion-ddos-request</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Medium sensitivity causes the rule to match on the medium and high suspicion labels.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// High sensitivity causes the rule to match on all of the suspicion labels: low, medium,
        /// and high.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>LOW</c> 
        /// </para>
        /// </summary>
        public SensitivityToAct SensitivityToBlock
        {
            get { return this._sensitivityToBlock; }
            set { this._sensitivityToBlock = value; }
        }

        // Check to see if SensitivityToBlock property is set
        internal bool IsSetSensitivityToBlock()
        {
            return this._sensitivityToBlock != null;
        }

    }
}