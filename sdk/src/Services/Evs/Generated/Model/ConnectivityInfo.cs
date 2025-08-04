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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// Amazon EVS is in public preview release and is subject to change.
    /// 
    ///  </note> 
    /// <para>
    /// The connectivity configuration for the environment. Amazon EVS requires that you specify
    /// two route server peer IDs. During environment creation, the route server endpoints
    /// peer with the NSX uplink VLAN for connectivity to the NSX overlay network.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class ConnectivityInfo
    {
        private List<string> _privateRouteServerPeerings = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property PrivateRouteServerPeerings. 
        /// <para>
        /// The unique IDs for private route server peers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<string> PrivateRouteServerPeerings
        {
            get { return this._privateRouteServerPeerings; }
            set { this._privateRouteServerPeerings = value; }
        }

        // Check to see if PrivateRouteServerPeerings property is set
        internal bool IsSetPrivateRouteServerPeerings()
        {
            return this._privateRouteServerPeerings != null && (this._privateRouteServerPeerings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}