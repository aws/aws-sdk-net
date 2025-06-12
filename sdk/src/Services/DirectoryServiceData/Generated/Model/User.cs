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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
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
        private string _distinguishedName;
        private string _emailAddress;
        private bool? _enabled;
        private string _givenName;
        private Dictionary<string, AttributeValue> _otherAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private string _samAccountName;
        private string _sid;
        private string _surname;
        private string _userPrincipalName;

        /// <summary>
        /// Gets and sets the property DistinguishedName. 
        /// <para>
        ///  The <a href="https://learn.microsoft.com/en-us/windows/win32/ad/object-names-and-identities#distinguished-name">distinguished
        /// name</a> of the object. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string DistinguishedName
        {
            get { return this._distinguishedName; }
            set { this._distinguishedName = value; }
        }

        // Check to see if DistinguishedName property is set
        internal bool IsSetDistinguishedName()
        {
            return this._distinguishedName != null;
        }

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        ///  The email address of the user. 
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
        /// Gets and sets the property Enabled. 
        /// <para>
        ///  Indicates whether the user account is active. 
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GivenName. 
        /// <para>
        ///  The first name of the user. 
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
        /// Gets and sets the property OtherAttributes. 
        /// <para>
        ///  An expression that includes one or more attributes, data types, and values of a user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public Dictionary<string, AttributeValue> OtherAttributes
        {
            get { return this._otherAttributes; }
            set { this._otherAttributes = value; }
        }

        // Check to see if OtherAttributes property is set
        internal bool IsSetOtherAttributes()
        {
            return this._otherAttributes != null && (this._otherAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SAMAccountName. 
        /// <para>
        ///  The name of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string SAMAccountName
        {
            get { return this._samAccountName; }
            set { this._samAccountName = value; }
        }

        // Check to see if SAMAccountName property is set
        internal bool IsSetSAMAccountName()
        {
            return this._samAccountName != null;
        }

        /// <summary>
        /// Gets and sets the property SID. 
        /// <para>
        ///  The unique security identifier (SID) of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SID
        {
            get { return this._sid; }
            set { this._sid = value; }
        }

        // Check to see if SID property is set
        internal bool IsSetSID()
        {
            return this._sid != null;
        }

        /// <summary>
        /// Gets and sets the property Surname. 
        /// <para>
        ///  The last name of the user. 
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
        /// Gets and sets the property UserPrincipalName. 
        /// <para>
        ///  The UPN that is an internet-style login name for a user and based on the internet
        /// standard <a href="https://datatracker.ietf.org/doc/html/rfc822">RFC 822</a>. The UPN
        /// is shorter than the distinguished name and easier to remember. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string UserPrincipalName
        {
            get { return this._userPrincipalName; }
            set { this._userPrincipalName = value; }
        }

        // Check to see if UserPrincipalName property is set
        internal bool IsSetUserPrincipalName()
        {
            return this._userPrincipalName != null;
        }

    }
}