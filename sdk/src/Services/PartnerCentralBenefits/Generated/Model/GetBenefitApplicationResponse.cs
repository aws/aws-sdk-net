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
    /// This is the response object from the GetBenefitApplication operation.
    /// </summary>
    public partial class GetBenefitApplicationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private List<string> _associatedResources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Amazon.Runtime.Documents.Document _benefitApplicationDetails;
        private string _benefitId;
        private string _catalog;
        private DateTime? _createdAt;
        private string _description;
        private List<FileDetail> _fileDetails = AWSConfigs.InitializeCollections ? new List<FileDetail>() : null;
        private List<string> _fulfillmentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _id;
        private string _name;
        private List<Contact> _partnerContacts = AWSConfigs.InitializeCollections ? new List<Contact>() : null;
        private List<string> _programs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _revision;
        private string _stage;
        private BenefitApplicationStatus _status;
        private string _statusReason;
        private string _statusReasonCode;
        private List<string> _statusReasonCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the benefit application.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedResources. 
        /// <para>
        /// AWS resources that are associated with this benefit application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property BenefitId. 
        /// <para>
        /// The identifier of the benefit being requested in this application.
        /// </para>
        /// </summary>
        public string BenefitId
        {
            get { return this._benefitId; }
            set { this._benefitId = value; }
        }

        // Check to see if BenefitId property is set
        internal bool IsSetBenefitId()
        {
            return this._benefitId != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier that the benefit application belongs to.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the benefit application was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A detailed description of the benefit application.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<FileDetail> FileDetails
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
        /// The fulfillment types requested for this benefit application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the benefit application.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The human-readable name of the benefit application.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property Programs. 
        /// <para>
        /// The AWS partner programs associated with this benefit application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Programs
        {
            get { return this._programs; }
            set { this._programs = value; }
        }

        // Check to see if Programs property is set
        internal bool IsSetPrograms()
        {
            return this._programs != null && (this._programs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The current revision number of the benefit application.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The current stage in the benefit application processing workflow.
        /// </para>
        /// </summary>
        public string Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current processing status of the benefit application.
        /// </para>
        /// </summary>
        public BenefitApplicationStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information explaining the current status of the benefit application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReasonCode. 
        /// <para>
        /// A standardized code representing the reason for the current status.
        /// </para>
        /// </summary>
        [Obsolete("This field is no longer used")]
        [AWSProperty(Min=1, Max=255)]
        public string StatusReasonCode
        {
            get { return this._statusReasonCode; }
            set { this._statusReasonCode = value; }
        }

        // Check to see if StatusReasonCode property is set
        internal bool IsSetStatusReasonCode()
        {
            return this._statusReasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReasonCodes. 
        /// <para>
        /// The list of standardized codes representing the reason for the current status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> StatusReasonCodes
        {
            get { return this._statusReasonCodes; }
            set { this._statusReasonCodes = value; }
        }

        // Check to see if StatusReasonCodes property is set
        internal bool IsSetStatusReasonCodes()
        {
            return this._statusReasonCodes != null && (this._statusReasonCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the benefit application was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}