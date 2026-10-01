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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Contains a recommended security group configuration for an AMI fulfillment option.
    /// </summary>
    public partial class AmazonMachineImageSecurityGroup
    {
        private List<string> _cidrIpAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _fromPort;
        private string _protocol;
        private int? _toPort;

        /// <summary>
        /// Gets and sets the property CidrIpAddresses. 
        /// <para>
        /// The IP address ranges in CIDR format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> CidrIpAddresses
        {
            get { return this._cidrIpAddresses; }
            set { this._cidrIpAddresses = value; }
        }

        // Check to see if CidrIpAddresses property is set
        internal bool IsSetCidrIpAddresses()
        {
            return this._cidrIpAddresses != null && (this._cidrIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// The start of the port range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? FromPort
        {
            get { return this._fromPort; }
            set { this._fromPort = value; }
        }

        // Check to see if FromPort property is set
        internal bool IsSetFromPort()
        {
            return this._fromPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The IP protocol name, such as <c>tcp</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// The end of the port range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ToPort
        {
            get { return this._toPort; }
            set { this._toPort = value; }
        }

        // Check to see if ToPort property is set
        internal bool IsSetToPort()
        {
            return this._toPort.HasValue; 
        }

    }
}