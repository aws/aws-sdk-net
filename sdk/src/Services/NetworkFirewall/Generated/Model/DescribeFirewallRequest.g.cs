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
    /// Container for the parameters to the DescribeFirewall operation. Returns the data objects
    /// for the specified firewall.
    /// </summary>
    public partial class DescribeFirewallRequest : AmazonNetworkFirewallRequest
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

        /// <summary>
        /// Gets and sets the property FirewallType. 
        /// <para>
        /// The type of firewall that the request targets. Network Firewall supports the following
        /// firewall types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IGW_FIREWALL</c> - An internet gateway firewall, which Amazon Web Services Network
        /// Security Manager creates and manages for a VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FIREWALL</c> - A standard Network Firewall firewall.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify the firewall ARN, the type must match the resource type in the ARN.
        /// If you specify only the firewall name, Network Firewall uses this value to identify
        /// the firewall. If you don't specify a type, the default is <c>FIREWALL</c>.
        /// </para>
        /// </summary>
        public FirewallType FirewallType { get; set; }

        /// <summary>
        /// Checks to see if the FirewallType property is set.
        /// </summary>
        internal bool IsSetFirewallType() => this.FirewallType != null;
    }
}
