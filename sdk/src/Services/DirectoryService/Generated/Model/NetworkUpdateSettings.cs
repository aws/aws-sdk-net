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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains the network configuration for directory update operations.
    /// </summary>
    public partial class NetworkUpdateSettings
    {
        private List<string> _customerDnsIpsV6 = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NetworkType _networkType;

        /// <summary>
        /// Gets and sets the property CustomerDnsIpsV6. 
        /// <para>
        /// IPv6 addresses of DNS servers or domain controllers in the self-managed directory.
        /// Required only when updating an AD Connector directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomerDnsIpsV6
        {
            get { return this._customerDnsIpsV6; }
            set { this._customerDnsIpsV6 = value; }
        }

        // Check to see if CustomerDnsIpsV6 property is set
        internal bool IsSetCustomerDnsIpsV6()
        {
            return this._customerDnsIpsV6 != null && (this._customerDnsIpsV6.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The target network type for the directory update.
        /// </para>
        /// </summary>
        public NetworkType NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

    }
}