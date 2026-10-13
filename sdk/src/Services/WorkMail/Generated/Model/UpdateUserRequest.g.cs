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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUser operation. Updates data for the user.
    /// To have the latest information, it must be preceded by a <a>DescribeUser</a> call.
    /// The dataset in the request should be the one expected when performing another <c>DescribeUser</c>
    /// call.
    /// </summary>
    public partial class UpdateUserRequest : AmazonWorkMailRequest
    {
        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// Updates the user's city.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property Company. 
        /// <para>
        /// Updates the user's company.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Company { get; set; }

        /// <summary>
        /// Checks to see if the Company property is set.
        /// </summary>
        internal bool IsSetCompany() => this.Company != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// Updates the user's country.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property Department. 
        /// <para>
        /// Updates the user's department.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Department { get; set; }

        /// <summary>
        /// Checks to see if the Department property is set.
        /// </summary>
        internal bool IsSetDepartment() => this.Department != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// Updates the display name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// Updates the user's first name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property HiddenFromGlobalAddressList. 
        /// <para>
        /// If enabled, the user is hidden from the global address list.
        /// </para>
        /// </summary>
        public bool? HiddenFromGlobalAddressList { get; set; }

        /// <summary>
        /// Checks to see if the HiddenFromGlobalAddressList property is set.
        /// </summary>
        internal bool IsSetHiddenFromGlobalAddressList() => this.HiddenFromGlobalAddressList.HasValue;

        /// <summary>
        /// Gets and sets the property IdentityProviderUserId. 
        /// <para>
        /// User ID from the IAM Identity Center. If this parameter is empty it will be updated
        /// automatically when the user logs in for the first time to the mailbox associated with
        /// WorkMail.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 47)]
        public string IdentityProviderUserId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderUserId property is set.
        /// </summary>
        internal bool IsSetIdentityProviderUserId() => this.IdentityProviderUserId != null;

        /// <summary>
        /// Gets and sets the property Initials. 
        /// <para>
        /// Updates the user's initials.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Initials { get; set; }

        /// <summary>
        /// Checks to see if the Initials property is set.
        /// </summary>
        internal bool IsSetInitials() => this.Initials != null;

        /// <summary>
        /// Gets and sets the property JobTitle. 
        /// <para>
        /// Updates the user's job title.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string JobTitle { get; set; }

        /// <summary>
        /// Checks to see if the JobTitle property is set.
        /// </summary>
        internal bool IsSetJobTitle() => this.JobTitle != null;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// Updates the user's last name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property Office. 
        /// <para>
        /// Updates the user's office.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Office { get; set; }

        /// <summary>
        /// Checks to see if the Office property is set.
        /// </summary>
        internal bool IsSetOffice() => this.Office != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier for the organization under which the user exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

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
        public UserRole Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property Street. 
        /// <para>
        /// Updates the user's street address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Street { get; set; }

        /// <summary>
        /// Checks to see if the Street property is set.
        /// </summary>
        internal bool IsSetStreet() => this.Street != null;

        /// <summary>
        /// Gets and sets the property Telephone. 
        /// <para>
        /// Updates the user's contact details.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Telephone { get; set; }

        /// <summary>
        /// Checks to see if the Telephone property is set.
        /// </summary>
        internal bool IsSetTelephone() => this.Telephone != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property ZipCode. 
        /// <para>
        /// Updates the user's zip code.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Checks to see if the ZipCode property is set.
        /// </summary>
        internal bool IsSetZipCode() => this.ZipCode != null;
    }
}
