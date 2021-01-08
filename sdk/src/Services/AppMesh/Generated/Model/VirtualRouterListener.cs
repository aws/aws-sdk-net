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
    /// An object that represents a virtual router listener.
    /// </summary>
    public partial class VirtualRouterListener
    {
        private PortMapping _portMapping;

        /// <summary>
        /// Gets and sets the property PortMapping.
        /// </summary>
        [AWSProperty(Required=true)]
        public PortMapping PortMapping
        {
            get { return this._portMapping; }
            set { this._portMapping = value; }
        }

        // Check to see if PortMapping property is set
        internal bool IsSetPortMapping()
        {
            return this._portMapping != null;
        }

    }
}