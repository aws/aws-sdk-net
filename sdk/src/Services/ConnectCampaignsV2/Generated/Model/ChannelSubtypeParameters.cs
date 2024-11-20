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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// ChannelSubtypeParameters for an outbound request
    /// </summary>
    public partial class ChannelSubtypeParameters
    {
        private EmailChannelSubtypeParameters _email;
        private SmsChannelSubtypeParameters _sms;
        private TelephonyChannelSubtypeParameters _telephony;

        /// <summary>
        /// Gets and sets the property Email.
        /// </summary>
        public EmailChannelSubtypeParameters Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property Sms.
        /// </summary>
        public SmsChannelSubtypeParameters Sms
        {
            get { return this._sms; }
            set { this._sms = value; }
        }

        // Check to see if Sms property is set
        internal bool IsSetSms()
        {
            return this._sms != null;
        }

        /// <summary>
        /// Gets and sets the property Telephony.
        /// </summary>
        public TelephonyChannelSubtypeParameters Telephony
        {
            get { return this._telephony; }
            set { this._telephony = value; }
        }

        // Check to see if Telephony property is set
        internal bool IsSetTelephony()
        {
            return this._telephony != null;
        }

    }
}