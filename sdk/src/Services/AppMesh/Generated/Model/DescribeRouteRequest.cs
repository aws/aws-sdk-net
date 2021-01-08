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
    /// Container for the parameters to the DescribeRoute operation.
    /// Describes an existing route.
    /// </summary>
    public partial class DescribeRouteRequest : AmazonAppMeshRequest
    {
        private string _meshName;
        private string _meshOwner;
        private string _routeName;
        private string _virtualRouterName;

        /// <summary>
        /// Gets and sets the property MeshName. 
        /// <para>
        /// The name of the service mesh that the route resides in.
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
        /// then it's the ID of the account that shared the mesh with your account. For more information
        /// about mesh sharing, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/sharing.html">Working
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
        /// Gets and sets the property RouteName. 
        /// <para>
        /// The name of the route to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string RouteName
        {
            get { return this._routeName; }
            set { this._routeName = value; }
        }

        // Check to see if RouteName property is set
        internal bool IsSetRouteName()
        {
            return this._routeName != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualRouterName. 
        /// <para>
        /// The name of the virtual router that the route is associated with.
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