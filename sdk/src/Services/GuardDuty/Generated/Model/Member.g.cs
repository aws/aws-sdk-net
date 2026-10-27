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
    /// Contains information about the member account.
    /// </summary>
    public partial class Member
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AdministratorId. 
        /// <para>
        /// The administrator account ID.
        /// </para>
        /// </summary>
        public string AdministratorId { get; set; }

        /// <summary>
        /// Checks to see if the AdministratorId property is set.
        /// </summary>
        internal bool IsSetAdministratorId() => this.AdministratorId != null;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The detector ID of the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 64)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property InvitedAt. 
        /// <para>
        /// The timestamp when the invitation was sent.
        /// </para>
        /// </summary>
        public string InvitedAt { get; set; }

        /// <summary>
        /// Checks to see if the InvitedAt property is set.
        /// </summary>
        internal bool IsSetInvitedAt() => this.InvitedAt != null;

        /// <summary>
        /// Gets and sets the property MasterId. 
        /// <para>
        /// The administrator account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MasterId { get; set; }

        /// <summary>
        /// Checks to see if the MasterId property is set.
        /// </summary>
        internal bool IsSetMasterId() => this.MasterId != null;

        /// <summary>
        /// Gets and sets the property RelationshipStatus. 
        /// <para>
        /// The status of the relationship between the member and the administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RelationshipStatus { get; set; }

        /// <summary>
        /// Checks to see if the RelationshipStatus property is set.
        /// </summary>
        internal bool IsSetRelationshipStatus() => this.RelationshipStatus != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The last-updated timestamp of the member.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt != null;
    }
}
