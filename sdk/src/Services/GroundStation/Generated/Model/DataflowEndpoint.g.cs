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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Information about a dataflow endpoint.
    /// </summary>
    public partial class DataflowEndpoint
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// Socket address of a dataflow endpoint.
        /// </para>
        /// </summary>
        public SocketAddress Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property Mtu. 
        /// <para>
        /// Maximum transmission unit (MTU) size in bytes of a dataflow endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1400, Max = 1500)]
        public int? Mtu { get; set; }

        /// <summary>
        /// Checks to see if the Mtu property is set.
        /// </summary>
        internal bool IsSetMtu() => this.Mtu.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of a dataflow endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of a dataflow endpoint.
        /// </para>
        /// </summary>
        public EndpointStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
