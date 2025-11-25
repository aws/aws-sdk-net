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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteProxyRules operation.
    /// Deletes the specified <a>ProxyRule</a>(s). currently attached to a <a>ProxyRuleGroup</a>
    /// </summary>
    public partial class DeleteProxyRulesRequest : AmazonNetworkFirewallRequest
    {
        private string _proxyRuleGroupArn;
        private string _proxyRuleGroupName;
        private List<string> _rules = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ProxyRuleGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a proxy rule group.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ProxyRuleGroupArn
        {
            get { return this._proxyRuleGroupArn; }
            set { this._proxyRuleGroupArn = value; }
        }

        // Check to see if ProxyRuleGroupArn property is set
        internal bool IsSetProxyRuleGroupArn()
        {
            return this._proxyRuleGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyRuleGroupName. 
        /// <para>
        /// The descriptive name of the proxy rule group. You can't change the name of a proxy
        /// rule group after you create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ProxyRuleGroupName
        {
            get { return this._proxyRuleGroupName; }
            set { this._proxyRuleGroupName = value; }
        }

        // Check to see if ProxyRuleGroupName property is set
        internal bool IsSetProxyRuleGroupName()
        {
            return this._proxyRuleGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The proxy rule(s) to remove from the existing proxy rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}