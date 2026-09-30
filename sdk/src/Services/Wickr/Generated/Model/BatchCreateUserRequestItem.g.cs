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
    /// Contains the details for a single user to be created in a batch user creation request.
    /// 
    ///  <note> 
    /// <para>
    /// A user can only be assigned to a single security group. Attempting to add a user to
    /// multiple security groups is not supported and will result in an error.
    /// </para>
    ///  </note> <note> 
    /// <para>
    ///  <c>codeValidation</c>, <c>inviteCode</c>, and <c>inviteCodeTtl</c> are restricted
    /// to networks under preview only.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchCreateUserRequestItem
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
        /// The first name of the user.
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
        /// A custom invite code for the user. If not provided, one will be generated automatically.
        /// </para>
        /// </summary>
        public string InviteCode { get; set; }

        /// <summary>
        /// Checks to see if the InviteCode property is set.
        /// </summary>
        internal bool IsSetInviteCode() => this.InviteCode != null;

        /// <summary>
        /// Gets and sets the property InviteCodeTtl. 
        /// <para>
        /// The time-to-live for the invite code in days. After this period, the invite code will
        /// expire.
        /// </para>
        /// </summary>
        public int? InviteCodeTtl { get; set; }

        /// <summary>
        /// Checks to see if the InviteCodeTtl property is set.
        /// </summary>
        internal bool IsSetInviteCodeTtl() => this.InviteCodeTtl.HasValue;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of security group IDs to which the user should be assigned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The email address or username for the user. Must be unique within the network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
