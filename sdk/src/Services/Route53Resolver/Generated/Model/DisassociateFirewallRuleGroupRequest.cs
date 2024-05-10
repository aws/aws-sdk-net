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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateFirewallRuleGroup operation.
    /// Disassociates a <a>FirewallRuleGroup</a> from a VPC, to remove DNS filtering from
    /// the VPC.
    /// </summary>
    public partial class DisassociateFirewallRuleGroupRequest : AmazonRoute53ResolverRequest
    {
        private string _firewallRuleGroupAssociationId;

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupAssociationId. 
        /// <para>
        /// The identifier of the <a>FirewallRuleGroupAssociation</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FirewallRuleGroupAssociationId
        {
            get { return this._firewallRuleGroupAssociationId; }
            set { this._firewallRuleGroupAssociationId = value; }
        }

        // Check to see if FirewallRuleGroupAssociationId property is set
        internal bool IsSetFirewallRuleGroupAssociationId()
        {
            return this._firewallRuleGroupAssociationId != null;
        }

    }
}