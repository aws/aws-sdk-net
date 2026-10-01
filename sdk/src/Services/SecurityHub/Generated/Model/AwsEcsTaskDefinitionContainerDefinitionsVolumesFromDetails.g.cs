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
    /// A data volume to mount from another container.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsVolumesFromDetails
    {
        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// Whether the container has read-only access to the volume.
        /// </para>
        /// </summary>
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Checks to see if the ReadOnly property is set.
        /// </summary>
        internal bool IsSetReadOnly() => this.ReadOnly.HasValue;

        /// <summary>
        /// Gets and sets the property SourceContainer. 
        /// <para>
        /// The name of another container within the same task definition from which to mount
        /// volumes.
        /// </para>
        /// </summary>
        public string SourceContainer { get; set; }

        /// <summary>
        /// Checks to see if the SourceContainer property is set.
        /// </summary>
        internal bool IsSetSourceContainer() => this.SourceContainer != null;
    }
}
