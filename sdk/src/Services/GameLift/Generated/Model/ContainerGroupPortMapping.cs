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
    /// Describes the port mappings for a single container in a container group. Each mapping
    /// shows how a container port maps to a connection port on the fleet instance.
    /// 
    ///  
    /// <para>
    ///  <b>Returned by:</b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeContainerGroupPortMappings.html">DescribeContainerGroupPortMappings</a>
    /// 
    /// </para>
    /// </summary>
    public partial class ContainerGroupPortMapping
    {
        private string _containerName;
        private List<ContainerPortMapping> _containerPortMappings = AWSConfigs.InitializeCollections ? new List<ContainerPortMapping>() : null;
        private string _containerRuntimeId;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container, as defined in the container group definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerPortMappings. 
        /// <para>
        /// A list of <c>ContainerPortMapping</c> objects that describe the port mappings for
        /// this container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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

        /// <summary>
        /// Gets and sets the property ContainerRuntimeId. 
        /// <para>
        /// The runtime ID for the container that's running in a compute. This value is unique
        /// within the compute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ContainerRuntimeId
        {
            get { return this._containerRuntimeId; }
            set { this._containerRuntimeId = value; }
        }

        // Check to see if ContainerRuntimeId property is set
        internal bool IsSetContainerRuntimeId()
        {
            return this._containerRuntimeId != null;
        }

    }
}