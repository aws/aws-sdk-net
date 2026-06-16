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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Describes a mapping between a container port and a connection port on a fleet instance.
    /// You define container ports in a container group definition. Amazon GameLift Servers
    /// assigns connection ports when it deploys the container group to an instance.
    /// 
    ///  
    /// <para>
    ///  <b>Part of:</b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ContainerGroupPortMapping.html">ContainerGroupPortMapping</a>
    /// 
    /// </para>
    /// </summary>
    public partial class ContainerPortMapping
    {
        private int? _connectionPort;
        private int? _containerPort;
        private IpProtocol _protocol;

        /// <summary>
        /// Gets and sets the property ConnectionPort. 
        /// <para>
        /// The port number on the fleet instance that maps to the container port. Connection
        /// ports are assigned by Amazon GameLift Servers when the container group is deployed
        /// to an instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=60000)]
        public int? ConnectionPort
        {
            get { return this._connectionPort; }
            set { this._connectionPort = value; }
        }

        // Check to see if ConnectionPort property is set
        internal bool IsSetConnectionPort()
        {
            return this._connectionPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContainerPort. 
        /// <para>
        /// The port number on the container. This port is defined in the container group definition.
        /// Container port numbers must be unique within a container group definition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=60000)]
        public int? ContainerPort
        {
            get { return this._containerPort; }
            set { this._containerPort = value; }
        }

        // Check to see if ContainerPort property is set
        internal bool IsSetContainerPort()
        {
            return this._containerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The network protocol for the port mapping. Valid values are <c>TCP</c> or <c>UDP</c>.
        /// </para>
        /// </summary>
        public IpProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

    }
}