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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyTrafficMirrorSession operation.
    /// Modifies a Traffic Mirror session.
    /// </summary>
    public partial class ModifyTrafficMirrorSessionRequest : AmazonEC2Request
    {
        private string _description;
        private int? _packetLength;
        private List<string> _removeFields = new List<string>();
        private int? _sessionNumber;
        private string _trafficMirrorFilterId;
        private string _trafficMirrorSessionId;
        private string _trafficMirrorTargetId;
        private int? _virtualNetworkId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to assign to the Traffic Mirror session.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property PacketLength. 
        /// <para>
        /// The number of bytes in each packet to mirror. These are bytes after the VXLAN header.
        /// To mirror a subset, set this to the length (in bytes) to mirror. For example, if you
        /// set this value to 100, then the first 100 bytes that meet the filter criteria are
        /// copied to the target. Do not specify this parameter when you want to mirror the entire
        /// packet.
        /// </para>
        /// </summary>
        public int PacketLength
        {
            get { return this._packetLength.GetValueOrDefault(); }
            set { this._packetLength = value; }
        }

        // Check to see if PacketLength property is set
        internal bool IsSetPacketLength()
        {
            return this._packetLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveFields. 
        /// <para>
        /// The properties that you want to remove from the Traffic Mirror session.
        /// </para>
        ///  
        /// <para>
        /// When you remove a property from a Traffic Mirror session, the property is set to the
        /// default.
        /// </para>
        /// </summary>
        public List<string> RemoveFields
        {
            get { return this._removeFields; }
            set { this._removeFields = value; }
        }

        // Check to see if RemoveFields property is set
        internal bool IsSetRemoveFields()
        {
            return this._removeFields != null && this._removeFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SessionNumber. 
        /// <para>
        /// The session number determines the order in which sessions are evaluated when an interface
        /// is used by multiple sessions. The first session with a matching filter is the one
        /// that mirrors the packets.
        /// </para>
        ///  
        /// <para>
        /// Valid values are 1-32766.
        /// </para>
        /// </summary>
        public int SessionNumber
        {
            get { return this._sessionNumber.GetValueOrDefault(); }
            set { this._sessionNumber = value; }
        }

        // Check to see if SessionNumber property is set
        internal bool IsSetSessionNumber()
        {
            return this._sessionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrafficMirrorFilterId. 
        /// <para>
        /// The ID of the Traffic Mirror filter.
        /// </para>
        /// </summary>
        public string TrafficMirrorFilterId
        {
            get { return this._trafficMirrorFilterId; }
            set { this._trafficMirrorFilterId = value; }
        }

        // Check to see if TrafficMirrorFilterId property is set
        internal bool IsSetTrafficMirrorFilterId()
        {
            return this._trafficMirrorFilterId != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficMirrorSessionId. 
        /// <para>
        /// The ID of the Traffic Mirror session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrafficMirrorSessionId
        {
            get { return this._trafficMirrorSessionId; }
            set { this._trafficMirrorSessionId = value; }
        }

        // Check to see if TrafficMirrorSessionId property is set
        internal bool IsSetTrafficMirrorSessionId()
        {
            return this._trafficMirrorSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficMirrorTargetId. 
        /// <para>
        /// The Traffic Mirror target. The target must be in the same VPC as the source, or have
        /// a VPC peering connection with the source.
        /// </para>
        /// </summary>
        public string TrafficMirrorTargetId
        {
            get { return this._trafficMirrorTargetId; }
            set { this._trafficMirrorTargetId = value; }
        }

        // Check to see if TrafficMirrorTargetId property is set
        internal bool IsSetTrafficMirrorTargetId()
        {
            return this._trafficMirrorTargetId != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualNetworkId. 
        /// <para>
        /// The virtual network ID of the Traffic Mirror session.
        /// </para>
        /// </summary>
        public int VirtualNetworkId
        {
            get { return this._virtualNetworkId.GetValueOrDefault(); }
            set { this._virtualNetworkId = value; }
        }

        // Check to see if VirtualNetworkId property is set
        internal bool IsSetVirtualNetworkId()
        {
            return this._virtualNetworkId.HasValue; 
        }

    }
}