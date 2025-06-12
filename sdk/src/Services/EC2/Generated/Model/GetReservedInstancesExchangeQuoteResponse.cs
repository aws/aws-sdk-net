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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains the output of GetReservedInstancesExchangeQuote.
    /// </summary>
    public partial class GetReservedInstancesExchangeQuoteResponse : AmazonWebServiceResponse
    {
        private string _currencyCode;
        private bool? _isValidExchange;
        private DateTime? _outputReservedInstancesWillExpireAt;
        private string _paymentDue;
        private ReservationValue _reservedInstanceValueRollup;
        private List<ReservedInstanceReservationValue> _reservedInstanceValueSet = AWSConfigs.InitializeCollections ? new List<ReservedInstanceReservationValue>() : null;
        private ReservationValue _targetConfigurationValueRollup;
        private List<TargetReservationValue> _targetConfigurationValueSet = AWSConfigs.InitializeCollections ? new List<TargetReservationValue>() : null;
        private string _validationFailureReason;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency of the transaction.
        /// </para>
        /// </summary>
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property IsValidExchange. 
        /// <para>
        /// If <c>true</c>, the exchange is valid. If <c>false</c>, the exchange cannot be completed.
        /// </para>
        /// </summary>
        public bool? IsValidExchange
        {
            get { return this._isValidExchange; }
            set { this._isValidExchange = value; }
        }

        // Check to see if IsValidExchange property is set
        internal bool IsSetIsValidExchange()
        {
            return this._isValidExchange.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputReservedInstancesWillExpireAt. 
        /// <para>
        /// The new end date of the reservation term.
        /// </para>
        /// </summary>
        public DateTime? OutputReservedInstancesWillExpireAt
        {
            get { return this._outputReservedInstancesWillExpireAt; }
            set { this._outputReservedInstancesWillExpireAt = value; }
        }

        // Check to see if OutputReservedInstancesWillExpireAt property is set
        internal bool IsSetOutputReservedInstancesWillExpireAt()
        {
            return this._outputReservedInstancesWillExpireAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PaymentDue. 
        /// <para>
        /// The total true upfront charge for the exchange.
        /// </para>
        /// </summary>
        public string PaymentDue
        {
            get { return this._paymentDue; }
            set { this._paymentDue = value; }
        }

        // Check to see if PaymentDue property is set
        internal bool IsSetPaymentDue()
        {
            return this._paymentDue != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedInstanceValueRollup. 
        /// <para>
        /// The cost associated with the Reserved Instance.
        /// </para>
        /// </summary>
        public ReservationValue ReservedInstanceValueRollup
        {
            get { return this._reservedInstanceValueRollup; }
            set { this._reservedInstanceValueRollup = value; }
        }

        // Check to see if ReservedInstanceValueRollup property is set
        internal bool IsSetReservedInstanceValueRollup()
        {
            return this._reservedInstanceValueRollup != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedInstanceValueSet. 
        /// <para>
        /// The configuration of your Convertible Reserved Instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReservedInstanceReservationValue> ReservedInstanceValueSet
        {
            get { return this._reservedInstanceValueSet; }
            set { this._reservedInstanceValueSet = value; }
        }

        // Check to see if ReservedInstanceValueSet property is set
        internal bool IsSetReservedInstanceValueSet()
        {
            return this._reservedInstanceValueSet != null && (this._reservedInstanceValueSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetConfigurationValueRollup. 
        /// <para>
        /// The cost associated with the Reserved Instance.
        /// </para>
        /// </summary>
        public ReservationValue TargetConfigurationValueRollup
        {
            get { return this._targetConfigurationValueRollup; }
            set { this._targetConfigurationValueRollup = value; }
        }

        // Check to see if TargetConfigurationValueRollup property is set
        internal bool IsSetTargetConfigurationValueRollup()
        {
            return this._targetConfigurationValueRollup != null;
        }

        /// <summary>
        /// Gets and sets the property TargetConfigurationValueSet. 
        /// <para>
        /// The values of the target Convertible Reserved Instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TargetReservationValue> TargetConfigurationValueSet
        {
            get { return this._targetConfigurationValueSet; }
            set { this._targetConfigurationValueSet = value; }
        }

        // Check to see if TargetConfigurationValueSet property is set
        internal bool IsSetTargetConfigurationValueSet()
        {
            return this._targetConfigurationValueSet != null && (this._targetConfigurationValueSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidationFailureReason. 
        /// <para>
        /// Describes the reason why the exchange cannot be completed.
        /// </para>
        /// </summary>
        public string ValidationFailureReason
        {
            get { return this._validationFailureReason; }
            set { this._validationFailureReason = value; }
        }

        // Check to see if ValidationFailureReason property is set
        internal bool IsSetValidationFailureReason()
        {
            return this._validationFailureReason != null;
        }

    }
}