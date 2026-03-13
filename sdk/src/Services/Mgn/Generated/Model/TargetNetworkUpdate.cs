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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Updated configuration for the target network topology and addressing.
    /// </summary>
    public partial class TargetNetworkUpdate
    {
        private string _inboundCidr;
        private string _inspectionCidr;
        private string _outboundCidr;
        private TargetNetworkTopology _topology;

        /// <summary>
        /// Gets and sets the property InboundCidr. 
        /// <para>
        /// The updated CIDR block for inbound traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=18)]
        public string InboundCidr
        {
            get { return this._inboundCidr; }
            set { this._inboundCidr = value; }
        }

        // Check to see if InboundCidr property is set
        internal bool IsSetInboundCidr()
        {
            return this._inboundCidr != null;
        }

        /// <summary>
        /// Gets and sets the property InspectionCidr. 
        /// <para>
        /// The updated CIDR block for inspection traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=18)]
        public string InspectionCidr
        {
            get { return this._inspectionCidr; }
            set { this._inspectionCidr = value; }
        }

        // Check to see if InspectionCidr property is set
        internal bool IsSetInspectionCidr()
        {
            return this._inspectionCidr != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundCidr. 
        /// <para>
        /// The updated CIDR block for outbound traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=18)]
        public string OutboundCidr
        {
            get { return this._outboundCidr; }
            set { this._outboundCidr = value; }
        }

        // Check to see if OutboundCidr property is set
        internal bool IsSetOutboundCidr()
        {
            return this._outboundCidr != null;
        }

        /// <summary>
        /// Gets and sets the property Topology. 
        /// <para>
        /// The updated network topology type.
        /// </para>
        /// </summary>
        public TargetNetworkTopology Topology
        {
            get { return this._topology; }
            set { this._topology = value; }
        }

        // Check to see if Topology property is set
        internal bool IsSetTopology()
        {
            return this._topology != null;
        }

    }
}