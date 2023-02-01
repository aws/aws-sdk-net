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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Information about an address.
    /// </summary>
    public partial class Address
    {
        private string _city;
        private string _company;
        private string _country;
        private string _name;
        private string _phoneNumber;
        private string _postalCode;
        private string _stateOrProvince;
        private string _street1;
        private string _street2;
        private string _street3;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city for this address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }

        // Check to see if City property is set
        internal bool IsSetCity()
        {
            return this._city != null;
        }

        /// <summary>
        /// Gets and sets the property Company. 
        /// <para>
        /// The company name for this address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Company
        {
            get { return this._company; }
            set { this._company = value; }
        }

        // Check to see if Company property is set
        internal bool IsSetCompany()
        {
            return this._company != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country for this address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The recipient's name for this address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number for this address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
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
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code for this address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string PostalCode
        {
            get { return this._postalCode; }
            set { this._postalCode = value; }
        }

        // Check to see if PostalCode property is set
        internal bool IsSetPostalCode()
        {
            return this._postalCode != null;
        }

        /// <summary>
        /// Gets and sets the property StateOrProvince. 
        /// <para>
        /// The state or province for this address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string StateOrProvince
        {
            get { return this._stateOrProvince; }
            set { this._stateOrProvince = value; }
        }

        // Check to see if StateOrProvince property is set
        internal bool IsSetStateOrProvince()
        {
            return this._stateOrProvince != null;
        }

        /// <summary>
        /// Gets and sets the property Street1. 
        /// <para>
        /// The first line of the street address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string Street1
        {
            get { return this._street1; }
            set { this._street1 = value; }
        }

        // Check to see if Street1 property is set
        internal bool IsSetStreet1()
        {
            return this._street1 != null;
        }

        /// <summary>
        /// Gets and sets the property Street2. 
        /// <para>
        /// The second line of the street address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Street2
        {
            get { return this._street2; }
            set { this._street2 = value; }
        }

        // Check to see if Street2 property is set
        internal bool IsSetStreet2()
        {
            return this._street2 != null;
        }

        /// <summary>
        /// Gets and sets the property Street3. 
        /// <para>
        /// The third line of the street address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string Street3
        {
            get { return this._street3; }
            set { this._street3 = value; }
        }

        // Check to see if Street3 property is set
        internal bool IsSetStreet3()
        {
            return this._street3 != null;
        }

    }
}