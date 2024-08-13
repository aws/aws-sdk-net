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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
    /// A mount point for the data volumes in the container.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsMountPointsDetails
    {
        private string _containerPath;
        private bool? _readOnly;
        private string _sourceVolume;

        /// <summary>
        /// Gets and sets the property ContainerPath. 
        /// <para>
        /// The path on the container to mount the host volume at.
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
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// Whether the container has read-only access to the volume.
        /// </para>
        /// </summary>
        public bool? ReadOnly
        {
            get { return this._readOnly; }
            set { this._readOnly = value; }
        }

        // Check to see if ReadOnly property is set
        internal bool IsSetReadOnly()
        {
            return this._readOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceVolume. 
        /// <para>
        /// The name of the volume to mount. Must match the name of a volume listed in <c>VolumeDetails</c>
        /// for the task definition.
        /// </para>
        /// </summary>
        public string SourceVolume
        {
            get { return this._sourceVolume; }
            set { this._sourceVolume = value; }
        }

        // Check to see if SourceVolume property is set
        internal bool IsSetSourceVolume()
        {
            return this._sourceVolume != null;
        }

    }
}