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
    /// <zonbook></zonbook><xhtml></xhtml>
    /// </summary>
    public partial class DeleteVirtualNodeResponse : AmazonWebServiceResponse
    {
        private VirtualNodeData _virtualNode;

        /// <summary>
        /// Gets and sets the property VirtualNode. 
        /// <para>
        /// The virtual node that was deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VirtualNodeData VirtualNode
        {
            get { return this._virtualNode; }
            set { this._virtualNode = value; }
        }

        // Check to see if VirtualNode property is set
        internal bool IsSetVirtualNode()
        {
            return this._virtualNode != null;
        }

    }
}