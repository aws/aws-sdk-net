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

namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// The details of the address associated with the TRN information.
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// Gets and sets the property AddressLine1. 
        /// <para>
        /// The first line of the address. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 180)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Checks to see if the AddressLine1 property is set.
        /// </summary>
        internal bool IsSetAddressLine1() => this.AddressLine1 != null;

        /// <summary>
        /// Gets and sets the property AddressLine2. 
        /// <para>
        /// The second line of the address, if applicable. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Checks to see if the AddressLine2 property is set.
        /// </summary>
        internal bool IsSetAddressLine2() => this.AddressLine2 != null;

        /// <summary>
        /// Gets and sets the property AddressLine3. 
        /// <para>
        ///  The third line of the address, if applicable. Currently, the Tax Settings API accepts
        /// the <c>addressLine3</c> parameter only for Saudi Arabia. When you specify a TRN in
        /// Saudi Arabia, you must enter the <c>addressLine3</c> and specify the building number
        /// for the address. For example, you might enter <c>1234</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Checks to see if the AddressLine3 property is set.
        /// </summary>
        internal bool IsSetAddressLine3() => this.AddressLine3 != null;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city that the address is in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The country code for the country that the address is in. 
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
        /// The district or county the address is located. 
        /// </para>
        ///  <note> 
        /// <para>
        /// For addresses in Brazil, this parameter uses the name of the neighborhood. When you
        /// set a TRN in Brazil, use <c>districtOrCounty</c> for the neighborhood name.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string DistrictOrCounty { get; set; }

        /// <summary>
        /// Checks to see if the DistrictOrCounty property is set.
        /// </summary>
        internal bool IsSetDistrictOrCounty() => this.DistrictOrCounty != null;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        ///  The postal code associated with the address. 
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
        /// The state, region, or province that the address is located. This field is only required
        /// for Canada, India, United Arab Emirates, Romania, and Brazil (CPF). It is optional
        /// for all other countries.
        /// </para>
        ///  
        /// <para>
        /// If this is required for tax settings, use the same name as shown on the <b>Tax Settings</b>
        /// page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string StateOrRegion { get; set; }

        /// <summary>
        /// Checks to see if the StateOrRegion property is set.
        /// </summary>
        internal bool IsSetStateOrRegion() => this.StateOrRegion != null;
    }
}
