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
    /// Proxy attached to a NAT gateway.
    /// </summary>
    public partial class Proxy
    {
        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Time the Proxy was created. 
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteTime. 
        /// <para>
        /// Time the Proxy was deleted. 
        /// </para>
        /// </summary>
        public DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Checks to see if the DeleteTime property is set.
        /// </summary>
        internal bool IsSetDeleteTime() => this.DeleteTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// Failure code for cases when the Proxy fails to attach or update. 
        /// </para>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Failure message for cases when the Proxy fails to attach or update. 
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property ListenerProperties. 
        /// <para>
        /// Listener properties for HTTP and HTTPS traffic. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ListenerProperty> ListenerProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<ListenerProperty>() : null;

        /// <summary>
        /// Checks to see if the ListenerProperties property is set.
        /// </summary>
        internal bool IsSetListenerProperties() => this.ListenerProperties != null && (this.ListenerProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// The NAT Gateway for the proxy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
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
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ProxyArn { get; set; }

        /// <summary>
        /// Checks to see if the ProxyArn property is set.
        /// </summary>
        internal bool IsSetProxyArn() => this.ProxyArn != null;

        /// <summary>
        /// Gets and sets the property ProxyConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a proxy configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ProxyConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ProxyConfigurationArn property is set.
        /// </summary>
        internal bool IsSetProxyConfigurationArn() => this.ProxyConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ProxyConfigurationName. 
        /// <para>
        /// The descriptive name of the proxy configuration. You can't change the name of a proxy
        /// configuration after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProxyConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the ProxyConfigurationName property is set.
        /// </summary>
        internal bool IsSetProxyConfigurationName() => this.ProxyConfigurationName != null;

        /// <summary>
        /// Gets and sets the property ProxyModifyState. 
        /// <para>
        /// Current modification status of the Proxy. 
        /// </para>
        /// </summary>
        public ProxyModifyState ProxyModifyState { get; set; }

        /// <summary>
        /// Checks to see if the ProxyModifyState property is set.
        /// </summary>
        internal bool IsSetProxyModifyState() => this.ProxyModifyState != null;

        /// <summary>
        /// Gets and sets the property ProxyName. 
        /// <para>
        /// The descriptive name of the proxy. You can't change the name of a proxy after you
        /// create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProxyName { get; set; }

        /// <summary>
        /// Checks to see if the ProxyName property is set.
        /// </summary>
        internal bool IsSetProxyName() => this.ProxyName != null;

        /// <summary>
        /// Gets and sets the property ProxyState. 
        /// <para>
        /// Current attachment/detachment status of the Proxy. 
        /// </para>
        /// </summary>
        public ProxyState ProxyState { get; set; }

        /// <summary>
        /// Checks to see if the ProxyState property is set.
        /// </summary>
        internal bool IsSetProxyState() => this.ProxyState != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TlsInterceptProperties. 
        /// <para>
        /// TLS decryption on traffic to filter on attributes in the HTTP header. 
        /// </para>
        /// </summary>
        public TlsInterceptProperties TlsInterceptProperties { get; set; }

        /// <summary>
        /// Checks to see if the TlsInterceptProperties property is set.
        /// </summary>
        internal bool IsSetTlsInterceptProperties() => this.TlsInterceptProperties != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// Time the Proxy was updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
