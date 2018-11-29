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
 * Do not modify this file. This file is generated from the appmesh-2018-10-01.normal.json service model.
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
    /// Container for the parameters to the CreateVirtualNode operation.
    /// Creates a new virtual node within a service mesh.
    /// 
    ///          
    /// <para>
    /// A virtual node acts as logical pointer to a particular task group, such as an Amazon
    /// ECS         service or a Kubernetes deployment. When you create a virtual node, you
    /// must specify the         DNS service discovery name for your task group.
    /// </para>
    ///          
    /// <para>
    /// Any inbound traffic that your virtual node expects should be specified as a      
    ///      <code>listener</code>. Any outbound traffic that your virtual node expects to
    /// reach         should be specified as a <code>backend</code>.
    /// </para>
    ///          
    /// <para>
    /// The response metadata for your new virtual node contains the <code>arn</code> that
    /// is         associated with the virtual node. Set this value (either the full ARN or
    /// the truncated         resource name, for example, <code>mesh/default/virtualNode/simpleapp</code>,
    /// as the            <code>APPMESH_VIRTUAL_NODE_NAME</code> environment variable for
    /// your task group's Envoy         proxy container in your task definition or pod spec.
    /// This is then mapped to the            <code>node.id</code> and <code>node.cluster</code>
    /// Envoy parameters.
    /// </para>
    ///          <note>            
    /// <para>
    /// If you require your Envoy stats or tracing to use a different name, you can override
    ///            the <code>node.cluster</code> value that is set by               <code>APPMESH_VIRTUAL_NODE_NAME</code>
    /// with the               <code>APPMESH_VIRTUAL_NODE_CLUSTER</code> environment variable.
    /// </para>
    ///          </note>
    /// </summary>
    public partial class CreateVirtualNodeRequest : AmazonAppMeshRequest
    {
        private string _clientToken;
        private string _meshName;
        private VirtualNodeSpec _spec;
        private string _virtualNodeName;

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
        /// The name of the service mesh in which to create the virtual node.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Spec. 
        /// <para>
        /// The virtual node specification to apply.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property VirtualNodeName. 
        /// <para>
        /// The name to use for the virtual node.
        /// </para>
        /// </summary>
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