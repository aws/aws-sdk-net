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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Defines a Firewall Manager network ACL policy. This is used in the <c>PolicyOption</c>
    /// of a <c>SecurityServicePolicyData</c> for a <c>Policy</c>, when the <c>SecurityServicePolicyData</c>
    /// type is set to <c>NETWORK_ACL_COMMON</c>. 
    /// 
    ///  
    /// <para>
    /// For information about network ACLs, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-network-acls.html">Control
    /// traffic to subnets using network ACLs</a> in the <i>Amazon Virtual Private Cloud User
    /// Guide</i>. 
    /// </para>
    /// </summary>
    public partial class NetworkAclCommonPolicy
    {
        private NetworkAclEntrySet _networkAclEntrySet;

        /// <summary>
        /// Gets and sets the property NetworkAclEntrySet. 
        /// <para>
        /// The definition of the first and last rules for the network ACL policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkAclEntrySet NetworkAclEntrySet
        {
            get { return this._networkAclEntrySet; }
            set { this._networkAclEntrySet = value; }
        }

        // Check to see if NetworkAclEntrySet property is set
        internal bool IsSetNetworkAclEntrySet()
        {
            return this._networkAclEntrySet != null;
        }

    }
}