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
    /// This is the response object from the GetUser operation.
    /// </summary>
    public partial class GetUserResponse : AmazonWebServiceResponse
    {
        private string _firstName;
        private bool? _isAdmin;
        private int? _lastActivity;
        private int? _lastLogin;
        private string _lastName;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _status;
        private bool? _suspended;
        private string _userId;
        private string _username;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name of the user.
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
        /// Gets and sets the property IsAdmin. 
        /// <para>
        /// Indicates whether the user has administrator privileges in the network.
        /// </para>
        /// </summary>
        public bool IsAdmin
        {
            get { return this._isAdmin.GetValueOrDefault(); }
            set { this._isAdmin = value; }
        }

        // Check to see if IsAdmin property is set
        internal bool IsSetIsAdmin()
        {
            return this._isAdmin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastActivity. 
        /// <para>
        /// The timestamp of the user's last activity in the network, specified in epoch seconds.
        /// </para>
        /// </summary>
        public int LastActivity
        {
            get { return this._lastActivity.GetValueOrDefault(); }
            set { this._lastActivity = value; }
        }

        // Check to see if LastActivity property is set
        internal bool IsSetLastActivity()
        {
            return this._lastActivity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastLogin. 
        /// <para>
        /// The timestamp of the user's last login to the network, specified in epoch seconds.
        /// </para>
        /// </summary>
        public int LastLogin
        {
            get { return this._lastLogin.GetValueOrDefault(); }
            set { this._lastLogin = value; }
        }

        // Check to see if LastLogin property is set
        internal bool IsSetLastLogin()
        {
            return this._lastLogin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name of the user.
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
        /// A list of security group IDs to which the user belongs.
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
        /// The current status of the user (1 for pending, 2 for active).
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
        /// Indicates whether the user is currently suspended.
        /// </para>
        /// </summary>
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
        /// The unique identifier of the user.
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

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The email address or username of the user.
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