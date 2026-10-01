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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// This is the response object from the UpdateUser operation.
    /// </summary>
    public partial class UpdateUserResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CodeValidation. 
        /// <para>
        /// Indicates whether the user can be verified through a custom invite code.
        /// </para>
        /// </summary>
        public bool? CodeValidation { get; set; }

        /// <summary>
        /// Checks to see if the CodeValidation property is set.
        /// </summary>
        internal bool IsSetCodeValidation() => this.CodeValidation.HasValue;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The updated first name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property InviteCode. 
        /// <para>
        /// The updated invite code for the user, if applicable.
        /// </para>
        /// </summary>
        public string InviteCode { get; set; }

        /// <summary>
        /// Checks to see if the InviteCode property is set.
        /// </summary>
        internal bool IsSetInviteCode() => this.InviteCode != null;

        /// <summary>
        /// Gets and sets the property InviteExpiration. 
        /// <para>
        /// The expiration time of the user's invite code, specified in epoch seconds.
        /// </para>
        /// </summary>
        public int? InviteExpiration { get; set; }

        /// <summary>
        /// Checks to see if the InviteExpiration property is set.
        /// </summary>
        internal bool IsSetInviteExpiration() => this.InviteExpiration.HasValue;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The updated last name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property MiddleName. 
        /// <para>
        /// The middle name of the user (currently not used).
        /// </para>
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Checks to see if the MiddleName property is set.
        /// </summary>
        internal bool IsSetMiddleName() => this.MiddleName != null;

        /// <summary>
        /// Gets and sets the property Modified. 
        /// <para>
        /// The timestamp when the user was last modified, specified in epoch seconds.
        /// </para>
        /// </summary>
        public int? Modified { get; set; }

        /// <summary>
        /// Checks to see if the Modified property is set.
        /// </summary>
        internal bool IsSetModified() => this.Modified.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the network where the user was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 8)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The list of security group IDs to which the user now belongs after the update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The user's status after the update.
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;

        /// <summary>
        /// Gets and sets the property Suspended. 
        /// <para>
        /// Indicates whether the user is suspended after the update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Suspended { get; set; }

        /// <summary>
        /// Checks to see if the Suspended property is set.
        /// </summary>
        internal bool IsSetSuspended() => this.Suspended.HasValue;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique identifier of the updated user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
