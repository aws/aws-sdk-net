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
    /// An object representing a container instance host device.
    /// </summary>
    public partial class Device
    {
        private string _containerPath;
        private string _hostPath;
        private List<string> _permissions = new List<string>();

        /// <summary>
        /// Gets and sets the property ContainerPath. 
        /// <para>
        /// The path inside the container at which to expose the host device.
        /// </para>
        /// </summary>
        public string ContainerPath
        {
            get { return this._containerPath; }
            set { this._containerPath = value; }
        }

        // Check to see if ContainerPath property is set
        internal bool IsSetContainerPath()
        {
            return this._containerPath != null;
        }

        /// <summary>
        /// Gets and sets the property HostPath. 
        /// <para>
        /// The path for the device on the host container instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HostPath
        {
            get { return this._hostPath; }
            set { this._hostPath = value; }
        }

        // Check to see if HostPath property is set
        internal bool IsSetHostPath()
        {
            return this._hostPath != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The explicit permissions to provide to the container for the device. By default, the
        /// container has permissions for <code>read</code>, <code>write</code>, and <code>mknod</code>
        /// for the device.
        /// </para>
        /// </summary>
        public List<string> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

    }
}