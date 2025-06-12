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
    /// Container for the parameters to the CreateVirtualService operation.
    /// Creates a virtual service within a service mesh.
    /// 
    ///  
    /// <para>
    /// A virtual service is an abstraction of a real service that is provided by a virtual
    /// node directly or indirectly by means of a virtual router. Dependent services call
    /// your virtual service by its <c>virtualServiceName</c>, and those requests are routed
    /// to the virtual node or virtual router that is specified as the provider for the virtual
    /// service.
    /// </para>
    ///  
    /// <para>
    /// For more information about virtual services, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/virtual_services.html">Virtual
    /// services</a>.
    /// </para>
    /// </summary>
    public partial class CreateVirtualServiceRequest : AmazonAppMeshRequest
    {
        private string _clientToken;
        private string _meshName;
        private string _meshOwner;
        private VirtualServiceSpec _spec;
        private List<TagRef> _tags = AWSConfigs.InitializeCollections ? new List<TagRef>() : null;
        private string _virtualServiceName;

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
        /// The name of the service mesh to create the virtual service in.
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
        /// The virtual service specification to apply.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VirtualServiceSpec Spec
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
        /// Optional metadata that you can apply to the virtual service to assist with categorization
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
        /// Gets and sets the property VirtualServiceName. 
        /// <para>
        /// The name to use for the virtual service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VirtualServiceName
        {
            get { return this._virtualServiceName; }
            set { this._virtualServiceName = value; }
        }

        // Check to see if VirtualServiceName property is set
        internal bool IsSetVirtualServiceName()
        {
            return this._virtualServiceName != null;
        }

    }
}