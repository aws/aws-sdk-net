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
    /// in the container can bind to a port number, making it accessible to inbound traffic
    /// when it's mapped to a container fleet's connection port.
    /// 
    ///  
    /// <para>
    /// Each container port range specifies a network protocol. When the configuration supports
    /// more than one protocol, we recommend that you use a different range for each protocol.
    /// If your ranges have overlapping port numbers, Amazon GameLift Servers maps a duplicated
    /// container port number to different connection ports. For example, if you include 1935
    /// in port ranges for both TCP and UDP, it might result in the following mappings: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// container port 1935 (tcp) =&gt; connection port 2001
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// container port 1935 (udp) =&gt; connection port 2002
    /// </para>
    ///  </li> </ul> 
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
        /// A set of one or more container port number ranges. The ranges can't overlap if the
        /// ranges' network protocols are the same. Overlapping ranges with different protocols
        /// is allowed but not recommended. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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