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
    /// Container for the parameters to the UpdateProxy operation.
    /// Updates the properties of the specified proxy.
    /// </summary>
    public partial class UpdateProxyRequest : AmazonNetworkFirewallRequest
    {
        private List<ListenerPropertyRequest> _listenerPropertiesToAdd = AWSConfigs.InitializeCollections ? new List<ListenerPropertyRequest>() : null;
        private List<ListenerPropertyRequest> _listenerPropertiesToRemove = AWSConfigs.InitializeCollections ? new List<ListenerPropertyRequest>() : null;
        private string _natGatewayId;
        private string _proxyArn;
        private string _proxyName;
        private TlsInterceptPropertiesRequest _tlsInterceptProperties;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property ListenerPropertiesToAdd. 
        /// <para>
        /// Listener properties for HTTP and HTTPS traffic to add. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<ListenerPropertyRequest> ListenerPropertiesToAdd
        {
            get { return this._listenerPropertiesToAdd; }
            set { this._listenerPropertiesToAdd = value; }
        }

        // Check to see if ListenerPropertiesToAdd property is set
        internal bool IsSetListenerPropertiesToAdd()
        {
            return this._listenerPropertiesToAdd != null && (this._listenerPropertiesToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListenerPropertiesToRemove. 
        /// <para>
        /// Listener properties for HTTP and HTTPS traffic to remove. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<ListenerPropertyRequest> ListenerPropertiesToRemove
        {
            get { return this._listenerPropertiesToRemove; }
            set { this._listenerPropertiesToRemove = value; }
        }

        // Check to see if ListenerPropertiesToRemove property is set
        internal bool IsSetListenerPropertiesToRemove()
        {
            return this._listenerPropertiesToRemove != null && (this._listenerPropertiesToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// The NAT Gateway the proxy is attached to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string NatGatewayId
        {
            get { return this._natGatewayId; }
            set { this._natGatewayId = value; }
        }

        // Check to see if NatGatewayId property is set
        internal bool IsSetNatGatewayId()
        {
            return this._natGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a proxy.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ProxyArn
        {
            get { return this._proxyArn; }
            set { this._proxyArn = value; }
        }

        // Check to see if ProxyArn property is set
        internal bool IsSetProxyArn()
        {
            return this._proxyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyName. 
        /// <para>
        /// The descriptive name of the proxy. You can't change the name of a proxy after you
        /// create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ProxyName
        {
            get { return this._proxyName; }
            set { this._proxyName = value; }
        }

        // Check to see if ProxyName property is set
        internal bool IsSetProxyName()
        {
            return this._proxyName != null;
        }

        /// <summary>
        /// Gets and sets the property TlsInterceptProperties. 
        /// <para>
        /// TLS decryption on traffic to filter on attributes in the HTTP header. 
        /// </para>
        /// </summary>
        public TlsInterceptPropertiesRequest TlsInterceptProperties
        {
            get { return this._tlsInterceptProperties; }
            set { this._tlsInterceptProperties = value; }
        }

        // Check to see if TlsInterceptProperties property is set
        internal bool IsSetTlsInterceptProperties()
        {
            return this._tlsInterceptProperties != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic locking. Network Firewall returns a token to your requests
        /// that access the proxy. The token marks the state of the proxy resource at the time
        /// of the request. 
        /// </para>
        ///  
        /// <para>
        /// To make changes to the proxy, you provide the token in your request. Network Firewall
        /// uses the token to ensure that the proxy hasn't changed since you last retrieved it.
        /// If it has changed, the operation fails with an <c>InvalidTokenException</c>. If this
        /// happens, retrieve the proxy again to get a current copy of it with a current token.
        /// Reapply your changes as needed, then try the operation again using the new token.
        /// 
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