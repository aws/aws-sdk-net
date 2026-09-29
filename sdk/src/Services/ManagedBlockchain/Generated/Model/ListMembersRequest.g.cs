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

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Container for the parameters to the ListMembers operation. Returns a list of the members
    /// in a network and properties of their configurations. <para> Applies only to Hyperledger
    /// Fabric. </para>
    /// </summary>
    public partial class ListMembersRequest : AmazonManagedBlockchainRequest
    {
        /// <summary>
        /// Gets and sets the property IsOwned. 
        /// <para>
        /// An optional Boolean value. If provided, the request is limited either to members that
        /// the current Amazon Web Services account owns (<c>true</c>) or that other Amazon Web
        /// Services accountsn own (<c>false</c>). If omitted, all members are listed.
        /// </para>
        /// </summary>
        public bool? IsOwned { get; set; }

        /// <summary>
        /// Checks to see if the IsOwned property is set.
        /// </summary>
        internal bool IsSetIsOwned() => this.IsOwned.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of members to return in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The optional name of the member to list.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The unique identifier of the network for which to list members.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token that indicates the next set of results to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// An optional status specifier. If provided, only members currently in this status are
        /// listed.
        /// </para>
        /// </summary>
        public MemberStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
