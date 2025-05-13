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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ECS.Model
{
    /// <summary>
    /// A list of namespaced kernel parameters to set in the container. This parameter maps
    /// to <c>Sysctls</c> in the docker container create command and the <c>--sysctl</c> option
    /// to docker run. For example, you can configure <c>net.ipv4.tcp_keepalive_time</c> setting
    /// to maintain longer lived connections.
    /// 
    ///  
    /// <para>
    /// We don't recommend that you specify network-related <c>systemControls</c> parameters
    /// for multiple containers in a single task that also uses either the <c>awsvpc</c> or
    /// <c>host</c> network mode. Doing this has the following disadvantages:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For tasks that use the <c>awsvpc</c> network mode including Fargate, if you set <c>systemControls</c>
    /// for any container, it applies to all containers in the task. If you set different
    /// <c>systemControls</c> for multiple containers in a single task, the container that's
    /// started last determines which <c>systemControls</c> take effect.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For tasks that use the <c>host</c> network mode, the network namespace <c>systemControls</c>
    /// aren't supported.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you're setting an IPC resource namespace to use for the containers in the task,
    /// the following conditions apply to your system controls. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_definition_parameters.html#task_definition_ipcmode">IPC
    /// mode</a>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For tasks that use the <c>host</c> IPC mode, IPC namespace <c>systemControls</c> aren't
    /// supported.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For tasks that use the <c>task</c> IPC mode, IPC namespace <c>systemControls</c> values
    /// apply to all containers within a task.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// This parameter is not supported for Windows containers.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// This parameter is only supported for tasks that are hosted on Fargate if the tasks
    /// are using platform version <c>1.4.0</c> or later (Linux). This isn't supported for
    /// Windows containers on Fargate.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SystemControl
    {
        private string _awsNamespace;
        private string _value;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespaced kernel parameter to set a <c>value</c> for.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The namespaced kernel parameter to set a <c>value</c> for.
        /// </para>
        ///  
        /// <para>
        /// Valid IPC namespace values: <c>"kernel.msgmax" | "kernel.msgmnb" | "kernel.msgmni"
        /// | "kernel.sem" | "kernel.shmall" | "kernel.shmmax" | "kernel.shmmni" | "kernel.shm_rmid_forced"</c>,
        /// and <c>Sysctls</c> that start with <c>"fs.mqueue.*"</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid network namespace values: <c>Sysctls</c> that start with <c>"net.*"</c>. Only
        /// namespaced <c>Sysctls</c> that exist within the container starting with "net.* are
        /// accepted.
        /// </para>
        ///  
        /// <para>
        /// All of these values are supported by Fargate.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}