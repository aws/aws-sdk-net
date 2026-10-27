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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DeleteFirewall operation. Deletes the specified
    /// <a>Firewall</a> and its <a>FirewallStatus</a>. This operation requires the firewall's
    /// <c>DeleteProtection</c> flag to be <c>FALSE</c>. You can't revert this operation.
    /// <para> You can check whether a firewall is in use by reviewing the route tables for
    /// the Availability Zones where you have firewall subnet mappings. Retrieve the subnet
    /// mappings by calling <a>DescribeFirewall</a>. You define and update the route tables
    /// through Amazon VPC. As needed, update the route tables for the zones to remove the
    /// firewall endpoints. When the route tables no longer use the firewall endpoints, you
    /// can remove the firewall safely. </para> <para> To delete a firewall, remove the delete
    /// protection if you need to using <a>UpdateFirewallDeleteProtection</a>, then delete
    /// the firewall by calling <a>DeleteFirewall</a>. </para>
    /// </summary>
    public partial class DeleteFirewallRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FirewallArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallArn property is set.
        /// </summary>
        internal bool IsSetFirewallArn() => this.FirewallArn != null;

        /// <summary>
        /// Gets and sets the property FirewallName. 
        /// <para>
        /// The descriptive name of the firewall. You can't change the name of a firewall after
        /// you create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FirewallName { get; set; }

        /// <summary>
        /// Checks to see if the FirewallName property is set.
        /// </summary>
        internal bool IsSetFirewallName() => this.FirewallName != null;
    }
}
