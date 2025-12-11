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
    /// Container for the parameters to the CreatePartner operation.
    /// Creates a new partner account in the AWS Partner Network with the specified details
    /// and configuration.
    /// </summary>
    public partial class CreatePartnerRequest : AmazonPartnerCentralAccountRequest
    {
        private AllianceLeadContact _allianceLeadContact;
        private string _catalog;
        private string _clientToken;
        private string _emailVerificationCode;
        private string _legalName;
        private PrimarySolutionType _primarySolutionType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AllianceLeadContact. 
        /// <para>
        /// The primary contact person for alliance and partnership matters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AllianceLeadContact AllianceLeadContact
        {
            get { return this._allianceLeadContact; }
            set { this._allianceLeadContact = value; }
        }

        // Check to see if AllianceLeadContact property is set
        internal bool IsSetAllianceLeadContact()
        {
            return this._allianceLeadContact != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier where the partner account will be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EmailVerificationCode. 
        /// <para>
        /// The verification code sent to the alliance lead contact's email to confirm account
        /// creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=6, Max=6)]
        public string EmailVerificationCode
        {
            get { return this._emailVerificationCode; }
            set { this._emailVerificationCode = value; }
        }

        // Check to see if EmailVerificationCode property is set
        internal bool IsSetEmailVerificationCode()
        {
            return this._emailVerificationCode != null;
        }

        /// <summary>
        /// Gets and sets the property LegalName. 
        /// <para>
        /// The legal name of the organization becoming a partner.
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
        /// Gets and sets the property PrimarySolutionType. 
        /// <para>
        /// The primary type of solution or service the partner provides (e.g., consulting, software,
        /// managed services).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrimarySolutionType PrimarySolutionType
        {
            get { return this._primarySolutionType; }
            set { this._primarySolutionType = value; }
        }

        // Check to see if PrimarySolutionType property is set
        internal bool IsSetPrimarySolutionType()
        {
            return this._primarySolutionType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the partner account for organization and billing
        /// purposes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}