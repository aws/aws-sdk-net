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
    /// This parameter is specified when you are using Docker volumes. Docker volumes are
    /// only supported when you are using the EC2 launch type. Windows containers only support
    /// the use of the <code>local</code> driver. To use bind mounts, specify a <code>host</code>
    /// instead.
    /// </summary>
    public partial class DockerVolumeConfiguration
    {
        private bool? _autoprovision;
        private string _driver;
        private Dictionary<string, string> _driverOpts = new Dictionary<string, string>();
        private Dictionary<string, string> _labels = new Dictionary<string, string>();
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property Autoprovision. 
        /// <para>
        /// If this value is <code>true</code>, the Docker volume is created if it does not already
        /// exist.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is only used if the <code>scope</code> is <code>shared</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool Autoprovision
        {
            get { return this._autoprovision.GetValueOrDefault(); }
            set { this._autoprovision = value; }
        }

        // Check to see if Autoprovision property is set
        internal bool IsSetAutoprovision()
        {
            return this._autoprovision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Driver. 
        /// <para>
        /// The Docker volume driver to use. The driver value must match the driver name provided
        /// by Docker because it is used for task placement. If the driver was installed using
        /// the Docker plugin CLI, use <code>docker plugin ls</code> to retrieve the driver name
        /// from your container instance. If the driver was installed using another method, use
        /// Docker plugin discovery to retrieve the driver name. For more information, see <a
        /// href="https://docs.docker.com/engine/extend/plugin_api/#plugin-discovery">Docker plugin
        /// discovery</a>. This parameter maps to <code>Driver</code> in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/VolumeCreate">Create
        /// a volume</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>xxdriver</code> option to <a href="https://docs.docker.com/engine/reference/commandline/volume_create/">
        /// <code>docker volume create</code> </a>.
        /// </para>
        /// </summary>
        public string Driver
        {
            get { return this._driver; }
            set { this._driver = value; }
        }

        // Check to see if Driver property is set
        internal bool IsSetDriver()
        {
            return this._driver != null;
        }

        /// <summary>
        /// Gets and sets the property DriverOpts. 
        /// <para>
        /// A map of Docker driver-specific options passed through. This parameter maps to <code>DriverOpts</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/VolumeCreate">Create
        /// a volume</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>xxopt</code> option to <a href="https://docs.docker.com/engine/reference/commandline/volume_create/">
        /// <code>docker volume create</code> </a>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> DriverOpts
        {
            get { return this._driverOpts; }
            set { this._driverOpts = value; }
        }

        // Check to see if DriverOpts property is set
        internal bool IsSetDriverOpts()
        {
            return this._driverOpts != null && this._driverOpts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// Custom metadata to add to your Docker volume. This parameter maps to <code>Labels</code>
        /// in the <a href="https://docs.docker.com/engine/api/v1.35/#operation/VolumeCreate">Create
        /// a volume</a> section of the <a href="https://docs.docker.com/engine/api/v1.35/">Docker
        /// Remote API</a> and the <code>xxlabel</code> option to <a href="https://docs.docker.com/engine/reference/commandline/volume_create/">
        /// <code>docker volume create</code> </a>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && this._labels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope for the Docker volume that determines its lifecycle. Docker volumes that
        /// are scoped to a <code>task</code> are automatically provisioned when the task starts
        /// and destroyed when the task stops. Docker volumes that are scoped as <code>shared</code>
        /// persist after the task stops.
        /// </para>
        /// </summary>
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}