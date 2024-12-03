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
    /// This is the response object from the DescribeUser operation.
    /// </summary>
    public partial class DescribeUserResponse : AmazonWebServiceResponse
    {
        private string _city;
        private string _company;
        private string _country;
        private string _department;
        private DateTime? _disabledDate;
        private string _displayName;
        private string _email;
        private DateTime? _enabledDate;
        private string _firstName;
        private bool? _hiddenFromGlobalAddressList;
        private string _identityProviderIdentityStoreId;
        private string _identityProviderUserId;
        private string _initials;
        private string _jobTitle;
        private string _lastName;
        private DateTime? _mailboxDeprovisionedDate;
        private DateTime? _mailboxProvisionedDate;
        private string _name;
        private string _office;
        private EntityState _state;
        private string _street;
        private string _telephone;
        private string _userId;
        private UserRole _userRole;
        private string _zipCode;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// City where the user is located.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }

        // Check to see if City property is set
        internal bool IsSetCity()
        {
            return this._city != null;
        }

        /// <summary>
        /// Gets and sets the property Company. 
        /// <para>
        /// Company of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string Company
        {
            get { return this._company; }
            set { this._company = value; }
        }

        // Check to see if Company property is set
        internal bool IsSetCompany()
        {
            return this._company != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// Country where the user is located.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property Department. 
        /// <para>
        /// Department of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string Department
        {
            get { return this._department; }
            set { this._department = value; }
        }

        // Check to see if Department property is set
        internal bool IsSetDepartment()
        {
            return this._department != null;
        }

        /// <summary>
        /// Gets and sets the property DisabledDate. 
        /// <para>
        /// The date and time at which the user was disabled for WorkMail usage, in UNIX epoch
        /// time format.
        /// </para>
        /// </summary>
        public DateTime? DisabledDate
        {
            get { return this._disabledDate; }
            set { this._disabledDate = value; }
        }

        // Check to see if DisabledDate property is set
        internal bool IsSetDisabledDate()
        {
            return this._disabledDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
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
        /// Gets and sets the property Email. 
        /// <para>
        /// The email of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=254)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledDate. 
        /// <para>
        /// The date and time at which the user was enabled for WorkMailusage, in UNIX epoch time
        /// format.
        /// </para>
        /// </summary>
        public DateTime? EnabledDate
        {
            get { return this._enabledDate; }
            set { this._enabledDate = value; }
        }

        // Check to see if EnabledDate property is set
        internal bool IsSetEnabledDate()
        {
            return this._enabledDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// First name of the user.
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
        /// If enabled, the user is hidden from the global address list.
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
        /// Gets and sets the property IdentityProviderIdentityStoreId. 
        /// <para>
        ///  Identity Store ID from the IAM Identity Center. If this parameter is empty it will
        /// be updated automatically when the user logs in for the first time to the mailbox associated
        /// with WorkMail. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string IdentityProviderIdentityStoreId
        {
            get { return this._identityProviderIdentityStoreId; }
            set { this._identityProviderIdentityStoreId = value; }
        }

        // Check to see if IdentityProviderIdentityStoreId property is set
        internal bool IsSetIdentityProviderIdentityStoreId()
        {
            return this._identityProviderIdentityStoreId != null;
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
        /// Gets and sets the property Initials. 
        /// <para>
        /// Initials of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string Initials
        {
            get { return this._initials; }
            set { this._initials = value; }
        }

        // Check to see if Initials property is set
        internal bool IsSetInitials()
        {
            return this._initials != null;
        }

        /// <summary>
        /// Gets and sets the property JobTitle. 
        /// <para>
        /// Job title of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string JobTitle
        {
            get { return this._jobTitle; }
            set { this._jobTitle = value; }
        }

        // Check to see if JobTitle property is set
        internal bool IsSetJobTitle()
        {
            return this._jobTitle != null;
        }

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// Last name of the user.
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
        /// Gets and sets the property MailboxDeprovisionedDate. 
        /// <para>
        /// The date when the mailbox was removed for the user.
        /// </para>
        /// </summary>
        public DateTime? MailboxDeprovisionedDate
        {
            get { return this._mailboxDeprovisionedDate; }
            set { this._mailboxDeprovisionedDate = value; }
        }

        // Check to see if MailboxDeprovisionedDate property is set
        internal bool IsSetMailboxDeprovisionedDate()
        {
            return this._mailboxDeprovisionedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MailboxProvisionedDate. 
        /// <para>
        /// The date when the mailbox was created for the user.
        /// </para>
        /// </summary>
        public DateTime? MailboxProvisionedDate
        {
            get { return this._mailboxProvisionedDate; }
            set { this._mailboxProvisionedDate = value; }
        }

        // Check to see if MailboxProvisionedDate property is set
        internal bool IsSetMailboxProvisionedDate()
        {
            return this._mailboxProvisionedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Office. 
        /// <para>
        /// Office where the user is located.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string Office
        {
            get { return this._office; }
            set { this._office = value; }
        }

        // Check to see if Office property is set
        internal bool IsSetOffice()
        {
            return this._office != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of a user: enabled (registered to WorkMail) or disabled (deregistered or
        /// never registered to WorkMail).
        /// </para>
        /// </summary>
        public EntityState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Street. 
        /// <para>
        /// Street where the user is located.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string Street
        {
            get { return this._street; }
            set { this._street = value; }
        }

        // Check to see if Street property is set
        internal bool IsSetStreet()
        {
            return this._street != null;
        }

        /// <summary>
        /// Gets and sets the property Telephone. 
        /// <para>
        /// User's contact number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string Telephone
        {
            get { return this._telephone; }
            set { this._telephone = value; }
        }

        // Check to see if Telephone property is set
        internal bool IsSetTelephone()
        {
            return this._telephone != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier for the described user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=256)]
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
        /// Gets and sets the property UserRole. 
        /// <para>
        /// In certain cases, other entities are modeled as users. If interoperability is enabled,
        /// resources are imported into WorkMail as users. Because different WorkMail organizations
        /// rely on different directory types, administrators can distinguish between an unregistered
        /// user (account is disabled and has a user role) and the directory administrators. The
        /// values are USER, RESOURCE, SYSTEM_USER, and REMOTE_USER.
        /// </para>
        /// </summary>
        public UserRole UserRole
        {
            get { return this._userRole; }
            set { this._userRole = value; }
        }

        // Check to see if UserRole property is set
        internal bool IsSetUserRole()
        {
            return this._userRole != null;
        }

        /// <summary>
        /// Gets and sets the property ZipCode. 
        /// <para>
        /// Zip code of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
        public string ZipCode
        {
            get { return this._zipCode; }
            set { this._zipCode = value; }
        }

        // Check to see if ZipCode property is set
        internal bool IsSetZipCode()
        {
            return this._zipCode != null;
        }

    }
}