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
    /// A unique identifier for a container in a compute on a managed container fleet instance.
    /// This information makes it possible to remotely connect to a specific container on
    /// a fleet instance.
    /// 
    ///  
    /// <para>
    ///  <b>Related to:</b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ContainerAttribute.html">ContainerAttribute</a>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Use with: </b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetComputeAccess.html">GetComputeAccess</a>
    /// 
    /// </para>
    /// </summary>
    public partial class ContainerIdentifier
    {
        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The identifier for a container that's running in a compute. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ContainerName { get; set; }

        /// <summary>
        /// Checks to see if the ContainerName property is set.
        /// </summary>
        internal bool IsSetContainerName() => this.ContainerName != null;

        /// <summary>
        /// Gets and sets the property ContainerRuntimeId. 
        /// <para>
        /// The runtime ID for the container that's running in a compute. This value is unique
        /// within the compute. It is returned as a <c>ContainerAttribute</c> value in a <c>Compute</c>
        /// object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ContainerRuntimeId { get; set; }

        /// <summary>
        /// Checks to see if the ContainerRuntimeId property is set.
        /// </summary>
        internal bool IsSetContainerRuntimeId() => this.ContainerRuntimeId != null;
    }
}
