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
    /// The domain for the specified distribution tenant.
    /// </summary>
    public partial class DomainItem
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property ServeOn. 
        /// <para>
        /// Specifies which requests for this domain CloudFront routes to the distribution tenant.
        /// Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>any</c> – CloudFront routes requests for this domain to the distribution tenant
        /// regardless of the IP address that they arrive on. This is the default if you don't
        /// specify a value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>anycast-ip-list-only</c> – CloudFront routes requests for this domain to the distribution
        /// tenant only when they arrive on the Anycast static IPs of the distribution tenant's
        /// connection group. CloudFront treats requests that arrive on other IP addresses as
        /// requests for an unknown domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ServeOn ServeOn { get; set; }

        /// <summary>
        /// Checks to see if the ServeOn property is set.
        /// </summary>
        internal bool IsSetServeOn() => this.ServeOn != null;
    }
}
