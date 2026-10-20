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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Details on a container instance bind mount host volume.
    /// </summary>
    public partial class HostVolumeProperties
    {
        /// <summary>
        /// Gets and sets the property SourcePath. 
        /// <para>
        /// When the <c>host</c> parameter is used, specify a <c>sourcePath</c> to declare the
        /// path on the host container instance that's presented to the container. If this parameter
        /// is empty, then the Docker daemon has assigned a host path for you. If the <c>host</c>
        /// parameter contains a <c>sourcePath</c> file location, then the data volume persists
        /// at the specified location on the host container instance until you delete it manually.
        /// If the <c>sourcePath</c> value doesn't exist on the host container instance, the Docker
        /// daemon creates it. If the location does exist, the contents of the source path folder
        /// are exported.
        /// </para>
        ///  
        /// <para>
        /// If you're using the Fargate launch type, the <c>sourcePath</c> parameter is not supported.
        /// </para>
        /// </summary>
        public string SourcePath { get; set; }

        /// <summary>
        /// Checks to see if the SourcePath property is set.
        /// </summary>
        internal bool IsSetSourcePath() => this.SourcePath != null;
    }
}
