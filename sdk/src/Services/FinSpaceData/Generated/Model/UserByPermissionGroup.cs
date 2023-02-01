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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// The structure of a user account associated with a permission group.
    /// </summary>
    public partial class UserByPermissionGroup
    {
        private ApiAccess _apiAccess;
        private string _apiAccessPrincipalArn;
        private string _emailAddress;
        private string _firstName;
        private string _lastName;
        private PermissionGroupMembershipStatus _membershipStatus;
        private UserStatus _status;
        private UserType _type;
        private string _userId;

        /// <summary>
        /// Gets and sets the property ApiAccess. 
        /// <para>
        /// Indicates whether the user can access FinSpace API operations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENABLED</code> – The user has permissions to use the API operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED</code> – The user does not have permissions to use any API operations.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ApiAccess ApiAccess
        {
            get { return this._apiAccess; }
            set { this._apiAccess = value; }
        }

        // Check to see if ApiAccess property is set
        internal bool IsSetApiAccess()
        {
            return this._apiAccess != null;
        }

        /// <summary>
        /// Gets and sets the property ApiAccessPrincipalArn. 
        /// <para>
        /// The IAM ARN identifier that is attached to FinSpace API calls.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ApiAccessPrincipalArn
        {
            get { return this._apiAccessPrincipalArn; }
            set { this._apiAccessPrincipalArn = value; }
        }

        // Check to see if ApiAccessPrincipalArn property is set
        internal bool IsSetApiAccessPrincipalArn()
        {
            return this._apiAccessPrincipalArn != null;
        }

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address of the user. The email address serves as a unique identifier for
        /// each user and cannot be changed after it's created.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=4, Max=320)]
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
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
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
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
        /// Gets and sets the property MembershipStatus. 
        /// <para>
        /// Indicates the status of the user account within a permission group.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ADDITION_IN_PROGRESS</code> – The user account is currently being added to
        /// the permission group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ADDITION_SUCCESS</code> – The user account is successfully added to the permission
        /// group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REMOVAL_IN_PROGRESS</code> – The user is currently being removed from the permission
        /// group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionGroupMembershipStatus MembershipStatus
        {
            get { return this._membershipStatus; }
            set { this._membershipStatus = value; }
        }

        // Check to see if MembershipStatus property is set
        internal bool IsSetMembershipStatus()
        {
            return this._membershipStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the user account. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATING</code> – The user account creation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENABLED</code> – The user account is created and is currently active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED</code> – The user account is currently inactive.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UserStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  Indicates the type of user.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SUPER_USER</code> – A user with permission to all the functionality and data
        /// in FinSpace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>APP_USER</code> – A user with specific permissions in FinSpace. The users are
        /// assigned permissions by adding them to a permission group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UserType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique identifier for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
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