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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// One or more private IPv4 addresses.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataNetworkInterfaceSetPrivateIpAddressesDetails
    {
        /// <summary>
        /// Gets and sets the property Primary. 
        /// <para>
        ///  Indicates whether the private IPv4 address is the primary private IPv4 address. Only
        /// one IPv4 address can be designated as primary. 
        /// </para>
        /// </summary>
        public bool? Primary { get; set; }

        /// <summary>
        /// Checks to see if the Primary property is set.
        /// </summary>
        internal bool IsSetPrimary() => this.Primary.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        ///  The private IPv4 address. 
        /// </para>
        /// </summary>
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddress() => this.PrivateIpAddress != null;
    }
}
