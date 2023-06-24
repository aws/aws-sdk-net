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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the RequestPhoneNumber operation.
    /// </summary>
    public partial class RequestPhoneNumberResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTimestamp;
        private bool? _deletionProtectionEnabled;
        private string _isoCountryCode;
        private MessageType _messageType;
        private string _monthlyLeasingPrice;
        private List<string> _numberCapabilities = new List<string>();
        private RequestableNumberType _numberType;
        private string _optOutListName;
        private string _phoneNumber;
        private string _phoneNumberArn;
        private string _phoneNumberId;
        private string _poolId;
        private bool? _selfManagedOptOutsEnabled;
        private NumberStatus _status;
        private List<Tag> _tags = new List<Tag>();
        private string _twoWayChannelArn;
        private bool? _twoWayEnabled;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the phone number was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// By default this is set to false. When set to true the phone number can't be deleted.
        /// 
        /// </para>
        /// </summary>
        public bool DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled.GetValueOrDefault(); }
            set { this._deletionProtectionEnabled = value; }
        }

        // Check to see if DeletionProtectionEnabled property is set
        internal bool IsSetDeletionProtectionEnabled()
        {
            return this._deletionProtectionEnabled.HasValue; 
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
        /// The type of message. Valid values are TRANSACTIONAL for messages that are critical
        /// or time-sensitive and PROMOTIONAL for messages that aren't critical or time-sensitive.
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
        /// The monthly price, in US dollars, to lease the phone number.
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
        /// Indicates if the phone number will be used for text messages, voice messages or both.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> NumberCapabilities
        {
            get { return this._numberCapabilities; }
            set { this._numberCapabilities = value; }
        }

        // Check to see if NumberCapabilities property is set
        internal bool IsSetNumberCapabilities()
        {
            return this._numberCapabilities != null && this._numberCapabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NumberType. 
        /// <para>
        /// The type of number that was released.
        /// </para>
        /// </summary>
        public RequestableNumberType NumberType
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
        /// The name of the OptOutList that is associated with the requested phone number.
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
        /// The new phone number that was requested.
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
        /// The Amazon Resource Name (ARN) of the requested phone number.
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
        /// The unique identifier of the new phone number.
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
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The unique identifier of the pool associated with the phone number 
        /// </para>
        /// </summary>
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManagedOptOutsEnabled. 
        /// <para>
        /// By default this is set to false. When an end recipient sends a message that begins
        /// with HELP or STOP to one of your dedicated numbers, Amazon Pinpoint automatically
        /// replies with a customizable message and adds the end recipient to the OptOutList.
        /// When set to true you're responsible for responding to HELP and STOP requests. You're
        /// also responsible for tracking and honoring opt-out requests.
        /// </para>
        /// </summary>
        public bool SelfManagedOptOutsEnabled
        {
            get { return this._selfManagedOptOutsEnabled.GetValueOrDefault(); }
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key and value pair tags that are associated with the phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TwoWayChannelArn. 
        /// <para>
        /// The ARN used to identify the two way channel.
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
        /// Gets and sets the property TwoWayEnabled. 
        /// <para>
        /// By default this is set to false. When set to true you can receive incoming text messages
        /// from your end recipients.
        /// </para>
        /// </summary>
        public bool TwoWayEnabled
        {
            get { return this._twoWayEnabled.GetValueOrDefault(); }
            set { this._twoWayEnabled = value; }
        }

        // Check to see if TwoWayEnabled property is set
        internal bool IsSetTwoWayEnabled()
        {
            return this._twoWayEnabled.HasValue; 
        }

    }
}