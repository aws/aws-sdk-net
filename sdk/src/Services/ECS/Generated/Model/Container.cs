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
    /// A Docker container that is part of a task.
    /// </summary>
    public partial class Container
    {
        private string _containerArn;
        private int? _exitCode;
        private HealthStatus _healthStatus;
        private string _lastStatus;
        private string _name;
        private List<NetworkBinding> _networkBindings = new List<NetworkBinding>();
        private List<NetworkInterface> _networkInterfaces = new List<NetworkInterface>();
        private string _reason;
        private string _taskArn;

        /// <summary>
        /// Gets and sets the property ContainerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container.
        /// </para>
        /// </summary>
        public string ContainerArn
        {
            get { return this._containerArn; }
            set { this._containerArn = value; }
        }

        // Check to see if ContainerArn property is set
        internal bool IsSetContainerArn()
        {
            return this._containerArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExitCode. 
        /// <para>
        /// The exit code returned from the container.
        /// </para>
        /// </summary>
        public int ExitCode
        {
            get { return this._exitCode.GetValueOrDefault(); }
            set { this._exitCode = value; }
        }

        // Check to see if ExitCode property is set
        internal bool IsSetExitCode()
        {
            return this._exitCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status of the container. If health checks are not configured for this container
        /// in its task definition, then it reports health status as <code>UNKNOWN</code>.
        /// </para>
        /// </summary>
        public HealthStatus HealthStatus
        {
            get { return this._healthStatus; }
            set { this._healthStatus = value; }
        }

        // Check to see if HealthStatus property is set
        internal bool IsSetHealthStatus()
        {
            return this._healthStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// The last known status of the container.
        /// </para>
        /// </summary>
        public string LastStatus
        {
            get { return this._lastStatus; }
            set { this._lastStatus = value; }
        }

        // Check to see if LastStatus property is set
        internal bool IsSetLastStatus()
        {
            return this._lastStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container.
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
        /// Gets and sets the property NetworkBindings. 
        /// <para>
        /// The network bindings associated with the container.
        /// </para>
        /// </summary>
        public List<NetworkBinding> NetworkBindings
        {
            get { return this._networkBindings; }
            set { this._networkBindings = value; }
        }

        // Check to see if NetworkBindings property is set
        internal bool IsSetNetworkBindings()
        {
            return this._networkBindings != null && this._networkBindings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The network interfaces associated with the container.
        /// </para>
        /// </summary>
        public List<NetworkInterface> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && this._networkInterfaces.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A short (255 max characters) human-readable string to provide additional details about
        /// a running or stopped container.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The ARN of the task.
        /// </para>
        /// </summary>
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

    }
}