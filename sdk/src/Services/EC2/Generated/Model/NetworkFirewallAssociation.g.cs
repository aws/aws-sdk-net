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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an Automated Internet Firewall that inspects traffic between a VPC and its
    /// internet gateway or egress-only internet gateway.
    /// </summary>
    public partial class NetworkFirewallAssociation
    {
        /// <summary>
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall.
        /// </para>
        /// </summary>
        public string FirewallArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallArn property is set.
        /// </summary>
        internal bool IsSetFirewallArn() => this.FirewallArn != null;

        /// <summary>
        /// Gets and sets the property FirewallMode. 
        /// <para>
        /// The mode of the firewall. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>enforce</c>: The firewall applies its policy to traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>monitor</c>: The firewall logs traffic that its policy would act on, but doesn't
        /// block it.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FirewallMode FirewallMode { get; set; }

        /// <summary>
        /// Checks to see if the FirewallMode property is set.
        /// </summary>
        internal bool IsSetFirewallMode() => this.FirewallMode != null;

        /// <summary>
        /// Gets and sets the property FirewallOnboardingStatus. 
        /// <para>
        /// The status of the firewall for the VPC. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>active</c>: The firewall inspects traffic for the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disabling</c>: AWS is removing the firewall from the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c>: AWS is setting up the firewall for the VPC. The firewall might not
        /// inspect traffic yet.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FirewallOnboardingStatus FirewallOnboardingStatus { get; set; }

        /// <summary>
        /// Checks to see if the FirewallOnboardingStatus property is set.
        /// </summary>
        internal bool IsSetFirewallOnboardingStatus() => this.FirewallOnboardingStatus != null;
    }
}
