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
    /// An object representing a virtual node returned by a list operation.
    /// </summary>
    public partial class VirtualNodeRef
    {
        private string _arn;
        private string _meshName;
        private string _virtualNodeName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) for the virtual node.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property MeshName. 
        /// <para>
        /// The name of the service mesh in which the virtual node resides.
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
        /// Gets and sets the property VirtualNodeName. 
        /// <para>
        /// The name of the virtual node.
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