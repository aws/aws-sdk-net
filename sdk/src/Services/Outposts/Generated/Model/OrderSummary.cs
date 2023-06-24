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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// A summary of line items in your order.
    /// </summary>
    public partial class OrderSummary
    {
        private Dictionary<string, int> _lineItemCountsByStatus = new Dictionary<string, int>();
        private DateTime? _orderFulfilledDate;
        private string _orderId;
        private DateTime? _orderSubmissionDate;
        private OrderType _orderType;
        private string _outpostId;
        private OrderStatus _status;

        /// <summary>
        /// Gets and sets the property LineItemCountsByStatus. 
        /// <para>
        ///  The status of all line items in the order. 
        /// </para>
        /// </summary>
        public Dictionary<string, int> LineItemCountsByStatus
        {
            get { return this._lineItemCountsByStatus; }
            set { this._lineItemCountsByStatus = value; }
        }

        // Check to see if LineItemCountsByStatus property is set
        internal bool IsSetLineItemCountsByStatus()
        {
            return this._lineItemCountsByStatus != null && this._lineItemCountsByStatus.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrderFulfilledDate. 
        /// <para>
        ///  The fulfilment date for the order. 
        /// </para>
        /// </summary>
        public DateTime OrderFulfilledDate
        {
            get { return this._orderFulfilledDate.GetValueOrDefault(); }
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
        ///  The ID of the order. 
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
        ///  The submission date for the order. 
        /// </para>
        /// </summary>
        public DateTime OrderSubmissionDate
        {
            get { return this._orderSubmissionDate.GetValueOrDefault(); }
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
        ///  The ID of the Outpost. 
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the order.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PREPARING</code> - Order is received and is being prepared.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_PROGRESS</code> - Order is either being built, shipped, or installed. For
        /// more information, see the <code>LineItem</code> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMPLETED</code> - Order is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CANCELLED</code> - Order is cancelled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ERROR</code> - Customer should contact support.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The following statuses are deprecated: <code>RECEIVED</code>, <code>PENDING</code>,
        /// <code>PROCESSING</code>, <code>INSTALLING</code>, and <code>FULFILLED</code>. 
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