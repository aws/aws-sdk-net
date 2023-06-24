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
    /// A phone number for which an order has been placed.
    /// </summary>
    public partial class OrderedPhoneNumber
    {
        private string _e164PhoneNumber;
        private OrderedPhoneNumberStatus _status;

        /// <summary>
        /// Gets and sets the property E164PhoneNumber. 
        /// <para>
        /// The phone number, in E.164 format.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string E164PhoneNumber
        {
            get { return this._e164PhoneNumber; }
            set { this._e164PhoneNumber = value; }
        }

        // Check to see if E164PhoneNumber property is set
        internal bool IsSetE164PhoneNumber()
        {
            return this._e164PhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The phone number status.
        /// </para>
        /// </summary>
        public OrderedPhoneNumberStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}