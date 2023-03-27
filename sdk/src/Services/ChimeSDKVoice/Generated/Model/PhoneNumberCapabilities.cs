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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The phone number capabilities for Amazon Chime SDK phone numbers, such as enabled
    /// inbound and outbound calling, and text messaging.
    /// </summary>
    public partial class PhoneNumberCapabilities
    {
        private bool? _inboundCall;
        private bool? _inboundMMS;
        private bool? _inboundSMS;
        private bool? _outboundCall;
        private bool? _outboundMMS;
        private bool? _outboundSMS;

        /// <summary>
        /// Gets and sets the property InboundCall. 
        /// <para>
        /// Allows or denies inbound calling for the specified phone number.
        /// </para>
        /// </summary>
        public bool InboundCall
        {
            get { return this._inboundCall.GetValueOrDefault(); }
            set { this._inboundCall = value; }
        }

        // Check to see if InboundCall property is set
        internal bool IsSetInboundCall()
        {
            return this._inboundCall.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InboundMMS. 
        /// <para>
        /// Allows or denies inbound MMS messaging for the specified phone number.
        /// </para>
        /// </summary>
        public bool InboundMMS
        {
            get { return this._inboundMMS.GetValueOrDefault(); }
            set { this._inboundMMS = value; }
        }

        // Check to see if InboundMMS property is set
        internal bool IsSetInboundMMS()
        {
            return this._inboundMMS.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InboundSMS. 
        /// <para>
        /// Allows or denies inbound SMS messaging for the specified phone number.
        /// </para>
        /// </summary>
        public bool InboundSMS
        {
            get { return this._inboundSMS.GetValueOrDefault(); }
            set { this._inboundSMS = value; }
        }

        // Check to see if InboundSMS property is set
        internal bool IsSetInboundSMS()
        {
            return this._inboundSMS.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutboundCall. 
        /// <para>
        /// Allows or denies outbound calling for the specified phone number.
        /// </para>
        /// </summary>
        public bool OutboundCall
        {
            get { return this._outboundCall.GetValueOrDefault(); }
            set { this._outboundCall = value; }
        }

        // Check to see if OutboundCall property is set
        internal bool IsSetOutboundCall()
        {
            return this._outboundCall.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutboundMMS. 
        /// <para>
        /// Allows or denies inbound MMS messaging for the specified phone number.
        /// </para>
        /// </summary>
        public bool OutboundMMS
        {
            get { return this._outboundMMS.GetValueOrDefault(); }
            set { this._outboundMMS = value; }
        }

        // Check to see if OutboundMMS property is set
        internal bool IsSetOutboundMMS()
        {
            return this._outboundMMS.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutboundSMS. 
        /// <para>
        /// Allows or denies outbound SMS messaging for the specified phone number.
        /// </para>
        /// </summary>
        public bool OutboundSMS
        {
            get { return this._outboundSMS.GetValueOrDefault(); }
            set { this._outboundSMS = value; }
        }

        // Check to see if OutboundSMS property is set
        internal bool IsSetOutboundSMS()
        {
            return this._outboundSMS.HasValue; 
        }

    }
}