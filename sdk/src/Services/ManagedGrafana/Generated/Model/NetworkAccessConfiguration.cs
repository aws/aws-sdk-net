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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// The configuration settings for in-bound network access to your workspace.
    /// 
    ///  
    /// <para>
    /// When this is configured, only listed IP addresses and VPC endpoints will be able to
    /// access your workspace. Standard Grafana authentication and authorization are still
    /// required.
    /// </para>
    ///  
    /// <para>
    /// Access is granted to a caller that is in either the IP address list or the VPC endpoint
    /// list - they do not need to be in both.
    /// </para>
    ///  
    /// <para>
    /// If this is not configured, or is removed, then all IP addresses and VPC endpoints
    /// are allowed. Standard Grafana authentication and authorization are still required.
    /// </para>
    ///  <note> 
    /// <para>
    /// While both <c>prefixListIds</c> and <c>vpceIds</c> are required, you can pass in an
    /// empty array of strings for either parameter if you do not want to allow any of that
    /// type.
    /// </para>
    ///  
    /// <para>
    /// If both are passed as empty arrays, no traffic is allowed to the workspace, because
    /// only <i>explicitly</i> allowed connections are accepted.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class NetworkAccessConfiguration
    {
        private List<string> _prefixListIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _vpceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property PrefixListIds. 
        /// <para>
        /// An array of prefix list IDs. A prefix list is a list of CIDR ranges of IP addresses.
        /// The IP addresses specified are allowed to access your workspace. If the list is not
        /// included in the configuration (passed an empty array) then no IP addresses are allowed
        /// to access the workspace. You create a prefix list using the Amazon VPC console.
        /// </para>
        ///  
        /// <para>
        /// Prefix list IDs have the format <c>pl-<i>1a2b3c4d</i> </c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about prefix lists, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/managed-prefix-lists.html">Group
        /// CIDR blocks using managed prefix lists</a>in the <i>Amazon Virtual Private Cloud User
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._prefixListIds != null && (this._prefixListIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpceIds. 
        /// <para>
        /// An array of Amazon VPC endpoint IDs for the workspace. You can create VPC endpoints
        /// to your Amazon Managed Grafana workspace for access from within a VPC. If a <c>NetworkAccessConfiguration</c>
        /// is specified then only VPC endpoints specified here are allowed to access the workspace.
        /// If you pass in an empty array of strings, then no VPCs are allowed to access the workspace.
        /// </para>
        ///  
        /// <para>
        /// VPC endpoint IDs have the format <c>vpce-<i>1a2b3c4d</i> </c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about creating an interface VPC endpoint, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/VPC-endpoints">Interface
        /// VPC endpoints</a> in the <i>Amazon Managed Grafana User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The only VPC endpoints that can be specified here are interface VPC endpoints for
        /// Grafana workspaces (using the <c>com.amazonaws.[region].grafana-workspace</c> service
        /// endpoint). Other VPC endpoints are ignored.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._vpceIds != null && (this._vpceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}