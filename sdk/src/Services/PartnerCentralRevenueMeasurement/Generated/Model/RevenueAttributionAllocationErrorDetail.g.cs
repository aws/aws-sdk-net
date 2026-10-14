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

namespace Amazon.PartnerCentralRevenueMeasurement.Model
{
    /// <summary>
    /// Details of a validation error for a single revenue attribution allocation record.
    /// </summary>
    public partial class RevenueAttributionAllocationErrorDetail
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that was attempted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RevenueAttributionAllocationAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property CustomerAwsAccountId. 
        /// <para>
        /// The customer AWS account ID of the failing record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 12, Max = 12)]
        public string CustomerAwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerAwsAccountId property is set.
        /// </summary>
        internal bool IsSetCustomerAwsAccountId() => this.CustomerAwsAccountId != null;

        /// <summary>
        /// Gets and sets the property EffectiveFrom. 
        /// <para>
        /// Effective start date of the failing record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string EffectiveFrom { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveFrom property is set.
        /// </summary>
        internal bool IsSetEffectiveFrom() => this.EffectiveFrom != null;

        /// <summary>
        /// Gets and sets the property EffectiveUntil. 
        /// <para>
        /// Effective end date of the failing record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string EffectiveUntil { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveUntil property is set.
        /// </summary>
        internal bool IsSetEffectiveUntil() => this.EffectiveUntil != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The deal entity identifier of the failing record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The deal entity type of the failing record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EntityType EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Machine-readable error code.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RevenueAttributionAllocationErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Human-readable error description.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property RevenueAttributionAllocationId. 
        /// <para>
        /// The allocation identifier. Present for UPDATE actions; absent for CREATE actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string RevenueAttributionAllocationId { get; set; }

        /// <summary>
        /// Checks to see if the RevenueAttributionAllocationId property is set.
        /// </summary>
        internal bool IsSetRevenueAttributionAllocationId() => this.RevenueAttributionAllocationId != null;
    }
}
