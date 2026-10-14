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

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUser operation. Creates a user within the
    /// specified identity store.
    /// </summary>
    public partial class CreateUserRequest : AmazonIdentityStoreRequest
    {
        /// <summary>
        /// Gets and sets the property Addresses. 
        /// <para>
        /// A list of <c>Address</c> objects containing addresses associated with the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<Address> Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<Address>() : null;

        /// <summary>
        /// Checks to see if the Addresses property is set.
        /// </summary>
        internal bool IsSetAddresses() => this.Addresses != null && (this.Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Birthdate. 
        /// <para>
        /// The user's birthdate in YYYY-MM-DD format. This field supports standard date format
        /// for storing personal information.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Birthdate { get; set; }

        /// <summary>
        /// Checks to see if the Birthdate property is set.
        /// </summary>
        internal bool IsSetBirthdate() => this.Birthdate != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A string containing the name of the user. This value is typically formatted for display
        /// when the user is referenced. For example, "John Doe." When used in IAM Identity Center,
        /// this parameter is required.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Emails. 
        /// <para>
        /// A list of <c>Email</c> objects containing email addresses associated with the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<Email> Emails { get; set; } = AWSConfigs.InitializeCollections ? new List<Email>() : null;

        /// <summary>
        /// Checks to see if the Emails property is set.
        /// </summary>
        internal bool IsSetEmails() => this.Emails != null && (this.Emails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Extensions. 
        /// <para>
        /// A map with additional attribute extensions for the user. Each map key corresponds
        /// to an extension name, while map values represent extension data in <c>Document</c>
        /// type (not supported by Java V1, Go V1 and older versions of the CLI). <c>aws:identitystore:enterprise</c>
        /// is the only supported extension name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public Dictionary<string, Amazon.Runtime.Documents.Document> Extensions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Checks to see if the Extensions property is set.
        /// </summary>
        internal bool IsSetExtensions() => this.Extensions != null && (this.Extensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The globally unique identifier for the identity store.
        /// </para>
        ///  
        /// <para>
        /// You can specify the identity store by ID or by Amazon Resource Name (ARN). For example,
        /// identity store ID <c>d-1234567890</c> or identity store ARN <c>arn:aws:identitystore::111122223333:identitystore/d-1234567890</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 93)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreId property is set.
        /// </summary>
        internal bool IsSetIdentityStoreId() => this.IdentityStoreId != null;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// A string containing the geographical region or location of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An object containing the name of the user. When used in IAM Identity Center, this
        /// parameter is required.
        /// </para>
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NickName. 
        /// <para>
        /// A string containing an alternate name for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string NickName { get; set; }

        /// <summary>
        /// Checks to see if the NickName property is set.
        /// </summary>
        internal bool IsSetNickName() => this.NickName != null;

        /// <summary>
        /// Gets and sets the property PhoneNumbers. 
        /// <para>
        /// A list of <c>PhoneNumber</c> objects containing phone numbers associated with the
        /// user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<PhoneNumber> PhoneNumbers { get; set; } = AWSConfigs.InitializeCollections ? new List<PhoneNumber>() : null;

        /// <summary>
        /// Checks to see if the PhoneNumbers property is set.
        /// </summary>
        internal bool IsSetPhoneNumbers() => this.PhoneNumbers != null && (this.PhoneNumbers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Photos. 
        /// <para>
        /// A list of photos associated with the user. You can add up to 3 photos per user. Each
        /// photo can include a value, type, display name, and primary designation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<Photo> Photos { get; set; } = AWSConfigs.InitializeCollections ? new List<Photo>() : null;

        /// <summary>
        /// Checks to see if the Photos property is set.
        /// </summary>
        internal bool IsSetPhotos() => this.Photos != null && (this.Photos.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PreferredLanguage. 
        /// <para>
        /// A string containing the preferred language of the user. For example, "American English"
        /// or "en-us."
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string PreferredLanguage { get; set; }

        /// <summary>
        /// Checks to see if the PreferredLanguage property is set.
        /// </summary>
        internal bool IsSetPreferredLanguage() => this.PreferredLanguage != null;

        /// <summary>
        /// Gets and sets the property ProfileUrl. 
        /// <para>
        /// A string containing a URL that might be associated with the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// Checks to see if the ProfileUrl property is set.
        /// </summary>
        internal bool IsSetProfileUrl() => this.ProfileUrl != null;

        /// <summary>
        /// Gets and sets the property Roles. 
        /// <para>
        /// A list of <c>Role</c> objects containing roles associated with the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<Role> Roles { get; set; } = AWSConfigs.InitializeCollections ? new List<Role>() : null;

        /// <summary>
        /// Checks to see if the Roles property is set.
        /// </summary>
        internal bool IsSetRoles() => this.Roles != null && (this.Roles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// A string containing the time zone of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A string containing the title of the user. Possible values are left unspecified. The
        /// value can vary based on your specific use case.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// A unique string used to identify the user. The length limit is 128 characters. This
        /// value can consist of letters, accented characters, symbols, numbers, and punctuation.
        /// This value is specified at the time the user is created and stored as an attribute
        /// of the user object in the identity store. <c>Administrator</c> and <c>AWSAdministrators</c>
        /// are reserved names and can't be used for users or groups.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;

        /// <summary>
        /// Gets and sets the property UserType. 
        /// <para>
        /// A string indicating the type of user. Possible values are left unspecified. The value
        /// can vary based on your specific use case.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string UserType { get; set; }

        /// <summary>
        /// Checks to see if the UserType property is set.
        /// </summary>
        internal bool IsSetUserType() => this.UserType != null;

        /// <summary>
        /// Gets and sets the property Website. 
        /// <para>
        /// The user's personal website or blog URL. This field allows users to provide a link
        /// to their personal or professional website.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Website { get; set; }

        /// <summary>
        /// Checks to see if the Website property is set.
        /// </summary>
        internal bool IsSetWebsite() => this.Website != null;
    }
}
