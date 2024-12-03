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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the PutTaxRegistration operation.
    /// Adds or updates tax registration for a single account. You can't set a TRN if there's
    /// a pending TRN. You'll need to delete the pending TRN first.
    /// 
    ///  
    /// <para>
    /// To call this API operation for specific countries, see the following country-specific
    /// requirements.
    /// </para>
    ///  
    /// <para>
    ///  <b>Bangladesh</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
    /// field of the <c>VerificationDetails</c> object.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Brazil</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You must complete the tax registration process in the <a href="https://console.aws.amazon.com/billing/home#/paymentpreferences/paymentmethods">Payment
    /// preferences</a> page in the Billing and Cost Management console. After your TRN and
    /// billing address are verified, you can call this API operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For Amazon Web Services accounts created through Organizations, you can call this
    /// API operation when you don't have a billing address.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Georgia</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The valid <c>personType</c> values are <c>Physical Person</c> and <c>Business</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Kenya</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You must specify the <c>personType</c> in the <c>kenyaAdditionalInfo</c> field of
    /// the <c>additionalTaxInformation</c> object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the <c>personType</c> is <c>Physical Person</c>, you must specify the tax registration
    /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
    /// object.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Malaysia</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The sector valid values are <c>Business</c> and <c>Individual</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RegistrationType</c> valid values are <c>NRIC</c> for individual, and TIN and
    /// sales and service tax (SST) for Business.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For individual, you can specify the <c>taxInformationNumber</c> in <c>MalaysiaAdditionalInfo</c>
    /// with NRIC type, and a valid <c>MyKad</c> or NRIC number.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For business, you must specify a <c>businessRegistrationNumber</c> in <c>MalaysiaAdditionalInfo</c>
    /// with a TIN type and tax identification number.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For business resellers, you must specify a <c>businessRegistrationNumber</c> and <c>taxInformationNumber</c>
    /// in <c>MalaysiaAdditionalInfo</c> with a sales and service tax (SST) type and a valid
    /// SST number.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For business resellers with service codes, you must specify <c>businessRegistrationNumber</c>,
    /// <c>taxInformationNumber</c>, and distinct <c>serviceTaxCodes</c> in <c>MalaysiaAdditionalInfo</c>
    /// with a SST type and valid sales and service tax (SST) number. By using this API operation,
    /// Amazon Web Services registers your self-declaration that you’re an authorized business
    /// reseller registered with the Royal Malaysia Customs Department (RMCD), and have a
    /// valid SST number.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Web Services reserves the right to seek additional information and/or take
    /// other actions to support your self-declaration as appropriate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Web Services is currently registered under the following service tax codes.
    /// You must include at least one of the service tax codes in the service tax code strings
    /// to declare yourself as an authorized registered business reseller.
    /// </para>
    ///  
    /// <para>
    /// Taxable service and service tax codes:
    /// </para>
    ///  
    /// <para>
    /// Consultancy - 9907061674
    /// </para>
    ///  
    /// <para>
    /// Training or coaching service - 9907071685
    /// </para>
    ///  
    /// <para>
    /// IT service - 9907101676
    /// </para>
    ///  
    /// <para>
    /// Digital services and electronic medium - 9907121690
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Nepal</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The sector valid values are <c>Business</c> and <c>Individual</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Saudi Arabia</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For <c>address</c>, you must specify <c>addressLine3</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>South Korea</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You must specify the <c>certifiedEmailId</c> and <c>legalName</c> in the <c>TaxRegistrationEntry</c>
    /// object. Use Korean characters for <c>legalName</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must specify the <c>businessRepresentativeName</c>, <c>itemOfBusiness</c>, and
    /// <c>lineOfBusiness</c> in the <c>southKoreaAdditionalInfo</c> field of the <c>additionalTaxInformation</c>
    /// object. Use Korean characters for these fields.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must specify the tax registration certificate document in the <c>taxRegistrationDocuments</c>
    /// field of the <c>VerificationDetails</c> object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For the <c>address</c> object, use Korean characters for <c>addressLine1</c>, <c>addressLine2</c>
    /// <c>city</c>, <c>postalCode</c>, and <c>stateOrRegion</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Spain</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You must specify the <c>registrationType</c> in the <c>spainAdditionalInfo</c> field
    /// of the <c>additionalTaxInformation</c> object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the <c>registrationType</c> is <c>Local</c>, you must specify the tax registration
    /// certificate document in the <c>taxRegistrationDocuments</c> field of the <c>VerificationDetails</c>
    /// object.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Turkey</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You must specify the <c>sector</c> in the <c>taxRegistrationEntry</c> object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your <c>sector</c> is <c>Business</c>, <c>Individual</c>, or <c>Government</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify the <c>taxOffice</c>. If your <c>sector</c> is <c>Individual</c>, don't enter
    /// this value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) Specify the <c>kepEmailId</c>. If your <c>sector</c> is <c>Individual</c>,
    /// don't enter this value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Note:</b> In the <b>Tax Settings</b> page of the Billing console, <c>Government</c>
    /// appears as <b>Public institutions</b> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// If your <c>sector</c> is <c>Business</c> and you're subject to KDV tax, you must specify
    /// your industry in the <c>industries</c> field.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <c>address</c>, you must specify <c>districtOrCounty</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Ukraine</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The sector valid values are <c>Business</c> and <c>Individual</c>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutTaxRegistrationRequest : AmazonTaxSettingsRequest
    {
        private string _accountId;
        private TaxRegistrationEntry _taxRegistrationEntry;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Your unique account identifier. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property TaxRegistrationEntry. 
        /// <para>
        ///  Your TRN information that will be stored to the account mentioned in <c>accountId</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public TaxRegistrationEntry TaxRegistrationEntry
        {
            get { return this._taxRegistrationEntry; }
            set { this._taxRegistrationEntry = value; }
        }

        // Check to see if TaxRegistrationEntry property is set
        internal bool IsSetTaxRegistrationEntry()
        {
            return this._taxRegistrationEntry != null;
        }

    }
}