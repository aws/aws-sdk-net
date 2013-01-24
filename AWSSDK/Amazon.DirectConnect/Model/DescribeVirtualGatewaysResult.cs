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
    /// <para> A structure containing a list of virtual gateways. </para>
    /// </summary>
    public class DescribeVirtualGatewaysResult  
    {
        
        private List<VirtualGateway> virtualGateways = new List<VirtualGateway>();

        /// <summary>
        /// A list of virtual gateways.
        ///  
        /// </summary>
        public List<VirtualGateway> VirtualGateways
        {
            get { return this.virtualGateways; }
            set { this.virtualGateways = value; }
        }
        /// <summary>
        /// Adds elements to the VirtualGateways collection
        /// </summary>
        /// <param name="virtualGateways">The values to add to the VirtualGateways collection </param>
        /// <returns>this instance</returns>
        public DescribeVirtualGatewaysResult WithVirtualGateways(params VirtualGateway[] virtualGateways)
        {
            foreach (VirtualGateway element in virtualGateways)
            {
                this.virtualGateways.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the VirtualGateways collection
        /// </summary>
        /// <param name="virtualGateways">The values to add to the VirtualGateways collection </param>
        /// <returns>this instance</returns>
        public DescribeVirtualGatewaysResult WithVirtualGateways(IEnumerable<VirtualGateway> virtualGateways)
        {
            foreach (VirtualGateway element in virtualGateways)
            {
                this.virtualGateways.Add(element);
            }

            return this;
        }

        // Check to see if VirtualGateways property is set
        internal bool IsSetVirtualGateways()
        {
            return this.virtualGateways.Count > 0;       
        }
    }
}
