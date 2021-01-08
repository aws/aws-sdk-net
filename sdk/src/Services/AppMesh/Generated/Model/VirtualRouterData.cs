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
    /// An object that represents a virtual router returned by a describe operation.
    /// </summary>
    public partial class VirtualRouterData
    {
        private string _meshName;
        private ResourceMetadata _metadata;
        private VirtualRouterSpec _spec;
        private VirtualRouterStatus _status;
        private string _virtualRouterName;

        /// <summary>
        /// Gets and sets the property MeshName. 
        /// <para>
        /// The name of the service mesh that the virtual router resides in.
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
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The associated metadata for the virtual router.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// The specifications of the virtual router.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the virtual router.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VirtualRouterStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualRouterName. 
        /// <para>
        /// The name of the virtual router.
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