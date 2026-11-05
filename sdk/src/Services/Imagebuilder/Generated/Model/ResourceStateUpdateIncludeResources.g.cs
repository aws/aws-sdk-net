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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Specifies which underlying resources the resource state update applies to, in addition
    /// to the Image Builder image resource itself: distributed AMIs and their snapshots for
    /// AMI images, or distributed container images for container images.
    /// </summary>
    public partial class ResourceStateUpdateIncludeResources
    {
        /// <summary>
        /// Gets and sets the property Amis. 
        /// <para>
        /// Specifies whether the lifecycle action should apply to distributed AMIs.
        /// </para>
        /// </summary>
        public bool? Amis { get; set; }

        /// <summary>
        /// Checks to see if the Amis property is set.
        /// </summary>
        internal bool IsSetAmis() => this.Amis.HasValue;

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// Specifies whether the lifecycle action should apply to distributed containers.
        /// </para>
        /// </summary>
        public bool? Containers { get; set; }

        /// <summary>
        /// Checks to see if the Containers property is set.
        /// </summary>
        internal bool IsSetContainers() => this.Containers.HasValue;

        /// <summary>
        /// Gets and sets the property Snapshots. 
        /// <para>
        /// Specifies whether the lifecycle action should apply to snapshots associated with distributed
        /// AMIs.
        /// </para>
        /// </summary>
        public bool? Snapshots { get; set; }

        /// <summary>
        /// Checks to see if the Snapshots property is set.
        /// </summary>
        internal bool IsSetSnapshots() => this.Snapshots.HasValue;
    }
}
