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

namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// This is the response object from the GetBenefitApplication operation.
    /// </summary>
    public partial class GetBenefitApplicationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the benefit application.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociatedResources. 
        /// <para>
        /// AWS resources that are associated with this benefit application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> AssociatedResources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedResources property is set.
        /// </summary>
        internal bool IsSetAssociatedResources() => this.AssociatedResources != null && (this.AssociatedResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BenefitApplicationDetails. 
        /// <para>
        /// Detailed information and requirements specific to the benefit being requested.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document BenefitApplicationDetails { get; set; }

        /// <summary>
        /// Checks to see if the BenefitApplicationDetails property is set.
        /// </summary>
        internal bool IsSetBenefitApplicationDetails() => !this.BenefitApplicationDetails.IsNull();

        /// <summary>
        /// Gets and sets the property BenefitId. 
        /// <para>
        /// The identifier of the benefit being requested in this application.
        /// </para>
        /// </summary>
        public string BenefitId { get; set; }

        /// <summary>
        /// Checks to see if the BenefitId property is set.
        /// </summary>
        internal bool IsSetBenefitId() => this.BenefitId != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier that the benefit application belongs to.
        /// </para>
        /// </summary>
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the benefit application was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A detailed description of the benefit application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FileDetails. 
        /// <para>
        /// Supporting documents and files attached to the benefit application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 30)]
        public List<FileDetail> FileDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<FileDetail>() : null;

        /// <summary>
        /// Checks to see if the FileDetails property is set.
        /// </summary>
        internal bool IsSetFileDetails() => this.FileDetails != null && (this.FileDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FulfillmentTypes. 
        /// <para>
        /// The fulfillment types requested for this benefit application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FulfillmentTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FulfillmentTypes property is set.
        /// </summary>
        internal bool IsSetFulfillmentTypes() => this.FulfillmentTypes != null && (this.FulfillmentTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the benefit application.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The human-readable name of the benefit application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PartnerContacts. 
        /// <para>
        /// Contact information for partner representatives responsible for this benefit application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Contact> PartnerContacts { get; set; } = AWSConfigs.InitializeCollections ? new List<Contact>() : null;

        /// <summary>
        /// Checks to see if the PartnerContacts property is set.
        /// </summary>
        internal bool IsSetPartnerContacts() => this.PartnerContacts != null && (this.PartnerContacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Programs. 
        /// <para>
        /// The AWS partner programs associated with this benefit application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Programs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Programs property is set.
        /// </summary>
        internal bool IsSetPrograms() => this.Programs != null && (this.Programs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The current revision number of the benefit application.
        /// </para>
        /// </summary>
        public string Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The current stage in the benefit application processing workflow.
        /// </para>
        /// </summary>
        public string Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current processing status of the benefit application.
        /// </para>
        /// </summary>
        public BenefitApplicationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information explaining the current status of the benefit application.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property StatusReasonCode. 
        /// <para>
        /// A standardized code representing the reason for the current status.
        /// </para>
        /// </summary>
        [Obsolete("This field is no longer used")]
        [AWSProperty(Min = 1, Max = 255)]
        public string StatusReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusReasonCode property is set.
        /// </summary>
        internal bool IsSetStatusReasonCode() => this.StatusReasonCode != null;

        /// <summary>
        /// Gets and sets the property StatusReasonCodes. 
        /// <para>
        /// The list of standardized codes representing the reason for the current status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> StatusReasonCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatusReasonCodes property is set.
        /// </summary>
        internal bool IsSetStatusReasonCodes() => this.StatusReasonCodes != null && (this.StatusReasonCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the benefit application was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
