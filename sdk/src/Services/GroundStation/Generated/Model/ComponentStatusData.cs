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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Data on the status of agent components.
    /// </summary>
    public partial class ComponentStatusData
    {
        private long? _bytesReceived;
        private long? _bytesSent;
        private string _capabilityArn;
        private ComponentType _componentType;
        private string _dataflowId;
        private long? _packetsDropped;
        private AgentStatus _status;

        /// <summary>
        /// Gets and sets the property BytesReceived. 
        /// <para>
        /// Bytes received by the component.
        /// </para>
        /// </summary>
        public long BytesReceived
        {
            get { return this._bytesReceived.GetValueOrDefault(); }
            set { this._bytesReceived = value; }
        }

        // Check to see if BytesReceived property is set
        internal bool IsSetBytesReceived()
        {
            return this._bytesReceived.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BytesSent. 
        /// <para>
        /// Bytes sent by the component.
        /// </para>
        /// </summary>
        public long BytesSent
        {
            get { return this._bytesSent.GetValueOrDefault(); }
            set { this._bytesSent = value; }
        }

        // Check to see if BytesSent property is set
        internal bool IsSetBytesSent()
        {
            return this._bytesSent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapabilityArn. 
        /// <para>
        /// Capability ARN of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapabilityArn
        {
            get { return this._capabilityArn; }
            set { this._capabilityArn = value; }
        }

        // Check to see if CapabilityArn property is set
        internal bool IsSetCapabilityArn()
        {
            return this._capabilityArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentType. 
        /// <para>
        /// The Component type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComponentType ComponentType
        {
            get { return this._componentType; }
            set { this._componentType = value; }
        }

        // Check to see if ComponentType property is set
        internal bool IsSetComponentType()
        {
            return this._componentType != null;
        }

        /// <summary>
        /// Gets and sets the property DataflowId. 
        /// <para>
        /// Dataflow UUID associated with the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string DataflowId
        {
            get { return this._dataflowId; }
            set { this._dataflowId = value; }
        }

        // Check to see if DataflowId property is set
        internal bool IsSetDataflowId()
        {
            return this._dataflowId != null;
        }

        /// <summary>
        /// Gets and sets the property PacketsDropped. 
        /// <para>
        /// Packets dropped by component.
        /// </para>
        /// </summary>
        public long PacketsDropped
        {
            get { return this._packetsDropped.GetValueOrDefault(); }
            set { this._packetsDropped = value; }
        }

        // Check to see if PacketsDropped property is set
        internal bool IsSetPacketsDropped()
        {
            return this._packetsDropped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Component status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}