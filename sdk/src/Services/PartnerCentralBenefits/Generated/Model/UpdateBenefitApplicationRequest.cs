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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
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
namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBenefitApplication operation.
    /// Updates an existing benefit application with new information while maintaining revision
    /// control.
    /// </summary>
    public partial class UpdateBenefitApplicationRequest : AmazonPartnerCentralBenefitsRequest
    {
        private Amazon.Runtime.Documents.Document _benefitApplicationDetails;
        private string _catalog;
        private string _clientToken;
        private string _description;
        private List<FileInput> _fileDetails = AWSConfigs.InitializeCollections ? new List<FileInput>() : null;
        private string _identifier;
        private string _name;
        private List<Contact> _partnerContacts = AWSConfigs.InitializeCollections ? new List<Contact>() : null;
        private string _revision;

        /// <summary>
        /// Gets and sets the property BenefitApplicationDetails. 
        /// <para>
        /// Updated detailed information and requirements specific to the benefit being requested.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document BenefitApplicationDetails
        {
            get { return this._benefitApplicationDetails; }
            set { this._benefitApplicationDetails = value; }
        }

        // Check to see if BenefitApplicationDetails property is set
        internal bool IsSetBenefitApplicationDetails()
        {
            return !this._benefitApplicationDetails.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier that specifies which benefit catalog the application belongs
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A unique, case-sensitive identifier to ensure idempotent processing of the update
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated detailed description of the benefit application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FileDetails. 
        /// <para>
        /// Updated supporting documents and files attached to the benefit application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<FileInput> FileDetails
        {
            get { return this._fileDetails; }
            set { this._fileDetails = value; }
        }

        // Check to see if FileDetails property is set
        internal bool IsSetFileDetails()
        {
            return this._fileDetails != null && (this._fileDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier of the benefit application to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated human-readable name for the benefit application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PartnerContacts. 
        /// <para>
        /// Updated contact information for partner representatives responsible for this benefit
        /// application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<Contact> PartnerContacts
        {
            get { return this._partnerContacts; }
            set { this._partnerContacts = value; }
        }

        // Check to see if PartnerContacts property is set
        internal bool IsSetPartnerContacts()
        {
            return this._partnerContacts != null && (this._partnerContacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The current revision number of the benefit application to ensure optimistic concurrency
        /// control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

    }
}