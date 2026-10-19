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
    /// Container for the parameters to the UpdateUser operation. Updates the specified attributes
    /// of the specified user, and grants or revokes administrative privileges to the Amazon
    /// WorkDocs site.
    /// </summary>
    public partial class UpdateUserRequest : AmazonWorkDocsRequest
    {
        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Not required when using Amazon Web Services
        /// administrator credentials to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 8199)]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationToken property is set.
        /// </summary>
        internal bool IsSetAuthenticationToken() => this.AuthenticationToken != null;

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
        /// Gets and sets the property GrantPoweruserPrivileges. 
        /// <para>
        /// Boolean value to determine whether the user is granted Power user privileges.
        /// </para>
        /// </summary>
        public BooleanEnumType GrantPoweruserPrivileges { get; set; }

        /// <summary>
        /// Checks to see if the GrantPoweruserPrivileges property is set.
        /// </summary>
        internal bool IsSetGrantPoweruserPrivileges() => this.GrantPoweruserPrivileges != null;

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
        /// Gets and sets the property StorageRule. 
        /// <para>
        /// The amount of storage for the user.
        /// </para>
        /// </summary>
        public StorageRuleType StorageRule { get; set; }

        /// <summary>
        /// Checks to see if the StorageRule property is set.
        /// </summary>
        internal bool IsSetStorageRule() => this.StorageRule != null;

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
        /// The type of the user.
        /// </para>
        /// </summary>
        public UserType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
