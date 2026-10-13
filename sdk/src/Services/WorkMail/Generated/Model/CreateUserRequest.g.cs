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
    /// Container for the parameters to the CreateUser operation. Creates a user who can be
    /// used in WorkMail by calling the <a>RegisterToWorkMail</a> operation.
    /// </summary>
    public partial class CreateUserRequest : AmazonWorkMailRequest
    {
        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name for the new user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 256)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name of the new user.
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
        /// If this parameter is enabled, the user will be hidden from the address book.
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
        [AWSProperty(Min = 1, Max = 47)]
        public string IdentityProviderUserId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderUserId property is set.
        /// </summary>
        internal bool IsSetIdentityProviderUserId() => this.IdentityProviderUserId != null;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name of the new user. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the new user. WorkMail directory user names have a maximum length of
        /// 64. All others have a maximum length of 20.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier of the organization for which the user is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password for the new user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

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
        public UserRole Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;
    }
}
