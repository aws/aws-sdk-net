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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains summary information about a phone number for a contact center.
    /// </summary>
    public partial class PhoneNumberSummary
    {
        private string _arn;
        private string _id;
        private string _phoneNumber;
        private PhoneNumberCountryCode _phoneNumberCountryCode;
        private PhoneNumberType _phoneNumberType;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the phone number.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the phone number.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number.
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
        /// Gets and sets the property PhoneNumberCountryCode. 
        /// <para>
        /// The ISO country code.
        /// </para>
        /// </summary>
        public PhoneNumberCountryCode PhoneNumberCountryCode
        {
            get { return this._phoneNumberCountryCode; }
            set { this._phoneNumberCountryCode = value; }
        }

        // Check to see if PhoneNumberCountryCode property is set
        internal bool IsSetPhoneNumberCountryCode()
        {
            return this._phoneNumberCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumberType. 
        /// <para>
        /// The type of phone number.
        /// </para>
        /// </summary>
        public PhoneNumberType PhoneNumberType
        {
            get { return this._phoneNumberType; }
            set { this._phoneNumberType = value; }
        }

        // Check to see if PhoneNumberType property is set
        internal bool IsSetPhoneNumberType()
        {
            return this._phoneNumberType != null;
        }

    }
}