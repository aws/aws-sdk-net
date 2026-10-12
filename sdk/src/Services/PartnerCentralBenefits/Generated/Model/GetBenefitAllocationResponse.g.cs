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
    /// This is the response object from the GetBenefitAllocation operation.
    /// </summary>
    public partial class GetBenefitAllocationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicableBenefitIds. 
        /// <para>
        /// A list of benefit identifiers that this allocation can be applied to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApplicableBenefitIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApplicableBenefitIds property is set.
        /// </summary>
        internal bool IsSetApplicableBenefitIds() => this.ApplicableBenefitIds != null && (this.ApplicableBenefitIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the benefit allocation.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BenefitApplicationId. 
        /// <para>
        /// The identifier of the benefit application that resulted in this allocation.
        /// </para>
        /// </summary>
        public string BenefitApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the BenefitApplicationId property is set.
        /// </summary>
        internal bool IsSetBenefitApplicationId() => this.BenefitApplicationId != null;

        /// <summary>
        /// Gets and sets the property BenefitId. 
        /// <para>
        /// The identifier of the benefit that this allocation is based on.
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
        /// The catalog identifier that the benefit allocation belongs to.
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
        /// The timestamp when the benefit allocation was created.
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
        /// A detailed description of the benefit allocation.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The timestamp when the benefit allocation expires and is no longer usable.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property FulfillmentDetail. 
        /// <para>
        /// Detailed information about how the benefit allocation is fulfilled.
        /// </para>
        /// </summary>
        public FulfillmentDetails FulfillmentDetail { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentDetail property is set.
        /// </summary>
        internal bool IsSetFulfillmentDetail() => this.FulfillmentDetail != null;

        /// <summary>
        /// Gets and sets the property FulfillmentType. 
        /// <para>
        /// The fulfillment type used for this benefit allocation.
        /// </para>
        /// </summary>
        public FulfillmentType FulfillmentType { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentType property is set.
        /// </summary>
        internal bool IsSetFulfillmentType() => this.FulfillmentType != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the benefit allocation.
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
        /// The human-readable name of the benefit allocation.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property StartsAt. 
        /// <para>
        /// The timestamp when the benefit allocation becomes active and usable.
        /// </para>
        /// </summary>
        public DateTime? StartsAt { get; set; }

        /// <summary>
        /// Checks to see if the StartsAt property is set.
        /// </summary>
        internal bool IsSetStartsAt() => this.StartsAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the benefit allocation (e.g., active, expired, consumed).
        /// </para>
        /// </summary>
        public BenefitAllocationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information explaining the current status of the benefit allocation.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the benefit allocation was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
