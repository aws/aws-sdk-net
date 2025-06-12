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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
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
    /// Container for the parameters to the CreateVirtualNode operation.
    /// Creates a virtual node within a service mesh.
    /// 
    ///  
    /// <para>
    ///  A virtual node acts as a logical pointer to a particular task group, such as an Amazon
    /// ECS service or a Kubernetes deployment. When you create a virtual node, you can specify
    /// the service discovery information for your task group, and whether the proxy running
    /// in a task group will communicate with other proxies using Transport Layer Security
    /// (TLS).
    /// </para>
    ///  
    /// <para>
    /// You define a <c>listener</c> for any inbound traffic that your virtual node expects.
    /// Any virtual service that your virtual node expects to communicate to is specified
    /// as a <c>backend</c>.
    /// </para>
    ///  
    /// <para>
    /// The response metadata for your new virtual node contains the <c>arn</c> that is associated
    /// with the virtual node. Set this value to the full ARN; for example, <c>arn:aws:appmesh:us-west-2:123456789012:myMesh/default/virtualNode/myApp</c>)
    /// as the <c>APPMESH_RESOURCE_ARN</c> environment variable for your task group's Envoy
    /// proxy container in your task definition or pod spec. This is then mapped to the <c>node.id</c>
    /// and <c>node.cluster</c> Envoy parameters.
    /// </para>
    ///  <note> 
    /// <para>
    /// By default, App Mesh uses the name of the resource you specified in <c>APPMESH_RESOURCE_ARN</c>
    /// when Envoy is referring to itself in metrics and traces. You can override this behavior
    /// by setting the <c>APPMESH_RESOURCE_CLUSTER</c> environment variable with your own
    /// name.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about virtual nodes, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/virtual_nodes.html">Virtual
    /// nodes</a>. You must be using <c>1.15.0</c> or later of the Envoy image when setting
    /// these variables. For more information aboutApp Mesh Envoy variables, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/envoy.html">Envoy
    /// image</a> in the App Mesh User Guide.
    /// </para>
    /// </summary>
    public partial class CreateVirtualNodeRequest : AmazonAppMeshRequest
    {
        private string _clientToken;
        private string _meshName;
        private string _meshOwner;
        private VirtualNodeSpec _spec;
        private List<TagRef> _tags = AWSConfigs.InitializeCollections ? new List<TagRef>() : null;
        private string _virtualNodeName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. Up to 36 letters, numbers, hyphens, and underscores are allowed.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property MeshName. 
        /// <para>
        /// The name of the service mesh to create the virtual node in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MeshName
        {
            get { return this._meshName; }
            set { this._meshName = value; }
        }

        // Check to see if MeshName property is set
        internal bool IsSetMeshName()
        {
            return this._meshName != null;
        }

        /// <summary>
        /// Gets and sets the property MeshOwner. 
        /// <para>
        /// The Amazon Web Services IAM account ID of the service mesh owner. If the account ID
        /// is not your own, then the account that you specify must share the mesh with your account
        /// before you can create the resource in the service mesh. For more information about
        /// mesh sharing, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/sharing.html">Working
        /// with shared meshes</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string MeshOwner
        {
            get { return this._meshOwner; }
            set { this._meshOwner = value; }
        }

        // Check to see if MeshOwner property is set
        internal bool IsSetMeshOwner()
        {
            return this._meshOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// The virtual node specification to apply.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VirtualNodeSpec Spec
        {
            get { return this._spec; }
            set { this._spec = value; }
        }

        // Check to see if Spec property is set
        internal bool IsSetSpec()
        {
            return this._spec != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you can apply to the virtual node to assist with categorization
        /// and organization. Each tag consists of a key and an optional value, both of which
        /// you define. Tag keys can have a maximum character length of 128 characters, and tag
        /// values can have a maximum length of 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TagRef> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VirtualNodeName. 
        /// <para>
        /// The name to use for the virtual node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string VirtualNodeName
        {
            get { return this._virtualNodeName; }
            set { this._virtualNodeName = value; }
        }

        // Check to see if VirtualNodeName property is set
        internal bool IsSetVirtualNodeName()
        {
            return this._virtualNodeName != null;
        }

    }
}