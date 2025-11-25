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
    /// Container for the parameters to the DeleteProxyConfiguration operation.
    /// Deletes the specified <a>ProxyConfiguration</a>.
    /// </summary>
    public partial class DeleteProxyConfigurationRequest : AmazonNetworkFirewallRequest
    {
        private string _proxyConfigurationArn;
        private string _proxyConfigurationName;

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

    }
}