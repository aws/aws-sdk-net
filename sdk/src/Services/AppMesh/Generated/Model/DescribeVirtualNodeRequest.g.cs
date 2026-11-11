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
    /// Container for the parameters to the DescribeVirtualNode operation. Describes an existing
    /// virtual node.
    /// </summary>
    public partial class DescribeVirtualNodeRequest : AmazonAppMeshRequest
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
        /// Gets and sets the property MeshOwner. 
        /// <para>
        /// The Amazon Web Services IAM account ID of the service mesh owner. If the account ID
        /// is not your own, then it's the ID of the account that shared the mesh with your account.
        /// For more information about mesh sharing, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/sharing.html">Working
        /// with shared meshes</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string MeshOwner { get; set; }

        /// <summary>
        /// Checks to see if the MeshOwner property is set.
        /// </summary>
        internal bool IsSetMeshOwner() => this.MeshOwner != null;

        /// <summary>
        /// Gets and sets the property VirtualNodeName. 
        /// <para>
        /// The name of the virtual node to describe.
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
