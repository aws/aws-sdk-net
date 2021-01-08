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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// This is the response object from the DescribeVirtualInterfaces operation.
    /// </summary>
    public partial class DescribeVirtualInterfacesResponse : AmazonWebServiceResponse
    {
        private List<VirtualInterface> _virtualInterfaces = new List<VirtualInterface>();

        /// <summary>
        /// Gets and sets the property VirtualInterfaces. 
        /// <para>
        /// The virtual interfaces
        /// </para>
        /// </summary>
        public List<VirtualInterface> VirtualInterfaces
        {
            get { return this._virtualInterfaces; }
            set { this._virtualInterfaces = value; }
        }

        // Check to see if VirtualInterfaces property is set
        internal bool IsSetVirtualInterfaces()
        {
            return this._virtualInterfaces != null && this._virtualInterfaces.Count > 0; 
        }

    }
}