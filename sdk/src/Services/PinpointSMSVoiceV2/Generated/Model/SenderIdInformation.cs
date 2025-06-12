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
    /// The information for all SenderIds in an Amazon Web Services account.
    /// </summary>
    public partial class SenderIdInformation
    {
        private bool? _deletionProtectionEnabled;
        private string _isoCountryCode;
        private List<string> _messageTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _monthlyLeasingPrice;
        private bool? _registered;
        private string _registrationId;
        private string _senderId;
        private string _senderIdArn;

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// By default this is set to false. When set to true the sender ID can't be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled; }
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
        [AWSProperty(Required=true, Min=2, Max=2)]
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
        /// Gets and sets the property MessageTypes. 
        /// <para>
        /// The type of message. Valid values are TRANSACTIONAL for messages that are critical
        /// or time-sensitive and PROMOTIONAL for messages that aren't critical or time-sensitive.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2)]
        public List<string> MessageTypes
        {
            get { return this._messageTypes; }
            set { this._messageTypes = value; }
        }

        // Check to see if MessageTypes property is set
        internal bool IsSetMessageTypes()
        {
            return this._messageTypes != null && (this._messageTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MonthlyLeasingPrice. 
        /// <para>
        /// The monthly leasing price, in US dollars.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Registered. 
        /// <para>
        /// True if the sender ID is registered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Registered
        {
            get { return this._registered; }
            set { this._registered = value; }
        }

        // Check to see if Registered property is set
        internal bool IsSetRegistered()
        {
            return this._registered.HasValue; 
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
        /// Gets and sets the property SenderId. 
        /// <para>
        /// The alphanumeric sender ID in a specific country that you'd like to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=11)]
        public string SenderId
        {
            get { return this._senderId; }
            set { this._senderId = value; }
        }

        // Check to see if SenderId property is set
        internal bool IsSetSenderId()
        {
            return this._senderId != null;
        }

        /// <summary>
        /// Gets and sets the property SenderIdArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the SenderId.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SenderIdArn
        {
            get { return this._senderIdArn; }
            set { this._senderIdArn = value; }
        }

        // Check to see if SenderIdArn property is set
        internal bool IsSetSenderIdArn()
        {
            return this._senderIdArn != null;
        }

    }
}