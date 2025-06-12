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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Contains your WhatsApp registration status and details of any unregistered WhatsApp
    /// phone number.
    /// </summary>
    public partial class LinkedWhatsAppBusinessAccountIdMetaData
    {
        private string _accountName;
        private RegistrationStatus _registrationStatus;
        private List<WhatsAppPhoneNumberDetail> _unregisteredWhatsAppPhoneNumbers = AWSConfigs.InitializeCollections ? new List<WhatsAppPhoneNumberDetail>() : null;
        private string _wabaId;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The name of your account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string AccountName
        {
            get { return this._accountName; }
            set { this._accountName = value; }
        }

        // Check to see if AccountName property is set
        internal bool IsSetAccountName()
        {
            return this._accountName != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationStatus. 
        /// <para>
        /// The registration status of the linked WhatsApp Business Account.
        /// </para>
        /// </summary>
        public RegistrationStatus RegistrationStatus
        {
            get { return this._registrationStatus; }
            set { this._registrationStatus = value; }
        }

        // Check to see if RegistrationStatus property is set
        internal bool IsSetRegistrationStatus()
        {
            return this._registrationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UnregisteredWhatsAppPhoneNumbers. 
        /// <para>
        /// The details for unregistered WhatsApp phone numbers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WhatsAppPhoneNumberDetail> UnregisteredWhatsAppPhoneNumbers
        {
            get { return this._unregisteredWhatsAppPhoneNumbers; }
            set { this._unregisteredWhatsAppPhoneNumbers = value; }
        }

        // Check to see if UnregisteredWhatsAppPhoneNumbers property is set
        internal bool IsSetUnregisteredWhatsAppPhoneNumbers()
        {
            return this._unregisteredWhatsAppPhoneNumbers != null && (this._unregisteredWhatsAppPhoneNumbers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WabaId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the WhatsApp Business Account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string WabaId
        {
            get { return this._wabaId; }
            set { this._wabaId = value; }
        }

        // Check to see if WabaId property is set
        internal bool IsSetWabaId()
        {
            return this._wabaId != null;
        }

    }
}