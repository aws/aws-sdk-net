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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
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
namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Contains the business information required for verifying a company's legal status
    /// and registration details within AWS Partner Central.
    /// </summary>
    public partial class BusinessVerificationDetails
    {
        private string _countryCode;
        private string _jurisdictionOfIncorporation;
        private string _legalName;
        private string _registrationId;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The ISO 3166-1 alpha-2 country code where the business is legally registered and operates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
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
        /// Gets and sets the property JurisdictionOfIncorporation. 
        /// <para>
        /// The specific legal jurisdiction or state where the business was incorporated or registered,
        /// providing additional location context beyond the country code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public string JurisdictionOfIncorporation
        {
            get { return this._jurisdictionOfIncorporation; }
            set { this._jurisdictionOfIncorporation = value; }
        }

        // Check to see if JurisdictionOfIncorporation property is set
        internal bool IsSetJurisdictionOfIncorporation()
        {
            return this._jurisdictionOfIncorporation != null;
        }

        /// <summary>
        /// Gets and sets the property LegalName. 
        /// <para>
        /// The official legal name of the business as registered with the appropriate government
        /// authorities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=80)]
        public string LegalName
        {
            get { return this._legalName; }
            set { this._legalName = value; }
        }

        // Check to see if LegalName property is set
        internal bool IsSetLegalName()
        {
            return this._legalName != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The unique business registration identifier assigned by the government or regulatory
        /// authority, such as a company registration number or tax identification number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=80)]
        public string RegistrationId
        {
            get { return this._registrationId; }
            set { this._registrationId = value; }
        }

        // Check to see if RegistrationId property is set
        internal bool IsSetRegistrationId()
        {
            return this._registrationId != null;
        }

    }
}