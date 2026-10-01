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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// A summary of line items in your order.
    /// </summary>
    public partial class OrderSummary
    {
        /// <summary>
        /// Gets and sets the property LineItemCountsByStatus. 
        /// <para>
        ///  The status of all line items in the order. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> LineItemCountsByStatus { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the LineItemCountsByStatus property is set.
        /// </summary>
        internal bool IsSetLineItemCountsByStatus() => this.LineItemCountsByStatus != null && (this.LineItemCountsByStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrderFulfilledDate. 
        /// <para>
        ///  The fulfilment date for the order. 
        /// </para>
        /// </summary>
        public DateTime? OrderFulfilledDate { get; set; }

        /// <summary>
        /// Checks to see if the OrderFulfilledDate property is set.
        /// </summary>
        internal bool IsSetOrderFulfilledDate() => this.OrderFulfilledDate.HasValue;

        /// <summary>
        /// Gets and sets the property OrderId. 
        /// <para>
        ///  The ID of the order. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string OrderId { get; set; }

        /// <summary>
        /// Checks to see if the OrderId property is set.
        /// </summary>
        internal bool IsSetOrderId() => this.OrderId != null;

        /// <summary>
        /// Gets and sets the property OrderSubmissionDate. 
        /// <para>
        ///  The submission date for the order. 
        /// </para>
        /// </summary>
        public DateTime? OrderSubmissionDate { get; set; }

        /// <summary>
        /// Checks to see if the OrderSubmissionDate property is set.
        /// </summary>
        internal bool IsSetOrderSubmissionDate() => this.OrderSubmissionDate.HasValue;

        /// <summary>
        /// Gets and sets the property OrderType. 
        /// <para>
        /// The type of order.
        /// </para>
        /// </summary>
        public OrderType OrderType { get; set; }

        /// <summary>
        /// Checks to see if the OrderType property is set.
        /// </summary>
        internal bool IsSetOrderType() => this.OrderType != null;

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        ///  The ID of the Outpost. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string OutpostId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostId property is set.
        /// </summary>
        internal bool IsSetOutpostId() => this.OutpostId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the order.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PREPARING</c> - Order is received and is being prepared.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - Order is either being built, shipped, or installed. For more
        /// information, see the <c>LineItem</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> - Order is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELLED</c> - Order is cancelled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c> - Customer should contact support.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The following statuses are deprecated: <c>RECEIVED</c>, <c>PENDING</c>, <c>PROCESSING</c>,
        /// <c>INSTALLING</c>, and <c>FULFILLED</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
