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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Defines the scope a flow operation. You can use up to 20 filters to configure a single
    /// flow operation.
    /// </summary>
    public partial class FlowFilter
    {
        private Address _destinationAddress;
        private string _destinationPort;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Address _sourceAddress;
        private string _sourcePort;

        /// <summary>
        /// Gets and sets the property DestinationAddress.
        /// </summary>
        public Address DestinationAddress
        {
            get { return this._destinationAddress; }
            set { this._destinationAddress = value; }
        }

        // Check to see if DestinationAddress property is set
        internal bool IsSetDestinationAddress()
        {
            return this._destinationAddress != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The destination port to inspect for. You can specify an individual port, for example
        /// <c>1994</c> and you can specify a port range, for example <c>1990:1994</c>. To match
        /// with any port, specify <c>ANY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DestinationPort
        {
            get { return this._destinationPort; }
            set { this._destinationPort = value; }
        }

        // Check to see if DestinationPort property is set
        internal bool IsSetDestinationPort()
        {
            return this._destinationPort != null;
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocols to inspect for, specified using the assigned internet protocol number
        /// (IANA) for each protocol. If not specified, this matches with any protocol.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && (this._protocols.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceAddress.
        /// </summary>
        public Address SourceAddress
        {
            get { return this._sourceAddress; }
            set { this._sourceAddress = value; }
        }

        // Check to see if SourceAddress property is set
        internal bool IsSetSourceAddress()
        {
            return this._sourceAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePort. 
        /// <para>
        /// The source port to inspect for. You can specify an individual port, for example <c>1994</c>
        /// and you can specify a port range, for example <c>1990:1994</c>. To match with any
        /// port, specify <c>ANY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string SourcePort
        {
            get { return this._sourcePort; }
            set { this._sourcePort = value; }
        }

        // Check to see if SourcePort property is set
        internal bool IsSetSourcePort()
        {
            return this._sourcePort != null;
        }

    }
}