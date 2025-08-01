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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Object that defines users contact preference.
    /// </summary>
    public partial class ContactPreference
    {
        private ContactType _contactType;
        private string _keyName;
        private string _keyValue;
        private string _profileId;

        /// <summary>
        /// Gets and sets the property ContactType. 
        /// <para>
        /// The contact type used for engagement. For example: HomePhoneNumber, PersonalEmailAddress.
        /// </para>
        /// </summary>
        public ContactType ContactType
        {
            get { return this._contactType; }
            set { this._contactType = value; }
        }

        // Check to see if ContactType property is set
        internal bool IsSetContactType()
        {
            return this._contactType != null;
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// A searchable, unique identifier of a customer profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property KeyValue. 
        /// <para>
        /// The key value used to look up profile based off the keyName.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string KeyValue
        {
            get { return this._keyValue; }
            set { this._keyValue = value; }
        }

        // Check to see if KeyValue property is set
        internal bool IsSetKeyValue()
        {
            return this._keyValue != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of a customer profile.
        /// </para>
        /// </summary>
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

    }
}