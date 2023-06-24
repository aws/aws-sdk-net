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
    /// The information for all SenderIds in an Amazon Web Services account.
    /// </summary>
    public partial class SenderIdInformation
    {
        private string _isoCountryCode;
        private List<string> _messageTypes = new List<string>();
        private string _monthlyLeasingPrice;
        private string _senderId;
        private string _senderIdArn;

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
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> MessageTypes
        {
            get { return this._messageTypes; }
            set { this._messageTypes = value; }
        }

        // Check to see if MessageTypes property is set
        internal bool IsSetMessageTypes()
        {
            return this._messageTypes != null && this._messageTypes.Count > 0; 
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