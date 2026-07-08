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
 * Do not modify this file. This file is generated from the partnercentral-revenue-measurement-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralRevenueMeasurement.Model
{
    /// <summary>
    /// A single allocation change within a batch request.
    /// </summary>
    public partial class RevenueShareAllocation
    {
        private RevenueAttributionAllocationAction _action;
        private string _customerAwsAccountId;
        private string _effectiveFrom;
        private string _effectiveUntil;
        private string _entityIdentifier;
        private EntityType _entityType;
        private string _revenueAttributionAllocationId;
        private string _revenueSharePercent;
        private AllocationStatus _status;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The operation type: CREATE or UPDATE.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RevenueAttributionAllocationAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerAwsAccountId. 
        /// <para>
        /// The customer AWS account ID for this associated deal entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=12, Max=12)]
        public string CustomerAwsAccountId
        {
            get { return this._customerAwsAccountId; }
            set { this._customerAwsAccountId = value; }
        }

        // Check to see if CustomerAwsAccountId property is set
        internal bool IsSetCustomerAwsAccountId()
        {
            return this._customerAwsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveFrom. 
        /// <para>
        /// The effective start date for this allocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string EffectiveFrom
        {
            get { return this._effectiveFrom; }
            set { this._effectiveFrom = value; }
        }

        // Check to see if EffectiveFrom property is set
        internal bool IsSetEffectiveFrom()
        {
            return this._effectiveFrom != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveUntil. 
        /// <para>
        /// The effective end date for this allocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string EffectiveUntil
        {
            get { return this._effectiveUntil; }
            set { this._effectiveUntil = value; }
        }

        // Check to see if EffectiveUntil property is set
        internal bool IsSetEffectiveUntil()
        {
            return this._effectiveUntil != null;
        }

        /// <summary>
        /// Gets and sets the property EntityIdentifier. 
        /// <para>
        /// The unique identifier of the associated deal entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string EntityIdentifier
        {
            get { return this._entityIdentifier; }
            set { this._entityIdentifier = value; }
        }

        // Check to see if EntityIdentifier property is set
        internal bool IsSetEntityIdentifier()
        {
            return this._entityIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of the associated deal entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntityType EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property RevenueAttributionAllocationId. 
        /// <para>
        /// The allocation to update. Required when Action is UPDATE.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string RevenueAttributionAllocationId
        {
            get { return this._revenueAttributionAllocationId; }
            set { this._revenueAttributionAllocationId = value; }
        }

        // Check to see if RevenueAttributionAllocationId property is set
        internal bool IsSetRevenueAttributionAllocationId()
        {
            return this._revenueAttributionAllocationId != null;
        }

        /// <summary>
        /// Gets and sets the property RevenueSharePercent. 
        /// <para>
        /// Revenue share percentage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6)]
        public string RevenueSharePercent
        {
            get { return this._revenueSharePercent; }
            set { this._revenueSharePercent = value; }
        }

        // Check to see if RevenueSharePercent property is set
        internal bool IsSetRevenueSharePercent()
        {
            return this._revenueSharePercent != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Allocation status. Defaults to ACTIVE on CREATE.
        /// </para>
        /// </summary>
        public AllocationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}