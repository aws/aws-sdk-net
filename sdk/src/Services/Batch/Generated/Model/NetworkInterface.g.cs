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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the elastic network interface for a multi-node parallel
    /// job node.
    /// </summary>
    public partial class NetworkInterface
    {
        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The attachment ID for the network interface.
        /// </para>
        /// </summary>
        public string AttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentId property is set.
        /// </summary>
        internal bool IsSetAttachmentId() => this.AttachmentId != null;

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The private IPv6 address for the network interface.
        /// </para>
        /// </summary>
        public string Ipv6Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Address property is set.
        /// </summary>
        internal bool IsSetIpv6Address() => this.Ipv6Address != null;

        /// <summary>
        /// Gets and sets the property PrivateIpv4Address. 
        /// <para>
        /// The private IPv4 address for the network interface.
        /// </para>
        /// </summary>
        public string PrivateIpv4Address { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpv4Address property is set.
        /// </summary>
        internal bool IsSetPrivateIpv4Address() => this.PrivateIpv4Address != null;
    }
}
