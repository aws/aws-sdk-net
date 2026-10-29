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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents a virtual node returned by a describe operation.
    /// </summary>
    public partial class VirtualNodeData
    {
        /// <summary>
        /// Gets and sets the property MeshName. 
        /// <para>
        /// The name of the service mesh that the virtual node resides in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string MeshName { get; set; }

        /// <summary>
        /// Checks to see if the MeshName property is set.
        /// </summary>
        internal bool IsSetMeshName() => this.MeshName != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The associated metadata for the virtual node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceMetadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// The specifications of the virtual node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VirtualNodeSpec Spec { get; set; }

        /// <summary>
        /// Checks to see if the Spec property is set.
        /// </summary>
        internal bool IsSetSpec() => this.Spec != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status for the virtual node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VirtualNodeStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VirtualNodeName. 
        /// <para>
        /// The name of the virtual node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string VirtualNodeName { get; set; }

        /// <summary>
        /// Checks to see if the VirtualNodeName property is set.
        /// </summary>
        internal bool IsSetVirtualNodeName() => this.VirtualNodeName != null;
    }
}
