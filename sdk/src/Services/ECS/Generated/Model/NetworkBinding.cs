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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        private string _containerPortRange;
        private int? _hostPort;
        private string _hostPortRange;
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
        /// The port number on the container that's used with the network binding.
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
        /// Gets and sets the property ContainerPortRange. 
        /// <para>
        /// The port number range on the container that's bound to the dynamically mapped host
        /// port range.
        /// </para>
        ///  
        /// <para>
        /// The following rules apply when you specify a <code>containerPortRange</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must use either the <code>bridge</code> network mode or the <code>awsvpc</code>
        /// network mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This parameter is available for both the EC2 and Fargate launch types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This parameter is available for both the Linux and Windows operating systems.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The container instance must have at least version 1.67.0 of the container agent and
        /// at least version 1.67.0-1 of the <code>ecs-init</code> package 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can specify a maximum of 100 port ranges per container.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You do not specify a <code>hostPortRange</code>. The value of the <code>hostPortRange</code>
        /// is set as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For containers in a task with the <code>awsvpc</code> network mode, the <code>hostPort</code>
        /// is set to the same value as the <code>containerPort</code>. This is a static mapping
        /// strategy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For containers in a task with the <code>bridge</code> network mode, the Amazon ECS
        /// agent finds open host ports from the default ephemeral range and passes it to docker
        /// to bind them to the container ports.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The <code>containerPortRange</code> valid values are between 1 and 65535.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A port can only be included in one port mapping per container.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot specify overlapping port ranges.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first port in the range must be less than last port in the range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Docker recommends that you turn off the docker-proxy in the Docker daemon config file
        /// when you have a large number of ports.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://github.com/moby/moby/issues/11185"> Issue
        /// #11185</a> on the Github website.
        /// </para>
        ///  
        /// <para>
        /// For information about how to turn off the docker-proxy in the Docker daemon config
        /// file, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/bootstrap_container_instance.html#bootstrap_docker_daemon">Docker
        /// daemon</a> in the <i>Amazon ECS Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can call <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DescribeTasks.html">
        /// <code>DescribeTasks</code> </a> to view the <code>hostPortRange</code> which are the
        /// host ports that are bound to the container ports.
        /// </para>
        /// </summary>
        public string ContainerPortRange
        {
            get { return this._containerPortRange; }
            set { this._containerPortRange = value; }
        }

        // Check to see if ContainerPortRange property is set
        internal bool IsSetContainerPortRange()
        {
            return this._containerPortRange != null;
        }

        /// <summary>
        /// Gets and sets the property HostPort. 
        /// <para>
        /// The port number on the host that's used with the network binding.
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
        /// Gets and sets the property HostPortRange. 
        /// <para>
        /// The port number range on the host that's used with the network binding. This is assigned
        /// is assigned by Docker and delivered by the Amazon ECS agent.
        /// </para>
        /// </summary>
        public string HostPortRange
        {
            get { return this._hostPortRange; }
            set { this._hostPortRange = value; }
        }

        // Check to see if HostPortRange property is set
        internal bool IsSetHostPortRange()
        {
            return this._hostPortRange != null;
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