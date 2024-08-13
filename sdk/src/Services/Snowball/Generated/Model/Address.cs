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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// The address that you want the Snow device(s) associated with a specific job to be
    /// shipped to. Addresses are validated at the time of creation. The address you provide
    /// must be located within the serviceable area of your region. Although no individual
    /// elements of the <c>Address</c> are required, if the address is invalid or unsupported,
    /// then an exception is thrown.
    /// </summary>
    public partial class Address
    {
        private string _addressId;
        private string _city;
        private string _company;
        private string _country;
        private bool? _isRestricted;
        private string _landmark;
        private string _name;
        private string _phoneNumber;
        private string _postalCode;
        private string _prefectureOrDistrict;
        private string _stateOrProvince;
        private string _street1;
        private string _street2;
        private string _street3;
        private AddressType _type;

        /// <summary>
        /// Gets and sets the property AddressId. 
        /// <para>
        /// The unique ID for an address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=40, Max=40)]
        public string AddressId
        {
            get { return this._addressId; }
            set { this._addressId = value; }
        }

        // Check to see if AddressId property is set
        internal bool IsSetAddressId()
        {
            return this._addressId != null;
        }

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city in an address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The name of the company to receive a Snow device at an address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The country in an address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property IsRestricted. 
        /// <para>
        /// If the address you are creating is a primary address, then set this option to true.
        /// This field is not supported in most regions.
        /// </para>
        /// </summary>
        public bool? IsRestricted
        {
            get { return this._isRestricted; }
            set { this._isRestricted = value; }
        }

        // Check to see if IsRestricted property is set
        internal bool IsSetIsRestricted()
        {
            return this._isRestricted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Landmark. 
        /// <para>
        /// This field is no longer used and the value is ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Landmark
        {
            get { return this._landmark; }
            set { this._landmark = value; }
        }

        // Check to see if Landmark property is set
        internal bool IsSetLandmark()
        {
            return this._landmark != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a person to receive a Snow device at an address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The phone number associated with an address that a Snow device is to be delivered
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The postal code in an address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property PrefectureOrDistrict. 
        /// <para>
        /// This field is no longer used and the value is ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PrefectureOrDistrict
        {
            get { return this._prefectureOrDistrict; }
            set { this._prefectureOrDistrict = value; }
        }

        // Check to see if PrefectureOrDistrict property is set
        internal bool IsSetPrefectureOrDistrict()
        {
            return this._prefectureOrDistrict != null;
        }

        /// <summary>
        /// Gets and sets the property StateOrProvince. 
        /// <para>
        /// The state or province in an address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The first line in a street address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The second line in a street address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The third line in a street address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Differentiates between delivery address and pickup address in the customer account.
        /// Provided at job creation.
        /// </para>
        /// </summary>
        public AddressType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}