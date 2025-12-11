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
    /// Container for the parameters to the CreateProxy operation.
    /// Creates an Network Firewall <a>Proxy</a> 
    /// 
    ///  
    /// <para>
    /// Attaches a Proxy configuration to a NAT Gateway. 
    /// </para>
    ///  
    /// <para>
    /// To manage a proxy's tags, use the standard Amazon Web Services resource tagging operations,
    /// <a>ListTagsForResource</a>, <a>TagResource</a>, and <a>UntagResource</a>.
    /// </para>
    ///  
    /// <para>
    /// To retrieve information about proxies, use <a>ListProxies</a> and <a>DescribeProxy</a>.
    /// </para>
    /// </summary>
    public partial class CreateProxyRequest : AmazonNetworkFirewallRequest
    {
        private List<ListenerPropertyRequest> _listenerProperties = AWSConfigs.InitializeCollections ? new List<ListenerPropertyRequest>() : null;
        private string _natGatewayId;
        private string _proxyConfigurationArn;
        private string _proxyConfigurationName;
        private string _proxyName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TlsInterceptPropertiesRequest _tlsInterceptProperties;

        /// <summary>
        /// Gets and sets the property ListenerProperties. 
        /// <para>
        /// Listener properties for HTTP and HTTPS traffic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<ListenerPropertyRequest> ListenerProperties
        {
            get { return this._listenerProperties; }
            set { this._listenerProperties = value; }
        }

        // Check to see if ListenerProperties property is set
        internal bool IsSetListenerProperties()
        {
            return this._listenerProperties != null && (this._listenerProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// A unique identifier for the NAT gateway to use with proxy resources.
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
        /// Gets and sets the property ProxyName. 
        /// <para>
        /// The descriptive name of the proxy. You can't change the name of a proxy after you
        /// create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TlsInterceptProperties. 
        /// <para>
        /// TLS decryption on traffic to filter on attributes in the HTTP header. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}