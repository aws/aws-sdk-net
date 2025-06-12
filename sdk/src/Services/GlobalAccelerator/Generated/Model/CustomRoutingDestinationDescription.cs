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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
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
    /// For a custom routing accelerator, describes the port range and protocol for all endpoints
    /// (virtual private cloud subnets) in an endpoint group to accept client traffic on.
    /// </summary>
    public partial class CustomRoutingDestinationDescription
    {
        private int? _fromPort;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _toPort;

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// The first port, inclusive, in the range of ports for the endpoint group that is associated
        /// with a custom routing accelerator.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? FromPort
        {
            get { return this._fromPort; }
            set { this._fromPort = value; }
        }

        // Check to see if FromPort property is set
        internal bool IsSetFromPort()
        {
            return this._fromPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocol for the endpoint group that is associated with a custom routing accelerator.
        /// The protocol can be either TCP or UDP.
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
        /// Gets and sets the property ToPort. 
        /// <para>
        /// The last port, inclusive, in the range of ports for the endpoint group that is associated
        /// with a custom routing accelerator.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int? ToPort
        {
            get { return this._toPort; }
            set { this._toPort = value; }
        }

        // Check to see if ToPort property is set
        internal bool IsSetToPort()
        {
            return this._toPort.HasValue; 
        }

    }
}