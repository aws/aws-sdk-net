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
    /// Container for the parameters to the UpdateUser operation.
    /// Updates data for the user. To have the latest information, it must be preceded by
    /// a <a>DescribeUser</a> call. The dataset in the request should be the one expected
    /// when performing another <c>DescribeUser</c> call.
    /// </summary>
    public partial class UpdateUserRequest : AmazonWorkMailRequest
    {
        private string _city;
        private string _company;
        private string _country;
        private string _department;
        private string _displayName;
        private string _firstName;
        private bool? _hiddenFromGlobalAddressList;
        private string _identityProviderUserId;
        private string _initials;
        private string _jobTitle;
        private string _lastName;
        private string _office;
        private string _organizationId;
        private UserRole _role;
        private string _street;
        private string _telephone;
        private string _userId;
        private string _zipCode;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// Updates the user's city.
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
        /// Updates the user's company.
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
        /// Updates the user's country.
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
        /// Updates the user's department.
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// Updates the display name of the user.
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
        /// Gets and sets the property FirstName. 
        /// <para>
        /// Updates the user's first name.
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
        /// Gets and sets the property IdentityProviderUserId. 
        /// <para>
        /// User ID from the IAM Identity Center. If this parameter is empty it will be updated
        /// automatically when the user logs in for the first time to the mailbox associated with
        /// WorkMail.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=47)]
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
        /// Updates the user's initials.
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
        /// Updates the user's job title.
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
        /// Updates the user's last name.
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
        /// Gets and sets the property Office. 
        /// <para>
        /// Updates the user's office.
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
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier for the organization under which the user exists.
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
        /// Gets and sets the property Role. 
        /// <para>
        /// Updates the user role.
        /// </para>
        ///  
        /// <para>
        /// You cannot pass <i>SYSTEM_USER</i> or <i>RESOURCE</i>.
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

        /// <summary>
        /// Gets and sets the property Street. 
        /// <para>
        /// Updates the user's street address.
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
        /// Updates the user's contact details.
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
        /// The identifier for the user to be updated.
        /// </para>
        ///  
        /// <para>
        /// The identifier can be the <i>UserId</i>, <i>Username</i>, or <i>email</i>. The following
        /// identity formats are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// User ID: 12345678-1234-1234-1234-123456789012 or S-1-1-12-1234567890-123456789-123456789-1234
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Email address: user@domain.tld
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User name: user
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property ZipCode. 
        /// <para>
        /// Updates the user's zip code.
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