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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the ReleasePhoneNumber operation.
    /// </summary>
    public partial class ReleasePhoneNumberResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTimestamp;
        private string _isoCountryCode;
        private MessageType _messageType;
        private string _monthlyLeasingPrice;
        private List<string> _numberCapabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NumberType _numberType;
        private string _optOutListName;
        private string _phoneNumber;
        private string _phoneNumberArn;
        private string _phoneNumberId;
        private string _registrationId;
        private bool? _selfManagedOptOutsEnabled;
        private NumberStatus _status;
        private string _twoWayChannelArn;
        private string _twoWayChannelRole;
        private bool? _twoWayEnabled;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the phone number was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsoCountryCode. 
        /// <para>
        /// The two-character code, in ISO 3166-1 alpha-2 format, for the country or region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public string IsoCountryCode
        {
            get { return this._isoCountryCode; }
            set { this._isoCountryCode = value; }
        }

        // Check to see if IsoCountryCode property is set
        internal bool IsSetIsoCountryCode()
        {
            return this._isoCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// The message type that was associated with the phone number.
        /// </para>
        /// </summary>
        public MessageType MessageType
        {
            get { return this._messageType; }
            set { this._messageType = value; }
        }

        // Check to see if MessageType property is set
        internal bool IsSetMessageType()
        {
            return this._messageType != null;
        }

        /// <summary>
        /// Gets and sets the property MonthlyLeasingPrice. 
        /// <para>
        /// The monthly price of the phone number, in US dollars.
        /// </para>
        /// </summary>
        public string MonthlyLeasingPrice
        {
            get { return this._monthlyLeasingPrice; }
            set { this._monthlyLeasingPrice = value; }
        }

        // Check to see if MonthlyLeasingPrice property is set
        internal bool IsSetMonthlyLeasingPrice()
        {
            return this._monthlyLeasingPrice != null;
        }

        /// <summary>
        /// Gets and sets the property NumberCapabilities. 
        /// <para>
        /// Specifies if the number could be used for text messages, voice, or both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> NumberCapabilities
        {
            get { return this._numberCapabilities; }
            set { this._numberCapabilities = value; }
        }

        // Check to see if NumberCapabilities property is set
        internal bool IsSetNumberCapabilities()
        {
            return this._numberCapabilities != null && (this._numberCapabilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumberType. 
        /// <para>
        /// The type of number that was released.
        /// </para>
        /// </summary>
        public NumberType NumberType
        {
            get { return this._numberType; }
            set { this._numberType = value; }
        }

        // Check to see if NumberType property is set
        internal bool IsSetNumberType()
        {
            return this._numberType != null;
        }

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The name of the OptOutList that was associated with the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string OptOutListName
        {
            get { return this._optOutListName; }
            set { this._optOutListName = value; }
        }

        // Check to see if OptOutListName property is set
        internal bool IsSetOptOutListName()
        {
            return this._optOutListName != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number that was released.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        // Check to see if PhoneNumber property is set
        internal bool IsSetPhoneNumber()
        {
            return this._phoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberArn. 
        /// <para>
        /// The PhoneNumberArn of the phone number that was released.
        /// </para>
        /// </summary>
        public string PhoneNumberArn
        {
            get { return this._phoneNumberArn; }
            set { this._phoneNumberArn = value; }
        }

        // Check to see if PhoneNumberArn property is set
        internal bool IsSetPhoneNumberArn()
        {
            return this._phoneNumberArn != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberId. 
        /// <para>
        /// The PhoneNumberId of the phone number that was released.
        /// </para>
        /// </summary>
        public string PhoneNumberId
        {
            get { return this._phoneNumberId; }
            set { this._phoneNumberId = value; }
        }

        // Check to see if PhoneNumberId property is set
        internal bool IsSetPhoneNumberId()
        {
            return this._phoneNumberId != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The unique identifier for the registration.
        /// </para>
        /// </summary>
        public string RegistrationId
        {
            get { return this._registrationId; }
            set { this._registrationId = value; }
        }

        // Check to see if RegistrationId property is set
        internal bool IsSetRegistrationId()
        {
            return this._registrationId != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManagedOptOutsEnabled. 
        /// <para>
        /// By default this is set to false. When an end recipient sends a message that begins
        /// with HELP or STOP to one of your dedicated numbers, AWS End User Messaging SMS and
        /// Voice automatically replies with a customizable message and adds the end recipient
        /// to the OptOutList. When set to true you're responsible for responding to HELP and
        /// STOP requests. You're also responsible for tracking and honoring opt-out requests.
        /// </para>
        /// </summary>
        public bool? SelfManagedOptOutsEnabled
        {
            get { return this._selfManagedOptOutsEnabled; }
            set { this._selfManagedOptOutsEnabled = value; }
        }

        // Check to see if SelfManagedOptOutsEnabled property is set
        internal bool IsSetSelfManagedOptOutsEnabled()
        {
            return this._selfManagedOptOutsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the request.
        /// </para>
        /// </summary>
        public NumberStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TwoWayChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the TwoWayChannel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string TwoWayChannelArn
        {
            get { return this._twoWayChannelArn; }
            set { this._twoWayChannelArn = value; }
        }

        // Check to see if TwoWayChannelArn property is set
        internal bool IsSetTwoWayChannelArn()
        {
            return this._twoWayChannelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TwoWayChannelRole. 
        /// <para>
        /// An optional IAM Role Arn for a service to assume, to be able to post inbound SMS messages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string TwoWayChannelRole
        {
            get { return this._twoWayChannelRole; }
            set { this._twoWayChannelRole = value; }
        }

        // Check to see if TwoWayChannelRole property is set
        internal bool IsSetTwoWayChannelRole()
        {
            return this._twoWayChannelRole != null;
        }

        /// <summary>
        /// Gets and sets the property TwoWayEnabled. 
        /// <para>
        /// By default this is set to false. When set to true you can receive incoming text messages
        /// from your end recipients.
        /// </para>
        /// </summary>
        public bool? TwoWayEnabled
        {
            get { return this._twoWayEnabled; }
            set { this._twoWayEnabled = value; }
        }

        // Check to see if TwoWayEnabled property is set
        internal bool IsSetTwoWayEnabled()
        {
            return this._twoWayEnabled.HasValue; 
        }

    }
}