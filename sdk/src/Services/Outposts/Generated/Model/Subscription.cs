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
    /// Provides information about your Amazon Web Services Outposts subscriptions.
    /// </summary>
    public partial class Subscription
    {
        private DateTime? _beginDate;
        private DateTime? _endDate;
        private double? _monthlyRecurringPrice;
        private List<string> _orderIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subscriptionId;
        private SubscriptionStatus _subscriptionStatus;
        private SubscriptionType _subscriptionType;
        private double? _upfrontPrice;

        /// <summary>
        /// Gets and sets the property BeginDate. 
        /// <para>
        /// The date your subscription starts.
        /// </para>
        /// </summary>
        public DateTime? BeginDate
        {
            get { return this._beginDate; }
            set { this._beginDate = value; }
        }

        // Check to see if BeginDate property is set
        internal bool IsSetBeginDate()
        {
            return this._beginDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date your subscription ends.
        /// </para>
        /// </summary>
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonthlyRecurringPrice. 
        /// <para>
        /// The amount you are billed each month in the subscription period.
        /// </para>
        /// </summary>
        public double? MonthlyRecurringPrice
        {
            get { return this._monthlyRecurringPrice; }
            set { this._monthlyRecurringPrice = value; }
        }

        // Check to see if MonthlyRecurringPrice property is set
        internal bool IsSetMonthlyRecurringPrice()
        {
            return this._monthlyRecurringPrice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrderIds. 
        /// <para>
        /// The order ID for your subscription.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OrderIds
        {
            get { return this._orderIds; }
            set { this._orderIds = value; }
        }

        // Check to see if OrderIds property is set
        internal bool IsSetOrderIds()
        {
            return this._orderIds != null && (this._orderIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The ID of the subscription that appears on the Amazon Web Services Billing Center
        /// console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }

        // Check to see if SubscriptionId property is set
        internal bool IsSetSubscriptionId()
        {
            return this._subscriptionId != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionStatus. 
        /// <para>
        /// The status of subscription which can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>INACTIVE</b> - Subscription requests that are inactive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ACTIVE</b> - Subscription requests that are in progress and have an end date in
        /// the future.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CANCELLED</b> - Subscription requests that are cancelled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SubscriptionStatus SubscriptionStatus
        {
            get { return this._subscriptionStatus; }
            set { this._subscriptionStatus = value; }
        }

        // Check to see if SubscriptionStatus property is set
        internal bool IsSetSubscriptionStatus()
        {
            return this._subscriptionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionType. 
        /// <para>
        /// The type of subscription which can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ORIGINAL</b> - The first order on the Amazon Web Services Outposts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>RENEWAL</b> - Renewal requests, both month to month and longer term.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CAPACITY_INCREASE</b> - Capacity scaling orders.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SubscriptionType SubscriptionType
        {
            get { return this._subscriptionType; }
            set { this._subscriptionType = value; }
        }

        // Check to see if SubscriptionType property is set
        internal bool IsSetSubscriptionType()
        {
            return this._subscriptionType != null;
        }

        /// <summary>
        /// Gets and sets the property UpfrontPrice. 
        /// <para>
        /// The amount billed when the subscription is created. This is a one-time charge.
        /// </para>
        /// </summary>
        public double? UpfrontPrice
        {
            get { return this._upfrontPrice; }
            set { this._upfrontPrice = value; }
        }

        // Check to see if UpfrontPrice property is set
        internal bool IsSetUpfrontPrice()
        {
            return this._upfrontPrice.HasValue; 
        }

    }
}