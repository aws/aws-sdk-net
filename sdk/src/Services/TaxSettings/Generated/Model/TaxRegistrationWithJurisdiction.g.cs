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
    /// Your TRN information with jurisdiction details. This doesn't contain the full legal
    /// address associated with the TRN information.
    /// </summary>
    public partial class TaxRegistrationWithJurisdiction
    {
        /// <summary>
        /// Gets and sets the property AdditionalTaxInformation. 
        /// <para>
        /// Additional tax information associated with your TRN. 
        /// </para>
        /// </summary>
        public AdditionalInfoResponse AdditionalTaxInformation { get; set; }

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
        /// Gets and sets the property Jurisdiction. 
        /// <para>
        ///  The jurisdiction associated with your TRN information. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Jurisdiction Jurisdiction { get; set; }

        /// <summary>
        /// Checks to see if the Jurisdiction property is set.
        /// </summary>
        internal bool IsSetJurisdiction() => this.Jurisdiction != null;

        /// <summary>
        /// Gets and sets the property LegalName. 
        /// <para>
        /// The legal name associated with your TRN information. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
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
        ///  The type of your tax registration. This can be either <c>VAT</c> or <c>GST</c>. 
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of your TRN. This can be either <c>Verified</c>, <c>Pending</c>, <c>Deleted</c>,
        /// or <c>Rejected</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TaxRegistrationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaxDocumentMetadatas. 
        /// <para>
        /// The metadata for your tax document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<TaxDocumentMetadata> TaxDocumentMetadatas { get; set; } = AWSConfigs.InitializeCollections ? new List<TaxDocumentMetadata>() : null;

        /// <summary>
        /// Checks to see if the TaxDocumentMetadatas property is set.
        /// </summary>
        internal bool IsSetTaxDocumentMetadatas() => this.TaxDocumentMetadatas != null && (this.TaxDocumentMetadatas.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
