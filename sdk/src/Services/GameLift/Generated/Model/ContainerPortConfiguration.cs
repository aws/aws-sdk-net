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
    /// A set of port ranges that can be opened on the container. A process that's running
    /// in the container can bind to a port number, making it accessible to inbound traffic.
    /// Container ports map to a container fleet's connection ports. 
    /// 
    ///  
    /// <para>
    ///  <b>Part of:</b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameServerContainerDefinition.html">GameServerContainerDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameServerContainerDefinitionInput.html">GameServerContainerDefinitionInput</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_SupportContainerDefinition.html">SupportContainerDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_SupportContainerDefinitionInput.html">SupportContainerDefinitionInput</a>
    /// 
    /// </para>
    /// </summary>
    public partial class ContainerPortConfiguration
    {
        private List<ContainerPortRange> _containerPortRanges = AWSConfigs.InitializeCollections ? new List<ContainerPortRange>() : null;

        /// <summary>
        /// Gets and sets the property ContainerPortRanges. 
        /// <para>
        /// A set of one or more container port number ranges. The ranges can't overlap. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<ContainerPortRange> ContainerPortRanges
        {
            get { return this._containerPortRanges; }
            set { this._containerPortRanges = value; }
        }

        // Check to see if ContainerPortRanges property is set
        internal bool IsSetContainerPortRanges()
        {
            return this._containerPortRanges != null && (this._containerPortRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}