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
    /// The details of your linked WhatsApp Business Account.
    /// </summary>
    public partial class LinkedWhatsAppBusinessAccount
    {
        private string _arn;
        private List<WhatsAppBusinessAccountEventDestination> _eventDestinations = AWSConfigs.InitializeCollections ? new List<WhatsAppBusinessAccountEventDestination>() : null;
        private string _id;
        private DateTime? _linkDate;
        private List<WhatsAppPhoneNumberSummary> _phoneNumbers = AWSConfigs.InitializeCollections ? new List<WhatsAppPhoneNumberSummary>() : null;
        private RegistrationStatus _registrationStatus;
        private string _wabaId;
        private string _wabaName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the linked WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property EventDestinations. 
        /// <para>
        /// The event destinations for the linked WhatsApp Business Account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public List<WhatsAppBusinessAccountEventDestination> EventDestinations
        {
            get { return this._eventDestinations; }
            set { this._eventDestinations = value; }
        }

        // Check to see if EventDestinations property is set
        internal bool IsSetEventDestinations()
        {
            return this._eventDestinations != null && (this._eventDestinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the linked WhatsApp Business Account, formatted as <c>waba-01234567890123456789012345678901</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property LinkDate. 
        /// <para>
        /// The date the WhatsApp Business Account was linked.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LinkDate
        {
            get { return this._linkDate; }
            set { this._linkDate = value; }
        }

        // Check to see if LinkDate property is set
        internal bool IsSetLinkDate()
        {
            return this._linkDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PhoneNumbers. 
        /// <para>
        /// The phone numbers associated with the Linked WhatsApp Business Account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<WhatsAppPhoneNumberSummary> PhoneNumbers
        {
            get { return this._phoneNumbers; }
            set { this._phoneNumbers = value; }
        }

        // Check to see if PhoneNumbers property is set
        internal bool IsSetPhoneNumbers()
        {
            return this._phoneNumbers != null && (this._phoneNumbers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegistrationStatus. 
        /// <para>
        /// The registration status of the linked WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property WabaId. 
        /// <para>
        /// The WhatsApp Business Account ID from meta.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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

        /// <summary>
        /// Gets and sets the property WabaName. 
        /// <para>
        /// The name of the linked WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public string WabaName
        {
            get { return this._wabaName; }
            set { this._wabaName = value; }
        }

        // Check to see if WabaName property is set
        internal bool IsSetWabaName()
        {
            return this._wabaName != null;
        }

    }
}