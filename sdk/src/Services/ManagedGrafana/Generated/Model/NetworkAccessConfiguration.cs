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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// The configuration settings for in-bound network access to your workspace.
    /// 
    ///  
    /// <para>
    /// When this is configured, only listed IP addresses and VPC endpoints will be able to
    /// access your workspace. Standard Grafana authentication and authorization will still
    /// be required.
    /// </para>
    ///  
    /// <para>
    /// If this is not configured, or is removed, then all IP addresses and VPC endpoints
    /// will be allowed. Standard Grafana authentication and authorization will still be required.
    /// </para>
    /// </summary>
    public partial class NetworkAccessConfiguration
    {
        private List<string> _prefixListIds = new List<string>();
        private List<string> _vpceIds = new List<string>();

        /// <summary>
        /// Gets and sets the property PrefixListIds. 
        /// <para>
        /// An array of prefix list IDs. A prefix list is a list of CIDR ranges of IP addresses.
        /// The IP addresses specified are allowed to access your workspace. If the list is not
        /// included in the configuration then no IP addresses will be allowed to access the workspace.
        /// You create a prefix list using the Amazon VPC console.
        /// </para>
        ///  
        /// <para>
        /// Prefix list IDs have the format <code>pl-<i>1a2b3c4d</i> </code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about prefix lists, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/managed-prefix-lists.html">Group
        /// CIDR blocks using managed prefix lists</a>in the <i>Amazon Virtual Private Cloud User
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> PrefixListIds
        {
            get { return this._prefixListIds; }
            set { this._prefixListIds = value; }
        }

        // Check to see if PrefixListIds property is set
        internal bool IsSetPrefixListIds()
        {
            return this._prefixListIds != null && this._prefixListIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpceIds. 
        /// <para>
        /// An array of Amazon VPC endpoint IDs for the workspace. You can create VPC endpoints
        /// to your Amazon Managed Grafana workspace for access from within a VPC. If a <code>NetworkAccessConfiguration</code>
        /// is specified then only VPC endpoints specified here will be allowed to access the
        /// workspace.
        /// </para>
        ///  
        /// <para>
        /// VPC endpoint IDs have the format <code>vpce-<i>1a2b3c4d</i> </code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating an interface VPC endpoint, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/VPC-endpoints">Interface
        /// VPC endpoints</a> in the <i>Amazon Managed Grafana User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The only VPC endpoints that can be specified here are interface VPC endpoints for
        /// Grafana workspaces (using the <code>com.amazonaws.[region].grafana-workspace</code>
        /// service endpoint). Other VPC endpoints will be ignored.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> VpceIds
        {
            get { return this._vpceIds; }
            set { this._vpceIds = value; }
        }

        // Check to see if VpceIds property is set
        internal bool IsSetVpceIds()
        {
            return this._vpceIds != null && this._vpceIds.Count > 0; 
        }

    }
}