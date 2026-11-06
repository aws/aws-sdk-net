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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Configuration for an IPAM CIDR that defines a specific IP address range, IPAM pool,
    /// and associated Anycast IP address.
    /// </summary>
    public partial class IpamCidrConfig
    {
        /// <summary>
        /// Gets and sets the property AnycastIp. 
        /// <para>
        /// The specified Anycast IP address allocated from the IPAM pool for this CIDR configuration.
        /// </para>
        /// </summary>
        public string AnycastIp { get; set; }

        /// <summary>
        /// Checks to see if the AnycastIp property is set.
        /// </summary>
        internal bool IsSetAnycastIp() => this.AnycastIp != null;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR that specifies the IP address range for this IPAM configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property IpamPoolArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IPAM pool that the CIDR block is assigned to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamPoolArn { get; set; }

        /// <summary>
        /// Checks to see if the IpamPoolArn property is set.
        /// </summary>
        internal bool IsSetIpamPoolArn() => this.IpamPoolArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the IPAM CIDR configuration.
        /// </para>
        /// </summary>
        public IpamCidrStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
