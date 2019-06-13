/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRoute operation.
    /// Creates a route that is associated with a virtual router.
    /// 
    ///          
    /// <para>
    /// You can use the <code>prefix</code> parameter in your route specification for path-based
    ///         routing of requests. For example, if your virtual service name is        
    ///    <code>my-service.local</code> and you want the route to match requests to     
    ///       <code>my-service.local/metrics</code>, your prefix should be         <code>/metrics</code>.
    /// </para>
    ///          
    /// <para>
    /// If your route matches a request, you can distribute traffic to one or more target
    ///         virtual nodes with relative weighting.
    /// </para>
    /// </summary>
    public partial class CreateRouteRequest : AmazonAppMeshRequest
    {
        private string _clientToken;
        private string _meshName;
        private string _routeName;
        private RouteSpec _spec;
        private List<TagRef> _tags = new List<TagRef>();
        private string _virtualRouterName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of therequest.
        /// Up to 36 letters, numbers, hyphens, and underscores are allowed.
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
        /// The name of the service mesh to create the route in.
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
        /// Gets and sets the property RouteName. 
        /// <para>
        /// The name to use for the route.
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
        /// Gets and sets the property Spec. 
        /// <para>
        /// The route specification to apply.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouteSpec Spec
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
        /// Optional metadata that you can apply to the route to assist with categorization and
        ///         organization. Each tag consists of a key and an optional value, both of which
        /// you define.         Tag keys can have a maximum character length of 128 characters,
        /// and tag values can have            a maximum length of 256 characters.
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
        /// The name of the virtual router in which to create the route.
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