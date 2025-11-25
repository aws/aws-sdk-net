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
    /// Container for the parameters to the DescribeProxy operation.
    /// Returns the data objects for the specified proxy.
    /// </summary>
    public partial class DescribeProxyRequest : AmazonNetworkFirewallRequest
    {
        private string _proxyArn;
        private string _proxyName;

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

    }
}