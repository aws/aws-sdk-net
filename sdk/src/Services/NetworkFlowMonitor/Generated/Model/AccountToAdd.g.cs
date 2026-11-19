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

namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// An account that you can add to the monitoring scope for a monitor, so that Network
    /// Flow Monitor can resolve the network paths for traffic to and from resources in the
    /// account.
    /// </summary>
    public partial class AccountToAdd
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the account that you can add to the monitoring scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Membership. 
        /// <para>
        /// Whether the account is a member of the same organization as the account that owns
        /// the monitor. The membership status can be one of the following
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_ORG</c>: The account is a member of the same organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_IN_ORG</c>: The account isn't a member of the same organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNKNOWN</c>: Network Flow Monitor can't determine the organization membership
        /// of the account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public OrgMembershipStatus Membership { get; set; }

        /// <summary>
        /// Checks to see if the Membership property is set.
        /// </summary>
        internal bool IsSetMembership() => this.Membership != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region of the traffic that Network Flow Monitor identified
        /// for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;
    }
}
