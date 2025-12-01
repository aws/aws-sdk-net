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
    /// Container for the parameters to the CreateBenefitApplication operation.
    /// Creates a new benefit application for a partner to request access to AWS benefits
    /// and programs.
    /// </summary>
    public partial class CreateBenefitApplicationRequest : AmazonPartnerCentralBenefitsRequest
    {
        private List<string> _associatedResources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Amazon.Runtime.Documents.Document _benefitApplicationDetails;
        private string _benefitIdentifier;
        private string _catalog;
        private string _clientToken;
        private string _description;
        private List<FileInput> _fileDetails = AWSConfigs.InitializeCollections ? new List<FileInput>() : null;
        private List<string> _fulfillmentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private List<Contact> _partnerContacts = AWSConfigs.InitializeCollections ? new List<Contact>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedResources. 
        /// <para>
        /// AWS resources that are associated with this benefit application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> AssociatedResources
        {
            get { return this._associatedResources; }
            set { this._associatedResources = value; }
        }

        // Check to see if AssociatedResources property is set
        internal bool IsSetAssociatedResources()
        {
            return this._associatedResources != null && (this._associatedResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BenefitApplicationDetails. 
        /// <para>
        /// Detailed information and requirements specific to the benefit being requested.
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
        /// Gets and sets the property BenefitIdentifier. 
        /// <para>
        /// The unique identifier of the benefit being requested in this application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BenefitIdentifier
        {
            get { return this._benefitIdentifier; }
            set { this._benefitIdentifier = value; }
        }

        // Check to see if BenefitIdentifier property is set
        internal bool IsSetBenefitIdentifier()
        {
            return this._benefitIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier that specifies which benefit catalog to create the application
        /// in.
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
        /// A unique, case-sensitive identifier to ensure idempotent processing of the creation
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
        /// A detailed description of the benefit application and its intended use.
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
        /// Supporting documents and files attached to the benefit application.
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
        /// Gets and sets the property FulfillmentTypes. 
        /// <para>
        /// The types of fulfillment requested for this benefit application (e.g., credits, access,
        /// disbursement).
        /// </para>
        /// </summary>
        public List<string> FulfillmentTypes
        {
            get { return this._fulfillmentTypes; }
            set { this._fulfillmentTypes = value; }
        }

        // Check to see if FulfillmentTypes property is set
        internal bool IsSetFulfillmentTypes()
        {
            return this._fulfillmentTypes != null && (this._fulfillmentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A human-readable name for the benefit application.
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
        /// Contact information for partner representatives responsible for this benefit application.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs to categorize and organize the benefit application.
        /// </para>
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