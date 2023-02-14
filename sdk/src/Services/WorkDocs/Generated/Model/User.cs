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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Describes a user.
    /// </summary>
    public partial class User
    {
        private DateTime? _createdTimestamp;
        private string _emailAddress;
        private string _givenName;
        private string _id;
        private LocaleType _locale;
        private DateTime? _modifiedTimestamp;
        private string _organizationId;
        private string _recycleBinFolderId;
        private string _rootFolderId;
        private UserStatusType _status;
        private UserStorageMetadata _storage;
        private string _surname;
        private string _timeZoneId;
        private UserType _type;
        private string _username;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the user was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
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
        /// Gets and sets the property GivenName. 
        /// <para>
        /// The given name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string GivenName
        {
            get { return this._givenName; }
            set { this._givenName = value; }
        }

        // Check to see if GivenName property is set
        internal bool IsSetGivenName()
        {
            return this._givenName != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale of the user.
        /// </para>
        /// </summary>
        public LocaleType Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedTimestamp. 
        /// <para>
        /// The time when the user was modified.
        /// </para>
        /// </summary>
        public DateTime ModifiedTimestamp
        {
            get { return this._modifiedTimestamp.GetValueOrDefault(); }
            set { this._modifiedTimestamp = value; }
        }

        // Check to see if ModifiedTimestamp property is set
        internal bool IsSetModifiedTimestamp()
        {
            return this._modifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property RecycleBinFolderId. 
        /// <para>
        /// The ID of the recycle bin folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RecycleBinFolderId
        {
            get { return this._recycleBinFolderId; }
            set { this._recycleBinFolderId = value; }
        }

        // Check to see if RecycleBinFolderId property is set
        internal bool IsSetRecycleBinFolderId()
        {
            return this._recycleBinFolderId != null;
        }

        /// <summary>
        /// Gets and sets the property RootFolderId. 
        /// <para>
        /// The ID of the root folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RootFolderId
        {
            get { return this._rootFolderId; }
            set { this._rootFolderId = value; }
        }

        // Check to see if RootFolderId property is set
        internal bool IsSetRootFolderId()
        {
            return this._rootFolderId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the user.
        /// </para>
        /// </summary>
        public UserStatusType Status
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
        /// Gets and sets the property Storage. 
        /// <para>
        /// The storage for the user.
        /// </para>
        /// </summary>
        public UserStorageMetadata Storage
        {
            get { return this._storage; }
            set { this._storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this._storage != null;
        }

        /// <summary>
        /// Gets and sets the property Surname. 
        /// <para>
        /// The surname of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Surname
        {
            get { return this._surname; }
            set { this._surname = value; }
        }

        // Check to see if Surname property is set
        internal bool IsSetSurname()
        {
            return this._surname != null;
        }

        /// <summary>
        /// Gets and sets the property TimeZoneId. 
        /// <para>
        /// The time zone ID of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TimeZoneId
        {
            get { return this._timeZoneId; }
            set { this._timeZoneId = value; }
        }

        // Check to see if TimeZoneId property is set
        internal bool IsSetTimeZoneId()
        {
            return this._timeZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of user.
        /// </para>
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
        /// Gets and sets the property Username. 
        /// <para>
        /// The login name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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