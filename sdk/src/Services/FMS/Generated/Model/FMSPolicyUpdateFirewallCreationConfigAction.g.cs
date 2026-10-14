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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Contains information about the actions that you can take to remediate scope violations
    /// caused by your policy's <c>FirewallCreationConfig</c>. <c>FirewallCreationConfig</c>
    /// is an optional configuration that you can use to choose which Availability Zones Firewall
    /// Manager creates Network Firewall endpoints in.
    /// </summary>
    public partial class FMSPolicyUpdateFirewallCreationConfigAction
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes the remedial action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FirewallCreationConfig. 
        /// <para>
        /// A <c>FirewallCreationConfig</c> that you can copy into your current policy's <a href="https://docs.aws.amazon.com/fms/2018-01-01/APIReference/API_SecurityServicePolicyData.html">SecurityServiceData</a>
        /// in order to remedy scope violations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 30000)]
        public string FirewallCreationConfig { get; set; }

        /// <summary>
        /// Checks to see if the FirewallCreationConfig property is set.
        /// </summary>
        internal bool IsSetFirewallCreationConfig() => this.FirewallCreationConfig != null;
    }
}
