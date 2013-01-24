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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para> A structure containing a list of virtual interfaces. </para>
    /// </summary>
    public class DescribeVirtualInterfacesResult  
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
        /// <summary>
        /// Adds elements to the VirtualInterfaces collection
        /// </summary>
        /// <param name="virtualInterfaces">The values to add to the VirtualInterfaces collection </param>
        /// <returns>this instance</returns>
        public DescribeVirtualInterfacesResult WithVirtualInterfaces(params VirtualInterface[] virtualInterfaces)
        {
            foreach (VirtualInterface element in virtualInterfaces)
            {
                this.virtualInterfaces.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the VirtualInterfaces collection
        /// </summary>
        /// <param name="virtualInterfaces">The values to add to the VirtualInterfaces collection </param>
        /// <returns>this instance</returns>
        public DescribeVirtualInterfacesResult WithVirtualInterfaces(IEnumerable<VirtualInterface> virtualInterfaces)
        {
            foreach (VirtualInterface element in virtualInterfaces)
            {
                this.virtualInterfaces.Add(element);
            }

            return this;
        }

        // Check to see if VirtualInterfaces property is set
        internal bool IsSetVirtualInterfaces()
        {
            return this.virtualInterfaces.Count > 0;       
        }
    }
}
