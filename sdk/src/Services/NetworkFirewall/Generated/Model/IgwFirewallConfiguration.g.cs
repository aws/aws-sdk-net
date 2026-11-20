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
    /// Contains the settings that configure an internet gateway firewall. An internet gateway
    /// firewall inspects all traffic between your VPC and its internet gateway, without changes
    /// to your subnets or route tables. You can describe and list internet gateway firewalls
    /// in Network Firewall, but you can't create, modify, or delete them directly, because
    /// Amazon Web Services Network Security Manager creates and manages them on your behalf.
    /// </summary>
    public partial class IgwFirewallConfiguration
    {
        /// <summary>
        /// Gets and sets the property EnforcementMode. 
        /// <para>
        /// How the internet gateway firewall enforces its rules. The only supported value is
        /// <c>POLICY_CONTROLLED</c>, which means that the enforcement mode is set by the firewall
        /// policy that Amazon Web Services Network Security Manager associates with the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnforcementMode EnforcementMode { get; set; }

        /// <summary>
        /// Checks to see if the EnforcementMode property is set.
        /// </summary>
        internal bool IsSetEnforcementMode() => this.EnforcementMode != null;
    }
}
