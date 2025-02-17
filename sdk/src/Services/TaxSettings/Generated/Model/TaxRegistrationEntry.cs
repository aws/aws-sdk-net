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
    /// The TRN information you provide when you add a new TRN, or update.
    /// </summary>
    public partial class TaxRegistrationEntry
    {
        private AdditionalInfoRequest _additionalTaxInformation;
        private string _certifiedEmailId;
        private Address _legalAddress;
        private string _legalName;
        private string _registrationId;
        private TaxRegistrationType _registrationType;
        private Sector _sector;
        private VerificationDetails _verificationDetails;

        /// <summary>
        /// Gets and sets the property AdditionalTaxInformation. 
        /// <para>
        ///  Additional tax information associated with your TRN. You only need to specify this
        /// parameter if Amazon Web Services collects any additional information for your country
        /// within <a>AdditionalInfoRequest</a>.
        /// </para>
        /// </summary>
        public AdditionalInfoRequest AdditionalTaxInformation
        {
            get { return this._additionalTaxInformation; }
            set { this._additionalTaxInformation = value; }
        }

        // Check to see if AdditionalTaxInformation property is set
        internal bool IsSetAdditionalTaxInformation()
        {
            return this._additionalTaxInformation != null;
        }

        /// <summary>
        /// Gets and sets the property CertifiedEmailId. 
        /// <para>
        /// The email address to receive VAT invoices.
        /// </para>
        /// </summary>
        public string CertifiedEmailId
        {
            get { return this._certifiedEmailId; }
            set { this._certifiedEmailId = value; }
        }

        // Check to see if CertifiedEmailId property is set
        internal bool IsSetCertifiedEmailId()
        {
            return this._certifiedEmailId != null;
        }

        /// <summary>
        /// Gets and sets the property LegalAddress. 
        /// <para>
        /// The legal address associated with your TRN.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're setting a TRN in Brazil for the CNPJ tax type, you don't need to specify
        /// the legal address. 
        /// </para>
        ///  
        /// <para>
        /// For TRNs in other countries and for CPF tax types Brazil, you must specify the legal
        /// address.
        /// </para>
        ///  </note>
        /// </summary>
        public Address LegalAddress
        {
            get { return this._legalAddress; }
            set { this._legalAddress = value; }
        }

        // Check to see if LegalAddress property is set
        internal bool IsSetLegalAddress()
        {
            return this._legalAddress != null;
        }

        /// <summary>
        /// Gets and sets the property LegalName. 
        /// <para>
        /// The legal name associated with your TRN. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're setting a TRN in Brazil, you don't need to specify the legal name. For TRNs
        /// in other countries, you must specify the legal name.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Your tax registration unique identifier. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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

        /// <summary>
        /// Gets and sets the property RegistrationType. 
        /// <para>
        ///  Your tax registration type. This can be either <c>VAT</c> or <c>GST</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaxRegistrationType RegistrationType
        {
            get { return this._registrationType; }
            set { this._registrationType = value; }
        }

        // Check to see if RegistrationType property is set
        internal bool IsSetRegistrationType()
        {
            return this._registrationType != null;
        }

        /// <summary>
        /// Gets and sets the property Sector. 
        /// <para>
        /// The industry that describes your business. For business-to-business (B2B) customers,
        /// specify Business. For business-to-consumer (B2C) customers, specify Individual. For
        /// business-to-government (B2G), specify Government.Note that certain values may not
        /// applicable for the request country. Please refer to country specific information in
        /// API document. 
        /// </para>
        /// </summary>
        public Sector Sector
        {
            get { return this._sector; }
            set { this._sector = value; }
        }

        // Check to see if Sector property is set
        internal bool IsSetSector()
        {
            return this._sector != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationDetails. 
        /// <para>
        /// Additional details needed to verify your TRN information in Brazil. You only need
        /// to specify this parameter when you set a TRN in Brazil that is the CPF tax type.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't specify this parameter to set a TRN in Brazil of the CNPJ tax type or to set
        /// a TRN for another country. 
        /// </para>
        ///  </note>
        /// </summary>
        public VerificationDetails VerificationDetails
        {
            get { return this._verificationDetails; }
            set { this._verificationDetails = value; }
        }

        // Check to see if VerificationDetails property is set
        internal bool IsSetVerificationDetails()
        {
            return this._verificationDetails != null;
        }

    }
}