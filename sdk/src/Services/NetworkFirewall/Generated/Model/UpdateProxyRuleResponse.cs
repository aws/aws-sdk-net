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
    /// This is the response object from the UpdateProxyRule operation.
    /// </summary>
    public partial class UpdateProxyRuleResponse : AmazonWebServiceResponse
    {
        private ProxyRule _proxyRule;
        private List<ProxyRuleCondition> _removedConditions = AWSConfigs.InitializeCollections ? new List<ProxyRuleCondition>() : null;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property ProxyRule. 
        /// <para>
        /// The updated proxy rule resource that reflects the updates from the request.
        /// </para>
        /// </summary>
        public ProxyRule ProxyRule
        {
            get { return this._proxyRule; }
            set { this._proxyRule = value; }
        }

        // Check to see if ProxyRule property is set
        internal bool IsSetProxyRule()
        {
            return this._proxyRule != null;
        }

        /// <summary>
        /// Gets and sets the property RemovedConditions. 
        /// <para>
        /// Proxy rule conditions removed from the rule. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProxyRuleCondition> RemovedConditions
        {
            get { return this._removedConditions; }
            set { this._removedConditions = value; }
        }

        // Check to see if RemovedConditions property is set
        internal bool IsSetRemovedConditions()
        {
            return this._removedConditions != null && (this._removedConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic locking. Network Firewall returns a token to your requests
        /// that access the proxy rule. The token marks the state of the proxy rule resource at
        /// the time of the request. 
        /// </para>
        ///  
        /// <para>
        /// To make changes to the proxy rule, you provide the token in your request. Network
        /// Firewall uses the token to ensure that the proxy rule hasn't changed since you last
        /// retrieved it. If it has changed, the operation fails with an <c>InvalidTokenException</c>.
        /// If this happens, retrieve the proxy rule again to get a current copy of it with a
        /// current token. Reapply your changes as needed, then try the operation again using
        /// the new token. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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