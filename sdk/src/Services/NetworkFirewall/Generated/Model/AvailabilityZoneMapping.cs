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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Defines the mapping between an Availability Zone and a firewall endpoint for a transit
    /// gateway-attached firewall. Each mapping represents where the firewall can process
    /// traffic. You use these mappings when calling <a>CreateFirewall</a>, <a>AssociateAvailabilityZones</a>,
    /// and <a>DisassociateAvailabilityZones</a>.
    /// 
    ///  
    /// <para>
    /// To retrieve the current Availability Zone mappings for a firewall, use <a>DescribeFirewall</a>.
    /// </para>
    /// </summary>
    public partial class AvailabilityZoneMapping
    {
        private string _availabilityZone;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The ID of the Availability Zone where the firewall endpoint is located. For example,
        /// <c>us-east-2a</c>. The Availability Zone must be in the same Region as the transit
        /// gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

    }
}