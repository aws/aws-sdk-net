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
    /// <b>This data type is used with the Amazon GameLift containers feature, which is currently
    /// in public preview.</b> 
    /// 
    ///  
    /// <para>
    /// Describes attributes of containers that are deployed to a fleet with compute type
    /// <c>CONTAINER</c>. 
    /// </para>
    /// </summary>
    public partial class ContainerAttributes
    {
        private List<ContainerPortMapping> _containerPortMappings = AWSConfigs.InitializeCollections ? new List<ContainerPortMapping>() : null;

        /// <summary>
        /// Gets and sets the property ContainerPortMappings. 
        /// <para>
        ///  Describes how container ports map to connection ports on the fleet instance. Incoming
        /// traffic connects to a game via a connection port. A <c>ContainerPortMapping</c> directs
        /// the traffic from a connection port to a port on the container that hosts the game
        /// session. 
        /// </para>
        /// </summary>
        public List<ContainerPortMapping> ContainerPortMappings
        {
            get { return this._containerPortMappings; }
            set { this._containerPortMappings = value; }
        }

        // Check to see if ContainerPortMappings property is set
        internal bool IsSetContainerPortMappings()
        {
            return this._containerPortMappings != null && (this._containerPortMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}