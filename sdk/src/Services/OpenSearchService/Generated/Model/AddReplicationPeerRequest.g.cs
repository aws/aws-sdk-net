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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the AddReplicationPeer operation. Starts replicating
    /// a domain to a peer domain in another AWS Region. A domain can have one peer. The domain
    /// you call becomes the primary and the peer becomes the secondary, which receives a
    /// copy of the primary's indexes and serves read requests. <para> Replication is established
    /// asynchronously. Use the <c>DescribeDomainReplication</c> operation to check whether
    /// the relationship has reached the <c>ACTIVE</c> state. </para>
    /// </summary>
    public partial class AddReplicationPeerRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DomainName.
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// When <c>true</c>, validates the request and reports whether replication could be established,
        /// without changing either domain.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property PeerDomainArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the domain to replicate to. The peer must be in
        /// a different Region from the domain you are calling, and in the same AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string PeerDomainArn { get; set; }

        /// <summary>
        /// Checks to see if the PeerDomainArn property is set.
        /// </summary>
        internal bool IsSetPeerDomainArn() => this.PeerDomainArn != null;
    }
}
