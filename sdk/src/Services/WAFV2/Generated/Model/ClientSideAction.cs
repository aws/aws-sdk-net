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
    /// This is part of the <c>AWSManagedRulesAntiDDoSRuleSet</c> <c>ClientSideActionConfig</c>
    /// configuration in <c>ManagedRuleGroupConfig</c>.
    /// </summary>
    public partial class ClientSideAction
    {
        private List<Regex> _exemptUriRegularExpressions = AWSConfigs.InitializeCollections ? new List<Regex>() : null;
        private SensitivityToAct _sensitivity;
        private UsageOfAction _usageOfAction;

        /// <summary>
        /// Gets and sets the property ExemptUriRegularExpressions. 
        /// <para>
        /// The regular expression to match against the web request URI, used to identify requests
        /// that can't handle a silent browser challenge. When the <c>ClientSideAction</c> setting
        /// <c>UsageOfAction</c> is enabled, the managed rule group uses this setting to determine
        /// which requests to label with <c>awswaf:managed:aws:anti-ddos:challengeable-request</c>.
        /// If <c>UsageOfAction</c> is disabled, this setting has no effect and the managed rule
        /// group doesn't add the label to any requests.
        /// </para>
        ///  
        /// <para>
        /// The anti-DDoS managed rule group doesn't evaluate the rules <c>ChallengeDDoSRequests</c>
        /// or <c>ChallengeAllDuringEvent</c> for web requests whose URIs match this regex. This
        /// is true regardless of whether you override the rule action for either of the rules
        /// in your web ACL configuration. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services recommends using a regular expression. 
        /// </para>
        ///  
        /// <para>
        /// This setting is required if <c>UsageOfAction</c> is set to <c>ENABLED</c>. If required,
        /// you can provide between 1 and 5 regex objects in the array of settings. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services recommends starting with the following setting. Review and update
        /// it for your application's needs:
        /// </para>
        ///  
        /// <para>
        ///  <c>\/api\/|\.(acc|avi|css|gif|jpe?g|js|mp[34]|ogg|otf|pdf|png|tiff?|ttf|webm|webp|woff2?)$</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Regex> ExemptUriRegularExpressions
        {
            get { return this._exemptUriRegularExpressions; }
            set { this._exemptUriRegularExpressions = value; }
        }

        // Check to see if ExemptUriRegularExpressions property is set
        internal bool IsSetExemptUriRegularExpressions()
        {
            return this._exemptUriRegularExpressions != null && (this._exemptUriRegularExpressions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Sensitivity. 
        /// <para>
        /// The sensitivity that the rule group rule <c>ChallengeDDoSRequests</c> uses when matching
        /// against the DDoS suspicion labeling on a request. The managed rule group adds the
        /// labeling during DDoS events, before the <c>ChallengeDDoSRequests</c> rule runs. 
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
        /// Default: <c>HIGH</c> 
        /// </para>
        /// </summary>
        public SensitivityToAct Sensitivity
        {
            get { return this._sensitivity; }
            set { this._sensitivity = value; }
        }

        // Check to see if Sensitivity property is set
        internal bool IsSetSensitivity()
        {
            return this._sensitivity != null;
        }

        /// <summary>
        /// Gets and sets the property UsageOfAction. 
        /// <para>
        /// Determines whether to use the <c>AWSManagedRulesAntiDDoSRuleSet</c> rules <c>ChallengeAllDuringEvent</c>
        /// and <c>ChallengeDDoSRequests</c> in the rule group evaluation and the related label
        /// <c>awswaf:managed:aws:anti-ddos:challengeable-request</c>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If usage is enabled: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The managed rule group adds the label <c>awswaf:managed:aws:anti-ddos:challengeable-request</c>
        /// to any web request whose URL does <i>NOT</i> match the regular expressions provided
        /// in the <c>ClientSideAction</c> setting <c>ExemptUriRegularExpressions</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The two rules are evaluated against web requests for protected resources that are
        /// experiencing a DDoS attack. The two rules only apply their action to matching requests
        /// that have the label <c>awswaf:managed:aws:anti-ddos:challengeable-request</c>. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If usage is disabled: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The managed rule group doesn't add the label <c>awswaf:managed:aws:anti-ddos:challengeable-request</c>
        /// to any web requests. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The two rules are not evaluated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None of the other <c>ClientSideAction</c> settings have any effect.
        /// </para>
        ///  </li> </ul> </li> </ul> <note> 
        /// <para>
        /// This setting only enables or disables the use of the two anti-DDOS rules <c>ChallengeAllDuringEvent</c>
        /// and <c>ChallengeDDoSRequests</c> in the anti-DDoS managed rule group. 
        /// </para>
        ///  
        /// <para>
        /// This setting doesn't alter the action setting in the two rules. To override the actions
        /// used by the rules <c>ChallengeAllDuringEvent</c> and <c>ChallengeDDoSRequests</c>,
        /// enable this setting, and then override the rule actions in the usual way, in your
        /// managed rule group configuration. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public UsageOfAction UsageOfAction
        {
            get { return this._usageOfAction; }
            set { this._usageOfAction = value; }
        }

        // Check to see if UsageOfAction property is set
        internal bool IsSetUsageOfAction()
        {
            return this._usageOfAction != null;
        }

    }
}