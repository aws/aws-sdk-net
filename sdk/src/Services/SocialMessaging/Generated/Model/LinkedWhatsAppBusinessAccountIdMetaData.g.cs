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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Contains your WhatsApp registration status and details of any unregistered WhatsApp
    /// phone number.
    /// </summary>
    public partial class LinkedWhatsAppBusinessAccountIdMetaData
    {
        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The name of your account.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 200)]
        public string AccountName { get; set; }

        /// <summary>
        /// Checks to see if the AccountName property is set.
        /// </summary>
        internal bool IsSetAccountName() => this.AccountName != null;

        /// <summary>
        /// Gets and sets the property RegistrationStatus. 
        /// <para>
        /// The registration status of the linked WhatsApp Business Account.
        /// </para>
        /// </summary>
        public RegistrationStatus RegistrationStatus { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationStatus property is set.
        /// </summary>
        internal bool IsSetRegistrationStatus() => this.RegistrationStatus != null;

        /// <summary>
        /// Gets and sets the property UnregisteredWhatsAppPhoneNumbers. 
        /// <para>
        /// The details for unregistered WhatsApp phone numbers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WhatsAppPhoneNumberDetail> UnregisteredWhatsAppPhoneNumbers { get; set; } = AWSConfigs.InitializeCollections ? new List<WhatsAppPhoneNumberDetail>() : null;

        /// <summary>
        /// Checks to see if the UnregisteredWhatsAppPhoneNumbers property is set.
        /// </summary>
        internal bool IsSetUnregisteredWhatsAppPhoneNumbers() => this.UnregisteredWhatsAppPhoneNumbers != null && (this.UnregisteredWhatsAppPhoneNumbers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WabaId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the WhatsApp Business Account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 115)]
        public string WabaId { get; set; }

        /// <summary>
        /// Checks to see if the WabaId property is set.
        /// </summary>
        internal bool IsSetWabaId() => this.WabaId != null;
    }
}
