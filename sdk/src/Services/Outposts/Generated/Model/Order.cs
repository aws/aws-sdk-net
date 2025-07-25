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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
        private List<LineItem> _lineItems = AWSConfigs.InitializeCollections ? new List<LineItem>() : null;
        private DateTime? _orderFulfilledDate;
        private string _orderId;
        private DateTime? _orderSubmissionDate;
        private OrderType _orderType;
        private string _outpostId;
        private PaymentOption _paymentOption;
        private PaymentTerm _paymentTerm;
        private OrderStatus _status;

        /// <summary>
        /// Gets and sets the property LineItems. 
        /// <para>
        /// The line items for the order
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LineItem> LineItems
        {
            get { return this._lineItems; }
            set { this._lineItems = value; }
        }

        // Check to see if LineItems property is set
        internal bool IsSetLineItems()
        {
            return this._lineItems != null && (this._lineItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OrderFulfilledDate. 
        /// <para>
        /// The fulfillment date of the order.
        /// </para>
        /// </summary>
        public DateTime? OrderFulfilledDate
        {
            get { return this._orderFulfilledDate; }
            set { this._orderFulfilledDate = value; }
        }

        // Check to see if OrderFulfilledDate property is set
        internal bool IsSetOrderFulfilledDate()
        {
            return this._orderFulfilledDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrderId. 
        /// <para>
        /// The ID of the order.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string OrderId
        {
            get { return this._orderId; }
            set { this._orderId = value; }
        }

        // Check to see if OrderId property is set
        internal bool IsSetOrderId()
        {
            return this._orderId != null;
        }

        /// <summary>
        /// Gets and sets the property OrderSubmissionDate. 
        /// <para>
        /// The submission date for the order.
        /// </para>
        /// </summary>
        public DateTime? OrderSubmissionDate
        {
            get { return this._orderSubmissionDate; }
            set { this._orderSubmissionDate = value; }
        }

        // Check to see if OrderSubmissionDate property is set
        internal bool IsSetOrderSubmissionDate()
        {
            return this._orderSubmissionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrderType. 
        /// <para>
        /// The type of order.
        /// </para>
        /// </summary>
        public OrderType OrderType
        {
            get { return this._orderType; }
            set { this._orderType = value; }
        }

        // Check to see if OrderType property is set
        internal bool IsSetOrderType()
        {
            return this._orderType != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        ///  The ID of the Outpost in the order. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string OutpostId
        {
            get { return this._outpostId; }
            set { this._outpostId = value; }
        }

        // Check to see if OutpostId property is set
        internal bool IsSetOutpostId()
        {
            return this._outpostId != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option for the order.
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption
        {
            get { return this._paymentOption; }
            set { this._paymentOption = value; }
        }

        // Check to see if PaymentOption property is set
        internal bool IsSetPaymentOption()
        {
            return this._paymentOption != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentTerm. 
        /// <para>
        /// The payment term.
        /// </para>
        /// </summary>
        public PaymentTerm PaymentTerm
        {
            get { return this._paymentTerm; }
            set { this._paymentTerm = value; }
        }

        // Check to see if PaymentTerm property is set
        internal bool IsSetPaymentTerm()
        {
            return this._paymentTerm != null;
        }

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
        public OrderStatus Status
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