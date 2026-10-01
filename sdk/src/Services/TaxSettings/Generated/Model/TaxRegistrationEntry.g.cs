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
    /// The TRN information you provide when you add a new TRN, or update.
    /// </summary>
    public partial class TaxRegistrationEntry
    {
        /// <summary>
        /// Gets and sets the property AdditionalTaxInformation. 
        /// <para>
        ///  Additional tax information associated with your TRN. You only need to specify this
        /// parameter if Amazon Web Services collects any additional information for your country
        /// within <a>AdditionalInfoRequest</a>.
        /// </para>
        /// </summary>
        public AdditionalInfoRequest AdditionalTaxInformation { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalTaxInformation property is set.
        /// </summary>
        internal bool IsSetAdditionalTaxInformation() => this.AdditionalTaxInformation != null;

        /// <summary>
        /// Gets and sets the property CertifiedEmailId. 
        /// <para>
        /// The email address to receive VAT invoices.
        /// </para>
        /// </summary>
        public string CertifiedEmailId { get; set; }

        /// <summary>
        /// Checks to see if the CertifiedEmailId property is set.
        /// </summary>
        internal bool IsSetCertifiedEmailId() => this.CertifiedEmailId != null;

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
        public Address LegalAddress { get; set; }

        /// <summary>
        /// Checks to see if the LegalAddress property is set.
        /// </summary>
        internal bool IsSetLegalAddress() => this.LegalAddress != null;

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
        [AWSProperty(Min = 1, Max = 200)]
        public string LegalName { get; set; }

        /// <summary>
        /// Checks to see if the LegalName property is set.
        /// </summary>
        internal bool IsSetLegalName() => this.LegalName != null;

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// Your tax registration unique identifier. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationId property is set.
        /// </summary>
        internal bool IsSetRegistrationId() => this.RegistrationId != null;

        /// <summary>
        /// Gets and sets the property RegistrationType. 
        /// <para>
        ///  Your tax registration type. This can be either <c>VAT</c> or <c>GST</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TaxRegistrationType RegistrationType { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationType property is set.
        /// </summary>
        internal bool IsSetRegistrationType() => this.RegistrationType != null;

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
        public Sector Sector { get; set; }

        /// <summary>
        /// Checks to see if the Sector property is set.
        /// </summary>
        internal bool IsSetSector() => this.Sector != null;

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
        public VerificationDetails VerificationDetails { get; set; }

        /// <summary>
        /// Checks to see if the VerificationDetails property is set.
        /// </summary>
        internal bool IsSetVerificationDetails() => this.VerificationDetails != null;
    }
}
