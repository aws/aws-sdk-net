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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// This data type is used as a response element in the <c>DescribeReservedDBInstances</c>
    /// and <c>PurchaseReservedDBInstancesOffering</c> actions.
    /// </summary>
    public partial class ReservedDBInstance
    {
        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the reserved DB instance.
        /// </para>
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        /// The DB instance class for the reserved DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceClass property is set.
        /// </summary>
        internal bool IsSetDBInstanceClass() => this.DBInstanceClass != null;

        /// <summary>
        /// Gets and sets the property DBInstanceCount. 
        /// <para>
        /// The number of reserved DB instances.
        /// </para>
        /// </summary>
        public int? DBInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceCount property is set.
        /// </summary>
        internal bool IsSetDBInstanceCount() => this.DBInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration of the reservation in seconds.
        /// </para>
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property FixedPrice. 
        /// <para>
        /// The fixed price charged for this reserved DB instance.
        /// </para>
        /// </summary>
        public double? FixedPrice { get; set; }

        /// <summary>
        /// Checks to see if the FixedPrice property is set.
        /// </summary>
        internal bool IsSetFixedPrice() => this.FixedPrice.HasValue;

        /// <summary>
        /// Gets and sets the property LeaseId. 
        /// <para>
        /// The unique identifier for the lease associated with the reserved DB instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Web Services Support might request the lease ID for an issue related to a reserved
        /// DB instance.
        /// </para>
        ///  </note>
        /// </summary>
        public string LeaseId { get; set; }

        /// <summary>
        /// Checks to see if the LeaseId property is set.
        /// </summary>
        internal bool IsSetLeaseId() => this.LeaseId != null;

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Indicates whether the reservation applies to Multi-AZ deployments.
        /// </para>
        /// </summary>
        public bool? MultiAZ { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZ property is set.
        /// </summary>
        internal bool IsSetMultiAZ() => this.MultiAZ.HasValue;

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The offering type of this reserved DB instance.
        /// </para>
        /// </summary>
        public string OfferingType { get; set; }

        /// <summary>
        /// Checks to see if the OfferingType property is set.
        /// </summary>
        internal bool IsSetOfferingType() => this.OfferingType != null;

        /// <summary>
        /// Gets and sets the property ProductDescription. 
        /// <para>
        /// The description of the reserved DB instance.
        /// </para>
        /// </summary>
        public string ProductDescription { get; set; }

        /// <summary>
        /// Checks to see if the ProductDescription property is set.
        /// </summary>
        internal bool IsSetProductDescription() => this.ProductDescription != null;

        /// <summary>
        /// Gets and sets the property RecurringCharges. 
        /// <para>
        /// The recurring price charged to run this reserved DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecurringCharge> RecurringCharges { get; set; } = AWSConfigs.InitializeCollections ? new List<RecurringCharge>() : null;

        /// <summary>
        /// Checks to see if the RecurringCharges property is set.
        /// </summary>
        internal bool IsSetRecurringCharges() => this.RecurringCharges != null && (this.RecurringCharges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReservedDBInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the reserved DB instance.
        /// </para>
        /// </summary>
        public string ReservedDBInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the ReservedDBInstanceArn property is set.
        /// </summary>
        internal bool IsSetReservedDBInstanceArn() => this.ReservedDBInstanceArn != null;

        /// <summary>
        /// Gets and sets the property ReservedDBInstanceId. 
        /// <para>
        /// The unique identifier for the reservation.
        /// </para>
        /// </summary>
        public string ReservedDBInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedDBInstanceId property is set.
        /// </summary>
        internal bool IsSetReservedDBInstanceId() => this.ReservedDBInstanceId != null;

        /// <summary>
        /// Gets and sets the property ReservedDBInstancesOfferingId. 
        /// <para>
        /// The offering identifier.
        /// </para>
        /// </summary>
        public string ReservedDBInstancesOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedDBInstancesOfferingId property is set.
        /// </summary>
        internal bool IsSetReservedDBInstancesOfferingId() => this.ReservedDBInstancesOfferingId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the reservation started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the reserved DB instance.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UsagePrice. 
        /// <para>
        /// The hourly price charged for this reserved DB instance.
        /// </para>
        /// </summary>
        public double? UsagePrice { get; set; }

        /// <summary>
        /// Checks to see if the UsagePrice property is set.
        /// </summary>
        internal bool IsSetUsagePrice() => this.UsagePrice.HasValue;
    }
}
