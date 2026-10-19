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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Describes a user.
    /// </summary>
    public partial class User
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the user was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property GivenName. 
        /// <para>
        /// The given name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string GivenName { get; set; }

        /// <summary>
        /// Checks to see if the GivenName property is set.
        /// </summary>
        internal bool IsSetGivenName() => this.GivenName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale of the user.
        /// </para>
        /// </summary>
        public LocaleType Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property ModifiedTimestamp. 
        /// <para>
        /// The time when the user was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedTimestamp property is set.
        /// </summary>
        internal bool IsSetModifiedTimestamp() => this.ModifiedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property RecycleBinFolderId. 
        /// <para>
        /// The ID of the recycle bin folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RecycleBinFolderId { get; set; }

        /// <summary>
        /// Checks to see if the RecycleBinFolderId property is set.
        /// </summary>
        internal bool IsSetRecycleBinFolderId() => this.RecycleBinFolderId != null;

        /// <summary>
        /// Gets and sets the property RootFolderId. 
        /// <para>
        /// The ID of the root folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RootFolderId { get; set; }

        /// <summary>
        /// Checks to see if the RootFolderId property is set.
        /// </summary>
        internal bool IsSetRootFolderId() => this.RootFolderId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the user.
        /// </para>
        /// </summary>
        public UserStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Storage. 
        /// <para>
        /// The storage for the user.
        /// </para>
        /// </summary>
        public UserStorageMetadata Storage { get; set; }

        /// <summary>
        /// Checks to see if the Storage property is set.
        /// </summary>
        internal bool IsSetStorage() => this.Storage != null;

        /// <summary>
        /// Gets and sets the property Surname. 
        /// <para>
        /// The surname of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string Surname { get; set; }

        /// <summary>
        /// Checks to see if the Surname property is set.
        /// </summary>
        internal bool IsSetSurname() => this.Surname != null;

        /// <summary>
        /// Gets and sets the property TimeZoneId. 
        /// <para>
        /// The time zone ID of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// Checks to see if the TimeZoneId property is set.
        /// </summary>
        internal bool IsSetTimeZoneId() => this.TimeZoneId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of user.
        /// </para>
        /// </summary>
        public UserType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The login name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
