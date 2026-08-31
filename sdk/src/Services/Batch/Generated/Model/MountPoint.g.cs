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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Details for a Docker volume mount point that's used in a job's container properties.
    /// This parameter maps to <c>Volumes</c> in the <a href="https://docs.docker.com/engine/api/latest/#tag/Container/operation/ContainerCreate">Create
    /// a container</a> section of the <i>Docker Remote API</i> and the <c>--volume</c> option
    /// to docker run.
    /// </summary>
    public partial class MountPoint
    {
        /// <summary>
        /// Gets and sets the property ContainerPath. 
        /// <para>
        /// The path on the container where the host volume is mounted.
        /// </para>
        /// </summary>
        public string ContainerPath { get; set; }

        /// <summary>
        /// Checks to see if the ContainerPath property is set.
        /// </summary>
        internal bool IsSetContainerPath() => this.ContainerPath != null;

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// If this value is <c>true</c>, the container has read-only access to the volume. Otherwise,
        /// the container can write to the volume. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Checks to see if the ReadOnly property is set.
        /// </summary>
        internal bool IsSetReadOnly() => this.ReadOnly.HasValue;

        /// <summary>
        /// Gets and sets the property SourceVolume. 
        /// <para>
        /// The name of the volume to mount.
        /// </para>
        /// </summary>
        public string SourceVolume { get; set; }

        /// <summary>
        /// Checks to see if the SourceVolume property is set.
        /// </summary>
        internal bool IsSetSourceVolume() => this.SourceVolume != null;
    }
}
