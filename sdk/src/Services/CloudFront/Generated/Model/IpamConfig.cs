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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The configuration IPAM settings that includes the quantity of CIDR configurations
    /// and the list of IPAM CIDR configurations.
    /// </summary>
    public partial class IpamConfig
    {
        private List<IpamCidrConfig> _ipamCidrConfigs = AWSConfigs.InitializeCollections ? new List<IpamCidrConfig>() : null;
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property IpamCidrConfigs. 
        /// <para>
        /// A list of IPAM CIDR configurations that define the IP address ranges, IPAM pools,
        /// and associated Anycast IP addresses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<IpamCidrConfig> IpamCidrConfigs
        {
            get { return this._ipamCidrConfigs; }
            set { this._ipamCidrConfigs = value; }
        }

        // Check to see if IpamCidrConfigs property is set
        internal bool IsSetIpamCidrConfigs()
        {
            return this._ipamCidrConfigs != null && (this._ipamCidrConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of IPAM CIDR configurations in the <c>IpamCidrConfigs</c> list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Quantity
        {
            get { return this._quantity.GetValueOrDefault(); }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

    }
}