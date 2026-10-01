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

namespace Amazon.Account.Model
{
    /// <summary>
    /// Contains the details of the primary contact information associated with an Amazon
    /// Web Services account.
    /// </summary>
    public partial class ContactInformation
    {
        /// <summary>
        /// Gets and sets the property AddressLine1. 
        /// <para>
        /// The first line of the primary contact address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 60)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Checks to see if the AddressLine1 property is set.
        /// </summary>
        internal bool IsSetAddressLine1() => this.AddressLine1 != null;

        /// <summary>
        /// Gets and sets the property AddressLine2. 
        /// <para>
        /// The second line of the primary contact address, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 60)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Checks to see if the AddressLine2 property is set.
        /// </summary>
        internal bool IsSetAddressLine2() => this.AddressLine2 != null;

        /// <summary>
        /// Gets and sets the property AddressLine3. 
        /// <para>
        /// The third line of the primary contact address, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 60)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Checks to see if the AddressLine3 property is set.
        /// </summary>
        internal bool IsSetAddressLine3() => this.AddressLine3 != null;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city of the primary contact address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 50)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// The name of the company associated with the primary contact information, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Checks to see if the CompanyName property is set.
        /// </summary>
        internal bool IsSetCompanyName() => this.CompanyName != null;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The ISO-3166 two-letter country code for the primary contact address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 2)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Checks to see if the CountryCode property is set.
        /// </summary>
        internal bool IsSetCountryCode() => this.CountryCode != null;

        /// <summary>
        /// Gets and sets the property DistrictOrCounty. 
        /// <para>
        /// The district or county of the primary contact address, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public string DistrictOrCounty { get; set; }

        /// <summary>
        /// Checks to see if the DistrictOrCounty property is set.
        /// </summary>
        internal bool IsSetDistrictOrCounty() => this.DistrictOrCounty != null;

        /// <summary>
        /// Gets and sets the property FullName. 
        /// <para>
        /// The full name of the primary contact address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 50)]
        public string FullName { get; set; }

        /// <summary>
        /// Checks to see if the FullName property is set.
        /// </summary>
        internal bool IsSetFullName() => this.FullName != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The phone number of the primary contact information. The number will be validated
        /// and, in some countries, checked for activation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 20)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code of the primary contact address.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 20)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode != null;

        /// <summary>
        /// Gets and sets the property StateOrRegion. 
        /// <para>
        /// The state or region of the primary contact address. If the mailing address is within
        /// the United States (US), the value in this field can be either a two character state
        /// code (for example, <c>NJ</c>) or the full state name (for example, <c>New Jersey</c>).
        /// This field is required in the following countries: <c>US</c>, <c>CA</c>, <c>GB</c>,
        /// <c>DE</c>, <c>JP</c>, <c>IN</c>, and <c>BR</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// Checks to see if the StateOrRegion property is set.
        /// </summary>
        internal bool IsSetStateOrRegion() => this.StateOrRegion != null;

        /// <summary>
        /// Gets and sets the property WebsiteUrl. 
        /// <para>
        /// The URL of the website associated with the primary contact information, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// Checks to see if the WebsiteUrl property is set.
        /// </summary>
        internal bool IsSetWebsiteUrl() => this.WebsiteUrl != null;
    }
}
