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
    /// Proxy attached to a NAT gateway.
    /// </summary>
    public partial class Proxy
    {
        private DateTime? _createTime;
        private DateTime? _deleteTime;
        private string _failureCode;
        private string _failureMessage;
        private List<ListenerProperty> _listenerProperties = AWSConfigs.InitializeCollections ? new List<ListenerProperty>() : null;
        private string _natGatewayId;
        private string _proxyArn;
        private string _proxyConfigurationArn;
        private string _proxyConfigurationName;
        private ProxyModifyState _proxyModifyState;
        private string _proxyName;
        private ProxyState _proxyState;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TlsInterceptProperties _tlsInterceptProperties;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Time the Proxy was created. 
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteTime. 
        /// <para>
        /// Time the Proxy was deleted. 
        /// </para>
        /// </summary>
        public DateTime? DeleteTime
        {
            get { return this._deleteTime; }
            set { this._deleteTime = value; }
        }

        // Check to see if DeleteTime property is set
        internal bool IsSetDeleteTime()
        {
            return this._deleteTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// Failure code for cases when the Proxy fails to attach or update. 
        /// </para>
        /// </summary>
        public string FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Failure message for cases when the Proxy fails to attach or update. 
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

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
        public List<ListenerProperty> ListenerProperties
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
        /// The NAT Gateway for the proxy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property ProxyConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a proxy configuration.
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
        /// Gets and sets the property ProxyModifyState. 
        /// <para>
        /// Current modification status of the Proxy. 
        /// </para>
        /// </summary>
        public ProxyModifyState ProxyModifyState
        {
            get { return this._proxyModifyState; }
            set { this._proxyModifyState = value; }
        }

        // Check to see if ProxyModifyState property is set
        internal bool IsSetProxyModifyState()
        {
            return this._proxyModifyState != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyName. 
        /// <para>
        /// The descriptive name of the proxy. You can't change the name of a proxy after you
        /// create it.
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
        /// Gets and sets the property ProxyState. 
        /// <para>
        /// Current attachment/detachment status of the Proxy. 
        /// </para>
        /// </summary>
        public ProxyState ProxyState
        {
            get { return this._proxyState; }
            set { this._proxyState = value; }
        }

        // Check to see if ProxyState property is set
        internal bool IsSetProxyState()
        {
            return this._proxyState != null;
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
        public TlsInterceptProperties TlsInterceptProperties
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
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// Time the Proxy was updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}