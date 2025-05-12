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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// The DynamoDB reserved capacity configuration used for recommendations.
    /// </summary>
    public partial class DynamoDbReservedCapacityConfiguration
    {
        private string _accountScope;
        private string _capacityUnits;
        private string _monthlyRecurringCost;
        private string _numberOfCapacityUnitsToPurchase;
        private string _paymentOption;
        private string _reservedInstancesRegion;
        private string _service;
        private string _term;
        private string _upfrontCost;

        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope for which you want recommendations.
        /// </para>
        /// </summary>
        public string AccountScope
        {
            get { return this._accountScope; }
            set { this._accountScope = value; }
        }

        // Check to see if AccountScope property is set
        internal bool IsSetAccountScope()
        {
            return this._accountScope != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityUnits. 
        /// <para>
        /// The capacity unit of the recommended reservation.
        /// </para>
        /// </summary>
        public string CapacityUnits
        {
            get { return this._capacityUnits; }
            set { this._capacityUnits = value; }
        }

        // Check to see if CapacityUnits property is set
        internal bool IsSetCapacityUnits()
        {
            return this._capacityUnits != null;
        }

        /// <summary>
        /// Gets and sets the property MonthlyRecurringCost. 
        /// <para>
        /// How much purchasing this reserved capacity costs you on a monthly basis.
        /// </para>
        /// </summary>
        public string MonthlyRecurringCost
        {
            get { return this._monthlyRecurringCost; }
            set { this._monthlyRecurringCost = value; }
        }

        // Check to see if MonthlyRecurringCost property is set
        internal bool IsSetMonthlyRecurringCost()
        {
            return this._monthlyRecurringCost != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfCapacityUnitsToPurchase. 
        /// <para>
        /// The number of reserved capacity units that Amazon Web Services recommends that you
        /// purchase.
        /// </para>
        /// </summary>
        public string NumberOfCapacityUnitsToPurchase
        {
            get { return this._numberOfCapacityUnitsToPurchase; }
            set { this._numberOfCapacityUnitsToPurchase = value; }
        }

        // Check to see if NumberOfCapacityUnitsToPurchase property is set
        internal bool IsSetNumberOfCapacityUnitsToPurchase()
        {
            return this._numberOfCapacityUnitsToPurchase != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option for the commitment.
        /// </para>
        /// </summary>
        public string PaymentOption
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
        /// Gets and sets the property ReservedInstancesRegion. 
        /// <para>
        /// The Amazon Web Services Region of the commitment.
        /// </para>
        /// </summary>
        public string ReservedInstancesRegion
        {
            get { return this._reservedInstancesRegion; }
            set { this._reservedInstancesRegion = value; }
        }

        // Check to see if ReservedInstancesRegion property is set
        internal bool IsSetReservedInstancesRegion()
        {
            return this._reservedInstancesRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The service for which you want recommendations.
        /// </para>
        /// </summary>
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property Term. 
        /// <para>
        /// The reserved capacity recommendation term in years.
        /// </para>
        /// </summary>
        public string Term
        {
            get { return this._term; }
            set { this._term = value; }
        }

        // Check to see if Term property is set
        internal bool IsSetTerm()
        {
            return this._term != null;
        }

        /// <summary>
        /// Gets and sets the property UpfrontCost. 
        /// <para>
        /// How much purchasing this reserved capacity costs you upfront.
        /// </para>
        /// </summary>
        public string UpfrontCost
        {
            get { return this._upfrontCost; }
            set { this._upfrontCost = value; }
        }

        // Check to see if UpfrontCost property is set
        internal bool IsSetUpfrontCost()
        {
            return this._upfrontCost != null;
        }

    }
}