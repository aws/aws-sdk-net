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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// A range of IP addresses and port settings that allow inbound traffic to connect to
    /// processes on an instance in a fleet. Processes are assigned an IP address/port number
    /// combination, which must fall into the fleet's allowed ranges. 
    /// 
    ///  
    /// <para>
    /// For Amazon GameLift Servers Realtime fleets, Amazon GameLift Servers automatically
    /// opens two port ranges, one for TCP messaging and one for UDP.
    /// </para>
    /// </summary>
    public partial class IpPermission
    {
        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// A starting value for a range of allowed port numbers.
        /// </para>
        ///  
        /// <para>
        /// For fleets using Linux builds, only ports <c>22</c> and <c>1026-60000</c> are valid.
        /// </para>
        ///  
        /// <para>
        /// For fleets using Windows builds, only ports <c>1026-60000</c> are valid.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 60000)]
        public int? FromPort { get; set; }

        /// <summary>
        /// Checks to see if the FromPort property is set.
        /// </summary>
        internal bool IsSetFromPort() => this.FromPort.HasValue;

        /// <summary>
        /// Gets and sets the property IpRange. 
        /// <para>
        /// A range of allowed IP addresses. This value must be expressed in CIDR notation. Example:
        /// "<c>000.000.000.000/[subnet mask]</c>" or optionally the shortened version "<c>0.0.0.0/[subnet
        /// mask]</c>".
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string IpRange { get; set; }

        /// <summary>
        /// Checks to see if the IpRange property is set.
        /// </summary>
        internal bool IsSetIpRange() => this.IpRange != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The network communication protocol used by the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IpProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// An ending value for a range of allowed port numbers. Port numbers are end-inclusive.
        /// This value must be equal to or greater than <c>FromPort</c>.
        /// </para>
        ///  
        /// <para>
        /// For fleets using Linux builds, only ports <c>22</c> and <c>1026-60000</c> are valid.
        /// </para>
        ///  
        /// <para>
        /// For fleets using Windows builds, only ports <c>1026-60000</c> are valid.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 60000)]
        public int? ToPort { get; set; }

        /// <summary>
        /// Checks to see if the ToPort property is set.
        /// </summary>
        internal bool IsSetToPort() => this.ToPort.HasValue;
    }
}
