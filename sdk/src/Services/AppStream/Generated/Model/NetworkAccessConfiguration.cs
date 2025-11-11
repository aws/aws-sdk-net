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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes the network details of the fleet or image builder instance.
    /// </summary>
    public partial class NetworkAccessConfiguration
    {
        private string _eniId;
        private List<string> _eniIpv6Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _eniPrivateIpAddress;

        /// <summary>
        /// Gets and sets the property EniId. 
        /// <para>
        /// The resource identifier of the elastic network interface that is attached to instances
        /// in your VPC. All network interfaces have the eni-xxxxxxxx resource identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string EniId
        {
            get { return this._eniId; }
            set { this._eniId = value; }
        }

        // Check to see if EniId property is set
        internal bool IsSetEniId()
        {
            return this._eniId != null;
        }

        /// <summary>
        /// Gets and sets the property EniIpv6Addresses. 
        /// <para>
        /// The IPv6 addresses of the elastic network interface that is attached to instances
        /// in your VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EniIpv6Addresses
        {
            get { return this._eniIpv6Addresses; }
            set { this._eniIpv6Addresses = value; }
        }

        // Check to see if EniIpv6Addresses property is set
        internal bool IsSetEniIpv6Addresses()
        {
            return this._eniIpv6Addresses != null && (this._eniIpv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EniPrivateIpAddress. 
        /// <para>
        /// The private IP address of the elastic network interface that is attached to instances
        /// in your VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string EniPrivateIpAddress
        {
            get { return this._eniPrivateIpAddress; }
            set { this._eniPrivateIpAddress = value; }
        }

        // Check to see if EniPrivateIpAddress property is set
        internal bool IsSetEniPrivateIpAddress()
        {
            return this._eniPrivateIpAddress != null;
        }

    }
}