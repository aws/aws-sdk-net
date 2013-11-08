/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para>A structure containing a list of virtual interfaces.</para>
    /// </summary>
    public partial class DescribeVirtualInterfacesResult : AmazonWebServiceResponse
    {
        
        private List<VirtualInterface> virtualInterfaces = new List<VirtualInterface>();


        /// <summary>
        /// A list of virtual interfaces.
        ///  
        /// </summary>
        public List<VirtualInterface> VirtualInterfaces
        {
            get { return this.virtualInterfaces; }
            set { this.virtualInterfaces = value; }
        }

        // Check to see if VirtualInterfaces property is set
        internal bool IsSetVirtualInterfaces()
        {
            return this.virtualInterfaces.Count > 0;
        }
    }
}
