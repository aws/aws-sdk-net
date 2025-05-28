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
    /// This is the response object from the DescribeFirewall operation.
    /// </summary>
    public partial class DescribeFirewallResponse : AmazonWebServiceResponse
    {
        private Firewall _firewall;
        private FirewallStatus _firewallStatus;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property Firewall. 
        /// <para>
        /// The configuration settings for the firewall. These settings include the firewall policy
        /// and the subnets in your VPC to use for the firewall endpoints. 
        /// </para>
        /// </summary>
        public Firewall Firewall
        {
            get { return this._firewall; }
            set { this._firewall = value; }
        }

        // Check to see if Firewall property is set
        internal bool IsSetFirewall()
        {
            return this._firewall != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallStatus. 
        /// <para>
        /// Detailed information about the current status of a <a>Firewall</a>. You can retrieve
        /// this for a firewall by calling <a>DescribeFirewall</a> and providing the firewall
        /// name and ARN.
        /// </para>
        ///  
        /// <para>
        /// The firewall status indicates a combined status. It indicates whether all subnets
        /// are up-to-date with the latest firewall configurations, which is based on the sync
        /// states config values, and also whether all subnets have their endpoints fully enabled,
        /// based on their sync states attachment values. 
        /// </para>
        /// </summary>
        public FirewallStatus FirewallStatus
        {
            get { return this._firewallStatus; }
            set { this._firewallStatus = value; }
        }

        // Check to see if FirewallStatus property is set
        internal bool IsSetFirewallStatus()
        {
            return this._firewallStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// An optional token that you can use for optimistic locking. Network Firewall returns
        /// a token to your requests that access the firewall. The token marks the state of the
        /// firewall resource at the time of the request. 
        /// </para>
        ///  
        /// <para>
        /// To make an unconditional change to the firewall, omit the token in your update request.
        /// Without the token, Network Firewall performs your updates regardless of whether the
        /// firewall has changed since you last retrieved it.
        /// </para>
        ///  
        /// <para>
        /// To make a conditional change to the firewall, provide the token in your update request.
        /// Network Firewall uses the token to ensure that the firewall hasn't changed since you
        /// last retrieved it. If it has changed, the operation fails with an <c>InvalidTokenException</c>.
        /// If this happens, retrieve the firewall again to get a current copy of it with a new
        /// token. Reapply your changes as needed, then try the operation again using the new
        /// token. 
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