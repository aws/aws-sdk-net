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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the ports that network activity involved. A port value
    /// can be a single port, a range such as <c>51000-51010</c>, or a comma-separated list
    /// such as <c>443,8080</c>.
    /// </summary>
    public partial class NetworkPorts
    {
        /// <summary>
        /// Gets and sets the property PortCount. 
        /// <para>
        /// The number of ports that the activity involved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? PortCount { get; set; }

        /// <summary>
        /// Checks to see if the PortCount property is set.
        /// </summary>
        internal bool IsSetPortCount() => this.PortCount.HasValue;

        /// <summary>
        /// Gets and sets the property Ports. 
        /// <para>
        /// The ports that the activity involved.
        /// </para>
        /// </summary>
        public string Ports { get; set; }

        /// <summary>
        /// Checks to see if the Ports property is set.
        /// </summary>
        internal bool IsSetPorts() => this.Ports != null;

        /// <summary>
        /// Gets and sets the property PortsUsed. 
        /// <para>
        /// The ports that the activity used.
        /// </para>
        /// </summary>
        public string PortsUsed { get; set; }

        /// <summary>
        /// Checks to see if the PortsUsed property is set.
        /// </summary>
        internal bool IsSetPortsUsed() => this.PortsUsed != null;

        /// <summary>
        /// Gets and sets the property RemotePort. 
        /// <para>
        /// The port on the remote host.
        /// </para>
        /// </summary>
        public string RemotePort { get; set; }

        /// <summary>
        /// Checks to see if the RemotePort property is set.
        /// </summary>
        internal bool IsSetRemotePort() => this.RemotePort != null;

        /// <summary>
        /// Gets and sets the property ResolverPort. 
        /// <para>
        /// The port of the DNS resolver.
        /// </para>
        /// </summary>
        public string ResolverPort { get; set; }

        /// <summary>
        /// Checks to see if the ResolverPort property is set.
        /// </summary>
        internal bool IsSetResolverPort() => this.ResolverPort != null;

        /// <summary>
        /// Gets and sets the property TargetPort. 
        /// <para>
        /// The port on the target of the activity.
        /// </para>
        /// </summary>
        public string TargetPort { get; set; }

        /// <summary>
        /// Checks to see if the TargetPort property is set.
        /// </summary>
        internal bool IsSetTargetPort() => this.TargetPort != null;
    }
}
