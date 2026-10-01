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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details for a volume mount point that's used in a container definition.
    /// </summary>
    public partial class AwsMountPoint
    {
        /// <summary>
        /// Gets and sets the property ContainerPath. 
        /// <para>
        /// The path on the container to mount the host volume at. 
        /// </para>
        /// </summary>
        public string ContainerPath { get; set; }

        /// <summary>
        /// Checks to see if the ContainerPath property is set.
        /// </summary>
        internal bool IsSetContainerPath() => this.ContainerPath != null;

        /// <summary>
        /// Gets and sets the property SourceVolume. 
        /// <para>
        /// The name of the volume to mount. Must be a volume name referenced in the <c>name</c>
        /// parameter of task definition <c>volume</c>. 
        /// </para>
        /// </summary>
        public string SourceVolume { get; set; }

        /// <summary>
        /// Checks to see if the SourceVolume property is set.
        /// </summary>
        internal bool IsSetSourceVolume() => this.SourceVolume != null;
    }
}
