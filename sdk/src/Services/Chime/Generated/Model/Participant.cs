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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The phone number and proxy phone number for a participant in an Amazon Chime Voice
    /// Connector proxy session.
    /// </summary>
    public partial class Participant
    {
        private string _phoneNumber;
        private string _proxyPhoneNumber;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The participant's phone number.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProxyPhoneNumber. 
        /// <para>
        /// The participant's proxy phone number.
        /// </para>
        /// </summary>
        public string ProxyPhoneNumber
        {
            get { return this._proxyPhoneNumber; }
            set { this._proxyPhoneNumber = value; }
        }

        // Check to see if ProxyPhoneNumber property is set
        internal bool IsSetProxyPhoneNumber()
        {
            return this._proxyPhoneNumber != null;
        }

    }
}