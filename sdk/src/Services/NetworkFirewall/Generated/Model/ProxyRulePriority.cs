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
    /// Proxy rule name and new desired position.
    /// </summary>
    public partial class ProxyRulePriority
    {
        private int? _newPosition;
        private string _proxyRuleName;

        /// <summary>
        /// Gets and sets the property NewPosition. 
        /// <para>
        /// Where to move a proxy rule in a proxy rule group. 
        /// </para>
        /// </summary>
        public int? NewPosition
        {
            get { return this._newPosition; }
            set { this._newPosition = value; }
        }

        // Check to see if NewPosition property is set
        internal bool IsSetNewPosition()
        {
            return this._newPosition.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProxyRuleName. 
        /// <para>
        /// The descriptive name of the proxy rule. You can't change the name of a proxy rule
        /// after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ProxyRuleName
        {
            get { return this._proxyRuleName; }
            set { this._proxyRuleName = value; }
        }

        // Check to see if ProxyRuleName property is set
        internal bool IsSetProxyRuleName()
        {
            return this._proxyRuleName != null;
        }

    }
}