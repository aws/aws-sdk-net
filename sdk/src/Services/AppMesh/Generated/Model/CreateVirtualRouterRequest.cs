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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVirtualRouter operation.
    /// Creates a virtual router within a service mesh.
    /// 
    ///  
    /// <para>
    /// Specify a <code>listener</code> for any inbound traffic that your virtual router receives.
    /// Create a virtual router for each protocol and port that you need to route. Virtual
    /// routers handle traffic for one or more virtual services within your mesh. After you
    /// create your virtual router, create and associate routes for your virtual router that
    /// direct incoming requests to different virtual nodes.
    /// </para>
    ///  
    /// <para>
    /// For more information about virtual routers, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/virtual_routers.html">Virtual
    /// routers</a>.
    /// </para>
    /// </summary>
    public partial class CreateVirtualRouterRequest : AmazonAppMeshRequest
    {
        private string _clientToken;
        private string _meshName;
        private string _meshOwner;
        private VirtualRouterSpec _spec;
        private List<TagRef> _tags = new List<TagRef>();
        private string _virtualRouterName;

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
        /// The name of the service mesh to create the virtual router in.
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
        /// The AWS IAM account ID of the service mesh owner. If the account ID is not your own,
        /// then the account that you specify must share the mesh with your account before you
        /// can create the resource in the service mesh. For more information about mesh sharing,
        /// see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/sharing.html">Working
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
        /// The virtual router specification to apply.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VirtualRouterSpec Spec
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
        /// Optional metadata that you can apply to the virtual router to assist with categorization
        /// and organization. Each tag consists of a key and an optional value, both of which
        /// you define. Tag keys can have a maximum character length of 128 characters, and tag
        /// values can have a maximum length of 256 characters.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VirtualRouterName. 
        /// <para>
        /// The name to use for the virtual router.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string VirtualRouterName
        {
            get { return this._virtualRouterName; }
            set { this._virtualRouterName = value; }
        }

        // Check to see if VirtualRouterName property is set
        internal bool IsSetVirtualRouterName()
        {
            return this._virtualRouterName != null;
        }

    }
}