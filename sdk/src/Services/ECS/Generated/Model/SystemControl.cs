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
    /// A list of namespaced kernel parameters to set in the container. This parameter maps
    /// to <c>Sysctls</c> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
    /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
    /// Remote API</a> and the <c>--sysctl</c> option to <a href="https://docs.docker.com/engine/reference/run/#security-configuration">docker
    /// run</a>.
    /// 
    ///  
    /// <para>
    /// We don't recommend that you specify network-related <c>systemControls</c> parameters
    /// for multiple containers in a single task. This task also uses either the <c>awsvpc</c>
    /// or <c>host</c> network mode. It does it for the following reasons.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For tasks that use the <c>awsvpc</c> network mode, if you set <c>systemControls</c>
    /// for any container, it applies to all containers in the task. If you set different
    /// <c>systemControls</c> for multiple containers in a single task, the container that's
    /// started last determines which <c>systemControls</c> take effect.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For tasks that use the <c>host</c> network mode, the <c>systemControls</c> parameter
    /// applies to the container instance's kernel parameter and that of all containers of
    /// any tasks running on that container instance.
    /// </para>
    ///  </li> </ul>
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
        /// Valid network namespace values: <c>Sysctls</c> that start with <c>"net.*"</c> 
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