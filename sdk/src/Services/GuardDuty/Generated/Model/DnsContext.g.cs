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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains DNS details about network activity.
    /// </summary>
    public partial class DnsContext
    {
        /// <summary>
        /// Gets and sets the property DomainSuffix. 
        /// <para>
        /// The suffix of the domain that was queried.
        /// </para>
        /// </summary>
        public string DomainSuffix { get; set; }

        /// <summary>
        /// Checks to see if the DomainSuffix property is set.
        /// </summary>
        internal bool IsSetDomainSuffix() => this.DomainSuffix != null;

        /// <summary>
        /// Gets and sets the property OtherDomains. 
        /// <para>
        /// Other domains that were queried.
        /// </para>
        /// </summary>
        public string OtherDomains { get; set; }

        /// <summary>
        /// Checks to see if the OtherDomains property is set.
        /// </summary>
        internal bool IsSetOtherDomains() => this.OtherDomains != null;

        /// <summary>
        /// Gets and sets the property ResolverHistory. 
        /// <para>
        /// The DNS resolution history for the domain.
        /// </para>
        /// </summary>
        public string ResolverHistory { get; set; }

        /// <summary>
        /// Checks to see if the ResolverHistory property is set.
        /// </summary>
        internal bool IsSetResolverHistory() => this.ResolverHistory != null;
    }
}
