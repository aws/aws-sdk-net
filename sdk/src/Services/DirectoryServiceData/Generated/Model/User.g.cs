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

namespace Amazon.DirectoryServiceData.Model
{
    /// <summary>
    /// A user object that contains identifying information and attributes for a specified
    /// user.
    /// </summary>
    public partial class User
    {
        /// <summary>
        /// Gets and sets the property DistinguishedName. 
        /// <para>
        ///  The <a href="https://learn.microsoft.com/en-us/windows/win32/ad/object-names-and-identities#distinguished-name">distinguished
        /// name</a> of the object. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// Checks to see if the DistinguishedName property is set.
        /// </summary>
        internal bool IsSetDistinguishedName() => this.DistinguishedName != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        ///  The email address of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        ///  Indicates whether the user account is active. 
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property GivenName. 
        /// <para>
        ///  The first name of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string GivenName { get; set; }

        /// <summary>
        /// Checks to see if the GivenName property is set.
        /// </summary>
        internal bool IsSetGivenName() => this.GivenName != null;

        /// <summary>
        /// Gets and sets the property OtherAttributes. 
        /// <para>
        ///  An expression that includes one or more attributes, data types, and values of a user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public Dictionary<string, AttributeValue> OtherAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;

        /// <summary>
        /// Checks to see if the OtherAttributes property is set.
        /// </summary>
        internal bool IsSetOtherAttributes() => this.OtherAttributes != null && (this.OtherAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SAMAccountName. 
        /// <para>
        ///  The name of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string SAMAccountName { get; set; }

        /// <summary>
        /// Checks to see if the SAMAccountName property is set.
        /// </summary>
        internal bool IsSetSAMAccountName() => this.SAMAccountName != null;

        /// <summary>
        /// Gets and sets the property SID. 
        /// <para>
        ///  The unique security identifier (SID) of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SID { get; set; }

        /// <summary>
        /// Checks to see if the SID property is set.
        /// </summary>
        internal bool IsSetSID() => this.SID != null;

        /// <summary>
        /// Gets and sets the property Surname. 
        /// <para>
        ///  The last name of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string Surname { get; set; }

        /// <summary>
        /// Checks to see if the Surname property is set.
        /// </summary>
        internal bool IsSetSurname() => this.Surname != null;

        /// <summary>
        /// Gets and sets the property UserPrincipalName. 
        /// <para>
        ///  The UPN that is an internet-style login name for a user and based on the internet
        /// standard <a href="https://datatracker.ietf.org/doc/html/rfc822">RFC 822</a>. The UPN
        /// is shorter than the distinguished name and easier to remember. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string UserPrincipalName { get; set; }

        /// <summary>
        /// Checks to see if the UserPrincipalName property is set.
        /// </summary>
        internal bool IsSetUserPrincipalName() => this.UserPrincipalName != null;
    }
}
