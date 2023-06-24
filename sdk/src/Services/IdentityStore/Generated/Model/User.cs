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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// A user object that contains the metadata and attributes for a specified user.
    /// </summary>
    public partial class User
    {
        private List<Address> _addresses = new List<Address>();
        private string _displayName;
        private List<Email> _emails = new List<Email>();
        private List<ExternalId> _externalIds = new List<ExternalId>();
        private string _identityStoreId;
        private string _locale;
        private Name _name;
        private string _nickName;
        private List<PhoneNumber> _phoneNumbers = new List<PhoneNumber>();
        private string _preferredLanguage;
        private string _profileUrl;
        private string _timezone;
        private string _title;
        private string _userId;
        private string _userName;
        private string _userType;

        /// <summary>
        /// Gets and sets the property Addresses. 
        /// <para>
        /// A list of <code>Address</code> objects containing addresses associated with the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<Address> Addresses
        {
            get { return this._addresses; }
            set { this._addresses = value; }
        }

        // Check to see if Addresses property is set
        internal bool IsSetAddresses()
        {
            return this._addresses != null && this._addresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A string containing the name of the user that is formatted for display when the user
        /// is referenced. For example, "John Doe."
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
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
        /// Gets and sets the property Emails. 
        /// <para>
        /// A list of <code>Email</code> objects containing email addresses associated with the
        /// user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<Email> Emails
        {
            get { return this._emails; }
            set { this._emails = value; }
        }

        // Check to see if Emails property is set
        internal bool IsSetEmails()
        {
            return this._emails != null && this._emails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExternalIds. 
        /// <para>
        /// A list of <code>ExternalId</code> objects that contains the identifiers issued to
        /// this resource by an external identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ExternalId> ExternalIds
        {
            get { return this._externalIds; }
            set { this._externalIds = value; }
        }

        // Check to see if ExternalIds property is set
        internal bool IsSetExternalIds()
        {
            return this._externalIds != null && this._externalIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The globally unique identifier for the identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string IdentityStoreId
        {
            get { return this._identityStoreId; }
            set { this._identityStoreId = value; }
        }

        // Check to see if IdentityStoreId property is set
        internal bool IsSetIdentityStoreId()
        {
            return this._identityStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// A string containing the geographical region or location of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Locale
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
        /// Gets and sets the property Name. 
        /// <para>
        /// An object containing the name of the user.
        /// </para>
        /// </summary>
        public Name Name
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
        /// Gets and sets the property NickName. 
        /// <para>
        /// A string containing an alternate name for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string NickName
        {
            get { return this._nickName; }
            set { this._nickName = value; }
        }

        // Check to see if NickName property is set
        internal bool IsSetNickName()
        {
            return this._nickName != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumbers. 
        /// <para>
        /// A list of <code>PhoneNumber</code> objects containing phone numbers associated with
        /// the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<PhoneNumber> PhoneNumbers
        {
            get { return this._phoneNumbers; }
            set { this._phoneNumbers = value; }
        }

        // Check to see if PhoneNumbers property is set
        internal bool IsSetPhoneNumbers()
        {
            return this._phoneNumbers != null && this._phoneNumbers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PreferredLanguage. 
        /// <para>
        /// A string containing the preferred language of the user. For example, "American English"
        /// or "en-us."
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string PreferredLanguage
        {
            get { return this._preferredLanguage; }
            set { this._preferredLanguage = value; }
        }

        // Check to see if PreferredLanguage property is set
        internal bool IsSetPreferredLanguage()
        {
            return this._preferredLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileUrl. 
        /// <para>
        /// A string containing a URL that might be associated with the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string ProfileUrl
        {
            get { return this._profileUrl; }
            set { this._profileUrl = value; }
        }

        // Check to see if ProfileUrl property is set
        internal bool IsSetProfileUrl()
        {
            return this._profileUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// A string containing the time zone of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A string containing the title of the user. Possible values are left unspecified. The
        /// value can vary based on your specific use case.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier for a user in the identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=47)]
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// A unique string used to identify the user. The length limit is 128 characters. This
        /// value can consist of letters, accented characters, symbols, numbers, and punctuation.
        /// This value is specified at the time the user is created and stored as an attribute
        /// of the user object in the identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

        /// <summary>
        /// Gets and sets the property UserType. 
        /// <para>
        /// A string indicating the type of user. Possible values are left unspecified. The value
        /// can vary based on your specific use case.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string UserType
        {
            get { return this._userType; }
            set { this._userType = value; }
        }

        // Check to see if UserType property is set
        internal bool IsSetUserType()
        {
            return this._userType != null;
        }

    }
}