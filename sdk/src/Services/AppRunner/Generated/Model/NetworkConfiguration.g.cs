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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes configuration settings related to network traffic of an App Runner service.
    /// Consists of embedded objects for each configurable network feature.
    /// </summary>
    public partial class NetworkConfiguration
    {
        /// <summary>
        /// Gets and sets the property EgressConfiguration. 
        /// <para>
        /// Network configuration settings for outbound message traffic.
        /// </para>
        /// </summary>
        public EgressConfiguration EgressConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EgressConfiguration property is set.
        /// </summary>
        internal bool IsSetEgressConfiguration() => this.EgressConfiguration != null;

        /// <summary>
        /// Gets and sets the property IngressConfiguration. 
        /// <para>
        /// Network configuration settings for inbound message traffic.
        /// </para>
        /// </summary>
        public IngressConfiguration IngressConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IngressConfiguration property is set.
        /// </summary>
        internal bool IsSetIngressConfiguration() => this.IngressConfiguration != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// App Runner provides you with the option to choose between <i>IPv4</i> and <i>dual
        /// stack</i> (IPv4 and IPv6). This is an optional parameter. If you do not specify an
        /// <c>IpAddressType</c>, it defaults to select IPv4.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;
    }
}
