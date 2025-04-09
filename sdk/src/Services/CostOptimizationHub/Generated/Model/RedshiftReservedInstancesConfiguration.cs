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
    /// The Redshift reserved instances configuration used for recommendations.
    /// </summary>
    public partial class RedshiftReservedInstancesConfiguration
    {
        private string _accountScope;
        private string _currentGeneration;
        private string _instanceFamily;
        private string _instanceType;
        private string _monthlyRecurringCost;
        private string _normalizedUnitsToPurchase;
        private string _numberOfInstancesToPurchase;
        private string _paymentOption;
        private string _reservedInstancesRegion;
        private string _service;
        private bool? _sizeFlexEligible;
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
        /// Gets and sets the property CurrentGeneration. 
        /// <para>
        /// Determines whether the recommendation is for a current generation instance.
        /// </para>
        /// </summary>
        public string CurrentGeneration
        {
            get { return this._currentGeneration; }
            set { this._currentGeneration = value; }
        }

        // Check to see if CurrentGeneration property is set
        internal bool IsSetCurrentGeneration()
        {
            return this._currentGeneration != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        /// The instance family of the recommended reservation.
        /// </para>
        /// </summary>
        public string InstanceFamily
        {
            get { return this._instanceFamily; }
            set { this._instanceFamily = value; }
        }

        // Check to see if InstanceFamily property is set
        internal bool IsSetInstanceFamily()
        {
            return this._instanceFamily != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance that Amazon Web Services recommends.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property MonthlyRecurringCost. 
        /// <para>
        /// How much purchasing these reserved instances costs you on a monthly basis.
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
        /// Gets and sets the property NormalizedUnitsToPurchase. 
        /// <para>
        /// The number of normalized units that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public string NormalizedUnitsToPurchase
        {
            get { return this._normalizedUnitsToPurchase; }
            set { this._normalizedUnitsToPurchase = value; }
        }

        // Check to see if NormalizedUnitsToPurchase property is set
        internal bool IsSetNormalizedUnitsToPurchase()
        {
            return this._normalizedUnitsToPurchase != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfInstancesToPurchase. 
        /// <para>
        /// The number of instances that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public string NumberOfInstancesToPurchase
        {
            get { return this._numberOfInstancesToPurchase; }
            set { this._numberOfInstancesToPurchase = value; }
        }

        // Check to see if NumberOfInstancesToPurchase property is set
        internal bool IsSetNumberOfInstancesToPurchase()
        {
            return this._numberOfInstancesToPurchase != null;
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
        /// Gets and sets the property SizeFlexEligible. 
        /// <para>
        /// Determines whether the recommendation is size flexible.
        /// </para>
        /// </summary>
        public bool? SizeFlexEligible
        {
            get { return this._sizeFlexEligible; }
            set { this._sizeFlexEligible = value; }
        }

        // Check to see if SizeFlexEligible property is set
        internal bool IsSetSizeFlexEligible()
        {
            return this._sizeFlexEligible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Term. 
        /// <para>
        /// The reserved instances recommendation term in years.
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
        /// How much purchasing this instance costs you upfront.
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