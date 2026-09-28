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
    /// Information about an order.
    /// </summary>
    public partial class Order
    {
        /// <summary>
        /// Gets and sets the property LineItems. 
        /// <para>
        /// The line items for the order
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LineItem> LineItems { get; set; } = AWSConfigs.InitializeCollections ? new List<LineItem>() : null;

        /// <summary>
        /// Checks to see if the LineItems property is set.
        /// </summary>
        internal bool IsSetLineItems() => this.LineItems != null && (this.LineItems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrderFulfilledDate. 
        /// <para>
        /// The fulfillment date of the order.
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
        /// The ID of the order.
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
        /// The submission date for the order.
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
        ///  The ID of the Outpost in the order. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string OutpostId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostId property is set.
        /// </summary>
        internal bool IsSetOutpostId() => this.OutpostId != null;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option for the order.
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property PaymentTerm. 
        /// <para>
        /// The payment term.
        /// </para>
        /// </summary>
        public PaymentTerm PaymentTerm { get; set; }

        /// <summary>
        /// Checks to see if the PaymentTerm property is set.
        /// </summary>
        internal bool IsSetPaymentTerm() => this.PaymentTerm != null;

        /// <summary>
        /// Gets and sets the property QuoteIdentifier. 
        /// <para>
        /// The ID of the quote associated with the order.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string QuoteIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the QuoteIdentifier property is set.
        /// </summary>
        internal bool IsSetQuoteIdentifier() => this.QuoteIdentifier != null;

        /// <summary>
        /// Gets and sets the property QuoteOptionIdentifier. 
        /// <para>
        /// The ID of the quote option associated with the order.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 21)]
        public string QuoteOptionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the QuoteOptionIdentifier property is set.
        /// </summary>
        internal bool IsSetQuoteOptionIdentifier() => this.QuoteOptionIdentifier != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the order.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PREPARING</c> - Order is received and being prepared.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - Order is either being built or shipped. To get more details,
        /// see the line item status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELIVERED</c> - Order was delivered to the Outpost site.
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
        /// The following status are deprecated: <c>RECEIVED</c>, <c>PENDING</c>, <c>PROCESSING</c>,
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
