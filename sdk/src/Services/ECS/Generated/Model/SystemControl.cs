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
    /// A list of namespaced kernel parameters to set in the container. This parameter maps
    /// to <code>Sysctls</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/ContainerCreate">Create
    /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
    /// Remote API</a> and the <code>--sysctl</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
    /// run</a>.
    /// 
    ///  <note> 
    /// <para>
    /// It is not recommended that you specify network-related <code>systemControls</code>
    /// parameters for multiple containers in a single task that also uses either the <code>awsvpc</code>
    /// or <code>host</code> network modes. When you do, the container that is started last
    /// will determine which <code>systemControls</code> parameters take effect.
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
        /// The namespaced kernel parameter to set a <code>value</code> for.
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
        /// The value for the namespaced kernel parameter specifed in <code>namespace</code>.
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