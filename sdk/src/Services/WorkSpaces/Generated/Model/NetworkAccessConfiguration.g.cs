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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the network details of a WorkSpaces Pool.
    /// </summary>
    public partial class NetworkAccessConfiguration
    {
        /// <summary>
        /// Gets and sets the property EniId. 
        /// <para>
        /// The resource identifier of the elastic network interface that is attached to instances
        /// in your VPC. All network interfaces have the eni-xxxxxxxx resource identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string EniId { get; set; }

        /// <summary>
        /// Checks to see if the EniId property is set.
        /// </summary>
        internal bool IsSetEniId() => this.EniId != null;

        /// <summary>
        /// Gets and sets the property EniPrivateIpAddress. 
        /// <para>
        /// The private IP address of the elastic network interface that is attached to instances
        /// in your VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string EniPrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the EniPrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetEniPrivateIpAddress() => this.EniPrivateIpAddress != null;
    }
}
