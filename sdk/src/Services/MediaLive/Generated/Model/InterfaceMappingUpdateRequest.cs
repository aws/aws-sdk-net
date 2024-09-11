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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for InterfaceMappingUpdateRequest
    /// </summary>
    public partial class InterfaceMappingUpdateRequest
    {
        private string _logicalInterfaceName;
        private string _networkId;

        /// <summary>
        /// Gets and sets the property LogicalInterfaceName. The logical name for one interface
        /// (on every Node) that handles a specific type of traffic. We recommend that the name
        /// hints at the physical interface it applies to. For example, it could refer to the
        /// traffic that the physical interface handles. For example, my-Inputs-Interface.
        /// </summary>
        public string LogicalInterfaceName
        {
            get { return this._logicalInterfaceName; }
            set { this._logicalInterfaceName = value; }
        }

        // Check to see if LogicalInterfaceName property is set
        internal bool IsSetLogicalInterfaceName()
        {
            return this._logicalInterfaceName != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkId. The ID of the network that you want to connect
        /// to the specified logicalInterfaceName. You can use the ListNetworks operation to discover
        /// all the IDs.
        /// </summary>
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

    }
}