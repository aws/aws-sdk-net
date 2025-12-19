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
    /// This is the response object from the UpdateUser operation.
    /// </summary>
    public partial class UpdateUserResponse : AmazonWebServiceResponse
    {
        private bool? _codeValidation;
        private string _firstName;
        private string _inviteCode;
        private int? _inviteExpiration;
        private string _lastName;
        private string _middleName;
        private int? _modified;
        private string _networkId;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _status;
        private bool? _suspended;
        private string _userId;

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
        /// The updated first name of the user.
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
        /// The updated invite code for the user, if applicable.
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
        /// Gets and sets the property InviteExpiration. 
        /// <para>
        /// The expiration time of the user's invite code, specified in epoch seconds.
        /// </para>
        /// </summary>
        public int InviteExpiration
        {
            get { return this._inviteExpiration.GetValueOrDefault(); }
            set { this._inviteExpiration = value; }
        }

        // Check to see if InviteExpiration property is set
        internal bool IsSetInviteExpiration()
        {
            return this._inviteExpiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The updated last name of the user.
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
        /// Gets and sets the property MiddleName. 
        /// <para>
        /// The middle name of the user (currently not used).
        /// </para>
        /// </summary>
        public string MiddleName
        {
            get { return this._middleName; }
            set { this._middleName = value; }
        }

        // Check to see if MiddleName property is set
        internal bool IsSetMiddleName()
        {
            return this._middleName != null;
        }

        /// <summary>
        /// Gets and sets the property Modified. 
        /// <para>
        /// The timestamp when the user was last modified, specified in epoch seconds.
        /// </para>
        /// </summary>
        public int Modified
        {
            get { return this._modified.GetValueOrDefault(); }
            set { this._modified = value; }
        }

        // Check to see if Modified property is set
        internal bool IsSetModified()
        {
            return this._modified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the network where the user was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=8)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The list of security group IDs to which the user now belongs after the update.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The user's status after the update.
        /// </para>
        /// </summary>
        public int Status
        {
            get { return this._status.GetValueOrDefault(); }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Suspended. 
        /// <para>
        /// Indicates whether the user is suspended after the update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Suspended
        {
            get { return this._suspended.GetValueOrDefault(); }
            set { this._suspended = value; }
        }

        // Check to see if Suspended property is set
        internal bool IsSetSuspended()
        {
            return this._suspended.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique identifier of the updated user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}