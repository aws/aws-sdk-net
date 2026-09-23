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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Coverage information for one firewall type within a deployment. It lists the deployment's
    /// policies that have this firewall type. It also lists the resource types in the deployment's
    /// scope that the firewall type protects.
    /// </summary>
    public partial class DeploymentCoverageEntry
    {
        private PolicyFirewallType _firewallType;
        private List<string> _inScopeResourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _policyArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FirewallType. 
        /// <para>
        /// The firewall type that the policies in this entry share.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyFirewallType FirewallType
        {
            get { return this._firewallType; }
            set { this._firewallType = value; }
        }

        // Check to see if FirewallType property is set
        internal bool IsSetFirewallType()
        {
            return this._firewallType != null;
        }

        /// <summary>
        /// Gets and sets the property InScopeResourceTypes. 
        /// <para>
        /// The resource types in the deployment's scope that this firewall type protects. This
        /// list is empty if the scope does not select any resource types that the firewall type
        /// protects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<string> InScopeResourceTypes
        {
            get { return this._inScopeResourceTypes; }
            set { this._inScopeResourceTypes = value; }
        }

        // Check to see if InScopeResourceTypes property is set
        internal bool IsSetInScopeResourceTypes()
        {
            return this._inScopeResourceTypes != null && (this._inScopeResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PolicyArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the deployment's policies that have this firewall
        /// type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<string> PolicyArns
        {
            get { return this._policyArns; }
            set { this._policyArns = value; }
        }

        // Check to see if PolicyArns property is set
        internal bool IsSetPolicyArns()
        {
            return this._policyArns != null && (this._policyArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}