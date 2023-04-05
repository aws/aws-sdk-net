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
    /// Port mappings allow containers to access ports on the host container instance to send
    /// or receive traffic. Port mappings are specified as part of the container definition.
    /// 
    ///  
    /// <para>
    /// If you use containers in a task with the <code>awsvpc</code> or <code>host</code>
    /// network mode, specify the exposed ports using <code>containerPort</code>. The <code>hostPort</code>
    /// can be left blank or it must be the same value as the <code>containerPort</code>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't expose the same container port for multiple protocols. If you attempt this,
    /// an error is returned.
    /// </para>
    ///  </note> 
    /// <para>
    /// After a task reaches the <code>RUNNING</code> status, manual and automatic host and
    /// container port assignments are visible in the <code>networkBindings</code> section
    /// of <a>DescribeTasks</a> API responses.
    /// </para>
    /// </summary>
    public partial class PortMapping
    {
        private ApplicationProtocol _appProtocol;
        private int? _containerPort;
        private string _containerPortRange;
        private int? _hostPort;
        private string _name;
        private TransportProtocol _protocol;

        /// <summary>
        /// Gets and sets the property AppProtocol. 
        /// <para>
        /// The application protocol that's used for the port mapping. This parameter only applies
        /// to Service Connect. We recommend that you set this parameter to be consistent with
        /// the protocol that your application uses. If you set this parameter, Amazon ECS adds
        /// protocol-specific connection handling to the Service Connect proxy. If you set this
        /// parameter, Amazon ECS adds protocol-specific telemetry in the Amazon ECS console and
        /// CloudWatch.
        /// </para>
        ///  
        /// <para>
        /// If you don't set a value for this parameter, then TCP is used. However, Amazon ECS
        /// doesn't add protocol-specific telemetry for TCP.
        /// </para>
        ///  
        /// <para>
        /// Tasks that run in a namespace can use short names to connect to services in the namespace.
        /// Tasks can connect to services across all of the clusters in the namespace. Tasks connect
        /// through a managed proxy container that collects logs and metrics for increased visibility.
        /// Only the tasks that Amazon ECS services create are supported with Service Connect.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
        /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public ApplicationProtocol AppProtocol
        {
            get { return this._appProtocol; }
            set { this._appProtocol = value; }
        }

        // Check to see if AppProtocol property is set
        internal bool IsSetAppProtocol()
        {
            return this._appProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerPort. 
        /// <para>
        /// The port number on the container that's bound to the user-specified or automatically
        /// assigned host port.
        /// </para>
        ///  
        /// <para>
        /// If you use containers in a task with the <code>awsvpc</code> or <code>host</code>
        /// network mode, specify the exposed ports using <code>containerPort</code>.
        /// </para>
        ///  
        /// <para>
        /// If you use containers in a task with the <code>bridge</code> network mode and you
        /// specify a container port and not a host port, your container automatically receives
        /// a host port in the ephemeral port range. For more information, see <code>hostPort</code>.
        /// Port mappings that are automatically assigned in this way do not count toward the
        /// 100 reserved ports limit of a container instance.
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
        /// The port number on the container instance to reserve for your container.
        /// </para>
        ///  
        /// <para>
        /// If you specify a <code>containerPortRange</code>, leave this field empty and the value
        /// of the <code>hostPort</code> is set as follows:
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
        /// agent finds open ports on the host and automaticaly binds them to the container ports.
        /// This is a dynamic mapping strategy.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you use containers in a task with the <code>awsvpc</code> or <code>host</code>
        /// network mode, the <code>hostPort</code> can either be left blank or set to the same
        /// value as the <code>containerPort</code>.
        /// </para>
        ///  
        /// <para>
        /// If you use containers in a task with the <code>bridge</code> network mode, you can
        /// specify a non-reserved host port for your container port mapping, or you can omit
        /// the <code>hostPort</code> (or set it to <code>0</code>) while specifying a <code>containerPort</code>
        /// and your container automatically receives a port in the ephemeral port range for your
        /// container instance operating system and Docker version.
        /// </para>
        ///  
        /// <para>
        /// The default ephemeral port range for Docker version 1.6.0 and later is listed on the
        /// instance under <code>/proc/sys/net/ipv4/ip_local_port_range</code>. If this kernel
        /// parameter is unavailable, the default ephemeral port range from 49153 through 65535
        /// is used. Do not attempt to specify a host port in the ephemeral port range as these
        /// are reserved for automatic assignment. In general, ports below 32768 are outside of
        /// the ephemeral port range.
        /// </para>
        ///  
        /// <para>
        /// The default reserved ports are 22 for SSH, the Docker ports 2375 and 2376, and the
        /// Amazon ECS container agent ports 51678-51680. Any host port that was previously specified
        /// in a running task is also reserved while the task is running. That is, after a task
        /// stops, the host port is released. The current reserved ports are displayed in the
        /// <code>remainingResources</code> of <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DescribeContainerInstances.html">DescribeContainerInstances</a>
        /// output. A container instance can have up to 100 reserved ports at a time. This number
        /// includes the default reserved ports. Automatically assigned ports aren't included
        /// in the 100 reserved ports quota.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that's used for the port mapping. This parameter only applies to Service
        /// Connect. This parameter is the name that you use in the <code>serviceConnectConfiguration</code>
        /// of a service. The name can include up to 64 characters. The characters can include
        /// lowercase letters, numbers, underscores (_), and hyphens (-). The name can't start
        /// with a hyphen.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
        /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used for the port mapping. Valid values are <code>tcp</code> and <code>udp</code>.
        /// The default is <code>tcp</code>.
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