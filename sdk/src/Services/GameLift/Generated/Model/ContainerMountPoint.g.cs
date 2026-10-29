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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AccessLevel. 
        /// <para>
        /// The type of access for the container.
        /// </para>
        /// </summary>
        public ContainerMountPointAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Checks to see if the AccessLevel property is set.
        /// </summary>
        internal bool IsSetAccessLevel() => this.AccessLevel != null;

        /// <summary>
        /// Gets and sets the property ContainerPath. 
        /// <para>
        /// The mount path on the container. If this property isn't set, the instance path is
        /// used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ContainerPath { get; set; }

        /// <summary>
        /// Checks to see if the ContainerPath property is set.
        /// </summary>
        internal bool IsSetContainerPath() => this.ContainerPath != null;

        /// <summary>
        /// Gets and sets the property InstancePath. 
        /// <para>
        /// The path to the source file or directory. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string InstancePath { get; set; }

        /// <summary>
        /// Checks to see if the InstancePath property is set.
        /// </summary>
        internal bool IsSetInstancePath() => this.InstancePath != null;
    }
}
