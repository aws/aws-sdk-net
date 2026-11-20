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
    /// Describes the Automated Internet Firewall that inspects traffic for an internet gateway
    /// or egress-only internet gateway route.
    /// </summary>
    public partial class IgwFirewall
    {
        /// <summary>
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The ARN of the firewall that inspects traffic for this route.
        /// </para>
        /// </summary>
        public string FirewallArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallArn property is set.
        /// </summary>
        internal bool IsSetFirewallArn() => this.FirewallArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the firewall that inspects traffic for this route. Uses the same values
        /// as <c>NetworkFirewallAssociation$firewallOnboardingStatus</c>: <c>active</c>, <c>disabling</c>,
        /// or <c>pending</c>.
        /// </para>
        /// </summary>
        public FirewallOnboardingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
