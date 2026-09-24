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
    /// Data on the status of agent components.
    /// </summary>
    public partial class ComponentStatusData
    {
        /// <summary>
        /// Gets and sets the property BytesReceived. 
        /// <para>
        /// Bytes received by the component.
        /// </para>
        /// </summary>
        public long? BytesReceived { get; set; }

        /// <summary>
        /// Checks to see if the BytesReceived property is set.
        /// </summary>
        internal bool IsSetBytesReceived() => this.BytesReceived.HasValue;

        /// <summary>
        /// Gets and sets the property BytesSent. 
        /// <para>
        /// Bytes sent by the component.
        /// </para>
        /// </summary>
        public long? BytesSent { get; set; }

        /// <summary>
        /// Checks to see if the BytesSent property is set.
        /// </summary>
        internal bool IsSetBytesSent() => this.BytesSent.HasValue;

        /// <summary>
        /// Gets and sets the property CapabilityArn. 
        /// <para>
        /// Capability ARN of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CapabilityArn { get; set; }

        /// <summary>
        /// Checks to see if the CapabilityArn property is set.
        /// </summary>
        internal bool IsSetCapabilityArn() => this.CapabilityArn != null;

        /// <summary>
        /// Gets and sets the property ComponentType. 
        /// <para>
        /// The Component type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ComponentType { get; set; }

        /// <summary>
        /// Checks to see if the ComponentType property is set.
        /// </summary>
        internal bool IsSetComponentType() => this.ComponentType != null;

        /// <summary>
        /// Gets and sets the property DataflowId. 
        /// <para>
        /// Dataflow UUID associated with the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string DataflowId { get; set; }

        /// <summary>
        /// Checks to see if the DataflowId property is set.
        /// </summary>
        internal bool IsSetDataflowId() => this.DataflowId != null;

        /// <summary>
        /// Gets and sets the property PacketsDropped. 
        /// <para>
        /// Packets dropped by component.
        /// </para>
        /// </summary>
        public long? PacketsDropped { get; set; }

        /// <summary>
        /// Checks to see if the PacketsDropped property is set.
        /// </summary>
        internal bool IsSetPacketsDropped() => this.PacketsDropped.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Component status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
