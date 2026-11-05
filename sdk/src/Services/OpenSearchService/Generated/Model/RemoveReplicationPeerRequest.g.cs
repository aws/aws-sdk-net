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
    /// Container for the parameters to the RemoveReplicationPeer operation. Stops replicating
    /// a domain to its peer. Replication ends for both domains, and each domain keeps the
    /// data it holds at that point. Neither domain is deleted.
    /// </summary>
    public partial class RemoveReplicationPeerRequest : AmazonOpenSearchServiceRequest
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
        /// Gets and sets the property PeerDomainArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the peer to stop replicating with. Both domains
        /// are named so that the request identifies exactly one replication relationship.
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
