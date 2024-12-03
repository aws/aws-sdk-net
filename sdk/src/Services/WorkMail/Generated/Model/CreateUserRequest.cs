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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUser operation.
    /// Creates a user who can be used in WorkMail by calling the <a>RegisterToWorkMail</a>
    /// operation.
    /// </summary>
    public partial class CreateUserRequest : AmazonWorkMailRequest
    {
        private string _displayName;
        private string _firstName;
        private bool? _hiddenFromGlobalAddressList;
        private string _identityProviderUserId;
        private string _lastName;
        private string _name;
        private string _organizationId;
        private string _password;
        private UserRole _role;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name for the new user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=256)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name of the new user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
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
        /// Gets and sets the property HiddenFromGlobalAddressList. 
        /// <para>
        /// If this parameter is enabled, the user will be hidden from the address book.
        /// </para>
        /// </summary>
        public bool? HiddenFromGlobalAddressList
        {
            get { return this._hiddenFromGlobalAddressList; }
            set { this._hiddenFromGlobalAddressList = value; }
        }

        // Check to see if HiddenFromGlobalAddressList property is set
        internal bool IsSetHiddenFromGlobalAddressList()
        {
            return this._hiddenFromGlobalAddressList.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderUserId. 
        /// <para>
        /// User ID from the IAM Identity Center. If this parameter is empty it will be updated
        /// automatically when the user logs in for the first time to the mailbox associated with
        /// WorkMail.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=47)]
        public string IdentityProviderUserId
        {
            get { return this._identityProviderUserId; }
            set { this._identityProviderUserId = value; }
        }

        // Check to see if IdentityProviderUserId property is set
        internal bool IsSetIdentityProviderUserId()
        {
            return this._identityProviderUserId != null;
        }

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name of the new user. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the new user. WorkMail directory user names have a maximum length of
        /// 64. All others have a maximum length of 20.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier of the organization for which the user is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password for the new user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The role of the new user.
        /// </para>
        ///  
        /// <para>
        /// You cannot pass <i>SYSTEM_USER</i> or <i>RESOURCE</i> role in a single request. When
        /// a user role is not selected, the default role of <i>USER</i> is selected.
        /// </para>
        /// </summary>
        public UserRole Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

    }
}