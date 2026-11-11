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
    /// Container for the parameters to the CreateRoute operation. Creates a route that is
    /// associated with a virtual router. <para> You can route several different protocols
    /// and define a retry policy for a route. Traffic can be routed to one or more virtual
    /// nodes. </para> <para> For more information about routes, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/routes.html">Routes</a>.
    /// </para>
    /// </summary>
    public partial class CreateRouteRequest : AmazonAppMeshRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. Up to 36 letters, numbers, hyphens, and underscores are allowed.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property MeshName. 
        /// <para>
        /// The name of the service mesh to create the route in.
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
        /// is not your own, then the account that you specify must share the mesh with your account
        /// before you can create the resource in the service mesh. For more information about
        /// mesh sharing, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/sharing.html">Working
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
        /// Gets and sets the property RouteName. 
        /// <para>
        /// The name to use for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string RouteName { get; set; }

        /// <summary>
        /// Checks to see if the RouteName property is set.
        /// </summary>
        internal bool IsSetRouteName() => this.RouteName != null;

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// The route specification to apply.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouteSpec Spec { get; set; }

        /// <summary>
        /// Checks to see if the Spec property is set.
        /// </summary>
        internal bool IsSetSpec() => this.Spec != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you can apply to the route to assist with categorization and
        /// organization. Each tag consists of a key and an optional value, both of which you
        /// define. Tag keys can have a maximum character length of 128 characters, and tag values
        /// can have a maximum length of 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<TagRef> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<TagRef>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VirtualRouterName. 
        /// <para>
        /// The name of the virtual router in which to create the route. If the virtual router
        /// is in a shared mesh, then you must be the owner of the virtual router resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string VirtualRouterName { get; set; }

        /// <summary>
        /// Checks to see if the VirtualRouterName property is set.
        /// </summary>
        internal bool IsSetVirtualRouterName() => this.VirtualRouterName != null;
    }
}
