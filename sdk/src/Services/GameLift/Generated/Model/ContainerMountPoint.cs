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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// A mount point that binds a container to a file or directory on the host system. 
    /// 
    ///  
    /// <para>
    ///  <b>Part of:</b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameServerContainerDefinition.html">GameServerContainerDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameServerContainerDefinitionInput.html">https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameServerContainerDefinitionInput.html</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_SupportContainerDefinition.html">SupportContainerDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_SupportContainerDefinitionInput.html">https://docs.aws.amazon.com/gamelift/latest/apireference/API_SupportContainerDefinitionInput.html</a>
    /// 
    /// </para>
    /// </summary>
    public partial class ContainerMountPoint
    {
        private ContainerMountPointAccessLevel _accessLevel;
        private string _containerPath;
        private string _instancePath;

        /// <summary>
        /// Gets and sets the property AccessLevel. 
        /// <para>
        /// The type of access for the container.
        /// </para>
        /// </summary>
        public ContainerMountPointAccessLevel AccessLevel
        {
            get { return this._accessLevel; }
            set { this._accessLevel = value; }
        }

        // Check to see if AccessLevel property is set
        internal bool IsSetAccessLevel()
        {
            return this._accessLevel != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerPath. 
        /// <para>
        /// The mount path on the container. If this property isn't set, the instance path is
        /// used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property InstancePath. 
        /// <para>
        /// The path to the source file or directory. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string InstancePath
        {
            get { return this._instancePath; }
            set { this._instancePath = value; }
        }

        // Check to see if InstancePath property is set
        internal bool IsSetInstancePath()
        {
            return this._instancePath != null;
        }

    }
}