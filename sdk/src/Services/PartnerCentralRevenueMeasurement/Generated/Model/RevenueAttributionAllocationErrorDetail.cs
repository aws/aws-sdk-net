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
    /// Details of a validation error for a single revenue attribution allocation record.
    /// </summary>
    public partial class RevenueAttributionAllocationErrorDetail
    {
        private RevenueAttributionAllocationAction _action;
        private string _customerAwsAccountId;
        private string _effectiveFrom;
        private string _effectiveUntil;
        private string _entityId;
        private EntityType _entityType;
        private RevenueAttributionAllocationErrorCode _errorCode;
        private string _errorMessage;
        private string _revenueAttributionAllocationId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that was attempted.
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
        /// The customer AWS account ID of the failing record.
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
        /// Effective start date of the failing record.
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
        /// Effective end date of the failing record.
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
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The deal entity identifier of the failing record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The deal entity type of the failing record.
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
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Machine-readable error code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RevenueAttributionAllocationErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Human-readable error description.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property RevenueAttributionAllocationId. 
        /// <para>
        /// The allocation identifier. Present for UPDATE actions; absent for CREATE actions.
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

    }
}