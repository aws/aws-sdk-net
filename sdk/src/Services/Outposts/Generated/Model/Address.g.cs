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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about an address.
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// Gets and sets the property AddressLine1. 
        /// <para>
        /// The first line of the address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 180)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Checks to see if the AddressLine1 property is set.
        /// </summary>
        internal bool IsSetAddressLine1() => this.AddressLine1 != null;

        /// <summary>
        /// Gets and sets the property AddressLine2. 
        /// <para>
        /// The second line of the address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 60)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Checks to see if the AddressLine2 property is set.
        /// </summary>
        internal bool IsSetAddressLine2() => this.AddressLine2 != null;

        /// <summary>
        /// Gets and sets the property AddressLine3. 
        /// <para>
        /// The third line of the address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 60)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Checks to see if the AddressLine3 property is set.
        /// </summary>
        internal bool IsSetAddressLine3() => this.AddressLine3 != null;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city for the address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property ContactName. 
        /// <para>
        /// The name of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ContactName { get; set; }

        /// <summary>
        /// Checks to see if the ContactName property is set.
        /// </summary>
        internal bool IsSetContactName() => this.ContactName != null;

        /// <summary>
        /// Gets and sets the property ContactPhoneNumber. 
        /// <para>
        /// The phone number of the contact, including the country code (for example, <c>+12065550100</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string ContactPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the ContactPhoneNumber property is set.
        /// </summary>
        internal bool IsSetContactPhoneNumber() => this.ContactPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The ISO-3166 two-letter country code for the address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Checks to see if the CountryCode property is set.
        /// </summary>
        internal bool IsSetCountryCode() => this.CountryCode != null;

        /// <summary>
        /// Gets and sets the property DistrictOrCounty. 
        /// <para>
        /// The district or county for the address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public string DistrictOrCounty { get; set; }

        /// <summary>
        /// Checks to see if the DistrictOrCounty property is set.
        /// </summary>
        internal bool IsSetDistrictOrCounty() => this.DistrictOrCounty != null;

        /// <summary>
        /// Gets and sets the property Municipality. 
        /// <para>
        /// The municipality for the address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 180)]
        public string Municipality { get; set; }

        /// <summary>
        /// Checks to see if the Municipality property is set.
        /// </summary>
        internal bool IsSetMunicipality() => this.Municipality != null;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code for the address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode != null;

        /// <summary>
        /// Gets and sets the property StateOrRegion. 
        /// <para>
        /// The state for the address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// Checks to see if the StateOrRegion property is set.
        /// </summary>
        internal bool IsSetStateOrRegion() => this.StateOrRegion != null;
    }
}
