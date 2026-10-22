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
    /// Contains information about the DNS_REQUEST action described in this finding.
    /// </summary>
    public partial class DnsRequestAction
    {
        /// <summary>
        /// Gets and sets the property Blocked. 
        /// <para>
        /// Indicates whether the targeted port is blocked.
        /// </para>
        /// </summary>
        public bool? Blocked { get; set; }

        /// <summary>
        /// Checks to see if the Blocked property is set.
        /// </summary>
        internal bool IsSetBlocked() => this.Blocked.HasValue;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain information for the DNS query.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property DomainWithSuffix. 
        /// <para>
        /// The second and top level domain involved in the activity that potentially prompted
        /// GuardDuty to generate this finding. For a list of top-level and second-level domains,
        /// see <a href="https://publicsuffix.org/">public suffix list</a>.
        /// </para>
        /// </summary>
        public string DomainWithSuffix { get; set; }

        /// <summary>
        /// Checks to see if the DomainWithSuffix property is set.
        /// </summary>
        internal bool IsSetDomainWithSuffix() => this.DomainWithSuffix != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The network connection protocol observed in the activity that prompted GuardDuty to
        /// generate the finding.
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property VpcOwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the VPC through which the DNS request
        /// was made.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string VpcOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the VpcOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetVpcOwnerAccountId() => this.VpcOwnerAccountId != null;
    }
}
