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
    /// This parameter is specified when you're using Docker volumes. Docker volumes are only
    /// supported when you're using the EC2 launch type. Windows containers only support the
    /// use of the <c>local</c> driver. To use bind mounts, specify a <c>host</c> instead.
    /// </summary>
    public partial class DockerVolumeConfiguration
    {
        private bool? _autoprovision;
        private string _driver;
        private Dictionary<string, string> _driverOpts = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _labels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property Autoprovision. 
        /// <para>
        /// If this value is <c>true</c>, the Docker volume is created if it doesn't already exist.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is only used if the <c>scope</c> is <c>shared</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? Autoprovision
        {
            get { return this._autoprovision; }
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
        /// the Docker plugin CLI, use <c>docker plugin ls</c> to retrieve the driver name from
        /// your container instance. If the driver was installed using another method, use Docker
        /// plugin discovery to retrieve the driver name. This parameter maps to <c>Driver</c>
        /// in the docker container create command and the <c>xxdriver</c> option to docker volume
        /// create.
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
        /// A map of Docker driver-specific options passed through. This parameter maps to <c>DriverOpts</c>
        /// in the docker create-volume command and the <c>xxopt</c> option to docker volume create.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DriverOpts
        {
            get { return this._driverOpts; }
            set { this._driverOpts = value; }
        }

        // Check to see if DriverOpts property is set
        internal bool IsSetDriverOpts()
        {
            return this._driverOpts != null && (this._driverOpts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// Custom metadata to add to your Docker volume. This parameter maps to <c>Labels</c>
        /// in the docker container create command and the <c>xxlabel</c> option to docker volume
        /// create.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope for the Docker volume that determines its lifecycle. Docker volumes that
        /// are scoped to a <c>task</c> are automatically provisioned when the task starts and
        /// destroyed when the task stops. Docker volumes that are scoped as <c>shared</c> persist
        /// after the task stops.
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