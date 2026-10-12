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

namespace Amazon.PartnerCentralAccount.Model
{
    /// <summary>
    /// Contains the business information required for verifying a company's legal status
    /// and registration details within AWS Partner Central.
    /// </summary>
    public partial class BusinessVerificationDetails
    {
        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The ISO 3166-1 alpha-2 country code where the business is legally registered and operates.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Checks to see if the CountryCode property is set.
        /// </summary>
        internal bool IsSetCountryCode() => this.CountryCode != null;

        /// <summary>
        /// Gets and sets the property JurisdictionOfIncorporation. 
        /// <para>
        /// The specific legal jurisdiction or state where the business was incorporated or registered,
        /// providing additional location context beyond the country code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string JurisdictionOfIncorporation { get; set; }

        /// <summary>
        /// Checks to see if the JurisdictionOfIncorporation property is set.
        /// </summary>
        internal bool IsSetJurisdictionOfIncorporation() => this.JurisdictionOfIncorporation != null;

        /// <summary>
        /// Gets and sets the property LegalName. 
        /// <para>
        /// The official legal name of the business as registered with the appropriate government
        /// authorities.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 80)]
        public string LegalName { get; set; }

        /// <summary>
        /// Checks to see if the LegalName property is set.
        /// </summary>
        internal bool IsSetLegalName() => this.LegalName != null;

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The unique business registration identifier assigned by the government or regulatory
        /// authority, such as a company registration number or tax identification number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 80)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationId property is set.
        /// </summary>
        internal bool IsSetRegistrationId() => this.RegistrationId != null;
    }
}
