/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Details on the network bindings between a container and its host container instance.
    /// After a task reaches the <code>RUNNING</code> status, manual and automatic host and
    /// container port assignments are visible in the <code>networkBindings</code> section
    /// of <a>DescribeTasks</a> API responses.
    /// </summary>
    public partial class NetworkBinding
    {
        private string _bindip;
        private int? _containerPort;
        private int? _hostPort;
        private TransportProtocol _protocol;

        /// <summary>
        /// Gets and sets the property BindIP. 
        /// <para>
        /// The IP address that the container is bound to on the container instance.
        /// </para>
        /// </summary>
        public string BindIP
        {
            get { return this._bindip; }
            set { this._bindip = value; }
        }

        // Check to see if BindIP property is set
        internal bool IsSetBindIP()
        {
            return this._bindip != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerPort. 
        /// <para>
        /// The port number on the container that is used with the network binding.
        /// </para>
        /// </summary>
        public int ContainerPort
        {
            get { return this._containerPort.GetValueOrDefault(); }
            set { this._containerPort = value; }
        }

        // Check to see if ContainerPort property is set
        internal bool IsSetContainerPort()
        {
            return this._containerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostPort. 
        /// <para>
        /// The port number on the host that is used with the network binding.
        /// </para>
        /// </summary>
        public int HostPort
        {
            get { return this._hostPort.GetValueOrDefault(); }
            set { this._hostPort = value; }
        }

        // Check to see if HostPort property is set
        internal bool IsSetHostPort()
        {
            return this._hostPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used for the network binding.
        /// </para>
        /// </summary>
        public TransportProtocol Protocol
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