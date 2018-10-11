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
    /// Container for the parameters to the UpdateVirtualInterfaceAttributes operation.
    /// Updates the specified attributes of the specified virtual private interface.
    /// 
    ///  
    /// <para>
    /// Setting the MTU of a virtual interface to 9001 (jumbo frames) can cause an update
    /// to the underlying physical connection if it wasn't updated to support jumbo frames.
    /// Updating the connection disrupts network connectivity for all virtual interfaces associated
    /// with the connection for up to 30 seconds. To check whether your connection supports
    /// jumbo frames, call <a>DescribeConnections</a>. To check whether your virtual interface
    /// supports jumbo frames, call <a>DescribeVirtualInterfaces</a>.
    /// </para>
    /// </summary>
    public partial class UpdateVirtualInterfaceAttributesRequest : AmazonDirectConnectRequest
    {
        private int? _mtu;
        private string _virtualInterfaceId;

        /// <summary>
        /// Gets and sets the property Mtu. 
        /// <para>
        /// The maximum transmission unit (MTU), in bytes. The supported values are 1500 and 9001.
        /// The default value is 1500.
        /// </para>
        /// </summary>
        public int Mtu
        {
            get { return this._mtu.GetValueOrDefault(); }
            set { this._mtu = value; }
        }

        // Check to see if Mtu property is set
        internal bool IsSetMtu()
        {
            return this._mtu.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VirtualInterfaceId. 
        /// <para>
        /// The ID of the virtual private interface.
        /// </para>
        /// </summary>
        public string VirtualInterfaceId
        {
            get { return this._virtualInterfaceId; }
            set { this._virtualInterfaceId = value; }
        }

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this._virtualInterfaceId != null;
        }

    }
}