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
    /// This is the response object from the DescribeUser operation.
    /// </summary>
    public partial class DescribeUserResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// City where the user is located.
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
        /// Company of the user.
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
        /// Country where the user is located.
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
        /// Department of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Department { get; set; }

        /// <summary>
        /// Checks to see if the Department property is set.
        /// </summary>
        internal bool IsSetDepartment() => this.Department != null;

        /// <summary>
        /// Gets and sets the property DisabledDate. 
        /// <para>
        /// The date and time at which the user was disabled for WorkMail usage, in UNIX epoch
        /// time format.
        /// </para>
        /// </summary>
        public DateTime? DisabledDate { get; set; }

        /// <summary>
        /// Checks to see if the DisabledDate property is set.
        /// </summary>
        internal bool IsSetDisabledDate() => this.DisabledDate.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 254)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property EnabledDate. 
        /// <para>
        /// The date and time at which the user was enabled for WorkMailusage, in UNIX epoch time
        /// format.
        /// </para>
        /// </summary>
        public DateTime? EnabledDate { get; set; }

        /// <summary>
        /// Checks to see if the EnabledDate property is set.
        /// </summary>
        internal bool IsSetEnabledDate() => this.EnabledDate.HasValue;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// First name of the user.
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
        /// Gets and sets the property IdentityProviderIdentityStoreId. 
        /// <para>
        ///  Identity Store ID from the IAM Identity Center. If this parameter is empty it will
        /// be updated automatically when the user logs in for the first time to the mailbox associated
        /// with WorkMail. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string IdentityProviderIdentityStoreId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderIdentityStoreId property is set.
        /// </summary>
        internal bool IsSetIdentityProviderIdentityStoreId() => this.IdentityProviderIdentityStoreId != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderUserId. 
        /// <para>
        /// User ID from the IAM Identity Center. If this parameter is empty it will be updated
        /// automatically when the user logs in for the first time to the mailbox associated with
        /// WorkMail.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 47)]
        public string IdentityProviderUserId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderUserId property is set.
        /// </summary>
        internal bool IsSetIdentityProviderUserId() => this.IdentityProviderUserId != null;

        /// <summary>
        /// Gets and sets the property Initials. 
        /// <para>
        /// Initials of the user.
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
        /// Job title of the user.
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
        /// Last name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property MailboxDeprovisionedDate. 
        /// <para>
        /// The date when the mailbox was removed for the user.
        /// </para>
        /// </summary>
        public DateTime? MailboxDeprovisionedDate { get; set; }

        /// <summary>
        /// Checks to see if the MailboxDeprovisionedDate property is set.
        /// </summary>
        internal bool IsSetMailboxDeprovisionedDate() => this.MailboxDeprovisionedDate.HasValue;

        /// <summary>
        /// Gets and sets the property MailboxProvisionedDate. 
        /// <para>
        /// The date when the mailbox was created for the user.
        /// </para>
        /// </summary>
        public DateTime? MailboxProvisionedDate { get; set; }

        /// <summary>
        /// Checks to see if the MailboxProvisionedDate property is set.
        /// </summary>
        internal bool IsSetMailboxProvisionedDate() => this.MailboxProvisionedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Office. 
        /// <para>
        /// Office where the user is located.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Office { get; set; }

        /// <summary>
        /// Checks to see if the Office property is set.
        /// </summary>
        internal bool IsSetOffice() => this.Office != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of a user: enabled (registered to WorkMail) or disabled (deregistered or
        /// never registered to WorkMail).
        /// </para>
        /// </summary>
        public EntityState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Street. 
        /// <para>
        /// Street where the user is located.
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
        /// User's contact number.
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
        /// The identifier for the described user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 256)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

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
        public UserRole UserRole { get; set; }

        /// <summary>
        /// Checks to see if the UserRole property is set.
        /// </summary>
        internal bool IsSetUserRole() => this.UserRole != null;

        /// <summary>
        /// Gets and sets the property ZipCode. 
        /// <para>
        /// Zip code of the user.
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
