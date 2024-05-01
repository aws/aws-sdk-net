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
    /// <b>This data type is used with the Amazon GameLift containers feature, which is currently
    /// in public preview.</b> 
    /// 
    ///  
    /// <para>
    ///  Defines how an internal-facing container port is mapped to an external-facing connection
    /// port on a fleet instance of compute type <c>CONTAINER</c>. Incoming traffic, such
    /// as a game client, uses a connection port to connect to a process in the container
    /// fleet. Amazon GameLift directs the inbound traffic to the container port that is assigned
    /// to the process, such as a game session, running on a container.
    /// </para>
    ///  
    /// <para>
    ///  <b>Part of:</b> <a>ContainerAttributes</a> 
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
        /// The port opened on the fleet instance. This is also called the "host port".
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
        /// The port opened on the container.
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
        /// The network protocol that this mapping supports.
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