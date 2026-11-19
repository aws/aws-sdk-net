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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// An IPAM discovered account. A discovered account is an Amazon Web Services account
    /// that is monitored under a resource discovery. If you have integrated IPAM with Amazon
    /// Web Services Organizations, all accounts in the organization are discovered accounts.
    /// </summary>
    public partial class IpamDiscoveredAccount
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property DiscoveryRegion. 
        /// <para>
        /// The Amazon Web Services Region that the account information is returned from. An account
        /// can be discovered in multiple regions and will have a separate discovered account
        /// for each Region.
        /// </para>
        /// </summary>
        public string DiscoveryRegion { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryRegion property is set.
        /// </summary>
        internal bool IsSetDiscoveryRegion() => this.DiscoveryRegion != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The resource discovery failure reason.
        /// </para>
        /// </summary>
        public IpamDiscoveryFailureReason FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastAttemptedDiscoveryTime. 
        /// <para>
        /// The last attempted resource discovery time.
        /// </para>
        /// </summary>
        public DateTime? LastAttemptedDiscoveryTime { get; set; }

        /// <summary>
        /// Checks to see if the LastAttemptedDiscoveryTime property is set.
        /// </summary>
        internal bool IsSetLastAttemptedDiscoveryTime() => this.LastAttemptedDiscoveryTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastSuccessfulDiscoveryTime. 
        /// <para>
        /// The last successful resource discovery time.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulDiscoveryTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulDiscoveryTime property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulDiscoveryTime() => this.LastSuccessfulDiscoveryTime.HasValue;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitId. 
        /// <para>
        /// The ID of an Organizational Unit in Amazon Web Services Organizations.
        /// </para>
        /// </summary>
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationalUnitId property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitId() => this.OrganizationalUnitId != null;
    }
}
