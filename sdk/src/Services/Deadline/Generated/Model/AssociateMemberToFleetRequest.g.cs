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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateMemberToFleet operation. Assigns a fleet
    /// membership level to a member.
    /// </summary>
    public partial class AssociateMemberToFleetRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property FarmId. The farm ID of the fleet to associate with the
        /// member.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property FleetId. The ID of the fleet to associate with a member.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterRegion. The Region of the IAM Identity Center
        /// instance. If not provided, the service defaults to the Region of the farm.
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string IdentityCenterRegion { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterRegion property is set.
        /// </summary>
        internal bool IsSetIdentityCenterRegion() => this.IdentityCenterRegion != null;

        /// <summary>
        /// Gets and sets the property IdentityStoreId. The member's identity store ID to associate
        /// with the fleet.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreId property is set.
        /// </summary>
        internal bool IsSetIdentityStoreId() => this.IdentityStoreId != null;

        /// <summary>
        /// Gets and sets the property MembershipLevel. The principal's membership level for the
        /// associated fleet.
        /// </summary>
        [AWSProperty(Required = true)]
        public MembershipLevel MembershipLevel { get; set; }

        /// <summary>
        /// Checks to see if the MembershipLevel property is set.
        /// </summary>
        internal bool IsSetMembershipLevel() => this.MembershipLevel != null;

        /// <summary>
        /// Gets and sets the property PrincipalId. The member's principal ID to associate with
        /// a fleet.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 47)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalId property is set.
        /// </summary>
        internal bool IsSetPrincipalId() => this.PrincipalId != null;

        /// <summary>
        /// Gets and sets the property PrincipalType. The member's principal type to associate
        /// with the fleet.
        /// </summary>
        [AWSProperty(Required = true)]
        public PrincipalType PrincipalType { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalType property is set.
        /// </summary>
        internal bool IsSetPrincipalType() => this.PrincipalType != null;
    }
}
