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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// A structure containing a list of virtual private gateways.
    /// </summary>
    public partial class DescribeVirtualGatewaysResult : AmazonWebServiceResponse
    {
        private List<VirtualGateway> _virtualGateways = new List<VirtualGateway>();

        /// <summary>
        /// Gets and sets the property VirtualGateways. 
        /// <para>
        /// A list of virtual private gateways.
        /// </para>
        /// </summary>
        public List<VirtualGateway> VirtualGateways
        {
            get { return this._virtualGateways; }
            set { this._virtualGateways = value; }
        }

        // Check to see if VirtualGateways property is set
        internal bool IsSetVirtualGateways()
        {
            return this._virtualGateways != null && this._virtualGateways.Count > 0; 
        }

    }
}