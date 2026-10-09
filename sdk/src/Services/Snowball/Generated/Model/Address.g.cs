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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AddressId. 
        /// <para>
        /// The unique ID for an address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 40, Max = 40)]
        public string AddressId { get; set; }

        /// <summary>
        /// Checks to see if the AddressId property is set.
        /// </summary>
        internal bool IsSetAddressId() => this.AddressId != null;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city in an address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property Company. 
        /// <para>
        /// The name of the company to receive a Snow device at an address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Company { get; set; }

        /// <summary>
        /// Checks to see if the Company property is set.
        /// </summary>
        internal bool IsSetCompany() => this.Company != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country in an address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property IsRestricted. 
        /// <para>
        /// If the address you are creating is a primary address, then set this option to true.
        /// This field is not supported in most regions.
        /// </para>
        /// </summary>
        public bool? IsRestricted { get; set; }

        /// <summary>
        /// Checks to see if the IsRestricted property is set.
        /// </summary>
        internal bool IsSetIsRestricted() => this.IsRestricted.HasValue;

        /// <summary>
        /// Gets and sets the property Landmark. 
        /// <para>
        /// This field is no longer used and the value is ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Landmark { get; set; }

        /// <summary>
        /// Checks to see if the Landmark property is set.
        /// </summary>
        internal bool IsSetLandmark() => this.Landmark != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a person to receive a Snow device at an address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number associated with an address that a Snow device is to be delivered
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code in an address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode != null;

        /// <summary>
        /// Gets and sets the property PrefectureOrDistrict. 
        /// <para>
        /// This field is no longer used and the value is ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PrefectureOrDistrict { get; set; }

        /// <summary>
        /// Checks to see if the PrefectureOrDistrict property is set.
        /// </summary>
        internal bool IsSetPrefectureOrDistrict() => this.PrefectureOrDistrict != null;

        /// <summary>
        /// Gets and sets the property StateOrProvince. 
        /// <para>
        /// The state or province in an address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// Checks to see if the StateOrProvince property is set.
        /// </summary>
        internal bool IsSetStateOrProvince() => this.StateOrProvince != null;

        /// <summary>
        /// Gets and sets the property Street1. 
        /// <para>
        /// The first line in a street address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Street1 { get; set; }

        /// <summary>
        /// Checks to see if the Street1 property is set.
        /// </summary>
        internal bool IsSetStreet1() => this.Street1 != null;

        /// <summary>
        /// Gets and sets the property Street2. 
        /// <para>
        /// The second line in a street address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Street2 { get; set; }

        /// <summary>
        /// Checks to see if the Street2 property is set.
        /// </summary>
        internal bool IsSetStreet2() => this.Street2 != null;

        /// <summary>
        /// Gets and sets the property Street3. 
        /// <para>
        /// The third line in a street address that a Snow device is to be delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Street3 { get; set; }

        /// <summary>
        /// Checks to see if the Street3 property is set.
        /// </summary>
        internal bool IsSetStreet3() => this.Street3 != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Differentiates between delivery address and pickup address in the customer account.
        /// Provided at job creation.
        /// </para>
        /// </summary>
        public AddressType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
