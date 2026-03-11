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
    /// Container for the parameters to the UpdateProxyConfiguration operation.
    /// Updates the properties of the specified proxy configuration.
    /// </summary>
    public partial class UpdateProxyConfigurationRequest : AmazonNetworkFirewallRequest
    {
        private ProxyConfigDefaultRulePhaseActionsRequest _defaultRulePhaseActions;
        private string _proxyConfigurationArn;
        private string _proxyConfigurationName;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property DefaultRulePhaseActions. 
        /// <para>
        /// Evaluation points in the traffic flow where rules are applied. There are three phases
        /// in a traffic where the rule match is applied. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProxyConfigDefaultRulePhaseActionsRequest DefaultRulePhaseActions
        {
            get { return this._defaultRulePhaseActions; }
            set { this._defaultRulePhaseActions = value; }
        }

        // Check to see if DefaultRulePhaseActions property is set
        internal bool IsSetDefaultRulePhaseActions()
        {
            return this._defaultRulePhaseActions != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a proxy configuration.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ProxyConfigurationArn
        {
            get { return this._proxyConfigurationArn; }
            set { this._proxyConfigurationArn = value; }
        }

        // Check to see if ProxyConfigurationArn property is set
        internal bool IsSetProxyConfigurationArn()
        {
            return this._proxyConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyConfigurationName. 
        /// <para>
        /// The descriptive name of the proxy configuration. You can't change the name of a proxy
        /// configuration after you create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ProxyConfigurationName
        {
            get { return this._proxyConfigurationName; }
            set { this._proxyConfigurationName = value; }
        }

        // Check to see if ProxyConfigurationName property is set
        internal bool IsSetProxyConfigurationName()
        {
            return this._proxyConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic locking. Network Firewall returns a token to your requests
        /// that access the proxy configuration. The token marks the state of the proxy configuration
        /// resource at the time of the request. 
        /// </para>
        ///  
        /// <para>
        /// To make changes to the proxy configuration, you provide the token in your request.
        /// Network Firewall uses the token to ensure that the proxy configuration hasn't changed
        /// since you last retrieved it. If it has changed, the operation fails with an <c>InvalidTokenException</c>.
        /// If this happens, retrieve the proxy configuration again to get a current copy of it
        /// with a current token. Reapply your changes as needed, then try the operation again
        /// using the new token. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string UpdateToken
        {
            get { return this._updateToken; }
            set { this._updateToken = value; }
        }

        // Check to see if UpdateToken property is set
        internal bool IsSetUpdateToken()
        {
            return this._updateToken != null;
        }

    }
}