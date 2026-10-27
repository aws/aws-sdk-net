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

namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Represents an IPv6 address configuration for a WorkSpace Instance.
    /// </summary>
    public partial class InstanceIpv6Address
    {
        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// Specific IPv6 address assigned to the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 128)]
        public string Ipv6Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Address property is set.
        /// </summary>
        internal bool IsSetIpv6Address() => this.Ipv6Address != null;

        /// <summary>
        /// Gets and sets the property IsPrimaryIpv6. 
        /// <para>
        /// Indicates if this is the primary IPv6 address for the instance.
        /// </para>
        /// </summary>
        public bool? IsPrimaryIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the IsPrimaryIpv6 property is set.
        /// </summary>
        internal bool IsSetIsPrimaryIpv6() => this.IsPrimaryIpv6.HasValue;
    }
}
