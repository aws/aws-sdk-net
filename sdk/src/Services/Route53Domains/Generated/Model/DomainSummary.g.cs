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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Summary information about one domain.
    /// </summary>
    public partial class DomainSummary
    {
        /// <summary>
        /// Gets and sets the property AutoRenew. 
        /// <para>
        /// Indicates whether the domain is automatically renewed upon expiration.
        /// </para>
        /// </summary>
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Checks to see if the AutoRenew property is set.
        /// </summary>
        internal bool IsSetAutoRenew() => this.AutoRenew.HasValue;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that the summary information applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Expiry. 
        /// <para>
        /// Expiration date of the domain in Unix time format and Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        public DateTime? Expiry { get; set; }

        /// <summary>
        /// Checks to see if the Expiry property is set.
        /// </summary>
        internal bool IsSetExpiry() => this.Expiry.HasValue;

        /// <summary>
        /// Gets and sets the property TransferLock. 
        /// <para>
        /// Indicates whether a domain is locked from unauthorized transfer to another party.
        /// </para>
        /// </summary>
        public bool? TransferLock { get; set; }

        /// <summary>
        /// Checks to see if the TransferLock property is set.
        /// </summary>
        internal bool IsSetTransferLock() => this.TransferLock.HasValue;
    }
}
