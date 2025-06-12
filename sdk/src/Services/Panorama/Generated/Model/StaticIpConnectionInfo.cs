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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// A static IP configuration.
    /// </summary>
    public partial class StaticIpConnectionInfo
    {
        private string _defaultGateway;
        private List<string> _dns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _ipAddress;
        private string _mask;

        /// <summary>
        /// Gets and sets the property DefaultGateway. 
        /// <para>
        /// The connection's default gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DefaultGateway
        {
            get { return this._defaultGateway; }
            set { this._defaultGateway = value; }
        }

        // Check to see if DefaultGateway property is set
        internal bool IsSetDefaultGateway()
        {
            return this._defaultGateway != null;
        }

        /// <summary>
        /// Gets and sets the property Dns. 
        /// <para>
        /// The connection's DNS address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Dns
        {
            get { return this._dns; }
            set { this._dns = value; }
        }

        // Check to see if Dns property is set
        internal bool IsSetDns()
        {
            return this._dns != null && (this._dns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The connection's IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Mask. 
        /// <para>
        /// The connection's DNS mask.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Mask
        {
            get { return this._mask; }
            set { this._mask = value; }
        }

        // Check to see if Mask property is set
        internal bool IsSetMask()
        {
            return this._mask != null;
        }

    }
}