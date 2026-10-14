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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Represents the output of a <c>PurchaseReservedNodesOffering</c> operation.
    /// </summary>
    public partial class ReservedNode
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the reserved node.
        /// </para>
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

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
        /// The fixed price charged for this reserved node.
        /// </para>
        /// </summary>
        public double? FixedPrice { get; set; }

        /// <summary>
        /// Checks to see if the FixedPrice property is set.
        /// </summary>
        internal bool IsSetFixedPrice() => this.FixedPrice.HasValue;

        /// <summary>
        /// Gets and sets the property NodeCount. 
        /// <para>
        /// The number of nodes that have been reserved.
        /// </para>
        /// </summary>
        public int? NodeCount { get; set; }

        /// <summary>
        /// Checks to see if the NodeCount property is set.
        /// </summary>
        internal bool IsSetNodeCount() => this.NodeCount.HasValue;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type for the reserved nodes.
        /// </para>
        /// </summary>
        public string NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The offering type of this reserved node.
        /// </para>
        /// </summary>
        public string OfferingType { get; set; }

        /// <summary>
        /// Checks to see if the OfferingType property is set.
        /// </summary>
        internal bool IsSetOfferingType() => this.OfferingType != null;

        /// <summary>
        /// Gets and sets the property RecurringCharges. 
        /// <para>
        /// The recurring price charged to run this reserved node.
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
        /// Gets and sets the property ReservationId. 
        /// <para>
        /// A customer-specified identifier to track this reservation.
        /// </para>
        /// </summary>
        public string ReservationId { get; set; }

        /// <summary>
        /// Checks to see if the ReservationId property is set.
        /// </summary>
        internal bool IsSetReservationId() => this.ReservationId != null;

        /// <summary>
        /// Gets and sets the property ReservedNodesOfferingId. 
        /// <para>
        /// The ID of the reserved node offering to purchase.
        /// </para>
        /// </summary>
        public string ReservedNodesOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedNodesOfferingId property is set.
        /// </summary>
        internal bool IsSetReservedNodesOfferingId() => this.ReservedNodesOfferingId != null;

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
        /// The state of the reserved node.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
