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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Configuration settings for phone type and phone number.
    /// </summary>
    public partial class PhoneNumberConfig
    {
        private Channel _channel;
        private string _phoneNumber;
        private PhoneType _phoneType;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel for this phone number configuration. <b>Only <c>VOICE</c> is supported
        /// for this data type.</b> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Channel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number for the user's desk phone.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property PhoneType. 
        /// <para>
        /// The phone type. Valid values: SOFT_PHONE, DESK_PHONE.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PhoneType PhoneType
        {
            get { return this._phoneType; }
            set { this._phoneType = value; }
        }

        // Check to see if PhoneType property is set
        internal bool IsSetPhoneType()
        {
            return this._phoneType != null;
        }

    }
}