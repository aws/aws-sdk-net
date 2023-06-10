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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// A contact with attributes.
    /// </summary>
    public partial class Contact
    {
        private string _contactArn;
        private string _displayName;
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private List<PhoneNumber> _phoneNumbers = new List<PhoneNumber>();
        private List<SipAddress> _sipAddresses = new List<SipAddress>();

        /// <summary>
        /// Gets and sets the property ContactArn. 
        /// <para>
        /// The ARN of the contact.
        /// </para>
        /// </summary>
        public string ContactArn
        {
            get { return this._contactArn; }
            set { this._contactArn = value; }
        }

        // Check to see if ContactArn property is set
        internal bool IsSetContactArn()
        {
            return this._contactArn != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the contact to display on the console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name of the contact, used to call the contact on the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        // Check to see if FirstName property is set
        internal bool IsSetFirstName()
        {
            return this._firstName != null;
        }

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name of the contact, used to call the contact on the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        // Check to see if LastName property is set
        internal bool IsSetLastName()
        {
            return this._lastName != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number of the contact. The phone number type defaults to WORK. You can either
        /// specify PhoneNumber or PhoneNumbers. We recommend that you use PhoneNumbers, which
        /// lets you specify the phone number type and multiple numbers.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
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
        /// Gets and sets the property PhoneNumbers. 
        /// <para>
        /// The list of phone numbers for the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<PhoneNumber> PhoneNumbers
        {
            get { return this._phoneNumbers; }
            set { this._phoneNumbers = value; }
        }

        // Check to see if PhoneNumbers property is set
        internal bool IsSetPhoneNumbers()
        {
            return this._phoneNumbers != null && this._phoneNumbers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SipAddresses. 
        /// <para>
        /// The list of SIP addresses for the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<SipAddress> SipAddresses
        {
            get { return this._sipAddresses; }
            set { this._sipAddresses = value; }
        }

        // Check to see if SipAddresses property is set
        internal bool IsSetSipAddresses()
        {
            return this._sipAddresses != null && this._sipAddresses.Count > 0; 
        }

    }
}