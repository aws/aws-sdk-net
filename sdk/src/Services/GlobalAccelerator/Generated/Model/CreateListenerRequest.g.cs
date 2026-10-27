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

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the CreateListener operation. Create a listener to
    /// process inbound connections from clients to an accelerator. Connections arrive to
    /// assigned static IP addresses on a port, port range, or list of port ranges that you
    /// specify.
    /// </summary>
    public partial class CreateListenerRequest : AmazonGlobalAcceleratorRequest
    {
        /// <summary>
        /// Gets and sets the property AcceleratorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of your accelerator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string AcceleratorArn { get; set; }

        /// <summary>
        /// Checks to see if the AcceleratorArn property is set.
        /// </summary>
        internal bool IsSetAcceleratorArn() => this.AcceleratorArn != null;

        /// <summary>
        /// Gets and sets the property ClientAffinity. 
        /// <para>
        /// Client affinity lets you direct all requests from a user to the same endpoint, if
        /// you have stateful applications, regardless of the port and protocol of the client
        /// request. Client affinity gives you control over whether to always route each client
        /// to the same specific endpoint.
        /// </para>
        ///  
        /// <para>
        /// Global Accelerator uses a consistent-flow hashing algorithm to choose the optimal
        /// endpoint for a connection. If client affinity is <c>NONE</c>, Global Accelerator uses
        /// the "five-tuple" (5-tuple) properties—source IP address, source port, destination
        /// IP address, destination port, and protocol—to select the hash value, and then chooses
        /// the best endpoint. However, with this setting, if someone uses different ports to
        /// connect to Global Accelerator, their connections might not be always routed to the
        /// same endpoint because the hash value changes. 
        /// </para>
        ///  
        /// <para>
        /// If you want a given client to always be routed to the same endpoint, set client affinity
        /// to <c>SOURCE_IP</c> instead. When you use the <c>SOURCE_IP</c> setting, Global Accelerator
        /// uses the "two-tuple" (2-tuple) properties— source (client) IP address and destination
        /// IP address—to select the hash value.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>NONE</c>.
        /// </para>
        /// </summary>
        public ClientAffinity ClientAffinity { get; set; }

        /// <summary>
        /// Checks to see if the ClientAffinity property is set.
        /// </summary>
        internal bool IsSetClientAffinity() => this.ClientAffinity != null;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency—that
        /// is, the uniqueness—of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property PortRanges. 
        /// <para>
        /// The list of port ranges to support for connections from clients to your accelerator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<PortRange> PortRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<PortRange>() : null;

        /// <summary>
        /// Checks to see if the PortRanges property is set.
        /// </summary>
        internal bool IsSetPortRanges() => this.PortRanges != null && (this.PortRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol for connections from clients to your accelerator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;
    }
}
