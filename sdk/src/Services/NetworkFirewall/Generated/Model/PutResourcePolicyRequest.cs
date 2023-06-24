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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Creates or updates an IAM policy for your rule group or firewall policy. Use this
    /// to share rule groups and firewall policies between accounts. This operation works
    /// in conjunction with the Amazon Web Services Resource Access Manager (RAM) service
    /// to manage resource sharing for Network Firewall. 
    /// 
    ///  
    /// <para>
    /// Use this operation to create or update a resource policy for your rule group or firewall
    /// policy. In the policy, you specify the accounts that you want to share the resource
    /// with and the operations that you want the accounts to be able to perform. 
    /// </para>
    ///  
    /// <para>
    /// When you add an account in the resource policy, you then run the following Resource
    /// Access Manager (RAM) operations to access and accept the shared rule group or firewall
    /// policy. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_GetResourceShareInvitations.html">GetResourceShareInvitations</a>
    /// - Returns the Amazon Resource Names (ARNs) of the resource share invitations. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_AcceptResourceShareInvitation.html">AcceptResourceShareInvitation</a>
    /// - Accepts the share invitation for a specified resource share. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For additional information about resource sharing using RAM, see <a href="https://docs.aws.amazon.com/ram/latest/userguide/what-is.html">Resource
    /// Access Manager User Guide</a>.
    /// </para>
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonNetworkFirewallRequest
    {
        private string _policy;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The IAM policy statement that lists the accounts that you want to share your rule
        /// group or firewall policy with and the operations that you want the accounts to be
        /// able to perform. 
        /// </para>
        ///  
        /// <para>
        /// For a rule group resource, you can specify the following operations in the Actions
        /// section of the statement:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// network-firewall:CreateFirewallPolicy
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// network-firewall:UpdateFirewallPolicy
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// network-firewall:ListRuleGroups
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a firewall policy resource, you can specify the following operations in the Actions
        /// section of the statement:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// network-firewall:AssociateFirewallPolicy
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// network-firewall:ListFirewallPolicies
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In the Resource section of the statement, you specify the ARNs for the rule groups
        /// and firewall policies that you want to share with the account that you specified in
        /// <code>Arn</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=395000)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the account that you want to share rule groups and
        /// firewall policies with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}