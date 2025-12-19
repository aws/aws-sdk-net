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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
    /// Contains the modifiable details for updating an existing user, including name, password,
    /// security group membership, and invitation settings.
    /// 
    ///  <note> 
    /// <para>
    /// A user can only be assigned to a single security group. Attempting to add a user to
    /// multiple security groups is not supported and will result in an error.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateUserDetails
    {
        private bool? _codeValidation;
        private string _firstName;
        private string _inviteCode;
        private int? _inviteCodeTtl;
        private string _lastName;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _username;

        /// <summary>
        /// Gets and sets the property CodeValidation. 
        /// <para>
        /// Indicates whether the user can be verified through a custom invite code.
        /// </para>
        /// </summary>
        public bool CodeValidation
        {
            get { return this._codeValidation.GetValueOrDefault(); }
            set { this._codeValidation = value; }
        }

        // Check to see if CodeValidation property is set
        internal bool IsSetCodeValidation()
        {
            return this._codeValidation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The new first name for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        // Check to see if FirstName property is set
        internal bool IsSetFirstName()
        {
            return this._firstName != null;
        }

        /// <summary>
        /// Gets and sets the property InviteCode. 
        /// <para>
        /// A new custom invite code for the user.
        /// </para>
        /// </summary>
        public string InviteCode
        {
            get { return this._inviteCode; }
            set { this._inviteCode = value; }
        }

        // Check to see if InviteCode property is set
        internal bool IsSetInviteCode()
        {
            return this._inviteCode != null;
        }

        /// <summary>
        /// Gets and sets the property InviteCodeTtl. 
        /// <para>
        /// The new time-to-live for the invite code in days.
        /// </para>
        /// </summary>
        public int InviteCodeTtl
        {
            get { return this._inviteCodeTtl.GetValueOrDefault(); }
            set { this._inviteCodeTtl = value; }
        }

        // Check to see if InviteCodeTtl property is set
        internal bool IsSetInviteCodeTtl()
        {
            return this._inviteCodeTtl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The new last name for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        // Check to see if LastName property is set
        internal bool IsSetLastName()
        {
            return this._lastName != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The updated list of security group IDs to which the user should belong.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The new username or email address for the user.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}