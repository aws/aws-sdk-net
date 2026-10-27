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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProxy operation. Updates the properties
    /// of the specified proxy.
    /// </summary>
    public partial class UpdateProxyRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property ListenerPropertiesToAdd. 
        /// <para>
        /// Listener properties for HTTP and HTTPS traffic to add. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<ListenerPropertyRequest> ListenerPropertiesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<ListenerPropertyRequest>() : null;

        /// <summary>
        /// Checks to see if the ListenerPropertiesToAdd property is set.
        /// </summary>
        internal bool IsSetListenerPropertiesToAdd() => this.ListenerPropertiesToAdd != null && (this.ListenerPropertiesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListenerPropertiesToRemove. 
        /// <para>
        /// Listener properties for HTTP and HTTPS traffic to remove. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<ListenerPropertyRequest> ListenerPropertiesToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<ListenerPropertyRequest>() : null;

        /// <summary>
        /// Checks to see if the ListenerPropertiesToRemove property is set.
        /// </summary>
        internal bool IsSetListenerPropertiesToRemove() => this.ListenerPropertiesToRemove != null && (this.ListenerPropertiesToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// The NAT Gateway the proxy is attached to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the NatGatewayId property is set.
        /// </summary>
        internal bool IsSetNatGatewayId() => this.NatGatewayId != null;

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
        [AWSProperty(Min = 1, Max = 256)]
        public string ProxyArn { get; set; }

        /// <summary>
        /// Checks to see if the ProxyArn property is set.
        /// </summary>
        internal bool IsSetProxyArn() => this.ProxyArn != null;

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
        [AWSProperty(Min = 1, Max = 128)]
        public string ProxyName { get; set; }

        /// <summary>
        /// Checks to see if the ProxyName property is set.
        /// </summary>
        internal bool IsSetProxyName() => this.ProxyName != null;

        /// <summary>
        /// Gets and sets the property TlsInterceptProperties. 
        /// <para>
        /// TLS decryption on traffic to filter on attributes in the HTTP header. 
        /// </para>
        /// </summary>
        public TlsInterceptPropertiesRequest TlsInterceptProperties { get; set; }

        /// <summary>
        /// Checks to see if the TlsInterceptProperties property is set.
        /// </summary>
        internal bool IsSetTlsInterceptProperties() => this.TlsInterceptProperties != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string UpdateToken { get; set; }

        /// <summary>
        /// Checks to see if the UpdateToken property is set.
        /// </summary>
        internal bool IsSetUpdateToken() => this.UpdateToken != null;
    }
}
