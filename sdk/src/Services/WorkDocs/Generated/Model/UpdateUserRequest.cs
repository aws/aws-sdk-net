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
    /// Container for the parameters to the UpdateUser operation.
    /// Updates the specified attributes of the specified user, and grants or revokes administrative
    /// privileges to the Amazon WorkDocs site.
    /// </summary>
    public partial class UpdateUserRequest : AmazonWorkDocsRequest
    {
        private string _authenticationToken;
        private string _givenName;
        private BooleanEnumType _grantPoweruserPrivileges;
        private LocaleType _locale;
        private StorageRuleType _storageRule;
        private string _surname;
        private string _timeZoneId;
        private UserType _type;
        private string _userId;

        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Not required when using Amazon Web Services
        /// administrator credentials to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=8199)]
        public string AuthenticationToken
        {
            get { return this._authenticationToken; }
            set { this._authenticationToken = value; }
        }

        // Check to see if AuthenticationToken property is set
        internal bool IsSetAuthenticationToken()
        {
            return this._authenticationToken != null;
        }

        /// <summary>
        /// Gets and sets the property GivenName. 
        /// <para>
        /// The given name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
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
        /// Gets and sets the property GrantPoweruserPrivileges. 
        /// <para>
        /// Boolean value to determine whether the user is granted Power user privileges.
        /// </para>
        /// </summary>
        public BooleanEnumType GrantPoweruserPrivileges
        {
            get { return this._grantPoweruserPrivileges; }
            set { this._grantPoweruserPrivileges = value; }
        }

        // Check to see if GrantPoweruserPrivileges property is set
        internal bool IsSetGrantPoweruserPrivileges()
        {
            return this._grantPoweruserPrivileges != null;
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
        /// Gets and sets the property StorageRule. 
        /// <para>
        /// The amount of storage for the user.
        /// </para>
        /// </summary>
        public StorageRuleType StorageRule
        {
            get { return this._storageRule; }
            set { this._storageRule = value; }
        }

        // Check to see if StorageRule property is set
        internal bool IsSetStorageRule()
        {
            return this._storageRule != null;
        }

        /// <summary>
        /// Gets and sets the property Surname. 
        /// <para>
        /// The surname of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
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
        /// The type of the user.
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
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the user.
        /// </para>
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

    }
}