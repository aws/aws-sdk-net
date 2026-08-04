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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// The address information for a lead customer, including city, state or region, postal
    /// code, and country code.
    /// </summary>
    public partial class LeadAddress
    {
        private string _city;
        private string _countryCode;
        private string _postalCode;
        private string _stateOrRegion;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city of the lead customer's address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The country code of the lead customer's address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=10)]
        public string CountryCode
        {
            get { return this._countryCode; }
            set { this._countryCode = value; }
        }

        // Check to see if CountryCode property is set
        internal bool IsSetCountryCode()
        {
            return this._countryCode != null;
        }

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code of the lead customer's address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
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
        /// Gets and sets the property StateOrRegion. 
        /// <para>
        /// The state or region of the lead customer's address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string StateOrRegion
        {
            get { return this._stateOrRegion; }
            set { this._stateOrRegion = value; }
        }

        // Check to see if StateOrRegion property is set
        internal bool IsSetStateOrRegion()
        {
            return this._stateOrRegion != null;
        }

    }
}