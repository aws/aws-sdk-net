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
    /// Your TRN information.
    /// </summary>
    public partial class TaxRegistration
    {
        private AdditionalInfoResponse _additionalTaxInformation;
        private string _certifiedEmailId;
        private Address _legalAddress;
        private string _legalName;
        private string _registrationId;
        private TaxRegistrationType _registrationType;
        private Sector _sector;
        private TaxRegistrationStatus _status;
        private List<TaxDocumentMetadata> _taxDocumentMetadatas = AWSConfigs.InitializeCollections ? new List<TaxDocumentMetadata>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalTaxInformation. 
        /// <para>
        ///  Additional tax information associated with your TRN. 
        /// </para>
        /// </summary>
        public AdditionalInfoResponse AdditionalTaxInformation
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
        ///  The legal address associated with your TRN registration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  The legal name associated with your TRN registration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        ///  Your tax registration unique identifier. 
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
        /// Type of your tax registration. 
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
        /// business-to-government (B2G), specify Government. Note that certain values may not
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of your TRN. This can be either <c>Verified</c>, <c>Pending</c>, <c>Deleted</c>,
        /// or <c>Rejected</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaxRegistrationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TaxDocumentMetadatas. 
        /// <para>
        /// The metadata for your tax document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<TaxDocumentMetadata> TaxDocumentMetadatas
        {
            get { return this._taxDocumentMetadatas; }
            set { this._taxDocumentMetadatas = value; }
        }

        // Check to see if TaxDocumentMetadatas property is set
        internal bool IsSetTaxDocumentMetadatas()
        {
            return this._taxDocumentMetadatas != null && (this._taxDocumentMetadatas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}