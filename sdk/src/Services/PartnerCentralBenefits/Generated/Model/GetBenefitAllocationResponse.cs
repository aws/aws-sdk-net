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
    /// This is the response object from the GetBenefitAllocation operation.
    /// </summary>
    public partial class GetBenefitAllocationResponse : AmazonWebServiceResponse
    {
        private List<string> _applicableBenefitIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _arn;
        private string _benefitApplicationId;
        private string _benefitId;
        private string _catalog;
        private DateTime? _createdAt;
        private string _description;
        private DateTime? _expiresAt;
        private FulfillmentDetails _fulfillmentDetail;
        private FulfillmentType _fulfillmentType;
        private string _id;
        private string _name;
        private DateTime? _startsAt;
        private BenefitAllocationStatus _status;
        private string _statusReason;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ApplicableBenefitIds. 
        /// <para>
        /// A list of benefit identifiers that this allocation can be applied to.
        /// </para>
        /// </summary>
        public List<string> ApplicableBenefitIds
        {
            get { return this._applicableBenefitIds; }
            set { this._applicableBenefitIds = value; }
        }

        // Check to see if ApplicableBenefitIds property is set
        internal bool IsSetApplicableBenefitIds()
        {
            return this._applicableBenefitIds != null && (this._applicableBenefitIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the benefit allocation.
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
        /// Gets and sets the property BenefitApplicationId. 
        /// <para>
        /// The identifier of the benefit application that resulted in this allocation.
        /// </para>
        /// </summary>
        public string BenefitApplicationId
        {
            get { return this._benefitApplicationId; }
            set { this._benefitApplicationId = value; }
        }

        // Check to see if BenefitApplicationId property is set
        internal bool IsSetBenefitApplicationId()
        {
            return this._benefitApplicationId != null;
        }

        /// <summary>
        /// Gets and sets the property BenefitId. 
        /// <para>
        /// The identifier of the benefit that this allocation is based on.
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
        /// The catalog identifier that the benefit allocation belongs to.
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
        /// The timestamp when the benefit allocation was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
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
        /// A detailed description of the benefit allocation.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The timestamp when the benefit allocation expires and is no longer usable.
        /// </para>
        /// </summary>
        public DateTime ExpiresAt
        {
            get { return this._expiresAt.GetValueOrDefault(); }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FulfillmentDetail. 
        /// <para>
        /// Detailed information about how the benefit allocation is fulfilled.
        /// </para>
        /// </summary>
        public FulfillmentDetails FulfillmentDetail
        {
            get { return this._fulfillmentDetail; }
            set { this._fulfillmentDetail = value; }
        }

        // Check to see if FulfillmentDetail property is set
        internal bool IsSetFulfillmentDetail()
        {
            return this._fulfillmentDetail != null;
        }

        /// <summary>
        /// Gets and sets the property FulfillmentType. 
        /// <para>
        /// The fulfillment type used for this benefit allocation.
        /// </para>
        /// </summary>
        public FulfillmentType FulfillmentType
        {
            get { return this._fulfillmentType; }
            set { this._fulfillmentType = value; }
        }

        // Check to see if FulfillmentType property is set
        internal bool IsSetFulfillmentType()
        {
            return this._fulfillmentType != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the benefit allocation.
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
        /// The human-readable name of the benefit allocation.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StartsAt. 
        /// <para>
        /// The timestamp when the benefit allocation becomes active and usable.
        /// </para>
        /// </summary>
        public DateTime StartsAt
        {
            get { return this._startsAt.GetValueOrDefault(); }
            set { this._startsAt = value; }
        }

        // Check to see if StartsAt property is set
        internal bool IsSetStartsAt()
        {
            return this._startsAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the benefit allocation (e.g., active, expired, consumed).
        /// </para>
        /// </summary>
        public BenefitAllocationStatus Status
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
        /// Additional information explaining the current status of the benefit allocation.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the benefit allocation was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}